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
    /// <summary>A datablock that specifies an Animation Lock effect.</summary>
    /// <description>
    /// Animation Lock is used to temporarily lock out user-controlled Player actions, usually while an Animation Clip is concurrently playing. Animation Clips can already do this, but must lock out user actions for the entire clip length. Sometimes you only want to block user actions for a short section of a longer playing animation, such as the part where the Player is thrown into the air from an impact. With Animation Lock, you can set a specific timespan for when user actions are blocked, independent of any Animation Clip timing.
    /// 
    /// The target of an Animation Lock is the constraint source object specified by the posConstraint field of the enclosing effect wrapper. The target must be a Player, a subclass of Player, or an afxModel.
    /// 
    /// The timing of the Animation Lock is determined by the timing fields of the enclosing effect wrapper.
    /// 
    /// Locking behavior timing is set by fields of the enclosing effect wrapper, so afxAnimLockData does not require any fields. However, TorqueScript syntax disallows the declaration of an empty datablock. Therefore, it is recommended that you set a dynamic field named 'priority' to zero in the body of the datablock as a workaround to this limitation.
    /// </description>
    public unsafe class afxAnimLockData : GameBaseData {
        public afxAnimLockData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxAnimLockData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxAnimLockData(string pName) 
            : this(pName, false) {
        }
        
        public afxAnimLockData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxAnimLockData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxAnimLockData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxAnimLockData(IntPtr pObj) 
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
                                "fnafxAnimLockData_staticGetType"), typeof(_StaticGetType));
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
                                "fnafxAnimLockData_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the afxAnimLockData class.
        /// </description>
        /// <returns>The type info object for afxAnimLockData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}