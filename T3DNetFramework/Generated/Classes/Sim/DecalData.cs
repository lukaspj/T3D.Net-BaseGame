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
    public unsafe class DecalData : SimDataBlock {
        public DecalData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public DecalData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public DecalData(string pName) 
            : this(pName, false) {
        }
        
        public DecalData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public DecalData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public DecalData(SimObject pObj) 
            : base(pObj) {
        }
        
        public DecalData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PostApply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PostApply(IntPtr _this, PostApply__Args args);
            private static _PostApply _PostApplyFunc;
            internal static _PostApply PostApply() {
                if (_PostApplyFunc == null) {
                    _PostApplyFunc =
                        (_PostApply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnDecalData_postApply"), typeof(_PostApply));
                }
                
                return _PostApplyFunc;
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
                                "fnDecalData_staticGetType"), typeof(_StaticGetType));
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
                                "fnDecalData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void PostApply() {
             InternalUnsafeMethods.PostApply__Args _args = new InternalUnsafeMethods.PostApply__Args() {
             };
             InternalUnsafeMethods.PostApply()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float Size {
            get => GenericMarshal.StringTo<float>(GetFieldValue("size"));
            set => SetFieldValue("size", GenericMarshal.ToString(value));
        }

        public string Material {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Material"));
            set => SetFieldValue("Material", GenericMarshal.ToString(value));
        }

        public int LifeSpan {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifeSpan"));
            set => SetFieldValue("lifeSpan", GenericMarshal.ToString(value));
        }

        public int FadeTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fadeTime"));
            set => SetFieldValue("fadeTime", GenericMarshal.ToString(value));
        }

        public float FadeStartPixelSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeStartPixelSize"));
            set => SetFieldValue("fadeStartPixelSize", GenericMarshal.ToString(value));
        }

        public float FadeEndPixelSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeEndPixelSize"));
            set => SetFieldValue("fadeEndPixelSize", GenericMarshal.ToString(value));
        }

        public sbyte RenderPriority {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("renderPriority"));
            set => SetFieldValue("renderPriority", GenericMarshal.ToString(value));
        }

        public float ClippingAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("clippingAngle"));
            set => SetFieldValue("clippingAngle", GenericMarshal.ToString(value));
        }

        public int Frame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("frame"));
            set => SetFieldValue("frame", GenericMarshal.ToString(value));
        }

        public bool Randomize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("randomize"));
            set => SetFieldValue("randomize", GenericMarshal.ToString(value));
        }

        public int TextureCoordCount {
            get => GenericMarshal.StringTo<int>(GetFieldValue("textureCoordCount"));
            set => SetFieldValue("textureCoordCount", GenericMarshal.ToString(value));
        }

        public int TexRows {
            get => GenericMarshal.StringTo<int>(GetFieldValue("texRows"));
            set => SetFieldValue("texRows", GenericMarshal.ToString(value));
        }

        public int TexCols {
            get => GenericMarshal.StringTo<int>(GetFieldValue("texCols"));
            set => SetFieldValue("texCols", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<RectF> TextureCoords {
            get => new DynamicFieldVector<RectF>(
                    this, 
                    "textureCoords", 
                    16, 
                    val => GenericMarshal.StringTo<RectF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}