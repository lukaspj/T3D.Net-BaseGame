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
    public unsafe class GuiMessageVectorCtrl : GuiControl {
        public GuiMessageVectorCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiMessageVectorCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiMessageVectorCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiMessageVectorCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiMessageVectorCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiMessageVectorCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiMessageVectorCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Detach__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Detach(IntPtr _this, Detach__Args args);
            private static _Detach _DetachFunc;
            internal static _Detach Detach() {
                if (_DetachFunc == null) {
                    _DetachFunc =
                        (_Detach)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMessageVectorCtrl_detach"), typeof(_Detach));
                }
                
                return _DetachFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Attach__Args
            {
                internal IntPtr item;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Attach(IntPtr _this, Attach__Args args);
            private static _Attach _AttachFunc;
            internal static _Attach Attach() {
                if (_AttachFunc == null) {
                    _AttachFunc =
                        (_Attach)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMessageVectorCtrl_attach"), typeof(_Attach));
                }
                
                return _AttachFunc;
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
                                "fnGuiMessageVectorCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiMessageVectorCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Detach() {
             InternalUnsafeMethods.Detach__Args _args = new InternalUnsafeMethods.Detach__Args() {
             };
             InternalUnsafeMethods.Detach()(ObjectPtr, _args);
        }

        public bool Attach(MessageVector item) {
             InternalUnsafeMethods.Attach__Args _args = new InternalUnsafeMethods.Attach__Args() {
                item = item.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.Attach()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int LineSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lineSpacing"));
            set => SetFieldValue("lineSpacing", GenericMarshal.ToString(value));
        }

        public int LineContinuedIndex {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lineContinuedIndex"));
            set => SetFieldValue("lineContinuedIndex", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<string> AllowedMatches {
            get => new DynamicFieldVector<string>(
                    this, 
                    "allowedMatches", 
                    16, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public ColorI MatchColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("matchColor"));
            set => SetFieldValue("matchColor", GenericMarshal.ToString(value));
        }

        public int MaxColorIndex {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxColorIndex"));
            set => SetFieldValue("maxColorIndex", GenericMarshal.ToString(value));
        }
    }
}