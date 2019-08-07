using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {    

    public unsafe class GuiIconButtonCtrl : GuiButtonCtrl {



        public GuiIconButtonCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiIconButtonCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiIconButtonCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiIconButtonCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiIconButtonCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiIconButtonCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiIconButtonCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetBitmap__Args
                {
				   
				   internal string buttonFilename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetBitmap(IntPtr _this, string buttonFilename);
                internal delegate void _SetBitmap(IntPtr _this, SetBitmap__Args args);
                private static _SetBitmap _SetBitmapFunc;
                internal static _SetBitmap SetBitmap() {
                    if (_SetBitmapFunc == null) {
                        _SetBitmapFunc =
                            (_SetBitmap)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiIconButtonCtrl_setBitmap"), typeof(_SetBitmap));
                    }
                    
                    return _SetBitmapFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct StaticGetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _StaticGetType();
                internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
                private static _StaticGetType _StaticGetTypeFunc;
                internal static _StaticGetType StaticGetType() {
                    if (_StaticGetTypeFunc == null) {
                        _StaticGetTypeFunc =
                            (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiIconButtonCtrl_staticGetType"), typeof(_StaticGetType));
                    }
                    
                    return _StaticGetTypeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Create__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _Create();
                internal delegate IntPtr _Create(Create__Args args);
                private static _Create _CreateFunc;
                internal static _Create Create() {
                    if (_CreateFunc == null) {
                        _CreateFunc =
                            (_Create)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiIconButtonCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void SetBitmap(string buttonFilename) {
        
                                          InternalUnsafeMethods.SetBitmap__Args _args = new InternalUnsafeMethods.SetBitmap__Args() {
                        buttonFilename = buttonFilename,
                     };
                     InternalUnsafeMethods.SetBitmap()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public Point2I ButtonMargin {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("buttonMargin"));
            set => SetFieldValue("buttonMargin", GenericMarshal.ToString(value));
        }


        public string IconBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("iconBitmap"));
            set => SetFieldValue("iconBitmap", GenericMarshal.ToString(value));
        }


        public GuiIconButtonIconLocation IconLocation {
            get => GenericMarshal.StringTo<GuiIconButtonIconLocation>(GetFieldValue("iconLocation"));
            set => SetFieldValue("iconLocation", GenericMarshal.ToString(value));
        }


        public bool SizeIconToButton {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sizeIconToButton"));
            set => SetFieldValue("sizeIconToButton", GenericMarshal.ToString(value));
        }


        public bool MakeIconSquare {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("makeIconSquare"));
            set => SetFieldValue("makeIconSquare", GenericMarshal.ToString(value));
        }


        public GuiIconButtonTextLocation TextLocation {
            get => GenericMarshal.StringTo<GuiIconButtonTextLocation>(GetFieldValue("textLocation"));
            set => SetFieldValue("textLocation", GenericMarshal.ToString(value));
        }


        public int TextMargin {
            get => GenericMarshal.StringTo<int>(GetFieldValue("textMargin"));
            set => SetFieldValue("textMargin", GenericMarshal.ToString(value));
        }


        public bool AutoSize {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSize"));
            set => SetFieldValue("autoSize", GenericMarshal.ToString(value));
        }


    }
}