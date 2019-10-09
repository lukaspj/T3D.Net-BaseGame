using BaseGame.Game.Spectator.Server;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Game.Spectator {
   [ConsoleClass]
   public class SpectatorGameplay : ModuleDefinition {
      public void create() {
         //server scripts

         //add DBs
         if (Global.IsObject("DatablockFilesList")) {
            ArrayObject datablockFilesList = Core.SimObjects.Collections.DatablockFilesList;
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/camera.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/defaultParticle.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/lights.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/managedDatablocks.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/managedDecalData.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/managedForestItemData.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/managedParticleData.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/managedParticleEmitterData.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/markers.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/ribbons.cs");
            datablockFilesList.Add("data/spectatorGameplay/scripts/datablocks/sounds.cs");
         }

         if (Global.IsObject("LevelFilesList")) {
            for (string file = Global.FindFirstFile("data/spectatorGameplay/levels/*.mis");
               file != "";
               file = Global.FindNextFile("data/spectatorGameplay/levels/*.mis")) {
               Core.SimObjects.Collections.LevelFilesList.Add(file);
            }
         }

         if (!Global.GetConsoleBool("Server::Dedicated")) {
            //client scripts
            string prefPath = Core.Functions.Paths.GetPrefPath();
            if (Global.IsFile(prefPath + "/keybinds.cs")) {
               Global.Exec(prefPath + "/keybinds.cs");
            }

            Client.InputCommands.Variables.Init();

            //guis
            Global.Exec("data/spectatorGameplay/scripts/gui/playGui.gui");
            Global.Exec("data/spectatorGameplay/scripts/gui/playGui.cs");
         }
      }

      public void destroy() { }
   }
}