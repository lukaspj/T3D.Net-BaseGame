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

    public unsafe class ForestWindEmitter : SceneObject {



        public ForestWindEmitter(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ForestWindEmitter(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ForestWindEmitter(string pName) 
            : this(pName, false) {
        }
        
        public ForestWindEmitter(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ForestWindEmitter(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ForestWindEmitter(SimObject pObj) 
            : base(pObj) {
        }
        
        public ForestWindEmitter(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AttachToObject__Args
                {
				   
				   internal uint objectID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AttachToObject(IntPtr _this, uint objectID);
                internal delegate void _AttachToObject(IntPtr _this, AttachToObject__Args args);
                private static _AttachToObject _AttachToObjectFunc;
                internal static _AttachToObject AttachToObject() {
                    if (_AttachToObjectFunc == null) {
                        _AttachToObjectFunc =
                            (_AttachToObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnForestWindEmitter_attachToObject"), typeof(_AttachToObject));
                    }
                    
                    return _AttachToObjectFunc;
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
                                    "fnForestWindEmitter_staticGetType"), typeof(_StaticGetType));
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
                                    "fnForestWindEmitter_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void AttachToObject(uint objectID) {
        
                                          InternalUnsafeMethods.AttachToObject__Args _args = new InternalUnsafeMethods.AttachToObject__Args() {
                        objectID = objectID,
                     };
                     InternalUnsafeMethods.AttachToObject()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool WindEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("windEnabled"));
            set => SetFieldValue("windEnabled", GenericMarshal.ToString(value));
        }


        public bool RadialEmitter {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("radialEmitter"));
            set => SetFieldValue("radialEmitter", GenericMarshal.ToString(value));
        }


        public float Strength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("strength"));
            set => SetFieldValue("strength", GenericMarshal.ToString(value));
        }


        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }


        public float GustStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gustStrength"));
            set => SetFieldValue("gustStrength", GenericMarshal.ToString(value));
        }


        public float GustFrequency {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gustFrequency"));
            set => SetFieldValue("gustFrequency", GenericMarshal.ToString(value));
        }


        public float GustYawAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gustYawAngle"));
            set => SetFieldValue("gustYawAngle", GenericMarshal.ToString(value));
        }


        public float GustYawFrequency {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gustYawFrequency"));
            set => SetFieldValue("gustYawFrequency", GenericMarshal.ToString(value));
        }


        public float GustWobbleStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gustWobbleStrength"));
            set => SetFieldValue("gustWobbleStrength", GenericMarshal.ToString(value));
        }


        public float TurbulenceStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("turbulenceStrength"));
            set => SetFieldValue("turbulenceStrength", GenericMarshal.ToString(value));
        }


        public float TurbulenceFrequency {
            get => GenericMarshal.StringTo<float>(GetFieldValue("turbulenceFrequency"));
            set => SetFieldValue("turbulenceFrequency", GenericMarshal.ToString(value));
        }


        public bool HasMount {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hasMount"));
            set => SetFieldValue("hasMount", GenericMarshal.ToString(value));
        }


    }
}