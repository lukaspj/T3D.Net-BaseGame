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

    public unsafe class GuiIdleCamFadeBitmapCtrl : GuiBitmapCtrl {



        public GuiIdleCamFadeBitmapCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiIdleCamFadeBitmapCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiIdleCamFadeBitmapCtrl(string pName)
            : this(pName, false) {
        }

        public GuiIdleCamFadeBitmapCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiIdleCamFadeBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiIdleCamFadeBitmapCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiIdleCamFadeBitmapCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct FadeOut__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _FadeOut(IntPtr _this);
                internal delegate void _FadeOut(IntPtr _this, FadeOut__Args args);
                private static _FadeOut _FadeOutFunc;
                internal static _FadeOut FadeOut() {
                    if (_FadeOutFunc == null) {
                        _FadeOutFunc =
                            (_FadeOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiIdleCamFadeBitmapCtrl_fadeOut"), typeof(_FadeOut));
                    }

                    return _FadeOutFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FadeIn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _FadeIn(IntPtr _this);
                internal delegate void _FadeIn(IntPtr _this, FadeIn__Args args);
                private static _FadeIn _FadeInFunc;
                internal static _FadeIn FadeIn() {
                    if (_FadeInFunc == null) {
                        _FadeInFunc =
                            (_FadeIn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiIdleCamFadeBitmapCtrl_fadeIn"), typeof(_FadeIn));
                    }

                    return _FadeInFunc;
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
                                    "fnGuiIdleCamFadeBitmapCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiIdleCamFadeBitmapCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void FadeOut() {

                     InternalUnsafeMethods.FadeOut__Args _args = new InternalUnsafeMethods.FadeOut__Args() {
                     };
                     InternalUnsafeMethods.FadeOut()(ObjectPtr, _args);

                  }



                  public void FadeIn() {

                     InternalUnsafeMethods.FadeIn__Args _args = new InternalUnsafeMethods.FadeIn__Args() {
                     };
                     InternalUnsafeMethods.FadeIn()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public int FadeInTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        public int FadeOutTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }


        public bool Done {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("done"));
            set => SetFieldValue("done", GenericMarshal.ToString(value));
        }


    }
}
