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
    public unsafe class StateMachineComponent : Component {
        public StateMachineComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public StateMachineComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public StateMachineComponent(string pName) 
            : this(pName, false) {
        }
        
        public StateMachineComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public StateMachineComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public StateMachineComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public StateMachineComponent(IntPtr pObj) 
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
                                "fnStateMachineComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnStateMachineComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStateChange__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStateChange(IntPtr _this, OnStateChange__Args args);
            private static _OnStateChange _OnStateChangeFunc;
            internal static _OnStateChange OnStateChange() {
                if (_OnStateChangeFunc == null) {
                    _OnStateChangeFunc =
                        (_OnStateChange)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbStateMachineComponent_onStateChange"), typeof(_OnStateChange));
                }
                
                return _OnStateChangeFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the StateMachineComponent class.
        /// </description>
        /// <returns>The type info object for StateMachineComponent</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <summary>Called when we collide with another object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The ShapeBase object</param>
        /// <param name="collObj">The object we collided with</param>
        /// <param name="vec">Collision impact vector</param>
        /// <param name="len">Length of the impact vector</param>
        public virtual void OnStateChange() {
             InternalUnsafeMethods.OnStateChange__Args _args = new InternalUnsafeMethods.OnStateChange__Args() {
             };
             InternalUnsafeMethods.OnStateChange()(ObjectPtr, _args);
        }


        /// <value>
        /// <description>
        /// The sim time of when we started this state
        /// </description>
        /// </value>
        public string StateMachineFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("stateMachineFile"));
            set => SetFieldValue("stateMachineFile", GenericMarshal.ToString(value));
        }
    }
}