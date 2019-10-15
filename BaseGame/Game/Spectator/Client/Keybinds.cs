using System.Globalization;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Game.Spectator.Client {
   public class Keybinds {
      public static void Init() {
         if (Global.IsObject("moveMap")) {
            ActionMap oldMoveMap = Sim.FindObjectByName<ActionMap>("moveMap");
            oldMoveMap.Delete();
         }

         ActionMap moveMap = new ActionMap("moveMap");
         moveMap.RegisterObject();

         ActionMap globalActionMap = Sim.FindObjectByName<ActionMap>("GlobalActionMap");

         //------------------------------------------------------------------------------
         // Non-remapable binds
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "F2", "showPlayerList");

         moveMap.Bind("keyboard", "ctrl h", "hideHUDs");

         moveMap.Bind("keyboard", "alt p", "doScreenShotHudless");

         moveMap.BindCmd("keyboard", "escape", "", "Canvas.pushDialog(PauseMenu);");

         //------------------------------------------------------------------------------
         // Movement Keys
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "a", "moveleft");
         moveMap.Bind("keyboard", "d", "moveright");
         moveMap.Bind("keyboard", "left", "moveleft");
         moveMap.Bind("keyboard", "right", "moveright");

         moveMap.Bind("keyboard", "w", "moveforward");
         moveMap.Bind("keyboard", "s", "movebackward");
         moveMap.Bind("keyboard", "up", "moveforward");
         moveMap.Bind("keyboard", "down", "movebackward");

         moveMap.Bind("keyboard", "e", "moveup");
         moveMap.Bind("keyboard", "c", "movedown");

         moveMap.Bind("keyboard", "space", "jump");
         moveMap.Bind("mouse", "xaxis", "yaw");
         moveMap.Bind("mouse", "yaxis", "pitch");

         moveMap.Bind("gamepad", "thumbrx", "D", "-0.23 0.23", "gamepadYaw");
         moveMap.Bind("gamepad", "thumbry", "D", "-0.23 0.23", "gamepadPitch");
         moveMap.Bind("gamepad", "thumblx", "D", "-0.23 0.23", "gamePadMoveX");
         moveMap.Bind("gamepad", "thumbly", "D", "-0.23 0.23", "gamePadMoveY");

         moveMap.Bind("gamepad", "btn_a", "jump");
         moveMap.BindCmd("gamepad", "btn_back", "disconnect();", "");

         moveMap.BindCmd("gamepad", "dpadl", "toggleLightColorViz();", "");
         moveMap.BindCmd("gamepad", "dpadu", "toggleDepthViz();", "");
         moveMap.BindCmd("gamepad", "dpadd", "toggleNormalsViz();", "");
         moveMap.BindCmd("gamepad", "dpadr", "toggleLightSpecularViz();", "");

         // ----------------------------------------------------------------------------
         // Stance/pose
         // ----------------------------------------------------------------------------
         moveMap.Bind("keyboard", "lcontrol", "doCrouch");
         moveMap.Bind("gamepad", "btn_b", "doCrouch");

         moveMap.Bind("keyboard", "lshift", "doSprint");

         //------------------------------------------------------------------------------
         // Mouse Trigger
         //------------------------------------------------------------------------------
         //function altTrigger(%val)
         //{
                  //$mvTriggerCount1++;
         //}

         moveMap.Bind("mouse", "button0", "mouseFire");
         //moveMap.Bind( "mouse", button1, altTrigger );

         //------------------------------------------------------------------------------
         // Gamepad Trigger
         //------------------------------------------------------------------------------
         moveMap.Bind("gamepad", "triggerr", "gamepadFire");
         moveMap.Bind("gamepad", "triggerl", "gamepadAltTrigger");

         //------------------------------------------------------------------------------
         // Zoom and FOV functions
         //------------------------------------------------------------------------------

         if (Global.GetConsoleString("Player::CurrentFOV") == "") {
            Global.SetConsoleString("Player::CurrentFOV",
               (Global.GetConsoleFloat("pref::Player::DefaultFOV") / 2).ToString(CultureInfo.InvariantCulture));
         }

         // toggleZoomFOV() works by dividing the CurrentFOV by 2.  Each time that this
         // toggle is hit it simply divides the CurrentFOV by 2 once again.  If the
         // FOV is reduced below a certain threshold then it resets to equal half of the
         // DefaultFOV value.  This gives us 4 zoom levels to cycle through.
         moveMap.Bind("keyboard", "f", "setZoomFOV"); // f for field of view
         moveMap.Bind("keyboard", "z", "toggleZoom"); // z for zoom
         moveMap.Bind("mouse", "button1", "mouseButtonZoom");

         //------------------------------------------------------------------------------
         // Camera & View functions
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "v", "toggleFreeLook"); // v for vanity
         moveMap.Bind("keyboard", "tab", "toggleFirstPerson");

         moveMap.Bind("gamepad", "btn_x", "toggleFirstPerson");

         // ----------------------------------------------------------------------------
         // Misc. Player stuff
         // ----------------------------------------------------------------------------

         // Gideon does not have these animations, so the player does not need access to
         // them.  Commenting instead of removing so as to retain an example for those
         // who will want to use a player model that has these animations and wishes to
         // use them.

         //moveMap.BindCmd( "keyboard", "ctrl w", "commandToServer('playCel',\"wave\");", "");
         //moveMap.BindCmd( "keyboard", "ctrl s", "commandToServer('playCel',\"salute\");", "");

         moveMap.BindCmd("keyboard", "ctrl k", "commandToServer('suicide');", "");

         //------------------------------------------------------------------------------
         // Item manipulation
         //------------------------------------------------------------------------------
         moveMap.BindCmd("keyboard", "1", "commandToServer('use',\"Ryder\");", "");
         moveMap.BindCmd("keyboard", "2", "commandToServer('use',\"Lurker\");", "");
         moveMap.BindCmd("keyboard", "3", "commandToServer('use',\"LurkerGrenadeLauncher\");", "");
         moveMap.BindCmd("keyboard", "4", "commandToServer('use',\"ProxMine\");", "");
         moveMap.BindCmd("keyboard", "5", "commandToServer('use',\"DeployableTurret\");", "");

         moveMap.BindCmd("keyboard", "r", "commandToServer('reloadWeapon');", "");

         moveMap.Bind("keyboard", "0", "unmountWeapon");

         moveMap.Bind("keyboard", "alt w", "throwWeapon");
         moveMap.Bind("keyboard", "alt a", "tossAmmo");

         moveMap.Bind("keyboard", "q", "nextWeapon");
         moveMap.Bind("keyboard", "ctrl q", "prevWeapon");
         moveMap.Bind("mouse", "zaxis", "mouseWheelWeaponCycle");

         //------------------------------------------------------------------------------
         // Message HUD functions
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "u", "toggleMessageHud");
         //moveMap.Bind( "keyboard", y, teamMessageHud );
         moveMap.Bind("keyboard", "pageUp", "pageMessageHudUp");
         moveMap.Bind("keyboard", "pageDown", "pageMessageHudDown");
         moveMap.Bind("keyboard", "p", "resizeMessageHud");

         //------------------------------------------------------------------------------
         // Demo recording functions
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "F3", "startRecordingDemo");
         moveMap.Bind("keyboard", "F4", "stopRecordingDemo");

         //------------------------------------------------------------------------------
         // Helper Functions
         //------------------------------------------------------------------------------
         moveMap.Bind("keyboard", "F8", "dropCameraAtPlayer");
         moveMap.Bind("keyboard", "F7", "dropPlayerAtCamera");

         globalActionMap.Bind("keyboard", "ctrl F3", "doProfile");

         //------------------------------------------------------------------------------
         // Misc.
         //------------------------------------------------------------------------------
         globalActionMap.Bind("keyboard", "tilde", "toggleConsole");
         globalActionMap.BindCmd("keyboard", "alt k", "cls();", "");
         globalActionMap.BindCmd("keyboard", "alt enter", "", "Canvas.attemptFullscreenToggle();");
         globalActionMap.BindCmd("keyboard", "F1", "", "contextHelp();");
         moveMap.BindCmd("keyboard", "n", "toggleNetGraph();", "");

         // ----------------------------------------------------------------------------
         // Useful vehicle stuff
         // ----------------------------------------------------------------------------
         // Bind the keys to the carjack command
         moveMap.BindCmd("keyboard", "ctrl z", "carjack();", "");

         // Starting vehicle action map code
         if (Global.IsObject("vehicleMap")) {
            ActionMap oldVehicleMap = Sim.FindObjectByName<ActionMap>("vehicleMap");
            oldVehicleMap.Delete();
         }

         ActionMap vehicleMap = new ActionMap("vehicleMap");
         vehicleMap.RegisterObject();

         //------------------------------------------------------------------------------
         // Non-remapable binds
         //------------------------------------------------------------------------------
         vehicleMap.BindCmd("keyboard", "escape", "", "Canvas.pushDialog(PauseMenu);");

         // The key command for flipping the car
         vehicleMap.BindCmd("keyboard", "ctrl x", "commandToServer(\'flipCar\');", "");

         vehicleMap.Bind("keyboard", "w", "moveforward");
         vehicleMap.Bind("keyboard", "s", "movebackward");
         vehicleMap.Bind("keyboard", "up", "moveforward");
         vehicleMap.Bind("keyboard", "down", "movebackward");
         vehicleMap.Bind("mouse", "xaxis", "yaw");
         vehicleMap.Bind("mouse", "yaxis", "pitch");
         vehicleMap.Bind("mouse", "button0", "mouseFire");
         vehicleMap.Bind("mouse", "button1", "altTrigger");
         vehicleMap.BindCmd("keyboard", "f", "getout();", "");
         vehicleMap.Bind("keyboard", "space", "brake");
         vehicleMap.BindCmd("keyboard", "l", "brakeLights();", "");
         vehicleMap.Bind("keyboard", "v", "toggleFreeLook"); // v for vanity
         //vehicleMap.Bind( "keyboard", tab, toggleFirstPerson );
         // bind the left thumbstick for steering
         vehicleMap.Bind("gamepad", "thumblx", "D", "-0.23 0.23", "gamepadYaw");
         // bind the gas, break, and reverse buttons
         vehicleMap.Bind("gamepad", "btn_a", "moveforward");
         vehicleMap.Bind("gamepad", "btn_b", "brake");
         vehicleMap.Bind("gamepad", "btn_x", "movebackward");
         // bind exiting the vehicle to a button
         vehicleMap.BindCmd("gamepad", "btn_y", "getout();", "");
      }
   }
}