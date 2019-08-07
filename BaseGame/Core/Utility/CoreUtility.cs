using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Game.Core.Utility
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
