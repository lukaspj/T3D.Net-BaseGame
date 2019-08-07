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

    public unsafe class AIPlayer : Player {



        public AIPlayer(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public AIPlayer(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public AIPlayer(string pName) 
            : this(pName, false) {
        }
        
        public AIPlayer(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public AIPlayer(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public AIPlayer(SimObject pObj) 
            : base(pObj) {
        }
        
        public AIPlayer(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAiPose__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetAiPose(IntPtr _this);
                internal delegate int _GetAiPose(IntPtr _this, GetAiPose__Args args);
                private static _GetAiPose _GetAiPoseFunc;
                internal static _GetAiPose GetAiPose() {
                    if (_GetAiPoseFunc == null) {
                        _GetAiPoseFunc =
                            (_GetAiPose)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getAiPose"), typeof(_GetAiPose));
                    }
                    
                    return _GetAiPoseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAiPose__Args
                {
				   
				   internal int pose;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetAiPose(IntPtr _this, int pose);
                internal delegate void _SetAiPose(IntPtr _this, SetAiPose__Args args);
                private static _SetAiPose _SetAiPoseFunc;
                internal static _SetAiPose SetAiPose() {
                    if (_SetAiPoseFunc == null) {
                        _SetAiPoseFunc =
                            (_SetAiPose)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setAiPose"), typeof(_SetAiPose));
                    }
                    
                    return _SetAiPoseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTargetDistance__Args
                {
				   
				   internal IntPtr obj;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool checkEnabled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetTargetDistance(IntPtr _this, IntPtr obj, [MarshalAs(UnmanagedType.I1)]bool checkEnabled);
                internal delegate float _GetTargetDistance(IntPtr _this, GetTargetDistance__Args args);
                private static _GetTargetDistance _GetTargetDistanceFunc;
                internal static _GetTargetDistance GetTargetDistance() {
                    if (_GetTargetDistanceFunc == null) {
                        _GetTargetDistanceFunc =
                            (_GetTargetDistance)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getTargetDistance"), typeof(_GetTargetDistance));
                    }
                    
                    return _GetTargetDistanceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearMoveTriggers__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearMoveTriggers(IntPtr _this);
                internal delegate void _ClearMoveTriggers(IntPtr _this, ClearMoveTriggers__Args args);
                private static _ClearMoveTriggers _ClearMoveTriggersFunc;
                internal static _ClearMoveTriggers ClearMoveTriggers() {
                    if (_ClearMoveTriggersFunc == null) {
                        _ClearMoveTriggersFunc =
                            (_ClearMoveTriggers)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_clearMoveTriggers"), typeof(_ClearMoveTriggers));
                    }
                    
                    return _ClearMoveTriggersFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveTrigger__Args
                {
				   
				   internal uint slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetMoveTrigger(IntPtr _this, uint slot);
                internal delegate bool _GetMoveTrigger(IntPtr _this, GetMoveTrigger__Args args);
                private static _GetMoveTrigger _GetMoveTriggerFunc;
                internal static _GetMoveTrigger GetMoveTrigger() {
                    if (_GetMoveTriggerFunc == null) {
                        _GetMoveTriggerFunc =
                            (_GetMoveTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getMoveTrigger"), typeof(_GetMoveTrigger));
                    }
                    
                    return _GetMoveTriggerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearMoveTrigger__Args
                {
				   
				   internal uint slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearMoveTrigger(IntPtr _this, uint slot);
                internal delegate void _ClearMoveTrigger(IntPtr _this, ClearMoveTrigger__Args args);
                private static _ClearMoveTrigger _ClearMoveTriggerFunc;
                internal static _ClearMoveTrigger ClearMoveTrigger() {
                    if (_ClearMoveTriggerFunc == null) {
                        _ClearMoveTriggerFunc =
                            (_ClearMoveTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_clearMoveTrigger"), typeof(_ClearMoveTrigger));
                    }
                    
                    return _ClearMoveTriggerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMoveTrigger__Args
                {
				   
				   internal uint slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMoveTrigger(IntPtr _this, uint slot);
                internal delegate void _SetMoveTrigger(IntPtr _this, SetMoveTrigger__Args args);
                private static _SetMoveTrigger _SetMoveTriggerFunc;
                internal static _SetMoveTrigger SetMoveTrigger() {
                    if (_SetMoveTriggerFunc == null) {
                        _SetMoveTriggerFunc =
                            (_SetMoveTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setMoveTrigger"), typeof(_SetMoveTrigger));
                    }
                    
                    return _SetMoveTriggerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CheckInFoV__Args
                {
				   
				   internal IntPtr obj;
				   
				   internal float fov;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool checkEnabled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CheckInFoV(IntPtr _this, IntPtr obj, float fov, [MarshalAs(UnmanagedType.I1)]bool checkEnabled);
                internal delegate bool _CheckInFoV(IntPtr _this, CheckInFoV__Args args);
                private static _CheckInFoV _CheckInFoVFunc;
                internal static _CheckInFoV CheckInFoV() {
                    if (_CheckInFoVFunc == null) {
                        _CheckInFoVFunc =
                            (_CheckInFoV)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_checkInFoV"), typeof(_CheckInFoV));
                    }
                    
                    return _CheckInFoVFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CheckInLos__Args
                {
				   
				   internal IntPtr obj;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool useMuzzle;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool checkEnabled;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CheckInLos(IntPtr _this, IntPtr obj, [MarshalAs(UnmanagedType.I1)]bool useMuzzle, [MarshalAs(UnmanagedType.I1)]bool checkEnabled);
                internal delegate bool _CheckInLos(IntPtr _this, CheckInLos__Args args);
                private static _CheckInLos _CheckInLosFunc;
                internal static _CheckInLos CheckInLos() {
                    if (_CheckInLosFunc == null) {
                        _CheckInLosFunc =
                            (_CheckInLos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_checkInLos"), typeof(_CheckInLos));
                    }
                    
                    return _CheckInLosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAimObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetAimObject(IntPtr _this);
                internal delegate int _GetAimObject(IntPtr _this, GetAimObject__Args args);
                private static _GetAimObject _GetAimObjectFunc;
                internal static _GetAimObject GetAimObject() {
                    if (_GetAimObjectFunc == null) {
                        _GetAimObjectFunc =
                            (_GetAimObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getAimObject"), typeof(_GetAimObject));
                    }
                    
                    return _GetAimObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAimObject__Args
                {
				   
				   internal string objName;
				   
				   internal IntPtr offset;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetAimObject(IntPtr _this, string objName, IntPtr offset);
                internal delegate void _SetAimObject(IntPtr _this, SetAimObject__Args args);
                private static _SetAimObject _SetAimObjectFunc;
                internal static _SetAimObject SetAimObject() {
                    if (_SetAimObjectFunc == null) {
                        _SetAimObjectFunc =
                            (_SetAimObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setAimObject"), typeof(_SetAimObject));
                    }
                    
                    return _SetAimObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAimLocation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetAimLocation(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetAimLocation(IntPtr _this, GetAimLocation__Args args);
                private static _GetAimLocation _GetAimLocationFunc;
                internal static _GetAimLocation GetAimLocation() {
                    if (_GetAimLocationFunc == null) {
                        _GetAimLocationFunc =
                            (_GetAimLocation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getAimLocation"), typeof(_GetAimLocation));
                    }
                    
                    return _GetAimLocationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAimLocation__Args
                {
				   
				   internal IntPtr target;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetAimLocation(IntPtr _this, IntPtr target);
                internal delegate void _SetAimLocation(IntPtr _this, SetAimLocation__Args args);
                private static _SetAimLocation _SetAimLocationFunc;
                internal static _SetAimLocation SetAimLocation() {
                    if (_SetAimLocationFunc == null) {
                        _SetAimLocationFunc =
                            (_SetAimLocation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setAimLocation"), typeof(_SetAimLocation));
                    }
                    
                    return _SetAimLocationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveDestination__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetMoveDestination(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetMoveDestination(IntPtr _this, GetMoveDestination__Args args);
                private static _GetMoveDestination _GetMoveDestinationFunc;
                internal static _GetMoveDestination GetMoveDestination() {
                    if (_GetMoveDestinationFunc == null) {
                        _GetMoveDestinationFunc =
                            (_GetMoveDestination)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getMoveDestination"), typeof(_GetMoveDestination));
                    }
                    
                    return _GetMoveDestinationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMoveDestination__Args
                {
				   
				   internal IntPtr goal;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool slowDown;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMoveDestination(IntPtr _this, IntPtr goal, [MarshalAs(UnmanagedType.I1)]bool slowDown);
                internal delegate void _SetMoveDestination(IntPtr _this, SetMoveDestination__Args args);
                private static _SetMoveDestination _SetMoveDestinationFunc;
                internal static _SetMoveDestination SetMoveDestination() {
                    if (_SetMoveDestinationFunc == null) {
                        _SetMoveDestinationFunc =
                            (_SetMoveDestination)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setMoveDestination"), typeof(_SetMoveDestination));
                    }
                    
                    return _SetMoveDestinationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveSpeed__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetMoveSpeed(IntPtr _this);
                internal delegate float _GetMoveSpeed(IntPtr _this, GetMoveSpeed__Args args);
                private static _GetMoveSpeed _GetMoveSpeedFunc;
                internal static _GetMoveSpeed GetMoveSpeed() {
                    if (_GetMoveSpeedFunc == null) {
                        _GetMoveSpeedFunc =
                            (_GetMoveSpeed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getMoveSpeed"), typeof(_GetMoveSpeed));
                    }
                    
                    return _GetMoveSpeedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMoveSpeed__Args
                {
				   
				   internal float speed;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMoveSpeed(IntPtr _this, float speed);
                internal delegate void _SetMoveSpeed(IntPtr _this, SetMoveSpeed__Args args);
                private static _SetMoveSpeed _SetMoveSpeedFunc;
                internal static _SetMoveSpeed SetMoveSpeed() {
                    if (_SetMoveSpeedFunc == null) {
                        _SetMoveSpeedFunc =
                            (_SetMoveSpeed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setMoveSpeed"), typeof(_SetMoveSpeed));
                    }
                    
                    return _SetMoveSpeedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearAim__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearAim(IntPtr _this);
                internal delegate void _ClearAim(IntPtr _this, ClearAim__Args args);
                private static _ClearAim _ClearAimFunc;
                internal static _ClearAim ClearAim() {
                    if (_ClearAimFunc == null) {
                        _ClearAimFunc =
                            (_ClearAim)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_clearAim"), typeof(_ClearAim));
                    }
                    
                    return _ClearAimFunc;
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
                                    "fnAIPlayer_stop"), typeof(_Stop));
                    }
                    
                    return _StopFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetNavSize__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetNavSize(IntPtr _this);
                internal delegate IntPtr _GetNavSize(IntPtr _this, GetNavSize__Args args);
                private static _GetNavSize _GetNavSizeFunc;
                internal static _GetNavSize GetNavSize() {
                    if (_GetNavSizeFunc == null) {
                        _GetNavSizeFunc =
                            (_GetNavSize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getNavSize"), typeof(_GetNavSize));
                    }
                    
                    return _GetNavSizeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetNavSize__Args
                {
				   
				   internal string size;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetNavSize(IntPtr _this, string size);
                internal delegate void _SetNavSize(IntPtr _this, SetNavSize__Args args);
                private static _SetNavSize _SetNavSizeFunc;
                internal static _SetNavSize SetNavSize() {
                    if (_SetNavSizeFunc == null) {
                        _SetNavSizeFunc =
                            (_SetNavSize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setNavSize"), typeof(_SetNavSize));
                    }
                    
                    return _SetNavSizeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetNavMesh__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetNavMesh(IntPtr _this);
                internal delegate int _GetNavMesh(IntPtr _this, GetNavMesh__Args args);
                private static _GetNavMesh _GetNavMeshFunc;
                internal static _GetNavMesh GetNavMesh() {
                    if (_GetNavMeshFunc == null) {
                        _GetNavMeshFunc =
                            (_GetNavMesh)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getNavMesh"), typeof(_GetNavMesh));
                    }
                    
                    return _GetNavMeshFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindNavMesh__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindNavMesh(IntPtr _this);
                internal delegate int _FindNavMesh(IntPtr _this, FindNavMesh__Args args);
                private static _FindNavMesh _FindNavMeshFunc;
                internal static _FindNavMesh FindNavMesh() {
                    if (_FindNavMeshFunc == null) {
                        _FindNavMeshFunc =
                            (_FindNavMesh)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_findNavMesh"), typeof(_FindNavMesh));
                    }
                    
                    return _FindNavMeshFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindCover__Args
                {
				   
				   internal IntPtr from;
				   
				   internal float radius;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindCover(IntPtr _this, IntPtr from, float radius);
                internal delegate int _FindCover(IntPtr _this, FindCover__Args args);
                private static _FindCover _FindCoverFunc;
                internal static _FindCover FindCover() {
                    if (_FindCoverFunc == null) {
                        _FindCoverFunc =
                            (_FindCover)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_findCover"), typeof(_FindCover));
                    }
                    
                    return _FindCoverFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Repath__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Repath(IntPtr _this);
                internal delegate void _Repath(IntPtr _this, Repath__Args args);
                private static _Repath _RepathFunc;
                internal static _Repath Repath() {
                    if (_RepathFunc == null) {
                        _RepathFunc =
                            (_Repath)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_repath"), typeof(_Repath));
                    }
                    
                    return _RepathFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FollowObject__Args
                {
				   
				   internal uint obj;
				   
				   internal float radius;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FollowObject(IntPtr _this, uint obj, float radius);
                internal delegate void _FollowObject(IntPtr _this, FollowObject__Args args);
                private static _FollowObject _FollowObjectFunc;
                internal static _FollowObject FollowObject() {
                    if (_FollowObjectFunc == null) {
                        _FollowObjectFunc =
                            (_FollowObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_followObject"), typeof(_FollowObject));
                    }
                    
                    return _FollowObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FollowNavPath__Args
                {
				   
				   internal uint obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FollowNavPath(IntPtr _this, uint obj);
                internal delegate void _FollowNavPath(IntPtr _this, FollowNavPath__Args args);
                private static _FollowNavPath _FollowNavPathFunc;
                internal static _FollowNavPath FollowNavPath() {
                    if (_FollowNavPathFunc == null) {
                        _FollowNavPathFunc =
                            (_FollowNavPath)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_followNavPath"), typeof(_FollowNavPath));
                    }
                    
                    return _FollowNavPathFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPathDestination__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetPathDestination(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetPathDestination(IntPtr _this, GetPathDestination__Args args);
                private static _GetPathDestination _GetPathDestinationFunc;
                internal static _GetPathDestination GetPathDestination() {
                    if (_GetPathDestinationFunc == null) {
                        _GetPathDestinationFunc =
                            (_GetPathDestination)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_getPathDestination"), typeof(_GetPathDestination));
                    }
                    
                    return _GetPathDestinationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPathDestination__Args
                {
				   
				   internal IntPtr goal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetPathDestination(IntPtr _this, IntPtr goal);
                internal delegate bool _SetPathDestination(IntPtr _this, SetPathDestination__Args args);
                private static _SetPathDestination _SetPathDestinationFunc;
                internal static _SetPathDestination SetPathDestination() {
                    if (_SetPathDestinationFunc == null) {
                        _SetPathDestinationFunc =
                            (_SetPathDestination)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnAIPlayer_setPathDestination"), typeof(_SetPathDestination));
                    }
                    
                    return _SetPathDestinationFunc;
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
                                    "fnAIPlayer_staticGetType"), typeof(_StaticGetType));
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
                                    "fnAIPlayer_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int GetAiPose() {
        
                     InternalUnsafeMethods.GetAiPose__Args _args = new InternalUnsafeMethods.GetAiPose__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetAiPose()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetAiPose(int pose) {
        
                                          InternalUnsafeMethods.SetAiPose__Args _args = new InternalUnsafeMethods.SetAiPose__Args() {
                        pose = pose,
                     };
                     InternalUnsafeMethods.SetAiPose()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public float GetTargetDistance(ShapeBase obj = null, bool checkEnabled = false) {
        
                                                               InternalUnsafeMethods.GetTargetDistance__Args _args = new InternalUnsafeMethods.GetTargetDistance__Args() {
                        obj = obj.ObjectPtr,
                        checkEnabled = checkEnabled,
                     };
                     float _engineResult = InternalUnsafeMethods.GetTargetDistance()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public void ClearMoveTriggers() {
        
                     InternalUnsafeMethods.ClearMoveTriggers__Args _args = new InternalUnsafeMethods.ClearMoveTriggers__Args() {
                     };
                     InternalUnsafeMethods.ClearMoveTriggers()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool GetMoveTrigger(uint slot) {
        
                                          InternalUnsafeMethods.GetMoveTrigger__Args _args = new InternalUnsafeMethods.GetMoveTrigger__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetMoveTrigger()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void ClearMoveTrigger(uint slot) {
        
                                          InternalUnsafeMethods.ClearMoveTrigger__Args _args = new InternalUnsafeMethods.ClearMoveTrigger__Args() {
                        slot = slot,
                     };
                     InternalUnsafeMethods.ClearMoveTrigger()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetMoveTrigger(uint slot) {
        
                                          InternalUnsafeMethods.SetMoveTrigger__Args _args = new InternalUnsafeMethods.SetMoveTrigger__Args() {
                        slot = slot,
                     };
                     InternalUnsafeMethods.SetMoveTrigger()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool CheckInFoV(ShapeBase obj = null, float fov = 45f, bool checkEnabled = false) {
        
                                                                                    InternalUnsafeMethods.CheckInFoV__Args _args = new InternalUnsafeMethods.CheckInFoV__Args() {
                        obj = obj.ObjectPtr,
                        fov = fov,
                        checkEnabled = checkEnabled,
                     };
                     bool _engineResult = InternalUnsafeMethods.CheckInFoV()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public bool CheckInLos(ShapeBase obj = null, bool useMuzzle = false, bool checkEnabled = false) {
        
                                                                                    InternalUnsafeMethods.CheckInLos__Args _args = new InternalUnsafeMethods.CheckInLos__Args() {
                        obj = obj.ObjectPtr,
                        useMuzzle = useMuzzle,
                        checkEnabled = checkEnabled,
                     };
                     bool _engineResult = InternalUnsafeMethods.CheckInLos()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public int GetAimObject() {
        
                     InternalUnsafeMethods.GetAimObject__Args _args = new InternalUnsafeMethods.GetAimObject__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetAimObject()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetAimObject(string objName, Point3F offset = null) {
        
                                          offset = offset ?? new Point3F("0 0 0");offset.Alloc();                     InternalUnsafeMethods.SetAimObject__Args _args = new InternalUnsafeMethods.SetAimObject__Args() {
                        objName = objName,
                        offset = offset.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetAimObject()(ObjectPtr, _args);
                                                               offset.Free();            
                  }
	

			
                  public Point3F GetAimLocation() {
        
                     InternalUnsafeMethods.GetAimLocation__Args _args = new InternalUnsafeMethods.GetAimLocation__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetAimLocation()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public void SetAimLocation(Point3F target) {
        
                     target.Alloc();                     InternalUnsafeMethods.SetAimLocation__Args _args = new InternalUnsafeMethods.SetAimLocation__Args() {
                        target = target.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetAimLocation()(ObjectPtr, _args);
                                          target.Free();            
                  }
	

			
                  public Point3F GetMoveDestination() {
        
                     InternalUnsafeMethods.GetMoveDestination__Args _args = new InternalUnsafeMethods.GetMoveDestination__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMoveDestination()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public void SetMoveDestination(Point3F goal, bool slowDown = true) {
        
                     goal.Alloc();                                          InternalUnsafeMethods.SetMoveDestination__Args _args = new InternalUnsafeMethods.SetMoveDestination__Args() {
                        goal = goal.internalStructPtr,
                        slowDown = slowDown,
                     };
                     InternalUnsafeMethods.SetMoveDestination()(ObjectPtr, _args);
                                          goal.Free();                                 
                  }
	

			
                  public float GetMoveSpeed() {
        
                     InternalUnsafeMethods.GetMoveSpeed__Args _args = new InternalUnsafeMethods.GetMoveSpeed__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetMoveSpeed()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetMoveSpeed(float speed) {
        
                                          InternalUnsafeMethods.SetMoveSpeed__Args _args = new InternalUnsafeMethods.SetMoveSpeed__Args() {
                        speed = speed,
                     };
                     InternalUnsafeMethods.SetMoveSpeed()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void ClearAim() {
        
                     InternalUnsafeMethods.ClearAim__Args _args = new InternalUnsafeMethods.ClearAim__Args() {
                     };
                     InternalUnsafeMethods.ClearAim()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Stop() {
        
                     InternalUnsafeMethods.Stop__Args _args = new InternalUnsafeMethods.Stop__Args() {
                     };
                     InternalUnsafeMethods.Stop()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetNavSize() {
        
                     InternalUnsafeMethods.GetNavSize__Args _args = new InternalUnsafeMethods.GetNavSize__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetNavSize()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetNavSize(string size) {
        
                                          InternalUnsafeMethods.SetNavSize__Args _args = new InternalUnsafeMethods.SetNavSize__Args() {
                        size = size,
                     };
                     InternalUnsafeMethods.SetNavSize()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetNavMesh() {
        
                     InternalUnsafeMethods.GetNavMesh__Args _args = new InternalUnsafeMethods.GetNavMesh__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetNavMesh()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int FindNavMesh() {
        
                     InternalUnsafeMethods.FindNavMesh__Args _args = new InternalUnsafeMethods.FindNavMesh__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.FindNavMesh()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int FindCover(Point3F from, float radius) {
        
                     from.Alloc();                                          InternalUnsafeMethods.FindCover__Args _args = new InternalUnsafeMethods.FindCover__Args() {
                        from = from.internalStructPtr,
                        radius = radius,
                     };
                     int _engineResult = InternalUnsafeMethods.FindCover()(ObjectPtr, _args);
                                          from.Free();                                 
                     return _engineResult;
                  }
	

			
                  public void Repath() {
        
                     InternalUnsafeMethods.Repath__Args _args = new InternalUnsafeMethods.Repath__Args() {
                     };
                     InternalUnsafeMethods.Repath()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void FollowObject(uint obj, float radius) {
        
                                                               InternalUnsafeMethods.FollowObject__Args _args = new InternalUnsafeMethods.FollowObject__Args() {
                        obj = obj,
                        radius = radius,
                     };
                     InternalUnsafeMethods.FollowObject()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void FollowNavPath(uint obj) {
        
                                          InternalUnsafeMethods.FollowNavPath__Args _args = new InternalUnsafeMethods.FollowNavPath__Args() {
                        obj = obj,
                     };
                     InternalUnsafeMethods.FollowNavPath()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public Point3F GetPathDestination() {
        
                     InternalUnsafeMethods.GetPathDestination__Args _args = new InternalUnsafeMethods.GetPathDestination__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetPathDestination()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public bool SetPathDestination(Point3F goal) {
        
                     goal.Alloc();                     InternalUnsafeMethods.SetPathDestination__Args _args = new InternalUnsafeMethods.SetPathDestination__Args() {
                        goal = goal.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetPathDestination()(ObjectPtr, _args);
                                          goal.Free();            
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public float MMoveTolerance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mMoveTolerance"));
            set => SetFieldValue("mMoveTolerance", GenericMarshal.ToString(value));
        }


        public float MoveStuckTolerance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("moveStuckTolerance"));
            set => SetFieldValue("moveStuckTolerance", GenericMarshal.ToString(value));
        }


        public int MoveStuckTestDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("moveStuckTestDelay"));
            set => SetFieldValue("moveStuckTestDelay", GenericMarshal.ToString(value));
        }


        public float AttackRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("AttackRadius"));
            set => SetFieldValue("AttackRadius", GenericMarshal.ToString(value));
        }


        public bool AllowWalk {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowWalk"));
            set => SetFieldValue("allowWalk", GenericMarshal.ToString(value));
        }


        public bool AllowJump {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowJump"));
            set => SetFieldValue("allowJump", GenericMarshal.ToString(value));
        }


        public bool AllowDrop {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowDrop"));
            set => SetFieldValue("allowDrop", GenericMarshal.ToString(value));
        }


        public bool AllowSwim {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowSwim"));
            set => SetFieldValue("allowSwim", GenericMarshal.ToString(value));
        }


        public bool AllowLedge {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowLedge"));
            set => SetFieldValue("allowLedge", GenericMarshal.ToString(value));
        }


        public bool AllowClimb {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowClimb"));
            set => SetFieldValue("allowClimb", GenericMarshal.ToString(value));
        }


        public bool AllowTeleport {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowTeleport"));
            set => SetFieldValue("allowTeleport", GenericMarshal.ToString(value));
        }


    }
}