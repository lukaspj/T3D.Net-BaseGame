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

namespace T3DNetFramework.Generated.Classes.Net {    
    public unsafe class RadialImpulseEvent : NetEvent {
        public RadialImpulseEvent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public RadialImpulseEvent(ConsoleObjectBase pObj) 
            : base(pObj) {
        }
        
        public RadialImpulseEvent(IntPtr pObj) 
            : base(pObj) {
        }

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Send__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string inPosition;
                internal float radius;
                internal float magnitude;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Send(Send__Args args);
            private static _Send _SendFunc;
            internal static _Send Send() {
                if (_SendFunc == null) {
                    _SendFunc =
                        (_Send)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRadialImpulseEvent_send"), typeof(_Send));
                }
                
                return _SendFunc;
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
                                "fnRadialImpulseEvent_staticGetType"), typeof(_StaticGetType));
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
                                "fnRadialImpulseEvent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public static void Send(string inPosition = "1.0 1.0 1.0", float radius = 10f, float magnitude = 20f) {
             InternalUnsafeMethods.Send__Args _args = new InternalUnsafeMethods.Send__Args() {
                inPosition = inPosition,
                radius = radius,
                magnitude = magnitude,
             };
             InternalUnsafeMethods.Send()(_args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}