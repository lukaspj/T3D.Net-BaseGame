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

    public unsafe class GuiObjectView : GuiTSCtrl {



        public GuiObjectView(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiObjectView(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiObjectView(string pName) 
            : this(pName, false) {
        }
        
        public GuiObjectView(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiObjectView(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiObjectView(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiObjectView(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLightDirection__Args
                {
				   
				   internal IntPtr direction;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetLightDirection(IntPtr _this, IntPtr direction);
                internal delegate void _SetLightDirection(IntPtr _this, SetLightDirection__Args args);
                private static _SetLightDirection _SetLightDirectionFunc;
                internal static _SetLightDirection SetLightDirection() {
                    if (_SetLightDirectionFunc == null) {
                        _SetLightDirectionFunc =
                            (_SetLightDirection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setLightDirection"), typeof(_SetLightDirection));
                    }
                    
                    return _SetLightDirectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLightAmbient__Args
                {
				   
				   internal IntPtr color;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetLightAmbient(IntPtr _this, IntPtr color);
                internal delegate void _SetLightAmbient(IntPtr _this, SetLightAmbient__Args args);
                private static _SetLightAmbient _SetLightAmbientFunc;
                internal static _SetLightAmbient SetLightAmbient() {
                    if (_SetLightAmbientFunc == null) {
                        _SetLightAmbientFunc =
                            (_SetLightAmbient)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setLightAmbient"), typeof(_SetLightAmbient));
                    }
                    
                    return _SetLightAmbientFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLightColor__Args
                {
				   
				   internal IntPtr color;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetLightColor(IntPtr _this, IntPtr color);
                internal delegate void _SetLightColor(IntPtr _this, SetLightColor__Args args);
                private static _SetLightColor _SetLightColorFunc;
                internal static _SetLightColor SetLightColor() {
                    if (_SetLightColorFunc == null) {
                        _SetLightColorFunc =
                            (_SetLightColor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setLightColor"), typeof(_SetLightColor));
                    }
                    
                    return _SetLightColorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCameraSpeed__Args
                {
				   
				   internal float factor;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCameraSpeed(IntPtr _this, float factor);
                internal delegate void _SetCameraSpeed(IntPtr _this, SetCameraSpeed__Args args);
                private static _SetCameraSpeed _SetCameraSpeedFunc;
                internal static _SetCameraSpeed SetCameraSpeed() {
                    if (_SetCameraSpeedFunc == null) {
                        _SetCameraSpeedFunc =
                            (_SetCameraSpeed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setCameraSpeed"), typeof(_SetCameraSpeed));
                    }
                    
                    return _SetCameraSpeedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCameraSpeed__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetCameraSpeed(IntPtr _this);
                internal delegate float _GetCameraSpeed(IntPtr _this, GetCameraSpeed__Args args);
                private static _GetCameraSpeed _GetCameraSpeedFunc;
                internal static _GetCameraSpeed GetCameraSpeed() {
                    if (_GetCameraSpeedFunc == null) {
                        _GetCameraSpeedFunc =
                            (_GetCameraSpeed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getCameraSpeed"), typeof(_GetCameraSpeed));
                    }
                    
                    return _GetCameraSpeedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetOrbitDistance__Args
                {
				   
				   internal float distance;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetOrbitDistance(IntPtr _this, float distance);
                internal delegate void _SetOrbitDistance(IntPtr _this, SetOrbitDistance__Args args);
                private static _SetOrbitDistance _SetOrbitDistanceFunc;
                internal static _SetOrbitDistance SetOrbitDistance() {
                    if (_SetOrbitDistanceFunc == null) {
                        _SetOrbitDistanceFunc =
                            (_SetOrbitDistance)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setOrbitDistance"), typeof(_SetOrbitDistance));
                    }
                    
                    return _SetOrbitDistanceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetOrbitDistance__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetOrbitDistance(IntPtr _this);
                internal delegate float _GetOrbitDistance(IntPtr _this, GetOrbitDistance__Args args);
                private static _GetOrbitDistance _GetOrbitDistanceFunc;
                internal static _GetOrbitDistance GetOrbitDistance() {
                    if (_GetOrbitDistanceFunc == null) {
                        _GetOrbitDistanceFunc =
                            (_GetOrbitDistance)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getOrbitDistance"), typeof(_GetOrbitDistance));
                    }
                    
                    return _GetOrbitDistanceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMount__Args
                {
				   
				   internal string shapeName;
				   
				   internal string mountNodeIndexOrName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMount(IntPtr _this, string shapeName, string mountNodeIndexOrName);
                internal delegate void _SetMount(IntPtr _this, SetMount__Args args);
                private static _SetMount _SetMountFunc;
                internal static _SetMount SetMount() {
                    if (_SetMountFunc == null) {
                        _SetMountFunc =
                            (_SetMount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setMount"), typeof(_SetMount));
                    }
                    
                    return _SetMountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSeq__Args
                {
				   
				   internal string indexOrName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetSeq(IntPtr _this, string indexOrName);
                internal delegate void _SetSeq(IntPtr _this, SetSeq__Args args);
                private static _SetSeq _SetSeqFunc;
                internal static _SetSeq SetSeq() {
                    if (_SetSeqFunc == null) {
                        _SetSeqFunc =
                            (_SetSeq)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setSeq"), typeof(_SetSeq));
                    }
                    
                    return _SetSeqFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountSkin__Args
                {
				   
				   internal string skinName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountSkin(IntPtr _this, string skinName);
                internal delegate void _SetMountSkin(IntPtr _this, SetMountSkin__Args args);
                private static _SetMountSkin _SetMountSkinFunc;
                internal static _SetMountSkin SetMountSkin() {
                    if (_SetMountSkinFunc == null) {
                        _SetMountSkinFunc =
                            (_SetMountSkin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setMountSkin"), typeof(_SetMountSkin));
                    }
                    
                    return _SetMountSkinFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountSkin__Args
                {
				   
				   internal int param1;
				   
				   internal int param2;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetMountSkin(IntPtr _this, int param1, int param2);
                internal delegate IntPtr _GetMountSkin(IntPtr _this, GetMountSkin__Args args);
                private static _GetMountSkin _GetMountSkinFunc;
                internal static _GetMountSkin GetMountSkin() {
                    if (_GetMountSkinFunc == null) {
                        _GetMountSkinFunc =
                            (_GetMountSkin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getMountSkin"), typeof(_GetMountSkin));
                    }
                    
                    return _GetMountSkinFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSkin__Args
                {
				   
				   internal string skinName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetSkin(IntPtr _this, string skinName);
                internal delegate void _SetSkin(IntPtr _this, SetSkin__Args args);
                private static _SetSkin _SetSkinFunc;
                internal static _SetSkin SetSkin() {
                    if (_SetSkinFunc == null) {
                        _SetSkinFunc =
                            (_SetSkin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setSkin"), typeof(_SetSkin));
                    }
                    
                    return _SetSkinFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSkin__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSkin(IntPtr _this);
                internal delegate IntPtr _GetSkin(IntPtr _this, GetSkin__Args args);
                private static _GetSkin _GetSkinFunc;
                internal static _GetSkin GetSkin() {
                    if (_GetSkinFunc == null) {
                        _GetSkinFunc =
                            (_GetSkin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getSkin"), typeof(_GetSkin));
                    }
                    
                    return _GetSkinFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountedModel__Args
                {
				   
				   internal string shapeName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountedModel(IntPtr _this, string shapeName);
                internal delegate void _SetMountedModel(IntPtr _this, SetMountedModel__Args args);
                private static _SetMountedModel _SetMountedModelFunc;
                internal static _SetMountedModel SetMountedModel() {
                    if (_SetMountedModelFunc == null) {
                        _SetMountedModelFunc =
                            (_SetMountedModel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setMountedModel"), typeof(_SetMountedModel));
                    }
                    
                    return _SetMountedModelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountedModel__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetMountedModel(IntPtr _this);
                internal delegate IntPtr _GetMountedModel(IntPtr _this, GetMountedModel__Args args);
                private static _GetMountedModel _GetMountedModelFunc;
                internal static _GetMountedModel GetMountedModel() {
                    if (_GetMountedModelFunc == null) {
                        _GetMountedModelFunc =
                            (_GetMountedModel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getMountedModel"), typeof(_GetMountedModel));
                    }
                    
                    return _GetMountedModelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetModel__Args
                {
				   
				   internal string shapeName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetModel(IntPtr _this, string shapeName);
                internal delegate void _SetModel(IntPtr _this, SetModel__Args args);
                private static _SetModel _SetModelFunc;
                internal static _SetModel SetModel() {
                    if (_SetModelFunc == null) {
                        _SetModelFunc =
                            (_SetModel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_setModel"), typeof(_SetModel));
                    }
                    
                    return _SetModelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetModel__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetModel(IntPtr _this);
                internal delegate IntPtr _GetModel(IntPtr _this, GetModel__Args args);
                private static _GetModel _GetModelFunc;
                internal static _GetModel GetModel() {
                    if (_GetModelFunc == null) {
                        _GetModelFunc =
                            (_GetModel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiObjectView_getModel"), typeof(_GetModel));
                    }
                    
                    return _GetModelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseLeave__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnMouseLeave(IntPtr _this);
                internal delegate void _OnMouseLeave(IntPtr _this, OnMouseLeave__Args args);
                private static _OnMouseLeave _OnMouseLeaveFunc;
                internal static _OnMouseLeave OnMouseLeave() {
                    if (_OnMouseLeaveFunc == null) {
                        _OnMouseLeaveFunc =
                            (_OnMouseLeave)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiObjectView_onMouseLeave"), typeof(_OnMouseLeave));
                    }
                    
                    return _OnMouseLeaveFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseEnter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnMouseEnter(IntPtr _this);
                internal delegate void _OnMouseEnter(IntPtr _this, OnMouseEnter__Args args);
                private static _OnMouseEnter _OnMouseEnterFunc;
                internal static _OnMouseEnter OnMouseEnter() {
                    if (_OnMouseEnterFunc == null) {
                        _OnMouseEnterFunc =
                            (_OnMouseEnter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiObjectView_onMouseEnter"), typeof(_OnMouseEnter));
                    }
                    
                    return _OnMouseEnterFunc;
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
                                    "fnGuiObjectView_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiObjectView_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void SetLightDirection(Point3F direction) {
        
                     direction.Alloc();                     InternalUnsafeMethods.SetLightDirection__Args _args = new InternalUnsafeMethods.SetLightDirection__Args() {
                        direction = direction.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetLightDirection()(ObjectPtr, _args);
                                          direction.Free();            
                  }
	

			
                  public void SetLightAmbient(LinearColorF color) {
        
                     color.Alloc();                     InternalUnsafeMethods.SetLightAmbient__Args _args = new InternalUnsafeMethods.SetLightAmbient__Args() {
                        color = color.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetLightAmbient()(ObjectPtr, _args);
                                          color.Free();            
                  }
	

			
                  public void SetLightColor(LinearColorF color) {
        
                     color.Alloc();                     InternalUnsafeMethods.SetLightColor__Args _args = new InternalUnsafeMethods.SetLightColor__Args() {
                        color = color.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetLightColor()(ObjectPtr, _args);
                                          color.Free();            
                  }
	

			
                  public void SetCameraSpeed(float factor) {
        
                                          InternalUnsafeMethods.SetCameraSpeed__Args _args = new InternalUnsafeMethods.SetCameraSpeed__Args() {
                        factor = factor,
                     };
                     InternalUnsafeMethods.SetCameraSpeed()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public float GetCameraSpeed() {
        
                     InternalUnsafeMethods.GetCameraSpeed__Args _args = new InternalUnsafeMethods.GetCameraSpeed__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetCameraSpeed()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetOrbitDistance(float distance) {
        
                                          InternalUnsafeMethods.SetOrbitDistance__Args _args = new InternalUnsafeMethods.SetOrbitDistance__Args() {
                        distance = distance,
                     };
                     InternalUnsafeMethods.SetOrbitDistance()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public float GetOrbitDistance() {
        
                     InternalUnsafeMethods.GetOrbitDistance__Args _args = new InternalUnsafeMethods.GetOrbitDistance__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetOrbitDistance()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetMount(string shapeName, string mountNodeIndexOrName) {
        
                                                               InternalUnsafeMethods.SetMount__Args _args = new InternalUnsafeMethods.SetMount__Args() {
                        shapeName = shapeName,
                        mountNodeIndexOrName = mountNodeIndexOrName,
                     };
                     InternalUnsafeMethods.SetMount()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void SetSeq(string indexOrName) {
        
                                          InternalUnsafeMethods.SetSeq__Args _args = new InternalUnsafeMethods.SetSeq__Args() {
                        indexOrName = indexOrName,
                     };
                     InternalUnsafeMethods.SetSeq()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetMountSkin(string skinName) {
        
                                          InternalUnsafeMethods.SetMountSkin__Args _args = new InternalUnsafeMethods.SetMountSkin__Args() {
                        skinName = skinName,
                     };
                     InternalUnsafeMethods.SetMountSkin()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetMountSkin(int param1, int param2) {
        
                                                               InternalUnsafeMethods.GetMountSkin__Args _args = new InternalUnsafeMethods.GetMountSkin__Args() {
                        param1 = param1,
                        param2 = param2,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetMountSkin()(ObjectPtr, _args);
                                                                           
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetSkin(string skinName) {
        
                                          InternalUnsafeMethods.SetSkin__Args _args = new InternalUnsafeMethods.SetSkin__Args() {
                        skinName = skinName,
                     };
                     InternalUnsafeMethods.SetSkin()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetSkin() {
        
                     InternalUnsafeMethods.GetSkin__Args _args = new InternalUnsafeMethods.GetSkin__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSkin()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetMountedModel(string shapeName) {
        
                                          InternalUnsafeMethods.SetMountedModel__Args _args = new InternalUnsafeMethods.SetMountedModel__Args() {
                        shapeName = shapeName,
                     };
                     InternalUnsafeMethods.SetMountedModel()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetMountedModel() {
        
                     InternalUnsafeMethods.GetMountedModel__Args _args = new InternalUnsafeMethods.GetMountedModel__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetMountedModel()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetModel(string shapeName) {
        
                                          InternalUnsafeMethods.SetModel__Args _args = new InternalUnsafeMethods.SetModel__Args() {
                        shapeName = shapeName,
                     };
                     InternalUnsafeMethods.SetModel()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetModel() {
        
                     InternalUnsafeMethods.GetModel__Args _args = new InternalUnsafeMethods.GetModel__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetModel()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void OnMouseLeave() {
        
                     InternalUnsafeMethods.OnMouseLeave__Args _args = new InternalUnsafeMethods.OnMouseLeave__Args() {
                     };
                     InternalUnsafeMethods.OnMouseLeave()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnMouseEnter() {
        
                     InternalUnsafeMethods.OnMouseEnter__Args _args = new InternalUnsafeMethods.OnMouseEnter__Args() {
                     };
                     InternalUnsafeMethods.OnMouseEnter()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }


        public string Skin {
            get => GenericMarshal.StringTo<string>(GetFieldValue("skin"));
            set => SetFieldValue("skin", GenericMarshal.ToString(value));
        }


        public string AnimSequence {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animSequence"));
            set => SetFieldValue("animSequence", GenericMarshal.ToString(value));
        }


        public string MountedShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("mountedShapeFile"));
            set => SetFieldValue("mountedShapeFile", GenericMarshal.ToString(value));
        }


        public string MountedSkin {
            get => GenericMarshal.StringTo<string>(GetFieldValue("mountedSkin"));
            set => SetFieldValue("mountedSkin", GenericMarshal.ToString(value));
        }


        public string MountedNode {
            get => GenericMarshal.StringTo<string>(GetFieldValue("mountedNode"));
            set => SetFieldValue("mountedNode", GenericMarshal.ToString(value));
        }


        public LinearColorF LightColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightColor"));
            set => SetFieldValue("lightColor", GenericMarshal.ToString(value));
        }


        public LinearColorF LightAmbient {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("lightAmbient"));
            set => SetFieldValue("lightAmbient", GenericMarshal.ToString(value));
        }


        public Point3F LightDirection {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("lightDirection"));
            set => SetFieldValue("lightDirection", GenericMarshal.ToString(value));
        }


        public float OrbitDiststance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("orbitDiststance"));
            set => SetFieldValue("orbitDiststance", GenericMarshal.ToString(value));
        }


        public float MinOrbitDiststance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minOrbitDiststance"));
            set => SetFieldValue("minOrbitDiststance", GenericMarshal.ToString(value));
        }


        public float MaxOrbitDiststance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxOrbitDiststance"));
            set => SetFieldValue("maxOrbitDiststance", GenericMarshal.ToString(value));
        }


        public float CameraSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraSpeed"));
            set => SetFieldValue("cameraSpeed", GenericMarshal.ToString(value));
        }


        public Point3F CameraRotation {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("cameraRotation"));
            set => SetFieldValue("cameraRotation", GenericMarshal.ToString(value));
        }


    }
}