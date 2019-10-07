using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;

namespace BaseGame.Core.SimObjects {
   public class Rendering {
      public static RenderBinManager RenderManager => Sim.FindObjectByName<RenderBinManager>("RenderManager");
   }
}