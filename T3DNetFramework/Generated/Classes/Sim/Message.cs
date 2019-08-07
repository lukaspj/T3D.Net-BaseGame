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

    public unsafe class Message : SimObject {



        public Message(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Message(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Message(string pName) 
            : this(pName, false) {
        }
        
        public Message(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Message(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Message(SimObject pObj) 
            : base(pObj) {
        }
        
        public Message(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FreeReference__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FreeReference(IntPtr _this);
                internal delegate void _FreeReference(IntPtr _this, FreeReference__Args args);
                private static _FreeReference _FreeReferenceFunc;
                internal static _FreeReference FreeReference() {
                    if (_FreeReferenceFunc == null) {
                        _FreeReferenceFunc =
                            (_FreeReference)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnMessage_freeReference"), typeof(_FreeReference));
                    }
                    
                    return _FreeReferenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddReference__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddReference(IntPtr _this);
                internal delegate void _AddReference(IntPtr _this, AddReference__Args args);
                private static _AddReference _AddReferenceFunc;
                internal static _AddReference AddReference() {
                    if (_AddReferenceFunc == null) {
                        _AddReferenceFunc =
                            (_AddReference)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnMessage_addReference"), typeof(_AddReference));
                    }
                    
                    return _AddReferenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetType(IntPtr _this);
                internal delegate IntPtr _GetType(IntPtr _this, GetType__Args args);
                private static _GetType _GetTypeFunc;
                internal static _GetType GetType() {
                    if (_GetTypeFunc == null) {
                        _GetTypeFunc =
                            (_GetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnMessage_getType"), typeof(_GetType));
                    }
                    
                    return _GetTypeFunc;
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
                                    "cbMessage_onRemove"), typeof(_OnRemove));
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
                                    "cbMessage_onAdd"), typeof(_OnAdd));
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
                                    "fnMessage_staticGetType"), typeof(_StaticGetType));
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
                                    "fnMessage_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void FreeReference() {
        
                     InternalUnsafeMethods.FreeReference__Args _args = new InternalUnsafeMethods.FreeReference__Args() {
                     };
                     InternalUnsafeMethods.FreeReference()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void AddReference() {
        
                     InternalUnsafeMethods.AddReference__Args _args = new InternalUnsafeMethods.AddReference__Args() {
                     };
                     InternalUnsafeMethods.AddReference()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetType() {
        
                     InternalUnsafeMethods.GetType__Args _args = new InternalUnsafeMethods.GetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetType()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
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