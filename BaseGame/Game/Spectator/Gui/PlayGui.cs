using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Structs;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Gui {
   [ConsoleClass]
   public class PlayGui : GuiTSCtrl {
      public override void OnWake() {
         // Turn off any shell sounds...
         // sfxStop( ... );

         Global.SetConsoleBool("enableDirectInput", true);
         Global.ActivateDirectInput();

         // Message hud dialog
         if (Global.IsObject("MainChatHud")) {
            Core.SimObjects.UI.Canvas.PushDialog("MainChatHud");
         }

         // just update the action map here
         Sim.FindObjectByName<ActionMap>("moveMap").Push();

         // hack city - these controls are floating around and need to be clamped
         if (Global.IsFunction("refreshCenterTextCtrl"))
            Global.Schedule("0", "0", "refreshCenterTextCtrl");
         if (Global.IsFunction("refreshBottomTextCtrl"))
            Global.Schedule("0", "0", "refreshBottomTextCtrl");
      }

      public override void OnSleep() {
         if (Global.IsObject("MainChatHud")) {
            Core.SimObjects.UI.Canvas.PopDialog(Sim.FindObjectByName<GuiControl>("MainChatHud"));
         }

         // pop the keymaps
         Sim.FindObjectByName<ActionMap>("moveMap").Pop();
      }

      public void ClearHud() {
         if (Global.IsObject("MainChatHud")) {
            Core.SimObjects.UI.Canvas.PopDialog(Sim.FindObjectByName<GuiControl>("MainChatHud"));
         }

         while (GetCount() > 0) {
            GetObject(0).Delete();
         }
      }

      [ConsoleFunction]
      public static void RefreshBottomTextCtrl() {
         if (Global.IsObject("BottomPrintText")) {
            Sim.FindObjectByName<GuiTextCtrl>("BottomPrintText").Position = new Point2I(0, 0);
         }
      }

      [ConsoleFunction]
      public static void RefreshCenterTextCtrl() {
         if (Global.IsObject("CenterPrintText")) {
            Sim.FindObjectByName<GuiTextCtrl>("CenterPrintText").Position = new Point2I(0, 0);
         }
      }
   }
}