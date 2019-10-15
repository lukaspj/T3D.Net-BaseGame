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
    public unsafe class LightFlareData : SimDataBlock {
        public LightFlareData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public LightFlareData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public LightFlareData(string pName) 
            : this(pName, false) {
        }
        
        public LightFlareData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public LightFlareData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public LightFlareData(SimObject pObj) 
            : base(pObj) {
        }
        
        public LightFlareData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Apply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Apply(IntPtr _this, Apply__Args args);
            private static _Apply _ApplyFunc;
            internal static _Apply Apply() {
                if (_ApplyFunc == null) {
                    _ApplyFunc =
                        (_Apply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnLightFlareData_apply"), typeof(_Apply));
                }
                
                return _ApplyFunc;
            }

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
                                "fnLightFlareData_staticGetType"), typeof(_StaticGetType));
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
                                "fnLightFlareData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Apply() {
             InternalUnsafeMethods.Apply__Args _args = new InternalUnsafeMethods.Apply__Args() {
             };
             InternalUnsafeMethods.Apply()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float OverallScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("overallScale"));
            set => SetFieldValue("overallScale", GenericMarshal.ToString(value));
        }

        public float OcclusionRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("occlusionRadius"));
            set => SetFieldValue("occlusionRadius", GenericMarshal.ToString(value));
        }

        public bool RenderReflectPass {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderReflectPass"));
            set => SetFieldValue("renderReflectPass", GenericMarshal.ToString(value));
        }

        public bool FlareEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("flareEnabled"));
            set => SetFieldValue("flareEnabled", GenericMarshal.ToString(value));
        }

        public string FlareTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("flareTexture"));
            set => SetFieldValue("flareTexture", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<RectF> ElementRect {
            get => new DynamicFieldVector<RectF>(
                    this, 
                    "elementRect", 
                    20, 
                    val => GenericMarshal.StringTo<RectF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> ElementDist {
            get => new DynamicFieldVector<float>(
                    this, 
                    "elementDist", 
                    20, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<float> ElementScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "elementScale", 
                    20, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<LinearColorF> ElementTint {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "elementTint", 
                    20, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> ElementRotate {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "elementRotate", 
                    20, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> ElementUseLightColor {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "elementUseLightColor", 
                    20, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}