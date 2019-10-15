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
    public unsafe class River : WaterObject {
        public River(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public River(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public River(string pName) 
            : this(pName, false) {
        }
        
        public River(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public River(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public River(SimObject pObj) 
            : base(pObj) {
        }
        
        public River(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMaxDivisionSize__Args
            {
                internal float meters;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMaxDivisionSize(IntPtr _this, SetMaxDivisionSize__Args args);
            private static _SetMaxDivisionSize _SetMaxDivisionSizeFunc;
            internal static _SetMaxDivisionSize SetMaxDivisionSize() {
                if (_SetMaxDivisionSizeFunc == null) {
                    _SetMaxDivisionSizeFunc =
                        (_SetMaxDivisionSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRiver_setMaxDivisionSize"), typeof(_SetMaxDivisionSize));
                }
                
                return _SetMaxDivisionSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeDepth__Args
            {
                internal int idx;
                internal float meters;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodeDepth(IntPtr _this, SetNodeDepth__Args args);
            private static _SetNodeDepth _SetNodeDepthFunc;
            internal static _SetNodeDepth SetNodeDepth() {
                if (_SetNodeDepthFunc == null) {
                    _SetNodeDepthFunc =
                        (_SetNodeDepth)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRiver_setNodeDepth"), typeof(_SetNodeDepth));
                }
                
                return _SetNodeDepthFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBatchSize__Args
            {
                internal float meters;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBatchSize(IntPtr _this, SetBatchSize__Args args);
            private static _SetBatchSize _SetBatchSizeFunc;
            internal static _SetBatchSize SetBatchSize() {
                if (_SetBatchSizeFunc == null) {
                    _SetBatchSizeFunc =
                        (_SetBatchSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRiver_setBatchSize"), typeof(_SetBatchSize));
                }
                
                return _SetBatchSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMetersPerSegment__Args
            {
                internal float meters;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMetersPerSegment(IntPtr _this, SetMetersPerSegment__Args args);
            private static _SetMetersPerSegment _SetMetersPerSegmentFunc;
            internal static _SetMetersPerSegment SetMetersPerSegment() {
                if (_SetMetersPerSegmentFunc == null) {
                    _SetMetersPerSegmentFunc =
                        (_SetMetersPerSegment)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRiver_setMetersPerSegment"), typeof(_SetMetersPerSegment));
                }
                
                return _SetMetersPerSegmentFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Regenerate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Regenerate(IntPtr _this, Regenerate__Args args);
            private static _Regenerate _RegenerateFunc;
            internal static _Regenerate Regenerate() {
                if (_RegenerateFunc == null) {
                    _RegenerateFunc =
                        (_Regenerate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnRiver_regenerate"), typeof(_Regenerate));
                }
                
                return _RegenerateFunc;
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
                                "fnRiver_staticGetType"), typeof(_StaticGetType));
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
                                "fnRiver_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void SetMaxDivisionSize(float meters) {
             InternalUnsafeMethods.SetMaxDivisionSize__Args _args = new InternalUnsafeMethods.SetMaxDivisionSize__Args() {
                meters = meters,
             };
             InternalUnsafeMethods.SetMaxDivisionSize()(ObjectPtr, _args);
        }

        public void SetNodeDepth(int idx, float meters) {
             InternalUnsafeMethods.SetNodeDepth__Args _args = new InternalUnsafeMethods.SetNodeDepth__Args() {
                idx = idx,
                meters = meters,
             };
             InternalUnsafeMethods.SetNodeDepth()(ObjectPtr, _args);
        }

        public void SetBatchSize(float meters) {
             InternalUnsafeMethods.SetBatchSize__Args _args = new InternalUnsafeMethods.SetBatchSize__Args() {
                meters = meters,
             };
             InternalUnsafeMethods.SetBatchSize()(ObjectPtr, _args);
        }

        public void SetMetersPerSegment(float meters) {
             InternalUnsafeMethods.SetMetersPerSegment__Args _args = new InternalUnsafeMethods.SetMetersPerSegment__Args() {
                meters = meters,
             };
             InternalUnsafeMethods.SetMetersPerSegment()(ObjectPtr, _args);
        }

        public void Regenerate() {
             InternalUnsafeMethods.Regenerate__Args _args = new InternalUnsafeMethods.Regenerate__Args() {
             };
             InternalUnsafeMethods.Regenerate()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public float SegmentLength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("SegmentLength"));
            set => SetFieldValue("SegmentLength", GenericMarshal.ToString(value));
        }

        public float SubdivideLength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("SubdivideLength"));
            set => SetFieldValue("SubdivideLength", GenericMarshal.ToString(value));
        }

        public float FlowMagnitude {
            get => GenericMarshal.StringTo<float>(GetFieldValue("FlowMagnitude"));
            set => SetFieldValue("FlowMagnitude", GenericMarshal.ToString(value));
        }

        public float LowLODDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("LowLODDistance"));
            set => SetFieldValue("LowLODDistance", GenericMarshal.ToString(value));
        }

        public string Node {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Node"));
            set => SetFieldValue("Node", GenericMarshal.ToString(value));
        }
    }
}