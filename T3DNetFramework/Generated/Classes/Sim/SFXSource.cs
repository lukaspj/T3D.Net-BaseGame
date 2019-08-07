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

    public unsafe class SFXSource : SimGroup {



        public SFXSource(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SFXSource(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SFXSource(string pName) 
            : this(pName, false) {
        }
        
        public SFXSource(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SFXSource(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SFXSource(SimObject pObj) 
            : base(pObj) {
        }
        
        public SFXSource(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddMarker__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string name;
				   
				   internal float pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddMarker(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string name, float pos);
                internal delegate void _AddMarker(IntPtr _this, AddMarker__Args args);
                private static _AddMarker _AddMarkerFunc;
                internal static _AddMarker AddMarker() {
                    if (_AddMarkerFunc == null) {
                        _AddMarkerFunc =
                            (_AddMarker)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_addMarker"), typeof(_AddMarker));
                    }
                    
                    return _AddMarkerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetParameter__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetParameter(IntPtr _this, int index);
                internal delegate IntPtr _GetParameter(IntPtr _this, GetParameter__Args args);
                private static _GetParameter _GetParameterFunc;
                internal static _GetParameter GetParameter() {
                    if (_GetParameterFunc == null) {
                        _GetParameterFunc =
                            (_GetParameter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getParameter"), typeof(_GetParameter));
                    }
                    
                    return _GetParameterFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveParameter__Args
                {
				   
				   internal IntPtr parameter;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveParameter(IntPtr _this, IntPtr parameter);
                internal delegate void _RemoveParameter(IntPtr _this, RemoveParameter__Args args);
                private static _RemoveParameter _RemoveParameterFunc;
                internal static _RemoveParameter RemoveParameter() {
                    if (_RemoveParameterFunc == null) {
                        _RemoveParameterFunc =
                            (_RemoveParameter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_removeParameter"), typeof(_RemoveParameter));
                    }
                    
                    return _RemoveParameterFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddParameter__Args
                {
				   
				   internal IntPtr parameter;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddParameter(IntPtr _this, IntPtr parameter);
                internal delegate void _AddParameter(IntPtr _this, AddParameter__Args args);
                private static _AddParameter _AddParameterFunc;
                internal static _AddParameter AddParameter() {
                    if (_AddParameterFunc == null) {
                        _AddParameterFunc =
                            (_AddParameter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_addParameter"), typeof(_AddParameter));
                    }
                    
                    return _AddParameterFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetParameterCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetParameterCount(IntPtr _this);
                internal delegate int _GetParameterCount(IntPtr _this, GetParameterCount__Args args);
                private static _GetParameterCount _GetParameterCountFunc;
                internal static _GetParameterCount GetParameterCount() {
                    if (_GetParameterCountFunc == null) {
                        _GetParameterCountFunc =
                            (_GetParameterCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getParameterCount"), typeof(_GetParameterCount));
                    }
                    
                    return _GetParameterCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCone__Args
                {
				   
				   internal float innerAngle;
				   
				   internal float outerAngle;
				   
				   internal float outsideVolume;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCone(IntPtr _this, float innerAngle, float outerAngle, float outsideVolume);
                internal delegate void _SetCone(IntPtr _this, SetCone__Args args);
                private static _SetCone _SetConeFunc;
                internal static _SetCone SetCone() {
                    if (_SetConeFunc == null) {
                        _SetConeFunc =
                            (_SetCone)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_setCone"), typeof(_SetCone));
                    }
                    
                    return _SetConeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTransform__Args
                {
				   
				   internal string position;
				   
				   internal string direction;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetTransform(IntPtr _this, string position, string direction);
                internal delegate void _SetTransform(IntPtr _this, SetTransform__Args args);
                private static _SetTransform _SetTransformFunc;
                internal static _SetTransform SetTransform() {
                    if (_SetTransformFunc == null) {
                        _SetTransformFunc =
                            (_SetTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_setTransform"), typeof(_SetTransform));
                    }
                    
                    return _SetTransformFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPitch__Args
                {
				   
				   internal float pitch;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetPitch(IntPtr _this, float pitch);
                internal delegate void _SetPitch(IntPtr _this, SetPitch__Args args);
                private static _SetPitch _SetPitchFunc;
                internal static _SetPitch SetPitch() {
                    if (_SetPitchFunc == null) {
                        _SetPitchFunc =
                            (_SetPitch)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_setPitch"), typeof(_SetPitch));
                    }
                    
                    return _SetPitchFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPitch__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetPitch(IntPtr _this);
                internal delegate float _GetPitch(IntPtr _this, GetPitch__Args args);
                private static _GetPitch _GetPitchFunc;
                internal static _GetPitch GetPitch() {
                    if (_GetPitchFunc == null) {
                        _GetPitchFunc =
                            (_GetPitch)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getPitch"), typeof(_GetPitch));
                    }
                    
                    return _GetPitchFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFadeTimes__Args
                {
				   
				   internal float fadeInTime;
				   
				   internal float fadeOutTime;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetFadeTimes(IntPtr _this, float fadeInTime, float fadeOutTime);
                internal delegate void _SetFadeTimes(IntPtr _this, SetFadeTimes__Args args);
                private static _SetFadeTimes _SetFadeTimesFunc;
                internal static _SetFadeTimes SetFadeTimes() {
                    if (_SetFadeTimesFunc == null) {
                        _SetFadeTimesFunc =
                            (_SetFadeTimes)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_setFadeTimes"), typeof(_SetFadeTimes));
                    }
                    
                    return _SetFadeTimesFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFadeOutTime__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetFadeOutTime(IntPtr _this);
                internal delegate float _GetFadeOutTime(IntPtr _this, GetFadeOutTime__Args args);
                private static _GetFadeOutTime _GetFadeOutTimeFunc;
                internal static _GetFadeOutTime GetFadeOutTime() {
                    if (_GetFadeOutTimeFunc == null) {
                        _GetFadeOutTimeFunc =
                            (_GetFadeOutTime)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getFadeOutTime"), typeof(_GetFadeOutTime));
                    }
                    
                    return _GetFadeOutTimeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFadeInTime__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetFadeInTime(IntPtr _this);
                internal delegate float _GetFadeInTime(IntPtr _this, GetFadeInTime__Args args);
                private static _GetFadeInTime _GetFadeInTimeFunc;
                internal static _GetFadeInTime GetFadeInTime() {
                    if (_GetFadeInTimeFunc == null) {
                        _GetFadeInTimeFunc =
                            (_GetFadeInTime)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getFadeInTime"), typeof(_GetFadeInTime));
                    }
                    
                    return _GetFadeInTimeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAttenuatedVolume__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetAttenuatedVolume(IntPtr _this);
                internal delegate float _GetAttenuatedVolume(IntPtr _this, GetAttenuatedVolume__Args args);
                private static _GetAttenuatedVolume _GetAttenuatedVolumeFunc;
                internal static _GetAttenuatedVolume GetAttenuatedVolume() {
                    if (_GetAttenuatedVolumeFunc == null) {
                        _GetAttenuatedVolumeFunc =
                            (_GetAttenuatedVolume)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getAttenuatedVolume"), typeof(_GetAttenuatedVolume));
                    }
                    
                    return _GetAttenuatedVolumeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetVolume__Args
                {
				   
				   internal float volume;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetVolume(IntPtr _this, float volume);
                internal delegate void _SetVolume(IntPtr _this, SetVolume__Args args);
                private static _SetVolume _SetVolumeFunc;
                internal static _SetVolume SetVolume() {
                    if (_SetVolumeFunc == null) {
                        _SetVolumeFunc =
                            (_SetVolume)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_setVolume"), typeof(_SetVolume));
                    }
                    
                    return _SetVolumeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetVolume__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetVolume(IntPtr _this);
                internal delegate float _GetVolume(IntPtr _this, GetVolume__Args args);
                private static _GetVolume _GetVolumeFunc;
                internal static _GetVolume GetVolume() {
                    if (_GetVolumeFunc == null) {
                        _GetVolumeFunc =
                            (_GetVolume)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getVolume"), typeof(_GetVolume));
                    }
                    
                    return _GetVolumeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetStatus__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetStatus(IntPtr _this);
                internal delegate int _GetStatus(IntPtr _this, GetStatus__Args args);
                private static _GetStatus _GetStatusFunc;
                internal static _GetStatus GetStatus() {
                    if (_GetStatusFunc == null) {
                        _GetStatusFunc =
                            (_GetStatus)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_getStatus"), typeof(_GetStatus));
                    }
                    
                    return _GetStatusFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsStopped__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsStopped(IntPtr _this);
                internal delegate bool _IsStopped(IntPtr _this, IsStopped__Args args);
                private static _IsStopped _IsStoppedFunc;
                internal static _IsStopped IsStopped() {
                    if (_IsStoppedFunc == null) {
                        _IsStoppedFunc =
                            (_IsStopped)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_isStopped"), typeof(_IsStopped));
                    }
                    
                    return _IsStoppedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsPaused__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsPaused(IntPtr _this);
                internal delegate bool _IsPaused(IntPtr _this, IsPaused__Args args);
                private static _IsPaused _IsPausedFunc;
                internal static _IsPaused IsPaused() {
                    if (_IsPausedFunc == null) {
                        _IsPausedFunc =
                            (_IsPaused)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_isPaused"), typeof(_IsPaused));
                    }
                    
                    return _IsPausedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsPlaying__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsPlaying(IntPtr _this);
                internal delegate bool _IsPlaying(IntPtr _this, IsPlaying__Args args);
                private static _IsPlaying _IsPlayingFunc;
                internal static _IsPlaying IsPlaying() {
                    if (_IsPlayingFunc == null) {
                        _IsPlayingFunc =
                            (_IsPlaying)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_isPlaying"), typeof(_IsPlaying));
                    }
                    
                    return _IsPlayingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Pause__Args
                {
				   
				   internal float fadeOutTime;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Pause(IntPtr _this, float fadeOutTime);
                internal delegate void _Pause(IntPtr _this, Pause__Args args);
                private static _Pause _PauseFunc;
                internal static _Pause Pause() {
                    if (_PauseFunc == null) {
                        _PauseFunc =
                            (_Pause)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_pause"), typeof(_Pause));
                    }
                    
                    return _PauseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Stop__Args
                {
				   
				   internal float fadeOutTime;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Stop(IntPtr _this, float fadeOutTime);
                internal delegate void _Stop(IntPtr _this, Stop__Args args);
                private static _Stop _StopFunc;
                internal static _Stop Stop() {
                    if (_StopFunc == null) {
                        _StopFunc =
                            (_Stop)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_stop"), typeof(_Stop));
                    }
                    
                    return _StopFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Play__Args
                {
				   
				   internal float fadeInTime;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Play(IntPtr _this, float fadeInTime);
                internal delegate void _Play(IntPtr _this, Play__Args args);
                private static _Play _PlayFunc;
                internal static _Play Play() {
                    if (_PlayFunc == null) {
                        _PlayFunc =
                            (_Play)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSFXSource_play"), typeof(_Play));
                    }
                    
                    return _PlayFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnParameterValueChange__Args
                {
				   
				   internal IntPtr parameter;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnParameterValueChange(IntPtr _this, IntPtr parameter);
                internal delegate void _OnParameterValueChange(IntPtr _this, OnParameterValueChange__Args args);
                private static _OnParameterValueChange _OnParameterValueChangeFunc;
                internal static _OnParameterValueChange OnParameterValueChange() {
                    if (_OnParameterValueChangeFunc == null) {
                        _OnParameterValueChangeFunc =
                            (_OnParameterValueChange)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbSFXSource_onParameterValueChange"), typeof(_OnParameterValueChange));
                    }
                    
                    return _OnParameterValueChangeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnStatusChange__Args
                {
				   
				   internal int newStatus;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnStatusChange(IntPtr _this, int newStatus);
                internal delegate void _OnStatusChange(IntPtr _this, OnStatusChange__Args args);
                private static _OnStatusChange _OnStatusChangeFunc;
                internal static _OnStatusChange OnStatusChange() {
                    if (_OnStatusChangeFunc == null) {
                        _OnStatusChangeFunc =
                            (_OnStatusChange)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbSFXSource_onStatusChange"), typeof(_OnStatusChange));
                    }
                    
                    return _OnStatusChangeFunc;
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
                                    "fnSFXSource_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSFXSource_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void AddMarker(string name, float pos) {
        
                                                               InternalUnsafeMethods.AddMarker__Args _args = new InternalUnsafeMethods.AddMarker__Args() {
                        name = name,
                        pos = pos,
                     };
                     InternalUnsafeMethods.AddMarker()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public SFXParameter GetParameter(int index) {
        
                                          InternalUnsafeMethods.GetParameter__Args _args = new InternalUnsafeMethods.GetParameter__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetParameter()(ObjectPtr, _args);
                                                      
                     return new SFXParameter(_engineResult);
                  }
	

			
                  public void RemoveParameter(SFXParameter parameter) {
        
                                          InternalUnsafeMethods.RemoveParameter__Args _args = new InternalUnsafeMethods.RemoveParameter__Args() {
                        parameter = parameter.ObjectPtr,
                     };
                     InternalUnsafeMethods.RemoveParameter()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddParameter(SFXParameter parameter) {
        
                                          InternalUnsafeMethods.AddParameter__Args _args = new InternalUnsafeMethods.AddParameter__Args() {
                        parameter = parameter.ObjectPtr,
                     };
                     InternalUnsafeMethods.AddParameter()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetParameterCount() {
        
                     InternalUnsafeMethods.GetParameterCount__Args _args = new InternalUnsafeMethods.GetParameterCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetParameterCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetCone(float innerAngle, float outerAngle, float outsideVolume) {
        
                                                                                    InternalUnsafeMethods.SetCone__Args _args = new InternalUnsafeMethods.SetCone__Args() {
                        innerAngle = innerAngle,
                        outerAngle = outerAngle,
                        outsideVolume = outsideVolume,
                     };
                     InternalUnsafeMethods.SetCone()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public void SetTransform(string position, string direction = "") {
        
                                                               InternalUnsafeMethods.SetTransform__Args _args = new InternalUnsafeMethods.SetTransform__Args() {
                        position = position,
                        direction = direction,
                     };
                     InternalUnsafeMethods.SetTransform()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void SetPitch(float pitch) {
        
                                          InternalUnsafeMethods.SetPitch__Args _args = new InternalUnsafeMethods.SetPitch__Args() {
                        pitch = pitch,
                     };
                     InternalUnsafeMethods.SetPitch()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public float GetPitch() {
        
                     InternalUnsafeMethods.GetPitch__Args _args = new InternalUnsafeMethods.GetPitch__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetPitch()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetFadeTimes(float fadeInTime, float fadeOutTime) {
        
                                                               InternalUnsafeMethods.SetFadeTimes__Args _args = new InternalUnsafeMethods.SetFadeTimes__Args() {
                        fadeInTime = fadeInTime,
                        fadeOutTime = fadeOutTime,
                     };
                     InternalUnsafeMethods.SetFadeTimes()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public float GetFadeOutTime() {
        
                     InternalUnsafeMethods.GetFadeOutTime__Args _args = new InternalUnsafeMethods.GetFadeOutTime__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetFadeOutTime()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public float GetFadeInTime() {
        
                     InternalUnsafeMethods.GetFadeInTime__Args _args = new InternalUnsafeMethods.GetFadeInTime__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetFadeInTime()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public float GetAttenuatedVolume() {
        
                     InternalUnsafeMethods.GetAttenuatedVolume__Args _args = new InternalUnsafeMethods.GetAttenuatedVolume__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetAttenuatedVolume()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetVolume(float volume) {
        
                                          InternalUnsafeMethods.SetVolume__Args _args = new InternalUnsafeMethods.SetVolume__Args() {
                        volume = volume,
                     };
                     InternalUnsafeMethods.SetVolume()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public float GetVolume() {
        
                     InternalUnsafeMethods.GetVolume__Args _args = new InternalUnsafeMethods.GetVolume__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetVolume()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public SFXStatus GetStatus() {
        
                     InternalUnsafeMethods.GetStatus__Args _args = new InternalUnsafeMethods.GetStatus__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetStatus()(ObjectPtr, _args);
                                 
                     return (SFXStatus)_engineResult;
                  }
	

			
                  public bool IsStopped() {
        
                     InternalUnsafeMethods.IsStopped__Args _args = new InternalUnsafeMethods.IsStopped__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsStopped()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool IsPaused() {
        
                     InternalUnsafeMethods.IsPaused__Args _args = new InternalUnsafeMethods.IsPaused__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsPaused()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool IsPlaying() {
        
                     InternalUnsafeMethods.IsPlaying__Args _args = new InternalUnsafeMethods.IsPlaying__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsPlaying()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void Pause(float fadeOutTime = -1f) {
        
                                          InternalUnsafeMethods.Pause__Args _args = new InternalUnsafeMethods.Pause__Args() {
                        fadeOutTime = fadeOutTime,
                     };
                     InternalUnsafeMethods.Pause()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void Stop(float fadeOutTime = -1f) {
        
                                          InternalUnsafeMethods.Stop__Args _args = new InternalUnsafeMethods.Stop__Args() {
                        fadeOutTime = fadeOutTime,
                     };
                     InternalUnsafeMethods.Stop()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void Play(float fadeInTime = -1f) {
        
                                          InternalUnsafeMethods.Play__Args _args = new InternalUnsafeMethods.Play__Args() {
                        fadeInTime = fadeInTime,
                     };
                     InternalUnsafeMethods.Play()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnParameterValueChange(SFXParameter parameter) {
        
                                          InternalUnsafeMethods.OnParameterValueChange__Args _args = new InternalUnsafeMethods.OnParameterValueChange__Args() {
                        parameter = parameter.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnParameterValueChange()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnStatusChange(SFXStatus newStatus) {
        
                                          InternalUnsafeMethods.OnStatusChange__Args _args = new InternalUnsafeMethods.OnStatusChange__Args() {
                        newStatus = (int)newStatus,
                     };
                     InternalUnsafeMethods.OnStatusChange()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public SFXDescription Description {
            get => GenericMarshal.StringTo<SFXDescription>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


        public string StatusCallback {
            get => GenericMarshal.StringTo<string>(GetFieldValue("statusCallback"));
            set => SetFieldValue("statusCallback", GenericMarshal.ToString(value));
        }


    }
}