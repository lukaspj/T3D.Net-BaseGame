using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Game.Core.Gui
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
