using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;
using T3DNetFramework.Interop;

namespace BaseGame.Core.PostFx
{
   [ConsoleClass("Core_PostFX")]
   public class CorePostFx : SimSet
   {
      public void onCreate() {
         //
         Global.Exec("core/postFX/scripts/postFx.cs");
         /*exec("./scripts/postFxManager.gui.cs");
         exec("./scripts/postFxManager.gui.settings.cs");
         exec("./scripts/postFxManager.persistance.cs");

         exec("./scripts/default.postfxpreset.cs");

         exec("./scripts/caustics.cs");
         exec("./scripts/chromaticLens.cs");
         exec("./scripts/dof.cs");
         exec("./scripts/edgeAA.cs");
         exec("./scripts/flash.cs");
         exec("./scripts/fog.cs");
         exec("./scripts/fxaa.cs");
         exec("./scripts/GammaPostFX.cs");
         exec("./scripts/glow.cs");
         exec("./scripts/hdr.cs");
         exec("./scripts/lightRay.cs");
         exec("./scripts/MLAA.cs");
         exec("./scripts/MotionBlurFx.cs");
         exec("./scripts/ovrBarrelDistortion.cs");
         exec("./scripts/ssao.cs");
         exec("./scripts/turbulence.cs");
         exec("./scripts/vignette.cs");*/
      }

      public void onDestroy() {
      }
   }
}
