using System;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Movement {
      [ConsoleFunction]
      public static void EscapeFromGame() {
         Core.Functions.ServerConnection.Disconnect();
      }

      [ConsoleFunction]
      public static void SetSpeed(float speed) {
         Global.SetConsoleFloat("movementSpeed", speed);
      }

      [ConsoleFunction]
      public static void MoveLeft(float val) {
         Global.SetConsoleFloat("mvLeftAction", val * Global.GetConsoleFloat("movementSpeed"));
      }

      [ConsoleFunction]
      public static void MoveRight(float val) {
         Global.SetConsoleFloat("mvRightAction", val * Global.GetConsoleFloat("movementSpeed"));
      }

      [ConsoleFunction]
      public static void MoveForward(float val) {
         Global.SetConsoleFloat("mvForwardAction", val * Global.GetConsoleFloat("movementSpeed"));
      }

      [ConsoleFunction]
      public static void MoveBackward(float val) {
         Global.SetConsoleFloat("mvBackwardAction", val * Global.GetConsoleFloat("movementSpeed"));
      }

      [ConsoleFunction]
      public static void MoveUp(float val) {
         GameBase controlObject = Core.SimObjects.Server.ServerConnection.GetControlObject();

         if (controlObject.IsInNamespaceHierarchy("Camera")) {
            Global.SetConsoleFloat("mvUpAction", val * Global.GetConsoleFloat("movementSpeed"));
         }
      }

      [ConsoleFunction]
      public static void MoveDown(float val) {
         GameBase controlObject = Core.SimObjects.Server.ServerConnection.GetControlObject();

         if (controlObject.IsInNamespaceHierarchy("Camera")) {
            Global.SetConsoleFloat("mvDownAction", val * Global.GetConsoleFloat("movementSpeed"));
         }
      }

      [ConsoleFunction]
      public static void TurnLeft(float val) {
         if (val > 0) {
            Global.SetConsoleFloat("mvYawRightSpeed", Global.GetConsoleFloat("Pref::Input::KeyboardTurnSpeed"));
         } else {
            Global.SetConsoleFloat("mvYawRightSpeed", 0);
         }
      }

      [ConsoleFunction]
      public static void TurnRight(float val) {
         if (val > 0) {
            Global.SetConsoleFloat("mvYawLeftSpeed", Global.GetConsoleFloat("Pref::Input::KeyboardTurnSpeed"));
         } else {
            Global.SetConsoleFloat("mvYawLeftSpeed", 0);
         }
      }

      [ConsoleFunction]
      public static void PanUp(float val) {
         if (val > 0) {
            Global.SetConsoleFloat("mvPitchDownSpeed", Global.GetConsoleFloat("Pref::Input::KeyboardTurnSpeed"));
         } else {
            Global.SetConsoleFloat("mvPitchDownSpeed", 0);
         }
      }

      [ConsoleFunction]
      public static void PanDown(float val) {
         if (val > 0) {
            Global.SetConsoleFloat("mvPitchUpSpeed", Global.GetConsoleFloat("Pref::Input::KeyboardTurnSpeed"));
         } else {
            Global.SetConsoleFloat("mvPitchUpSpeed", 0);
         }
      }

      [ConsoleFunction]
      public static float GetVerticalMouseAdjustAmount(float val) {
         float sensitivity = Global.GetConsoleFloat("pref::Input::VertMouseSensitivity");
         
         // based on a default camera FOV of 90'
         if (GenericMarshal.StringToBool(Core.SimObjects.Server.ServerConnection.GetFieldValue("zoomed"))) {
            sensitivity = Global.GetConsoleFloat("pref::Input::ZoomVertMouseSensitivity");
         }

         if (Global.GetConsoleBool("pref::Input::invertVerticalMouse")) {
            sensitivity *= -1;
         }
      
         return val * (Global.GetConsoleFloat("cameraFov") / 90f) * 0.01f * sensitivity;
      }

      [ConsoleFunction]
      public static float GetHorizontalMouseAdjustAmount(float val) {
         float sensitivity = Global.GetConsoleFloat("pref::Input::HorzMouseSensitivity");
         
         // based on a default camera FOV of 90'
         if (GenericMarshal.StringToBool(Core.SimObjects.Server.ServerConnection.GetFieldValue("zoomed"))) {
            sensitivity = Global.GetConsoleFloat("pref::Input::ZoomHorzMouseSensitivity");
         }

         return val * (Global.GetConsoleFloat("cameraFov") / 90f) * 0.01f * sensitivity;
      }

      [ConsoleFunction]
      public static float GetRollMouseAdjustAmount(float val) {
         float sensitivity = Global.GetConsoleFloat("pref::Input::RollMouseSensitivity");

         return val * (Global.GetConsoleFloat("cameraFov") / 90f) * 0.01f * sensitivity;
      }

      [ConsoleFunction]
      public static void Yaw(float val) {
         float yawAdj = GetHorizontalMouseAdjustAmount(val);

         if (Core.SimObjects.Server.ServerConnection.IsControlObjectRotDampedCamera()) {
            // Clamp and scale
            yawAdj = (float) Math.Clamp(yawAdj, -2*Math.PI+0.01f, 2*Math.PI-0.01f);
            yawAdj *= 0.5f;
         }

         Global.SetConsoleFloat("mvYaw", Global.GetConsoleFloat("mvYaw") + yawAdj);
      }

      [ConsoleFunction]
      public static void Pitch(float val) {
         float pitchAdj = GetVerticalMouseAdjustAmount(val);

         if (Core.SimObjects.Server.ServerConnection.IsControlObjectRotDampedCamera()) {
            // Clamp and scale
            pitchAdj = (float) Math.Clamp(pitchAdj, -2*Math.PI+0.01f, 2*Math.PI-0.01f);
            pitchAdj *= 0.5f;
         }

         Global.SetConsoleFloat("mvPitch", Global.GetConsoleFloat("mvPitch") + pitchAdj);
      }

      [ConsoleFunction]
      public static void Jump(float val) {
         Global.SetConsoleInt("mvTriggerCount2", Global.GetConsoleInt("mvTriggerCount2") + 1);
      }
   }
}