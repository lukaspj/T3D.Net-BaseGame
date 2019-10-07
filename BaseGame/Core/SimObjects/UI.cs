using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.SimObjects {
   public static class UI {
      public static GuiCanvas Canvas => Sim.FindObjectByName<GuiCanvas>("Canvas");
   }
}