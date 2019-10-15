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
    public unsafe class GuiFilterCtrl : GuiControl {
        public GuiFilterCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiFilterCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiFilterCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiFilterCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiFilterCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiFilterCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiFilterCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetFiltering__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetFiltering(IntPtr _this, ResetFiltering__Args args);
            private static _ResetFiltering _ResetFilteringFunc;
            internal static _ResetFiltering ResetFiltering() {
                if (_ResetFilteringFunc == null) {
                    _ResetFilteringFunc =
                        (_ResetFiltering)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiFilterCtrl_resetFiltering"), typeof(_ResetFiltering));
                }
                
                return _ResetFilteringFunc;
            }


            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, ref StringVector.InternalStruct args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
                if (_SetValueFunc == null) {
                    _SetValueFunc =
                        (_SetValue)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiFilterCtrl_setValue"), typeof(_SetValue));
                }
                
                return _SetValueFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetValue(IntPtr _this, GetValue__Args args);
            private static _GetValue _GetValueFunc;
            internal static _GetValue GetValue() {
                if (_GetValueFunc == null) {
                    _GetValueFunc =
                        (_GetValue)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiFilterCtrl_getValue"), typeof(_GetValue));
                }
                
                return _GetValueFunc;
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
                                "fnGuiFilterCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiFilterCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void ResetFiltering() {
             InternalUnsafeMethods.ResetFiltering__Args _args = new InternalUnsafeMethods.ResetFiltering__Args() {
             };
             InternalUnsafeMethods.ResetFiltering()(ObjectPtr, _args);
        }

        public void SetValue(params string[] args) { 
            List<string> _argList = new List<string>() {"", ""};
            _argList.AddRange(args);

            StringVector nativeVecArgs = new StringVector {
                ElementCount = (uint)_argList.Count,
                Array = _argList.ToArray(),
                ArraySize = (uint)_argList.Count
            };
            nativeVecArgs.Alloc();
            InternalUnsafeMethods.SetValue()(ObjectPtr, ref nativeVecArgs.internalStruct);
            nativeVecArgs.Free();

        }

        public string GetValue() {
             InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public int ControlPoints {
            get => GenericMarshal.StringTo<int>(GetFieldValue("controlPoints"));
            set => SetFieldValue("controlPoints", GenericMarshal.ToString(value));
        }

        public FloatVector Filter {
            get => GenericMarshal.StringTo<FloatVector>(GetFieldValue("filter"));
            set => SetFieldValue("filter", GenericMarshal.ToString(value));
        }

        public bool ShowIdentity {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showIdentity"));
            set => SetFieldValue("showIdentity", GenericMarshal.ToString(value));
        }

        public Point2F Identity {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("identity"));
            set => SetFieldValue("identity", GenericMarshal.ToString(value));
        }
    }
}