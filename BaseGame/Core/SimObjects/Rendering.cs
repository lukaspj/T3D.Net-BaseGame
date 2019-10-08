using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;

namespace BaseGame.Core.SimObjects {
   public static class Rendering {
      public static RenderBinManager RenderManager => Sim.FindObjectByName<RenderBinManager>("RenderManager");
      
      public static class PostFX {
         public static PostEffect DOFPostEffect => Sim.FindObjectByName<PostEffect>("DOFPostEffect");
      }
   }
}