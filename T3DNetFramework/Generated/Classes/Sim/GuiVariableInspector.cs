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

    public unsafe class GuiVariableInspector : GuiInspector {



        public GuiVariableInspector(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiVariableInspector(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiVariableInspector(string pName) 
            : this(pName, false) {
        }
        
        public GuiVariableInspector(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiVariableInspector(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiVariableInspector(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiVariableInspector(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct LoadVars__Args
                {
				   
				   internal string searchString;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _LoadVars(IntPtr _this, string searchString);
                internal delegate void _LoadVars(IntPtr _this, LoadVars__Args args);
                private static _LoadVars _LoadVarsFunc;
                internal static _LoadVars LoadVars() {
                    if (_LoadVarsFunc == null) {
                        _LoadVarsFunc =
                            (_LoadVars)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_loadVars"), typeof(_LoadVars));
                    }
                    
                    return _LoadVarsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFieldEnabled__Args
                {
				   
				   internal string fieldName;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isEnabled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetFieldEnabled(IntPtr _this, string fieldName, [MarshalAs(UnmanagedType.I1)]bool isEnabled);
                internal delegate void _SetFieldEnabled(IntPtr _this, SetFieldEnabled__Args args);
                private static _SetFieldEnabled _SetFieldEnabledFunc;
                internal static _SetFieldEnabled SetFieldEnabled() {
                    if (_SetFieldEnabledFunc == null) {
                        _SetFieldEnabledFunc =
                            (_SetFieldEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_setFieldEnabled"), typeof(_SetFieldEnabled));
                    }
                    
                    return _SetFieldEnabledFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearFields__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearFields(IntPtr _this);
                internal delegate void _ClearFields(IntPtr _this, ClearFields__Args args);
                private static _ClearFields _ClearFieldsFunc;
                internal static _ClearFields ClearFields() {
                    if (_ClearFieldsFunc == null) {
                        _ClearFieldsFunc =
                            (_ClearFields)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_clearFields"), typeof(_ClearFields));
                    }
                    
                    return _ClearFieldsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Update__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Update(IntPtr _this);
                internal delegate void _Update(IntPtr _this, Update__Args args);
                private static _Update _UpdateFunc;
                internal static _Update Update() {
                    if (_UpdateFunc == null) {
                        _UpdateFunc =
                            (_Update)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_update"), typeof(_Update));
                    }
                    
                    return _UpdateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddCallbackField__Args
                {
				   
				   internal string name;
				   
				   internal string label;
				   
				   internal string typeName;
				   
				   internal string description;
				   
				   internal string defaultValue;
				   
				   internal string dataValues;
				   
				   internal string callbackName;
				   
				   internal IntPtr ownerObj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddCallbackField(IntPtr _this, string name, string label, string typeName, string description, string defaultValue, string dataValues, string callbackName, IntPtr ownerObj);
                internal delegate void _AddCallbackField(IntPtr _this, AddCallbackField__Args args);
                private static _AddCallbackField _AddCallbackFieldFunc;
                internal static _AddCallbackField AddCallbackField() {
                    if (_AddCallbackFieldFunc == null) {
                        _AddCallbackFieldFunc =
                            (_AddCallbackField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_addCallbackField"), typeof(_AddCallbackField));
                    }
                    
                    return _AddCallbackFieldFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddField__Args
                {
				   
				   internal string name;
				   
				   internal string label;
				   
				   internal string typeName;
				   
				   internal string description;
				   
				   internal string defaultValue;
				   
				   internal string dataValues;
				   
				   internal IntPtr ownerObj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddField(IntPtr _this, string name, string label, string typeName, string description, string defaultValue, string dataValues, IntPtr ownerObj);
                internal delegate void _AddField(IntPtr _this, AddField__Args args);
                private static _AddField _AddFieldFunc;
                internal static _AddField AddField() {
                    if (_AddFieldFunc == null) {
                        _AddFieldFunc =
                            (_AddField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_addField"), typeof(_AddField));
                    }
                    
                    return _AddFieldFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct EndGroup__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _EndGroup(IntPtr _this);
                internal delegate void _EndGroup(IntPtr _this, EndGroup__Args args);
                private static _EndGroup _EndGroupFunc;
                internal static _EndGroup EndGroup() {
                    if (_EndGroupFunc == null) {
                        _EndGroupFunc =
                            (_EndGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_endGroup"), typeof(_EndGroup));
                    }
                    
                    return _EndGroupFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct StartGroup__Args
                {
				   
				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _StartGroup(IntPtr _this, string name);
                internal delegate void _StartGroup(IntPtr _this, StartGroup__Args args);
                private static _StartGroup _StartGroupFunc;
                internal static _StartGroup StartGroup() {
                    if (_StartGroupFunc == null) {
                        _StartGroupFunc =
                            (_StartGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiVariableInspector_startGroup"), typeof(_StartGroup));
                    }
                    
                    return _StartGroupFunc;
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
                                    "fnGuiVariableInspector_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiVariableInspector_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void LoadVars(string searchString) {
        
                                          InternalUnsafeMethods.LoadVars__Args _args = new InternalUnsafeMethods.LoadVars__Args() {
                        searchString = searchString,
                     };
                     InternalUnsafeMethods.LoadVars()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetFieldEnabled(string fieldName, bool isEnabled = true) {
        
                                                               InternalUnsafeMethods.SetFieldEnabled__Args _args = new InternalUnsafeMethods.SetFieldEnabled__Args() {
                        fieldName = fieldName,
                        isEnabled = isEnabled,
                     };
                     InternalUnsafeMethods.SetFieldEnabled()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void ClearFields() {
        
                     InternalUnsafeMethods.ClearFields__Args _args = new InternalUnsafeMethods.ClearFields__Args() {
                     };
                     InternalUnsafeMethods.ClearFields()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Update() {
        
                     InternalUnsafeMethods.Update__Args _args = new InternalUnsafeMethods.Update__Args() {
                     };
                     InternalUnsafeMethods.Update()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void AddCallbackField(string name, string label = "", string typeName = "", string description = "", string defaultValue = "", string dataValues = "", string callbackName = "", SimObject ownerObj = null) {
        
                                                                                                                                                                                             InternalUnsafeMethods.AddCallbackField__Args _args = new InternalUnsafeMethods.AddCallbackField__Args() {
                        name = name,
                        label = label,
                        typeName = typeName,
                        description = description,
                        defaultValue = defaultValue,
                        dataValues = dataValues,
                        callbackName = callbackName,
                        ownerObj = ownerObj.ObjectPtr,
                     };
                     InternalUnsafeMethods.AddCallbackField()(ObjectPtr, _args);
                                                                                                                                                                                                         
                  }
	

			
                  public void AddField(string name = "", string label = "", string typeName = "", string description = "", string defaultValue = "", string dataValues = "", SimObject ownerObj = null) {
        
                                                                                                                                                                        InternalUnsafeMethods.AddField__Args _args = new InternalUnsafeMethods.AddField__Args() {
                        name = name,
                        label = label,
                        typeName = typeName,
                        description = description,
                        defaultValue = defaultValue,
                        dataValues = dataValues,
                        ownerObj = ownerObj.ObjectPtr,
                     };
                     InternalUnsafeMethods.AddField()(ObjectPtr, _args);
                                                                                                                                                                                    
                  }
	

			
                  public void EndGroup() {
        
                     InternalUnsafeMethods.EndGroup__Args _args = new InternalUnsafeMethods.EndGroup__Args() {
                     };
                     InternalUnsafeMethods.EndGroup()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void StartGroup(string name) {
        
                                          InternalUnsafeMethods.StartGroup__Args _args = new InternalUnsafeMethods.StartGroup__Args() {
                        name = name,
                     };
                     InternalUnsafeMethods.StartGroup()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





    }
}