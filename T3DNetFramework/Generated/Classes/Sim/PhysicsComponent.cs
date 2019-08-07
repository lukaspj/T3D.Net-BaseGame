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

    public unsafe class PhysicsComponent : Component {



        public PhysicsComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PhysicsComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PhysicsComponent(string pName) 
            : this(pName, false) {
        }
        
        public PhysicsComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PhysicsComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PhysicsComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public PhysicsComponent(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyImpulse__Args
                {
				   
				   internal IntPtr pos;
				   
				   internal IntPtr vel;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ApplyImpulse(IntPtr _this, IntPtr pos, IntPtr vel);
                internal delegate bool _ApplyImpulse(IntPtr _this, ApplyImpulse__Args args);
                private static _ApplyImpulse _ApplyImpulseFunc;
                internal static _ApplyImpulse ApplyImpulse() {
                    if (_ApplyImpulseFunc == null) {
                        _ApplyImpulseFunc =
                            (_ApplyImpulse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPhysicsComponent_applyImpulse"), typeof(_ApplyImpulse));
                    }
                    
                    return _ApplyImpulseFunc;
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
                                    "fnPhysicsComponent_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPhysicsComponent_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public bool ApplyImpulse(Point3F pos, Point3F vel) {
        
                     pos.Alloc();                     vel.Alloc();                     InternalUnsafeMethods.ApplyImpulse__Args _args = new InternalUnsafeMethods.ApplyImpulse__Args() {
                        pos = pos.internalStructPtr,
                        vel = vel.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.ApplyImpulse()(ObjectPtr, _args);
                                          pos.Free();                     vel.Free();            
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public Point3F Gravity {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("gravity"));
            set => SetFieldValue("gravity", GenericMarshal.ToString(value));
        }


        public Point3F Velocity {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("velocity"));
            set => SetFieldValue("velocity", GenericMarshal.ToString(value));
        }


        public bool IsStatic {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isStatic"));
            set => SetFieldValue("isStatic", GenericMarshal.ToString(value));
        }


    }
}