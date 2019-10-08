using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;

namespace BaseGame.Core.SimObjects {
   public static class Collections {
      public static ArrayObject DatablockFilesList => Sim.FindObjectByName<ArrayObject>("DatablockFilesList");
      public static ArrayObject LevelFilesList => Sim.FindObjectByName<ArrayObject>("LevelFilesList");

      public static SimGroup MissionCleanup => Sim.FindObjectByName<SimGroup>("MissionCleanup");
   }
}