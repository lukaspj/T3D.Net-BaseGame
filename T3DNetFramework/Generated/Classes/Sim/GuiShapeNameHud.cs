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
    public unsafe class GuiShapeNameHud : GuiControl {
        public GuiShapeNameHud(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiShapeNameHud(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiShapeNameHud(string pName) 
            : this(pName, false) {
        }
        
        public GuiShapeNameHud(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiShapeNameHud(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiShapeNameHud(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiShapeNameHud(IntPtr pObj) 
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
                                "fnGuiShapeNameHud_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiShapeNameHud_create"), typeof(_Create));
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

        public LinearColorF FillColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("fillColor"));
            set => SetFieldValue("fillColor", GenericMarshal.ToString(value));
        }

        public LinearColorF FrameColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("frameColor"));
            set => SetFieldValue("frameColor", GenericMarshal.ToString(value));
        }

        public LinearColorF TextColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("textColor"));
            set => SetFieldValue("textColor", GenericMarshal.ToString(value));
        }

        public LinearColorF LabelFillColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("labelFillColor"));
            set => SetFieldValue("labelFillColor", GenericMarshal.ToString(value));
        }

        public LinearColorF LabelFrameColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("labelFrameColor"));
            set => SetFieldValue("labelFrameColor", GenericMarshal.ToString(value));
        }

        public bool ShowFill {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showFill"));
            set => SetFieldValue("showFill", GenericMarshal.ToString(value));
        }

        public bool ShowFrame {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showFrame"));
            set => SetFieldValue("showFrame", GenericMarshal.ToString(value));
        }

        public bool ShowLabelFill {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showLabelFill"));
            set => SetFieldValue("showLabelFill", GenericMarshal.ToString(value));
        }

        public bool ShowLabelFrame {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showLabelFrame"));
            set => SetFieldValue("showLabelFrame", GenericMarshal.ToString(value));
        }

        public Point2I LabelPadding {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("labelPadding"));
            set => SetFieldValue("labelPadding", GenericMarshal.ToString(value));
        }

        public float VerticalOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("verticalOffset"));
            set => SetFieldValue("verticalOffset", GenericMarshal.ToString(value));
        }

        public float DistanceFade {
            get => GenericMarshal.StringTo<float>(GetFieldValue("distanceFade"));
            set => SetFieldValue("distanceFade", GenericMarshal.ToString(value));
        }
    }
}