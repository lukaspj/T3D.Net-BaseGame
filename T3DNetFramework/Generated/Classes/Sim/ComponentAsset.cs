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
    public unsafe class ComponentAsset : AssetBase {
        public ComponentAsset(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ComponentAsset(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ComponentAsset(string pName) 
            : this(pName, false) {
        }
        
        public ComponentAsset(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ComponentAsset(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ComponentAsset(SimObject pObj) 
            : base(pObj) {
        }
        
        public ComponentAsset(IntPtr pObj) 
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
                                "fnComponentAsset_staticGetType"), typeof(_StaticGetType));
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
                                "fnComponentAsset_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the ComponentAsset class.
        /// </description>
        /// <returns>The type info object for ComponentAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Unique Name of the component. Defines the namespace of the scripts for the component.
        /// </description>
        /// </value>
        public string ComponentName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("componentName"));
            set => SetFieldValue("componentName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Class of object this component uses.
        /// </description>
        /// </value>
        public string ComponentClass {
            get => GenericMarshal.StringTo<string>(GetFieldValue("componentClass"));
            set => SetFieldValue("componentClass", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The human-readble name for the component.
        /// </description>
        /// </value>
        public string FriendlyName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("friendlyName"));
            set => SetFieldValue("friendlyName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The category of the component for organizing in the editor.
        /// </description>
        /// </value>
        public string ComponentType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("componentType"));
            set => SetFieldValue("componentType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Simple description of the component.
        /// </description>
        /// </value>
        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// A script file with additional scripted functionality for this component.
        /// </description>
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("scriptFile"));
            set => SetFieldValue("scriptFile", GenericMarshal.ToString(value));
        }
    }
}