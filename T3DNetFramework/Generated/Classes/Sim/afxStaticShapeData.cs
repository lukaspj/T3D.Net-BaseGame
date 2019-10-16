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
    /// <summary>A datablock that specifies a StaticShape effect.</summary>
    /// <description>
    /// afxStaticShapeData inherits from StaticShapeData and adds some AFX specific fields. StaticShape effects should be specified using afxStaticShapeData rather than StaticShapeData datablocks.
    /// </description>
    public unsafe class afxStaticShapeData : StaticShapeData {
        public afxStaticShapeData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxStaticShapeData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxStaticShapeData(string pName) 
            : this(pName, false) {
        }
        
        public afxStaticShapeData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxStaticShapeData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxStaticShapeData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxStaticShapeData(IntPtr pObj) 
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
                                "fnafxStaticShapeData_staticGetType"), typeof(_StaticGetType));
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
                                "fnafxStaticShapeData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the afxStaticShapeData class.
        /// </description>
        /// <returns>The type info object for afxStaticShapeData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// An animation sequence in the StaticShape to play.
        /// </description>
        /// </value>
        public string Sequence {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sequence"));
            set => SetFieldValue("sequence", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool IgnoreSceneAmbient {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreSceneAmbient"));
            set => SetFieldValue("ignoreSceneAmbient", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool UseCustomSceneAmbient {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useCustomSceneAmbient"));
            set => SetFieldValue("useCustomSceneAmbient", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public LinearColorF CustomSceneAmbient {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("customSceneAmbient"));
            set => SetFieldValue("customSceneAmbient", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When true, the StaticShape effect will leave behind the StaticShape object as a permanent part of the scene.
        /// </description>
        /// </value>
        public bool DoSpawn {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("doSpawn"));
            set => SetFieldValue("doSpawn", GenericMarshal.ToString(value));
        }
    }
}