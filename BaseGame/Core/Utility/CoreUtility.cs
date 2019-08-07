using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.Utility
{
   [ConsoleClass("Core_Utility")]
   public class CoreUtility : SimSet
   {
      public void onCreate() {
         Global.Exec("core/utility/scripts/parseArgs.cs");
         Global.Exec("core/utility/scripts/globals.cs");
         Global.Exec("core/utility/scripts/helperFunctions.cs");
         Global.Exec("core/utility/scripts/gameObjectManagement.cs");
         Global.Exec("core/utility/scripts/persistanceManagement.cs");
      }

      public void onDestroy() {
      }
   }
}
