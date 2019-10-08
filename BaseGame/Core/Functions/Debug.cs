using System.Linq;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public class Debug {
      public static void StartDemoRecord() => Global.Call("startDemoRecord");
      
      public static void StopDemoRecord() => Global.Call("stopDemoRecord");
      
      public static void Metrics(params string[] metrics) => Global.Call("stopDemoRecord", string.Join(" ", metrics));
   }
}