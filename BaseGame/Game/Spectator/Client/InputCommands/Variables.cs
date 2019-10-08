using T3DNetFramework.Generated.Functions;

namespace BaseGame.Game.Spectator.Client.InputCommands {
   public class Variables {
      public static void Init() {
         Global.SetConsoleInt("movementSpeed", 1);
         
         if (string.IsNullOrEmpty(Global.GetConsoleString("Player::CurrentFOV"))) {
            Global.SetConsoleString("Player::CurrentFOV", Global.GetConsoleString("pref::Player::DefaultFOV"));
         }
      }
   }
}