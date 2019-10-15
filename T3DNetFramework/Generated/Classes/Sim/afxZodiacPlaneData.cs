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
    public unsafe class afxZodiacPlaneData : GameBaseData {
        public afxZodiacPlaneData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxZodiacPlaneData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxZodiacPlaneData(string pName) 
            : this(pName, false) {
        }
        
        public afxZodiacPlaneData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxZodiacPlaneData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxZodiacPlaneData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxZodiacPlaneData(IntPtr pObj) 
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
                                "fnafxZodiacPlaneData_staticGetType"), typeof(_StaticGetType));
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
                                "fnafxZodiacPlaneData_create"), typeof(_Create));
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

        public string Texture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("texture"));
            set => SetFieldValue("texture", GenericMarshal.ToString(value));
        }

        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }

        public float StartAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("startAngle"));
            set => SetFieldValue("startAngle", GenericMarshal.ToString(value));
        }

        public float RotationRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rotationRate"));
            set => SetFieldValue("rotationRate", GenericMarshal.ToString(value));
        }

        public float GrowInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("growInTime"));
            set => SetFieldValue("growInTime", GenericMarshal.ToString(value));
        }

        public float ShrinkOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shrinkOutTime"));
            set => SetFieldValue("shrinkOutTime", GenericMarshal.ToString(value));
        }

        public float GrowthRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("growthRate"));
            set => SetFieldValue("growthRate", GenericMarshal.ToString(value));
        }

        public LinearColorF Color {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }

        public afxZodiacPlane_BlendType Blend {
            get => GenericMarshal.StringTo<afxZodiacPlane_BlendType>(GetFieldValue("blend"));
            set => SetFieldValue("blend", GenericMarshal.ToString(value));
        }

        public bool TrackOrientConstraint {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("trackOrientConstraint"));
            set => SetFieldValue("trackOrientConstraint", GenericMarshal.ToString(value));
        }

        public bool DoubleSided {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("doubleSided"));
            set => SetFieldValue("doubleSided", GenericMarshal.ToString(value));
        }

        public afxZodiacPlane_FacingType FaceDir {
            get => GenericMarshal.StringTo<afxZodiacPlane_FacingType>(GetFieldValue("faceDir"));
            set => SetFieldValue("faceDir", GenericMarshal.ToString(value));
        }

        public bool UseFullTransform {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useFullTransform"));
            set => SetFieldValue("useFullTransform", GenericMarshal.ToString(value));
        }
    }
}