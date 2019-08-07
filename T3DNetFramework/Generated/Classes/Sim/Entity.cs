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

    public unsafe class Entity : GameBase {



        public Entity(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Entity(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Entity(string pName) 
            : this(pName, false) {
        }
        
        public Entity(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Entity(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Entity(SimObject pObj) 
            : base(pObj) {
        }
        
        public Entity(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Notify__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string signalFunction;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string argA;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string argB;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string argC;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string argD;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string argE;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Notify(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string signalFunction, [MarshalAs(UnmanagedType.LPUTF8Str)]string argA, [MarshalAs(UnmanagedType.LPUTF8Str)]string argB, [MarshalAs(UnmanagedType.LPUTF8Str)]string argC, [MarshalAs(UnmanagedType.LPUTF8Str)]string argD, [MarshalAs(UnmanagedType.LPUTF8Str)]string argE);
                internal delegate void _Notify(IntPtr _this, Notify__Args args);
                private static _Notify _NotifyFunc;
                internal static _Notify Notify() {
                    if (_NotifyFunc == null) {
                        _NotifyFunc =
                            (_Notify)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_notify"), typeof(_Notify));
                    }
                    
                    return _NotifyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RotateTo__Args
                {
				   
				   internal IntPtr lookPosition;
				   
				   internal float degreePerSecond;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RotateTo(IntPtr _this, IntPtr lookPosition, float degreePerSecond);
                internal delegate void _RotateTo(IntPtr _this, RotateTo__Args args);
                private static _RotateTo _RotateToFunc;
                internal static _RotateTo RotateTo() {
                    if (_RotateToFunc == null) {
                        _RotateToFunc =
                            (_RotateTo)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_rotateTo"), typeof(_RotateTo));
                    }
                    
                    return _RotateToFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct LookAt__Args
                {
				   
				   internal IntPtr lookPosition;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _LookAt(IntPtr _this, IntPtr lookPosition);
                internal delegate void _LookAt(IntPtr _this, LookAt__Args args);
                private static _LookAt _LookAtFunc;
                internal static _LookAt LookAt() {
                    if (_LookAtFunc == null) {
                        _LookAtFunc =
                            (_LookAt)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_lookAt"), typeof(_LookAt));
                    }
                    
                    return _LookAtFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetForwardVector__Args
                {
				   
				   internal IntPtr newForward;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetForwardVector(IntPtr _this, IntPtr newForward);
                internal delegate void _SetForwardVector(IntPtr _this, SetForwardVector__Args args);
                private static _SetForwardVector _SetForwardVectorFunc;
                internal static _SetForwardVector SetForwardVector() {
                    if (_SetForwardVectorFunc == null) {
                        _SetForwardVectorFunc =
                            (_SetForwardVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_setForwardVector"), typeof(_SetForwardVector));
                    }
                    
                    return _SetForwardVectorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetForwardVector__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetForwardVector(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetForwardVector(IntPtr _this, GetForwardVector__Args args);
                private static _GetForwardVector _GetForwardVectorFunc;
                internal static _GetForwardVector GetForwardVector() {
                    if (_GetForwardVectorFunc == null) {
                        _GetForwardVectorFunc =
                            (_GetForwardVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getForwardVector"), typeof(_GetForwardVector));
                    }
                    
                    return _GetForwardVectorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveTrigger__Args
                {
				   
				   internal int triggerNum;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetMoveTrigger(IntPtr _this, int triggerNum);
                internal delegate bool _GetMoveTrigger(IntPtr _this, GetMoveTrigger__Args args);
                private static _GetMoveTrigger _GetMoveTriggerFunc;
                internal static _GetMoveTrigger GetMoveTrigger() {
                    if (_GetMoveTriggerFunc == null) {
                        _GetMoveTriggerFunc =
                            (_GetMoveTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getMoveTrigger"), typeof(_GetMoveTrigger));
                    }
                    
                    return _GetMoveTriggerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveRotation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetMoveRotation(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetMoveRotation(IntPtr _this, GetMoveRotation__Args args);
                private static _GetMoveRotation _GetMoveRotationFunc;
                internal static _GetMoveRotation GetMoveRotation() {
                    if (_GetMoveRotationFunc == null) {
                        _GetMoveRotationFunc =
                            (_GetMoveRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getMoveRotation"), typeof(_GetMoveRotation));
                    }
                    
                    return _GetMoveRotationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMoveVector__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point3F.InternalStruct _GetMoveVector(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetMoveVector(IntPtr _this, GetMoveVector__Args args);
                private static _GetMoveVector _GetMoveVectorFunc;
                internal static _GetMoveVector GetMoveVector() {
                    if (_GetMoveVectorFunc == null) {
                        _GetMoveVectorFunc =
                            (_GetMoveVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getMoveVector"), typeof(_GetMoveVector));
                    }
                    
                    return _GetMoveVectorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetComponentDirty__Args
                {
				   
				   internal int componentID;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool forceUpdate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetComponentDirty(IntPtr _this, int componentID, [MarshalAs(UnmanagedType.I1)]bool forceUpdate);
                internal delegate void _SetComponentDirty(IntPtr _this, SetComponentDirty__Args args);
                private static _SetComponentDirty _SetComponentDirtyFunc;
                internal static _SetComponentDirty SetComponentDirty() {
                    if (_SetComponentDirtyFunc == null) {
                        _SetComponentDirtyFunc =
                            (_SetComponentDirty)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_setComponentDirty"), typeof(_SetComponentDirty));
                    }
                    
                    return _SetComponentDirtyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetComponentCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetComponentCount(IntPtr _this);
                internal delegate int _GetComponentCount(IntPtr _this, GetComponentCount__Args args);
                private static _GetComponentCount _GetComponentCountFunc;
                internal static _GetComponentCount GetComponentCount() {
                    if (_GetComponentCountFunc == null) {
                        _GetComponentCountFunc =
                            (_GetComponentCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getComponentCount"), typeof(_GetComponentCount));
                    }
                    
                    return _GetComponentCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetComponent__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string componentName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetComponent(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string componentName);
                internal delegate IntPtr _GetComponent(IntPtr _this, GetComponent__Args args);
                private static _GetComponent _GetComponentFunc;
                internal static _GetComponent GetComponent() {
                    if (_GetComponentFunc == null) {
                        _GetComponentFunc =
                            (_GetComponent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getComponent"), typeof(_GetComponent));
                    }
                    
                    return _GetComponentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetComponentByIndex__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetComponentByIndex(IntPtr _this, int index);
                internal delegate IntPtr _GetComponentByIndex(IntPtr _this, GetComponentByIndex__Args args);
                private static _GetComponentByIndex _GetComponentByIndexFunc;
                internal static _GetComponentByIndex GetComponentByIndex() {
                    if (_GetComponentByIndexFunc == null) {
                        _GetComponentByIndexFunc =
                            (_GetComponentByIndex)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getComponentByIndex"), typeof(_GetComponentByIndex));
                    }
                    
                    return _GetComponentByIndexFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearComponents__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearComponents(IntPtr _this);
                internal delegate void _ClearComponents(IntPtr _this, ClearComponents__Args args);
                private static _ClearComponents _ClearComponentsFunc;
                internal static _ClearComponents ClearComponents() {
                    if (_ClearComponentsFunc == null) {
                        _ClearComponentsFunc =
                            (_ClearComponents)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_clearComponents"), typeof(_ClearComponents));
                    }
                    
                    return _ClearComponentsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveComponent__Args
                {
				   
				   internal IntPtr comp;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool deleteComponent;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _RemoveComponent(IntPtr _this, IntPtr comp, [MarshalAs(UnmanagedType.I1)]bool deleteComponent);
                internal delegate bool _RemoveComponent(IntPtr _this, RemoveComponent__Args args);
                private static _RemoveComponent _RemoveComponentFunc;
                internal static _RemoveComponent RemoveComponent() {
                    if (_RemoveComponentFunc == null) {
                        _RemoveComponentFunc =
                            (_RemoveComponent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_removeComponent"), typeof(_RemoveComponent));
                    }
                    
                    return _RemoveComponentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddComponent__Args
                {
				   
				   internal IntPtr comp;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _AddComponent(IntPtr _this, IntPtr comp);
                internal delegate bool _AddComponent(IntPtr _this, AddComponent__Args args);
                private static _AddComponent _AddComponentFunc;
                internal static _AddComponent AddComponent() {
                    if (_AddComponentFunc == null) {
                        _AddComponentFunc =
                            (_AddComponent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_addComponent"), typeof(_AddComponent));
                    }
                    
                    return _AddComponentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetBox__Args
                {
				   
				   internal IntPtr box;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetBox(IntPtr _this, IntPtr box);
                internal delegate void _SetBox(IntPtr _this, SetBox__Args args);
                private static _SetBox _SetBoxFunc;
                internal static _SetBox SetBox() {
                    if (_SetBoxFunc == null) {
                        _SetBoxFunc =
                            (_SetBox)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_setBox"), typeof(_SetBox));
                    }
                    
                    return _SetBoxFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountTransform__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate TransformF.InternalStruct _GetMountTransform(IntPtr _this);
                internal delegate TransformF.InternalStruct _GetMountTransform(IntPtr _this, GetMountTransform__Args args);
                private static _GetMountTransform _GetMountTransformFunc;
                internal static _GetMountTransform GetMountTransform() {
                    if (_GetMountTransformFunc == null) {
                        _GetMountTransformFunc =
                            (_GetMountTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_getMountTransform"), typeof(_GetMountTransform));
                    }
                    
                    return _GetMountTransformFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountRotation__Args
                {
				   
				   internal IntPtr rotOffset;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountRotation(IntPtr _this, IntPtr rotOffset);
                internal delegate void _SetMountRotation(IntPtr _this, SetMountRotation__Args args);
                private static _SetMountRotation _SetMountRotationFunc;
                internal static _SetMountRotation SetMountRotation() {
                    if (_SetMountRotationFunc == null) {
                        _SetMountRotationFunc =
                            (_SetMountRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_setMountRotation"), typeof(_SetMountRotation));
                    }
                    
                    return _SetMountRotationFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountOffset__Args
                {
				   
				   internal IntPtr posOffset;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountOffset(IntPtr _this, IntPtr posOffset);
                internal delegate void _SetMountOffset(IntPtr _this, SetMountOffset__Args args);
                private static _SetMountOffset _SetMountOffsetFunc;
                internal static _SetMountOffset SetMountOffset() {
                    if (_SetMountOffsetFunc == null) {
                        _SetMountOffsetFunc =
                            (_SetMountOffset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_setMountOffset"), typeof(_SetMountOffset));
                    }
                    
                    return _SetMountOffsetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MountObject__Args
                {
				   
				   internal IntPtr objB;
				   
				   internal IntPtr txfm;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _MountObject(IntPtr _this, IntPtr objB, IntPtr txfm);
                internal delegate bool _MountObject(IntPtr _this, MountObject__Args args);
                private static _MountObject _MountObjectFunc;
                internal static _MountObject MountObject() {
                    if (_MountObjectFunc == null) {
                        _MountObjectFunc =
                            (_MountObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnEntity_mountObject"), typeof(_MountObject));
                    }
                    
                    return _MountObjectFunc;
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
                                    "fnEntity_staticGetType"), typeof(_StaticGetType));
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
                                    "fnEntity_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void Notify(string signalFunction = "", string argA = "", string argB = "", string argC = "", string argD = "", string argE = "") {
        
                                                                                                                                                   InternalUnsafeMethods.Notify__Args _args = new InternalUnsafeMethods.Notify__Args() {
                        signalFunction = signalFunction,
                        argA = argA,
                        argB = argB,
                        argC = argC,
                        argD = argD,
                        argE = argE,
                     };
                     InternalUnsafeMethods.Notify()(ObjectPtr, _args);
                                                                                                                                                               
                  }
	

			
                  public void RotateTo(Point3F lookPosition, float degreePerSecond = 1f) {
        
                     lookPosition.Alloc();                                          InternalUnsafeMethods.RotateTo__Args _args = new InternalUnsafeMethods.RotateTo__Args() {
                        lookPosition = lookPosition.internalStructPtr,
                        degreePerSecond = degreePerSecond,
                     };
                     InternalUnsafeMethods.RotateTo()(ObjectPtr, _args);
                                          lookPosition.Free();                                 
                  }
	

			
                  public void LookAt(Point3F lookPosition) {
        
                     lookPosition.Alloc();                     InternalUnsafeMethods.LookAt__Args _args = new InternalUnsafeMethods.LookAt__Args() {
                        lookPosition = lookPosition.internalStructPtr,
                     };
                     InternalUnsafeMethods.LookAt()(ObjectPtr, _args);
                                          lookPosition.Free();            
                  }
	

			
                  public void SetForwardVector(Point3F newForward = null) {
        
                     newForward = newForward ?? new Point3F("0 0 0");newForward.Alloc();                     InternalUnsafeMethods.SetForwardVector__Args _args = new InternalUnsafeMethods.SetForwardVector__Args() {
                        newForward = newForward.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetForwardVector()(ObjectPtr, _args);
                                          newForward.Free();            
                  }
	

			
                  public Point3F GetForwardVector() {
        
                     InternalUnsafeMethods.GetForwardVector__Args _args = new InternalUnsafeMethods.GetForwardVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetForwardVector()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public bool GetMoveTrigger(int triggerNum = 0) {
        
                                          InternalUnsafeMethods.GetMoveTrigger__Args _args = new InternalUnsafeMethods.GetMoveTrigger__Args() {
                        triggerNum = triggerNum,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetMoveTrigger()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public Point3F GetMoveRotation() {
        
                     InternalUnsafeMethods.GetMoveRotation__Args _args = new InternalUnsafeMethods.GetMoveRotation__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMoveRotation()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public Point3F GetMoveVector() {
        
                     InternalUnsafeMethods.GetMoveVector__Args _args = new InternalUnsafeMethods.GetMoveVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMoveVector()(ObjectPtr, _args);
                                 
                     return new Point3F(_engineResult);
                  }
	

			
                  public void SetComponentDirty(int componentID = 0, bool forceUpdate = false) {
        
                                                               InternalUnsafeMethods.SetComponentDirty__Args _args = new InternalUnsafeMethods.SetComponentDirty__Args() {
                        componentID = componentID,
                        forceUpdate = forceUpdate,
                     };
                     InternalUnsafeMethods.SetComponentDirty()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public int GetComponentCount() {
        
                     InternalUnsafeMethods.GetComponentCount__Args _args = new InternalUnsafeMethods.GetComponentCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetComponentCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public Component GetComponent(string componentName = "") {
        
                                          InternalUnsafeMethods.GetComponent__Args _args = new InternalUnsafeMethods.GetComponent__Args() {
                        componentName = componentName,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetComponent()(ObjectPtr, _args);
                                                      
                     return new Component(_engineResult);
                  }
	

			
                  public Component GetComponentByIndex(int index) {
        
                                          InternalUnsafeMethods.GetComponentByIndex__Args _args = new InternalUnsafeMethods.GetComponentByIndex__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetComponentByIndex()(ObjectPtr, _args);
                                                      
                     return new Component(_engineResult);
                  }
	

			
                  public void ClearComponents() {
        
                     InternalUnsafeMethods.ClearComponents__Args _args = new InternalUnsafeMethods.ClearComponents__Args() {
                     };
                     InternalUnsafeMethods.ClearComponents()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool RemoveComponent(Component comp, bool deleteComponent = true) {
        
                                                               InternalUnsafeMethods.RemoveComponent__Args _args = new InternalUnsafeMethods.RemoveComponent__Args() {
                        comp = comp.ObjectPtr,
                        deleteComponent = deleteComponent,
                     };
                     bool _engineResult = InternalUnsafeMethods.RemoveComponent()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool AddComponent(Component comp) {
        
                                          InternalUnsafeMethods.AddComponent__Args _args = new InternalUnsafeMethods.AddComponent__Args() {
                        comp = comp.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.AddComponent()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetBox(Point3F box = null) {
        
                     box = box ?? new Point3F("1 1 1");box.Alloc();                     InternalUnsafeMethods.SetBox__Args _args = new InternalUnsafeMethods.SetBox__Args() {
                        box = box.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetBox()(ObjectPtr, _args);
                                          box.Free();            
                  }
	

			
                  public TransformF GetMountTransform() {
        
                     InternalUnsafeMethods.GetMountTransform__Args _args = new InternalUnsafeMethods.GetMountTransform__Args() {
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetMountTransform()(ObjectPtr, _args);
                                 
                     return new TransformF(_engineResult);
                  }
	

			
                  public void SetMountRotation(Point3F rotOffset = null) {
        
                     rotOffset = rotOffset ?? new Point3F("0 0 0");rotOffset.Alloc();                     InternalUnsafeMethods.SetMountRotation__Args _args = new InternalUnsafeMethods.SetMountRotation__Args() {
                        rotOffset = rotOffset.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetMountRotation()(ObjectPtr, _args);
                                          rotOffset.Free();            
                  }
	

			
                  public void SetMountOffset(Point3F posOffset = null) {
        
                     posOffset = posOffset ?? new Point3F("0 0 0");posOffset.Alloc();                     InternalUnsafeMethods.SetMountOffset__Args _args = new InternalUnsafeMethods.SetMountOffset__Args() {
                        posOffset = posOffset.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetMountOffset()(ObjectPtr, _args);
                                          posOffset.Free();            
                  }
	

			
                  public bool MountObject(SceneObject objB, TransformF txfm = null) {
        
                                          txfm = txfm ?? new TransformF("0 0 0 1 0 0 0 true");txfm.Alloc();                     InternalUnsafeMethods.MountObject__Args _args = new InternalUnsafeMethods.MountObject__Args() {
                        objB = objB.ObjectPtr,
                        txfm = txfm.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.MountObject()(ObjectPtr, _args);
                                                               txfm.Free();            
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public MatrixF LocalPosition {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("LocalPosition"));
            set => SetFieldValue("LocalPosition", GenericMarshal.ToString(value));
        }


        public MatrixF LocalRotation {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("LocalRotation"));
            set => SetFieldValue("LocalRotation", GenericMarshal.ToString(value));
        }


        public int LifetimeMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lifetimeMS"));
            set => SetFieldValue("lifetimeMS", GenericMarshal.ToString(value));
        }


        public IntPtr GameObjectName {
            get => GenericMarshal.StringTo<IntPtr>(GetFieldValue("gameObjectName"));
            set => SetFieldValue("gameObjectName", GenericMarshal.ToString(value));
        }


    }
}