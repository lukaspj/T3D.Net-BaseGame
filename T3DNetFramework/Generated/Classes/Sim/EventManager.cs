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
    public unsafe class EventManager : SimObject {
        public EventManager(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public EventManager(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public EventManager(string pName) 
            : this(pName, false) {
        }
        
        public EventManager(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public EventManager(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public EventManager(SimObject pObj) 
            : base(pObj) {
        }
        
        public EventManager(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpSubscribers__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpSubscribers(IntPtr _this, DumpSubscribers__Args args);
            private static _DumpSubscribers _DumpSubscribersFunc;
            internal static _DumpSubscribers DumpSubscribers() {
                if (_DumpSubscribersFunc == null) {
                    _DumpSubscribersFunc =
                        (_DumpSubscribers)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_dumpSubscribers"), typeof(_DumpSubscribers));
                }
                
                return _DumpSubscribersFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpEvents__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpEvents(IntPtr _this, DumpEvents__Args args);
            private static _DumpEvents _DumpEventsFunc;
            internal static _DumpEvents DumpEvents() {
                if (_DumpEventsFunc == null) {
                    _DumpEventsFunc =
                        (_DumpEvents)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_dumpEvents"), typeof(_DumpEvents));
                }
                
                return _DumpEventsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveAll__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveAll(IntPtr _this, RemoveAll__Args args);
            private static _RemoveAll _RemoveAllFunc;
            internal static _RemoveAll RemoveAll() {
                if (_RemoveAllFunc == null) {
                    _RemoveAllFunc =
                        (_RemoveAll)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_removeAll"), typeof(_RemoveAll));
                }
                
                return _RemoveAllFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Remove__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Remove(IntPtr _this, Remove__Args args);
            private static _Remove _RemoveFunc;
            internal static _Remove Remove() {
                if (_RemoveFunc == null) {
                    _RemoveFunc =
                        (_Remove)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_remove"), typeof(_Remove));
                }
                
                return _RemoveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Subscribe__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Subscribe(IntPtr _this, Subscribe__Args args);
            private static _Subscribe _SubscribeFunc;
            internal static _Subscribe Subscribe() {
                if (_SubscribeFunc == null) {
                    _SubscribeFunc =
                        (_Subscribe)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_subscribe"), typeof(_Subscribe));
                }
                
                return _SubscribeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PostEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PostEvent(IntPtr _this, PostEvent__Args args);
            private static _PostEvent _PostEventFunc;
            internal static _PostEvent PostEvent() {
                if (_PostEventFunc == null) {
                    _PostEventFunc =
                        (_PostEvent)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_postEvent"), typeof(_PostEvent));
                }
                
                return _PostEventFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRegisteredEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRegisteredEvent(IntPtr _this, IsRegisteredEvent__Args args);
            private static _IsRegisteredEvent _IsRegisteredEventFunc;
            internal static _IsRegisteredEvent IsRegisteredEvent() {
                if (_IsRegisteredEventFunc == null) {
                    _IsRegisteredEventFunc =
                        (_IsRegisteredEvent)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_isRegisteredEvent"), typeof(_IsRegisteredEvent));
                }
                
                return _IsRegisteredEventFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct UnregisterEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnregisterEvent(IntPtr _this, UnregisterEvent__Args args);
            private static _UnregisterEvent _UnregisterEventFunc;
            internal static _UnregisterEvent UnregisterEvent() {
                if (_UnregisterEventFunc == null) {
                    _UnregisterEventFunc =
                        (_UnregisterEvent)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_unregisterEvent"), typeof(_UnregisterEvent));
                }
                
                return _UnregisterEventFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RegisterEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RegisterEvent(IntPtr _this, RegisterEvent__Args args);
            private static _RegisterEvent _RegisterEventFunc;
            internal static _RegisterEvent RegisterEvent() {
                if (_RegisterEventFunc == null) {
                    _RegisterEventFunc =
                        (_RegisterEvent)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnEventManager_registerEvent"), typeof(_RegisterEvent));
                }
                
                return _RegisterEventFunc;
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
                                "fnEventManager_staticGetType"), typeof(_StaticGetType));
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
                                "fnEventManager_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void DumpSubscribers(string listenerName = "") {
             InternalUnsafeMethods.DumpSubscribers__Args _args = new InternalUnsafeMethods.DumpSubscribers__Args() {
                listenerName = listenerName,
             };
             InternalUnsafeMethods.DumpSubscribers()(ObjectPtr, _args);
        }

        public void DumpEvents() {
             InternalUnsafeMethods.DumpEvents__Args _args = new InternalUnsafeMethods.DumpEvents__Args() {
             };
             InternalUnsafeMethods.DumpEvents()(ObjectPtr, _args);
        }

        public void RemoveAll(string listenerName) {
             InternalUnsafeMethods.RemoveAll__Args _args = new InternalUnsafeMethods.RemoveAll__Args() {
                listenerName = listenerName,
             };
             InternalUnsafeMethods.RemoveAll()(ObjectPtr, _args);
        }

        public void Remove(string listenerName, string evt) {
             InternalUnsafeMethods.Remove__Args _args = new InternalUnsafeMethods.Remove__Args() {
                listenerName = listenerName,
                evt = evt,
             };
             InternalUnsafeMethods.Remove()(ObjectPtr, _args);
        }

        public bool Subscribe(string listenerName, string evt, string callback = "") {
             InternalUnsafeMethods.Subscribe__Args _args = new InternalUnsafeMethods.Subscribe__Args() {
                listenerName = listenerName,
                evt = evt,
                callback = callback,
             };
             bool _engineResult = InternalUnsafeMethods.Subscribe()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool PostEvent(string evt, string data = "") {
             InternalUnsafeMethods.PostEvent__Args _args = new InternalUnsafeMethods.PostEvent__Args() {
                evt = evt,
                data = data,
             };
             bool _engineResult = InternalUnsafeMethods.PostEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool IsRegisteredEvent(string evt) {
             InternalUnsafeMethods.IsRegisteredEvent__Args _args = new InternalUnsafeMethods.IsRegisteredEvent__Args() {
                evt = evt,
             };
             bool _engineResult = InternalUnsafeMethods.IsRegisteredEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        public void UnregisterEvent(string evt) {
             InternalUnsafeMethods.UnregisterEvent__Args _args = new InternalUnsafeMethods.UnregisterEvent__Args() {
                evt = evt,
             };
             InternalUnsafeMethods.UnregisterEvent()(ObjectPtr, _args);
        }

        public bool RegisterEvent(string evt) {
             InternalUnsafeMethods.RegisterEvent__Args _args = new InternalUnsafeMethods.RegisterEvent__Args() {
                evt = evt,
             };
             bool _engineResult = InternalUnsafeMethods.RegisterEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string Queue {
            get => GenericMarshal.StringTo<string>(GetFieldValue("queue"));
            set => SetFieldValue("queue", GenericMarshal.ToString(value));
        }
    }
}