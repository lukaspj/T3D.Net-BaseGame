using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
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

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxSpellButton : GuiButtonCtrl {



        public afxSpellButton(bool pRegister = false)
            : base(pRegister) {
        }

        public afxSpellButton(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxSpellButton(string pName)
            : this(pName, false) {
        }

        public afxSpellButton(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxSpellButton(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxSpellButton(SimObject pObj)
            : base(pObj) {
        }

        public afxSpellButton(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFreeTargetStyle__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetFreeTargetStyle(IntPtr _this);
                internal delegate int _GetFreeTargetStyle(IntPtr _this, GetFreeTargetStyle__Args args);
                private static _GetFreeTargetStyle _GetFreeTargetStyleFunc;
                internal static _GetFreeTargetStyle GetFreeTargetStyle() {
                    if (_GetFreeTargetStyleFunc == null) {
                        _GetFreeTargetStyleFunc =
                            (_GetFreeTargetStyle)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_getFreeTargetStyle"), typeof(_GetFreeTargetStyle));
                    }

                    return _GetFreeTargetStyleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct UseFreeTargeting__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _UseFreeTargeting(IntPtr _this);
                internal delegate bool _UseFreeTargeting(IntPtr _this, UseFreeTargeting__Args args);
                private static _UseFreeTargeting _UseFreeTargetingFunc;
                internal static _UseFreeTargeting UseFreeTargeting() {
                    if (_UseFreeTargetingFunc == null) {
                        _UseFreeTargetingFunc =
                            (_UseFreeTargeting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_useFreeTargeting"), typeof(_UseFreeTargeting));
                    }

                    return _UseFreeTargetingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSpellRPGDataBlock__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetSpellRPGDataBlock(IntPtr _this);
                internal delegate int _GetSpellRPGDataBlock(IntPtr _this, GetSpellRPGDataBlock__Args args);
                private static _GetSpellRPGDataBlock _GetSpellRPGDataBlockFunc;
                internal static _GetSpellRPGDataBlock GetSpellRPGDataBlock() {
                    if (_GetSpellRPGDataBlockFunc == null) {
                        _GetSpellRPGDataBlockFunc =
                            (_GetSpellRPGDataBlock)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_getSpellRPGDataBlock"), typeof(_GetSpellRPGDataBlock));
                    }

                    return _GetSpellRPGDataBlockFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSpellDataBlock__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetSpellDataBlock(IntPtr _this);
                internal delegate int _GetSpellDataBlock(IntPtr _this, GetSpellDataBlock__Args args);
                private static _GetSpellDataBlock _GetSpellDataBlockFunc;
                internal static _GetSpellDataBlock GetSpellDataBlock() {
                    if (_GetSpellDataBlockFunc == null) {
                        _GetSpellDataBlockFunc =
                            (_GetSpellDataBlock)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_getSpellDataBlock"), typeof(_GetSpellDataBlock));
                    }

                    return _GetSpellDataBlockFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSpellDescription__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetSpellDescription(IntPtr _this);
                internal delegate IntPtr _GetSpellDescription(IntPtr _this, GetSpellDescription__Args args);
                private static _GetSpellDescription _GetSpellDescriptionFunc;
                internal static _GetSpellDescription GetSpellDescription() {
                    if (_GetSpellDescriptionFunc == null) {
                        _GetSpellDescriptionFunc =
                            (_GetSpellDescription)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_getSpellDescription"), typeof(_GetSpellDescription));
                    }

                    return _GetSpellDescriptionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnTurnPage__Args
                {

				   internal uint page;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnTurnPage(IntPtr _this, uint page);
                internal delegate void _OnTurnPage(IntPtr _this, OnTurnPage__Args args);
                private static _OnTurnPage _OnTurnPageFunc;
                internal static _OnTurnPage OnTurnPage() {
                    if (_OnTurnPageFunc == null) {
                        _OnTurnPageFunc =
                            (_OnTurnPage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_onTurnPage"), typeof(_OnTurnPage));
                    }

                    return _OnTurnPageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnSpellbookChange__Args
                {

				   internal IntPtr spellbook;

				   internal uint page;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnSpellbookChange(IntPtr _this, IntPtr spellbook, uint page);
                internal delegate void _OnSpellbookChange(IntPtr _this, OnSpellbookChange__Args args);
                private static _OnSpellbookChange _OnSpellbookChangeFunc;
                internal static _OnSpellbookChange OnSpellbookChange() {
                    if (_OnSpellbookChangeFunc == null) {
                        _OnSpellbookChangeFunc =
                            (_OnSpellbookChange)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxSpellButton_onSpellbookChange"), typeof(_OnSpellbookChange));
                    }

                    return _OnSpellbookChangeFunc;
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
                                    "fnafxSpellButton_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxSpellButton_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public int GetFreeTargetStyle() {

                     InternalUnsafeMethods.GetFreeTargetStyle__Args _args = new InternalUnsafeMethods.GetFreeTargetStyle__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetFreeTargetStyle()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool UseFreeTargeting() {

                     InternalUnsafeMethods.UseFreeTargeting__Args _args = new InternalUnsafeMethods.UseFreeTargeting__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.UseFreeTargeting()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetSpellRPGDataBlock() {

                     InternalUnsafeMethods.GetSpellRPGDataBlock__Args _args = new InternalUnsafeMethods.GetSpellRPGDataBlock__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSpellRPGDataBlock()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetSpellDataBlock() {

                     InternalUnsafeMethods.GetSpellDataBlock__Args _args = new InternalUnsafeMethods.GetSpellDataBlock__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSpellDataBlock()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetSpellDescription() {

                     InternalUnsafeMethods.GetSpellDescription__Args _args = new InternalUnsafeMethods.GetSpellDescription__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSpellDescription()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void OnTurnPage(uint page) {

                                          InternalUnsafeMethods.OnTurnPage__Args _args = new InternalUnsafeMethods.OnTurnPage__Args() {
                        page = page,
                     };
                     InternalUnsafeMethods.OnTurnPage()(ObjectPtr, _args);

                  }



                  public void OnSpellbookChange(afxSpellBook spellbook, uint page) {

                                                               InternalUnsafeMethods.OnSpellbookChange__Args _args = new InternalUnsafeMethods.OnSpellbookChange__Args() {
                        spellbook = spellbook.ObjectPtr,
                        page = page,
                     };
                     InternalUnsafeMethods.OnSpellbookChange()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("bitmap"));
            set => SetFieldValue("bitmap", GenericMarshal.ToString(value));
        }


        public Point2I Book_slot {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("book_slot"));
            set => SetFieldValue("book_slot", GenericMarshal.ToString(value));
        }


    }
}
