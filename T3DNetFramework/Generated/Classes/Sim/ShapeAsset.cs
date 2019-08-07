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

    public unsafe class ShapeAsset : AssetBase {



        public ShapeAsset(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ShapeAsset(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ShapeAsset(string pName) 
            : this(pName, false) {
        }
        
        public ShapeAsset(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ShapeAsset(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ShapeAsset(SimObject pObj) 
            : base(pObj) {
        }
        
        public ShapeAsset(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAnimation__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetAnimation(IntPtr _this, int index);
                internal delegate IntPtr _GetAnimation(IntPtr _this, GetAnimation__Args args);
                private static _GetAnimation _GetAnimationFunc;
                internal static _GetAnimation GetAnimation() {
                    if (_GetAnimationFunc == null) {
                        _GetAnimationFunc =
                            (_GetAnimation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeAsset_getAnimation"), typeof(_GetAnimation));
                    }
                    
                    return _GetAnimationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAnimationCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetAnimationCount(IntPtr _this);
                internal delegate int _GetAnimationCount(IntPtr _this, GetAnimationCount__Args args);
                private static _GetAnimationCount _GetAnimationCountFunc;
                internal static _GetAnimationCount GetAnimationCount() {
                    if (_GetAnimationCountFunc == null) {
                        _GetAnimationCountFunc =
                            (_GetAnimationCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeAsset_getAnimationCount"), typeof(_GetAnimationCount));
                    }
                    
                    return _GetAnimationCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMaterialCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetMaterialCount(IntPtr _this);
                internal delegate int _GetMaterialCount(IntPtr _this, GetMaterialCount__Args args);
                private static _GetMaterialCount _GetMaterialCountFunc;
                internal static _GetMaterialCount GetMaterialCount() {
                    if (_GetMaterialCountFunc == null) {
                        _GetMaterialCountFunc =
                            (_GetMaterialCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeAsset_getMaterialCount"), typeof(_GetMaterialCount));
                    }
                    
                    return _GetMaterialCountFunc;
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
                                    "fnShapeAsset_staticGetType"), typeof(_StaticGetType));
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
                                    "fnShapeAsset_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public ShapeAnimationAsset GetAnimation(int index = 0) {
        
                                          InternalUnsafeMethods.GetAnimation__Args _args = new InternalUnsafeMethods.GetAnimation__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetAnimation()(ObjectPtr, _args);
                                                      
                     return new ShapeAnimationAsset(_engineResult);
                  }
	

			
                  public int GetAnimationCount() {
        
                     InternalUnsafeMethods.GetAnimationCount__Args _args = new InternalUnsafeMethods.GetAnimationCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetAnimationCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetMaterialCount() {
        
                     InternalUnsafeMethods.GetMaterialCount__Args _args = new InternalUnsafeMethods.GetMaterialCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetMaterialCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }


    }
}