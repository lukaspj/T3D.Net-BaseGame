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

    public unsafe class Player : ShapeBase {



        public Player(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Player(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Player(string pName) 
            : this(pName, false) {
        }
        
        public Player(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Player(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Player(SimObject pObj) 
            : base(pObj) {
        }
        
        public Player(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMovementSpeedBias__Args
                {
				   
				   internal float bias;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMovementSpeedBias(IntPtr _this, float bias);
                internal delegate void _SetMovementSpeedBias(IntPtr _this, SetMovementSpeedBias__Args args);
                private static _SetMovementSpeedBias _SetMovementSpeedBiasFunc;
                internal static _SetMovementSpeedBias SetMovementSpeedBias() {
                    if (_SetMovementSpeedBiasFunc == null) {
                        _SetMovementSpeedBiasFunc =
                            (_SetMovementSpeedBias)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_setMovementSpeedBias"), typeof(_SetMovementSpeedBias));
                    }
                    
                    return _SetMovementSpeedBiasFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CopyHeadRotation__Args
                {
				   
				   internal IntPtr other_player;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CopyHeadRotation(IntPtr _this, IntPtr other_player);
                internal delegate void _CopyHeadRotation(IntPtr _this, CopyHeadRotation__Args args);
                private static _CopyHeadRotation _CopyHeadRotationFunc;
                internal static _CopyHeadRotation CopyHeadRotation() {
                    if (_CopyHeadRotationFunc == null) {
                        _CopyHeadRotationFunc =
                            (_CopyHeadRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_copyHeadRotation"), typeof(_CopyHeadRotation));
                    }
                    
                    return _CopyHeadRotationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLookAnimationOverride__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool flag;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetLookAnimationOverride(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool flag);
                internal delegate void _SetLookAnimationOverride(IntPtr _this, SetLookAnimationOverride__Args args);
                private static _SetLookAnimationOverride _SetLookAnimationOverrideFunc;
                internal static _SetLookAnimationOverride SetLookAnimationOverride() {
                    if (_SetLookAnimationOverrideFunc == null) {
                        _SetLookAnimationOverrideFunc =
                            (_SetLookAnimationOverride)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_setLookAnimationOverride"), typeof(_SetLookAnimationOverride));
                    }
                    
                    return _SetLookAnimationOverrideFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsAnimationLocked__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsAnimationLocked(IntPtr _this);
                internal delegate bool _IsAnimationLocked(IntPtr _this, IsAnimationLocked__Args args);
                private static _IsAnimationLocked _IsAnimationLockedFunc;
                internal static _IsAnimationLocked IsAnimationLocked() {
                    if (_IsAnimationLockedFunc == null) {
                        _IsAnimationLockedFunc =
                            (_IsAnimationLocked)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_isAnimationLocked"), typeof(_IsAnimationLocked));
                    }
                    
                    return _IsAnimationLockedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetNumDeathAnimations__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetNumDeathAnimations(IntPtr _this);
                internal delegate int _GetNumDeathAnimations(IntPtr _this, GetNumDeathAnimations__Args args);
                private static _GetNumDeathAnimations _GetNumDeathAnimationsFunc;
                internal static _GetNumDeathAnimations GetNumDeathAnimations() {
                    if (_GetNumDeathAnimationsFunc == null) {
                        _GetNumDeathAnimationsFunc =
                            (_GetNumDeathAnimations)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_getNumDeathAnimations"), typeof(_GetNumDeathAnimations));
                    }
                    
                    return _GetNumDeathAnimationsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CheckDismountPoint__Args
                {
				   
				   internal IntPtr oldPos;
				   
				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CheckDismountPoint(IntPtr _this, IntPtr oldPos, IntPtr pos);
                internal delegate bool _CheckDismountPoint(IntPtr _this, CheckDismountPoint__Args args);
                private static _CheckDismountPoint _CheckDismountPointFunc;
                internal static _CheckDismountPoint CheckDismountPoint() {
                    if (_CheckDismountPointFunc == null) {
                        _CheckDismountPointFunc =
                            (_CheckDismountPoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_checkDismountPoint"), typeof(_CheckDismountPoint));
                    }
                    
                    return _CheckDismountPointFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearControlObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearControlObject(IntPtr _this);
                internal delegate void _ClearControlObject(IntPtr _this, ClearControlObject__Args args);
                private static _ClearControlObject _ClearControlObjectFunc;
                internal static _ClearControlObject ClearControlObject() {
                    if (_ClearControlObjectFunc == null) {
                        _ClearControlObjectFunc =
                            (_ClearControlObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_clearControlObject"), typeof(_ClearControlObject));
                    }
                    
                    return _ClearControlObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControlObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetControlObject(IntPtr _this);
                internal delegate int _GetControlObject(IntPtr _this, GetControlObject__Args args);
                private static _GetControlObject _GetControlObjectFunc;
                internal static _GetControlObject GetControlObject() {
                    if (_GetControlObjectFunc == null) {
                        _GetControlObjectFunc =
                            (_GetControlObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_getControlObject"), typeof(_GetControlObject));
                    }
                    
                    return _GetControlObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetControlObject__Args
                {
				   
				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetControlObject(IntPtr _this, IntPtr obj);
                internal delegate bool _SetControlObject(IntPtr _this, SetControlObject__Args args);
                private static _SetControlObject _SetControlObjectFunc;
                internal static _SetControlObject SetControlObject() {
                    if (_SetControlObjectFunc == null) {
                        _SetControlObjectFunc =
                            (_SetControlObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_setControlObject"), typeof(_SetControlObject));
                    }
                    
                    return _SetControlObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetActionThread__Args
                {
				   
				   internal string name;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool hold;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool fsp;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetActionThread(IntPtr _this, string name, [MarshalAs(UnmanagedType.I1)]bool hold, [MarshalAs(UnmanagedType.I1)]bool fsp);
                internal delegate bool _SetActionThread(IntPtr _this, SetActionThread__Args args);
                private static _SetActionThread _SetActionThreadFunc;
                internal static _SetActionThread SetActionThread() {
                    if (_SetActionThreadFunc == null) {
                        _SetActionThreadFunc =
                            (_SetActionThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_setActionThread"), typeof(_SetActionThread));
                    }
                    
                    return _SetActionThreadFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetArmThread__Args
                {
				   
				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetArmThread(IntPtr _this, string name);
                internal delegate bool _SetArmThread(IntPtr _this, SetArmThread__Args args);
                private static _SetArmThread _SetArmThreadFunc;
                internal static _SetArmThread SetArmThread() {
                    if (_SetArmThreadFunc == null) {
                        _SetArmThreadFunc =
                            (_SetArmThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_setArmThread"), typeof(_SetArmThread));
                    }
                    
                    return _SetArmThreadFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDamageLocation__Args
                {
				   
				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetDamageLocation(IntPtr _this, IntPtr pos);
                internal delegate IntPtr _GetDamageLocation(IntPtr _this, GetDamageLocation__Args args);
                private static _GetDamageLocation _GetDamageLocationFunc;
                internal static _GetDamageLocation GetDamageLocation() {
                    if (_GetDamageLocationFunc == null) {
                        _GetDamageLocationFunc =
                            (_GetDamageLocation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_getDamageLocation"), typeof(_GetDamageLocation));
                    }
                    
                    return _GetDamageLocationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetState__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetState(IntPtr _this);
                internal delegate IntPtr _GetState(IntPtr _this, GetState__Args args);
                private static _GetState _GetStateFunc;
                internal static _GetState GetState() {
                    if (_GetStateFunc == null) {
                        _GetStateFunc =
                            (_GetState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_getState"), typeof(_GetState));
                    }
                    
                    return _GetStateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowSwimming__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowSwimming(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowSwimming(IntPtr _this, AllowSwimming__Args args);
                private static _AllowSwimming _AllowSwimmingFunc;
                internal static _AllowSwimming AllowSwimming() {
                    if (_AllowSwimmingFunc == null) {
                        _AllowSwimmingFunc =
                            (_AllowSwimming)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowSwimming"), typeof(_AllowSwimming));
                    }
                    
                    return _AllowSwimmingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowProne__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowProne(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowProne(IntPtr _this, AllowProne__Args args);
                private static _AllowProne _AllowProneFunc;
                internal static _AllowProne AllowProne() {
                    if (_AllowProneFunc == null) {
                        _AllowProneFunc =
                            (_AllowProne)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowProne"), typeof(_AllowProne));
                    }
                    
                    return _AllowProneFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowCrouching__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowCrouching(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowCrouching(IntPtr _this, AllowCrouching__Args args);
                private static _AllowCrouching _AllowCrouchingFunc;
                internal static _AllowCrouching AllowCrouching() {
                    if (_AllowCrouchingFunc == null) {
                        _AllowCrouchingFunc =
                            (_AllowCrouching)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowCrouching"), typeof(_AllowCrouching));
                    }
                    
                    return _AllowCrouchingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowSprinting__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowSprinting(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowSprinting(IntPtr _this, AllowSprinting__Args args);
                private static _AllowSprinting _AllowSprintingFunc;
                internal static _AllowSprinting AllowSprinting() {
                    if (_AllowSprintingFunc == null) {
                        _AllowSprintingFunc =
                            (_AllowSprinting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowSprinting"), typeof(_AllowSprinting));
                    }
                    
                    return _AllowSprintingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowJetJumping__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowJetJumping(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowJetJumping(IntPtr _this, AllowJetJumping__Args args);
                private static _AllowJetJumping _AllowJetJumpingFunc;
                internal static _AllowJetJumping AllowJetJumping() {
                    if (_AllowJetJumpingFunc == null) {
                        _AllowJetJumpingFunc =
                            (_AllowJetJumping)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowJetJumping"), typeof(_AllowJetJumping));
                    }
                    
                    return _AllowJetJumpingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowJumping__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowJumping(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _AllowJumping(IntPtr _this, AllowJumping__Args args);
                private static _AllowJumping _AllowJumpingFunc;
                internal static _AllowJumping AllowJumping() {
                    if (_AllowJumpingFunc == null) {
                        _AllowJumpingFunc =
                            (_AllowJumping)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowJumping"), typeof(_AllowJumping));
                    }
                    
                    return _AllowJumpingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AllowAllPoses__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AllowAllPoses(IntPtr _this);
                internal delegate void _AllowAllPoses(IntPtr _this, AllowAllPoses__Args args);
                private static _AllowAllPoses _AllowAllPosesFunc;
                internal static _AllowAllPoses AllowAllPoses() {
                    if (_AllowAllPosesFunc == null) {
                        _AllowAllPosesFunc =
                            (_AllowAllPoses)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_allowAllPoses"), typeof(_AllowAllPoses));
                    }
                    
                    return _AllowAllPosesFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPose__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetPose(IntPtr _this);
                internal delegate IntPtr _GetPose(IntPtr _this, GetPose__Args args);
                private static _GetPose _GetPoseFunc;
                internal static _GetPose GetPose() {
                    if (_GetPoseFunc == null) {
                        _GetPoseFunc =
                            (_GetPose)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnPlayer_getPose"), typeof(_GetPose));
                    }
                    
                    return _GetPoseFunc;
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
                                    "fnPlayer_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPlayer_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void SetMovementSpeedBias(float bias) {
        
                                          InternalUnsafeMethods.SetMovementSpeedBias__Args _args = new InternalUnsafeMethods.SetMovementSpeedBias__Args() {
                        bias = bias,
                     };
                     InternalUnsafeMethods.SetMovementSpeedBias()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void CopyHeadRotation(Player other_player) {
        
                                          InternalUnsafeMethods.CopyHeadRotation__Args _args = new InternalUnsafeMethods.CopyHeadRotation__Args() {
                        other_player = other_player.ObjectPtr,
                     };
                     InternalUnsafeMethods.CopyHeadRotation()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetLookAnimationOverride(bool flag) {
        
                                          InternalUnsafeMethods.SetLookAnimationOverride__Args _args = new InternalUnsafeMethods.SetLookAnimationOverride__Args() {
                        flag = flag,
                     };
                     InternalUnsafeMethods.SetLookAnimationOverride()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool IsAnimationLocked() {
        
                     InternalUnsafeMethods.IsAnimationLocked__Args _args = new InternalUnsafeMethods.IsAnimationLocked__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsAnimationLocked()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetNumDeathAnimations() {
        
                     InternalUnsafeMethods.GetNumDeathAnimations__Args _args = new InternalUnsafeMethods.GetNumDeathAnimations__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetNumDeathAnimations()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool CheckDismountPoint(Point3F oldPos, Point3F pos) {
        
                     oldPos.Alloc();                     pos.Alloc();                     InternalUnsafeMethods.CheckDismountPoint__Args _args = new InternalUnsafeMethods.CheckDismountPoint__Args() {
                        oldPos = oldPos.internalStructPtr,
                        pos = pos.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.CheckDismountPoint()(ObjectPtr, _args);
                                          oldPos.Free();                     pos.Free();            
                     return _engineResult;
                  }
	

			
                  public void ClearControlObject() {
        
                     InternalUnsafeMethods.ClearControlObject__Args _args = new InternalUnsafeMethods.ClearControlObject__Args() {
                     };
                     InternalUnsafeMethods.ClearControlObject()(ObjectPtr, _args);
                                 
                  }
	

			
                  public int GetControlObject() {
        
                     InternalUnsafeMethods.GetControlObject__Args _args = new InternalUnsafeMethods.GetControlObject__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetControlObject()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool SetControlObject(ShapeBase obj) {
        
                                          InternalUnsafeMethods.SetControlObject__Args _args = new InternalUnsafeMethods.SetControlObject__Args() {
                        obj = obj.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetControlObject()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool SetActionThread(string name, bool hold = false, bool fsp = true) {
        
                                                                                    InternalUnsafeMethods.SetActionThread__Args _args = new InternalUnsafeMethods.SetActionThread__Args() {
                        name = name,
                        hold = hold,
                        fsp = fsp,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetActionThread()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public bool SetArmThread(string name) {
        
                                          InternalUnsafeMethods.SetArmThread__Args _args = new InternalUnsafeMethods.SetArmThread__Args() {
                        name = name,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetArmThread()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public string GetDamageLocation(Point3F pos) {
        
                     pos.Alloc();                     InternalUnsafeMethods.GetDamageLocation__Args _args = new InternalUnsafeMethods.GetDamageLocation__Args() {
                        pos = pos.internalStructPtr,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetDamageLocation()(ObjectPtr, _args);
                                          pos.Free();            
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public string GetState() {
        
                     InternalUnsafeMethods.GetState__Args _args = new InternalUnsafeMethods.GetState__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetState()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void AllowSwimming(bool state) {
        
                                          InternalUnsafeMethods.AllowSwimming__Args _args = new InternalUnsafeMethods.AllowSwimming__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowSwimming()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowProne(bool state) {
        
                                          InternalUnsafeMethods.AllowProne__Args _args = new InternalUnsafeMethods.AllowProne__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowProne()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowCrouching(bool state) {
        
                                          InternalUnsafeMethods.AllowCrouching__Args _args = new InternalUnsafeMethods.AllowCrouching__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowCrouching()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowSprinting(bool state) {
        
                                          InternalUnsafeMethods.AllowSprinting__Args _args = new InternalUnsafeMethods.AllowSprinting__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowSprinting()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowJetJumping(bool state) {
        
                                          InternalUnsafeMethods.AllowJetJumping__Args _args = new InternalUnsafeMethods.AllowJetJumping__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowJetJumping()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowJumping(bool state) {
        
                                          InternalUnsafeMethods.AllowJumping__Args _args = new InternalUnsafeMethods.AllowJumping__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.AllowJumping()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AllowAllPoses() {
        
                     InternalUnsafeMethods.AllowAllPoses__Args _args = new InternalUnsafeMethods.AllowAllPoses__Args() {
                     };
                     InternalUnsafeMethods.AllowAllPoses()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetPose() {
        
                     InternalUnsafeMethods.GetPose__Args _args = new InternalUnsafeMethods.GetPose__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetPose()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





    }
}