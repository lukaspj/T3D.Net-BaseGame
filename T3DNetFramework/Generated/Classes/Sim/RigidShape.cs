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
    public unsafe class RigidShape : ShapeBase {
        public RigidShape(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RigidShape(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public RigidShape(string pName) 
            : this(pName, false) {
        }
        
        public RigidShape(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public RigidShape(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public RigidShape(SimObject pObj) 
            : base(pObj) {
        }
        
        public RigidShape(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ForceClientTransform__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ForceClientTransform(IntPtr _this, ForceClientTransform__Args args);
            private static _ForceClientTransform _ForceClientTransformFunc;
            internal static _ForceClientTransform ForceClientTransform() {
                if (_ForceClientTransformFunc == null) {
                    _ForceClientTransformFunc =
                        (_ForceClientTransform)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRigidShape_forceClientTransform"), typeof(_ForceClientTransform));
                }
                
                return _ForceClientTransformFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct FreezeSim__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool isFrozen;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FreezeSim(IntPtr _this, FreezeSim__Args args);
            private static _FreezeSim _FreezeSimFunc;
            internal static _FreezeSim FreezeSim() {
                if (_FreezeSimFunc == null) {
                    _FreezeSimFunc =
                        (_FreezeSim)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRigidShape_freezeSim"), typeof(_FreezeSim));
                }
                
                return _FreezeSimFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
                if (_ResetFunc == null) {
                    _ResetFunc =
                        (_Reset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRigidShape_reset"), typeof(_Reset));
                }
                
                return _ResetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveLiquid__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string liquidType;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveLiquid(IntPtr _this, OnLeaveLiquid__Args args);
            private static _OnLeaveLiquid _OnLeaveLiquidFunc;
            internal static _OnLeaveLiquid OnLeaveLiquid() {
                if (_OnLeaveLiquidFunc == null) {
                    _OnLeaveLiquidFunc =
                        (_OnLeaveLiquid)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbRigidShape_onLeaveLiquid"), typeof(_OnLeaveLiquid));
                }
                
                return _OnLeaveLiquidFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterLiquid__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objId;
                internal float waterCoverage;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string liquidType;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterLiquid(IntPtr _this, OnEnterLiquid__Args args);
            private static _OnEnterLiquid _OnEnterLiquidFunc;
            internal static _OnEnterLiquid OnEnterLiquid() {
                if (_OnEnterLiquidFunc == null) {
                    _OnEnterLiquidFunc =
                        (_OnEnterLiquid)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbRigidShape_onEnterLiquid"), typeof(_OnEnterLiquid));
                }
                
                return _OnEnterLiquidFunc;
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
                                "fnRigidShape_staticGetType"), typeof(_StaticGetType));
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
                                "fnRigidShape_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void ForceClientTransform() {
             InternalUnsafeMethods.ForceClientTransform__Args _args = new InternalUnsafeMethods.ForceClientTransform__Args() {
             };
             InternalUnsafeMethods.ForceClientTransform()(ObjectPtr, _args);
        }

        public void FreezeSim(bool isFrozen) {
             InternalUnsafeMethods.FreezeSim__Args _args = new InternalUnsafeMethods.FreezeSim__Args() {
                isFrozen = isFrozen,
             };
             InternalUnsafeMethods.FreezeSim()(ObjectPtr, _args);
        }

        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        public void OnLeaveLiquid(string objId, string liquidType) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                objId = objId,
                liquidType = liquidType,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        public void OnEnterLiquid(string objId, float waterCoverage, string liquidType) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                objId = objId,
                waterCoverage = waterCoverage,
                liquidType = liquidType,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}