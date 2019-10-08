using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Debug {
      [ConsoleFunction]
      public static void StartRecordingDemo(float val) {
         if (val > 0) {
            Core.Functions.Debug.StartDemoRecord();
         }
      }
      
      [ConsoleFunction]
      public static void StopRecordingDemo(float val) {
         if (val > 0) {
            Core.Functions.Debug.StopDemoRecord();
         }
      }
      
      [ConsoleFunction]
      public static void BringUpOptions(float val) {
         if (val > 0) {
            Core.SimObjects.UI.Canvas.PushDialog("OptionsDlg");
         }
      }
      
      [ConsoleFunction]
      public static void ShowMetrics(float val) {
         if (val > 0) {
            Core.Functions.Debug.Metrics("fps", "gfx", "shadow", "sfx", "terrain", "groundcover", "forest", "net");
         }
      }
      
      [ConsoleFunction]
      public static void DoProfile(float val) {
         if (val > 0) {
            // key down -- start profile
            Global.Echo("Starting profile session...");
            Global.ProfilerReset();
            Global.ProfilerEnable(true);
         } else {
            // key up -- finish off profile
            Global.Echo("Ending profile session...");

            Global.ProfilerDumpToFile("profilerDumpToFile" + Global.GetSimTime() + ".txt");
            Global.ProfilerEnable(false);
         }
      }
   }
}