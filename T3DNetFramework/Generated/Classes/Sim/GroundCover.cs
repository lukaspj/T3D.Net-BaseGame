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

    public unsafe class GroundCover : SceneObject {



        public GroundCover(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GroundCover(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GroundCover(string pName) 
            : this(pName, false) {
        }
        
        public GroundCover(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GroundCover(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GroundCover(SimObject pObj) 
            : base(pObj) {
        }
        
        public GroundCover(IntPtr pObj) 
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
                                    "fnGroundCover_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGroundCover_create"), typeof(_Create));
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
	





        public string Material {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Material"));
            set => SetFieldValue("Material", GenericMarshal.ToString(value));
        }


        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }


        public float DissolveRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dissolveRadius"));
            set => SetFieldValue("dissolveRadius", GenericMarshal.ToString(value));
        }


        public float ReflectScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reflectScale"));
            set => SetFieldValue("reflectScale", GenericMarshal.ToString(value));
        }


        public int GridSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("gridSize"));
            set => SetFieldValue("gridSize", GenericMarshal.ToString(value));
        }


        public float ZOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("zOffset"));
            set => SetFieldValue("zOffset", GenericMarshal.ToString(value));
        }


        public int Seed {
            get => GenericMarshal.StringTo<int>(GetFieldValue("seed"));
            set => SetFieldValue("seed", GenericMarshal.ToString(value));
        }


        public int MaxElements {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxElements"));
            set => SetFieldValue("maxElements", GenericMarshal.ToString(value));
        }


        public float MaxBillboardTiltAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxBillboardTiltAngle"));
            set => SetFieldValue("maxBillboardTiltAngle", GenericMarshal.ToString(value));
        }


        public float ShapeCullRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shapeCullRadius"));
            set => SetFieldValue("shapeCullRadius", GenericMarshal.ToString(value));
        }


        public bool ShapesCastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("shapesCastShadows"));
            set => SetFieldValue("shapesCastShadows", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<RectF> BillboardUVs {
            get => new DynamicFieldVector<RectF>(
                    this, 
                    "billboardUVs", 
                    8, 
                    val => GenericMarshal.StringTo<RectF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> ShapeFilename {
            get => new DynamicFieldVector<string>(
                    this, 
                    "shapeFilename", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> Layer {
            get => new DynamicFieldVector<string>(
                    this, 
                    "layer", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> InvertLayer {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "invertLayer", 
                    8, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> Probability {
            get => new DynamicFieldVector<float>(
                    this, 
                    "probability", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> SizeMin {
            get => new DynamicFieldVector<float>(
                    this, 
                    "sizeMin", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> SizeMax {
            get => new DynamicFieldVector<float>(
                    this, 
                    "sizeMax", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> SizeExponent {
            get => new DynamicFieldVector<float>(
                    this, 
                    "sizeExponent", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> WindScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "windScale", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> MaxSlope {
            get => new DynamicFieldVector<float>(
                    this, 
                    "maxSlope", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> MinElevation {
            get => new DynamicFieldVector<float>(
                    this, 
                    "minElevation", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> MaxElevation {
            get => new DynamicFieldVector<float>(
                    this, 
                    "maxElevation", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<int> MinClumpCount {
            get => new DynamicFieldVector<int>(
                    this, 
                    "minClumpCount", 
                    8, 
                    val => GenericMarshal.StringTo<int>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<int> MaxClumpCount {
            get => new DynamicFieldVector<int>(
                    this, 
                    "maxClumpCount", 
                    8, 
                    val => GenericMarshal.StringTo<int>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> ClumpExponent {
            get => new DynamicFieldVector<float>(
                    this, 
                    "clumpExponent", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<float> ClumpRadius {
            get => new DynamicFieldVector<float>(
                    this, 
                    "clumpRadius", 
                    8, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public Point2F WindDirection {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("windDirection"));
            set => SetFieldValue("windDirection", GenericMarshal.ToString(value));
        }


        public float WindGustLength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windGustLength"));
            set => SetFieldValue("windGustLength", GenericMarshal.ToString(value));
        }


        public float WindGustFrequency {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windGustFrequency"));
            set => SetFieldValue("windGustFrequency", GenericMarshal.ToString(value));
        }


        public float WindGustStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windGustStrength"));
            set => SetFieldValue("windGustStrength", GenericMarshal.ToString(value));
        }


        public float WindTurbulenceFrequency {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windTurbulenceFrequency"));
            set => SetFieldValue("windTurbulenceFrequency", GenericMarshal.ToString(value));
        }


        public float WindTurbulenceStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("windTurbulenceStrength"));
            set => SetFieldValue("windTurbulenceStrength", GenericMarshal.ToString(value));
        }


        public bool LockFrustum {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lockFrustum"));
            set => SetFieldValue("lockFrustum", GenericMarshal.ToString(value));
        }


        public bool RenderCells {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderCells"));
            set => SetFieldValue("renderCells", GenericMarshal.ToString(value));
        }


        public bool NoBillboards {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("noBillboards"));
            set => SetFieldValue("noBillboards", GenericMarshal.ToString(value));
        }


        public bool NoShapes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("noShapes"));
            set => SetFieldValue("noShapes", GenericMarshal.ToString(value));
        }


    }
}