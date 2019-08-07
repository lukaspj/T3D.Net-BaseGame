using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.Gui
{
   [ConsoleClass("Core_GUI")]
   public class CoreGui : SimSet
   {
      public void onCreate() {
         Global.Exec("core/gui/scripts/profiles.cs");
         Global.Exec("core/gui/scripts/canvas.cs");
         Global.Exec("core/gui/scripts/cursor.cs");
      }

      public void onDestroy() {
      }
   }
}
