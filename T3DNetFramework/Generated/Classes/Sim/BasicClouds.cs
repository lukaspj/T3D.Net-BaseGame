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
    public unsafe class BasicClouds : SceneObject {
        public BasicClouds(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public BasicClouds(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public BasicClouds(string pName) 
            : this(pName, false) {
        }
        
        public BasicClouds(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public BasicClouds(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public BasicClouds(SimObject pObj) 
            : base(pObj) {
        }
        
        public BasicClouds(IntPtr pObj) 
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
                                "fnBasicClouds_staticGetType"), typeof(_StaticGetType));
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
                                "fnBasicClouds_create"), typeof(_Create));
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

        public DynamicFieldVector<bool> LayerEnabled {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "layerEnabled", 
                    3, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<string> Texture {
            get => new DynamicFieldVector<string>(
                    this, 
                    "texture", 
                    3, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> TexScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "texScale", 
                    3, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> TexDirection {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "texDirection", 
                    3, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> TexSpeed {
            get => new DynamicFieldVector<float>(
                    this, 
                    "texSpeed", 
                    3, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<Point2F> TexOffset {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "texOffset", 
                    3, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> Height {
            get => new DynamicFieldVector<float>(
                    this, 
                    "height", 
                    3, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}