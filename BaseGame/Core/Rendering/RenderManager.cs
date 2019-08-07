using Game.Core.Rendering.GfxData;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Functions;

namespace Game.Core.Rendering
{
   public class RenderManager
   {
      public static RenderPassManager DiffuseRenderPassManager { get; private set; }

      /// <summary>
      ///    This is the Default PostFX state block. Put here to prevent any missing object
      ///    errors for below dependencies
      /// </summary>
      public static GFXStateBlockData PFX_DefaultStateBlock { get; private set; }

      /// <summary>
      ///    This post effect is used to copy data from the non-MSAA back-buffer to the
      ///    device back buffer (which could be MSAA). It must be declared here so that
      ///    it is initialized when 'AL_FormatToken' is initialzed.
      /// </summary>
      public static GFXStateBlockData AL_FormatTokenState { get; private set; }

      /// <summary>
      ///    This PostEffect is used by 'AL_FormatToken' directly. It is never added to
      ///    the PostEffectManager. Do not call enable() on it.
      /// </summary>
      public static PostEffect AL_FormatCopy { get; private set; }

      public static RenderFormatToken AL_FormatToken { get; private set; }

      public static void Init() {
         Global.Assert(!Global.IsObject("DiffuseRenderPassManager"),
            "initRenderManager() - DiffuseRenderPassManager already initialized!");

         DiffuseRenderPassManager = new RenderPassManager("DiffuseRenderPassManager");
         Global.Assert(DiffuseRenderPassManager.RegisterSingleton(), "Failed to instantiate DiffuseRenderPassManager");

         PFX_DefaultStateBlock = new GFXStateBlockData("PFX_DefaultStateBlock") {
            ZDefined = true,
            ZEnable = false,
            ZWriteEnable = false,

            SamplersDefined = true,
            SamplerStates = {[0] = CommonMaterialData.SamplerClampLinear}
         };
         Global.Assert(PFX_DefaultStateBlock.RegisterSingleton(), "Failed to instantiate PFX_DefaultStateBlock");

         AL_FormatTokenState = new GFXStateBlockData("AL_FormatTokenState", PFX_DefaultStateBlock) {
            SamplersDefined = true,
            SamplerStates = {[0] = CommonMaterialData.SamplerClampPoint}
         };
         Global.Assert(AL_FormatTokenState.RegisterSingleton(), "Failed to instantiate AL_FormatTokenState");

         AL_FormatCopy = new PostEffect("AL_FormatCopy") {
            Enabled = false,
            AllowReflectPass = true,

            Shader = Shaders.PFX_PassthruShader,
            StateBlock = AL_FormatTokenState,

            Texture = {[0] = "$inTex"},
            Target = "$backBuffer"
         };

         // This token, and the associated render managers, ensure that driver MSAA
         // does not get used for Advanced Lighting renders.  The 'AL_FormatResolve'
         // PostEffect copies the result to the backbuffer.
         AL_FormatToken = new RenderFormatToken(AL_FormatToken) {
            Enabled = false,

            //When hdr is enabled this will be changed to the appropriate format
            Format = GFXFormat.GFXFormatR8G8B8A8_SRGB,
            DepthFormat = GFXFormat.GFXFormatD24S8,
            AaLevel = 0, // -1 = match backbuffer

            // The contents of the back buffer before this format token is executed
            // is provided in $inTex
            CopyEffect = AL_FormatCopy,

            // The contents of the render target created by this format token is
            // provided in $inTex
            ResolveEffect = AL_FormatCopy
         };
         DiffuseRenderPassManager.AddManager(new RenderPassStateBin
            {RenderOrder = 0.001f, StateToken = AL_FormatToken});

         // We really need to fix the sky to render after all the
         // meshes... but that causes issues in reflections.
         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("SkyBin")
            {BinType = "Sky", RenderOrder = 0.1f, ProcessAddOrder = 0.1f});

         //DiffuseRenderPassManager.AddManager( new RenderVistaMgr()               { bintype = "Vista"; renderOrder = 0.15; processAddOrder = 0.15; } );

         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("BeginBin")
            {BinType = "Begin", RenderOrder = 0.2f, ProcessAddOrder = 0.2f});
         // Normal mesh rendering.
         DiffuseRenderPassManager.AddManager(new RenderTerrainMgr("TerrainBin")
            {RenderOrder = 0.4f, ProcessAddOrder = 0.4f, BasicOnly = true});
         DiffuseRenderPassManager.AddManager(new RenderMeshMgr("MeshBin")
            {BinType = "Mesh", RenderOrder = 0.5f, ProcessAddOrder = 0.5f, BasicOnly = true});
         DiffuseRenderPassManager.AddManager(new RenderImposterMgr("ImposterBin")
            {RenderOrder = 0.56f, ProcessAddOrder = 0.56f});
         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("ObjectBin")
            {BinType = "Object", RenderOrder = 0.6f, ProcessAddOrder = 0.6f});

         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("ShadowBin")
            {BinType = "Shadow", RenderOrder = 0.7f, ProcessAddOrder = 0.7f});
         DiffuseRenderPassManager.AddManager(new RenderMeshMgr("DecalRoadBin")
            {BinType = "DecalRoad", RenderOrder = 0.8f, ProcessAddOrder = 0.8f});
         DiffuseRenderPassManager.AddManager(new RenderMeshMgr("DecalBin")
            {BinType = "Decal", RenderOrder = 0.81f, ProcessAddOrder = 0.81f});
         DiffuseRenderPassManager.AddManager(new RenderOcclusionMgr("OccluderBin")
            {BinType = "Occluder", RenderOrder = 0.9f, ProcessAddOrder = 0.9f});

         // We now render translucent objects that should handle
         // their own fogging and lighting.

         // Note that the fog effect is triggered before this bin.
         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("ObjTranslucentBin")
            {BinType = "ObjectTranslucent", RenderOrder = 1.0f, ProcessAddOrder = 1.0f});

         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("WaterBin")
            {BinType = "Water", RenderOrder = 1.2f, ProcessAddOrder = 1.2f});
         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("FoliageBin")
            {BinType = "Foliage", RenderOrder = 1.3f, ProcessAddOrder = 1.3f});
         DiffuseRenderPassManager.AddManager(new RenderParticleMgr("ParticleBin")
            {RenderOrder = 1.35f, ProcessAddOrder = 1.35f});
         DiffuseRenderPassManager.AddManager(new RenderTranslucentMgr("TranslucentBin")
            {RenderOrder = 1.4f, ProcessAddOrder = 1.4f});

         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("FogBin")
            {BinType = "ObjectVolumetricFog", RenderOrder = 1.45f, ProcessAddOrder = 1.45f});

         // Note that the GlowPostFx is triggered after this bin.
         DiffuseRenderPassManager.AddManager(new RenderGlowMgr("GlowBin")
            {RenderOrder = 1.5f, ProcessAddOrder = 1.5f});

         // We render any editor stuff from this bin.  Note that the HDR is
         // completed before this bin to keep editor elements from tone mapping.
         DiffuseRenderPassManager.AddManager(new RenderObjectMgr("EditorBin")
            {BinType = "Editor", RenderOrder = 1.6f, ProcessAddOrder = 1.6f});

         // Resolve format change token last.
         DiffuseRenderPassManager.AddManager(new RenderPassStateBin("FinalBin")
            {RenderOrder = 1.7f, StateToken = AL_FormatToken});
      }
   }
}
