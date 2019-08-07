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

    public unsafe class SoundComponent : Component {



        public SoundComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SoundComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SoundComponent(string pName) 
            : this(pName, false) {
        }
        
        public SoundComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SoundComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SoundComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public SoundComponent(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct StopAudio__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _StopAudio(IntPtr _this, int slot);
                internal delegate bool _StopAudio(IntPtr _this, StopAudio__Args args);
                private static _StopAudio _StopAudioFunc;
                internal static _StopAudio StopAudio() {
                    if (_StopAudioFunc == null) {
                        _StopAudioFunc =
                            (_StopAudio)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSoundComponent_stopAudio"), typeof(_StopAudio));
                    }
                    
                    return _StopAudioFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PlayAudio__Args
                {
				   
				   internal int slot;
				   
				   internal IntPtr track;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PlayAudio(IntPtr _this, int slot, IntPtr track);
                internal delegate bool _PlayAudio(IntPtr _this, PlayAudio__Args args);
                private static _PlayAudio _PlayAudioFunc;
                internal static _PlayAudio PlayAudio() {
                    if (_PlayAudioFunc == null) {
                        _PlayAudioFunc =
                            (_PlayAudio)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSoundComponent_playAudio"), typeof(_PlayAudio));
                    }
                    
                    return _PlayAudioFunc;
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
                                    "fnSoundComponent_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSoundComponent_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public bool StopAudio(int slot) {
        
                                          InternalUnsafeMethods.StopAudio__Args _args = new InternalUnsafeMethods.StopAudio__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.StopAudio()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool PlayAudio(int slot = 0, SFXTrack track = null) {
        
                                                               InternalUnsafeMethods.PlayAudio__Args _args = new InternalUnsafeMethods.PlayAudio__Args() {
                        slot = slot,
                        track = track.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.PlayAudio()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public DynamicFieldVector<SFXTrack> MSoundFile {
            get => new DynamicFieldVector<SFXTrack>(
                    this, 
                    "mSoundFile", 
                    4, 
                    val => GenericMarshal.StringTo<SFXTrack>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> MPreviewSound {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "mPreviewSound", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<bool> Play {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "play", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


    }
}