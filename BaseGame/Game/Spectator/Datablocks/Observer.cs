using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Datablocks {
   [ConsoleClass]
   public class Observer : CameraData {
      public static class ObserverMode {
         public static string OBSERVER = "Observer";
         public static string CORPSE = "Corpse";
      }

      public void OnTrigger(Camera obj, int trigger, int state) {
         // state = 0 means that a trigger key was released
         if (state == 0) {
            return;
         }

         // Default player triggers: 0=fire 1=altFire 2=jump
         int clientId = obj.GetControllingClient();
         GameConnection client = Sim.FindObjectById<GameConnection>((uint) clientId);
         switch (obj.GetFieldValue("mode")) {
            case "Observer":
               // Do something interesting.
               break;

            case "Corpse":
               // Viewing dead corpse, so we probably want to respawn.
               if (client.IsMethod("spawnPlayer")) {
                  client.Call("spawnPlayer");
               }

               // Set the camera back into observer mode, since in
               // debug mode we like to switch to it.
               SetMode(obj, "Observer");
               break;
         }
      }

      public void SetMode(Camera obj, string mode, params string[] args) {
         switch (mode) {
            case "Observer":
               // Let the player fly around
               obj.SetFlyMode();
               break;

            case "Corpse":
               // Lock the camera down in orbit around the corpse,
               // which should be arg1
               GameBase corpse = Sim.FindObject<GameBase>(args[0]);
               obj.SetOrbitMode(corpse, corpse.GetTransform(), 0.5f, 4.5f, 4.5f);
               break;
         }

         obj.SetFieldValue("mode", mode);
      }
   }
}