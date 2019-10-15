using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {    
    public unsafe class Lightning : GameBase {
        public Lightning(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Lightning(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Lightning(string pName) 
            : this(pName, false) {
        }
        
        public Lightning(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Lightning(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Lightning(SimObject pObj) 
            : base(pObj) {
        }
        
        public Lightning(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StrikeObject__Args
            {
                internal IntPtr pSB;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StrikeObject(IntPtr _this, StrikeObject__Args args);
            private static _StrikeObject _StrikeObjectFunc;
            internal static _StrikeObject StrikeObject() {
                if (_StrikeObjectFunc == null) {
                    _StrikeObjectFunc =
                        (_StrikeObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightning_strikeObject"), typeof(_StrikeObject));
                }
                
                return _StrikeObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StrikeRandomPoint__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StrikeRandomPoint(IntPtr _this, StrikeRandomPoint__Args args);
            private static _StrikeRandomPoint _StrikeRandomPointFunc;
            internal static _StrikeRandomPoint StrikeRandomPoint() {
                if (_StrikeRandomPointFunc == null) {
                    _StrikeRandomPointFunc =
                        (_StrikeRandomPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightning_strikeRandomPoint"), typeof(_StrikeRandomPoint));
                }
                
                return _StrikeRandomPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct WarningFlashes__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _WarningFlashes(IntPtr _this, WarningFlashes__Args args);
            private static _WarningFlashes _WarningFlashesFunc;
            internal static _WarningFlashes WarningFlashes() {
                if (_WarningFlashesFunc == null) {
                    _WarningFlashesFunc =
                        (_WarningFlashes)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightning_warningFlashes"), typeof(_WarningFlashes));
                }
                
                return _WarningFlashesFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ApplyDamage__Args
            {
                internal IntPtr hitPosition;
                internal IntPtr hitNormal;
                internal IntPtr hitObject;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ApplyDamage(IntPtr _this, ApplyDamage__Args args);
            private static _ApplyDamage _ApplyDamageFunc;
            internal static _ApplyDamage ApplyDamage() {
                if (_ApplyDamageFunc == null) {
                    _ApplyDamageFunc =
                        (_ApplyDamage)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbLightning_applyDamage"), typeof(_ApplyDamage));
                }
                
                return _ApplyDamageFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightning_staticGetType"), typeof(_StaticGetType));
                }
                
                return _StaticGetTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightning_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void StrikeObject(ShapeBase pSB = null) {
             InternalUnsafeMethods.StrikeObject__Args _args = new InternalUnsafeMethods.StrikeObject__Args() {
                pSB = pSB.ObjectPtr,
             };
             InternalUnsafeMethods.StrikeObject()(ObjectPtr, _args);
        }

        public void StrikeRandomPoint() {
             InternalUnsafeMethods.StrikeRandomPoint__Args _args = new InternalUnsafeMethods.StrikeRandomPoint__Args() {
             };
             InternalUnsafeMethods.StrikeRandomPoint()(ObjectPtr, _args);
        }

        public void WarningFlashes() {
             InternalUnsafeMethods.WarningFlashes__Args _args = new InternalUnsafeMethods.WarningFlashes__Args() {
             };
             InternalUnsafeMethods.WarningFlashes()(ObjectPtr, _args);
        }

        public virtual void ApplyDamage(Point3F hitPosition, Point3F hitNormal, SceneObject hitObject) {
hitPosition.Alloc();hitNormal.Alloc();             InternalUnsafeMethods.ApplyDamage__Args _args = new InternalUnsafeMethods.ApplyDamage__Args() {
                hitPosition = hitPosition.internalStructPtr,
                hitNormal = hitNormal.internalStructPtr,
                hitObject = hitObject.ObjectPtr,
             };
             InternalUnsafeMethods.ApplyDamage()(ObjectPtr, _args);
hitPosition.Free();hitNormal.Free();        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int StrikesPerMinute {
            get => GenericMarshal.StringTo<int>(GetFieldValue("strikesPerMinute"));
            set => SetFieldValue("strikesPerMinute", GenericMarshal.ToString(value));
        }

        public float StrikeWidth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("strikeWidth"));
            set => SetFieldValue("strikeWidth", GenericMarshal.ToString(value));
        }

        public float StrikeRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("strikeRadius"));
            set => SetFieldValue("strikeRadius", GenericMarshal.ToString(value));
        }

        public LinearColorF Color {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }

        public LinearColorF FadeColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fadeColor"));
            set => SetFieldValue("fadeColor", GenericMarshal.ToString(value));
        }

        public float ChanceToHitTarget {
            get => GenericMarshal.StringTo<float>(GetFieldValue("chanceToHitTarget"));
            set => SetFieldValue("chanceToHitTarget", GenericMarshal.ToString(value));
        }

        public float BoltStartRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boltStartRadius"));
            set => SetFieldValue("boltStartRadius", GenericMarshal.ToString(value));
        }

        public bool UseFog {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useFog"));
            set => SetFieldValue("useFog", GenericMarshal.ToString(value));
        }
    }
}