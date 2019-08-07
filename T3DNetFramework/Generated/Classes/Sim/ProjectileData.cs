using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class ProjectileData : GameBaseData {



        public ProjectileData(bool pRegister = false)
            : base(pRegister) {
        }

        public ProjectileData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ProjectileData(string pName)
            : this(pName, false) {
        }

        public ProjectileData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ProjectileData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ProjectileData(SimObject pObj)
            : base(pObj) {
        }

        public ProjectileData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnCollision__Args
                {

				   internal IntPtr proj;

				   internal IntPtr col;

				   internal float fade;

				   internal IntPtr pos;

				   internal IntPtr normal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnCollision(IntPtr _this, IntPtr proj, IntPtr col, float fade, IntPtr pos, IntPtr normal);
                internal delegate void _OnCollision(IntPtr _this, OnCollision__Args args);
                private static _OnCollision _OnCollisionFunc;
                internal static _OnCollision OnCollision() {
                    if (_OnCollisionFunc == null) {
                        _OnCollisionFunc =
                            (_OnCollision)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbProjectileData_onCollision"), typeof(_OnCollision));
                    }

                    return _OnCollisionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnExplode__Args
                {

				   internal IntPtr proj;

				   internal IntPtr pos;

				   internal float fade;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnExplode(IntPtr _this, IntPtr proj, IntPtr pos, float fade);
                internal delegate void _OnExplode(IntPtr _this, OnExplode__Args args);
                private static _OnExplode _OnExplodeFunc;
                internal static _OnExplode OnExplode() {
                    if (_OnExplodeFunc == null) {
                        _OnExplodeFunc =
                            (_OnExplode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbProjectileData_onExplode"), typeof(_OnExplode));
                    }

                    return _OnExplodeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StaticGetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _StaticGetType();
                internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
                private static _StaticGetType _StaticGetTypeFunc;
                internal static _StaticGetType StaticGetType() {
                    if (_StaticGetTypeFunc == null) {
                        _StaticGetTypeFunc =
                            (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnProjectileData_staticGetType"), typeof(_StaticGetType));
                    }

                    return _StaticGetTypeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Create__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _Create();
                internal delegate IntPtr _Create(Create__Args args);
                private static _Create _CreateFunc;
                internal static _Create Create() {
                    if (_CreateFunc == null) {
                        _CreateFunc =
                            (_Create)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnProjectileData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void OnCollision(Projectile proj, SceneObject col, float fade, Point3F pos, Point3F normal) {

                                                                                    pos.Alloc();                     normal.Alloc();                     InternalUnsafeMethods.OnCollision__Args _args = new InternalUnsafeMethods.OnCollision__Args() {
                        proj = proj.ObjectPtr,
                        col = col.ObjectPtr,
                        fade = fade,
                        pos = pos.internalStructPtr,
                        normal = normal.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnCollision()(ObjectPtr, _args);
                                                                                                         pos.Free();                     normal.Free();
                  }



                  public void OnExplode(Projectile proj, Point3F pos, float fade) {

                                          pos.Alloc();                                          InternalUnsafeMethods.OnExplode__Args _args = new InternalUnsafeMethods.OnExplode__Args() {
                        proj = proj.ObjectPtr,
                        pos = pos.internalStructPtr,
                        fade = fade,
                     };
                     InternalUnsafeMethods.OnExplode()(ObjectPtr, _args);
                                                               pos.Free();
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public ParticleEmitterData ParticleEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("ParticleEmitter"));
            set => SetFieldValue("ParticleEmitter", GenericMarshal.ToString(value));
        }


        public ParticleEmitterData ParticleWaterEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("particleWaterEmitter"));
            set => SetFieldValue("particleWaterEmitter", GenericMarshal.ToString(value));
        }


        public string ProjectileShapeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("projectileShapeName"));
            set => SetFieldValue("projectileShapeName", GenericMarshal.ToString(value));
        }


        public Point3F Scale {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("scale"));
            set => SetFieldValue("scale", GenericMarshal.ToString(value));
        }


        public SFXTrack Sound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("sound"));
            set => SetFieldValue("sound", GenericMarshal.ToString(value));
        }


        public ExplosionData Explosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("Explosion"));
            set => SetFieldValue("Explosion", GenericMarshal.ToString(value));
        }


        public ExplosionData WaterExplosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("waterExplosion"));
            set => SetFieldValue("waterExplosion", GenericMarshal.ToString(value));
        }


        public SplashData Splash {
            get => GenericMarshal.StringTo<SplashData>(GetFieldValue("Splash"));
            set => SetFieldValue("Splash", GenericMarshal.ToString(value));
        }


        public DecalData Decal {
            get => GenericMarshal.StringTo<DecalData>(GetFieldValue("decal"));
            set => SetFieldValue("decal", GenericMarshal.ToString(value));
        }


        public LightDescription LightDesc {
            get => GenericMarshal.StringTo<LightDescription>(GetFieldValue("lightDesc"));
            set => SetFieldValue("lightDesc", GenericMarshal.ToString(value));
        }


        public bool IsBallistic {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isBallistic"));
            set => SetFieldValue("isBallistic", GenericMarshal.ToString(value));
        }


        public float VelInheritFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("velInheritFactor"));
            set => SetFieldValue("velInheritFactor", GenericMarshal.ToString(value));
        }


        public float MuzzleVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("muzzleVelocity"));
            set => SetFieldValue("muzzleVelocity", GenericMarshal.ToString(value));
        }


        public float ImpactForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("impactForce"));
            set => SetFieldValue("impactForce", GenericMarshal.ToString(value));
        }


        public int Lifetime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }


        public int ArmingDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("armingDelay"));
            set => SetFieldValue("armingDelay", GenericMarshal.ToString(value));
        }


        public int FadeDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeDelay"));
            set => SetFieldValue("fadeDelay", GenericMarshal.ToString(value));
        }


        public float BounceElasticity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bounceElasticity"));
            set => SetFieldValue("bounceElasticity", GenericMarshal.ToString(value));
        }


        public float BounceFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bounceFriction"));
            set => SetFieldValue("bounceFriction", GenericMarshal.ToString(value));
        }


        public float GravityMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gravityMod"));
            set => SetFieldValue("gravityMod", GenericMarshal.ToString(value));
        }


    }
}
