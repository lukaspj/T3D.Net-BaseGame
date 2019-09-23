using T3DNetFramework.Engine.Structs;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Rendering.GfxData
{
   public class Water
   {
      public static void Init() {
         //-----------------------------------------------------------------------------
         // Water
         //-----------------------------------------------------------------------------
         ShaderData WaterShader = new ShaderData("WaterShader")
         {
             DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/waterV.hlsl",
             DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/waterP.hlsl",

             OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/gl/waterV.glsl",
             OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/gl/waterP.glsl",

             SamplerNames =
             {
                 [0] = "$bumpMap", // noise
                 [1] = "$deferredTex", // #deferred
                 [2] = "$reflectMap", // $reflectbuff
                 [3] = "$refractBuff", // $backbuff
                 [4] = "$skyMap", // $cubemap
                 [5] = "$foamMap", // foam
                 [6] = "$depthGradMap", // depthMap ( color gradient )
             },

             PixVersion = 3.0f
         };
         WaterShader.RegisterSingleton();

         var WaterSampler = new GFXSamplerStateData("WaterSampler") {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterAnisotropic,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MaxAnisotropy = 4,
         };
         WaterSampler.RegisterSingleton();

         var WaterStateBlock = new GFXStateBlockData("WaterStateBlock") {
            SamplersDefined = true,
            SamplerStates = {
               [0] = WaterSampler,
               [1] = CommonMaterialData.SamplerClampPoint,
               [2] = CommonMaterialData.SamplerClampLinear,
               [3] = CommonMaterialData.SamplerClampPoint,
               [4] = CommonMaterialData.SamplerWrapLinear,
               [5] = CommonMaterialData.SamplerWrapLinear,
               [6] = CommonMaterialData.SamplerClampLinear,
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullCCW,
         };
         WaterStateBlock.RegisterSingleton();

         var UnderWaterStateBlock = new GFXStateBlockData("UnderWaterStateBlock", WaterStateBlock) {
            CullMode = GFXCullMode.GFXCullCW,
         };
         UnderWaterStateBlock.RegisterSingleton();

         var WaterMat = new CustomMaterial("WaterMat") {
            Shader = "WaterShader",
            StateBlock = WaterStateBlock,
            Version = 3.0f,
            UseAnisotropic = {[0] = true}
         };

         WaterMat.SetFieldValue("sampler[deferredTex]", "#deferred");
         WaterMat.SetFieldValue("sampler[reflectMap]", "$reflectbuff");
         WaterMat.SetFieldValue("sampler[refractBuff]", "$backbuff");
         // These samplers are set in code not here.
         // This is to allow different WaterObject instances
         // to use this same material but override these textures
         // per instance.
         //sampler["bumpMap"] = "";
         //sampler["skyMap"] = "";
         //sampler["foamMap"] = "";
         //sampler["depthGradMap"] = "";
         WaterMat.RegisterSingleton();

         //-----------------------------------------------------------------------------
         // Underwater
         //-----------------------------------------------------------------------------

         new ShaderData("UnderWaterShader", WaterShader)
         {
            Defines = "UNDERWATER"
         }.RegisterSingleton();

         CustomMaterial UnderwaterMat = new CustomMaterial("UnderwaterMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.
            //sampler["bumpMap"] = "art/images/water/noise02";
            //sampler["foamMap"] = "art/images/water/foam";

            Shader = "UnderWaterShader",
            StateBlock = UnderWaterStateBlock,
            Specular = {[0] = new LinearColorF(0.75f, 0.75f, 0.75f, 1.0f)},
            SpecularPower = {[0] = 48.0f},
            Version = 3.0f
         };
         UnderwaterMat.SetFieldValue("sampler[deferredTex]", "#deferred");
         UnderwaterMat.SetFieldValue("sampler[refractBuff]", "$backbuff");
         UnderwaterMat.RegisterSingleton();
         //-----------------------------------------------------------------------------
         // Basic Water
         //-----------------------------------------------------------------------------

         ShaderData WaterBasicShader = new ShaderData("WaterBasicShader")
         {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/waterBasicV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/waterBasicP.hlsl",
            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/gl/waterBasicV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/water/gl/waterBasicP.glsl",
            SamplerNames =
            {
               [0] = "$bumpMap",
               [2] = "$reflectMap",
               [3] = "$refractBuff",
               [4] = "$skyMap",
               [5] = "$depthGradMap"
            },
            PixVersion = 2.0f
         };
         WaterBasicShader.RegisterSingleton();

         GFXStateBlockData WaterBasicStateBlock = new GFXStateBlockData("WaterBasicStateBlock")
         {
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = WaterSampler, // noise
               [2] = CommonMaterialData.SamplerClampLinear, // $reflectbuff
               [3] = CommonMaterialData.SamplerClampPoint, // $backbuff
               [4] = CommonMaterialData.SamplerWrapLinear // $cubemap
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullCCW
         };
         WaterBasicStateBlock.RegisterSingleton();

         GFXStateBlockData UnderWaterBasicStateBlock = new GFXStateBlockData("UnderWaterBasicStateBlock",
            WaterBasicStateBlock)
         {
            CullMode = GFXCullMode.GFXCullCW
         };
         UnderWaterBasicStateBlock.RegisterSingleton();

         CustomMaterial WaterBasicMat = new CustomMaterial("WaterBasicMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.
            //sampler["bumpMap"] = "art/images/water/noise02";
            //sampler["skyMap"] = "$cubemap";

            //sampler["prepassTex"] = "#prepass";

            Cubemap = "NewLevelSkyCubemap",
            Shader = "WaterBasicShader",
            StateBlock = WaterBasicStateBlock,
            Version = 2.0f
         };
         WaterBasicMat.SetFieldValue("sampler[reflectMap]", "$reflectbuff");
         WaterBasicMat.SetFieldValue("sampler[refractBuff]", "$backbuff");
         WaterBasicMat.RegisterSingleton();

         //-----------------------------------------------------------------------------
         // Basic UnderWater
         //-----------------------------------------------------------------------------

         new ShaderData("UnderWaterBasicShader", WaterBasicShader)
         {
            Defines = "UNDERWATER"
         }.RegisterSingleton();

         CustomMaterial UnderwaterBasicMat = new CustomMaterial("UnderwaterBasicMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.
            //sampler["bumpMap"] = "art/images/water/noise02";
            //samplers["skyMap"] = "$cubemap";

            //sampler["prepassTex"] = "#prepass";

            Shader = "UnderWaterBasicShader",
            StateBlock = UnderWaterBasicStateBlock,
            Version = 2.0f
         };
         UnderwaterBasicMat.SetFieldValue("sampler[refractBuff]", "$backbuff");
         UnderwaterBasicMat.RegisterSingleton();
      }
   }
}
