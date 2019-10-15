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
    public unsafe class RenderPassStateToken : SimObject {
        public RenderPassStateToken(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RenderPassStateToken(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public RenderPassStateToken(string pName) 
            : this(pName, false) {
        }
        
        public RenderPassStateToken(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public RenderPassStateToken(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public RenderPassStateToken(SimObject pObj) 
            : base(pObj) {
        }
        
        public RenderPassStateToken(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Toggle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Toggle(IntPtr _this, Toggle__Args args);
            private static _Toggle _ToggleFunc;
            internal static _Toggle Toggle() {
                if (_ToggleFunc == null) {
                    _ToggleFunc =
                        (_Toggle)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRenderPassStateToken_toggle"), typeof(_Toggle));
                }
                
                return _ToggleFunc;
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
                                "fnRenderPassStateToken_disable"), typeof(_Disable));
                }
                
                return _DisableFunc;
            }

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
                                "fnRenderPassStateToken_enable"), typeof(_Enable));
                }
                
                return _EnableFunc;
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
                                "fnRenderPassStateToken_staticGetType"), typeof(_StaticGetType));
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
                                "fnRenderPassStateToken_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Toggle() {
             InternalUnsafeMethods.Toggle__Args _args = new InternalUnsafeMethods.Toggle__Args() {
             };
             InternalUnsafeMethods.Toggle()(ObjectPtr, _args);
        }

        public void Disable() {
             InternalUnsafeMethods.Disable__Args _args = new InternalUnsafeMethods.Disable__Args() {
             };
             InternalUnsafeMethods.Disable()(ObjectPtr, _args);
        }

        public void Enable() {
             InternalUnsafeMethods.Enable__Args _args = new InternalUnsafeMethods.Enable__Args() {
             };
             InternalUnsafeMethods.Enable()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool Enabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enabled"));
            set => SetFieldValue("enabled", GenericMarshal.ToString(value));
        }
    }
}