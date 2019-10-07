using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public static class Rendering {
      /// <summary>
      /// Initialize render manager, calls the TorqueScript function "initRenderManager".
      /// </summary>
      public static void InitRenderManager() {
         // Call TorqueScript function
         Global.Call("InitRenderManager");
      }
      
      public static class PostFX {
         /// <summary>
         /// Initialize PostFX system, calls the TorqueScript function "postFXInit".
         /// </summary>
         public static void Init() => Global.Call("postFXInit");
      }
   }
}