using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Zoom {
      public static float PlayerCurrentFOV {
         get => Global.GetConsoleFloat("Player::CurrentFOV");
         set => Global.SetConsoleFloat("Player::CurrentFOV", value);
      }
      
      [ConsoleFunction]
      public static void ToggleZoomFOV(float val) {
         PlayerCurrentFOV = PlayerCurrentFOV / 2;

         if (PlayerCurrentFOV < 5) {
            ResetCurrentFOV();
         }

         if (GenericMarshal.StringToBool(Core.SimObjects.Server.ServerConnection.GetFieldValue("zoomed"))) {
            Global.SetFov(PlayerCurrentFOV);
         } else {
            Global.SetFov(Core.SimObjects.Server.ServerConnection.GetControlCameraDefaultFov());
         }
      }
      
      [ConsoleFunction]
      public static void ResetCurrentFOV() {
         PlayerCurrentFOV = Core.SimObjects.Server.ServerConnection.GetControlCameraDefaultFov() / 2;
      }
      
      [ConsoleFunction]
      public static void TurnOffZoom() {
         Core.SimObjects.Server.ServerConnection.SetFieldValue("zoomed", "false");
         Global.SetFov(Core.SimObjects.Server.ServerConnection.GetControlCameraDefaultFov());
         
         Core.Functions.Rendering.PostFX.UpdateDOFSettings();
      }
      
      [ConsoleFunction]
      public static void SetZoomFOV(float val) {
         if (val > 0) {
            ToggleZoomFOV(val);
         }
      }
      
      [ConsoleFunction]
      public static void ToggleZoom(float val) {
         if (val > 0) {
            Core.SimObjects.Server.ServerConnection.SetFieldValue("zoomed", "true");
            Global.SetFov(PlayerCurrentFOV);

            PostEffect dofPostEffect = Core.SimObjects.Rendering.PostFX.DOFPostEffect;

            dofPostEffect.Call("setAutoFocus", "true");
            dofPostEffect.Call("setFocusParams", "0.5", "0.5", "50", "500", "-5", "5");
            dofPostEffect.Enable();
         } else {
            TurnOffZoom();
         }
      }
   }
}