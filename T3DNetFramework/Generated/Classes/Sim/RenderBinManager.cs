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
    public unsafe class RenderBinManager : SimObject {
        public RenderBinManager(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RenderBinManager(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public RenderBinManager(string pName) 
            : this(pName, false) {
        }
        
        public RenderBinManager(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public RenderBinManager(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public RenderBinManager(SimObject pObj) 
            : base(pObj) {
        }
        
        public RenderBinManager(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBinType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBinType(IntPtr _this, GetBinType__Args args);
            private static _GetBinType _GetBinTypeFunc;
            internal static _GetBinType GetBinType() {
                if (_GetBinTypeFunc == null) {
                    _GetBinTypeFunc =
                        (_GetBinType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRenderBinManager_getBinType"), typeof(_GetBinType));
                }
                
                return _GetBinTypeFunc;
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
                                "fnRenderBinManager_staticGetType"), typeof(_StaticGetType));
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
                                "fnRenderBinManager_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public string GetBinType() {
             InternalUnsafeMethods.GetBinType__Args _args = new InternalUnsafeMethods.GetBinType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBinType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string BinType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("binType"));
            set => SetFieldValue("binType", GenericMarshal.ToString(value));
        }

        public float RenderOrder {
            get => GenericMarshal.StringTo<float>(GetFieldValue("renderOrder"));
            set => SetFieldValue("renderOrder", GenericMarshal.ToString(value));
        }

        public float ProcessAddOrder {
            get => GenericMarshal.StringTo<float>(GetFieldValue("processAddOrder"));
            set => SetFieldValue("processAddOrder", GenericMarshal.ToString(value));
        }

        public bool BasicOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("basicOnly"));
            set => SetFieldValue("basicOnly", GenericMarshal.ToString(value));
        }
    }
}