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

namespace T3DSharpFramework.Generated.Classes.Sim.Net {    

    public unsafe class NetConnection : SimGroup {



        public NetConnection(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public NetConnection(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public NetConnection(string pName) 
            : this(pName, false) {
        }
        
        public NetConnection(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public NetConnection(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public NetConnection(SimObject pObj) 
            : base(pObj) {
        }
        
        public NetConnection(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ResolveGhost__Args
                {
				   
				   internal int ghostIndex;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _ResolveGhost(IntPtr _this, int ghostIndex);
                internal delegate int _ResolveGhost(IntPtr _this, ResolveGhost__Args args);
                private static _ResolveGhost _ResolveGhostFunc;
                internal static _ResolveGhost ResolveGhost() {
                    if (_ResolveGhostFunc == null) {
                        _ResolveGhostFunc =
                            (_ResolveGhost)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_ResolveGhost"), typeof(_ResolveGhost));
                    }
                    
                    return _ResolveGhostFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetGhostIndex__Args
                {
				   
				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetGhostIndex(IntPtr _this, IntPtr obj);
                internal delegate int _GetGhostIndex(IntPtr _this, GetGhostIndex__Args args);
                private static _GetGhostIndex _GetGhostIndexFunc;
                internal static _GetGhostIndex GetGhostIndex() {
                    if (_GetGhostIndexFunc == null) {
                        _GetGhostIndexFunc =
                            (_GetGhostIndex)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_GetGhostIndex"), typeof(_GetGhostIndex));
                    }
                    
                    return _GetGhostIndexFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetGhostsActive__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetGhostsActive(IntPtr _this);
                internal delegate int _GetGhostsActive(IntPtr _this, GetGhostsActive__Args args);
                private static _GetGhostsActive _GetGhostsActiveFunc;
                internal static _GetGhostsActive GetGhostsActive() {
                    if (_GetGhostsActiveFunc == null) {
                        _GetGhostsActiveFunc =
                            (_GetGhostsActive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_getGhostsActive"), typeof(_GetGhostsActive));
                    }
                    
                    return _GetGhostsActiveFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ConnectLocal__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _ConnectLocal(IntPtr _this);
                internal delegate IntPtr _ConnectLocal(IntPtr _this, ConnectLocal__Args args);
                private static _ConnectLocal _ConnectLocalFunc;
                internal static _ConnectLocal ConnectLocal() {
                    if (_ConnectLocalFunc == null) {
                        _ConnectLocalFunc =
                            (_ConnectLocal)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_connectLocal"), typeof(_ConnectLocal));
                    }
                    
                    return _ConnectLocalFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Connect__Args
                {
				   
				   internal string remoteAddress;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Connect(IntPtr _this, string remoteAddress);
                internal delegate void _Connect(IntPtr _this, Connect__Args args);
                private static _Connect _ConnectFunc;
                internal static _Connect Connect() {
                    if (_ConnectFunc == null) {
                        _ConnectFunc =
                            (_Connect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_connect"), typeof(_Connect));
                    }
                    
                    return _ConnectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetGhostID__Args
                {
				   
				   internal int realID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetGhostID(IntPtr _this, int realID);
                internal delegate int _GetGhostID(IntPtr _this, GetGhostID__Args args);
                private static _GetGhostID _GetGhostIDFunc;
                internal static _GetGhostID GetGhostID() {
                    if (_GetGhostIDFunc == null) {
                        _GetGhostIDFunc =
                            (_GetGhostID)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_getGhostID"), typeof(_GetGhostID));
                    }
                    
                    return _GetGhostIDFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ResolveObjectFromGhostIndex__Args
                {
				   
				   internal int ghostID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _ResolveObjectFromGhostIndex(IntPtr _this, int ghostID);
                internal delegate int _ResolveObjectFromGhostIndex(IntPtr _this, ResolveObjectFromGhostIndex__Args args);
                private static _ResolveObjectFromGhostIndex _ResolveObjectFromGhostIndexFunc;
                internal static _ResolveObjectFromGhostIndex ResolveObjectFromGhostIndex() {
                    if (_ResolveObjectFromGhostIndexFunc == null) {
                        _ResolveObjectFromGhostIndexFunc =
                            (_ResolveObjectFromGhostIndex)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_resolveObjectFromGhostIndex"), typeof(_ResolveObjectFromGhostIndex));
                    }
                    
                    return _ResolveObjectFromGhostIndexFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ResolveGhostID__Args
                {
				   
				   internal int ghostID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _ResolveGhostID(IntPtr _this, int ghostID);
                internal delegate int _ResolveGhostID(IntPtr _this, ResolveGhostID__Args args);
                private static _ResolveGhostID _ResolveGhostIDFunc;
                internal static _ResolveGhostID ResolveGhostID() {
                    if (_ResolveGhostIDFunc == null) {
                        _ResolveGhostIDFunc =
                            (_ResolveGhostID)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_resolveGhostID"), typeof(_ResolveGhostID));
                    }
                    
                    return _ResolveGhostIDFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CheckMaxRate__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CheckMaxRate(IntPtr _this);
                internal delegate void _CheckMaxRate(IntPtr _this, CheckMaxRate__Args args);
                private static _CheckMaxRate _CheckMaxRateFunc;
                internal static _CheckMaxRate CheckMaxRate() {
                    if (_CheckMaxRateFunc == null) {
                        _CheckMaxRateFunc =
                            (_CheckMaxRate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_checkMaxRate"), typeof(_CheckMaxRate));
                    }
                    
                    return _CheckMaxRateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPacketLoss__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetPacketLoss(IntPtr _this);
                internal delegate int _GetPacketLoss(IntPtr _this, GetPacketLoss__Args args);
                private static _GetPacketLoss _GetPacketLossFunc;
                internal static _GetPacketLoss GetPacketLoss() {
                    if (_GetPacketLossFunc == null) {
                        _GetPacketLossFunc =
                            (_GetPacketLoss)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_getPacketLoss"), typeof(_GetPacketLoss));
                    }
                    
                    return _GetPacketLossFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPing__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetPing(IntPtr _this);
                internal delegate int _GetPing(IntPtr _this, GetPing__Args args);
                private static _GetPing _GetPingFunc;
                internal static _GetPing GetPing() {
                    if (_GetPingFunc == null) {
                        _GetPingFunc =
                            (_GetPing)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_getPing"), typeof(_GetPing));
                    }
                    
                    return _GetPingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSimulatedNetParams__Args
                {
				   
				   internal float packetLoss;
				   
				   internal int delay;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetSimulatedNetParams(IntPtr _this, float packetLoss, int delay);
                internal delegate void _SetSimulatedNetParams(IntPtr _this, SetSimulatedNetParams__Args args);
                private static _SetSimulatedNetParams _SetSimulatedNetParamsFunc;
                internal static _SetSimulatedNetParams SetSimulatedNetParams() {
                    if (_SetSimulatedNetParamsFunc == null) {
                        _SetSimulatedNetParamsFunc =
                            (_SetSimulatedNetParams)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_setSimulatedNetParams"), typeof(_SetSimulatedNetParams));
                    }
                    
                    return _SetSimulatedNetParamsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAddress__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetAddress(IntPtr _this);
                internal delegate IntPtr _GetAddress(IntPtr _this, GetAddress__Args args);
                private static _GetAddress _GetAddressFunc;
                internal static _GetAddress GetAddress() {
                    if (_GetAddressFunc == null) {
                        _GetAddressFunc =
                            (_GetAddress)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_getAddress"), typeof(_GetAddress));
                    }
                    
                    return _GetAddressFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearPaths__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearPaths(IntPtr _this);
                internal delegate void _ClearPaths(IntPtr _this, ClearPaths__Args args);
                private static _ClearPaths _ClearPathsFunc;
                internal static _ClearPaths ClearPaths() {
                    if (_ClearPathsFunc == null) {
                        _ClearPathsFunc =
                            (_ClearPaths)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_clearPaths"), typeof(_ClearPaths));
                    }
                    
                    return _ClearPathsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct TransmitPaths__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _TransmitPaths(IntPtr _this);
                internal delegate void _TransmitPaths(IntPtr _this, TransmitPaths__Args args);
                private static _TransmitPaths _TransmitPathsFunc;
                internal static _TransmitPaths TransmitPaths() {
                    if (_TransmitPathsFunc == null) {
                        _TransmitPathsFunc =
                            (_TransmitPaths)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNetConnection_transmitPaths"), typeof(_TransmitPaths));
                    }
                    
                    return _TransmitPathsFunc;
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
                                    "fnNetConnection_staticGetType"), typeof(_StaticGetType));
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
                                    "fnNetConnection_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int ResolveGhost(int ghostIndex) {
        
                                          InternalUnsafeMethods.ResolveGhost__Args _args = new InternalUnsafeMethods.ResolveGhost__Args() {
                        ghostIndex = ghostIndex,
                     };
                     int _engineResult = InternalUnsafeMethods.ResolveGhost()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetGhostIndex(NetObject obj) {
        
                                          InternalUnsafeMethods.GetGhostIndex__Args _args = new InternalUnsafeMethods.GetGhostIndex__Args() {
                        obj = obj.ObjectPtr,
                     };
                     int _engineResult = InternalUnsafeMethods.GetGhostIndex()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetGhostsActive() {
        
                     InternalUnsafeMethods.GetGhostsActive__Args _args = new InternalUnsafeMethods.GetGhostsActive__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetGhostsActive()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public string ConnectLocal() {
        
                     InternalUnsafeMethods.ConnectLocal__Args _args = new InternalUnsafeMethods.ConnectLocal__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ConnectLocal()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void Connect(string remoteAddress) {
        
                                          InternalUnsafeMethods.Connect__Args _args = new InternalUnsafeMethods.Connect__Args() {
                        remoteAddress = remoteAddress,
                     };
                     InternalUnsafeMethods.Connect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetGhostID(int realID) {
        
                                          InternalUnsafeMethods.GetGhostID__Args _args = new InternalUnsafeMethods.GetGhostID__Args() {
                        realID = realID,
                     };
                     int _engineResult = InternalUnsafeMethods.GetGhostID()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int ResolveObjectFromGhostIndex(int ghostID) {
        
                                          InternalUnsafeMethods.ResolveObjectFromGhostIndex__Args _args = new InternalUnsafeMethods.ResolveObjectFromGhostIndex__Args() {
                        ghostID = ghostID,
                     };
                     int _engineResult = InternalUnsafeMethods.ResolveObjectFromGhostIndex()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int ResolveGhostID(int ghostID) {
        
                                          InternalUnsafeMethods.ResolveGhostID__Args _args = new InternalUnsafeMethods.ResolveGhostID__Args() {
                        ghostID = ghostID,
                     };
                     int _engineResult = InternalUnsafeMethods.ResolveGhostID()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void CheckMaxRate() {
        
                     InternalUnsafeMethods.CheckMaxRate__Args _args = new InternalUnsafeMethods.CheckMaxRate__Args() {
                     };
                     InternalUnsafeMethods.CheckMaxRate()(ObjectPtr, _args);
                                 
                  }
	

			
                  public int GetPacketLoss() {
        
                     InternalUnsafeMethods.GetPacketLoss__Args _args = new InternalUnsafeMethods.GetPacketLoss__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetPacketLoss()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetPing() {
        
                     InternalUnsafeMethods.GetPing__Args _args = new InternalUnsafeMethods.GetPing__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetPing()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetSimulatedNetParams(float packetLoss, int delay) {
        
                                                               InternalUnsafeMethods.SetSimulatedNetParams__Args _args = new InternalUnsafeMethods.SetSimulatedNetParams__Args() {
                        packetLoss = packetLoss,
                        delay = delay,
                     };
                     InternalUnsafeMethods.SetSimulatedNetParams()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public string GetAddress() {
        
                     InternalUnsafeMethods.GetAddress__Args _args = new InternalUnsafeMethods.GetAddress__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetAddress()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void ClearPaths() {
        
                     InternalUnsafeMethods.ClearPaths__Args _args = new InternalUnsafeMethods.ClearPaths__Args() {
                     };
                     InternalUnsafeMethods.ClearPaths()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void TransmitPaths() {
        
                     InternalUnsafeMethods.TransmitPaths__Args _args = new InternalUnsafeMethods.TransmitPaths__Args() {
                     };
                     InternalUnsafeMethods.TransmitPaths()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





    }
}