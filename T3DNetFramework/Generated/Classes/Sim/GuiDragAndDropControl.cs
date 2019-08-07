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

    public unsafe class GuiDragAndDropControl : GuiControl {



        public GuiDragAndDropControl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiDragAndDropControl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiDragAndDropControl(string pName)
            : this(pName, false) {
        }

        public GuiDragAndDropControl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiDragAndDropControl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiDragAndDropControl(SimObject pObj)
            : base(pObj) {
        }

        public GuiDragAndDropControl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct StartDragging__Args
                {

				   internal int x;

				   internal int y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _StartDragging(IntPtr _this, int x, int y);
                internal delegate void _StartDragging(IntPtr _this, StartDragging__Args args);
                private static _StartDragging _StartDraggingFunc;
                internal static _StartDragging StartDragging() {
                    if (_StartDraggingFunc == null) {
                        _StartDraggingFunc =
                            (_StartDragging)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiDragAndDropControl_startDragging"), typeof(_StartDragging));
                    }

                    return _StartDraggingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlDragCancelled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlDragCancelled(IntPtr _this);
                internal delegate void _OnControlDragCancelled(IntPtr _this, OnControlDragCancelled__Args args);
                private static _OnControlDragCancelled _OnControlDragCancelledFunc;
                internal static _OnControlDragCancelled OnControlDragCancelled() {
                    if (_OnControlDragCancelledFunc == null) {
                        _OnControlDragCancelledFunc =
                            (_OnControlDragCancelled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiDragAndDropControl_onControlDragCancelled"), typeof(_OnControlDragCancelled));
                    }

                    return _OnControlDragCancelledFunc;
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
                                    "fnGuiDragAndDropControl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiDragAndDropControl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void StartDragging(int x = 0, int y = 0) {

                                                               InternalUnsafeMethods.StartDragging__Args _args = new InternalUnsafeMethods.StartDragging__Args() {
                        x = x,
                        y = y,
                     };
                     InternalUnsafeMethods.StartDragging()(ObjectPtr, _args);

                  }



                  public void OnControlDragCancelled() {

                     InternalUnsafeMethods.OnControlDragCancelled__Args _args = new InternalUnsafeMethods.OnControlDragCancelled__Args() {
                     };
                     InternalUnsafeMethods.OnControlDragCancelled()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool DeleteOnMouseUp {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("deleteOnMouseUp"));
            set => SetFieldValue("deleteOnMouseUp", GenericMarshal.ToString(value));
        }


        public bool UseWholeCanvas {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useWholeCanvas"));
            set => SetFieldValue("useWholeCanvas", GenericMarshal.ToString(value));
        }


    }
}
