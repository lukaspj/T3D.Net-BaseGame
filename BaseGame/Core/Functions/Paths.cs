using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public static class Paths {
      public static string GetPrefPath() => Global.Call("getPrefPath");
   }
}