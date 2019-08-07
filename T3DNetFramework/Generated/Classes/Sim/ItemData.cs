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

    public unsafe class ItemData : ShapeBaseData {



        public ItemData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ItemData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ItemData(string pName) 
            : this(pName, false) {
        }
        
        public ItemData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ItemData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ItemData(SimObject pObj) 
            : base(pObj) {
        }
        
        public ItemData(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

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
                                    "fnItemData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnItemData_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public float Friction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("friction"));
            set => SetFieldValue("friction", GenericMarshal.ToString(value));
        }


        public float Elasticity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("elasticity"));
            set => SetFieldValue("elasticity", GenericMarshal.ToString(value));
        }


        public bool Sticky {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sticky"));
            set => SetFieldValue("sticky", GenericMarshal.ToString(value));
        }


        public float GravityMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gravityMod"));
            set => SetFieldValue("gravityMod", GenericMarshal.ToString(value));
        }


        public float MaxVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxVelocity"));
            set => SetFieldValue("maxVelocity", GenericMarshal.ToString(value));
        }


        public ItemLightType LightType {
            get => GenericMarshal.StringTo<ItemLightType>(GetFieldValue("lightType"));
            set => SetFieldValue("lightType", GenericMarshal.ToString(value));
        }


        public LinearColorF LightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightColor"));
            set => SetFieldValue("lightColor", GenericMarshal.ToString(value));
        }


        public int LightTime {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lightTime"));
            set => SetFieldValue("lightTime", GenericMarshal.ToString(value));
        }


        public float LightRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lightRadius"));
            set => SetFieldValue("lightRadius", GenericMarshal.ToString(value));
        }


        public bool LightOnlyStatic {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lightOnlyStatic"));
            set => SetFieldValue("lightOnlyStatic", GenericMarshal.ToString(value));
        }


        public bool SimpleServerCollision {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("simpleServerCollision"));
            set => SetFieldValue("simpleServerCollision", GenericMarshal.ToString(value));
        }


    }
}