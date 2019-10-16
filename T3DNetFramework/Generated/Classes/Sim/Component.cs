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
    public unsafe class Component : SimObject {
        public Component(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Component(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Component(string pName) 
            : this(pName, false) {
        }
        
        public Component(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Component(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Component(SimObject pObj) 
            : base(pObj) {
        }
        
        public Component(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDirty__Args
            {
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
                                "fnComponent_setDirty"), typeof(_SetDirty));
                }
                
                return _SetDirtyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddDependency__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string behaviorName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddDependency(IntPtr _this, AddDependency__Args args);
            private static _AddDependency _AddDependencyFunc;
            internal static _AddDependency AddDependency() {
                if (_AddDependencyFunc == null) {
                    _AddDependencyFunc =
                        (_AddDependency)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_addDependency"), typeof(_AddDependency));
                }
                
                return _AddDependencyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetComponentFieldDescription__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetComponentFieldDescription(IntPtr _this, GetComponentFieldDescription__Args args);
            private static _GetComponentFieldDescription _GetComponentFieldDescriptionFunc;
            internal static _GetComponentFieldDescription GetComponentFieldDescription() {
                if (_GetComponentFieldDescriptionFunc == null) {
                    _GetComponentFieldDescriptionFunc =
                        (_GetComponentFieldDescription)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_getComponentFieldDescription"), typeof(_GetComponentFieldDescription));
                }
                
                return _GetComponentFieldDescriptionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBehaviorFieldUserData__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBehaviorFieldUserData(IntPtr _this, GetBehaviorFieldUserData__Args args);
            private static _GetBehaviorFieldUserData _GetBehaviorFieldUserDataFunc;
            internal static _GetBehaviorFieldUserData GetBehaviorFieldUserData() {
                if (_GetBehaviorFieldUserDataFunc == null) {
                    _GetBehaviorFieldUserDataFunc =
                        (_GetBehaviorFieldUserData)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_getBehaviorFieldUserData"), typeof(_GetBehaviorFieldUserData));
                }
                
                return _GetBehaviorFieldUserDataFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetComponentFieldType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetComponentFieldType(IntPtr _this, GetComponentFieldType__Args args);
            private static _GetComponentFieldType _GetComponentFieldTypeFunc;
            internal static _GetComponentFieldType GetComponentFieldType() {
                if (_GetComponentFieldTypeFunc == null) {
                    _GetComponentFieldTypeFunc =
                        (_GetComponentFieldType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_getComponentFieldType"), typeof(_GetComponentFieldType));
                }
                
                return _GetComponentFieldTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetComponentield__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _SetComponentield(IntPtr _this, SetComponentield__Args args);
            private static _SetComponentield _SetComponentieldFunc;
            internal static _SetComponentield SetComponentield() {
                if (_SetComponentieldFunc == null) {
                    _SetComponentieldFunc =
                        (_SetComponentield)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_setComponentield"), typeof(_SetComponentield));
                }
                
                return _SetComponentieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetComponentField__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetComponentField(IntPtr _this, GetComponentField__Args args);
            private static _GetComponentField _GetComponentFieldFunc;
            internal static _GetComponentField GetComponentField() {
                if (_GetComponentFieldFunc == null) {
                    _GetComponentFieldFunc =
                        (_GetComponentField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_getComponentField"), typeof(_GetComponentField));
                }
                
                return _GetComponentFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetComponentFieldCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetComponentFieldCount(IntPtr _this, GetComponentFieldCount__Args args);
            private static _GetComponentFieldCount _GetComponentFieldCountFunc;
            internal static _GetComponentFieldCount GetComponentFieldCount() {
                if (_GetComponentFieldCountFunc == null) {
                    _GetComponentFieldCountFunc =
                        (_GetComponentFieldCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_getComponentFieldCount"), typeof(_GetComponentFieldCount));
                }
                
                return _GetComponentFieldCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddComponentField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldDesc;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldType;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string defValue;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string userData;
                [MarshalAs(UnmanagedType.I1)]
                internal bool hidden;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddComponentField(IntPtr _this, AddComponentField__Args args);
            private static _AddComponentField _AddComponentFieldFunc;
            internal static _AddComponentField AddComponentField() {
                if (_AddComponentFieldFunc == null) {
                    _AddComponentFieldFunc =
                        (_AddComponentField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_addComponentField"), typeof(_AddComponentField));
                }
                
                return _AddComponentFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct EndGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EndGroup(IntPtr _this, EndGroup__Args args);
            private static _EndGroup _EndGroupFunc;
            internal static _EndGroup EndGroup() {
                if (_EndGroupFunc == null) {
                    _EndGroupFunc =
                        (_EndGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_endGroup"), typeof(_EndGroup));
                }
                
                return _EndGroupFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct BeginGroup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _BeginGroup(IntPtr _this, BeginGroup__Args args);
            private static _BeginGroup _BeginGroupFunc;
            internal static _BeginGroup BeginGroup() {
                if (_BeginGroupFunc == null) {
                    _BeginGroupFunc =
                        (_BeginGroup)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnComponent_beginGroup"), typeof(_BeginGroup));
                }
                
                return _BeginGroupFunc;
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
                                "fnComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <summary>Gets a field description by index</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>Returns a string representing the description of this field</returns>
        public void SetDirty() {
             InternalUnsafeMethods.SetDirty__Args _args = new InternalUnsafeMethods.SetDirty__Args() {
             };
             InternalUnsafeMethods.SetDirty()(ObjectPtr, _args);
        }

        /// <summary>Gets a field description by index</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>Returns a string representing the description of this field</returns>
        public void AddDependency(string behaviorName) {
             InternalUnsafeMethods.AddDependency__Args _args = new InternalUnsafeMethods.AddDependency__Args() {
                behaviorName = behaviorName,
             };
             InternalUnsafeMethods.AddDependency()(ObjectPtr, _args);
        }

        /// <summary>Gets a field description by index</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>Returns a string representing the description of this field</returns>
        public string GetComponentFieldDescription(int index) {
             InternalUnsafeMethods.GetComponentFieldDescription__Args _args = new InternalUnsafeMethods.GetComponentFieldDescription__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetComponentFieldDescription()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the UserData associated with a field by index in the field list</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>Returns a string representing the user data of this field</returns>
        public string GetBehaviorFieldUserData(int index) {
             InternalUnsafeMethods.GetBehaviorFieldUserData__Args _args = new InternalUnsafeMethods.GetBehaviorFieldUserData__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBehaviorFieldUserData()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the number of static fields on the object.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public string GetComponentFieldType(string fieldName) {
             InternalUnsafeMethods.GetComponentFieldType__Args _args = new InternalUnsafeMethods.GetComponentFieldType__Args() {
                fieldName = fieldName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetComponentFieldType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets a Tab-Delimited list of information about a ComponentField specified by Index</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>FieldName, FieldType and FieldDefaultValue, each separated by a TAB character.</returns>
        public string SetComponentield(int index) {
             InternalUnsafeMethods.SetComponentield__Args _args = new InternalUnsafeMethods.SetComponentield__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.SetComponentield()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets a Tab-Delimited list of information about a ComponentField specified by Index</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The index of the behavior</param>
        /// <returns>FieldName, FieldType and FieldDefaultValue, each separated by a TAB character.</returns>
        public string GetComponentField(int index) {
             InternalUnsafeMethods.GetComponentField__Args _args = new InternalUnsafeMethods.GetComponentField__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetComponentField()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Get the number of ComponentField's on this object</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns the number of BehaviorFields as a nonnegative integer</returns>
        public int GetComponentFieldCount() {
             InternalUnsafeMethods.GetComponentFieldCount__Args _args = new InternalUnsafeMethods.GetComponentFieldCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetComponentFieldCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the number of static fields on the object.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public void AddComponentField(string fieldName = "", string fieldDesc = "", string fieldType = "", string defValue = "", string userData = "", bool hidden = false) {
             InternalUnsafeMethods.AddComponentField__Args _args = new InternalUnsafeMethods.AddComponentField__Args() {
                fieldName = fieldName,
                fieldDesc = fieldDesc,
                fieldType = fieldType,
                defValue = defValue,
                userData = userData,
                hidden = hidden,
             };
             InternalUnsafeMethods.AddComponentField()(ObjectPtr, _args);
        }

        /// <summary>Ends the grouping for prior fields being added to be grouped into</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="groupName">The name of this group</param>
        /// <param name="desc">The Description of this field</param>
        /// <param name="type">The DataType for this field (default, int, float, Point2F, bool, enum, Object, keybind, color)</param>
        /// <param name="defaultValue">The Default value for this field</param>
        /// <param name="userData">An extra data field that can be used for custom data on a per-field basis<br>Usage for default types<br>-enum: a TAB separated list of possible values<br>-object: the T2D object type that are valid choices for the field.  The object types observe inheritance, so if you have a t2dSceneObject field you will be able to choose t2dStaticSrpites, t2dAnimatedSprites, etc.</param>
        /// <returns>Nothing</returns>
        public void EndGroup() {
             InternalUnsafeMethods.EndGroup__Args _args = new InternalUnsafeMethods.EndGroup__Args() {
             };
             InternalUnsafeMethods.EndGroup()(ObjectPtr, _args);
        }

        /// <summary>Starts the grouping for following fields being added to be grouped into</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="groupName">The name of this group</param>
        /// <param name="desc">The Description of this field</param>
        /// <param name="type">The DataType for this field (default, int, float, Point2F, bool, enum, Object, keybind, color)</param>
        /// <param name="defaultValue">The Default value for this field</param>
        /// <param name="userData">An extra data field that can be used for custom data on a per-field basis<br>Usage for default types<br>-enum: a TAB separated list of possible values<br>-object: the T2D object type that are valid choices for the field.  The object types observe inheritance, so if you have a t2dSceneObject field you will be able to choose t2dStaticSrpites, t2dAnimatedSprites, etc.</param>
        /// <returns>Nothing</returns>
        public void BeginGroup(string groupName) {
             InternalUnsafeMethods.BeginGroup__Args _args = new InternalUnsafeMethods.BeginGroup__Args() {
                groupName = groupName,
             };
             InternalUnsafeMethods.BeginGroup()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Component class.
        /// </description>
        /// <returns>The type info object for Component</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The type of behavior.
        /// </description>
        /// </value>
        public string ComponentType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("componentType"));
            set => SetFieldValue("componentType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The type of behavior.
        /// </description>
        /// </value>
        public string NetworkType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("networkType"));
            set => SetFieldValue("networkType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Human friendly name of this behavior
        /// </description>
        /// </value>
        public string FriendlyName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("friendlyName"));
            set => SetFieldValue("friendlyName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The description of this behavior which can be set to a "string" or a fileName
        /// </description>
        /// </value>
        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Is this behavior ghosted to clients?
        /// </description>
        /// </value>
        public bool Networked {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("networked"));
            set => SetFieldValue("networked", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public SimObject Owner {
            get => GenericMarshal.StringTo<SimObject>(GetFieldValue("Owner"));
            set => SetFieldValue("Owner", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Enabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enabled"));
            set => SetFieldValue("enabled", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Asset that spawned this component, used for tracking/housekeeping
        /// </description>
        /// </value>
        public IntPtr OriginatingAsset {
            get => GenericMarshal.StringTo<IntPtr>(GetFieldValue("originatingAsset"));
            set => SetFieldValue("originatingAsset", GenericMarshal.ToString(value));
        }
    }
}