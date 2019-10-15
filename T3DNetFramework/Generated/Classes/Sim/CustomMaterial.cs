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
    public unsafe class CustomMaterial : Material {
        public CustomMaterial(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CustomMaterial(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CustomMaterial(string pName) 
            : this(pName, false) {
        }
        
        public CustomMaterial(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CustomMaterial(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CustomMaterial(SimObject pObj) 
            : base(pObj) {
        }
        
        public CustomMaterial(IntPtr pObj) 
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
                                "fnCustomMaterial_staticGetType"), typeof(_StaticGetType));
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
                                "fnCustomMaterial_create"), typeof(_Create));
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

        public float Version {
            get => GenericMarshal.StringTo<float>(GetFieldValue("version"));
            set => SetFieldValue("version", GenericMarshal.ToString(value));
        }

        public Material Fallback {
            get => GenericMarshal.StringTo<Material>(GetFieldValue("fallback"));
            set => SetFieldValue("fallback", GenericMarshal.ToString(value));
        }

        public string Shader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shader"));
            set => SetFieldValue("shader", GenericMarshal.ToString(value));
        }

        public GFXStateBlockData StateBlock {
            get => GenericMarshal.StringTo<GFXStateBlockData>(GetFieldValue("stateBlock"));
            set => SetFieldValue("stateBlock", GenericMarshal.ToString(value));
        }

        public string Target {
            get => GenericMarshal.StringTo<string>(GetFieldValue("target"));
            set => SetFieldValue("target", GenericMarshal.ToString(value));
        }

        public bool ForwardLit {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("forwardLit"));
            set => SetFieldValue("forwardLit", GenericMarshal.ToString(value));
        }
    }
}