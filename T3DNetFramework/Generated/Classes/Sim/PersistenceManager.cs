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
    public unsafe class PersistenceManager : SimObject {
        public PersistenceManager(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PersistenceManager(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PersistenceManager(string pName) 
            : this(pName, false) {
        }
        
        public PersistenceManager(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PersistenceManager(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PersistenceManager(SimObject pObj) 
            : base(pObj) {
        }
        
        public PersistenceManager(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveField(IntPtr _this, RemoveField__Args args);
            private static _RemoveField _RemoveFieldFunc;
            internal static _RemoveField RemoveField() {
                if (_RemoveFieldFunc == null) {
                    _RemoveFieldFunc =
                        (_RemoveField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_removeField"), typeof(_RemoveField));
                }
                
                return _RemoveFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveObjectFromFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveObjectFromFile(IntPtr _this, RemoveObjectFromFile__Args args);
            private static _RemoveObjectFromFile _RemoveObjectFromFileFunc;
            internal static _RemoveObjectFromFile RemoveObjectFromFile() {
                if (_RemoveObjectFromFileFunc == null) {
                    _RemoveObjectFromFileFunc =
                        (_RemoveObjectFromFile)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_removeObjectFromFile"), typeof(_RemoveObjectFromFile));
                }
                
                return _RemoveObjectFromFileFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearAll__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearAll(IntPtr _this, ClearAll__Args args);
            private static _ClearAll _ClearAllFunc;
            internal static _ClearAll ClearAll() {
                if (_ClearAllFunc == null) {
                    _ClearAllFunc =
                        (_ClearAll)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_clearAll"), typeof(_ClearAll));
                }
                
                return _ClearAllFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveDirtyObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SaveDirtyObject(IntPtr _this, SaveDirtyObject__Args args);
            private static _SaveDirtyObject _SaveDirtyObjectFunc;
            internal static _SaveDirtyObject SaveDirtyObject() {
                if (_SaveDirtyObjectFunc == null) {
                    _SaveDirtyObjectFunc =
                        (_SaveDirtyObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_saveDirtyObject"), typeof(_SaveDirtyObject));
                }
                
                return _SaveDirtyObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SaveDirty(IntPtr _this, SaveDirty__Args args);
            private static _SaveDirty _SaveDirtyFunc;
            internal static _SaveDirty SaveDirty() {
                if (_SaveDirtyFunc == null) {
                    _SaveDirtyFunc =
                        (_SaveDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_saveDirty"), typeof(_SaveDirty));
                }
                
                return _SaveDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ListDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ListDirty(IntPtr _this, ListDirty__Args args);
            private static _ListDirty _ListDirtyFunc;
            internal static _ListDirty ListDirty() {
                if (_ListDirtyFunc == null) {
                    _ListDirtyFunc =
                        (_ListDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_listDirty"), typeof(_ListDirty));
                }
                
                return _ListDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDirtyObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDirtyObject(IntPtr _this, GetDirtyObject__Args args);
            private static _GetDirtyObject _GetDirtyObjectFunc;
            internal static _GetDirtyObject GetDirtyObject() {
                if (_GetDirtyObjectFunc == null) {
                    _GetDirtyObjectFunc =
                        (_GetDirtyObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_getDirtyObject"), typeof(_GetDirtyObject));
                }
                
                return _GetDirtyObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDirtyObjectCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDirtyObjectCount(IntPtr _this, GetDirtyObjectCount__Args args);
            private static _GetDirtyObjectCount _GetDirtyObjectCountFunc;
            internal static _GetDirtyObjectCount GetDirtyObjectCount() {
                if (_GetDirtyObjectCountFunc == null) {
                    _GetDirtyObjectCountFunc =
                        (_GetDirtyObjectCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_getDirtyObjectCount"), typeof(_GetDirtyObjectCount));
                }
                
                return _GetDirtyObjectCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct HasDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _HasDirty(IntPtr _this, HasDirty__Args args);
            private static _HasDirty _HasDirtyFunc;
            internal static _HasDirty HasDirty() {
                if (_HasDirtyFunc == null) {
                    _HasDirtyFunc =
                        (_HasDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_hasDirty"), typeof(_HasDirty));
                }
                
                return _HasDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsDirty__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsDirty(IntPtr _this, IsDirty__Args args);
            private static _IsDirty _IsDirtyFunc;
            internal static _IsDirty IsDirty() {
                if (_IsDirtyFunc == null) {
                    _IsDirtyFunc =
                        (_IsDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_isDirty"), typeof(_IsDirty));
                }
                
                return _IsDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveDirty__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveDirty(IntPtr _this, RemoveDirty__Args args);
            private static _RemoveDirty _RemoveDirtyFunc;
            internal static _RemoveDirty RemoveDirty() {
                if (_RemoveDirtyFunc == null) {
                    _RemoveDirtyFunc =
                        (_RemoveDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_removeDirty"), typeof(_RemoveDirty));
                }
                
                return _RemoveDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDirty__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetDirty(IntPtr _this, SetDirty__Args args);
            private static _SetDirty _SetDirtyFunc;
            internal static _SetDirty SetDirty() {
                if (_SetDirtyFunc == null) {
                    _SetDirtyFunc =
                        (_SetDirty)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_setDirty"), typeof(_SetDirty));
                }
                
                return _SetDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteObjectsFromFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteObjectsFromFile(IntPtr _this, DeleteObjectsFromFile__Args args);
            private static _DeleteObjectsFromFile _DeleteObjectsFromFileFunc;
            internal static _DeleteObjectsFromFile DeleteObjectsFromFile() {
                if (_DeleteObjectsFromFileFunc == null) {
                    _DeleteObjectsFromFileFunc =
                        (_DeleteObjectsFromFile)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPersistenceManager_deleteObjectsFromFile"), typeof(_DeleteObjectsFromFile));
                }
                
                return _DeleteObjectsFromFileFunc;
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
                                "fnPersistenceManager_staticGetType"), typeof(_StaticGetType));
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
                                "fnPersistenceManager_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void RemoveField(string objName, string fieldName) {
             InternalUnsafeMethods.RemoveField__Args _args = new InternalUnsafeMethods.RemoveField__Args() {
                objName = objName,
                fieldName = fieldName,
             };
             InternalUnsafeMethods.RemoveField()(ObjectPtr, _args);
        }

        public void RemoveObjectFromFile(string objName, string filename = "") {
             InternalUnsafeMethods.RemoveObjectFromFile__Args _args = new InternalUnsafeMethods.RemoveObjectFromFile__Args() {
                objName = objName,
                filename = filename,
             };
             InternalUnsafeMethods.RemoveObjectFromFile()(ObjectPtr, _args);
        }

        public void ClearAll() {
             InternalUnsafeMethods.ClearAll__Args _args = new InternalUnsafeMethods.ClearAll__Args() {
             };
             InternalUnsafeMethods.ClearAll()(ObjectPtr, _args);
        }

        public bool SaveDirtyObject(string objName) {
             InternalUnsafeMethods.SaveDirtyObject__Args _args = new InternalUnsafeMethods.SaveDirtyObject__Args() {
                objName = objName,
             };
             bool _engineResult = InternalUnsafeMethods.SaveDirtyObject()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SaveDirty() {
             InternalUnsafeMethods.SaveDirty__Args _args = new InternalUnsafeMethods.SaveDirty__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.SaveDirty()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ListDirty() {
             InternalUnsafeMethods.ListDirty__Args _args = new InternalUnsafeMethods.ListDirty__Args() {
             };
             InternalUnsafeMethods.ListDirty()(ObjectPtr, _args);
        }

        public int GetDirtyObject(int index) {
             InternalUnsafeMethods.GetDirtyObject__Args _args = new InternalUnsafeMethods.GetDirtyObject__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetDirtyObject()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetDirtyObjectCount() {
             InternalUnsafeMethods.GetDirtyObjectCount__Args _args = new InternalUnsafeMethods.GetDirtyObjectCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDirtyObjectCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool HasDirty() {
             InternalUnsafeMethods.HasDirty__Args _args = new InternalUnsafeMethods.HasDirty__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.HasDirty()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool IsDirty(string objName) {
             InternalUnsafeMethods.IsDirty__Args _args = new InternalUnsafeMethods.IsDirty__Args() {
                objName = objName,
             };
             bool _engineResult = InternalUnsafeMethods.IsDirty()(ObjectPtr, _args);
             return _engineResult;
        }

        public void RemoveDirty(string objName) {
             InternalUnsafeMethods.RemoveDirty__Args _args = new InternalUnsafeMethods.RemoveDirty__Args() {
                objName = objName,
             };
             InternalUnsafeMethods.RemoveDirty()(ObjectPtr, _args);
        }

        public void SetDirty(string objName, string fileName = "") {
             InternalUnsafeMethods.SetDirty__Args _args = new InternalUnsafeMethods.SetDirty__Args() {
                objName = objName,
                fileName = fileName,
             };
             InternalUnsafeMethods.SetDirty()(ObjectPtr, _args);
        }

        public void DeleteObjectsFromFile(string fileName) {
             InternalUnsafeMethods.DeleteObjectsFromFile__Args _args = new InternalUnsafeMethods.DeleteObjectsFromFile__Args() {
                fileName = fileName,
             };
             InternalUnsafeMethods.DeleteObjectsFromFile()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}