using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.Rendering
{
   [ConsoleClass("Core_Rendering")]
   public class CoreRendering : SimSet
   {
      public void onCreate() {
         Global.SetConsoleString("Core::MissingTexturePath", "core/rendering/images/missingTexture");
         Global.SetConsoleString("Core::UnAvailableTexturePath", "core/rendering/images/unavailable");
         Global.SetConsoleString("Core::WarningTexturePath", "core/rendering/images/warnMat");
         Global.SetConsoleString("Core::CommonShaderPath", "core/rendering/shaders");

         GfxData.Shaders.Init();
         GfxData.CommonMaterialData.Init();
         RenderManager.Init();
         GfxData.Clouds.Init();
         GfxData.ScatterSky.Init();
         GfxData.TerrainBlock.Init();
         GfxData.Water.Init();
      }

      public void onDestroy() {
      }
   }
}
