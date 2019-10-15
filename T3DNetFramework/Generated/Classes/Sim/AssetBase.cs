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
    public unsafe class AssetBase : SimObject {
        public AssetBase(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AssetBase(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AssetBase(string pName) 
            : this(pName, false) {
        }
        
        public AssetBase(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AssetBase(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AssetBase(SimObject pObj) 
            : base(pObj) {
        }
        
        public AssetBase(IntPtr pObj) 
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
                                "fnAssetBase_staticGetType"), typeof(_StaticGetType));
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
                                "fnAssetBase_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetId(IntPtr _this, GetAssetId__Args args);
            private static _GetAssetId _GetAssetIdFunc;
            internal static _GetAssetId GetAssetId() {
                if (_GetAssetIdFunc == null) {
                    _GetAssetIdFunc =
                        (_GetAssetId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetBase_getAssetId"), typeof(_GetAssetId));
                }
                
                return _GetAssetIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RefreshAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RefreshAsset(IntPtr _this, RefreshAsset__Args args);
            private static _RefreshAsset _RefreshAssetFunc;
            internal static _RefreshAsset RefreshAsset() {
                if (_RefreshAssetFunc == null) {
                    _RefreshAssetFunc =
                        (_RefreshAsset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAssetBase_refreshAsset"), typeof(_RefreshAsset));
                }
                
                return _RefreshAssetFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string GetAssetId() {
             InternalUnsafeMethods.GetAssetId__Args _args = new InternalUnsafeMethods.GetAssetId__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetId()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void RefreshAsset() {
             InternalUnsafeMethods.RefreshAsset__Args _args = new InternalUnsafeMethods.RefreshAsset__Args() {
             };
             InternalUnsafeMethods.RefreshAsset()(ObjectPtr, _args);
        }

        public string AssetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetName"));
            set => SetFieldValue("AssetName", GenericMarshal.ToString(value));
        }

        public string AssetDescription {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetDescription"));
            set => SetFieldValue("AssetDescription", GenericMarshal.ToString(value));
        }

        public string AssetCategory {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetCategory"));
            set => SetFieldValue("AssetCategory", GenericMarshal.ToString(value));
        }

        public bool AssetAutoUnload {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetAutoUnload"));
            set => SetFieldValue("AssetAutoUnload", GenericMarshal.ToString(value));
        }

        public bool AssetInternal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetInternal"));
            set => SetFieldValue("AssetInternal", GenericMarshal.ToString(value));
        }

        public bool AssetPrivate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetPrivate"));
            set => SetFieldValue("AssetPrivate", GenericMarshal.ToString(value));
        }
    }
}