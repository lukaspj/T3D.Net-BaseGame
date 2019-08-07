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

    public unsafe class HTTPObject : TCPObject {



        public HTTPObject(bool pRegister = false)
            : base(pRegister) {
        }

        public HTTPObject(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public HTTPObject(string pName)
            : this(pName, false) {
        }

        public HTTPObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public HTTPObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public HTTPObject(SimObject pObj)
            : base(pObj) {
        }

        public HTTPObject(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Post__Args
                {

				   internal string Address;

				   internal string requirstURI;

				   internal string query;

				   internal string post;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Post(IntPtr _this, string Address, string requirstURI, string query, string post);
                internal delegate void _Post(IntPtr _this, Post__Args args);
                private static _Post _PostFunc;
                internal static _Post Post() {
                    if (_PostFunc == null) {
                        _PostFunc =
                            (_Post)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnHTTPObject_post"), typeof(_Post));
                    }

                    return _PostFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Get__Args
                {

				   internal string Address;

				   internal string requirstURI;

				   internal string query;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Get(IntPtr _this, string Address, string requirstURI, string query);
                internal delegate void _Get(IntPtr _this, Get__Args args);
                private static _Get _GetFunc;
                internal static _Get Get() {
                    if (_GetFunc == null) {
                        _GetFunc =
                            (_Get)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnHTTPObject_get"), typeof(_Get));
                    }

                    return _GetFunc;
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
                                    "fnHTTPObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnHTTPObject_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Post(string Address, string requirstURI, string query, string post) {

                                                                                                         InternalUnsafeMethods.Post__Args _args = new InternalUnsafeMethods.Post__Args() {
                        Address = Address,
                        requirstURI = requirstURI,
                        query = query,
                        post = post,
                     };
                     InternalUnsafeMethods.Post()(ObjectPtr, _args);

                  }



                  public void Get(string Address, string requirstURI, string query = "") {

                                                                                    InternalUnsafeMethods.Get__Args _args = new InternalUnsafeMethods.Get__Args() {
                        Address = Address,
                        requirstURI = requirstURI,
                        query = query,
                     };
                     InternalUnsafeMethods.Get()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
