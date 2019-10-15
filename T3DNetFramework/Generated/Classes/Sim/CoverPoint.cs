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
    public unsafe class CoverPoint : SceneObject {
        public CoverPoint(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CoverPoint(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CoverPoint(string pName) 
            : this(pName, false) {
        }
        
        public CoverPoint(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CoverPoint(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CoverPoint(SimObject pObj) 
            : base(pObj) {
        }
        
        public CoverPoint(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsOccupied__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsOccupied(IntPtr _this, IsOccupied__Args args);
            private static _IsOccupied _IsOccupiedFunc;
            internal static _IsOccupied IsOccupied() {
                if (_IsOccupiedFunc == null) {
                    _IsOccupiedFunc =
                        (_IsOccupied)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCoverPoint_isOccupied"), typeof(_IsOccupied));
                }
                
                return _IsOccupiedFunc;
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
                                "fnCoverPoint_staticGetType"), typeof(_StaticGetType));
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
                                "fnCoverPoint_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool IsOccupied() {
             InternalUnsafeMethods.IsOccupied__Args _args = new InternalUnsafeMethods.IsOccupied__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsOccupied()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public CoverPointSize Size {
            get => GenericMarshal.StringTo<CoverPointSize>(GetFieldValue("size"));
            set => SetFieldValue("size", GenericMarshal.ToString(value));
        }

        public float Quality {
            get => GenericMarshal.StringTo<float>(GetFieldValue("quality"));
            set => SetFieldValue("quality", GenericMarshal.ToString(value));
        }

        public bool PeekLeft {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("peekLeft"));
            set => SetFieldValue("peekLeft", GenericMarshal.ToString(value));
        }

        public bool PeekRight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("peekRight"));
            set => SetFieldValue("peekRight", GenericMarshal.ToString(value));
        }

        public bool PeekOver {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("peekOver"));
            set => SetFieldValue("peekOver", GenericMarshal.ToString(value));
        }
    }
}