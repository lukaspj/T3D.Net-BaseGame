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
    public unsafe class ScriptTickObject : ScriptObject {
        public ScriptTickObject(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ScriptTickObject(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ScriptTickObject(string pName) 
            : this(pName, false) {
        }
        
        public ScriptTickObject(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ScriptTickObject(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ScriptTickObject(SimObject pObj) 
            : base(pObj) {
        }
        
        public ScriptTickObject(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsProcessingTicks__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsProcessingTicks(IntPtr _this, IsProcessingTicks__Args args);
            private static _IsProcessingTicks _IsProcessingTicksFunc;
            internal static _IsProcessingTicks IsProcessingTicks() {
                if (_IsProcessingTicksFunc == null) {
                    _IsProcessingTicksFunc =
                        (_IsProcessingTicks)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScriptTickObject_isProcessingTicks"), typeof(_IsProcessingTicks));
                }
                
                return _IsProcessingTicksFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetProcessTicks__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool tick;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetProcessTicks(IntPtr _this, SetProcessTicks__Args args);
            private static _SetProcessTicks _SetProcessTicksFunc;
            internal static _SetProcessTicks SetProcessTicks() {
                if (_SetProcessTicksFunc == null) {
                    _SetProcessTicksFunc =
                        (_SetProcessTicks)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScriptTickObject_setProcessTicks"), typeof(_SetProcessTicks));
                }
                
                return _SetProcessTicksFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdvanceTime__Args
            {
                internal float timeDelta;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdvanceTime(IntPtr _this, OnAdvanceTime__Args args);
            private static _OnAdvanceTime _OnAdvanceTimeFunc;
            internal static _OnAdvanceTime OnAdvanceTime() {
                if (_OnAdvanceTimeFunc == null) {
                    _OnAdvanceTimeFunc =
                        (_OnAdvanceTime)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbScriptTickObject_onAdvanceTime"), typeof(_OnAdvanceTime));
                }
                
                return _OnAdvanceTimeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnProcessTick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnProcessTick(IntPtr _this, OnProcessTick__Args args);
            private static _OnProcessTick _OnProcessTickFunc;
            internal static _OnProcessTick OnProcessTick() {
                if (_OnProcessTickFunc == null) {
                    _OnProcessTickFunc =
                        (_OnProcessTick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbScriptTickObject_onProcessTick"), typeof(_OnProcessTick));
                }
                
                return _OnProcessTickFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnInterpolateTick__Args
            {
                internal float delta;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnInterpolateTick(IntPtr _this, OnInterpolateTick__Args args);
            private static _OnInterpolateTick _OnInterpolateTickFunc;
            internal static _OnInterpolateTick OnInterpolateTick() {
                if (_OnInterpolateTickFunc == null) {
                    _OnInterpolateTickFunc =
                        (_OnInterpolateTick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbScriptTickObject_onInterpolateTick"), typeof(_OnInterpolateTick));
                }
                
                return _OnInterpolateTickFunc;
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
                                "fnScriptTickObject_staticGetType"), typeof(_StaticGetType));
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
                                "fnScriptTickObject_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool IsProcessingTicks() {
             InternalUnsafeMethods.IsProcessingTicks__Args _args = new InternalUnsafeMethods.IsProcessingTicks__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsProcessingTicks()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetProcessTicks(bool tick) {
             InternalUnsafeMethods.SetProcessTicks__Args _args = new InternalUnsafeMethods.SetProcessTicks__Args() {
                tick = tick,
             };
             InternalUnsafeMethods.SetProcessTicks()(ObjectPtr, _args);
        }

        public void OnAdvanceTime(float timeDelta) {
             InternalUnsafeMethods.OnAdvanceTime__Args _args = new InternalUnsafeMethods.OnAdvanceTime__Args() {
                timeDelta = timeDelta,
             };
             InternalUnsafeMethods.OnAdvanceTime()(ObjectPtr, _args);
        }

        public void OnProcessTick() {
             InternalUnsafeMethods.OnProcessTick__Args _args = new InternalUnsafeMethods.OnProcessTick__Args() {
             };
             InternalUnsafeMethods.OnProcessTick()(ObjectPtr, _args);
        }

        public void OnInterpolateTick(float delta) {
             InternalUnsafeMethods.OnInterpolateTick__Args _args = new InternalUnsafeMethods.OnInterpolateTick__Args() {
                delta = delta,
             };
             InternalUnsafeMethods.OnInterpolateTick()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool CallOnAdvanceTime {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("callOnAdvanceTime"));
            set => SetFieldValue("callOnAdvanceTime", GenericMarshal.ToString(value));
        }
    }
}