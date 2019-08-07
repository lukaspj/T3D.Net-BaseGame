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

    public unsafe class RibbonData : GameBaseData {



        public RibbonData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RibbonData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public RibbonData(string pName) 
            : this(pName, false) {
        }
        
        public RibbonData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public RibbonData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public RibbonData(SimObject pObj) 
            : base(pObj) {
        }
        
        public RibbonData(IntPtr pObj) 
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
                                    "fnRibbonData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnRibbonData_create"), typeof(_Create));
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
	





        public DynamicFieldVector<float> Size {
            get => new DynamicFieldVector<float>(
                    this, 
                    "size", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<LinearColorF> Color {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "color", 
                    4, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> Position {
            get => new DynamicFieldVector<float>(
                    this, 
                    "position", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public int RibbonLength {
            get => GenericMarshal.StringTo<int>(GetFieldValue("ribbonLength"));
            set => SetFieldValue("ribbonLength", GenericMarshal.ToString(value));
        }


        public int SegmentsPerUpdate {
            get => GenericMarshal.StringTo<int>(GetFieldValue("segmentsPerUpdate"));
            set => SetFieldValue("segmentsPerUpdate", GenericMarshal.ToString(value));
        }


        public int SkipAmount {
            get => GenericMarshal.StringTo<int>(GetFieldValue("skipAmount"));
            set => SetFieldValue("skipAmount", GenericMarshal.ToString(value));
        }


        public bool UseFadeOut {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useFadeOut"));
            set => SetFieldValue("useFadeOut", GenericMarshal.ToString(value));
        }


        public float FadeAwayStep {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeAwayStep"));
            set => SetFieldValue("fadeAwayStep", GenericMarshal.ToString(value));
        }


        public string RibbonMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ribbonMaterial"));
            set => SetFieldValue("ribbonMaterial", GenericMarshal.ToString(value));
        }


        public float TileScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("tileScale"));
            set => SetFieldValue("tileScale", GenericMarshal.ToString(value));
        }


        public bool FixedTexcoords {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fixedTexcoords"));
            set => SetFieldValue("fixedTexcoords", GenericMarshal.ToString(value));
        }


        public bool TexcoordsRelativeToDistance {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("texcoordsRelativeToDistance"));
            set => SetFieldValue("texcoordsRelativeToDistance", GenericMarshal.ToString(value));
        }


    }
}