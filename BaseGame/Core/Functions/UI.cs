using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public class UI {
      public static class GraphicsMenu {
         public static void AutoDetect() => Global.Eval("GraphicsMenu.AutoDetect");
      }
      public static void ConfigureCanvas() => Global.Call("configureCanvas");
   }
}