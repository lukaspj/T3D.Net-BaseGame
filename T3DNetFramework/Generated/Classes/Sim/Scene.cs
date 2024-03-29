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
    public unsafe class Scene : NetObject {
        public Scene(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Scene(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Scene(string pName) 
            : this(pName, false) {
        }
        
        public Scene(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Scene(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Scene(SimObject pObj) 
            : base(pObj) {
        }
        
        public Scene(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectsByClass__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string className;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetObjectsByClass(IntPtr _this, GetObjectsByClass__Args args);
            private static _GetObjectsByClass _GetObjectsByClassFunc;
            internal static _GetObjectsByClass GetObjectsByClass() {
                if (_GetObjectsByClassFunc == null) {
                    _GetObjectsByClassFunc =
                        (_GetObjectsByClass)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScene_getObjectsByClass"), typeof(_GetObjectsByClass));
                }
                
                return _GetObjectsByClassFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveDynamicObject__Args
            {
                internal IntPtr sceneObj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveDynamicObject(IntPtr _this, RemoveDynamicObject__Args args);
            private static _RemoveDynamicObject _RemoveDynamicObjectFunc;
            internal static _RemoveDynamicObject RemoveDynamicObject() {
                if (_RemoveDynamicObjectFunc == null) {
                    _RemoveDynamicObjectFunc =
                        (_RemoveDynamicObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScene_removeDynamicObject"), typeof(_RemoveDynamicObject));
                }
                
                return _RemoveDynamicObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddDynamicObject__Args
            {
                internal IntPtr sceneObj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddDynamicObject(IntPtr _this, AddDynamicObject__Args args);
            private static _AddDynamicObject _AddDynamicObjectFunc;
            internal static _AddDynamicObject AddDynamicObject() {
                if (_AddDynamicObjectFunc == null) {
                    _AddDynamicObjectFunc =
                        (_AddDynamicObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScene_addDynamicObject"), typeof(_AddDynamicObject));
                }
                
                return _AddDynamicObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRootScene__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRootScene(IntPtr _this, GetRootScene__Args args);
            private static _GetRootScene _GetRootSceneFunc;
            internal static _GetRootScene GetRootScene() {
                if (_GetRootSceneFunc == null) {
                    _GetRootSceneFunc =
                        (_GetRootScene)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnScene_getRootScene"), typeof(_GetRootScene));
                }
                
                return _GetRootSceneFunc;
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
                                "fnScene_staticGetType"), typeof(_StaticGetType));
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
                                "fnScene_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public string GetObjectsByClass(string className = "") {
             InternalUnsafeMethods.GetObjectsByClass__Args _args = new InternalUnsafeMethods.GetObjectsByClass__Args() {
                className = className,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetObjectsByClass()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public void RemoveDynamicObject(SceneObject sceneObj = null) {
             InternalUnsafeMethods.RemoveDynamicObject__Args _args = new InternalUnsafeMethods.RemoveDynamicObject__Args() {
                sceneObj = sceneObj.ObjectPtr,
             };
             InternalUnsafeMethods.RemoveDynamicObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public void AddDynamicObject(SceneObject sceneObj = null) {
             InternalUnsafeMethods.AddDynamicObject__Args _args = new InternalUnsafeMethods.AddDynamicObject__Args() {
                sceneObj = sceneObj.ObjectPtr,
             };
             InternalUnsafeMethods.AddDynamicObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public int GetRootScene() {
             InternalUnsafeMethods.GetRootScene__Args _args = new InternalUnsafeMethods.GetRootScene__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRootScene()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the Scene class.
        /// </description>
        /// <returns>The type info object for Scene</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool IsSubscene {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isSubscene"));
            set => SetFieldValue("isSubscene", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IsEditing {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isEditing"));
            set => SetFieldValue("isEditing", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IsDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isDirty"));
            set => SetFieldValue("isDirty", GenericMarshal.ToString(value));
        }
    }
}