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
    public unsafe class PathCamera : ShapeBase {
        public PathCamera(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PathCamera(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PathCamera(string pName) 
            : this(pName, false) {
        }
        
        public PathCamera(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PathCamera(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PathCamera(SimObject pObj) 
            : base(pObj) {
        }
        
        public PathCamera(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PopFront__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopFront(IntPtr _this, PopFront__Args args);
            private static _PopFront _PopFrontFunc;
            internal static _PopFront PopFront() {
                if (_PopFrontFunc == null) {
                    _PopFrontFunc =
                        (_PopFront)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_popFront"), typeof(_PopFront));
                }
                
                return _PopFrontFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PushFront__Args
            {
                internal IntPtr transform;
                internal float speed;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushFront(IntPtr _this, PushFront__Args args);
            private static _PushFront _PushFrontFunc;
            internal static _PushFront PushFront() {
                if (_PushFrontFunc == null) {
                    _PushFrontFunc =
                        (_PushFront)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_pushFront"), typeof(_PushFront));
                }
                
                return _PushFrontFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PushBack__Args
            {
                internal IntPtr transform;
                internal float speed;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushBack(IntPtr _this, PushBack__Args args);
            private static _PushBack _PushBackFunc;
            internal static _PushBack PushBack() {
                if (_PushBackFunc == null) {
                    _PushBackFunc =
                        (_PushBack)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_pushBack"), typeof(_PushBack));
                }
                
                return _PushBackFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
                internal float speed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
                if (_ResetFunc == null) {
                    _ResetFunc =
                        (_Reset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_reset"), typeof(_Reset));
                }
                
                return _ResetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetState__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newState;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetState(IntPtr _this, SetState__Args args);
            private static _SetState _SetStateFunc;
            internal static _SetState SetState() {
                if (_SetStateFunc == null) {
                    _SetStateFunc =
                        (_SetState)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_setState"), typeof(_SetState));
                }
                
                return _SetStateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTarget__Args
            {
                internal float position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTarget(IntPtr _this, SetTarget__Args args);
            private static _SetTarget _SetTargetFunc;
            internal static _SetTarget SetTarget() {
                if (_SetTargetFunc == null) {
                    _SetTargetFunc =
                        (_SetTarget)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_setTarget"), typeof(_SetTarget));
                }
                
                return _SetTargetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetPosition__Args
            {
                internal float position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetPosition(IntPtr _this, SetPosition__Args args);
            private static _SetPosition _SetPositionFunc;
            internal static _SetPosition SetPosition() {
                if (_SetPositionFunc == null) {
                    _SetPositionFunc =
                        (_SetPosition)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPathCamera_setPosition"), typeof(_SetPosition));
                }
                
                return _SetPositionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnNode__Args
            {
                internal int node;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnNode(IntPtr _this, OnNode__Args args);
            private static _OnNode _OnNodeFunc;
            internal static _OnNode OnNode() {
                if (_OnNodeFunc == null) {
                    _OnNodeFunc =
                        (_OnNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPathCamera_onNode"), typeof(_OnNode));
                }
                
                return _OnNodeFunc;
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
                                "fnPathCamera_staticGetType"), typeof(_StaticGetType));
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
                                "fnPathCamera_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void PopFront() {
             InternalUnsafeMethods.PopFront__Args _args = new InternalUnsafeMethods.PopFront__Args() {
             };
             InternalUnsafeMethods.PopFront()(ObjectPtr, _args);
        }

        public void PushFront(TransformF transform, float speed = 1f, string type = "Normal", string path = "Linear") {
transform.Alloc();             InternalUnsafeMethods.PushFront__Args _args = new InternalUnsafeMethods.PushFront__Args() {
                transform = transform.internalStructPtr,
                speed = speed,
                type = type,
                path = path,
             };
             InternalUnsafeMethods.PushFront()(ObjectPtr, _args);
transform.Free();        }

        public void PushBack(TransformF transform, float speed = 1f, string type = "Normal", string path = "Linear") {
transform.Alloc();             InternalUnsafeMethods.PushBack__Args _args = new InternalUnsafeMethods.PushBack__Args() {
                transform = transform.internalStructPtr,
                speed = speed,
                type = type,
                path = path,
             };
             InternalUnsafeMethods.PushBack()(ObjectPtr, _args);
transform.Free();        }

        public void Reset(float speed = 1f) {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                speed = speed,
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        public void SetState(string newState = "forward") {
             InternalUnsafeMethods.SetState__Args _args = new InternalUnsafeMethods.SetState__Args() {
                newState = newState,
             };
             InternalUnsafeMethods.SetState()(ObjectPtr, _args);
        }

        public void SetTarget(float position = 1f) {
             InternalUnsafeMethods.SetTarget__Args _args = new InternalUnsafeMethods.SetTarget__Args() {
                position = position,
             };
             InternalUnsafeMethods.SetTarget()(ObjectPtr, _args);
        }

        public void SetPosition(float position = 0f) {
             InternalUnsafeMethods.SetPosition__Args _args = new InternalUnsafeMethods.SetPosition__Args() {
                position = position,
             };
             InternalUnsafeMethods.SetPosition()(ObjectPtr, _args);
        }

        public virtual void OnNode(int node) {
             InternalUnsafeMethods.OnNode__Args _args = new InternalUnsafeMethods.OnNode__Args() {
                node = node,
             };
             InternalUnsafeMethods.OnNode()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}