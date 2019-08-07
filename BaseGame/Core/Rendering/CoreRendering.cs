using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Game.Core.Rendering
{
   [ConsoleClass("Core_Rendering")]
   public class CoreRendering : SimSet
   {
      public void onCreate() {
         Global.SetConsoleString("Core::MissingTexturePath", "core/rendering/images/missingTexture");
         Global.SetConsoleString("Core::UnAvailableTexturePath", "core/rendering/images/unavailable");
         Global.SetConsoleString("Core::WarningTexturePath", "core/rendering/images/warnMat");
         Global.SetConsoleString("Core::CommonShaderPath", "core/rendering/shaders");

         Global.Exec("core/rendering/scripts/renderManager.cs");
         Global.Exec("core/rendering/scripts/gfxData/clouds.cs");
         Global.Exec("core/rendering/scripts/gfxData/commonMaterialData.cs");
         Global.Exec("core/rendering/scripts/gfxData/scatterSky.cs");
         Global.Exec("core/rendering/scripts/gfxData/shaders.cs");
         Global.Exec("core/rendering/scripts/gfxData/terrainBlock.cs");
         Global.Exec("core/rendering/scripts/gfxData/water.cs");
      }

      public void onDestroy() {
      }
   }
}
