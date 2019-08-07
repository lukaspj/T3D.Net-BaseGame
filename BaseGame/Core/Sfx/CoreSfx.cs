using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Game.Core.Sfx
{
   [ConsoleClass("Core_SFX")]
   public class CoreSfx : SimSet
   {
      public void onCreate() {
         Global.Exec("core/sfx/scripts/audio.cs");
         Global.Exec("core/sfx/scripts/audioData.cs");
         Global.Exec("core/sfx/scripts/audioAmbience.cs");
         Global.Exec("core/sfx/scripts/audioDescriptions.cs");
         Global.Exec("core/sfx/scripts/audioEnvironments.cs");
         Global.Exec("core/sfx/scripts/audioStates.cs");
      }

      public void onDestroy() {
      }
   }
}
