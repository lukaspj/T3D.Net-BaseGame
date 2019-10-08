using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public class ServerConnection {
      public static void Disconnect() => Global.Call("disconnect");
   }
}