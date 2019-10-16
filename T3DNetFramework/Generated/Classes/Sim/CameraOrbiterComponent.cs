using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {
    /// 
    public unsafe class CameraOrbiterComponent : Component {
        public CameraOrbiterComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CameraOrbiterComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CameraOrbiterComponent(string pName) 
            : this(pName, false) {
        }
        
        public CameraOrbiterComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CameraOrbiterComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CameraOrbiterComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public CameraOrbiterComponent(IntPtr pObj) 
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
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraOrbiterComponent_staticGetType"), typeof(_StaticGetType));
                }
                
                return _StaticGetTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCameraOrbiterComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the CameraOrbiterComponent class.
        /// </description>
        /// <returns>The type info object for CameraOrbiterComponent</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Object world orientation.
        /// </description>
        /// </value>
        public float OrbitDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("orbitDistance"));
            set => SetFieldValue("orbitDistance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Object world orientation.
        /// </description>
        /// </value>
        public RotationF Rotation {
            get => GenericMarshal.StringTo<RotationF>(GetFieldValue("rotation"));
            set => SetFieldValue("rotation", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Object world orientation.
        /// </description>
        /// </value>
        public float MaxPitchAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxPitchAngle"));
            set => SetFieldValue("maxPitchAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Object world orientation.
        /// </description>
        /// </value>
        public float MinPitchAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minPitchAngle"));
            set => SetFieldValue("minPitchAngle", GenericMarshal.ToString(value));
        }
    }
}