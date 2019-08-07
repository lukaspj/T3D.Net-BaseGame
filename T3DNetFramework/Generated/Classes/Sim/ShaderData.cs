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

    public unsafe class ShaderData : SimObject {



        public ShaderData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ShaderData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ShaderData(string pName) 
            : this(pName, false) {
        }
        
        public ShaderData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ShaderData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ShaderData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ShaderData(IntPtr pObj) 
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
                                    "fnShaderData_reload"), typeof(_Reload));
                    }
                    
                    return _ReloadFunc;
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
                                    "fnShaderData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnShaderData_create"), typeof(_Create));
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
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string DXVertexShaderFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DXVertexShaderFile"));
            set => SetFieldValue("DXVertexShaderFile", GenericMarshal.ToString(value));
        }


        public string DXPixelShaderFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DXPixelShaderFile"));
            set => SetFieldValue("DXPixelShaderFile", GenericMarshal.ToString(value));
        }


        public string OGLVertexShaderFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("OGLVertexShaderFile"));
            set => SetFieldValue("OGLVertexShaderFile", GenericMarshal.ToString(value));
        }


        public string OGLPixelShaderFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("OGLPixelShaderFile"));
            set => SetFieldValue("OGLPixelShaderFile", GenericMarshal.ToString(value));
        }


        public bool UseDevicePixVersion {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useDevicePixVersion"));
            set => SetFieldValue("useDevicePixVersion", GenericMarshal.ToString(value));
        }


        public float PixVersion {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pixVersion"));
            set => SetFieldValue("pixVersion", GenericMarshal.ToString(value));
        }


        public string Defines {
            get => GenericMarshal.StringTo<string>(GetFieldValue("defines"));
            set => SetFieldValue("defines", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<string> SamplerNames {
            get => new DynamicFieldVector<string>(
                    this, 
                    "samplerNames", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> RtParams {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "rtParams", 
                    8, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


    }
}