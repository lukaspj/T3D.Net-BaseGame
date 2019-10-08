using System;
using System.Linq;
using BaseGame.Core.SimClasses;
using BaseGame.Game.Spectator.Datablocks;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Structs;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;
using TransformF = T3DNetFramework.Generated.Structs.Math.TransformF;

namespace BaseGame.Game.Spectator.Server {
   /// <summary>
   /// DefaultGame manages the communication between the server's world and the
   /// client's simulation. These functions are responsible for maintaining the
   /// client's camera and player objects.
   /// </summary>
   [ConsoleClass]
   public class DefaultGame : LevelInfo {
      /// <summary>
      /// What kind of "player" is spawned is either controlled directly by the
      /// SpawnSphere or it defaults back to the values set here. This also controls
      /// which SimGroups to attempt to select the spawn sphere's from by walking down
      /// the list of SpawnGroups till it finds a valid spawn object.
      /// These override the values set in core/scripts/server/spawn.cs
      /// </summary>
      public static void InitGameVars() {
         // Leave $Game::defaultPlayerClass and $Game::defaultPlayerDataBlock as empty strings ("")
         // to spawn a the $Game::defaultCameraClass as the control object.
         Global.SetConsoleString("Game::DefaultPlayerClass", "");
         Global.SetConsoleString("Game::DefaultPlayerDataBlock", "");
         Global.SetConsoleString("Game::DefaultPlayerSpawnGroups",
            "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints");

         //-----------------------------------------------------------------------------
         // What kind of "camera" is spawned is either controlled directly by the
         // SpawnSphere or it defaults back to the values set here. This also controls
         // which SimGroups to attempt to select the spawn sphere's from by walking down
         // the list of SpawnGroups till it finds a valid spawn object.
         // These override the values set in core/scripts/server/spawn.cs
         //-----------------------------------------------------------------------------
         Global.SetConsoleString("Game::DefaultCameraClass", "Camera");
         Global.SetConsoleString("Game::DefaultCameraDataBlock", "Observer");
         Global.SetConsoleString("Game::DefaultCameraSpawnGroups",
            "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints");

         // Global movement speed that affects all Cameras
         Global.SetConsoleInt("Camera::MovementSpeed", 30);
      }

      /// <summary>
      /// This is the main entry point for spawning a control object for the client.
      /// The control object is the actual game object that the client is responsible
      /// for controlling in the client and server simulations. We also spawn a
      /// convenient camera object for use as an alternate control object. We do not
      /// have to spawn this camera object in order to function in the simulation.
      ///
      /// Called for each client after it's finished downloading the mission and is
      /// ready to start playing.
      /// </summary>
      /// <param name="client"></param>
      public void OnClientEnterGame(GameConnection client) {
         // This function currently relies on some helper functions defined in
         // core/scripts/spawn.cs. For custom spawn behaviors one can either
         // override the properties on the SpawnSphere's or directly override the
         // functions themselves.

         // Find a spawn point for the camera
         SceneObject cameraSpawnPoint = PickCameraSpawnPoint(Global.GetConsoleString("Game::DefaultCameraSpawnGroups"));
   
         // Spawn a camera for this client using the found %spawnPoint
         SpawnCamera(cameraSpawnPoint.GetTransform(), client);
      }
      
      public void OnClientLeaveGame(GameConnection client) {
         // Cleanup the camera
         if (Global.IsObject(GetFieldValue("camera"))) {
            Camera camera = Sim.FindObject<Camera>(GetFieldValue("camera"));
            camera.Delete();
         }
      }

      public void OnMissionStart() {
         InitGameVars();
         
         Global.SetConsoleString("Game::Duration", GetFieldValue("duration"));
      }

      public void OnMissionEnded() {
         Global.Cancel(Global.GetConsoleInt("Game::Schedule"));
         Global.SetConsoleBool("Game::Running", false);
         Global.SetConsoleBool("Game::Cycling", false);
      }

      public void OnMissionReset() {
         InitGameVars();
         
         Global.SetConsoleString("Game::Duration", GetFieldValue("duration"));
      }

      public SceneObject PickCameraSpawnPoint(string spawnGroups) {
         SimObject spawnPoint = spawnGroups.Split(' ')
            .ToList()
            .Select((group) => Sim.FindObjectByName<SimSet>(group)?.GetRandom())
            .ToList()
            .Find((x) => x != null && Global.IsObject(x.GetId().ToString()));

         if (spawnPoint != null) {
            return spawnPoint.As<SceneObject>();
         }
         
         // Didn't find a spawn point by looking for the groups
         // so let's return the "default" SpawnSphere
         // First create it if it doesn't already exist
         SpawnSphere spawn;
         if (!Global.IsObject("DefaultCameraSpawnSphere")) {
            spawn = new SpawnSphere("DefaultCameraSpawnSphere") {
               DataBlock = Sim.FindObjectByName<GameBaseData>("SpawnSphereMarker"),
               SpawnClass = Global.GetConsoleString("Game::DefaultCameraClass"),
               SpawnDatablock = Global.GetConsoleString("Game::DefaultCameraDataBlock"),
            };
            spawn.RegisterObject();

            // Add it to the MissionCleanup group so that it
            // doesn't get saved to the Mission (and gets cleaned
            // up of course)
            Core.SimObjects.Collections.MissionCleanup.Add(spawn);
         } else {
            spawn = Sim.FindObjectByName<SpawnSphere>("DefaultCameraSpawnSphere");
         }

         return spawn;
      }

      public void SpawnCamera(TransformF spawnPoint, GameConnection client) {
         // Set the control object to the default camera
         if (!Global.IsObject(client.GetFieldValue("camera"))) {
            int camId = Global.SpawnObject("Camera", "Observer");
            client.SetFieldValue("camera", camId.ToString());
         }
         
         // If we have a camera then set up some properties
         if (Global.IsObject(client.GetFieldValue("camera"))) {
            Core.SimObjects.Collections.MissionCleanup.Add(client.GetFieldValue("camera"));
            Camera clientCam = Sim.FindObjectById<Camera>(Convert.ToUInt32(client.GetFieldValue("camera")));
            clientCam.ScopeToClient(client);

            client.SetControlObject(clientCam);

            if (spawnPoint == null) {
               return;
            } 
            
            clientCam.SetTransform(spawnPoint);
         }
      }
   }
}