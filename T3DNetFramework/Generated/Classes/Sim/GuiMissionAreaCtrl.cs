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
    public unsafe class GuiMissionAreaCtrl : GuiBitmapCtrl {
        public GuiMissionAreaCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiMissionAreaCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiMissionAreaCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiMissionAreaCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiMissionAreaCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiMissionAreaCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiMissionAreaCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateTerrain__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateTerrain(IntPtr _this, UpdateTerrain__Args args);
            private static _UpdateTerrain _UpdateTerrainFunc;
            internal static _UpdateTerrain UpdateTerrain() {
                if (_UpdateTerrainFunc == null) {
                    _UpdateTerrainFunc =
                        (_UpdateTerrain)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMissionAreaCtrl_updateTerrain"), typeof(_UpdateTerrain));
                }
                
                return _UpdateTerrainFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMissionArea__Args
            {
                internal IntPtr area;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMissionArea(IntPtr _this, SetMissionArea__Args args);
            private static _SetMissionArea _SetMissionAreaFunc;
            internal static _SetMissionArea SetMissionArea() {
                if (_SetMissionAreaFunc == null) {
                    _SetMissionAreaFunc =
                        (_SetMissionArea)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiMissionAreaCtrl_setMissionArea"), typeof(_SetMissionArea));
                }
                
                return _SetMissionAreaFunc;
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
                                "fnGuiMissionAreaCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiMissionAreaCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void UpdateTerrain() {
             InternalUnsafeMethods.UpdateTerrain__Args _args = new InternalUnsafeMethods.UpdateTerrain__Args() {
             };
             InternalUnsafeMethods.UpdateTerrain()(ObjectPtr, _args);
        }

        public void SetMissionArea(MissionArea area) {
             InternalUnsafeMethods.SetMissionArea__Args _args = new InternalUnsafeMethods.SetMissionArea__Args() {
                area = area.ObjectPtr,
             };
             InternalUnsafeMethods.SetMissionArea()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool SquareBitmap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("squareBitmap"));
            set => SetFieldValue("squareBitmap", GenericMarshal.ToString(value));
        }

        public string HandleBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("handleBitmap"));
            set => SetFieldValue("handleBitmap", GenericMarshal.ToString(value));
        }

        public ColorI MissionBoundsColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("missionBoundsColor"));
            set => SetFieldValue("missionBoundsColor", GenericMarshal.ToString(value));
        }

        public ColorI CameraColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("cameraColor"));
            set => SetFieldValue("cameraColor", GenericMarshal.ToString(value));
        }
    }
}