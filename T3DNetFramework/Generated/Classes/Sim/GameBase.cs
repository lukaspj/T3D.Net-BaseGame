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

    public unsafe class GameBase : SceneObject {



        public GameBase(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GameBase(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GameBase(string pName) 
            : this(pName, false) {
        }
        
        public GameBase(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GameBase(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GameBase(SimObject pObj) 
            : base(pObj) {
        }
        
        public GameBase(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyRadialImpulse__Args
                {
				   
				   internal IntPtr origin;
				   
				   internal float radius;
				   
				   internal float magnitude;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ApplyRadialImpulse(IntPtr _this, IntPtr origin, float radius, float magnitude);
                internal delegate void _ApplyRadialImpulse(IntPtr _this, ApplyRadialImpulse__Args args);
                private static _ApplyRadialImpulse _ApplyRadialImpulseFunc;
                internal static _ApplyRadialImpulse ApplyRadialImpulse() {
                    if (_ApplyRadialImpulseFunc == null) {
                        _ApplyRadialImpulseFunc =
                            (_ApplyRadialImpulse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameBase_applyRadialImpulse"), typeof(_ApplyRadialImpulse));
                    }
                    
                    return _ApplyRadialImpulseFunc;
                }

	

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
                                    "fnGameBase_applyImpulse"), typeof(_ApplyImpulse));
                    }
                    
                    return _ApplyImpulseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDataBlock__Args
                {
				   
				   internal IntPtr data;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetDataBlock(IntPtr _this, IntPtr data);
                internal delegate bool _SetDataBlock(IntPtr _this, SetDataBlock__Args args);
                private static _SetDataBlock _SetDataBlockFunc;
                internal static _SetDataBlock SetDataBlock() {
                    if (_SetDataBlockFunc == null) {
                        _SetDataBlockFunc =
                            (_SetDataBlock)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameBase_setDataBlock"), typeof(_SetDataBlock));
                    }
                    
                    return _SetDataBlockFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDataBlock__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetDataBlock(IntPtr _this);
                internal delegate int _GetDataBlock(IntPtr _this, GetDataBlock__Args args);
                private static _GetDataBlock _GetDataBlockFunc;
                internal static _GetDataBlock GetDataBlock() {
                    if (_GetDataBlockFunc == null) {
                        _GetDataBlockFunc =
                            (_GetDataBlock)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameBase_getDataBlock"), typeof(_GetDataBlock));
                    }
                    
                    return _GetDataBlockFunc;
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
                                    "fnGameBase_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGameBase_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetControl__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool controlled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetControl(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool controlled);
                internal delegate void _SetControl(IntPtr _this, SetControl__Args args);
                private static _SetControl _SetControlFunc;
                internal static _SetControl SetControl() {
                    if (_SetControlFunc == null) {
                        _SetControlFunc =
                            (_SetControl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameBase_setControl"), typeof(_SetControl));
                    }
                    
                    return _SetControlFunc;
                }

        }
        #endregion


			
                  public void ApplyRadialImpulse(Point3F origin, float radius, float magnitude) {
        
                     origin.Alloc();                                                               InternalUnsafeMethods.ApplyRadialImpulse__Args _args = new InternalUnsafeMethods.ApplyRadialImpulse__Args() {
                        origin = origin.internalStructPtr,
                        radius = radius,
                        magnitude = magnitude,
                     };
                     InternalUnsafeMethods.ApplyRadialImpulse()(ObjectPtr, _args);
                                          origin.Free();                                                      
                  }
	

			
                  public bool ApplyImpulse(Point3F pos, Point3F vel) {
        
                     pos.Alloc();                     vel.Alloc();                     InternalUnsafeMethods.ApplyImpulse__Args _args = new InternalUnsafeMethods.ApplyImpulse__Args() {
                        pos = pos.internalStructPtr,
                        vel = vel.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.ApplyImpulse()(ObjectPtr, _args);
                                          pos.Free();                     vel.Free();            
                     return _engineResult;
                  }
	

			
                  public bool SetDataBlock(GameBaseData data) {
        
                                          InternalUnsafeMethods.SetDataBlock__Args _args = new InternalUnsafeMethods.SetDataBlock__Args() {
                        data = data.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetDataBlock()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetDataBlock() {
        
                     InternalUnsafeMethods.GetDataBlock__Args _args = new InternalUnsafeMethods.GetDataBlock__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetDataBlock()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	



			
                  public void SetControl(bool controlled) {
        
                                          InternalUnsafeMethods.SetControl__Args _args = new InternalUnsafeMethods.SetControl__Args() {
                        controlled = controlled,
                     };
                     InternalUnsafeMethods.SetControl()(ObjectPtr, _args);
                                                      
                  }
	



        public GameBaseData DataBlock {
            get => GenericMarshal.StringTo<GameBaseData>(GetFieldValue("dataBlock"));
            set => SetFieldValue("dataBlock", GenericMarshal.ToString(value));
        }


    }
}