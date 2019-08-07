using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Rendering.GfxData
{
   public class Clouds
   {
      public static void Init() {
         //------------------------------------------------------------------------------
         // CloudLayer
         //------------------------------------------------------------------------------
         new ShaderData("CloudLayerShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/cloudLayerV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/cloudLayerP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/cloudLayerV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/cloudLayerP.glsl",

            SamplerNames = {[0] = "$normalHeightMap"},

            PixVersion = 2.0f
         }.RegisterSingleton();

         //------------------------------------------------------------------------------
         // BasicClouds
         //------------------------------------------------------------------------------
         new ShaderData("BasicCloudsShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/basicCloudsV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/basicCloudsP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/basicCloudsV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/basicCloudsP.glsl",

            SamplerNames = {[0] = "$diffuseMap"},

            PixVersion = 2.0f
         }.RegisterSingleton();
      }
   }
}
