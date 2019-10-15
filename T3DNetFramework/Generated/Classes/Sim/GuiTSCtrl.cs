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
    public unsafe class GuiTSCtrl : GuiContainer {
        public GuiTSCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTSCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTSCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTSCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTSCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTSCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTSCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetStereoGui__Args
            {
                internal IntPtr canvas;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetStereoGui(IntPtr _this, SetStereoGui__Args args);
            private static _SetStereoGui _SetStereoGuiFunc;
            internal static _SetStereoGui SetStereoGui() {
                if (_SetStereoGuiFunc == null) {
                    _SetStereoGuiFunc =
                        (_SetStereoGui)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTSCtrl_setStereoGui"), typeof(_SetStereoGui));
                }
                
                return _SetStereoGuiFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct CalculateViewDistance__Args
            {
                internal float radius;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _CalculateViewDistance(IntPtr _this, CalculateViewDistance__Args args);
            private static _CalculateViewDistance _CalculateViewDistanceFunc;
            internal static _CalculateViewDistance CalculateViewDistance() {
                if (_CalculateViewDistanceFunc == null) {
                    _CalculateViewDistanceFunc =
                        (_CalculateViewDistance)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTSCtrl_calculateViewDistance"), typeof(_CalculateViewDistance));
                }
                
                return _CalculateViewDistanceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWorldToScreenScale__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetWorldToScreenScale(IntPtr _this, GetWorldToScreenScale__Args args);
            private static _GetWorldToScreenScale _GetWorldToScreenScaleFunc;
            internal static _GetWorldToScreenScale GetWorldToScreenScale() {
                if (_GetWorldToScreenScaleFunc == null) {
                    _GetWorldToScreenScaleFunc =
                        (_GetWorldToScreenScale)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTSCtrl_getWorldToScreenScale"), typeof(_GetWorldToScreenScale));
                }
                
                return _GetWorldToScreenScaleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Project__Args
            {
                internal IntPtr worldPosition;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _Project(IntPtr _this, Project__Args args);
            private static _Project _ProjectFunc;
            internal static _Project Project() {
                if (_ProjectFunc == null) {
                    _ProjectFunc =
                        (_Project)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTSCtrl_project"), typeof(_Project));
                }
                
                return _ProjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Unproject__Args
            {
                internal IntPtr screenPosition;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _Unproject(IntPtr _this, Unproject__Args args);
            private static _Unproject _UnprojectFunc;
            internal static _Unproject Unproject() {
                if (_UnprojectFunc == null) {
                    _UnprojectFunc =
                        (_Unproject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTSCtrl_unproject"), typeof(_Unproject));
                }
                
                return _UnprojectFunc;
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
                                "fnGuiTSCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiTSCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void SetStereoGui(GuiOffscreenCanvas canvas) {
             InternalUnsafeMethods.SetStereoGui__Args _args = new InternalUnsafeMethods.SetStereoGui__Args() {
                canvas = canvas.ObjectPtr,
             };
             InternalUnsafeMethods.SetStereoGui()(ObjectPtr, _args);
        }

        public float CalculateViewDistance(float radius) {
             InternalUnsafeMethods.CalculateViewDistance__Args _args = new InternalUnsafeMethods.CalculateViewDistance__Args() {
                radius = radius,
             };
             float _engineResult = InternalUnsafeMethods.CalculateViewDistance()(ObjectPtr, _args);
             return _engineResult;
        }

        public Point2F GetWorldToScreenScale() {
             InternalUnsafeMethods.GetWorldToScreenScale__Args _args = new InternalUnsafeMethods.GetWorldToScreenScale__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetWorldToScreenScale()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        public Point3F Project(Point3F worldPosition) {
worldPosition.Alloc();             InternalUnsafeMethods.Project__Args _args = new InternalUnsafeMethods.Project__Args() {
                worldPosition = worldPosition.internalStructPtr,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.Project()(ObjectPtr, _args);
worldPosition.Free();             return new Point3F(_engineResult);
        }

        public Point3F Unproject(Point3F screenPosition) {
screenPosition.Alloc();             InternalUnsafeMethods.Unproject__Args _args = new InternalUnsafeMethods.Unproject__Args() {
                screenPosition = screenPosition.internalStructPtr,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.Unproject()(ObjectPtr, _args);
screenPosition.Free();             return new Point3F(_engineResult);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float CameraZRot {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraZRot"));
            set => SetFieldValue("cameraZRot", GenericMarshal.ToString(value));
        }

        public float ForceFOV {
            get => GenericMarshal.StringTo<float>(GetFieldValue("forceFOV"));
            set => SetFieldValue("forceFOV", GenericMarshal.ToString(value));
        }

        public float ReflectPriority {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectPriority"));
            set => SetFieldValue("reflectPriority", GenericMarshal.ToString(value));
        }

        public GuiTSRenderStyles RenderStyle {
            get => GenericMarshal.StringTo<GuiTSRenderStyles>(GetFieldValue("renderStyle"));
            set => SetFieldValue("renderStyle", GenericMarshal.ToString(value));
        }
    }
}