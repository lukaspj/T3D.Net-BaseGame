using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Trigger {
      [ConsoleFunction]
      public static void MouseFire(int val) {
         Global.SetConsoleInt("mvTriggerCount0", Global.GetConsoleInt("mvTriggerCount0") + 1);
      }
      
      [ConsoleFunction]
      public static void AltTrigger(int val) {
         Global.SetConsoleInt("mvTriggerCount1", Global.GetConsoleInt("mvTriggerCount1") + 1);
         
         Zoom.ToggleZoom(val);
      }
   }
}