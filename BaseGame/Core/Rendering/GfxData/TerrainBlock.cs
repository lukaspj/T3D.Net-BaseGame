using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Rendering.GfxData
{
   public class TerrainBlock
   {
      public static void Init() {
         new ShaderData("CubemapSaveShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/terrain/blendV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/terrain/blendP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/terrain/gl/blendV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/terrain/gl/blendP.glsl",

            SamplerNames = {
               [0] = "layerTex",
               [1] = "textureMap",
            },

            PixVersion = 3.0f
         }.RegisterSingleton();
      }
   }
}
