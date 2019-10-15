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
    public unsafe class CubemapData : SimObject {
        public CubemapData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CubemapData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CubemapData(string pName) 
            : this(pName, false) {
        }
        
        public CubemapData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CubemapData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CubemapData(SimObject pObj) 
            : base(pObj) {
        }
        
        public CubemapData(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFilename__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFilename(IntPtr _this, GetFilename__Args args);
            private static _GetFilename _GetFilenameFunc;
            internal static _GetFilename GetFilename() {
                if (_GetFilenameFunc == null) {
                    _GetFilenameFunc =
                        (_GetFilename)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCubemapData_getFilename"), typeof(_GetFilename));
                }
                
                return _GetFilenameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateFaces__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateFaces(IntPtr _this, UpdateFaces__Args args);
            private static _UpdateFaces _UpdateFacesFunc;
            internal static _UpdateFaces UpdateFaces() {
                if (_UpdateFacesFunc == null) {
                    _UpdateFacesFunc =
                        (_UpdateFaces)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCubemapData_updateFaces"), typeof(_UpdateFaces));
                }
                
                return _UpdateFacesFunc;
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
                                "fnCubemapData_staticGetType"), typeof(_StaticGetType));
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
                                "fnCubemapData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public string GetFilename() {
             InternalUnsafeMethods.GetFilename__Args _args = new InternalUnsafeMethods.GetFilename__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFilename()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void UpdateFaces() {
             InternalUnsafeMethods.UpdateFaces__Args _args = new InternalUnsafeMethods.UpdateFaces__Args() {
             };
             InternalUnsafeMethods.UpdateFaces()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public DynamicFieldVector<string> CubeFace {
            get => new DynamicFieldVector<string>(
                    this, 
                    "cubeFace", 
                    6, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public string Cubemap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubemap"));
            set => SetFieldValue("cubemap", GenericMarshal.ToString(value));
        }
    }
}