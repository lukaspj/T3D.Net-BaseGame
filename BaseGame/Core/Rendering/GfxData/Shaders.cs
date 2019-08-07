using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;

namespace Game.Core.Rendering.GfxData
{
   public class Shaders
   {
      public static ShaderData PFX_PassthruShader { get; set; }

      public static void Init() {
         PFX_PassthruShader = new ShaderData("PFX_PassthruShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/postFxV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/passthruP.hlsl",
            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/gl/postFxV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/gl/passthruP.glsl",

            SamplerNames = {[0] = "$inputTex"},

            PixVersion = 2.0f
         };
      }
   }
}
