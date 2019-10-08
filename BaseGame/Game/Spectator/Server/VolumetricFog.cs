using System.Globalization;
using T3DNetFramework.Engine.Structs;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using AngAxisF = T3DNetFramework.Generated.Structs.Math.AngAxisF;
using Point3F = T3DNetFramework.Engine.Structs.Point3F;
using Point2F = T3DNetFramework.Engine.Structs.Point2F;

namespace BaseGame.Game.Spectator.Server {
   [ConsoleClass]
   public class VolumetricFog : T3DNetFramework.Generated.Classes.Sim.VolumetricFog {
      public void Dissolve(int speed, bool delete) {
         SetFieldValue("isBuilding", true.ToString());
         if (FogDensity > 0) {
            SetFogDensity(FogDensity - 0.005f);
            Schedule(speed.ToString(), "Dissolve", speed.ToString(), delete.ToString());
         } else {
            SetFieldValue("isBuilding", false.ToString());
            SetFogDensity(0.0f);
            if (delete) {
               Schedule("250", "delete");
            }
         }
      }
      
      public void Thicken(int speed, float endDensity) {
         SetFieldValue("isBuilding", true.ToString());
         if (FogDensity + 0.005 < endDensity) {
            SetFogDensity(FogDensity + 0.005f);
            Schedule(speed.ToString(), "Thicken", speed.ToString(), endDensity.ToString(CultureInfo.InvariantCulture));
         } else {
            SetFieldValue("isBuilding", false.ToString());
            SetFogDensity(endDensity);
         }
      }

      [ConsoleFunction]
      public static VolumetricFog GenerateFog(Point3F pos, Point3F scale, ColorI color, float density) {
         VolumetricFog fog = new VolumetricFog() {
            ShapeName = "data/FPSGameplay/art/environment/Fog_Sphere.dts",
            FogColor = color,
            FogDensity = 0.0f,
            IgnoreWater = false,
            MinSize = 250f,
            FadeSize = 750f,
            Texture = "data/FPSGameplay/art/environment/FogMod_heavy.dds",
            Tiles = 1f,
            ModStrength = 0.2f,
            PrimSpeed = new Point2F(-0.01f, 0.04f),
            SecSpeed = new Point2F(0.02f, 0.02f),
            Position = pos,
            //TODO Rotation = "0 0 1 20.354",
            Scale = scale,
            CanSave = true,
            CanSaveDynamicFields = true,
         };

         fog.SetFieldValue("rotation", "0 0 1 20.354");

         if (fog.RegisterObject()) {
            Core.SimObjects.Collections.MissionCleanup.Add(fog);
            
            fog.Thicken(500, density);
         }

         return fog;
      }
   }
}