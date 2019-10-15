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
    public unsafe class MeshComponent : Component {
        public MeshComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public MeshComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public MeshComponent(string pName) 
            : this(pName, false) {
        }
        
        public MeshComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public MeshComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public MeshComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public MeshComponent(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
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
                                "fnMeshComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnMeshComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMatInstField__Args
            {
                internal uint slot;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string field;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMatInstField(IntPtr _this, SetMatInstField__Args args);
            private static _SetMatInstField _SetMatInstFieldFunc;
            internal static _SetMatInstField SetMatInstField() {
                if (_SetMatInstFieldFunc == null) {
                    _SetMatInstFieldFunc =
                        (_SetMatInstField)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_setMatInstField"), typeof(_SetMatInstField));
                }
                
                return _SetMatInstFieldFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ChangeMaterial__Args
            {
                internal uint slot;
                internal IntPtr newMat;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ChangeMaterial(IntPtr _this, ChangeMaterial__Args args);
            private static _ChangeMaterial _ChangeMaterialFunc;
            internal static _ChangeMaterial ChangeMaterial() {
                if (_ChangeMaterialFunc == null) {
                    _ChangeMaterialFunc =
                        (_ChangeMaterial)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_changeMaterial"), typeof(_ChangeMaterial));
                }
                
                return _ChangeMaterialFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeByName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string nodeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNodeByName(IntPtr _this, GetNodeByName__Args args);
            private static _GetNodeByName _GetNodeByNameFunc;
            internal static _GetNodeByName GetNodeByName() {
                if (_GetNodeByNameFunc == null) {
                    _GetNodeByNameFunc =
                        (_GetNodeByName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getNodeByName"), typeof(_GetNodeByName));
                }
                
                return _GetNodeByNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeRotation__Args
            {
                internal int node;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetNodeRotation(IntPtr _this, GetNodeRotation__Args args);
            private static _GetNodeRotation _GetNodeRotationFunc;
            internal static _GetNodeRotation GetNodeRotation() {
                if (_GetNodeRotationFunc == null) {
                    _GetNodeRotationFunc =
                        (_GetNodeRotation)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getNodeRotation"), typeof(_GetNodeRotation));
                }
                
                return _GetNodeRotationFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodePosition__Args
            {
                internal int node;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetNodePosition(IntPtr _this, GetNodePosition__Args args);
            private static _GetNodePosition _GetNodePositionFunc;
            internal static _GetNodePosition GetNodePosition() {
                if (_GetNodePositionFunc == null) {
                    _GetNodePositionFunc =
                        (_GetNodePosition)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getNodePosition"), typeof(_GetNodePosition));
                }
                
                return _GetNodePositionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeEulerRot__Args
            {
                internal int node;
                [MarshalAs(UnmanagedType.I1)]
                internal bool radToDeg;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetNodeEulerRot(IntPtr _this, GetNodeEulerRot__Args args);
            private static _GetNodeEulerRot _GetNodeEulerRotFunc;
            internal static _GetNodeEulerRot GetNodeEulerRot() {
                if (_GetNodeEulerRotFunc == null) {
                    _GetNodeEulerRotFunc =
                        (_GetNodeEulerRot)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getNodeEulerRot"), typeof(_GetNodeEulerRot));
                }
                
                return _GetNodeEulerRotFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeTransform__Args
            {
                internal int node;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate TransformF.InternalStruct _GetNodeTransform(IntPtr _this, GetNodeTransform__Args args);
            private static _GetNodeTransform _GetNodeTransformFunc;
            internal static _GetNodeTransform GetNodeTransform() {
                if (_GetNodeTransformFunc == null) {
                    _GetNodeTransformFunc =
                        (_GetNodeTransform)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getNodeTransform"), typeof(_GetNodeTransform));
                }
                
                return _GetNodeTransformFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct MountObject__Args
            {
                internal IntPtr objB;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string node;
                internal IntPtr txfm;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _MountObject(IntPtr _this, MountObject__Args args);
            private static _MountObject _MountObjectFunc;
            internal static _MountObject MountObject() {
                if (_MountObjectFunc == null) {
                    _MountObjectFunc =
                        (_MountObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_mountObject"), typeof(_MountObject));
                }
                
                return _MountObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetShapeBounds__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Box3F.InternalStruct _GetShapeBounds(IntPtr _this, GetShapeBounds__Args args);
            private static _GetShapeBounds _GetShapeBoundsFunc;
            internal static _GetShapeBounds GetShapeBounds() {
                if (_GetShapeBoundsFunc == null) {
                    _GetShapeBoundsFunc =
                        (_GetShapeBounds)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnMeshComponent_getShapeBounds"), typeof(_GetShapeBounds));
                }
                
                return _GetShapeBoundsFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public bool SetMatInstField(uint slot = 0, string field = "", string value = "") {
             InternalUnsafeMethods.SetMatInstField__Args _args = new InternalUnsafeMethods.SetMatInstField__Args() {
                slot = slot,
                field = field,
                value = value,
             };
             bool _engineResult = InternalUnsafeMethods.SetMatInstField()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ChangeMaterial(uint slot = 0, MaterialAsset newMat = null) {
             InternalUnsafeMethods.ChangeMaterial__Args _args = new InternalUnsafeMethods.ChangeMaterial__Args() {
                slot = slot,
                newMat = newMat.ObjectPtr,
             };
             InternalUnsafeMethods.ChangeMaterial()(ObjectPtr, _args);
        }

        public int GetNodeByName(string nodeName) {
             InternalUnsafeMethods.GetNodeByName__Args _args = new InternalUnsafeMethods.GetNodeByName__Args() {
                nodeName = nodeName,
             };
             int _engineResult = InternalUnsafeMethods.GetNodeByName()(ObjectPtr, _args);
             return _engineResult;
        }

        public Point3F GetNodeRotation(int node = -1) {
             InternalUnsafeMethods.GetNodeRotation__Args _args = new InternalUnsafeMethods.GetNodeRotation__Args() {
                node = node,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetNodeRotation()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public Point3F GetNodePosition(int node = -1) {
             InternalUnsafeMethods.GetNodePosition__Args _args = new InternalUnsafeMethods.GetNodePosition__Args() {
                node = node,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetNodePosition()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public Point3F GetNodeEulerRot(int node = -1, bool radToDeg = true) {
             InternalUnsafeMethods.GetNodeEulerRot__Args _args = new InternalUnsafeMethods.GetNodeEulerRot__Args() {
                node = node,
                radToDeg = radToDeg,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetNodeEulerRot()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        public TransformF GetNodeTransform(int node = -1) {
             InternalUnsafeMethods.GetNodeTransform__Args _args = new InternalUnsafeMethods.GetNodeTransform__Args() {
                node = node,
             };
             TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetNodeTransform()(ObjectPtr, _args);
             return new TransformF(_engineResult);
        }

        public bool MountObject(SceneObject objB, string node, TransformF txfm = null) {
txfm = txfm ?? new TransformF("0 0 0 1 0 0 0 true");
txfm.Alloc();             InternalUnsafeMethods.MountObject__Args _args = new InternalUnsafeMethods.MountObject__Args() {
                objB = objB.ObjectPtr,
                node = node,
                txfm = txfm.internalStructPtr,
             };
             bool _engineResult = InternalUnsafeMethods.MountObject()(ObjectPtr, _args);
txfm.Free();             return _engineResult;
        }

        public Box3F GetShapeBounds() {
             InternalUnsafeMethods.GetShapeBounds__Args _args = new InternalUnsafeMethods.GetShapeBounds__Args() {
             };
             Box3F.InternalStruct _engineResult = InternalUnsafeMethods.GetShapeBounds()(ObjectPtr, _args);
             return new Box3F(_engineResult);
        }

        public BatchingMode BatchingMode {
            get => GenericMarshal.StringTo<BatchingMode>(GetFieldValue("BatchingMode"));
            set => SetFieldValue("BatchingMode", GenericMarshal.ToString(value));
        }

        public string MeshAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MeshAsset"));
            set => SetFieldValue("MeshAsset", GenericMarshal.ToString(value));
        }
    }
}