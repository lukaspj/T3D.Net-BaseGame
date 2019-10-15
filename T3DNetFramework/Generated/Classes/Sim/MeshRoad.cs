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
    public unsafe class MeshRoad : SceneObject {
        public MeshRoad(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public MeshRoad(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public MeshRoad(string pName) 
            : this(pName, false) {
        }
        
        public MeshRoad(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public MeshRoad(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public MeshRoad(SimObject pObj) 
            : base(pObj) {
        }
        
        public MeshRoad(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PostApply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PostApply(IntPtr _this, PostApply__Args args);
            private static _PostApply _PostApplyFunc;
            internal static _PostApply PostApply() {
                if (_PostApplyFunc == null) {
                    _PostApplyFunc =
                        (_PostApply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshRoad_postApply"), typeof(_PostApply));
                }
                
                return _PostApplyFunc;
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
                                "fnMeshRoad_regenerate"), typeof(_Regenerate));
                }
                
                return _RegenerateFunc;
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
                                "fnMeshRoad_setNodeDepth"), typeof(_SetNodeDepth));
                }
                
                return _SetNodeDepthFunc;
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
                                "fnMeshRoad_staticGetType"), typeof(_StaticGetType));
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
                                "fnMeshRoad_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void PostApply() {
             InternalUnsafeMethods.PostApply__Args _args = new InternalUnsafeMethods.PostApply__Args() {
             };
             InternalUnsafeMethods.PostApply()(ObjectPtr, _args);
        }

        public void Regenerate() {
             InternalUnsafeMethods.Regenerate__Args _args = new InternalUnsafeMethods.Regenerate__Args() {
             };
             InternalUnsafeMethods.Regenerate()(ObjectPtr, _args);
        }

        public void SetNodeDepth(int idx, float meters) {
             InternalUnsafeMethods.SetNodeDepth__Args _args = new InternalUnsafeMethods.SetNodeDepth__Args() {
                idx = idx,
                meters = meters,
             };
             InternalUnsafeMethods.SetNodeDepth()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string TopMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("topMaterial"));
            set => SetFieldValue("topMaterial", GenericMarshal.ToString(value));
        }

        public string BottomMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("bottomMaterial"));
            set => SetFieldValue("bottomMaterial", GenericMarshal.ToString(value));
        }

        public string SideMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sideMaterial"));
            set => SetFieldValue("sideMaterial", GenericMarshal.ToString(value));
        }

        public float TextureLength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("textureLength"));
            set => SetFieldValue("textureLength", GenericMarshal.ToString(value));
        }

        public float BreakAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("breakAngle"));
            set => SetFieldValue("breakAngle", GenericMarshal.ToString(value));
        }

        public int WidthSubdivisions {
            get => GenericMarshal.StringTo<int>(GetFieldValue("widthSubdivisions"));
            set => SetFieldValue("widthSubdivisions", GenericMarshal.ToString(value));
        }

        public string Node {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Node"));
            set => SetFieldValue("Node", GenericMarshal.ToString(value));
        }
    }
}