using System;
using System.IO;
using System.Reflection;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Interop;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Generated.Structs.Math;
using Path = System.IO.Path;

namespace BaseGame
{
   class Main
   {
      [ScriptEntryPoint]
      public static void Entry() {
         // --- Boilerplate C#-specific setup. Normally Torque uses the main.cs file to set these variables, here we have to do it ourselves.
         string CSDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace('\\', '/');
         Global.SetMainDotCsDir(CSDir);
         Global.SetCurrentDirectory(CSDir);
         // ---

         Global.SetConsoleString("Core::windowIcon", "data/icon.png");
         Global.SetConsoleString("Core::splashWindowImage", "data/splash.png");

         // Display a splash window immediately to improve app responsiveness before
         // engine is initialized and main window created.
         Global.DisplaySplashWindow(Global.GetConsoleString("Core::splashWindowImage"));

         // Enable console logging, which creates the file console.log each time you run
         // the engine.
         Global.SetLogMode(6);

         // Disable script trace.
         Global.Trace(false);

         // Set the name of our application
         Global.SetConsoleString("appName", "BaseGame");

         //-----------------------------------------------------------------------------
         // Load up scripts to initialise subsystems.
         ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
         ModuleDatabase.SetModuleExtension("module");
         ModuleDatabase.ScanModules( "core", false );
         ModuleDatabase.LoadExplicit( "CoreModule" );

         //-----------------------------------------------------------------------------
         // Load any gameplay modules
         ModuleDatabase.ScanModules( "data", false );
         ModuleDatabase.LoadGroup("Game");

         if (Global.GetConsoleBool("isDedicated") == false) {
            // Start rendering and stuff
            Global.Call("initRenderManager");
            Global.Call("initLightingSystems", "Advanced Lighting");


            Global.Call("configureCanvas");
            //Core.Canvas.ConfigureCanvas();

            // Autodetect settings if it's our first time
            if (Global.GetConsoleBool("pref::Video::autoDetect"))
            {
               //todo GraphicsMenu.Autodetect()
               Global.Eval("GraphicsMenu.AutoDetect");
            }

            Global.Call("postFXInit");

            Global.CloseSplashWindow();

            // As we know at this point that the initial load is complete,
            // we can hide any splash screen we have, and show the canvas.
            // This keeps things looking nice, instead of having a blank window
            // Core.Canvas.ShowWindow();
            Global.Eval("Canvas.showWindow();");
         } else {
            Global.CloseSplashWindow();
         }

         Global.Echo("Engine initialized...");
      }

      //-----------------------------------------------------------------------------
      // Called when the engine is shutting down.
      [ConsoleFunction]
      public static void onExit() {
         ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
         ModuleDatabase.UnloadExplicit("CoreModule");
         ModuleDatabase.UnloadGroup("Game");
      }
   }
}
