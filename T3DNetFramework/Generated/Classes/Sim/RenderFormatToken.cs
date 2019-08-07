using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class RenderFormatToken : RenderPassStateToken {



        public RenderFormatToken(bool pRegister = false)
            : base(pRegister) {
        }

        public RenderFormatToken(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public RenderFormatToken(string pName)
            : this(pName, false) {
        }

        public RenderFormatToken(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public RenderFormatToken(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public RenderFormatToken(SimObject pObj)
            : base(pObj) {
        }

        public RenderFormatToken(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



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
                                    "fnRenderFormatToken_staticGetType"), typeof(_StaticGetType));
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
                                    "fnRenderFormatToken_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public GFXFormat Format {
            get => GenericMarshal.StringTo<GFXFormat>(GetFieldValue("Format"));
            set => SetFieldValue("Format", GenericMarshal.ToString(value));
        }


        public GFXFormat DepthFormat {
            get => GenericMarshal.StringTo<GFXFormat>(GetFieldValue("depthFormat"));
            set => SetFieldValue("depthFormat", GenericMarshal.ToString(value));
        }


        public PostEffect CopyEffect {
            get => GenericMarshal.StringTo<PostEffect>(GetFieldValue("copyEffect"));
            set => SetFieldValue("copyEffect", GenericMarshal.ToString(value));
        }


        public PostEffect ResolveEffect {
            get => GenericMarshal.StringTo<PostEffect>(GetFieldValue("resolveEffect"));
            set => SetFieldValue("resolveEffect", GenericMarshal.ToString(value));
        }


        public int AaLevel {
            get => GenericMarshal.StringTo<int>(GetFieldValue("aaLevel"));
            set => SetFieldValue("aaLevel", GenericMarshal.ToString(value));
        }


    }
}
