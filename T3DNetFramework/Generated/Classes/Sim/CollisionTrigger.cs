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
    /// <summary>A CollisionTrigger is a volume of space that initiates script callbacks when objects pass through the CollisionTrigger.</summary>
    /// <description>
    /// CollisionTriggerData provides the callbacks for the CollisionTrigger when an object enters, stays inside or leaves the CollisionTrigger's volume.
    /// </description>
    /// <see cref="CollisionTriggerData" />
    public unsafe class CollisionTrigger : GameBase {
        public CollisionTrigger(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CollisionTrigger(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CollisionTrigger(string pName) 
            : this(pName, false) {
        }
        
        public CollisionTrigger(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CollisionTrigger(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CollisionTrigger(SimObject pObj) 
            : base(pObj) {
        }
        
        public CollisionTrigger(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetObject(IntPtr _this, GetObject__Args args);
            private static _GetObject _GetObjectFunc;
            internal static _GetObject GetObject() {
                if (_GetObjectFunc == null) {
                    _GetObjectFunc =
                        (_GetObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionTrigger_getObject"), typeof(_GetObject));
                }
                
                return _GetObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumObjects__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumObjects(IntPtr _this, GetNumObjects__Args args);
            private static _GetNumObjects _GetNumObjectsFunc;
            internal static _GetNumObjects GetNumObjects() {
                if (_GetNumObjectsFunc == null) {
                    _GetNumObjectsFunc =
                        (_GetNumObjects)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionTrigger_getNumObjects"), typeof(_GetNumObjects));
                }
                
                return _GetNumObjectsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemove__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
            private static _OnRemove _OnRemoveFunc;
            internal static _OnRemove OnRemove() {
                if (_OnRemoveFunc == null) {
                    _OnRemoveFunc =
                        (_OnRemove)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbCollisionTrigger_onRemove"), typeof(_OnRemove));
                }
                
                return _OnRemoveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
            private static _OnAdd _OnAddFunc;
            internal static _OnAdd OnAdd() {
                if (_OnAddFunc == null) {
                    _OnAddFunc =
                        (_OnAdd)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbCollisionTrigger_onAdd"), typeof(_OnAdd));
                }
                
                return _OnAddFunc;
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
                                "fnCollisionTrigger_staticGetType"), typeof(_StaticGetType));
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
                                "fnCollisionTrigger_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <summary>Retrieve the requested object that is within the CollisionTrigger's bounds.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">Index of the object to get (range is 0 to getNumObjects()-1)</param>
        /// <returns>The SimObjectID of the object, or -1 if the requested index is invalid.</returns>
        /// <see cref="getNumObjects()" />
        public int GetObject(int index) {
             InternalUnsafeMethods.GetObject__Args _args = new InternalUnsafeMethods.GetObject__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Get the number of objects that are within the CollisionTrigger's bounds.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="getObject()" />
        public int GetNumObjects() {
             InternalUnsafeMethods.GetNumObjects__Args _args = new InternalUnsafeMethods.GetNumObjects__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumObjects()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Called just before the CollisionTrigger is deleted.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objectId">the object id of the CollisionTrigger being deleted</param>
        public virtual void OnRemove(uint objectId) {
             InternalUnsafeMethods.OnRemove__Args _args = new InternalUnsafeMethods.OnRemove__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnRemove()(ObjectPtr, _args);
        }

        /// <summary>Called when the CollisionTrigger is being created.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objectId">the object id of the CollisionTrigger being created</param>
        public virtual void OnAdd(uint objectId) {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the CollisionTrigger class.
        /// </description>
        /// <returns>The type info object for CollisionTrigger</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Defines a non-rectangular area for the CollisionTrigger.</summary>
        /// <description>
        /// Rather than the standard rectangular bounds, this optional parameter defines a quadrilateral CollisionTrigger area.  The quadrilateral is defined as a corner point followed by three vectors representing the edges extending from the corner.
        /// </description>
        /// </value>
        public FloatVector Polyhedron {
            get => GenericMarshal.StringTo<FloatVector>(GetFieldValue("polyhedron"));
            set => SetFieldValue("polyhedron", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute when an object enters this CollisionTrigger. Object id stored in %%obj. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string EnterCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("enterCommand"));
            set => SetFieldValue("enterCommand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute when an object leaves this CollisionTrigger. Object id stored in %%obj. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string LeaveCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("leaveCommand"));
            set => SetFieldValue("leaveCommand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute while an object is inside this CollisionTrigger. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string TickCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("tickCommand"));
            set => SetFieldValue("tickCommand", GenericMarshal.ToString(value));
        }
    }
}