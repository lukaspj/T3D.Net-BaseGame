using BaseGame.Core.SimClasses;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Camera {
      [ConsoleFunction]
      public static void ToggleFreeLook(float val) {
         Global.SetConsoleBool("mvFreeLook", val > 0);
      }
      
      [ConsoleFunction]
      public static void ToggleFirstPerson(float val) {
         if (!(val > 0)) {
            return;
         }
         
         GameConnection serverConnection = Core.SimObjects.Server.ServerConnection;
         serverConnection.SetFirstPerson(!serverConnection.IsFirstPerson());
      }
      
      [ConsoleFunction]
      public static void ToggleCamera(float val) {
         if (!(val > 0)) {
            return;
         }
         
         Global.CommandToServer("ToggleCamera".Tag());
      }
      
      [ConsoleFunction]
      public static void DropCameraAtPlayer(float val) {
         if (!(val > 0)) {
            return;
         }
         
         Global.CommandToServer("DropCameraAtPlayer".Tag());
      }
      
      [ConsoleFunction]
      public static void DropPlayerAtCamera(float val) {
         if (!(val > 0)) {
            return;
         }
         
         Global.CommandToServer("DropPlayerAtCamera".Tag());
      }
   }
}