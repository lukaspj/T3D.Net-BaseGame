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

    public unsafe class GuiFileTreeCtrl : GuiTreeViewCtrl {



        public GuiFileTreeCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiFileTreeCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiFileTreeCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiFileTreeCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiFileTreeCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiFileTreeCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiFileTreeCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Reload__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Reload(IntPtr _this);
                internal delegate void _Reload(IntPtr _this, Reload__Args args);
                private static _Reload _ReloadFunc;
                internal static _Reload Reload() {
                    if (_ReloadFunc == null) {
                        _ReloadFunc =
                            (_Reload)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFileTreeCtrl_reload"), typeof(_Reload));
                    }
                    
                    return _ReloadFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSelectedPath__Args
                {
				   
				   internal string path;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetSelectedPath(IntPtr _this, string path);
                internal delegate bool _SetSelectedPath(IntPtr _this, SetSelectedPath__Args args);
                private static _SetSelectedPath _SetSelectedPathFunc;
                internal static _SetSelectedPath SetSelectedPath() {
                    if (_SetSelectedPathFunc == null) {
                        _SetSelectedPathFunc =
                            (_SetSelectedPath)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFileTreeCtrl_setSelectedPath"), typeof(_SetSelectedPath));
                    }
                    
                    return _SetSelectedPathFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedPath__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSelectedPath(IntPtr _this);
                internal delegate IntPtr _GetSelectedPath(IntPtr _this, GetSelectedPath__Args args);
                private static _GetSelectedPath _GetSelectedPathFunc;
                internal static _GetSelectedPath GetSelectedPath() {
                    if (_GetSelectedPathFunc == null) {
                        _GetSelectedPathFunc =
                            (_GetSelectedPath)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFileTreeCtrl_getSelectedPath"), typeof(_GetSelectedPath));
                    }
                    
                    return _GetSelectedPathFunc;
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
                                    "fnGuiFileTreeCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiFileTreeCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void Reload() {
        
                     InternalUnsafeMethods.Reload__Args _args = new InternalUnsafeMethods.Reload__Args() {
                     };
                     InternalUnsafeMethods.Reload()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool SetSelectedPath(string path) {
        
                                          InternalUnsafeMethods.SetSelectedPath__Args _args = new InternalUnsafeMethods.SetSelectedPath__Args() {
                        path = path,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetSelectedPath()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public string GetSelectedPath() {
        
                     InternalUnsafeMethods.GetSelectedPath__Args _args = new InternalUnsafeMethods.GetSelectedPath__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSelectedPath()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string RootPath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("rootPath"));
            set => SetFieldValue("rootPath", GenericMarshal.ToString(value));
        }


        public string FileFilter {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileFilter"));
            set => SetFieldValue("fileFilter", GenericMarshal.ToString(value));
        }


    }
}