using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.Sfx
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
