using BaseGame.Core.SimClasses;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;

namespace BaseGame.Core.SimObjects {
   public class Server {
      public static GameConnection ServerConnection => Sim.FindObjectByName<GameConnection>("ServerConnection");
   }
}