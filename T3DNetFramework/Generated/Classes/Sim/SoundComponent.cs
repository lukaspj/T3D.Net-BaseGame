using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {
    /// 
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

        /// <summary>Stop a sound started with playAudio.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="slot">audio slot index (started with playAudio)</param>
        /// <returns>true if the sound was stopped successfully, false if failed</returns>
        /// <see cref="playAudio()" />
        public bool StopAudio(int slot) {
             InternalUnsafeMethods.StopAudio__Args _args = new InternalUnsafeMethods.StopAudio__Args() {
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.StopAudio()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Attach a sound to this shape and start playing it.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="slot">Audio slot index for the sound (valid range is 0 - 3)</param>
        /// <param name="track">SFXTrack to play</param>
        /// <returns>true if the sound was attached successfully, false if failed</returns>
        /// <see cref="stopAudio()" />
        public bool PlayAudio(int slot = 0, SFXTrack track = null) {
             InternalUnsafeMethods.PlayAudio__Args _args = new InternalUnsafeMethods.PlayAudio__Args() {
                slot = slot,
                track = track.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.PlayAudio()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the SoundComponent class.
        /// </description>
        /// <returns>The type info object for SoundComponent</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If the text will not fit in the control, the deniedSound is played.
        /// </description>
        /// </value>
        public DynamicFieldVector<SFXTrack> MSoundFile {
            get => new DynamicFieldVector<SFXTrack>(
                    this, 
                    "mSoundFile", 
                    4, 
                    val => GenericMarshal.StringTo<SFXTrack>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Preview Sound
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> MPreviewSound {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "mPreviewSound", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Whether playback of the emitter's sound should start as soon as the emitter object is added to the level.
        /// If this is true, the emitter will immediately start to play when the level is loaded.
        /// </description>
        /// </value>
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