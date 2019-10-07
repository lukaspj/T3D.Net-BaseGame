using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Functions {
   public static class Lighting {
      /// <summary>
      /// Initialize lighting systems, calls the TorqueScript function "initLightingSystems".
      /// </summary>
      /// <param name="lightingSystem">
      ///    Can be one of:
      ///      * "Advanced Lighting"
      ///      * "Basic Lighting"
      /// </param>
      public static void InitLightingSystems(string lightingSystem) =>
         Global.Call("initLightingSystems", lightingSystem);
   }
}