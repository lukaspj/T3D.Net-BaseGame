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

    public unsafe class ScriptMsgListener : SimObject {



        public ScriptMsgListener(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ScriptMsgListener(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ScriptMsgListener(string pName) 
            : this(pName, false) {
        }
        
        public ScriptMsgListener(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ScriptMsgListener(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ScriptMsgListener(SimObject pObj) 
            : base(pObj) {
        }
        
        public ScriptMsgListener(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRemoveFromQueue__Args
                {
				   
				   internal string queue;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRemoveFromQueue(IntPtr _this, string queue);
                internal delegate void _OnRemoveFromQueue(IntPtr _this, OnRemoveFromQueue__Args args);
                private static _OnRemoveFromQueue _OnRemoveFromQueueFunc;
                internal static _OnRemoveFromQueue OnRemoveFromQueue() {
                    if (_OnRemoveFromQueueFunc == null) {
                        _OnRemoveFromQueueFunc =
                            (_OnRemoveFromQueue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onRemoveFromQueue"), typeof(_OnRemoveFromQueue));
                    }
                    
                    return _OnRemoveFromQueueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAddToQueue__Args
                {
				   
				   internal string queue;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAddToQueue(IntPtr _this, string queue);
                internal delegate void _OnAddToQueue(IntPtr _this, OnAddToQueue__Args args);
                private static _OnAddToQueue _OnAddToQueueFunc;
                internal static _OnAddToQueue OnAddToQueue() {
                    if (_OnAddToQueueFunc == null) {
                        _OnAddToQueueFunc =
                            (_OnAddToQueue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onAddToQueue"), typeof(_OnAddToQueue));
                    }
                    
                    return _OnAddToQueueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMessageObjectReceived__Args
                {
				   
				   internal string queue;
				   
				   internal IntPtr msg;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OnMessageObjectReceived(IntPtr _this, string queue, IntPtr msg);
                internal delegate bool _OnMessageObjectReceived(IntPtr _this, OnMessageObjectReceived__Args args);
                private static _OnMessageObjectReceived _OnMessageObjectReceivedFunc;
                internal static _OnMessageObjectReceived OnMessageObjectReceived() {
                    if (_OnMessageObjectReceivedFunc == null) {
                        _OnMessageObjectReceivedFunc =
                            (_OnMessageObjectReceived)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onMessageObjectReceived"), typeof(_OnMessageObjectReceived));
                    }
                    
                    return _OnMessageObjectReceivedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMessageReceived__Args
                {
				   
				   internal string queue;
				   
				   internal string _event;
				   
				   internal string data;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OnMessageReceived(IntPtr _this, string queue, string _event, string data);
                internal delegate bool _OnMessageReceived(IntPtr _this, OnMessageReceived__Args args);
                private static _OnMessageReceived _OnMessageReceivedFunc;
                internal static _OnMessageReceived OnMessageReceived() {
                    if (_OnMessageReceivedFunc == null) {
                        _OnMessageReceivedFunc =
                            (_OnMessageReceived)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onMessageReceived"), typeof(_OnMessageReceived));
                    }
                    
                    return _OnMessageReceivedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRemove__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRemove(IntPtr _this);
                internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
                private static _OnRemove _OnRemoveFunc;
                internal static _OnRemove OnRemove() {
                    if (_OnRemoveFunc == null) {
                        _OnRemoveFunc =
                            (_OnRemove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onRemove"), typeof(_OnRemove));
                    }
                    
                    return _OnRemoveFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAdd__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAdd(IntPtr _this);
                internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
                private static _OnAdd _OnAddFunc;
                internal static _OnAdd OnAdd() {
                    if (_OnAddFunc == null) {
                        _OnAddFunc =
                            (_OnAdd)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbScriptMsgListener_onAdd"), typeof(_OnAdd));
                    }
                    
                    return _OnAddFunc;
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
                                    "fnScriptMsgListener_staticGetType"), typeof(_StaticGetType));
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
                                    "fnScriptMsgListener_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void OnRemoveFromQueue(string queue) {
        
                                          InternalUnsafeMethods.OnRemoveFromQueue__Args _args = new InternalUnsafeMethods.OnRemoveFromQueue__Args() {
                        queue = queue,
                     };
                     InternalUnsafeMethods.OnRemoveFromQueue()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnAddToQueue(string queue) {
        
                                          InternalUnsafeMethods.OnAddToQueue__Args _args = new InternalUnsafeMethods.OnAddToQueue__Args() {
                        queue = queue,
                     };
                     InternalUnsafeMethods.OnAddToQueue()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool OnMessageObjectReceived(string queue, Message msg) {
        
                                                               InternalUnsafeMethods.OnMessageObjectReceived__Args _args = new InternalUnsafeMethods.OnMessageObjectReceived__Args() {
                        queue = queue,
                        msg = msg.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.OnMessageObjectReceived()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool OnMessageReceived(string queue, string _event, string data) {
        
                                                                                    InternalUnsafeMethods.OnMessageReceived__Args _args = new InternalUnsafeMethods.OnMessageReceived__Args() {
                        queue = queue,
                        _event = _event,
                        data = data,
                     };
                     bool _engineResult = InternalUnsafeMethods.OnMessageReceived()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public void OnRemove() {
        
                     InternalUnsafeMethods.OnRemove__Args _args = new InternalUnsafeMethods.OnRemove__Args() {
                     };
                     InternalUnsafeMethods.OnRemove()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnAdd() {
        
                     InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                     };
                     InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





    }
}