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
    /// <summary>A spline along which various objects can move along. The spline object acts like a container for Marker objects, which make</summary>
    /// <description>
    /// up the joints, or knots, along the path. Paths can be assigned a speed, can be looping or non-looping. Each of a path's markers can be
    /// one of three primary movement types: "normal", "Position Only", or "Kink".
    /// </description>
    /// <code>
    /// new path()
    /// 	{
    ///      isLooping = "1";
    /// 
    ///      new Marker()
    /// 		{
    /// 			seqNum = "0";
    /// 			type = "Normal";
    /// 			msToNext = "1000";
    /// 			smoothingType = "Spline";
    /// 			position = "-0.054708 -35.0612 234.802";
    /// 			rotation = "1 0 0 0";
    ///       };
    /// 
    /// 	};
    /// </code>
    /// <see cref="Marker" />
    /// <see cref="NetConnection::transmitPaths()" />
    /// <see cref="NetConnection::clearPaths()" />
    /// <see cref="Path" />
    public unsafe class Path : SimGroup {
        public Path(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Path(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Path(string pName) 
            : this(pName, false) {
        }
        
        public Path(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Path(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Path(SimObject pObj) 
            : base(pObj) {
        }
        
        public Path(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPathId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetPathId(IntPtr _this, GetPathId__Args args);
            private static _GetPathId _GetPathIdFunc;
            internal static _GetPathId GetPathId() {
                if (_GetPathIdFunc == null) {
                    _GetPathIdFunc =
                        (_GetPathId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPath_getPathId"), typeof(_GetPathId));
                }
                
                return _GetPathIdFunc;
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
                                "fnPath_staticGetType"), typeof(_StaticGetType));
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
                                "fnPath_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <summary>Returns the PathID (not the object ID) of this path.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>PathID (not the object ID) of this path.</returns>
        /// <code>
        /// // Acquire the PathID of this path object.
        /// %pathID = %thisPath.getPathId();
        /// </code>
        public int GetPathId() {
             InternalUnsafeMethods.GetPathId__Args _args = new InternalUnsafeMethods.GetPathId__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetPathId()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the Path class.
        /// </description>
        /// <returns>The type info object for Path</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If this is true, the loop is closed, otherwise it is open.
        /// </description>
        /// </value>
        public bool IsLooping {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isLooping"));
            set => SetFieldValue("isLooping", GenericMarshal.ToString(value));
        }
    }
}