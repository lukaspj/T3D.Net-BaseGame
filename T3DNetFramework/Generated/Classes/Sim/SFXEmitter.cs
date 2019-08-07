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

    public unsafe class SFXEmitter : SceneObject {



        public SFXEmitter(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SFXEmitter(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SFXEmitter(string pName) 
            : this(pName, false) {
        }
        
        public SFXEmitter(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SFXEmitter(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SFXEmitter(SimObject pObj) 
            : base(pObj) {
        }
        
        public SFXEmitter(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSource__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSource(IntPtr _this);
                internal delegate IntPtr _GetSource(IntPtr _this, GetSource__Args args);
                private static _GetSource _GetSourceFunc;
                internal static _GetSource GetSource() {
                    if (_GetSourceFunc == null) {
                        _GetSourceFunc =
                            (_GetSource)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXEmitter_getSource"), typeof(_GetSource));
                    }
                    
                    return _GetSourceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Stop__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Stop(IntPtr _this);
                internal delegate void _Stop(IntPtr _this, Stop__Args args);
                private static _Stop _StopFunc;
                internal static _Stop Stop() {
                    if (_StopFunc == null) {
                        _StopFunc =
                            (_Stop)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXEmitter_stop"), typeof(_Stop));
                    }
                    
                    return _StopFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Play__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Play(IntPtr _this);
                internal delegate void _Play(IntPtr _this, Play__Args args);
                private static _Play _PlayFunc;
                internal static _Play Play() {
                    if (_PlayFunc == null) {
                        _PlayFunc =
                            (_Play)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXEmitter_play"), typeof(_Play));
                    }
                    
                    return _PlayFunc;
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
                                    "fnSFXEmitter_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSFXEmitter_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public SFXSource GetSource() {
        
                     InternalUnsafeMethods.GetSource__Args _args = new InternalUnsafeMethods.GetSource__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSource()(ObjectPtr, _args);
                                 
                     return new SFXSource(_engineResult);
                  }
	

			
                  public void Stop() {
        
                     InternalUnsafeMethods.Stop__Args _args = new InternalUnsafeMethods.Stop__Args() {
                     };
                     InternalUnsafeMethods.Stop()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Play() {
        
                     InternalUnsafeMethods.Play__Args _args = new InternalUnsafeMethods.Play__Args() {
                     };
                     InternalUnsafeMethods.Play()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public SFXTrack Track {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("track"));
            set => SetFieldValue("track", GenericMarshal.ToString(value));
        }


        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }


        public bool PlayOnAdd {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("playOnAdd"));
            set => SetFieldValue("playOnAdd", GenericMarshal.ToString(value));
        }


        public bool UseTrackDescriptionOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useTrackDescriptionOnly"));
            set => SetFieldValue("useTrackDescriptionOnly", GenericMarshal.ToString(value));
        }


        public bool IsLooping {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isLooping"));
            set => SetFieldValue("isLooping", GenericMarshal.ToString(value));
        }


        public bool IsStreaming {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isStreaming"));
            set => SetFieldValue("isStreaming", GenericMarshal.ToString(value));
        }


        public SFXSource SourceGroup {
            get => GenericMarshal.StringTo<SFXSource>(GetFieldValue("sourceGroup"));
            set => SetFieldValue("sourceGroup", GenericMarshal.ToString(value));
        }


        public float Volume {
            get => GenericMarshal.StringTo<float>(GetFieldValue("volume"));
            set => SetFieldValue("volume", GenericMarshal.ToString(value));
        }


        public float Pitch {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pitch"));
            set => SetFieldValue("pitch", GenericMarshal.ToString(value));
        }


        public float FadeInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        public float FadeOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }


        public bool Is3D {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("is3D"));
            set => SetFieldValue("is3D", GenericMarshal.ToString(value));
        }


        public float ReferenceDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("referenceDistance"));
            set => SetFieldValue("referenceDistance", GenericMarshal.ToString(value));
        }


        public float MaxDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDistance"));
            set => SetFieldValue("maxDistance", GenericMarshal.ToString(value));
        }


        public Point3F ScatterDistance {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("scatterDistance"));
            set => SetFieldValue("scatterDistance", GenericMarshal.ToString(value));
        }


        public int ConeInsideAngle {
            get => GenericMarshal.StringTo<int>(GetFieldValue("coneInsideAngle"));
            set => SetFieldValue("coneInsideAngle", GenericMarshal.ToString(value));
        }


        public int ConeOutsideAngle {
            get => GenericMarshal.StringTo<int>(GetFieldValue("coneOutsideAngle"));
            set => SetFieldValue("coneOutsideAngle", GenericMarshal.ToString(value));
        }


        public float ConeOutsideVolume {
            get => GenericMarshal.StringTo<float>(GetFieldValue("coneOutsideVolume"));
            set => SetFieldValue("coneOutsideVolume", GenericMarshal.ToString(value));
        }


    }
}