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
    public unsafe class GuiOffscreenCanvas : GuiCanvas {
        public GuiOffscreenCanvas(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiOffscreenCanvas(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiOffscreenCanvas(string pName) 
            : this(pName, false) {
        }
        
        public GuiOffscreenCanvas(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiOffscreenCanvas(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiOffscreenCanvas(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiOffscreenCanvas(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct MarkDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MarkDirty(IntPtr _this, MarkDirty__Args args);
            private static _MarkDirty _MarkDirtyFunc;
            internal static _MarkDirty MarkDirty() {
                if (_MarkDirtyFunc == null) {
                    _MarkDirtyFunc =
                        (_MarkDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiOffscreenCanvas_markDirty"), typeof(_MarkDirty));
                }
                
                return _MarkDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetTarget(IntPtr _this, ResetTarget__Args args);
            private static _ResetTarget _ResetTargetFunc;
            internal static _ResetTarget ResetTarget() {
                if (_ResetTargetFunc == null) {
                    _ResetTargetFunc =
                        (_ResetTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiOffscreenCanvas_resetTarget"), typeof(_ResetTarget));
                }
                
                return _ResetTargetFunc;
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
                                "fnGuiOffscreenCanvas_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiOffscreenCanvas_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void MarkDirty() {
             InternalUnsafeMethods.MarkDirty__Args _args = new InternalUnsafeMethods.MarkDirty__Args() {
             };
             InternalUnsafeMethods.MarkDirty()(ObjectPtr, _args);
        }

        public void ResetTarget() {
             InternalUnsafeMethods.ResetTarget__Args _args = new InternalUnsafeMethods.ResetTarget__Args() {
             };
             InternalUnsafeMethods.ResetTarget()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public Point2I TargetSize {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("targetSize"));
            set => SetFieldValue("targetSize", GenericMarshal.ToString(value));
        }

        public GFXFormat TargetFormat {
            get => GenericMarshal.StringTo<GFXFormat>(GetFieldValue("targetFormat"));
            set => SetFieldValue("targetFormat", GenericMarshal.ToString(value));
        }

        public string TargetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetName"));
            set => SetFieldValue("targetName", GenericMarshal.ToString(value));
        }

        public bool DynamicTarget {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dynamicTarget"));
            set => SetFieldValue("dynamicTarget", GenericMarshal.ToString(value));
        }

        public bool UseDepth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useDepth"));
            set => SetFieldValue("useDepth", GenericMarshal.ToString(value));
        }
    }
}