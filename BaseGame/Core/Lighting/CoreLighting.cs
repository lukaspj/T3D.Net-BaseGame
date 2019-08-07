using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.Lighting
{
   [ConsoleClass("Core_Lighting")]
   public class CoreLighting : SimSet
   {
      public void onCreate() {
         Global.Exec("core/lighting/scripts/lighting.cs");

         //Advanced/Deferred
         Global.Exec("core/lighting/scripts/advancedLighting_Shaders.cs");
         Global.Exec("core/lighting/scripts/deferredShading.cs");
         Global.Exec("core/lighting/scripts/advancedLighting_Init.cs");

         //Basic/Forward
         Global.Exec("core/lighting/scripts/basicLighting_shadowFilter.cs");
         Global.Exec("core/lighting/scripts/shadowMaps_Init.cs");
         Global.Exec("core/lighting/scripts/basicLighting_Init.cs");
      }

      public void onDestroy() {
      }
   }
}
