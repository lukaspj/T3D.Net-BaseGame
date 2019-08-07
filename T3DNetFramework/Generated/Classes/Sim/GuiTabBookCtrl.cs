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

    public unsafe class GuiTabBookCtrl : GuiContainer {



        public GuiTabBookCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTabBookCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTabBookCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTabBookCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTabBookCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTabBookCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTabBookCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedPage__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelectedPage(IntPtr _this);
                internal delegate int _GetSelectedPage(IntPtr _this, GetSelectedPage__Args args);
                private static _GetSelectedPage _GetSelectedPageFunc;
                internal static _GetSelectedPage GetSelectedPage() {
                    if (_GetSelectedPageFunc == null) {
                        _GetSelectedPageFunc =
                            (_GetSelectedPage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTabBookCtrl_getSelectedPage"), typeof(_GetSelectedPage));
                    }
                    
                    return _GetSelectedPageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SelectPage__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SelectPage(IntPtr _this, int index);
                internal delegate void _SelectPage(IntPtr _this, SelectPage__Args args);
                private static _SelectPage _SelectPageFunc;
                internal static _SelectPage SelectPage() {
                    if (_SelectPageFunc == null) {
                        _SelectPageFunc =
                            (_SelectPage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTabBookCtrl_selectPage"), typeof(_SelectPage));
                    }
                    
                    return _SelectPageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddPage__Args
                {
				   
				   internal string title;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddPage(IntPtr _this, string title);
                internal delegate void _AddPage(IntPtr _this, AddPage__Args args);
                private static _AddPage _AddPageFunc;
                internal static _AddPage AddPage() {
                    if (_AddPageFunc == null) {
                        _AddPageFunc =
                            (_AddPage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTabBookCtrl_addPage"), typeof(_AddPage));
                    }
                    
                    return _AddPageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnTabRightClick__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string text;
				   
				   internal uint index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnTabRightClick(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string text, uint index);
                internal delegate void _OnTabRightClick(IntPtr _this, OnTabRightClick__Args args);
                private static _OnTabRightClick _OnTabRightClickFunc;
                internal static _OnTabRightClick OnTabRightClick() {
                    if (_OnTabRightClickFunc == null) {
                        _OnTabRightClickFunc =
                            (_OnTabRightClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTabBookCtrl_onTabRightClick"), typeof(_OnTabRightClick));
                    }
                    
                    return _OnTabRightClickFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnTabSelected__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string text;
				   
				   internal uint index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnTabSelected(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string text, uint index);
                internal delegate void _OnTabSelected(IntPtr _this, OnTabSelected__Args args);
                private static _OnTabSelected _OnTabSelectedFunc;
                internal static _OnTabSelected OnTabSelected() {
                    if (_OnTabSelectedFunc == null) {
                        _OnTabSelectedFunc =
                            (_OnTabSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTabBookCtrl_onTabSelected"), typeof(_OnTabSelected));
                    }
                    
                    return _OnTabSelectedFunc;
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
                                    "fnGuiTabBookCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiTabBookCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int GetSelectedPage() {
        
                     InternalUnsafeMethods.GetSelectedPage__Args _args = new InternalUnsafeMethods.GetSelectedPage__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelectedPage()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SelectPage(int index) {
        
                                          InternalUnsafeMethods.SelectPage__Args _args = new InternalUnsafeMethods.SelectPage__Args() {
                        index = index,
                     };
                     InternalUnsafeMethods.SelectPage()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddPage(string title = "") {
        
                                          InternalUnsafeMethods.AddPage__Args _args = new InternalUnsafeMethods.AddPage__Args() {
                        title = title,
                     };
                     InternalUnsafeMethods.AddPage()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnTabRightClick(string text, uint index) {
        
                                                               InternalUnsafeMethods.OnTabRightClick__Args _args = new InternalUnsafeMethods.OnTabRightClick__Args() {
                        text = text,
                        index = index,
                     };
                     InternalUnsafeMethods.OnTabRightClick()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnTabSelected(string text, uint index) {
        
                                                               InternalUnsafeMethods.OnTabSelected__Args _args = new InternalUnsafeMethods.OnTabSelected__Args() {
                        text = text,
                        index = index,
                     };
                     InternalUnsafeMethods.OnTabSelected()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public GuiTabPosition TabPosition {
            get => GenericMarshal.StringTo<GuiTabPosition>(GetFieldValue("tabPosition"));
            set => SetFieldValue("tabPosition", GenericMarshal.ToString(value));
        }


        public int TabMargin {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tabMargin"));
            set => SetFieldValue("tabMargin", GenericMarshal.ToString(value));
        }


        public int MinTabWidth {
            get => GenericMarshal.StringTo<int>(GetFieldValue("minTabWidth"));
            set => SetFieldValue("minTabWidth", GenericMarshal.ToString(value));
        }


        public int TabHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tabHeight"));
            set => SetFieldValue("tabHeight", GenericMarshal.ToString(value));
        }


        public bool AllowReorder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowReorder"));
            set => SetFieldValue("allowReorder", GenericMarshal.ToString(value));
        }


        public int DefaultPage {
            get => GenericMarshal.StringTo<int>(GetFieldValue("defaultPage"));
            set => SetFieldValue("defaultPage", GenericMarshal.ToString(value));
        }


        public int SelectedPage {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedPage"));
            set => SetFieldValue("selectedPage", GenericMarshal.ToString(value));
        }


        public int FrontTabPadding {
            get => GenericMarshal.StringTo<int>(GetFieldValue("frontTabPadding"));
            set => SetFieldValue("frontTabPadding", GenericMarshal.ToString(value));
        }


    }
}