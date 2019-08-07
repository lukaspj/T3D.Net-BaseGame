using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiDynamicCtrlArrayControl : GuiControl {



        public GuiDynamicCtrlArrayControl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiDynamicCtrlArrayControl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiDynamicCtrlArrayControl(string pName)
            : this(pName, false) {
        }

        public GuiDynamicCtrlArrayControl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiDynamicCtrlArrayControl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiDynamicCtrlArrayControl(SimObject pObj)
            : base(pObj) {
        }

        public GuiDynamicCtrlArrayControl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Refresh__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Refresh(IntPtr _this);
                internal delegate void _Refresh(IntPtr _this, Refresh__Args args);
                private static _Refresh _RefreshFunc;
                internal static _Refresh Refresh() {
                    if (_RefreshFunc == null) {
                        _RefreshFunc =
                            (_Refresh)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiDynamicCtrlArrayControl_refresh"), typeof(_Refresh));
                    }

                    return _RefreshFunc;
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
                                    "fnGuiDynamicCtrlArrayControl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiDynamicCtrlArrayControl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Refresh() {

                     InternalUnsafeMethods.Refresh__Args _args = new InternalUnsafeMethods.Refresh__Args() {
                     };
                     InternalUnsafeMethods.Refresh()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public int ColCount {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colCount"));
            set => SetFieldValue("colCount", GenericMarshal.ToString(value));
        }


        public int ColSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colSize"));
            set => SetFieldValue("colSize", GenericMarshal.ToString(value));
        }


        public int RowCount {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rowCount"));
            set => SetFieldValue("rowCount", GenericMarshal.ToString(value));
        }


        public int RowSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rowSize"));
            set => SetFieldValue("rowSize", GenericMarshal.ToString(value));
        }


        public int RowSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rowSpacing"));
            set => SetFieldValue("rowSpacing", GenericMarshal.ToString(value));
        }


        public int ColSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colSpacing"));
            set => SetFieldValue("colSpacing", GenericMarshal.ToString(value));
        }


        public bool Frozen {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("frozen"));
            set => SetFieldValue("frozen", GenericMarshal.ToString(value));
        }


        public bool AutoCellSize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoCellSize"));
            set => SetFieldValue("autoCellSize", GenericMarshal.ToString(value));
        }


        public bool FillRowFirst {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fillRowFirst"));
            set => SetFieldValue("fillRowFirst", GenericMarshal.ToString(value));
        }


        public bool DynamicSize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dynamicSize"));
            set => SetFieldValue("dynamicSize", GenericMarshal.ToString(value));
        }


        public RectSpacingI Padding {
            get => GenericMarshal.StringTo<RectSpacingI>(GetFieldValue("padding"));
            set => SetFieldValue("padding", GenericMarshal.ToString(value));
        }


    }
}
