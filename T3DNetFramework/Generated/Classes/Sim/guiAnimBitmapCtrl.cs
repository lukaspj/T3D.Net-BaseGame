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
    public unsafe class guiAnimBitmapCtrl : GuiBitmapCtrl {
        public guiAnimBitmapCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public guiAnimBitmapCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public guiAnimBitmapCtrl(string pName) 
            : this(pName, false) {
        }
        
        public guiAnimBitmapCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public guiAnimBitmapCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public guiAnimBitmapCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public guiAnimBitmapCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnFrame__Args
            {
                internal int frameIndex;
                internal int frame;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnFrame(IntPtr _this, OnFrame__Args args);
            private static _OnFrame _OnFrameFunc;
            internal static _OnFrame OnFrame() {
                if (_OnFrameFunc == null) {
                    _OnFrameFunc =
                        (_OnFrame)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbguiAnimBitmapCtrl_onFrame"), typeof(_OnFrame));
                }
                
                return _OnFrameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnCompleted__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnCompleted(IntPtr _this, OnCompleted__Args args);
            private static _OnCompleted _OnCompletedFunc;
            internal static _OnCompleted OnCompleted() {
                if (_OnCompletedFunc == null) {
                    _OnCompletedFunc =
                        (_OnCompleted)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbguiAnimBitmapCtrl_onCompleted"), typeof(_OnCompleted));
                }
                
                return _OnCompletedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLoop__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLoop(IntPtr _this, OnLoop__Args args);
            private static _OnLoop _OnLoopFunc;
            internal static _OnLoop OnLoop() {
                if (_OnLoopFunc == null) {
                    _OnLoopFunc =
                        (_OnLoop)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbguiAnimBitmapCtrl_onLoop"), typeof(_OnLoop));
                }
                
                return _OnLoopFunc;
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
                                "fnguiAnimBitmapCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnguiAnimBitmapCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void OnFrame(int frameIndex, int frame) {
             InternalUnsafeMethods.OnFrame__Args _args = new InternalUnsafeMethods.OnFrame__Args() {
                frameIndex = frameIndex,
                frame = frame,
             };
             InternalUnsafeMethods.OnFrame()(ObjectPtr, _args);
        }

        public void OnCompleted() {
             InternalUnsafeMethods.OnCompleted__Args _args = new InternalUnsafeMethods.OnCompleted__Args() {
             };
             InternalUnsafeMethods.OnCompleted()(ObjectPtr, _args);
        }

        public void OnLoop() {
             InternalUnsafeMethods.OnLoop__Args _args = new InternalUnsafeMethods.OnLoop__Args() {
             };
             InternalUnsafeMethods.OnLoop()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public Point2I AnimTexTiling {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("animTexTiling"));
            set => SetFieldValue("animTexTiling", GenericMarshal.ToString(value));
        }

        public string AnimTexFrames {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animTexFrames"));
            set => SetFieldValue("animTexFrames", GenericMarshal.ToString(value));
        }

        public bool Loop {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("loop"));
            set => SetFieldValue("loop", GenericMarshal.ToString(value));
        }

        public bool Play {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("play"));
            set => SetFieldValue("play", GenericMarshal.ToString(value));
        }

        public bool Reverse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reverse"));
            set => SetFieldValue("reverse", GenericMarshal.ToString(value));
        }

        public int Fps {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fps"));
            set => SetFieldValue("fps", GenericMarshal.ToString(value));
        }

        public int CurFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("curFrame"));
            set => SetFieldValue("curFrame", GenericMarshal.ToString(value));
        }
    }
}