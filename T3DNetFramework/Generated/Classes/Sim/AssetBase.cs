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
    /// 
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

        /// <description>
        /// Get the type info object for the AssetBase class.
        /// </description>
        /// <returns>The type info object for AssetBase</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <description>
        /// Gets the assets' Asset Id.  This is only available if the asset was acquired from the asset manager.
        /// </description>
        /// <returns>The assets' Asset Id.</returns>
        public string GetAssetId() {
             InternalUnsafeMethods.GetAssetId__Args _args = new InternalUnsafeMethods.GetAssetId__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetId()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Refresh the asset.
        /// </description>
        /// <returns>No return value.</returns>
        public void RefreshAsset() {
             InternalUnsafeMethods.RefreshAsset__Args _args = new InternalUnsafeMethods.RefreshAsset__Args() {
             };
             InternalUnsafeMethods.RefreshAsset()(ObjectPtr, _args);
        }


        /// <value>
        /// <description>
        /// The name of the asset.  The is not a unique identification like an asset Id.
        /// </description>
        /// </value>
        public string AssetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetName"));
            set => SetFieldValue("AssetName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The simple description of the asset contents.
        /// </description>
        /// </value>
        public string AssetDescription {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetDescription"));
            set => SetFieldValue("AssetDescription", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// An arbitrary category that can be used to categorized assets.
        /// </description>
        /// </value>
        public string AssetCategory {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetCategory"));
            set => SetFieldValue("AssetCategory", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is automatically unloaded when an asset is released and has no other acquisitions or not.
        /// </description>
        /// </value>
        public bool AssetAutoUnload {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetAutoUnload"));
            set => SetFieldValue("AssetAutoUnload", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is used internally only or not.
        /// </description>
        /// </value>
        public bool AssetInternal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetInternal"));
            set => SetFieldValue("AssetInternal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is private or not.
        /// </description>
        /// </value>
        public bool AssetPrivate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetPrivate"));
            set => SetFieldValue("AssetPrivate", GenericMarshal.ToString(value));
        }
    }
}