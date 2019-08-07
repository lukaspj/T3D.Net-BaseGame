using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
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
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiPaneControl : GuiControl {



        public GuiPaneControl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiPaneControl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiPaneControl(string pName)
            : this(pName, false) {
        }

        public GuiPaneControl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiPaneControl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiPaneControl(SimObject pObj)
            : base(pObj) {
        }

        public GuiPaneControl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCollapsed__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool collapse;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetCollapsed(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool collapse);
                internal delegate void _SetCollapsed(IntPtr _this, SetCollapsed__Args args);
                private static _SetCollapsed _SetCollapsedFunc;
                internal static _SetCollapsed SetCollapsed() {
                    if (_SetCollapsedFunc == null) {
                        _SetCollapsedFunc =
                            (_SetCollapsed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPaneControl_setCollapsed"), typeof(_SetCollapsed));
                    }

                    return _SetCollapsedFunc;
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
                                    "fnGuiPaneControl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiPaneControl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetCollapsed(bool collapse) {

                                          InternalUnsafeMethods.SetCollapsed__Args _args = new InternalUnsafeMethods.SetCollapsed__Args() {
                        collapse = collapse,
                     };
                     InternalUnsafeMethods.SetCollapsed()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        public string CaptionID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("captionID"));
            set => SetFieldValue("captionID", GenericMarshal.ToString(value));
        }


        public bool Collapsable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("collapsable"));
            set => SetFieldValue("collapsable", GenericMarshal.ToString(value));
        }


        public bool BarBehindText {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("barBehindText"));
            set => SetFieldValue("barBehindText", GenericMarshal.ToString(value));
        }


    }
}
