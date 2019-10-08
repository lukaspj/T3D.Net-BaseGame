using System;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class GamePad {
      [ConsoleFunction]
      public static float GetGamepadAdjustAmount(float val) {
         float sensitivity = Global.GetConsoleFloat("pref::Input::RollMouseSensitivity");

         return val * (Global.GetConsoleFloat("cameraFov") / 90f) * 0.01f * 10.0f;
      }
      
      [ConsoleFunction]
      public static void GamePadMoveX(float val) {
         Global.SetConsoleFloat("mvXAxis_L", val);
      }

      [ConsoleFunction]
      public static void GamePadMoveY(float val) {
         Global.SetConsoleFloat("mvYAxis_L", val);
      }

      [ConsoleFunction]
      public static void GamePadYaw(float val) {
         float yawAdj = GetGamepadAdjustAmount(val);

         if (Core.SimObjects.Server.ServerConnection.IsControlObjectRotDampedCamera()) {
            // Clamp and scale
            yawAdj = (float) Math.Clamp(yawAdj, -2*Math.PI+0.01f, 2*Math.PI-0.01f);
            yawAdj *= 0.5f;
         }

         Global.SetConsoleFloat("mvYaw", Global.GetConsoleFloat("mvYaw") + yawAdj);
            
         if(yawAdj > 0)
         {
            Global.SetConsoleFloat("mvYawLeftSpeed", yawAdj);
            Global.SetConsoleFloat("mvYawRightSpeed", 0);
         }
         else
         {
            Global.SetConsoleFloat("mvYawLeftSpeed", 0);
            Global.SetConsoleFloat("mvYawRightSpeed", -yawAdj);
         }
      }

      [ConsoleFunction]
      public static void GamePadPitch(float val) {
         float pitchAdj = GetGamepadAdjustAmount(val);

         if (Core.SimObjects.Server.ServerConnection.IsControlObjectRotDampedCamera()) {
            // Clamp and scale
            pitchAdj = (float) Math.Clamp(pitchAdj, -2*Math.PI+0.01f, 2*Math.PI-0.01f);
            pitchAdj *= 0.5f;
         }

         Global.SetConsoleFloat("mvYaw", Global.GetConsoleFloat("mvYaw") + pitchAdj);
            
         if(pitchAdj > 0)
         {
            Global.SetConsoleFloat("mvPitchDownSpeed", pitchAdj);
            Global.SetConsoleFloat("mvPitchUpSpeed", 0);
         }
         else
         {
            Global.SetConsoleFloat("mvPitchDownSpeed", 0);
            Global.SetConsoleFloat("mvPitchUpSpeed", -pitchAdj);
         }
      }

      [ConsoleFunction]
      public static void GamePadFire(float val) {
         if(val > 0.1 && !Global.GetConsoleBool("gamepadFireTriggered"))
         {
            Global.SetConsoleBool("gamepadFireTriggered", true);
            Global.SetConsoleInt("mvTriggerCount0", Global.GetConsoleInt("mvTriggerCount0") + 1);
         }
         else if(val <= 0.1 && Global.GetConsoleBool("gamepadFireTriggered"))
         {
            Global.SetConsoleBool("gamepadFireTriggered", false);
            Global.SetConsoleInt("mvTriggerCount0", Global.GetConsoleInt("mvTriggerCount0") + 1);
         }
      }

      [ConsoleFunction]
      public static void GamePadAltTrigger(float val) {
         if(val > 0.1 && !Global.GetConsoleBool("gamepadAltTriggerTriggered"))
         {
            Global.SetConsoleBool("gamepadAltTriggerTriggered", true);
            Global.SetConsoleInt("mvTriggerCount1", Global.GetConsoleInt("mvTriggerCount1") + 1);
         }
         else if(val <= 0.1 && Global.GetConsoleBool("gamepadAltTriggerTriggered"))
         {
            Global.SetConsoleBool("gamepadAltTriggerTriggered", false);
            Global.SetConsoleInt("mvTriggerCount1", Global.GetConsoleInt("mvTriggerCount1") + 1);
         }
      }
   }
}