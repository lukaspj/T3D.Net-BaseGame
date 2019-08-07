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

    public unsafe class ShapeAnimationAsset : AssetBase {



        public ShapeAnimationAsset(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ShapeAnimationAsset(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ShapeAnimationAsset(string pName) 
            : this(pName, false) {
        }
        
        public ShapeAnimationAsset(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ShapeAnimationAsset(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ShapeAnimationAsset(SimObject pObj) 
            : base(pObj) {
        }
        
        public ShapeAnimationAsset(IntPtr pObj) 
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
                                    "fnShapeAnimationAsset_staticGetType"), typeof(_StaticGetType));
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
                                    "fnShapeAnimationAsset_create"), typeof(_Create));
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
	





        public string AnimationFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animationFile"));
            set => SetFieldValue("animationFile", GenericMarshal.ToString(value));
        }


        public string AnimationName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animationName"));
            set => SetFieldValue("animationName", GenericMarshal.ToString(value));
        }


        public bool IsEmbedded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isEmbedded"));
            set => SetFieldValue("isEmbedded", GenericMarshal.ToString(value));
        }


        public bool IsCyclic {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isCyclic"));
            set => SetFieldValue("isCyclic", GenericMarshal.ToString(value));
        }


        public bool IsBlend {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isBlend"));
            set => SetFieldValue("isBlend", GenericMarshal.ToString(value));
        }


        public string BlendRefAnimation {
            get => GenericMarshal.StringTo<string>(GetFieldValue("blendRefAnimation"));
            set => SetFieldValue("blendRefAnimation", GenericMarshal.ToString(value));
        }


        public int BlendFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("blendFrame"));
            set => SetFieldValue("blendFrame", GenericMarshal.ToString(value));
        }


        public int StartFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("startFrame"));
            set => SetFieldValue("startFrame", GenericMarshal.ToString(value));
        }


        public int EndFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("endFrame"));
            set => SetFieldValue("endFrame", GenericMarshal.ToString(value));
        }


        public bool PadRotation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("padRotation"));
            set => SetFieldValue("padRotation", GenericMarshal.ToString(value));
        }


        public bool PadTransforms {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("padTransforms"));
            set => SetFieldValue("padTransforms", GenericMarshal.ToString(value));
        }


    }
}