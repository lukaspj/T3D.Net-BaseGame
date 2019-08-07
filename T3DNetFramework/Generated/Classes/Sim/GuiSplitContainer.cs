using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiSplitContainer : GuiContainer {



        public GuiSplitContainer(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiSplitContainer(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiSplitContainer(string pName)
            : this(pName, false) {
        }

        public GuiSplitContainer(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiSplitContainer(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiSplitContainer(SimObject pObj)
            : base(pObj) {
        }

        public GuiSplitContainer(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSplitPoint__Args
                {

				   internal IntPtr splitPoint;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetSplitPoint(IntPtr _this, IntPtr splitPoint);
                internal delegate void _SetSplitPoint(IntPtr _this, SetSplitPoint__Args args);
                private static _SetSplitPoint _SetSplitPointFunc;
                internal static _SetSplitPoint SetSplitPoint() {
                    if (_SetSplitPointFunc == null) {
                        _SetSplitPointFunc =
                            (_SetSplitPoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiSplitContainer_setSplitPoint"), typeof(_SetSplitPoint));
                    }

                    return _SetSplitPointFunc;
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
                                    "fnGuiSplitContainer_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiSplitContainer_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetSplitPoint(Point2I splitPoint) {

                     splitPoint.Alloc();                     InternalUnsafeMethods.SetSplitPoint__Args _args = new InternalUnsafeMethods.SetSplitPoint__Args() {
                        splitPoint = splitPoint.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetSplitPoint()(ObjectPtr, _args);
                                          splitPoint.Free();
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public GuiSplitOrientation Orientation {
            get => GenericMarshal.StringTo<GuiSplitOrientation>(GetFieldValue("orientation"));
            set => SetFieldValue("orientation", GenericMarshal.ToString(value));
        }


        public int SplitterSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("splitterSize"));
            set => SetFieldValue("splitterSize", GenericMarshal.ToString(value));
        }


        public Point2I SplitPoint {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("splitPoint"));
            set => SetFieldValue("splitPoint", GenericMarshal.ToString(value));
        }


        public GuiSplitFixedPanel FixedPanel {
            get => GenericMarshal.StringTo<GuiSplitFixedPanel>(GetFieldValue("fixedPanel"));
            set => SetFieldValue("fixedPanel", GenericMarshal.ToString(value));
        }


        public int FixedSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fixedSize"));
            set => SetFieldValue("fixedSize", GenericMarshal.ToString(value));
        }


    }
}
