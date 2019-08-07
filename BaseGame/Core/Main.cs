using System;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Game.Core
{
   [ConsoleClass]
   public class CoreModule : SimSet
   {
      public void onCreate() {
         // ----------------------------------------------------------------------------
         // Initialize core sub system functionality such as audio, the Canvas, PostFX,
         // rendermanager, light managers, etc.
         //
         // Note that not all of these need to be initialized before the client, although
         // the audio should and the canvas definitely needs to be.  I've put things here
         // to distinguish between the purpose and functionality of the various client
         // scripts.  Game specific script isn't needed until we reach the shell menus
         // and start a game or connect to a server. We get the various subsystems ready
         // to go, and then use initClient() to handle the rest of the startup sequence.
         //
         // If this is too convoluted we can reduce this complexity after futher testing
         // to find exactly which subsystems should be readied before kicking things off.
         // ----------------------------------------------------------------------------
         ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
         ModuleDatabase.LoadExplicit("Core_Rendering");
         ModuleDatabase.LoadExplicit("Core_Utility");
         ModuleDatabase.LoadExplicit("Core_GUI");
         ModuleDatabase.LoadExplicit("Core_Lighting");
         ModuleDatabase.LoadExplicit("Core_SFX");
         ModuleDatabase.LoadExplicit("Core_PostFX");
         ModuleDatabase.LoadExplicit("Core_Components");
         ModuleDatabase.LoadExplicit("Core_ClientServer");

         // Load prefs
         string prefPath = Global.GetPrefsPath();
         Console.WriteLine("-----");
         Console.WriteLine(prefPath);
         if (Global.IsFile(prefPath + "/clientPrefs.cs")) {
            Global.Exec(prefPath + "/clientPrefs.cs");
         } else {
            Global.Exec("data/defaults.cs");
         }

         // Seed the random number generator.
         Global.SetRandomSeed();

         // Parse the command line arguments
         Global.Echo("\n--------- Parsing Arguments ---------");
         Global.Call("parseArgs");

         // The canvas needs to be initialized before any gui scripts are run since
         // some of the controls assume that the canvas exists at load time.
         Global.Call("createCanvas", Global.GetConsoleString("appName"));

         //load canvas
         //exec("./console/main.cs");

         ModuleDatabase.LoadExplicit("Core_Console");

         // Init the physics plugin.
         Global.PhysicsInit();

         Global.Call("sfxStartup");

         // Set up networking.
         Global.SetNetPort(0);

         // Start processing file change events.
         Global.StartFileChangeNotifications();

         // If we have editors, initialize them here as well
         if (Global.IsToolBuild()) {
            if (Global.IsFile("tools/main.cs") && Global.GetConsoleBool("isDedicated") == false) {
               Global.Exec("tools/main.cs");
            }

            ModuleDatabase.ScanModules("tools", false);
            ModuleDatabase.LoadGroup("Tools");
         }
      }

      public void onDestroy() {
         // Stop file change events.
         Global.StopFileChangeNotifications();
      }
   }
}
