using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.ClientServer
{
   // The general flow of a gane - server's creation, loading and hosting clients, and then destruction is as follows:

   // First, a client will always create a server in the event that they want to host a single player
   // game. Torque3D treats even single player connections as a soft multiplayer game, with some stuff
   // in the networking short-circuited to sidestep around lag and packet transmission times.

   // initServer() is called, loading the default server scripts.
   // After that, if this is a dedicated server session, initDedicated() is called, otherwise initClient is called
   // to prep a playable client session.

   // When a local game is started - a listen server - via calling StartGame() a server is created and then the client is
   // connected to it via createAndConnectToLocalServer().
   [ConsoleClass("Core_ClientServer")]
   public class CoreClientServer : SimSet
   {
      public void create() {
         Global.Echo("\n--------- Initializing Directory: scripts ---------");
         Global.Exec("core/clientServer/scripts/client/client.cs");
         Global.Exec("core/clientServer/scripts/server/server.cs");

         Global.SetConsoleString("Game::MainScene", Global.GetScene(0));

         Global.Call("initServer");


         //% dbList = new ArrayObject(DatablockFilesList);

         // Start up in either client, or dedicated server mode
         if (Global.GetConsoleBool("Server::Dedicated")) {
            Global.Call("initDedicated");
         } else {
            Global.Call("initClient");
         }
      }

      public void destroy() {
         // Ensure that we are disconnected and/or the server is destroyed.
         // This prevents crashes due to the SceneGraph being deleted before
         // the objects it contains.
         if (Global.GetConsoleBool("Server::Dedicated")) {
            Global.Call("destroyServer");
         } else {
            Global.Call("disconnect");
         }

         // Destroy the physics plugin.
         //physicsDestroy();

         Global.Call("sfxShutdown");

         Global.Echo("Exporting client prefs");

         string prefPath = Global.Call("getPrefPath");

         Global.Export("$pref::*", prefPath + "/clientPrefs.cs");

         Global.Echo("Exporting server prefs");
         Global.Export("$Pref::Server::*", prefPath + "/serverPrefs.cs");
         BanList.Export(prefPath + "/banlist.cs");
      }

      [ConsoleFunction]
      public static void StartGame(string mission = null, string hostingType = null) {
         if (string.IsNullOrEmpty(mission)) {
            GuiTextListCtrl CL_levelList = Sim.FindObjectByName<GuiTextListCtrl>("CL_levelList");
            int id = CL_levelList.GetSelectedId();
            mission = Global.GetField(CL_levelList.GetRowTextById(id), 1);
            //error("Cannot start a level with no level selected!");
         }

         string serverType;

         if (!string.IsNullOrEmpty(hostingType)) {
            serverType = hostingType;
         } else {
            if (Global.GetConsoleBool("pref::HostMultiPlayer")) {
               serverType = "MultiPlayer";
            } else {
               serverType = "SinglePlayer";
            }
         }

         // Show the loading screen immediately.
         if (Global.IsObject("LoadingGui")) {
            GuiChunkedBitmapCtrl LoadingGui = Sim.FindObjectByName<GuiChunkedBitmapCtrl>("LoadingGui");

            GuiCanvas Canvas = Sim.FindObjectByName<GuiCanvas>("Canvas");
            Canvas.SetContent(LoadingGui);

            GuiProgressBitmapCtrl LoadingProgress = Sim.FindObjectByName<GuiProgressBitmapCtrl>("LoadingProgress");
            LoadingProgress.SetValue("1");

            GuiTextCtrl LoadingProgressTxt = Sim.FindObjectByName<GuiTextCtrl>("LoadingProgressTxt");
            LoadingProgressTxt.SetValue("LOADING MISSION FILE");
            Canvas.Repaint();
         }

         Global.Call("createAndConnectToLocalServer", serverType, mission);
      }

      [ConsoleFunction]
      public static void JoinGame(uint serverIndex) {
         // The server info index is stored in the row along with the
         // rest of displayed info.
         if (Global.SetServerInfo(serverIndex)) {
            GuiCanvas Canvas = Sim.FindObjectByName<GuiCanvas>("Canvas");

            GuiChunkedBitmapCtrl LoadingGui = Sim.FindObjectByName<GuiChunkedBitmapCtrl>("LoadingGui");
            Canvas.SetContent(LoadingGui);


            GuiProgressBitmapCtrl LoadingProgress = Sim.FindObjectByName<GuiProgressBitmapCtrl>("LoadingProgress");
            LoadingProgress.SetValue("1");

            GuiTextCtrl LoadingProgressTxt = Sim.FindObjectByName<GuiTextCtrl>("LoadingProgressTxt");
            LoadingProgressTxt.SetValue("WAITING FOR SERVER");
            Canvas.Repaint();
            GameConnection conn = new GameConnection("ServerConnection");
            conn.SetConnectArgs(Global.GetConsoleString("pref::Player::Name"));
            conn.SetJoinPassword(Global.GetConsoleString("Client::Password"));
            conn.Connect(Global.GetConsoleString("ServerInfo::Address"));
         }
      }
   }
}
