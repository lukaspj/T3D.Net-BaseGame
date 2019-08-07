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

    public unsafe class PlayerControllerComponent : Component {



        public PlayerControllerComponent(bool pRegister = false)
            : base(pRegister) {
        }

        public PlayerControllerComponent(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public PlayerControllerComponent(string pName)
            : this(pName, false) {
        }

        public PlayerControllerComponent(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PlayerControllerComponent(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PlayerControllerComponent(SimObject pObj)
            : base(pObj) {
        }

        public PlayerControllerComponent(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsContacted__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsContacted(IntPtr _this);
                internal delegate bool _IsContacted(IntPtr _this, IsContacted__Args args);
                private static _IsContacted _IsContactedFunc;
                internal static _IsContacted IsContacted() {
                    if (_IsContactedFunc == null) {
                        _IsContactedFunc =
                            (_IsContacted)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayerControllerComponent_isContacted"), typeof(_IsContacted));
                    }

                    return _IsContactedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetContactObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetContactObject(IntPtr _this);
                internal delegate IntPtr _GetContactObject(IntPtr _this, GetContactObject__Args args);
                private static _GetContactObject _GetContactObjectFunc;
                internal static _GetContactObject GetContactObject() {
                    if (_GetContactObjectFunc == null) {
                        _GetContactObjectFunc =
                            (_GetContactObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayerControllerComponent_getContactObject"), typeof(_GetContactObject));
                    }

                    return _GetContactObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetContactNormal__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetContactNormal(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetContactNormal(IntPtr _this, GetContactNormal__Args args);
                private static _GetContactNormal _GetContactNormalFunc;
                internal static _GetContactNormal GetContactNormal() {
                    if (_GetContactNormalFunc == null) {
                        _GetContactNormalFunc =
                            (_GetContactNormal)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayerControllerComponent_getContactNormal"), typeof(_GetContactNormal));
                    }

                    return _GetContactNormalFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyImpulse__Args
                {

				   internal IntPtr pos;

				   internal IntPtr vel;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ApplyImpulse(IntPtr _this, IntPtr pos, IntPtr vel);
                internal delegate bool _ApplyImpulse(IntPtr _this, ApplyImpulse__Args args);
                private static _ApplyImpulse _ApplyImpulseFunc;
                internal static _ApplyImpulse ApplyImpulse() {
                    if (_ApplyImpulseFunc == null) {
                        _ApplyImpulseFunc =
                            (_ApplyImpulse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayerControllerComponent_applyImpulse"), typeof(_ApplyImpulse));
                    }

                    return _ApplyImpulseFunc;
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
                                    "fnPlayerControllerComponent_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPlayerControllerComponent_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct UpdateMove__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _UpdateMove(IntPtr _this, IntPtr obj);
                internal delegate void _UpdateMove(IntPtr _this, UpdateMove__Args args);
                private static _UpdateMove _UpdateMoveFunc;
                internal static _UpdateMove UpdateMove() {
                    if (_UpdateMoveFunc == null) {
                        _UpdateMoveFunc =
                            (_UpdateMove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbPlayerControllerComponent_updateMove"), typeof(_UpdateMove));
                    }

                    return _UpdateMoveFunc;
                }

        }
        #endregion



                  public bool IsContacted() {

                     InternalUnsafeMethods.IsContacted__Args _args = new InternalUnsafeMethods.IsContacted__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsContacted()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public SceneObject GetContactObject() {

                     InternalUnsafeMethods.GetContactObject__Args _args = new InternalUnsafeMethods.GetContactObject__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetContactObject()(ObjectPtr, _args);

                     return new SceneObject(_engineResult);
                  }



                  public Point3F GetContactNormal() {

                     InternalUnsafeMethods.GetContactNormal__Args _args = new InternalUnsafeMethods.GetContactNormal__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetContactNormal()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public bool ApplyImpulse(Point3F pos, Point3F vel) {

                     pos.Alloc();                     vel.Alloc();                     InternalUnsafeMethods.ApplyImpulse__Args _args = new InternalUnsafeMethods.ApplyImpulse__Args() {
                        pos = pos.internalStructPtr,
                        vel = vel.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.ApplyImpulse()(ObjectPtr, _args);
                                          pos.Free();                     vel.Free();
                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }





                  public void UpdateMove(PlayerControllerComponent obj) {

                                          InternalUnsafeMethods.UpdateMove__Args _args = new InternalUnsafeMethods.UpdateMove__Args() {
                        obj = obj.ObjectPtr,
                     };
                     InternalUnsafeMethods.UpdateMove()(ObjectPtr, _args);

                  }




        public Point3F InputVelocity {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("inputVelocity"));
            set => SetFieldValue("inputVelocity", GenericMarshal.ToString(value));
        }


        public Point3F UseDirectMoveInput {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("useDirectMoveInput"));
            set => SetFieldValue("useDirectMoveInput", GenericMarshal.ToString(value));
        }


    }
}
