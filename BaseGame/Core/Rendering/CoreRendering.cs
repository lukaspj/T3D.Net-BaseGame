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

         GfxData.Clouds.Init();
         GfxData.CommonMaterialData.Init();
         GfxData.ScatterSky.Init();
         GfxData.Shaders.Init();
         GfxData.TerrainBlock.Init();
         GfxData.Water.Init();
      }

      public void onDestroy() {
      }
   }
}
