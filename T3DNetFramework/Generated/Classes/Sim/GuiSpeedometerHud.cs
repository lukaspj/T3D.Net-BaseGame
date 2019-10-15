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
    public unsafe class GuiSpeedometerHud : GuiBitmapCtrl {
        public GuiSpeedometerHud(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiSpeedometerHud(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiSpeedometerHud(string pName) 
            : this(pName, false) {
        }
        
        public GuiSpeedometerHud(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiSpeedometerHud(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiSpeedometerHud(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiSpeedometerHud(IntPtr pObj) 
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
                                "fnGuiSpeedometerHud_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiSpeedometerHud_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float MaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSpeed"));
            set => SetFieldValue("maxSpeed", GenericMarshal.ToString(value));
        }

        public float MinAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minAngle"));
            set => SetFieldValue("minAngle", GenericMarshal.ToString(value));
        }

        public float MaxAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxAngle"));
            set => SetFieldValue("maxAngle", GenericMarshal.ToString(value));
        }

        public Point2F Center {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("center"));
            set => SetFieldValue("center", GenericMarshal.ToString(value));
        }

        public float Length {
            get => GenericMarshal.StringTo<float>(GetFieldValue("length"));
            set => SetFieldValue("length", GenericMarshal.ToString(value));
        }

        public float Width {
            get => GenericMarshal.StringTo<float>(GetFieldValue("width"));
            set => SetFieldValue("width", GenericMarshal.ToString(value));
        }

        public float Tail {
            get => GenericMarshal.StringTo<float>(GetFieldValue("tail"));
            set => SetFieldValue("tail", GenericMarshal.ToString(value));
        }
    }
}