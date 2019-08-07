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

    public unsafe class GuiTextCtrl : GuiContainer {



        public GuiTextCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTextCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTextCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTextCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTextCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTextCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTextCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTextID__Args
                {
				   
				   internal string textID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetTextID(IntPtr _this, string textID);
                internal delegate void _SetTextID(IntPtr _this, SetTextID__Args args);
                private static _SetTextID _SetTextIDFunc;
                internal static _SetTextID SetTextID() {
                    if (_SetTextIDFunc == null) {
                        _SetTextIDFunc =
                            (_SetTextID)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTextCtrl_setTextID"), typeof(_SetTextID));
                    }
                    
                    return _SetTextIDFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetText__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetText(IntPtr _this, string text);
                internal delegate void _SetText(IntPtr _this, SetText__Args args);
                private static _SetText _SetTextFunc;
                internal static _SetText SetText() {
                    if (_SetTextFunc == null) {
                        _SetTextFunc =
                            (_SetText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTextCtrl_setText"), typeof(_SetText));
                    }
                    
                    return _SetTextFunc;
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
                                    "fnGuiTextCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiTextCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void SetTextID(string textID) {
        
                                          InternalUnsafeMethods.SetTextID__Args _args = new InternalUnsafeMethods.SetTextID__Args() {
                        textID = textID,
                     };
                     InternalUnsafeMethods.SetTextID()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetText(string text) {
        
                                          InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.SetText()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string Text {
            get => GenericMarshal.StringTo<string>(GetFieldValue("text"));
            set => SetFieldValue("text", GenericMarshal.ToString(value));
        }


        public string TextID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textID"));
            set => SetFieldValue("textID", GenericMarshal.ToString(value));
        }


        public int MaxLength {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxLength"));
            set => SetFieldValue("maxLength", GenericMarshal.ToString(value));
        }


    }
}