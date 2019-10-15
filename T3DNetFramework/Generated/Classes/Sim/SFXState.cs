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
    public unsafe class SFXState : SimDataBlock {
        public SFXState(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SFXState(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SFXState(string pName) 
            : this(pName, false) {
        }
        
        public SFXState(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SFXState(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SFXState(SimObject pObj) 
            : base(pObj) {
        }
        
        public SFXState(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Enable__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Enable(IntPtr _this, Enable__Args args);
            private static _Enable _EnableFunc;
            internal static _Enable Enable() {
                if (_EnableFunc == null) {
                    _EnableFunc =
                        (_Enable)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_enable"), typeof(_Enable));
                }
                
                return _EnableFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Disable__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Disable(IntPtr _this, Disable__Args args);
            private static _Disable _DisableFunc;
            internal static _Disable Disable() {
                if (_DisableFunc == null) {
                    _DisableFunc =
                        (_Disable)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_disable"), typeof(_Disable));
                }
                
                return _DisableFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsDisabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsDisabled(IntPtr _this, IsDisabled__Args args);
            private static _IsDisabled _IsDisabledFunc;
            internal static _IsDisabled IsDisabled() {
                if (_IsDisabledFunc == null) {
                    _IsDisabledFunc =
                        (_IsDisabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_isDisabled"), typeof(_IsDisabled));
                }
                
                return _IsDisabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Deactivate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Deactivate(IntPtr _this, Deactivate__Args args);
            private static _Deactivate _DeactivateFunc;
            internal static _Deactivate Deactivate() {
                if (_DeactivateFunc == null) {
                    _DeactivateFunc =
                        (_Deactivate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_deactivate"), typeof(_Deactivate));
                }
                
                return _DeactivateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Activate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Activate(IntPtr _this, Activate__Args args);
            private static _Activate _ActivateFunc;
            internal static _Activate Activate() {
                if (_ActivateFunc == null) {
                    _ActivateFunc =
                        (_Activate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_activate"), typeof(_Activate));
                }
                
                return _ActivateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsActive__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsActive(IntPtr _this, IsActive__Args args);
            private static _IsActive _IsActiveFunc;
            internal static _IsActive IsActive() {
                if (_IsActiveFunc == null) {
                    _IsActiveFunc =
                        (_IsActive)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSFXState_isActive"), typeof(_IsActive));
                }
                
                return _IsActiveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDeactivate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDeactivate(IntPtr _this, OnDeactivate__Args args);
            private static _OnDeactivate _OnDeactivateFunc;
            internal static _OnDeactivate OnDeactivate() {
                if (_OnDeactivateFunc == null) {
                    _OnDeactivateFunc =
                        (_OnDeactivate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbSFXState_onDeactivate"), typeof(_OnDeactivate));
                }
                
                return _OnDeactivateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnActivate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnActivate(IntPtr _this, OnActivate__Args args);
            private static _OnActivate _OnActivateFunc;
            internal static _OnActivate OnActivate() {
                if (_OnActivateFunc == null) {
                    _OnActivateFunc =
                        (_OnActivate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbSFXState_onActivate"), typeof(_OnActivate));
                }
                
                return _OnActivateFunc;
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
                                "fnSFXState_staticGetType"), typeof(_StaticGetType));
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
                                "fnSFXState_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Enable() {
             InternalUnsafeMethods.Enable__Args _args = new InternalUnsafeMethods.Enable__Args() {
             };
             InternalUnsafeMethods.Enable()(ObjectPtr, _args);
        }

        public void Disable() {
             InternalUnsafeMethods.Disable__Args _args = new InternalUnsafeMethods.Disable__Args() {
             };
             InternalUnsafeMethods.Disable()(ObjectPtr, _args);
        }

        public bool IsDisabled() {
             InternalUnsafeMethods.IsDisabled__Args _args = new InternalUnsafeMethods.IsDisabled__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsDisabled()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Deactivate() {
             InternalUnsafeMethods.Deactivate__Args _args = new InternalUnsafeMethods.Deactivate__Args() {
             };
             InternalUnsafeMethods.Deactivate()(ObjectPtr, _args);
        }

        public void Activate() {
             InternalUnsafeMethods.Activate__Args _args = new InternalUnsafeMethods.Activate__Args() {
             };
             InternalUnsafeMethods.Activate()(ObjectPtr, _args);
        }

        public bool IsActive() {
             InternalUnsafeMethods.IsActive__Args _args = new InternalUnsafeMethods.IsActive__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsActive()(ObjectPtr, _args);
             return _engineResult;
        }

        public virtual void OnDeactivate() {
             InternalUnsafeMethods.OnDeactivate__Args _args = new InternalUnsafeMethods.OnDeactivate__Args() {
             };
             InternalUnsafeMethods.OnDeactivate()(ObjectPtr, _args);
        }

        public virtual void OnActivate() {
             InternalUnsafeMethods.OnActivate__Args _args = new InternalUnsafeMethods.OnActivate__Args() {
             };
             InternalUnsafeMethods.OnActivate()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public DynamicFieldVector<SFXState> IncludedStates {
            get => new DynamicFieldVector<SFXState>(
                    this, 
                    "includedStates", 
                    4, 
                    val => GenericMarshal.StringTo<SFXState>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<SFXState> ExcludedStates {
            get => new DynamicFieldVector<SFXState>(
                    this, 
                    "excludedStates", 
                    4, 
                    val => GenericMarshal.StringTo<SFXState>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}