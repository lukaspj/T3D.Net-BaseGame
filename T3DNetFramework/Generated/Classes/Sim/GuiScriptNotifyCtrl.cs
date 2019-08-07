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

    public unsafe class GuiScriptNotifyCtrl : GuiControl {



        public GuiScriptNotifyCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiScriptNotifyCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiScriptNotifyCtrl(string pName)
            : this(pName, false) {
        }

        public GuiScriptNotifyCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiScriptNotifyCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiScriptNotifyCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiScriptNotifyCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnGainFirstResponder__Args
                {

				   internal uint ID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnGainFirstResponder(IntPtr _this, uint ID);
                internal delegate void _OnGainFirstResponder(IntPtr _this, OnGainFirstResponder__Args args);
                private static _OnGainFirstResponder _OnGainFirstResponderFunc;
                internal static _OnGainFirstResponder OnGainFirstResponder() {
                    if (_OnGainFirstResponderFunc == null) {
                        _OnGainFirstResponderFunc =
                            (_OnGainFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onGainFirstResponder"), typeof(_OnGainFirstResponder));
                    }

                    return _OnGainFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnLoseFirstResponder__Args
                {

				   internal uint ID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnLoseFirstResponder(IntPtr _this, uint ID);
                internal delegate void _OnLoseFirstResponder(IntPtr _this, OnLoseFirstResponder__Args args);
                private static _OnLoseFirstResponder _OnLoseFirstResponderFunc;
                internal static _OnLoseFirstResponder OnLoseFirstResponder() {
                    if (_OnLoseFirstResponderFunc == null) {
                        _OnLoseFirstResponderFunc =
                            (_OnLoseFirstResponder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onLoseFirstResponder"), typeof(_OnLoseFirstResponder));
                    }

                    return _OnLoseFirstResponderFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnParentResized__Args
                {

				   internal uint ID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnParentResized(IntPtr _this, uint ID);
                internal delegate void _OnParentResized(IntPtr _this, OnParentResized__Args args);
                private static _OnParentResized _OnParentResizedFunc;
                internal static _OnParentResized OnParentResized() {
                    if (_OnParentResizedFunc == null) {
                        _OnParentResizedFunc =
                            (_OnParentResized)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onParentResized"), typeof(_OnParentResized));
                    }

                    return _OnParentResizedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnChildResized__Args
                {

				   internal uint ID;

				   internal uint childID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnChildResized(IntPtr _this, uint ID, uint childID);
                internal delegate void _OnChildResized(IntPtr _this, OnChildResized__Args args);
                private static _OnChildResized _OnChildResizedFunc;
                internal static _OnChildResized OnChildResized() {
                    if (_OnChildResizedFunc == null) {
                        _OnChildResizedFunc =
                            (_OnChildResized)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onChildResized"), typeof(_OnChildResized));
                    }

                    return _OnChildResizedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnChildRemoved__Args
                {

				   internal uint ID;

				   internal uint childID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnChildRemoved(IntPtr _this, uint ID, uint childID);
                internal delegate void _OnChildRemoved(IntPtr _this, OnChildRemoved__Args args);
                private static _OnChildRemoved _OnChildRemovedFunc;
                internal static _OnChildRemoved OnChildRemoved() {
                    if (_OnChildRemovedFunc == null) {
                        _OnChildRemovedFunc =
                            (_OnChildRemoved)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onChildRemoved"), typeof(_OnChildRemoved));
                    }

                    return _OnChildRemovedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnChildAdded__Args
                {

				   internal uint ID;

				   internal uint childID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnChildAdded(IntPtr _this, uint ID, uint childID);
                internal delegate void _OnChildAdded(IntPtr _this, OnChildAdded__Args args);
                private static _OnChildAdded _OnChildAddedFunc;
                internal static _OnChildAdded OnChildAdded() {
                    if (_OnChildAddedFunc == null) {
                        _OnChildAddedFunc =
                            (_OnChildAdded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onChildAdded"), typeof(_OnChildAdded));
                    }

                    return _OnChildAddedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnResize__Args
                {

				   internal uint ID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnResize(IntPtr _this, uint ID);
                internal delegate void _OnResize(IntPtr _this, OnResize__Args args);
                private static _OnResize _OnResizeFunc;
                internal static _OnResize OnResize() {
                    if (_OnResizeFunc == null) {
                        _OnResizeFunc =
                            (_OnResize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiScriptNotifyCtrl_onResize"), typeof(_OnResize));
                    }

                    return _OnResizeFunc;
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
                                    "fnGuiScriptNotifyCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiScriptNotifyCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void OnGainFirstResponder(uint ID) {

                                          InternalUnsafeMethods.OnGainFirstResponder__Args _args = new InternalUnsafeMethods.OnGainFirstResponder__Args() {
                        ID = ID,
                     };
                     InternalUnsafeMethods.OnGainFirstResponder()(ObjectPtr, _args);

                  }



                  public void OnLoseFirstResponder(uint ID) {

                                          InternalUnsafeMethods.OnLoseFirstResponder__Args _args = new InternalUnsafeMethods.OnLoseFirstResponder__Args() {
                        ID = ID,
                     };
                     InternalUnsafeMethods.OnLoseFirstResponder()(ObjectPtr, _args);

                  }



                  public void OnParentResized(uint ID) {

                                          InternalUnsafeMethods.OnParentResized__Args _args = new InternalUnsafeMethods.OnParentResized__Args() {
                        ID = ID,
                     };
                     InternalUnsafeMethods.OnParentResized()(ObjectPtr, _args);

                  }



                  public void OnChildResized(uint ID, uint childID) {

                                                               InternalUnsafeMethods.OnChildResized__Args _args = new InternalUnsafeMethods.OnChildResized__Args() {
                        ID = ID,
                        childID = childID,
                     };
                     InternalUnsafeMethods.OnChildResized()(ObjectPtr, _args);

                  }



                  public void OnChildRemoved(uint ID, uint childID) {

                                                               InternalUnsafeMethods.OnChildRemoved__Args _args = new InternalUnsafeMethods.OnChildRemoved__Args() {
                        ID = ID,
                        childID = childID,
                     };
                     InternalUnsafeMethods.OnChildRemoved()(ObjectPtr, _args);

                  }



                  public void OnChildAdded(uint ID, uint childID) {

                                                               InternalUnsafeMethods.OnChildAdded__Args _args = new InternalUnsafeMethods.OnChildAdded__Args() {
                        ID = ID,
                        childID = childID,
                     };
                     InternalUnsafeMethods.OnChildAdded()(ObjectPtr, _args);

                  }



                  public void OnResize(uint ID) {

                                          InternalUnsafeMethods.OnResize__Args _args = new InternalUnsafeMethods.OnResize__Args() {
                        ID = ID,
                     };
                     InternalUnsafeMethods.OnResize()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool NotifyOnChildAdded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnChildAdded"));
            set => SetFieldValue("notifyOnChildAdded", GenericMarshal.ToString(value));
        }


        public bool NotifyOnChildRemoved {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnChildRemoved"));
            set => SetFieldValue("notifyOnChildRemoved", GenericMarshal.ToString(value));
        }


        public bool NotifyOnChildResized {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnChildResized"));
            set => SetFieldValue("notifyOnChildResized", GenericMarshal.ToString(value));
        }


        public bool NotifyOnParentResized {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnParentResized"));
            set => SetFieldValue("notifyOnParentResized", GenericMarshal.ToString(value));
        }


        public bool NotifyOnResize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnResize"));
            set => SetFieldValue("notifyOnResize", GenericMarshal.ToString(value));
        }


        public bool NotifyOnLoseFirstResponder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnLoseFirstResponder"));
            set => SetFieldValue("notifyOnLoseFirstResponder", GenericMarshal.ToString(value));
        }


        public bool NotifyOnGainFirstResponder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("notifyOnGainFirstResponder"));
            set => SetFieldValue("notifyOnGainFirstResponder", GenericMarshal.ToString(value));
        }


    }
}
