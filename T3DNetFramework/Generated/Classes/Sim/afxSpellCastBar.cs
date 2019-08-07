using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxSpellCastBar : GuiControl {



        public afxSpellCastBar(bool pRegister = false)
            : base(pRegister) {
        }

        public afxSpellCastBar(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxSpellCastBar(string pName)
            : this(pName, false) {
        }

        public afxSpellCastBar(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxSpellCastBar(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxSpellCastBar(SimObject pObj)
            : base(pObj) {
        }

        public afxSpellCastBar(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetProgress__Args
                {

				   internal float percentDone;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetProgress(IntPtr _this, float percentDone);
                internal delegate void _SetProgress(IntPtr _this, SetProgress__Args args);
                private static _SetProgress _SetProgressFunc;
                internal static _SetProgress SetProgress() {
                    if (_SetProgressFunc == null) {
                        _SetProgressFunc =
                            (_SetProgress)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellCastBar_setProgress"), typeof(_SetProgress));
                    }

                    return _SetProgressFunc;
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
                                    "fnafxSpellCastBar_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxSpellCastBar_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void SetProgress(float percentDone) {

                                          InternalUnsafeMethods.SetProgress__Args _args = new InternalUnsafeMethods.SetProgress__Args() {
                        percentDone = percentDone,
                     };
                     InternalUnsafeMethods.SetProgress()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public LinearColorF BackgroundColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("backgroundColor"));
            set => SetFieldValue("backgroundColor", GenericMarshal.ToString(value));
        }


        public LinearColorF BorderColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }


        public LinearColorF FillColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fillColor"));
            set => SetFieldValue("fillColor", GenericMarshal.ToString(value));
        }


        public LinearColorF FillColorFinal {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fillColorFinal"));
            set => SetFieldValue("fillColorFinal", GenericMarshal.ToString(value));
        }


    }
}
