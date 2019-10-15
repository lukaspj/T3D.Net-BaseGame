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
    public unsafe class AnimationComponent : Component {
        public AnimationComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AnimationComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AnimationComponent(string pName) 
            : this(pName, false) {
        }
        
        public AnimationComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AnimationComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AnimationComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public AnimationComponent(IntPtr pObj) 
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
                                "fnAnimationComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnAnimationComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAnimationTrigger__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string animName;
                internal int triggerID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAnimationTrigger(IntPtr _this, OnAnimationTrigger__Args args);
            private static _OnAnimationTrigger _OnAnimationTriggerFunc;
            internal static _OnAnimationTrigger OnAnimationTrigger() {
                if (_OnAnimationTriggerFunc == null) {
                    _OnAnimationTriggerFunc =
                        (_OnAnimationTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbAnimationComponent_onAnimationTrigger"), typeof(_OnAnimationTrigger));
                }
                
                return _OnAnimationTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAnimationEnd__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string animName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAnimationEnd(IntPtr _this, OnAnimationEnd__Args args);
            private static _OnAnimationEnd _OnAnimationEndFunc;
            internal static _OnAnimationEnd OnAnimationEnd() {
                if (_OnAnimationEndFunc == null) {
                    _OnAnimationEndFunc =
                        (_OnAnimationEnd)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbAnimationComponent_onAnimationEnd"), typeof(_OnAnimationEnd));
                }
                
                return _OnAnimationEndFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAnimationStart__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string animName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAnimationStart(IntPtr _this, OnAnimationStart__Args args);
            private static _OnAnimationStart _OnAnimationStartFunc;
            internal static _OnAnimationStart OnAnimationStart() {
                if (_OnAnimationStartFunc == null) {
                    _OnAnimationStartFunc =
                        (_OnAnimationStart)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbAnimationComponent_onAnimationStart"), typeof(_OnAnimationStart));
                }
                
                return _OnAnimationStartFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAnimationName(IntPtr _this, GetAnimationName__Args args);
            private static _GetAnimationName _GetAnimationNameFunc;
            internal static _GetAnimationName GetAnimationName() {
                if (_GetAnimationNameFunc == null) {
                    _GetAnimationNameFunc =
                        (_GetAnimationName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_getAnimationName"), typeof(_GetAnimationName));
                }
                
                return _GetAnimationNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAnimationIndex(IntPtr _this, GetAnimationIndex__Args args);
            private static _GetAnimationIndex _GetAnimationIndexFunc;
            internal static _GetAnimationIndex GetAnimationIndex() {
                if (_GetAnimationIndexFunc == null) {
                    _GetAnimationIndexFunc =
                        (_GetAnimationIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_getAnimationIndex"), typeof(_GetAnimationIndex));
                }
                
                return _GetAnimationIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAnimationCount(IntPtr _this, GetAnimationCount__Args args);
            private static _GetAnimationCount _GetAnimationCountFunc;
            internal static _GetAnimationCount GetAnimationCount() {
                if (_GetAnimationCountFunc == null) {
                    _GetAnimationCountFunc =
                        (_GetAnimationCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_getAnimationCount"), typeof(_GetAnimationCount));
                }
                
                return _GetAnimationCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PauseThread__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PauseThread(IntPtr _this, PauseThread__Args args);
            private static _PauseThread _PauseThreadFunc;
            internal static _PauseThread PauseThread() {
                if (_PauseThreadFunc == null) {
                    _PauseThreadFunc =
                        (_PauseThread)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_pauseThread"), typeof(_PauseThread));
                }
                
                return _PauseThreadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DestroyThread__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _DestroyThread(IntPtr _this, DestroyThread__Args args);
            private static _DestroyThread _DestroyThreadFunc;
            internal static _DestroyThread DestroyThread() {
                if (_DestroyThreadFunc == null) {
                    _DestroyThreadFunc =
                        (_DestroyThread)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_destroyThread"), typeof(_DestroyThread));
                }
                
                return _DestroyThreadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StopThread__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _StopThread(IntPtr _this, StopThread__Args args);
            private static _StopThread _StopThreadFunc;
            internal static _StopThread StopThread() {
                if (_StopThreadFunc == null) {
                    _StopThreadFunc =
                        (_StopThread)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_stopThread"), typeof(_StopThread));
                }
                
                return _StopThreadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetThreadAnimation__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetThreadAnimation(IntPtr _this, GetThreadAnimation__Args args);
            private static _GetThreadAnimation _GetThreadAnimationFunc;
            internal static _GetThreadAnimation GetThreadAnimation() {
                if (_GetThreadAnimationFunc == null) {
                    _GetThreadAnimationFunc =
                        (_GetThreadAnimation)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_getThreadAnimation"), typeof(_GetThreadAnimation));
                }
                
                return _GetThreadAnimationFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetThreadAnimation__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetThreadAnimation(IntPtr _this, SetThreadAnimation__Args args);
            private static _SetThreadAnimation _SetThreadAnimationFunc;
            internal static _SetThreadAnimation SetThreadAnimation() {
                if (_SetThreadAnimationFunc == null) {
                    _SetThreadAnimationFunc =
                        (_SetThreadAnimation)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_setThreadAnimation"), typeof(_SetThreadAnimation));
                }
                
                return _SetThreadAnimationFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetThreadPosition__Args
            {
                internal int slot;
                internal float pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetThreadPosition(IntPtr _this, SetThreadPosition__Args args);
            private static _SetThreadPosition _SetThreadPositionFunc;
            internal static _SetThreadPosition SetThreadPosition() {
                if (_SetThreadPositionFunc == null) {
                    _SetThreadPositionFunc =
                        (_SetThreadPosition)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_setThreadPosition"), typeof(_SetThreadPosition));
                }
                
                return _SetThreadPositionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetThreadTimeScale__Args
            {
                internal int slot;
                internal float scale;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetThreadTimeScale(IntPtr _this, SetThreadTimeScale__Args args);
            private static _SetThreadTimeScale _SetThreadTimeScaleFunc;
            internal static _SetThreadTimeScale SetThreadTimeScale() {
                if (_SetThreadTimeScaleFunc == null) {
                    _SetThreadTimeScaleFunc =
                        (_SetThreadTimeScale)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_setThreadTimeScale"), typeof(_SetThreadTimeScale));
                }
                
                return _SetThreadTimeScaleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetThreadDir__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.I1)]
                internal bool fwd;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetThreadDir(IntPtr _this, SetThreadDir__Args args);
            private static _SetThreadDir _SetThreadDirFunc;
            internal static _SetThreadDir SetThreadDir() {
                if (_SetThreadDirFunc == null) {
                    _SetThreadDirFunc =
                        (_SetThreadDir)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_setThreadDir"), typeof(_SetThreadDir));
                }
                
                return _SetThreadDirFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PlayThread__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.I1)]
                internal bool transition;
                internal float transitionTime;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PlayThread(IntPtr _this, PlayThread__Args args);
            private static _PlayThread _PlayThreadFunc;
            internal static _PlayThread PlayThread() {
                if (_PlayThreadFunc == null) {
                    _PlayThreadFunc =
                        (_PlayThread)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnAnimationComponent_playThread"), typeof(_PlayThread));
                }
                
                return _PlayThreadFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public virtual void OnAnimationTrigger(Component obj, string animName, int triggerID) {
             InternalUnsafeMethods.OnAnimationTrigger__Args _args = new InternalUnsafeMethods.OnAnimationTrigger__Args() {
                obj = obj.ObjectPtr,
                animName = animName,
                triggerID = triggerID,
             };
             InternalUnsafeMethods.OnAnimationTrigger()(ObjectPtr, _args);
        }

        public virtual void OnAnimationEnd(Component obj, string animName) {
             InternalUnsafeMethods.OnAnimationEnd__Args _args = new InternalUnsafeMethods.OnAnimationEnd__Args() {
                obj = obj.ObjectPtr,
                animName = animName,
             };
             InternalUnsafeMethods.OnAnimationEnd()(ObjectPtr, _args);
        }

        public virtual void OnAnimationStart(Component obj, string animName) {
             InternalUnsafeMethods.OnAnimationStart__Args _args = new InternalUnsafeMethods.OnAnimationStart__Args() {
                obj = obj.ObjectPtr,
                animName = animName,
             };
             InternalUnsafeMethods.OnAnimationStart()(ObjectPtr, _args);
        }

        public string GetAnimationName(int index) {
             InternalUnsafeMethods.GetAnimationName__Args _args = new InternalUnsafeMethods.GetAnimationName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAnimationName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetAnimationIndex(string name) {
             InternalUnsafeMethods.GetAnimationIndex__Args _args = new InternalUnsafeMethods.GetAnimationIndex__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetAnimationIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetAnimationCount() {
             InternalUnsafeMethods.GetAnimationCount__Args _args = new InternalUnsafeMethods.GetAnimationCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAnimationCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool PauseThread(int slot) {
             InternalUnsafeMethods.PauseThread__Args _args = new InternalUnsafeMethods.PauseThread__Args() {
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.PauseThread()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool DestroyThread(int slot) {
             InternalUnsafeMethods.DestroyThread__Args _args = new InternalUnsafeMethods.DestroyThread__Args() {
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.DestroyThread()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool StopThread(int slot) {
             InternalUnsafeMethods.StopThread__Args _args = new InternalUnsafeMethods.StopThread__Args() {
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.StopThread()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetThreadAnimation(int slot) {
             InternalUnsafeMethods.GetThreadAnimation__Args _args = new InternalUnsafeMethods.GetThreadAnimation__Args() {
                slot = slot,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetThreadAnimation()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetThreadAnimation(int slot, string name = "") {
             InternalUnsafeMethods.SetThreadAnimation__Args _args = new InternalUnsafeMethods.SetThreadAnimation__Args() {
                slot = slot,
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.SetThreadAnimation()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetThreadPosition(int slot, float pos) {
             InternalUnsafeMethods.SetThreadPosition__Args _args = new InternalUnsafeMethods.SetThreadPosition__Args() {
                slot = slot,
                pos = pos,
             };
             bool _engineResult = InternalUnsafeMethods.SetThreadPosition()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetThreadTimeScale(int slot, float scale) {
             InternalUnsafeMethods.SetThreadTimeScale__Args _args = new InternalUnsafeMethods.SetThreadTimeScale__Args() {
                slot = slot,
                scale = scale,
             };
             bool _engineResult = InternalUnsafeMethods.SetThreadTimeScale()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetThreadDir(int slot, bool fwd) {
             InternalUnsafeMethods.SetThreadDir__Args _args = new InternalUnsafeMethods.SetThreadDir__Args() {
                slot = slot,
                fwd = fwd,
             };
             bool _engineResult = InternalUnsafeMethods.SetThreadDir()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool PlayThread(int slot = -1, string name = "", bool transition = true, float transitionTime = 0.5f) {
             InternalUnsafeMethods.PlayThread__Args _args = new InternalUnsafeMethods.PlayThread__Args() {
                slot = slot,
                name = name,
                transition = transition,
                transitionTime = transitionTime,
             };
             bool _engineResult = InternalUnsafeMethods.PlayThread()(ObjectPtr, _args);
             return _engineResult;
        }
    }
}