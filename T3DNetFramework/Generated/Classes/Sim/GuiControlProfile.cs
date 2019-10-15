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
    public unsafe class GuiControlProfile : SimObject {
        public GuiControlProfile(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiControlProfile(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiControlProfile(string pName) 
            : this(pName, false) {
        }
        
        public GuiControlProfile(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiControlProfile(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiControlProfile(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiControlProfile(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetStringWidth__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string _string;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetStringWidth(IntPtr _this, GetStringWidth__Args args);
            private static _GetStringWidth _GetStringWidthFunc;
            internal static _GetStringWidth GetStringWidth() {
                if (_GetStringWidthFunc == null) {
                    _GetStringWidthFunc =
                        (_GetStringWidth)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiControlProfile_getStringWidth"), typeof(_GetStringWidth));
                }
                
                return _GetStringWidthFunc;
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
                                "fnGuiControlProfile_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiControlProfile_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public int GetStringWidth(string _string) {
             InternalUnsafeMethods.GetStringWidth__Args _args = new InternalUnsafeMethods.GetStringWidth__Args() {
                _string = _string,
             };
             int _engineResult = InternalUnsafeMethods.GetStringWidth()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool Tab {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tab"));
            set => SetFieldValue("tab", GenericMarshal.ToString(value));
        }

        public bool CanKeyFocus {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canKeyFocus"));
            set => SetFieldValue("canKeyFocus", GenericMarshal.ToString(value));
        }

        public bool MouseOverSelected {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("mouseOverSelected"));
            set => SetFieldValue("mouseOverSelected", GenericMarshal.ToString(value));
        }

        public bool Modal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("modal"));
            set => SetFieldValue("modal", GenericMarshal.ToString(value));
        }

        public bool Opaque {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("opaque"));
            set => SetFieldValue("opaque", GenericMarshal.ToString(value));
        }

        public ColorI FillColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColor"));
            set => SetFieldValue("fillColor", GenericMarshal.ToString(value));
        }

        public ColorI FillColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorHL"));
            set => SetFieldValue("fillColorHL", GenericMarshal.ToString(value));
        }

        public ColorI FillColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorNA"));
            set => SetFieldValue("fillColorNA", GenericMarshal.ToString(value));
        }

        public ColorI FillColorERR {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorERR"));
            set => SetFieldValue("fillColorERR", GenericMarshal.ToString(value));
        }

        public ColorI FillColorSEL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorSEL"));
            set => SetFieldValue("fillColorSEL", GenericMarshal.ToString(value));
        }

        public int Border {
            get => GenericMarshal.StringTo<int>(GetFieldValue("border"));
            set => SetFieldValue("border", GenericMarshal.ToString(value));
        }

        public int BorderThickness {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderThickness"));
            set => SetFieldValue("borderThickness", GenericMarshal.ToString(value));
        }

        public ColorI BorderColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }

        public ColorI BorderColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorHL"));
            set => SetFieldValue("borderColorHL", GenericMarshal.ToString(value));
        }

        public ColorI BorderColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorNA"));
            set => SetFieldValue("borderColorNA", GenericMarshal.ToString(value));
        }

        public ColorI BevelColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("bevelColorHL"));
            set => SetFieldValue("bevelColorHL", GenericMarshal.ToString(value));
        }

        public ColorI BevelColorLL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("bevelColorLL"));
            set => SetFieldValue("bevelColorLL", GenericMarshal.ToString(value));
        }

        public string FontType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fontType"));
            set => SetFieldValue("fontType", GenericMarshal.ToString(value));
        }

        public int FontSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fontSize"));
            set => SetFieldValue("fontSize", GenericMarshal.ToString(value));
        }

        public GuiFontCharset FontCharset {
            get => GenericMarshal.StringTo<GuiFontCharset>(GetFieldValue("fontCharset"));
            set => SetFieldValue("fontCharset", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<ColorI> FontColors {
            get => new DynamicFieldVector<ColorI>(
                    this, 
                    "fontColors", 
                    10, 
                    val => GenericMarshal.StringTo<ColorI>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public ColorI FontColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColor"));
            set => SetFieldValue("fontColor", GenericMarshal.ToString(value));
        }

        public ColorI FontColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorHL"));
            set => SetFieldValue("fontColorHL", GenericMarshal.ToString(value));
        }

        public ColorI FontColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorNA"));
            set => SetFieldValue("fontColorNA", GenericMarshal.ToString(value));
        }

        public ColorI FontColorSEL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorSEL"));
            set => SetFieldValue("fontColorSEL", GenericMarshal.ToString(value));
        }

        public ColorI FontColorLink {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorLink"));
            set => SetFieldValue("fontColorLink", GenericMarshal.ToString(value));
        }

        public ColorI FontColorLinkHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorLinkHL"));
            set => SetFieldValue("fontColorLinkHL", GenericMarshal.ToString(value));
        }

        public GuiAlignmentType Justify {
            get => GenericMarshal.StringTo<GuiAlignmentType>(GetFieldValue("justify"));
            set => SetFieldValue("justify", GenericMarshal.ToString(value));
        }

        public Point2I TextOffset {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("textOffset"));
            set => SetFieldValue("textOffset", GenericMarshal.ToString(value));
        }

        public bool AutoSizeWidth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSizeWidth"));
            set => SetFieldValue("autoSizeWidth", GenericMarshal.ToString(value));
        }

        public bool AutoSizeHeight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSizeHeight"));
            set => SetFieldValue("autoSizeHeight", GenericMarshal.ToString(value));
        }

        public bool ReturnTab {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("returnTab"));
            set => SetFieldValue("returnTab", GenericMarshal.ToString(value));
        }

        public bool NumbersOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("numbersOnly"));
            set => SetFieldValue("numbersOnly", GenericMarshal.ToString(value));
        }

        public ColorI CursorColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("cursorColor"));
            set => SetFieldValue("cursorColor", GenericMarshal.ToString(value));
        }

        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("bitmap"));
            set => SetFieldValue("bitmap", GenericMarshal.ToString(value));
        }

        public bool HasBitmapArray {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hasBitmapArray"));
            set => SetFieldValue("hasBitmapArray", GenericMarshal.ToString(value));
        }

        public SFXTrack SoundButtonDown {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("soundButtonDown"));
            set => SetFieldValue("soundButtonDown", GenericMarshal.ToString(value));
        }

        public SFXTrack SoundButtonOver {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("soundButtonOver"));
            set => SetFieldValue("soundButtonOver", GenericMarshal.ToString(value));
        }

        public string ProfileForChildren {
            get => GenericMarshal.StringTo<string>(GetFieldValue("profileForChildren"));
            set => SetFieldValue("profileForChildren", GenericMarshal.ToString(value));
        }

        public string Category {
            get => GenericMarshal.StringTo<string>(GetFieldValue("category"));
            set => SetFieldValue("category", GenericMarshal.ToString(value));
        }
    }
}