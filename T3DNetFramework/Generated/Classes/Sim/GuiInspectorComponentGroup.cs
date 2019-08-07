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

    public unsafe class GuiInspectorComponentGroup : GuiInspectorGroup {



        public GuiInspectorComponentGroup(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiInspectorComponentGroup(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiInspectorComponentGroup(string pName) 
            : this(pName, false) {
        }
        
        public GuiInspectorComponentGroup(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiInspectorComponentGroup(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiInspectorComponentGroup(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiInspectorComponentGroup(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetComponent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetComponent(IntPtr _this);
                internal delegate int _GetComponent(IntPtr _this, GetComponent__Args args);
                private static _GetComponent _GetComponentFunc;
                internal static _GetComponent GetComponent() {
                    if (_GetComponentFunc == null) {
                        _GetComponentFunc =
                            (_GetComponent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorComponentGroup_getComponent"), typeof(_GetComponent));
                    }
                    
                    return _GetComponentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveDynamicField__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveDynamicField(IntPtr _this);
                internal delegate void _RemoveDynamicField(IntPtr _this, RemoveDynamicField__Args args);
                private static _RemoveDynamicField _RemoveDynamicFieldFunc;
                internal static _RemoveDynamicField RemoveDynamicField() {
                    if (_RemoveDynamicFieldFunc == null) {
                        _RemoveDynamicFieldFunc =
                            (_RemoveDynamicField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorComponentGroup_removeDynamicField"), typeof(_RemoveDynamicField));
                    }
                    
                    return _RemoveDynamicFieldFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddDynamicField__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddDynamicField(IntPtr _this);
                internal delegate void _AddDynamicField(IntPtr _this, AddDynamicField__Args args);
                private static _AddDynamicField _AddDynamicFieldFunc;
                internal static _AddDynamicField AddDynamicField() {
                    if (_AddDynamicFieldFunc == null) {
                        _AddDynamicFieldFunc =
                            (_AddDynamicField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorComponentGroup_addDynamicField"), typeof(_AddDynamicField));
                    }
                    
                    return _AddDynamicFieldFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InspectGroup__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _InspectGroup(IntPtr _this);
                internal delegate bool _InspectGroup(IntPtr _this, InspectGroup__Args args);
                private static _InspectGroup _InspectGroupFunc;
                internal static _InspectGroup InspectGroup() {
                    if (_InspectGroupFunc == null) {
                        _InspectGroupFunc =
                            (_InspectGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorComponentGroup_inspectGroup"), typeof(_InspectGroup));
                    }
                    
                    return _InspectGroupFunc;
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
                                    "fnGuiInspectorComponentGroup_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiInspectorComponentGroup_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int GetComponent() {
        
                     InternalUnsafeMethods.GetComponent__Args _args = new InternalUnsafeMethods.GetComponent__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetComponent()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void RemoveDynamicField() {
        
                     InternalUnsafeMethods.RemoveDynamicField__Args _args = new InternalUnsafeMethods.RemoveDynamicField__Args() {
                     };
                     InternalUnsafeMethods.RemoveDynamicField()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void AddDynamicField() {
        
                     InternalUnsafeMethods.AddDynamicField__Args _args = new InternalUnsafeMethods.AddDynamicField__Args() {
                     };
                     InternalUnsafeMethods.AddDynamicField()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool InspectGroup() {
        
                     InternalUnsafeMethods.InspectGroup__Args _args = new InternalUnsafeMethods.InspectGroup__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.InspectGroup()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





    }
}