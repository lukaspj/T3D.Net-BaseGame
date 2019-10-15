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
    public unsafe class FieldBrushObject : SimObject {
        public FieldBrushObject(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public FieldBrushObject(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public FieldBrushObject(string pName) 
            : this(pName, false) {
        }
        
        public FieldBrushObject(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public FieldBrushObject(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public FieldBrushObject(SimObject pObj) 
            : base(pObj) {
        }
        
        public FieldBrushObject(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PasteFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PasteFields(IntPtr _this, PasteFields__Args args);
            private static _PasteFields _PasteFieldsFunc;
            internal static _PasteFields PasteFields() {
                if (_PasteFieldsFunc == null) {
                    _PasteFieldsFunc =
                        (_PasteFields)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnFieldBrushObject_pasteFields"), typeof(_PasteFields));
                }
                
                return _PasteFieldsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct CopyFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CopyFields(IntPtr _this, CopyFields__Args args);
            private static _CopyFields _CopyFieldsFunc;
            internal static _CopyFields CopyFields() {
                if (_CopyFieldsFunc == null) {
                    _CopyFieldsFunc =
                        (_CopyFields)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnFieldBrushObject_copyFields"), typeof(_CopyFields));
                }
                
                return _CopyFieldsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct QueryFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _QueryFields(IntPtr _this, QueryFields__Args args);
            private static _QueryFields _QueryFieldsFunc;
            internal static _QueryFields QueryFields() {
                if (_QueryFieldsFunc == null) {
                    _QueryFieldsFunc =
                        (_QueryFields)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnFieldBrushObject_queryFields"), typeof(_QueryFields));
                }
                
                return _QueryFieldsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct QueryGroups__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _QueryGroups(IntPtr _this, QueryGroups__Args args);
            private static _QueryGroups _QueryGroupsFunc;
            internal static _QueryGroups QueryGroups() {
                if (_QueryGroupsFunc == null) {
                    _QueryGroupsFunc =
                        (_QueryGroups)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnFieldBrushObject_queryGroups"), typeof(_QueryGroups));
                }
                
                return _QueryGroupsFunc;
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
                                "fnFieldBrushObject_staticGetType"), typeof(_StaticGetType));
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
                                "fnFieldBrushObject_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void PasteFields(string simObjName) {
             InternalUnsafeMethods.PasteFields__Args _args = new InternalUnsafeMethods.PasteFields__Args() {
                simObjName = simObjName,
             };
             InternalUnsafeMethods.PasteFields()(ObjectPtr, _args);
        }

        public void CopyFields(string simObjName, string pFieldList = "") {
             InternalUnsafeMethods.CopyFields__Args _args = new InternalUnsafeMethods.CopyFields__Args() {
                simObjName = simObjName,
                pFieldList = pFieldList,
             };
             InternalUnsafeMethods.CopyFields()(ObjectPtr, _args);
        }

        public string QueryFields(string simObjName, string groupList = "") {
             InternalUnsafeMethods.QueryFields__Args _args = new InternalUnsafeMethods.QueryFields__Args() {
                simObjName = simObjName,
                groupList = groupList,
             };
             IntPtr _engineResult = InternalUnsafeMethods.QueryFields()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string QueryGroups(string simObjName) {
             InternalUnsafeMethods.QueryGroups__Args _args = new InternalUnsafeMethods.QueryGroups__Args() {
                simObjName = simObjName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.QueryGroups()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }

        public string SortName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sortName"));
            set => SetFieldValue("sortName", GenericMarshal.ToString(value));
        }
    }
}