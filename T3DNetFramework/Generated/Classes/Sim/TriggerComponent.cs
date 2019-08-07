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

    public unsafe class TriggerComponent : Component {



        public TriggerComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public TriggerComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public TriggerComponent(string pName) 
            : this(pName, false) {
        }
        
        public TriggerComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public TriggerComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public TriggerComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public TriggerComponent(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct VisualizeFrustums__Args
                {
				   
				   internal float renderTime;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _VisualizeFrustums(IntPtr _this, float renderTime);
                internal delegate void _VisualizeFrustums(IntPtr _this, VisualizeFrustums__Args args);
                private static _VisualizeFrustums _VisualizeFrustumsFunc;
                internal static _VisualizeFrustums VisualizeFrustums() {
                    if (_VisualizeFrustumsFunc == null) {
                        _VisualizeFrustumsFunc =
                            (_VisualizeFrustums)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTriggerComponent_visualizeFrustums"), typeof(_VisualizeFrustums));
                    }
                    
                    return _VisualizeFrustumsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveClient__Args
                {
				   
				   internal int clientID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveClient(IntPtr _this, int clientID);
                internal delegate void _RemoveClient(IntPtr _this, RemoveClient__Args args);
                private static _RemoveClient _RemoveClientFunc;
                internal static _RemoveClient RemoveClient() {
                    if (_RemoveClientFunc == null) {
                        _RemoveClientFunc =
                            (_RemoveClient)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTriggerComponent_removeClient"), typeof(_RemoveClient));
                    }
                    
                    return _RemoveClientFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddClient__Args
                {
				   
				   internal int clientID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddClient(IntPtr _this, int clientID);
                internal delegate void _AddClient(IntPtr _this, AddClient__Args args);
                private static _AddClient _AddClientFunc;
                internal static _AddClient AddClient() {
                    if (_AddClientFunc == null) {
                        _AddClientFunc =
                            (_AddClient)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTriggerComponent_addClient"), typeof(_AddClient));
                    }
                    
                    return _AddClientFunc;
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
                                    "fnTriggerComponent_staticGetType"), typeof(_StaticGetType));
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
                                    "fnTriggerComponent_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnUpdateOutOfView__Args
                {
				   
				   internal IntPtr cameraEnt;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnUpdateOutOfView(IntPtr _this, IntPtr cameraEnt);
                internal delegate void _OnUpdateOutOfView(IntPtr _this, OnUpdateOutOfView__Args args);
                private static _OnUpdateOutOfView _OnUpdateOutOfViewFunc;
                internal static _OnUpdateOutOfView OnUpdateOutOfView() {
                    if (_OnUpdateOutOfViewFunc == null) {
                        _OnUpdateOutOfViewFunc =
                            (_OnUpdateOutOfView)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbTriggerComponent_onUpdateOutOfView"), typeof(_OnUpdateOutOfView));
                    }
                    
                    return _OnUpdateOutOfViewFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnUpdateInView__Args
                {
				   
				   internal IntPtr cameraEnt;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnUpdateInView(IntPtr _this, IntPtr cameraEnt);
                internal delegate void _OnUpdateInView(IntPtr _this, OnUpdateInView__Args args);
                private static _OnUpdateInView _OnUpdateInViewFunc;
                internal static _OnUpdateInView OnUpdateInView() {
                    if (_OnUpdateInViewFunc == null) {
                        _OnUpdateInViewFunc =
                            (_OnUpdateInView)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbTriggerComponent_onUpdateInView"), typeof(_OnUpdateInView));
                    }
                    
                    return _OnUpdateInViewFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnExitView__Args
                {
				   
				   internal IntPtr cameraEnt;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnExitView(IntPtr _this, IntPtr cameraEnt);
                internal delegate void _OnExitView(IntPtr _this, OnExitView__Args args);
                private static _OnExitView _OnExitViewFunc;
                internal static _OnExitView OnExitView() {
                    if (_OnExitViewFunc == null) {
                        _OnExitViewFunc =
                            (_OnExitView)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbTriggerComponent_onExitView"), typeof(_OnExitView));
                    }
                    
                    return _OnExitViewFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnEnterView__Args
                {
				   
				   internal IntPtr cameraEnt;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool firstTimeSeeing;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnEnterView(IntPtr _this, IntPtr cameraEnt, [MarshalAs(UnmanagedType.I1)]bool firstTimeSeeing);
                internal delegate void _OnEnterView(IntPtr _this, OnEnterView__Args args);
                private static _OnEnterView _OnEnterViewFunc;
                internal static _OnEnterView OnEnterView() {
                    if (_OnEnterViewFunc == null) {
                        _OnEnterViewFunc =
                            (_OnEnterView)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbTriggerComponent_onEnterView"), typeof(_OnEnterView));
                    }
                    
                    return _OnEnterViewFunc;
                }

        }
        #endregion


			
                  public void VisualizeFrustums(float renderTime = 1000f) {
        
                                          InternalUnsafeMethods.VisualizeFrustums__Args _args = new InternalUnsafeMethods.VisualizeFrustums__Args() {
                        renderTime = renderTime,
                     };
                     InternalUnsafeMethods.VisualizeFrustums()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void RemoveClient(int clientID = -1) {
        
                                          InternalUnsafeMethods.RemoveClient__Args _args = new InternalUnsafeMethods.RemoveClient__Args() {
                        clientID = clientID,
                     };
                     InternalUnsafeMethods.RemoveClient()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddClient(int clientID = -1) {
        
                                          InternalUnsafeMethods.AddClient__Args _args = new InternalUnsafeMethods.AddClient__Args() {
                        clientID = clientID,
                     };
                     InternalUnsafeMethods.AddClient()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	



			
                  public void OnUpdateOutOfView(Entity cameraEnt) {
        
                                          InternalUnsafeMethods.OnUpdateOutOfView__Args _args = new InternalUnsafeMethods.OnUpdateOutOfView__Args() {
                        cameraEnt = cameraEnt.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnUpdateOutOfView()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnUpdateInView(Entity cameraEnt) {
        
                                          InternalUnsafeMethods.OnUpdateInView__Args _args = new InternalUnsafeMethods.OnUpdateInView__Args() {
                        cameraEnt = cameraEnt.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnUpdateInView()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnExitView(Entity cameraEnt) {
        
                                          InternalUnsafeMethods.OnExitView__Args _args = new InternalUnsafeMethods.OnExitView__Args() {
                        cameraEnt = cameraEnt.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnExitView()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnEnterView(Entity cameraEnt, bool firstTimeSeeing) {
        
                                                               InternalUnsafeMethods.OnEnterView__Args _args = new InternalUnsafeMethods.OnEnterView__Args() {
                        cameraEnt = cameraEnt.ObjectPtr,
                        firstTimeSeeing = firstTimeSeeing,
                     };
                     InternalUnsafeMethods.OnEnterView()(ObjectPtr, _args);
                                                                           
                  }
	



        public bool Visibile {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("visibile"));
            set => SetFieldValue("visibile", GenericMarshal.ToString(value));
        }


        public string OnEnterViewCmd {
            get => GenericMarshal.StringTo<string>(GetFieldValue("onEnterViewCmd"));
            set => SetFieldValue("onEnterViewCmd", GenericMarshal.ToString(value));
        }


        public string OnExitViewCmd {
            get => GenericMarshal.StringTo<string>(GetFieldValue("onExitViewCmd"));
            set => SetFieldValue("onExitViewCmd", GenericMarshal.ToString(value));
        }


        public string OnUpdateInViewCmd {
            get => GenericMarshal.StringTo<string>(GetFieldValue("onUpdateInViewCmd"));
            set => SetFieldValue("onUpdateInViewCmd", GenericMarshal.ToString(value));
        }


    }
}