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
    public unsafe class SimObject : ConsoleObject, ISimObject {
        public SimObject(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SimObject(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SimObject(string pName) 
            : this(pName, false) {
        }
        
        public SimObject(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SimObject(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SimObject(SimObject pObj) 
            : base(pObj) {
        }
        
        public SimObject(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        public void SetPointerFromObject(ISimObject pObj) {
            if (pObj is SimObject sim) {
                base.SetPointerFromObject(sim);
            } else if (pObj is UnknownSimObject unk) {
                base.SetPointerFromObject(unk);
            } else {
                throw new NotImplementedException();
            }
        }

        public T As<T>() where T : class, ISimObject {
            if (typeof(SimObject).IsAssignableFrom(typeof(T))) {
                return base.As(typeof(T)) as T;
            } else if (typeof(UnknownSimObject).IsAssignableFrom(typeof(T))) {
                return base.As(typeof(T)) as T;
            }
            throw new NotImplementedException();
        }

        public ISimObject As(Type t) {
            if (typeof(SimObject).IsAssignableFrom(t)) {
                return base.As(t) as ISimObject;
            }
            throw new NotImplementedException();
        }
        
        public static implicit operator string(SimObject simObject) {
            return GenericMarshal.ToString((ISimObject)simObject);
        }
        
        public bool RegisterObject() {
			InternalUnsafeMethods.RegisterObject__Args _args = new InternalUnsafeMethods.RegisterObject__Args()
			{
			};
            bool registered = InternalUnsafeMethods.RegisterObject()(ObjectPtr, _args);
            if (registered) {
                SimDictionary.RegisterObject(this);
            }

            return registered;
        }

        public bool RegisterSingleton() => RegisterObject();

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct InspectPostApply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InspectPostApply(IntPtr _this, InspectPostApply__Args args);
            private static _InspectPostApply _InspectPostApplyFunc;
            internal static _InspectPostApply InspectPostApply() {
                if (_InspectPostApplyFunc == null) {
                    _InspectPostApplyFunc =
                        (_InspectPostApply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_InspectPostApply"), typeof(_InspectPostApply));
                }
                
                return _InspectPostApplyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct InspectPreApply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InspectPreApply(IntPtr _this, InspectPreApply__Args args);
            private static _InspectPreApply _InspectPreApplyFunc;
            internal static _InspectPreApply InspectPreApply() {
                if (_InspectPreApplyFunc == null) {
                    _InspectPreApplyFunc =
                        (_InspectPreApply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_InspectPreApply"), typeof(_InspectPreApply));
                }
                
                return _InspectPreApplyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsLocked__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsLocked(IntPtr _this, IsLocked__Args args);
            private static _IsLocked _IsLockedFunc;
            internal static _IsLocked IsLocked() {
                if (_IsLockedFunc == null) {
                    _IsLockedFunc =
                        (_IsLocked)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_IsLocked"), typeof(_IsLocked));
                }
                
                return _IsLockedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMods__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool modStaticFields;
                [MarshalAs(UnmanagedType.I1)]
                internal bool modDynamicFields;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMods(IntPtr _this, SetMods__Args args);
            private static _SetMods _SetModsFunc;
            internal static _SetMods SetMods() {
                if (_SetModsFunc == null) {
                    _SetModsFunc =
                        (_SetMods)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_SetMods"), typeof(_SetMods));
                }
                
                return _SetModsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct CopyFrom__Args
            {
                internal IntPtr parent;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CopyFrom(IntPtr _this, CopyFrom__Args args);
            private static _CopyFrom _CopyFromFunc;
            internal static _CopyFrom CopyFrom() {
                if (_CopyFromFunc == null) {
                    _CopyFromFunc =
                        (_CopyFrom)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_CopyFrom"), typeof(_CopyFrom));
                }
                
                return _CopyFromFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RegisterObject__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RegisterObject(IntPtr _this, RegisterObject__Args args);
            private static _RegisterObject _RegisterObjectFunc;
            internal static _RegisterObject RegisterObject() {
                if (_RegisterObjectFunc == null) {
                    _RegisterObjectFunc =
                        (_RegisterObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_RegisterObject"), typeof(_RegisterObject));
                }
                
                return _RegisterObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDebugInfo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetDebugInfo(IntPtr _this, GetDebugInfo__Args args);
            private static _GetDebugInfo _GetDebugInfoFunc;
            internal static _GetDebugInfo GetDebugInfo() {
                if (_GetDebugInfoFunc == null) {
                    _GetDebugInfoFunc =
                        (_GetDebugInfo)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getDebugInfo"), typeof(_GetDebugInfo));
                }
                
                return _GetDebugInfoFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetField__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetField(IntPtr _this, GetField__Args args);
            private static _GetField _GetFieldFunc;
            internal static _GetField GetField() {
                if (_GetFieldFunc == null) {
                    _GetFieldFunc =
                        (_GetField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getField"), typeof(_GetField));
                }
                
                return _GetFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFieldCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetFieldCount(IntPtr _this, GetFieldCount__Args args);
            private static _GetFieldCount _GetFieldCountFunc;
            internal static _GetFieldCount GetFieldCount() {
                if (_GetFieldCountFunc == null) {
                    _GetFieldCountFunc =
                        (_GetFieldCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getFieldCount"), typeof(_GetFieldCount));
                }
                
                return _GetFieldCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDynamicField__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDynamicField(IntPtr _this, GetDynamicField__Args args);
            private static _GetDynamicField _GetDynamicFieldFunc;
            internal static _GetDynamicField GetDynamicField() {
                if (_GetDynamicFieldFunc == null) {
                    _GetDynamicFieldFunc =
                        (_GetDynamicField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getDynamicField"), typeof(_GetDynamicField));
                }
                
                return _GetDynamicFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDynamicFieldCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDynamicFieldCount(IntPtr _this, GetDynamicFieldCount__Args args);
            private static _GetDynamicFieldCount _GetDynamicFieldCountFunc;
            internal static _GetDynamicFieldCount GetDynamicFieldCount() {
                if (_GetDynamicFieldCountFunc == null) {
                    _GetDynamicFieldCountFunc =
                        (_GetDynamicFieldCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getDynamicFieldCount"), typeof(_GetDynamicFieldCount));
                }
                
                return _GetDynamicFieldCountFunc;
            }


            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Schedule(IntPtr _this, ref StringVector.InternalStruct args);
            private static _Schedule _ScheduleFunc;
            internal static _Schedule Schedule() {
                if (_ScheduleFunc == null) {
                    _ScheduleFunc =
                        (_Schedule)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_schedule"), typeof(_Schedule));
                }
                
                return _ScheduleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Delete__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Delete(IntPtr _this, Delete__Args args);
            private static _Delete _DeleteFunc;
            internal static _Delete Delete() {
                if (_DeleteFunc == null) {
                    _DeleteFunc =
                        (_Delete)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_delete"), typeof(_Delete));
                }
                
                return _DeleteFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetGroup(IntPtr _this, GetGroup__Args args);
            private static _GetGroup _GetGroupFunc;
            internal static _GetGroup GetGroup() {
                if (_GetGroupFunc == null) {
                    _GetGroupFunc =
                        (_GetGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getGroup"), typeof(_GetGroup));
                }
                
                return _GetGroupFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetId(IntPtr _this, GetId__Args args);
            private static _GetId _GetIdFunc;
            internal static _GetId GetId() {
                if (_GetIdFunc == null) {
                    _GetIdFunc =
                        (_GetId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getId"), typeof(_GetId));
                }
                
                return _GetIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsInNamespaceHierarchy__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsInNamespaceHierarchy(IntPtr _this, IsInNamespaceHierarchy__Args args);
            private static _IsInNamespaceHierarchy _IsInNamespaceHierarchyFunc;
            internal static _IsInNamespaceHierarchy IsInNamespaceHierarchy() {
                if (_IsInNamespaceHierarchyFunc == null) {
                    _IsInNamespaceHierarchyFunc =
                        (_IsInNamespaceHierarchy)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isInNamespaceHierarchy"), typeof(_IsInNamespaceHierarchy));
                }
                
                return _IsInNamespaceHierarchyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsMemberOfClass__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string className;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsMemberOfClass(IntPtr _this, IsMemberOfClass__Args args);
            private static _IsMemberOfClass _IsMemberOfClassFunc;
            internal static _IsMemberOfClass IsMemberOfClass() {
                if (_IsMemberOfClassFunc == null) {
                    _IsMemberOfClassFunc =
                        (_IsMemberOfClass)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isMemberOfClass"), typeof(_IsMemberOfClass));
                }
                
                return _IsMemberOfClassFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpClassHierarchy__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpClassHierarchy(IntPtr _this, DumpClassHierarchy__Args args);
            private static _DumpClassHierarchy _DumpClassHierarchyFunc;
            internal static _DumpClassHierarchy DumpClassHierarchy() {
                if (_DumpClassHierarchyFunc == null) {
                    _DumpClassHierarchyFunc =
                        (_DumpClassHierarchy)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_dumpClassHierarchy"), typeof(_DumpClassHierarchy));
                }
                
                return _DumpClassHierarchyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInternalName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInternalName(IntPtr _this, GetInternalName__Args args);
            private static _GetInternalName _GetInternalNameFunc;
            internal static _GetInternalName GetInternalName() {
                if (_GetInternalNameFunc == null) {
                    _GetInternalNameFunc =
                        (_GetInternalName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getInternalName"), typeof(_GetInternalName));
                }
                
                return _GetInternalNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetInternalName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newInternalName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetInternalName(IntPtr _this, SetInternalName__Args args);
            private static _SetInternalName _SetInternalNameFunc;
            internal static _SetInternalName SetInternalName() {
                if (_SetInternalNameFunc == null) {
                    _SetInternalNameFunc =
                        (_SetInternalName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setInternalName"), typeof(_SetInternalName));
                }
                
                return _SetInternalNameFunc;
            }


            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _Call(IntPtr _this, ref StringVector.InternalStruct args);
            private static _Call _CallFunc;
            internal static _Call Call() {
                if (_CallFunc == null) {
                    _CallFunc =
                        (_Call)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_call"), typeof(_Call));
                }
                
                return _CallFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFieldType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFieldType(IntPtr _this, SetFieldType__Args args);
            private static _SetFieldType _SetFieldTypeFunc;
            internal static _SetFieldType SetFieldType() {
                if (_SetFieldTypeFunc == null) {
                    _SetFieldTypeFunc =
                        (_SetFieldType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setFieldType"), typeof(_SetFieldType));
                }
                
                return _SetFieldTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFieldType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFieldType(IntPtr _this, GetFieldType__Args args);
            private static _GetFieldType _GetFieldTypeFunc;
            internal static _GetFieldType GetFieldType() {
                if (_GetFieldTypeFunc == null) {
                    _GetFieldTypeFunc =
                        (_GetFieldType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getFieldType"), typeof(_GetFieldType));
                }
                
                return _GetFieldTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFieldValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetFieldValue(IntPtr _this, SetFieldValue__Args args);
            private static _SetFieldValue _SetFieldValueFunc;
            internal static _SetFieldValue SetFieldValue() {
                if (_SetFieldValueFunc == null) {
                    _SetFieldValueFunc =
                        (_SetFieldValue)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setFieldValue"), typeof(_SetFieldValue));
                }
                
                return _SetFieldValueFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFieldValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFieldValue(IntPtr _this, GetFieldValue__Args args);
            private static _GetFieldValue _GetFieldValueFunc;
            internal static _GetFieldValue GetFieldValue() {
                if (_GetFieldValueFunc == null) {
                    _GetFieldValueFunc =
                        (_GetFieldValue)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getFieldValue"), typeof(_GetFieldValue));
                }
                
                return _GetFieldValueFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsField(IntPtr _this, IsField__Args args);
            private static _IsField _IsFieldFunc;
            internal static _IsField IsField() {
                if (_IsFieldFunc == null) {
                    _IsFieldFunc =
                        (_IsField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isField"), typeof(_IsField));
                }
                
                return _IsFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetClassName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetClassName(IntPtr _this, GetClassName__Args args);
            private static _GetClassName _GetClassNameFunc;
            internal static _GetClassName GetClassName() {
                if (_GetClassNameFunc == null) {
                    _GetClassNameFunc =
                        (_GetClassName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getClassName"), typeof(_GetClassName));
                }
                
                return _GetClassNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetName(IntPtr _this, GetName__Args args);
            private static _GetName _GetNameFunc;
            internal static _GetName GetName() {
                if (_GetNameFunc == null) {
                    _GetNameFunc =
                        (_GetName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getName"), typeof(_GetName));
                }
                
                return _GetNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetName(IntPtr _this, SetName__Args args);
            private static _SetName _SetNameFunc;
            internal static _SetName SetName() {
                if (_SetNameFunc == null) {
                    _SetNameFunc =
                        (_SetName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setName"), typeof(_SetName));
                }
                
                return _SetNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Save__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
                [MarshalAs(UnmanagedType.I1)]
                internal bool selectedOnly;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string preAppendString;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Save(IntPtr _this, Save__Args args);
            private static _Save _SaveFunc;
            internal static _Save Save() {
                if (_SaveFunc == null) {
                    _SaveFunc =
                        (_Save)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_save"), typeof(_Save));
                }
                
                return _SaveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Dump__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool detailed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Dump(IntPtr _this, Dump__Args args);
            private static _Dump _DumpFunc;
            internal static _Dump Dump() {
                if (_DumpFunc == null) {
                    _DumpFunc =
                        (_Dump)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_dump"), typeof(_Dump));
                }
                
                return _DumpFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpMethods__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _DumpMethods(IntPtr _this, DumpMethods__Args args);
            private static _DumpMethods _DumpMethodsFunc;
            internal static _DumpMethods DumpMethods() {
                if (_DumpMethodsFunc == null) {
                    _DumpMethodsFunc =
                        (_DumpMethods)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_dumpMethods"), typeof(_DumpMethods));
                }
                
                return _DumpMethodsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetHidden__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetHidden(IntPtr _this, SetHidden__Args args);
            private static _SetHidden _SetHiddenFunc;
            internal static _SetHidden SetHidden() {
                if (_SetHiddenFunc == null) {
                    _SetHiddenFunc =
                        (_SetHidden)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setHidden"), typeof(_SetHidden));
                }
                
                return _SetHiddenFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetLocked__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetLocked(IntPtr _this, SetLocked__Args args);
            private static _SetLocked _SetLockedFunc;
            internal static _SetLocked SetLocked() {
                if (_SetLockedFunc == null) {
                    _SetLockedFunc =
                        (_SetLocked)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setLocked"), typeof(_SetLocked));
                }
                
                return _SetLockedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DeepClone__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _DeepClone(IntPtr _this, DeepClone__Args args);
            private static _DeepClone _DeepCloneFunc;
            internal static _DeepClone DeepClone() {
                if (_DeepCloneFunc == null) {
                    _DeepCloneFunc =
                        (_DeepClone)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_deepClone"), typeof(_DeepClone));
                }
                
                return _DeepCloneFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Clone__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Clone(IntPtr _this, Clone__Args args);
            private static _Clone _CloneFunc;
            internal static _Clone Clone() {
                if (_CloneFunc == null) {
                    _CloneFunc =
                        (_Clone)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_clone"), typeof(_Clone));
                }
                
                return _CloneFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNameChangeAllowed__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNameChangeAllowed(IntPtr _this, SetNameChangeAllowed__Args args);
            private static _SetNameChangeAllowed _SetNameChangeAllowedFunc;
            internal static _SetNameChangeAllowed SetNameChangeAllowed() {
                if (_SetNameChangeAllowedFunc == null) {
                    _SetNameChangeAllowedFunc =
                        (_SetNameChangeAllowed)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setNameChangeAllowed"), typeof(_SetNameChangeAllowed));
                }
                
                return _SetNameChangeAllowedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsNameChangeAllowed__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsNameChangeAllowed(IntPtr _this, IsNameChangeAllowed__Args args);
            private static _IsNameChangeAllowed _IsNameChangeAllowedFunc;
            internal static _IsNameChangeAllowed IsNameChangeAllowed() {
                if (_IsNameChangeAllowedFunc == null) {
                    _IsNameChangeAllowedFunc =
                        (_IsNameChangeAllowed)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isNameChangeAllowed"), typeof(_IsNameChangeAllowed));
                }
                
                return _IsNameChangeAllowedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEditorOnly__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEditorOnly(IntPtr _this, SetEditorOnly__Args args);
            private static _SetEditorOnly _SetEditorOnlyFunc;
            internal static _SetEditorOnly SetEditorOnly() {
                if (_SetEditorOnlyFunc == null) {
                    _SetEditorOnlyFunc =
                        (_SetEditorOnly)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setEditorOnly"), typeof(_SetEditorOnly));
                }
                
                return _SetEditorOnlyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsEditorOnly__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsEditorOnly(IntPtr _this, IsEditorOnly__Args args);
            private static _IsEditorOnly _IsEditorOnlyFunc;
            internal static _IsEditorOnly IsEditorOnly() {
                if (_IsEditorOnlyFunc == null) {
                    _IsEditorOnlyFunc =
                        (_IsEditorOnly)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isEditorOnly"), typeof(_IsEditorOnly));
                }
                
                return _IsEditorOnlyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCanSave__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCanSave(IntPtr _this, SetCanSave__Args args);
            private static _SetCanSave _SetCanSaveFunc;
            internal static _SetCanSave SetCanSave() {
                if (_SetCanSaveFunc == null) {
                    _SetCanSaveFunc =
                        (_SetCanSave)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setCanSave"), typeof(_SetCanSave));
                }
                
                return _SetCanSaveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCanSave__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetCanSave(IntPtr _this, GetCanSave__Args args);
            private static _GetCanSave _GetCanSaveFunc;
            internal static _GetCanSave GetCanSave() {
                if (_GetCanSaveFunc == null) {
                    _GetCanSaveFunc =
                        (_GetCanSave)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getCanSave"), typeof(_GetCanSave));
                }
                
                return _GetCanSaveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AssignPersistentId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AssignPersistentId(IntPtr _this, AssignPersistentId__Args args);
            private static _AssignPersistentId _AssignPersistentIdFunc;
            internal static _AssignPersistentId AssignPersistentId() {
                if (_AssignPersistentIdFunc == null) {
                    _AssignPersistentIdFunc =
                        (_AssignPersistentId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_assignPersistentId"), typeof(_AssignPersistentId));
                }
                
                return _AssignPersistentIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AssignFieldsFrom__Args
            {
                internal IntPtr fromObject;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AssignFieldsFrom(IntPtr _this, AssignFieldsFrom__Args args);
            private static _AssignFieldsFrom _AssignFieldsFromFunc;
            internal static _AssignFieldsFrom AssignFieldsFrom() {
                if (_AssignFieldsFromFunc == null) {
                    _AssignFieldsFromFunc =
                        (_AssignFieldsFrom)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_assignFieldsFrom"), typeof(_AssignFieldsFrom));
                }
                
                return _AssignFieldsFromFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDeclarationLine__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDeclarationLine(IntPtr _this, GetDeclarationLine__Args args);
            private static _GetDeclarationLine _GetDeclarationLineFunc;
            internal static _GetDeclarationLine GetDeclarationLine() {
                if (_GetDeclarationLineFunc == null) {
                    _GetDeclarationLineFunc =
                        (_GetDeclarationLine)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getDeclarationLine"), typeof(_GetDeclarationLine));
                }
                
                return _GetDeclarationLineFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFilename__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFilename(IntPtr _this, SetFilename__Args args);
            private static _SetFilename _SetFilenameFunc;
            internal static _SetFilename SetFilename() {
                if (_SetFilenameFunc == null) {
                    _SetFilenameFunc =
                        (_SetFilename)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setFilename"), typeof(_SetFilename));
                }
                
                return _SetFilenameFunc;
            }

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
                                "fnSimObject_getFilename"), typeof(_GetFilename));
                }
                
                return _GetFilenameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetIsExpanded__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetIsExpanded(IntPtr _this, SetIsExpanded__Args args);
            private static _SetIsExpanded _SetIsExpandedFunc;
            internal static _SetIsExpanded SetIsExpanded() {
                if (_SetIsExpandedFunc == null) {
                    _SetIsExpandedFunc =
                        (_SetIsExpanded)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setIsExpanded"), typeof(_SetIsExpanded));
                }
                
                return _SetIsExpandedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsExpanded__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsExpanded(IntPtr _this, IsExpanded__Args args);
            private static _IsExpanded _IsExpandedFunc;
            internal static _IsExpanded IsExpanded() {
                if (_IsExpandedFunc == null) {
                    _IsExpandedFunc =
                        (_IsExpanded)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isExpanded"), typeof(_IsExpanded));
                }
                
                return _IsExpandedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetIsSelected__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetIsSelected(IntPtr _this, SetIsSelected__Args args);
            private static _SetIsSelected _SetIsSelectedFunc;
            internal static _SetIsSelected SetIsSelected() {
                if (_SetIsSelectedFunc == null) {
                    _SetIsSelectedFunc =
                        (_SetIsSelected)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setIsSelected"), typeof(_SetIsSelected));
                }
                
                return _SetIsSelectedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsSelected(IntPtr _this, IsSelected__Args args);
            private static _IsSelected _IsSelectedFunc;
            internal static _IsSelected IsSelected() {
                if (_IsSelectedFunc == null) {
                    _IsSelectedFunc =
                        (_IsSelected)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isSelected"), typeof(_IsSelected));
                }
                
                return _IsSelectedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSuperClassNamespace__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSuperClassNamespace(IntPtr _this, SetSuperClassNamespace__Args args);
            private static _SetSuperClassNamespace _SetSuperClassNamespaceFunc;
            internal static _SetSuperClassNamespace SetSuperClassNamespace() {
                if (_SetSuperClassNamespaceFunc == null) {
                    _SetSuperClassNamespaceFunc =
                        (_SetSuperClassNamespace)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setSuperClassNamespace"), typeof(_SetSuperClassNamespace));
                }
                
                return _SetSuperClassNamespaceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetClassNamespace__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetClassNamespace(IntPtr _this, SetClassNamespace__Args args);
            private static _SetClassNamespace _SetClassNamespaceFunc;
            internal static _SetClassNamespace SetClassNamespace() {
                if (_SetClassNamespaceFunc == null) {
                    _SetClassNamespaceFunc =
                        (_SetClassNamespace)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_setClassNamespace"), typeof(_SetClassNamespace));
                }
                
                return _SetClassNamespaceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSuperClassNamespace__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSuperClassNamespace(IntPtr _this, GetSuperClassNamespace__Args args);
            private static _GetSuperClassNamespace _GetSuperClassNamespaceFunc;
            internal static _GetSuperClassNamespace GetSuperClassNamespace() {
                if (_GetSuperClassNamespaceFunc == null) {
                    _GetSuperClassNamespaceFunc =
                        (_GetSuperClassNamespace)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getSuperClassNamespace"), typeof(_GetSuperClassNamespace));
                }
                
                return _GetSuperClassNamespaceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetClassNamespace__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetClassNamespace(IntPtr _this, GetClassNamespace__Args args);
            private static _GetClassNamespace _GetClassNamespaceFunc;
            internal static _GetClassNamespace GetClassNamespace() {
                if (_GetClassNamespaceFunc == null) {
                    _GetClassNamespaceFunc =
                        (_GetClassNamespace)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_getClassNamespace"), typeof(_GetClassNamespace));
                }
                
                return _GetClassNamespaceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsChildOfGroup__Args
            {
                internal IntPtr group;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsChildOfGroup(IntPtr _this, IsChildOfGroup__Args args);
            private static _IsChildOfGroup _IsChildOfGroupFunc;
            internal static _IsChildOfGroup IsChildOfGroup() {
                if (_IsChildOfGroupFunc == null) {
                    _IsChildOfGroupFunc =
                        (_IsChildOfGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isChildOfGroup"), typeof(_IsChildOfGroup));
                }
                
                return _IsChildOfGroupFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsMethod__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string methodName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsMethod(IntPtr _this, IsMethod__Args args);
            private static _IsMethod _IsMethodFunc;
            internal static _IsMethod IsMethod() {
                if (_IsMethodFunc == null) {
                    _IsMethodFunc =
                        (_IsMethod)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_isMethod"), typeof(_IsMethod));
                }
                
                return _IsMethodFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpGroupHierarchy__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpGroupHierarchy(IntPtr _this, DumpGroupHierarchy__Args args);
            private static _DumpGroupHierarchy _DumpGroupHierarchyFunc;
            internal static _DumpGroupHierarchy DumpGroupHierarchy() {
                if (_DumpGroupHierarchyFunc == null) {
                    _DumpGroupHierarchyFunc =
                        (_DumpGroupHierarchy)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimObject_dumpGroupHierarchy"), typeof(_DumpGroupHierarchy));
                }
                
                return _DumpGroupHierarchyFunc;
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
                                "fnSimObject_staticGetType"), typeof(_StaticGetType));
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
                                "fnSimObject_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void InspectPostApply() {
             InternalUnsafeMethods.InspectPostApply__Args _args = new InternalUnsafeMethods.InspectPostApply__Args() {
             };
             InternalUnsafeMethods.InspectPostApply()(ObjectPtr, _args);
        }

        public void InspectPreApply() {
             InternalUnsafeMethods.InspectPreApply__Args _args = new InternalUnsafeMethods.InspectPreApply__Args() {
             };
             InternalUnsafeMethods.InspectPreApply()(ObjectPtr, _args);
        }

        public bool IsLocked() {
             InternalUnsafeMethods.IsLocked__Args _args = new InternalUnsafeMethods.IsLocked__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsLocked()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetMods(bool modStaticFields, bool modDynamicFields) {
             InternalUnsafeMethods.SetMods__Args _args = new InternalUnsafeMethods.SetMods__Args() {
                modStaticFields = modStaticFields,
                modDynamicFields = modDynamicFields,
             };
             InternalUnsafeMethods.SetMods()(ObjectPtr, _args);
        }

        public void CopyFrom(SimObject parent) {
             InternalUnsafeMethods.CopyFrom__Args _args = new InternalUnsafeMethods.CopyFrom__Args() {
                parent = parent.ObjectPtr,
             };
             InternalUnsafeMethods.CopyFrom()(ObjectPtr, _args);
        }

        public ArrayObject GetDebugInfo() {
             InternalUnsafeMethods.GetDebugInfo__Args _args = new InternalUnsafeMethods.GetDebugInfo__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDebugInfo()(ObjectPtr, _args);
             return new ArrayObject(_engineResult);
        }

        public string GetField(int index) {
             InternalUnsafeMethods.GetField__Args _args = new InternalUnsafeMethods.GetField__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetField()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetFieldCount() {
             InternalUnsafeMethods.GetFieldCount__Args _args = new InternalUnsafeMethods.GetFieldCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetFieldCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetDynamicField(int index) {
             InternalUnsafeMethods.GetDynamicField__Args _args = new InternalUnsafeMethods.GetDynamicField__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDynamicField()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetDynamicFieldCount() {
             InternalUnsafeMethods.GetDynamicFieldCount__Args _args = new InternalUnsafeMethods.GetDynamicFieldCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDynamicFieldCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public int Schedule(params string[] args) { 
            List<string> _argList = new List<string>() {"", ""};
            _argList.AddRange(args);

            StringVector nativeVecArgs = new StringVector {
                ElementCount = (uint)_argList.Count,
                Array = _argList.ToArray(),
                ArraySize = (uint)_argList.Count
            };
            nativeVecArgs.Alloc();
            int _engineResult = InternalUnsafeMethods.Schedule()(ObjectPtr, ref nativeVecArgs.internalStruct);
            nativeVecArgs.Free();

            return _engineResult;
        }

        public void Delete() {
             InternalUnsafeMethods.Delete__Args _args = new InternalUnsafeMethods.Delete__Args() {
             };
             InternalUnsafeMethods.Delete()(ObjectPtr, _args);
        }

        public SimGroup GetGroup() {
             InternalUnsafeMethods.GetGroup__Args _args = new InternalUnsafeMethods.GetGroup__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGroup()(ObjectPtr, _args);
             return new SimGroup(_engineResult);
        }

        public int GetId() {
             InternalUnsafeMethods.GetId__Args _args = new InternalUnsafeMethods.GetId__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetId()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool IsInNamespaceHierarchy(string name) {
             InternalUnsafeMethods.IsInNamespaceHierarchy__Args _args = new InternalUnsafeMethods.IsInNamespaceHierarchy__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.IsInNamespaceHierarchy()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool IsMemberOfClass(string className) {
             InternalUnsafeMethods.IsMemberOfClass__Args _args = new InternalUnsafeMethods.IsMemberOfClass__Args() {
                className = className,
             };
             bool _engineResult = InternalUnsafeMethods.IsMemberOfClass()(ObjectPtr, _args);
             return _engineResult;
        }

        public void DumpClassHierarchy() {
             InternalUnsafeMethods.DumpClassHierarchy__Args _args = new InternalUnsafeMethods.DumpClassHierarchy__Args() {
             };
             InternalUnsafeMethods.DumpClassHierarchy()(ObjectPtr, _args);
        }

        public string GetInternalName() {
             InternalUnsafeMethods.GetInternalName__Args _args = new InternalUnsafeMethods.GetInternalName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInternalName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetInternalName(string newInternalName) {
             InternalUnsafeMethods.SetInternalName__Args _args = new InternalUnsafeMethods.SetInternalName__Args() {
                newInternalName = newInternalName,
             };
             InternalUnsafeMethods.SetInternalName()(ObjectPtr, _args);
        }

        public string Call(params string[] args) { 
            List<string> _argList = new List<string>() {"", ""};
            _argList.AddRange(args);

            StringVector nativeVecArgs = new StringVector {
                ElementCount = (uint)_argList.Count,
                Array = _argList.ToArray(),
                ArraySize = (uint)_argList.Count
            };
            nativeVecArgs.Alloc();
            IntPtr _engineResult = InternalUnsafeMethods.Call()(ObjectPtr, ref nativeVecArgs.internalStruct);
            nativeVecArgs.Free();

            return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetFieldType(string fieldName, string type) {
             InternalUnsafeMethods.SetFieldType__Args _args = new InternalUnsafeMethods.SetFieldType__Args() {
                fieldName = fieldName,
                type = type,
             };
             InternalUnsafeMethods.SetFieldType()(ObjectPtr, _args);
        }

        public string GetFieldType(string fieldName) {
             InternalUnsafeMethods.GetFieldType__Args _args = new InternalUnsafeMethods.GetFieldType__Args() {
                fieldName = fieldName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFieldType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetFieldValue(string fieldName, string value, int index = -1) {
             InternalUnsafeMethods.SetFieldValue__Args _args = new InternalUnsafeMethods.SetFieldValue__Args() {
                fieldName = fieldName,
                value = value,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetFieldValue()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetFieldValue(string fieldName, int index = -1) {
             InternalUnsafeMethods.GetFieldValue__Args _args = new InternalUnsafeMethods.GetFieldValue__Args() {
                fieldName = fieldName,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFieldValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool IsField(string fieldName) {
             InternalUnsafeMethods.IsField__Args _args = new InternalUnsafeMethods.IsField__Args() {
                fieldName = fieldName,
             };
             bool _engineResult = InternalUnsafeMethods.IsField()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetClassName() {
             InternalUnsafeMethods.GetClassName__Args _args = new InternalUnsafeMethods.GetClassName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetClassName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string GetName() {
             InternalUnsafeMethods.GetName__Args _args = new InternalUnsafeMethods.GetName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetName(string newName) {
             InternalUnsafeMethods.SetName__Args _args = new InternalUnsafeMethods.SetName__Args() {
                newName = newName,
             };
             InternalUnsafeMethods.SetName()(ObjectPtr, _args);
        }

        public bool Save(string fileName, bool selectedOnly = false, string preAppendString = "") {
             InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                fileName = fileName,
                selectedOnly = selectedOnly,
                preAppendString = preAppendString,
             };
             bool _engineResult = InternalUnsafeMethods.Save()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Dump(bool detailed = false) {
             InternalUnsafeMethods.Dump__Args _args = new InternalUnsafeMethods.Dump__Args() {
                detailed = detailed,
             };
             InternalUnsafeMethods.Dump()(ObjectPtr, _args);
        }

        public ArrayObject DumpMethods() {
             InternalUnsafeMethods.DumpMethods__Args _args = new InternalUnsafeMethods.DumpMethods__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.DumpMethods()(ObjectPtr, _args);
             return new ArrayObject(_engineResult);
        }

        public void SetHidden(bool value = true) {
             InternalUnsafeMethods.SetHidden__Args _args = new InternalUnsafeMethods.SetHidden__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetHidden()(ObjectPtr, _args);
        }

        public void SetLocked(bool value = true) {
             InternalUnsafeMethods.SetLocked__Args _args = new InternalUnsafeMethods.SetLocked__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetLocked()(ObjectPtr, _args);
        }

        public SimObject DeepClone() {
             InternalUnsafeMethods.DeepClone__Args _args = new InternalUnsafeMethods.DeepClone__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.DeepClone()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        public SimObject Clone() {
             InternalUnsafeMethods.Clone__Args _args = new InternalUnsafeMethods.Clone__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.Clone()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        public void SetNameChangeAllowed(bool value = true) {
             InternalUnsafeMethods.SetNameChangeAllowed__Args _args = new InternalUnsafeMethods.SetNameChangeAllowed__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetNameChangeAllowed()(ObjectPtr, _args);
        }

        public bool IsNameChangeAllowed() {
             InternalUnsafeMethods.IsNameChangeAllowed__Args _args = new InternalUnsafeMethods.IsNameChangeAllowed__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsNameChangeAllowed()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetEditorOnly(bool value = true) {
             InternalUnsafeMethods.SetEditorOnly__Args _args = new InternalUnsafeMethods.SetEditorOnly__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetEditorOnly()(ObjectPtr, _args);
        }

        public bool IsEditorOnly() {
             InternalUnsafeMethods.IsEditorOnly__Args _args = new InternalUnsafeMethods.IsEditorOnly__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsEditorOnly()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetCanSave(bool value = true) {
             InternalUnsafeMethods.SetCanSave__Args _args = new InternalUnsafeMethods.SetCanSave__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetCanSave()(ObjectPtr, _args);
        }

        public bool GetCanSave() {
             InternalUnsafeMethods.GetCanSave__Args _args = new InternalUnsafeMethods.GetCanSave__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetCanSave()(ObjectPtr, _args);
             return _engineResult;
        }

        public void AssignPersistentId() {
             InternalUnsafeMethods.AssignPersistentId__Args _args = new InternalUnsafeMethods.AssignPersistentId__Args() {
             };
             InternalUnsafeMethods.AssignPersistentId()(ObjectPtr, _args);
        }

        public void AssignFieldsFrom(SimObject fromObject) {
             InternalUnsafeMethods.AssignFieldsFrom__Args _args = new InternalUnsafeMethods.AssignFieldsFrom__Args() {
                fromObject = fromObject.ObjectPtr,
             };
             InternalUnsafeMethods.AssignFieldsFrom()(ObjectPtr, _args);
        }

        public int GetDeclarationLine() {
             InternalUnsafeMethods.GetDeclarationLine__Args _args = new InternalUnsafeMethods.GetDeclarationLine__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDeclarationLine()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetFilename(string fileName) {
             InternalUnsafeMethods.SetFilename__Args _args = new InternalUnsafeMethods.SetFilename__Args() {
                fileName = fileName,
             };
             InternalUnsafeMethods.SetFilename()(ObjectPtr, _args);
        }

        public string GetFilename() {
             InternalUnsafeMethods.GetFilename__Args _args = new InternalUnsafeMethods.GetFilename__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFilename()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetIsExpanded(bool state = true) {
             InternalUnsafeMethods.SetIsExpanded__Args _args = new InternalUnsafeMethods.SetIsExpanded__Args() {
                state = state,
             };
             InternalUnsafeMethods.SetIsExpanded()(ObjectPtr, _args);
        }

        public bool IsExpanded() {
             InternalUnsafeMethods.IsExpanded__Args _args = new InternalUnsafeMethods.IsExpanded__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsExpanded()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetIsSelected(bool state = true) {
             InternalUnsafeMethods.SetIsSelected__Args _args = new InternalUnsafeMethods.SetIsSelected__Args() {
                state = state,
             };
             InternalUnsafeMethods.SetIsSelected()(ObjectPtr, _args);
        }

        public bool IsSelected() {
             InternalUnsafeMethods.IsSelected__Args _args = new InternalUnsafeMethods.IsSelected__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetSuperClassNamespace(string name) {
             InternalUnsafeMethods.SetSuperClassNamespace__Args _args = new InternalUnsafeMethods.SetSuperClassNamespace__Args() {
                name = name,
             };
             InternalUnsafeMethods.SetSuperClassNamespace()(ObjectPtr, _args);
        }

        public void SetClassNamespace(string name) {
             InternalUnsafeMethods.SetClassNamespace__Args _args = new InternalUnsafeMethods.SetClassNamespace__Args() {
                name = name,
             };
             InternalUnsafeMethods.SetClassNamespace()(ObjectPtr, _args);
        }

        public string GetSuperClassNamespace() {
             InternalUnsafeMethods.GetSuperClassNamespace__Args _args = new InternalUnsafeMethods.GetSuperClassNamespace__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSuperClassNamespace()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string GetClassNamespace() {
             InternalUnsafeMethods.GetClassNamespace__Args _args = new InternalUnsafeMethods.GetClassNamespace__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetClassNamespace()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool IsChildOfGroup(SimGroup group) {
             InternalUnsafeMethods.IsChildOfGroup__Args _args = new InternalUnsafeMethods.IsChildOfGroup__Args() {
                group = group.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.IsChildOfGroup()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool IsMethod(string methodName) {
             InternalUnsafeMethods.IsMethod__Args _args = new InternalUnsafeMethods.IsMethod__Args() {
                methodName = methodName,
             };
             bool _engineResult = InternalUnsafeMethods.IsMethod()(ObjectPtr, _args);
             return _engineResult;
        }

        public void DumpGroupHierarchy() {
             InternalUnsafeMethods.DumpGroupHierarchy__Args _args = new InternalUnsafeMethods.DumpGroupHierarchy__Args() {
             };
             InternalUnsafeMethods.DumpGroupHierarchy()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public new string Name {
            get => GetName();
            set => SetName(value);
        }

        public string InternalName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("internalName"));
            set => SetFieldValue("internalName", GenericMarshal.ToString(value));
        }

        public SimObject ParentGroup {
            get => GenericMarshal.StringTo<SimObject>(GetFieldValue("parentGroup"));
            set => SetFieldValue("parentGroup", GenericMarshal.ToString(value));
        }

        public string Class {
            get => GenericMarshal.StringTo<string>(GetFieldValue("class"));
            set => SetFieldValue("class", GenericMarshal.ToString(value));
        }

        public string SuperClass {
            get => GenericMarshal.StringTo<string>(GetFieldValue("superClass"));
            set => SetFieldValue("superClass", GenericMarshal.ToString(value));
        }

        public string ClassName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("className"));
            set => SetFieldValue("className", GenericMarshal.ToString(value));
        }

        public bool Hidden {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hidden"));
            set => SetFieldValue("hidden", GenericMarshal.ToString(value));
        }

        public bool Locked {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("locked"));
            set => SetFieldValue("locked", GenericMarshal.ToString(value));
        }

        public bool CanSave {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canSave"));
            set => SetFieldValue("canSave", GenericMarshal.ToString(value));
        }

        public bool CanSaveDynamicFields {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canSaveDynamicFields"));
            set => SetFieldValue("canSaveDynamicFields", GenericMarshal.ToString(value));
        }

        public SimPersistID PersistentId {
            get => GenericMarshal.StringTo<SimPersistID>(GetFieldValue("persistentId"));
            set => SetFieldValue("persistentId", GenericMarshal.ToString(value));
        }
    }
}