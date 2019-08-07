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

    public unsafe class GuiRolloutCtrl : GuiControl {



        public GuiRolloutCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiRolloutCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiRolloutCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiRolloutCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiRolloutCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiRolloutCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiRolloutCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SizeToContents__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SizeToContents(IntPtr _this);
                internal delegate void _SizeToContents(IntPtr _this, SizeToContents__Args args);
                private static _SizeToContents _SizeToContentsFunc;
                internal static _SizeToContents SizeToContents() {
                    if (_SizeToContentsFunc == null) {
                        _SizeToContentsFunc =
                            (_SizeToContents)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_sizeToContents"), typeof(_SizeToContents));
                    }
                    
                    return _SizeToContentsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InstantExpand__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _InstantExpand(IntPtr _this);
                internal delegate void _InstantExpand(IntPtr _this, InstantExpand__Args args);
                private static _InstantExpand _InstantExpandFunc;
                internal static _InstantExpand InstantExpand() {
                    if (_InstantExpandFunc == null) {
                        _InstantExpandFunc =
                            (_InstantExpand)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_instantExpand"), typeof(_InstantExpand));
                    }
                    
                    return _InstantExpandFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InstantCollapse__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _InstantCollapse(IntPtr _this);
                internal delegate void _InstantCollapse(IntPtr _this, InstantCollapse__Args args);
                private static _InstantCollapse _InstantCollapseFunc;
                internal static _InstantCollapse InstantCollapse() {
                    if (_InstantCollapseFunc == null) {
                        _InstantCollapseFunc =
                            (_InstantCollapse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_instantCollapse"), typeof(_InstantCollapse));
                    }
                    
                    return _InstantCollapseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ToggleExpanded__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool instantly;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ToggleExpanded(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool instantly);
                internal delegate void _ToggleExpanded(IntPtr _this, ToggleExpanded__Args args);
                private static _ToggleExpanded _ToggleExpandedFunc;
                internal static _ToggleExpanded ToggleExpanded() {
                    if (_ToggleExpandedFunc == null) {
                        _ToggleExpandedFunc =
                            (_ToggleExpanded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_toggleExpanded"), typeof(_ToggleExpanded));
                    }
                    
                    return _ToggleExpandedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ToggleCollapse__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ToggleCollapse(IntPtr _this);
                internal delegate void _ToggleCollapse(IntPtr _this, ToggleCollapse__Args args);
                private static _ToggleCollapse _ToggleCollapseFunc;
                internal static _ToggleCollapse ToggleCollapse() {
                    if (_ToggleCollapseFunc == null) {
                        _ToggleCollapseFunc =
                            (_ToggleCollapse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_toggleCollapse"), typeof(_ToggleCollapse));
                    }
                    
                    return _ToggleCollapseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Expand__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Expand(IntPtr _this);
                internal delegate void _Expand(IntPtr _this, Expand__Args args);
                private static _Expand _ExpandFunc;
                internal static _Expand Expand() {
                    if (_ExpandFunc == null) {
                        _ExpandFunc =
                            (_Expand)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_expand"), typeof(_Expand));
                    }
                    
                    return _ExpandFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Collapse__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Collapse(IntPtr _this);
                internal delegate void _Collapse(IntPtr _this, Collapse__Args args);
                private static _Collapse _CollapseFunc;
                internal static _Collapse Collapse() {
                    if (_CollapseFunc == null) {
                        _CollapseFunc =
                            (_Collapse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_collapse"), typeof(_Collapse));
                    }
                    
                    return _CollapseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsExpanded__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsExpanded(IntPtr _this);
                internal delegate bool _IsExpanded(IntPtr _this, IsExpanded__Args args);
                private static _IsExpanded _IsExpandedFunc;
                internal static _IsExpanded IsExpanded() {
                    if (_IsExpandedFunc == null) {
                        _IsExpandedFunc =
                            (_IsExpanded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiRolloutCtrl_isExpanded"), typeof(_IsExpanded));
                    }
                    
                    return _IsExpandedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnCollapsed__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnCollapsed(IntPtr _this);
                internal delegate void _OnCollapsed(IntPtr _this, OnCollapsed__Args args);
                private static _OnCollapsed _OnCollapsedFunc;
                internal static _OnCollapsed OnCollapsed() {
                    if (_OnCollapsedFunc == null) {
                        _OnCollapsedFunc =
                            (_OnCollapsed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiRolloutCtrl_onCollapsed"), typeof(_OnCollapsed));
                    }
                    
                    return _OnCollapsedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnExpanded__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnExpanded(IntPtr _this);
                internal delegate void _OnExpanded(IntPtr _this, OnExpanded__Args args);
                private static _OnExpanded _OnExpandedFunc;
                internal static _OnExpanded OnExpanded() {
                    if (_OnExpandedFunc == null) {
                        _OnExpandedFunc =
                            (_OnExpanded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiRolloutCtrl_onExpanded"), typeof(_OnExpanded));
                    }
                    
                    return _OnExpandedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnHeaderRightClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnHeaderRightClick(IntPtr _this);
                internal delegate void _OnHeaderRightClick(IntPtr _this, OnHeaderRightClick__Args args);
                private static _OnHeaderRightClick _OnHeaderRightClickFunc;
                internal static _OnHeaderRightClick OnHeaderRightClick() {
                    if (_OnHeaderRightClickFunc == null) {
                        _OnHeaderRightClickFunc =
                            (_OnHeaderRightClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiRolloutCtrl_onHeaderRightClick"), typeof(_OnHeaderRightClick));
                    }
                    
                    return _OnHeaderRightClickFunc;
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
                                    "fnGuiRolloutCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiRolloutCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void SizeToContents() {
        
                     InternalUnsafeMethods.SizeToContents__Args _args = new InternalUnsafeMethods.SizeToContents__Args() {
                     };
                     InternalUnsafeMethods.SizeToContents()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void InstantExpand() {
        
                     InternalUnsafeMethods.InstantExpand__Args _args = new InternalUnsafeMethods.InstantExpand__Args() {
                     };
                     InternalUnsafeMethods.InstantExpand()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void InstantCollapse() {
        
                     InternalUnsafeMethods.InstantCollapse__Args _args = new InternalUnsafeMethods.InstantCollapse__Args() {
                     };
                     InternalUnsafeMethods.InstantCollapse()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ToggleExpanded(bool instantly = false) {
        
                                          InternalUnsafeMethods.ToggleExpanded__Args _args = new InternalUnsafeMethods.ToggleExpanded__Args() {
                        instantly = instantly,
                     };
                     InternalUnsafeMethods.ToggleExpanded()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void ToggleCollapse() {
        
                     InternalUnsafeMethods.ToggleCollapse__Args _args = new InternalUnsafeMethods.ToggleCollapse__Args() {
                     };
                     InternalUnsafeMethods.ToggleCollapse()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Expand() {
        
                     InternalUnsafeMethods.Expand__Args _args = new InternalUnsafeMethods.Expand__Args() {
                     };
                     InternalUnsafeMethods.Expand()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Collapse() {
        
                     InternalUnsafeMethods.Collapse__Args _args = new InternalUnsafeMethods.Collapse__Args() {
                     };
                     InternalUnsafeMethods.Collapse()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool IsExpanded() {
        
                     InternalUnsafeMethods.IsExpanded__Args _args = new InternalUnsafeMethods.IsExpanded__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsExpanded()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void OnCollapsed() {
        
                     InternalUnsafeMethods.OnCollapsed__Args _args = new InternalUnsafeMethods.OnCollapsed__Args() {
                     };
                     InternalUnsafeMethods.OnCollapsed()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnExpanded() {
        
                     InternalUnsafeMethods.OnExpanded__Args _args = new InternalUnsafeMethods.OnExpanded__Args() {
                     };
                     InternalUnsafeMethods.OnExpanded()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnHeaderRightClick() {
        
                     InternalUnsafeMethods.OnHeaderRightClick__Args _args = new InternalUnsafeMethods.OnHeaderRightClick__Args() {
                     };
                     InternalUnsafeMethods.OnHeaderRightClick()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        public RectI Margin {
            get => GenericMarshal.StringTo<RectI>(GetFieldValue("margin"));
            set => SetFieldValue("margin", GenericMarshal.ToString(value));
        }


        public int DefaultHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("defaultHeight"));
            set => SetFieldValue("defaultHeight", GenericMarshal.ToString(value));
        }


        public bool Expanded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("expanded"));
            set => SetFieldValue("expanded", GenericMarshal.ToString(value));
        }


        public bool ClickCollapse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clickCollapse"));
            set => SetFieldValue("clickCollapse", GenericMarshal.ToString(value));
        }


        public bool HideHeader {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hideHeader"));
            set => SetFieldValue("hideHeader", GenericMarshal.ToString(value));
        }


        public bool AutoCollapseSiblings {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoCollapseSiblings"));
            set => SetFieldValue("autoCollapseSiblings", GenericMarshal.ToString(value));
        }


    }
}