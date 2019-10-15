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
    public unsafe class fxShapeReplicatedStatic : SceneObject {
        public fxShapeReplicatedStatic(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public fxShapeReplicatedStatic(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public fxShapeReplicatedStatic(string pName) 
            : this(pName, false) {
        }
        
        public fxShapeReplicatedStatic(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public fxShapeReplicatedStatic(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public fxShapeReplicatedStatic(SimObject pObj) 
            : base(pObj) {
        }
        
        public fxShapeReplicatedStatic(IntPtr pObj) 
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
                                "fnfxShapeReplicatedStatic_staticGetType"), typeof(_StaticGetType));
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
                                "fnfxShapeReplicatedStatic_create"), typeof(_Create));
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

        public string ShapeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeName"));
            set => SetFieldValue("shapeName", GenericMarshal.ToString(value));
        }

        public string Skin {
            get => GenericMarshal.StringTo<string>(GetFieldValue("skin"));
            set => SetFieldValue("skin", GenericMarshal.ToString(value));
        }

        public bool PlayAmbient {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("playAmbient"));
            set => SetFieldValue("playAmbient", GenericMarshal.ToString(value));
        }

        public bool MeshCulling {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("meshCulling"));
            set => SetFieldValue("meshCulling", GenericMarshal.ToString(value));
        }

        public bool OriginSort {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("originSort"));
            set => SetFieldValue("originSort", GenericMarshal.ToString(value));
        }

        public string CubeReflectorDesc {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubeReflectorDesc"));
            set => SetFieldValue("cubeReflectorDesc", GenericMarshal.ToString(value));
        }

        public TSMeshType CollisionType {
            get => GenericMarshal.StringTo<TSMeshType>(GetFieldValue("CollisionType"));
            set => SetFieldValue("CollisionType", GenericMarshal.ToString(value));
        }

        public TSMeshType DecalType {
            get => GenericMarshal.StringTo<TSMeshType>(GetFieldValue("DecalType"));
            set => SetFieldValue("DecalType", GenericMarshal.ToString(value));
        }

        public bool AllowPlayerStep {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowPlayerStep"));
            set => SetFieldValue("allowPlayerStep", GenericMarshal.ToString(value));
        }

        public bool AlphaFadeEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alphaFadeEnable"));
            set => SetFieldValue("alphaFadeEnable", GenericMarshal.ToString(value));
        }

        public float AlphaFadeStart {
            get => GenericMarshal.StringTo<float>(GetFieldValue("alphaFadeStart"));
            set => SetFieldValue("alphaFadeStart", GenericMarshal.ToString(value));
        }

        public float AlphaFadeEnd {
            get => GenericMarshal.StringTo<float>(GetFieldValue("alphaFadeEnd"));
            set => SetFieldValue("alphaFadeEnd", GenericMarshal.ToString(value));
        }

        public bool AlphaFadeInverse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alphaFadeInverse"));
            set => SetFieldValue("alphaFadeInverse", GenericMarshal.ToString(value));
        }

        public float RenderNormals {
            get => GenericMarshal.StringTo<float>(GetFieldValue("renderNormals"));
            set => SetFieldValue("renderNormals", GenericMarshal.ToString(value));
        }

        public int ForceDetail {
            get => GenericMarshal.StringTo<int>(GetFieldValue("forceDetail"));
            set => SetFieldValue("forceDetail", GenericMarshal.ToString(value));
        }

        public bool IgnoreZodiacs {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreZodiacs"));
            set => SetFieldValue("ignoreZodiacs", GenericMarshal.ToString(value));
        }

        public bool UseGradientRange {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useGradientRange"));
            set => SetFieldValue("useGradientRange", GenericMarshal.ToString(value));
        }

        public Point2F GradientRange {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("gradientRange"));
            set => SetFieldValue("gradientRange", GenericMarshal.ToString(value));
        }

        public bool InvertGradientRange {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("invertGradientRange"));
            set => SetFieldValue("invertGradientRange", GenericMarshal.ToString(value));
        }
    }
}