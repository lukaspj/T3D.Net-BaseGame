using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Rendering.GfxData
{
   public class ScatterSky
   {
      public static void Init() {
         //------------------------------------------------------------------------------
         // CloudLayer
         //------------------------------------------------------------------------------
         new GFXStateBlockData("ScatterSkySBData") {
            CullMode = GFXCullMode.GFXCullNone,

            ZDefined = true,
            ZEnable = true,
            ZWriteEnable = false,

            SamplersDefined = true,
            SamplerStates = {
               [0] = CommonMaterialData.SamplerClampLinear,
               [1] = CommonMaterialData.SamplerClampLinear
            },
            VertexColorEnable = true,
         }.RegisterSingleton();

         //------------------------------------------------------------------------------
         // BasicClouds
         //------------------------------------------------------------------------------
         new ShaderData("ScatterSkyShaderData") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/scatterSkyV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/scatterSkyP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/scatterSkyV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/scatterSkyP.glsl",

            SamplerNames = {[0] = "$nightSky"},

            PixVersion = 2.0f
         }.RegisterSingleton();
      }
   }
}
