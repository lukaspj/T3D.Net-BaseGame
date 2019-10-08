using System.Linq;
using BaseGame.Game.Spectator.Datablocks;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator.Server {
   [ConsoleClass]
   public class Camera : T3DNetFramework.Generated.Classes.Sim.Camera {

      public void OnAdd(SimObject simObject) {
         Global.Warn("OnAdd");
         // Default start mode
         if (!string.IsNullOrEmpty(GetFieldValue("mode"))) {
            SetMode(GetFieldValue("mode"));
         }
      }

      public void SetMode(string mode, params string[] args) {
         Global.Warn("SetMode");
         // Punt this one over to our datablock
         int datablockId = GetDataBlock();
         CameraData data = Sim.FindObjectById<CameraData>((uint) datablockId);
         if (data.IsMethod("setMode")) {
            data.Call(
               args.ToList()
                  .Prepend("setMode")
                  .Prepend(GetId().ToString())
                  .Prepend(mode)
                  .ToArray()
            );
         }
      }
   }
}