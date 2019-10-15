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
    public unsafe class AssetQuery : SimObject {
        public AssetQuery(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AssetQuery(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AssetQuery(string pName) 
            : this(pName, false) {
        }
        
        public AssetQuery(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AssetQuery(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AssetQuery(SimObject pObj) 
            : base(pObj) {
        }
        
        public AssetQuery(IntPtr pObj) 
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
                                "fnAssetQuery_staticGetType"), typeof(_StaticGetType));
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
                                "fnAssetQuery_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAsset__Args
            {
                internal int resultIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAsset(IntPtr _this, GetAsset__Args args);
            private static _GetAsset _GetAssetFunc;
            internal static _GetAsset GetAsset() {
                if (_GetAssetFunc == null) {
                    _GetAssetFunc =
                        (_GetAsset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetQuery_getAsset"), typeof(_GetAsset));
                }
                
                return _GetAssetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCount(IntPtr _this, GetCount__Args args);
            private static _GetCount _GetCountFunc;
            internal static _GetCount GetCount() {
                if (_GetCountFunc == null) {
                    _GetCountFunc =
                        (_GetCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetQuery_getCount"), typeof(_GetCount));
                }
                
                return _GetCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Set__Args
            {
                internal int queryId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Set(IntPtr _this, Set__Args args);
            private static _Set _SetFunc;
            internal static _Set Set() {
                if (_SetFunc == null) {
                    _SetFunc =
                        (_Set)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetQuery_set"), typeof(_Set));
                }
                
                return _SetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
                if (_ClearFunc == null) {
                    _ClearFunc =
                        (_Clear)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetQuery_clear"), typeof(_Clear));
                }
                
                return _ClearFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string GetAsset(int resultIndex = -1) {
             InternalUnsafeMethods.GetAsset__Args _args = new InternalUnsafeMethods.GetAsset__Args() {
                resultIndex = resultIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetCount() {
             InternalUnsafeMethods.GetCount__Args _args = new InternalUnsafeMethods.GetCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool Set(int queryId) {
             InternalUnsafeMethods.Set__Args _args = new InternalUnsafeMethods.Set__Args() {
                queryId = queryId,
             };
             bool _engineResult = InternalUnsafeMethods.Set()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        public int Count {
            get => GenericMarshal.StringTo<int>(GetFieldValue("count"));
            set => SetFieldValue("count", GenericMarshal.ToString(value));
        }
    }
}