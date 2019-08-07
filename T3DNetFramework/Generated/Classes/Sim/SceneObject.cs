using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class SceneObject : NetObject {



        public SceneObject(bool pRegister = false)
            : base(pRegister) {
        }

        public SceneObject(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SceneObject(string pName)
            : this(pName, false) {
        }

        public SceneObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SceneObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SceneObject(SimObject pObj)
            : base(pObj) {
        }

        public SceneObject(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSpeed__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetSpeed(IntPtr _this);
                internal delegate float _GetSpeed(IntPtr _this, GetSpeed__Args args);
                private static _GetSpeed _GetSpeedFunc;
                internal static _GetSpeed GetSpeed() {
                    if (_GetSpeedFunc == null) {
                        _GetSpeedFunc =
                            (_GetSpeed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getSpeed"), typeof(_GetSpeed));
                    }

                    return _GetSpeedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetForwardVector__Args
                {

				   internal IntPtr newForward;

				   internal IntPtr upVector;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetForwardVector(IntPtr _this, IntPtr newForward, IntPtr upVector);
                internal delegate void _SetForwardVector(IntPtr _this, SetForwardVector__Args args);
                private static _SetForwardVector _SetForwardVectorFunc;
                internal static _SetForwardVector SetForwardVector() {
                    if (_SetForwardVectorFunc == null) {
                        _SetForwardVectorFunc =
                            (_SetForwardVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_setForwardVector"), typeof(_SetForwardVector));
                    }

                    return _SetForwardVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsGlobalBounds__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsGlobalBounds(IntPtr _this);
                internal delegate bool _IsGlobalBounds(IntPtr _this, IsGlobalBounds__Args args);
                private static _IsGlobalBounds _IsGlobalBoundsFunc;
                internal static _IsGlobalBounds IsGlobalBounds() {
                    if (_IsGlobalBoundsFunc == null) {
                        _IsGlobalBoundsFunc =
                            (_IsGlobalBounds)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_isGlobalBounds"), typeof(_IsGlobalBounds));
                    }

                    return _IsGlobalBoundsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetObjectBox__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Box3F.InternalStruct _GetObjectBox(IntPtr _this);
                internal delegate Box3F.InternalStruct _GetObjectBox(IntPtr _this, GetObjectBox__Args args);
                private static _GetObjectBox _GetObjectBoxFunc;
                internal static _GetObjectBox GetObjectBox() {
                    if (_GetObjectBoxFunc == null) {
                        _GetObjectBoxFunc =
                            (_GetObjectBox)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getObjectBox"), typeof(_GetObjectBox));
                    }

                    return _GetObjectBoxFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetWorldBoxCenter__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetWorldBoxCenter(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetWorldBoxCenter(IntPtr _this, GetWorldBoxCenter__Args args);
                private static _GetWorldBoxCenter _GetWorldBoxCenterFunc;
                internal static _GetWorldBoxCenter GetWorldBoxCenter() {
                    if (_GetWorldBoxCenterFunc == null) {
                        _GetWorldBoxCenterFunc =
                            (_GetWorldBoxCenter)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getWorldBoxCenter"), typeof(_GetWorldBoxCenter));
                    }

                    return _GetWorldBoxCenterFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetWorldBox__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Box3F.InternalStruct _GetWorldBox(IntPtr _this);
                internal delegate Box3F.InternalStruct _GetWorldBox(IntPtr _this, GetWorldBox__Args args);
                private static _GetWorldBox _GetWorldBoxFunc;
                internal static _GetWorldBox GetWorldBox() {
                    if (_GetWorldBoxFunc == null) {
                        _GetWorldBoxFunc =
                            (_GetWorldBox)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getWorldBox"), typeof(_GetWorldBox));
                    }

                    return _GetWorldBoxFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetScale__Args
                {

				   internal IntPtr scale;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetScale(IntPtr _this, IntPtr scale);
                internal delegate void _SetScale(IntPtr _this, SetScale__Args args);
                private static _SetScale _SetScaleFunc;
                internal static _SetScale SetScale() {
                    if (_SetScaleFunc == null) {
                        _SetScaleFunc =
                            (_SetScale)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_setScale"), typeof(_SetScale));
                    }

                    return _SetScaleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetScale__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetScale(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetScale(IntPtr _this, GetScale__Args args);
                private static _GetScale _GetScaleFunc;
                internal static _GetScale GetScale() {
                    if (_GetScaleFunc == null) {
                        _GetScaleFunc =
                            (_GetScale)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getScale"), typeof(_GetScale));
                    }

                    return _GetScaleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTransform__Args
                {

				   internal IntPtr txfm;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetTransform(IntPtr _this, IntPtr txfm);
                internal delegate void _SetTransform(IntPtr _this, SetTransform__Args args);
                private static _SetTransform _SetTransformFunc;
                internal static _SetTransform SetTransform() {
                    if (_SetTransformFunc == null) {
                        _SetTransformFunc =
                            (_SetTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_setTransform"), typeof(_SetTransform));
                    }

                    return _SetTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetUpVector__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetUpVector(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetUpVector(IntPtr _this, GetUpVector__Args args);
                private static _GetUpVector _GetUpVectorFunc;
                internal static _GetUpVector GetUpVector() {
                    if (_GetUpVectorFunc == null) {
                        _GetUpVectorFunc =
                            (_GetUpVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getUpVector"), typeof(_GetUpVector));
                    }

                    return _GetUpVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRightVector__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetRightVector(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetRightVector(IntPtr _this, GetRightVector__Args args);
                private static _GetRightVector _GetRightVectorFunc;
                internal static _GetRightVector GetRightVector() {
                    if (_GetRightVectorFunc == null) {
                        _GetRightVectorFunc =
                            (_GetRightVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getRightVector"), typeof(_GetRightVector));
                    }

                    return _GetRightVectorFunc;
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
                                    "fnSceneObject_getForwardVector"), typeof(_GetForwardVector));
                    }

                    return _GetForwardVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEulerRotation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetEulerRotation(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetEulerRotation(IntPtr _this, GetEulerRotation__Args args);
                private static _GetEulerRotation _GetEulerRotationFunc;
                internal static _GetEulerRotation GetEulerRotation() {
                    if (_GetEulerRotationFunc == null) {
                        _GetEulerRotationFunc =
                            (_GetEulerRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getEulerRotation"), typeof(_GetEulerRotation));
                    }

                    return _GetEulerRotationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPosition__Args
                {

				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPosition(IntPtr _this, IntPtr pos);
                internal delegate void _SetPosition(IntPtr _this, SetPosition__Args args);
                private static _SetPosition _SetPositionFunc;
                internal static _SetPosition SetPosition() {
                    if (_SetPositionFunc == null) {
                        _SetPositionFunc =
                            (_SetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_setPosition"), typeof(_SetPosition));
                    }

                    return _SetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetPosition(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetPosition(IntPtr _this, GetPosition__Args args);
                private static _GetPosition _GetPositionFunc;
                internal static _GetPosition GetPosition() {
                    if (_GetPositionFunc == null) {
                        _GetPositionFunc =
                            (_GetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getPosition"), typeof(_GetPosition));
                    }

                    return _GetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetInverseTransform__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate TransformF.InternalStruct _GetInverseTransform(IntPtr _this);
                internal delegate TransformF.InternalStruct _GetInverseTransform(IntPtr _this, GetInverseTransform__Args args);
                private static _GetInverseTransform _GetInverseTransformFunc;
                internal static _GetInverseTransform GetInverseTransform() {
                    if (_GetInverseTransformFunc == null) {
                        _GetInverseTransformFunc =
                            (_GetInverseTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getInverseTransform"), typeof(_GetInverseTransform));
                    }

                    return _GetInverseTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTransform__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate TransformF.InternalStruct _GetTransform(IntPtr _this);
                internal delegate TransformF.InternalStruct _GetTransform(IntPtr _this, GetTransform__Args args);
                private static _GetTransform _GetTransformFunc;
                internal static _GetTransform GetTransform() {
                    if (_GetTransformFunc == null) {
                        _GetTransformFunc =
                            (_GetTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getTransform"), typeof(_GetTransform));
                    }

                    return _GetTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountNodeObject__Args
                {

				   internal int node;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountNodeObject(IntPtr _this, int node);
                internal delegate int _GetMountNodeObject(IntPtr _this, GetMountNodeObject__Args args);
                private static _GetMountNodeObject _GetMountNodeObjectFunc;
                internal static _GetMountNodeObject GetMountNodeObject() {
                    if (_GetMountNodeObjectFunc == null) {
                        _GetMountNodeObjectFunc =
                            (_GetMountNodeObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getMountNodeObject"), typeof(_GetMountNodeObject));
                    }

                    return _GetMountNodeObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountedObjectNode__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountedObjectNode(IntPtr _this, int slot);
                internal delegate int _GetMountedObjectNode(IntPtr _this, GetMountedObjectNode__Args args);
                private static _GetMountedObjectNode _GetMountedObjectNodeFunc;
                internal static _GetMountedObjectNode GetMountedObjectNode() {
                    if (_GetMountedObjectNodeFunc == null) {
                        _GetMountedObjectNodeFunc =
                            (_GetMountedObjectNode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getMountedObjectNode"), typeof(_GetMountedObjectNode));
                    }

                    return _GetMountedObjectNodeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountedObject__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountedObject(IntPtr _this, int slot);
                internal delegate int _GetMountedObject(IntPtr _this, GetMountedObject__Args args);
                private static _GetMountedObject _GetMountedObjectFunc;
                internal static _GetMountedObject GetMountedObject() {
                    if (_GetMountedObjectFunc == null) {
                        _GetMountedObjectFunc =
                            (_GetMountedObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getMountedObject"), typeof(_GetMountedObject));
                    }

                    return _GetMountedObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountedObjectCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountedObjectCount(IntPtr _this);
                internal delegate int _GetMountedObjectCount(IntPtr _this, GetMountedObjectCount__Args args);
                private static _GetMountedObjectCount _GetMountedObjectCountFunc;
                internal static _GetMountedObjectCount GetMountedObjectCount() {
                    if (_GetMountedObjectCountFunc == null) {
                        _GetMountedObjectCountFunc =
                            (_GetMountedObjectCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getMountedObjectCount"), typeof(_GetMountedObjectCount));
                    }

                    return _GetMountedObjectCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetObjectMount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetObjectMount(IntPtr _this);
                internal delegate int _GetObjectMount(IntPtr _this, GetObjectMount__Args args);
                private static _GetObjectMount _GetObjectMountFunc;
                internal static _GetObjectMount GetObjectMount() {
                    if (_GetObjectMountFunc == null) {
                        _GetObjectMountFunc =
                            (_GetObjectMount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getObjectMount"), typeof(_GetObjectMount));
                    }

                    return _GetObjectMountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsMounted__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsMounted(IntPtr _this);
                internal delegate bool _IsMounted(IntPtr _this, IsMounted__Args args);
                private static _IsMounted _IsMountedFunc;
                internal static _IsMounted IsMounted() {
                    if (_IsMountedFunc == null) {
                        _IsMountedFunc =
                            (_IsMounted)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_isMounted"), typeof(_IsMounted));
                    }

                    return _IsMountedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Unmount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Unmount(IntPtr _this);
                internal delegate void _Unmount(IntPtr _this, Unmount__Args args);
                private static _Unmount _UnmountFunc;
                internal static _Unmount Unmount() {
                    if (_UnmountFunc == null) {
                        _UnmountFunc =
                            (_Unmount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_unmount"), typeof(_Unmount));
                    }

                    return _UnmountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct UnmountObject__Args
                {

				   internal IntPtr target;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _UnmountObject(IntPtr _this, IntPtr target);
                internal delegate bool _UnmountObject(IntPtr _this, UnmountObject__Args args);
                private static _UnmountObject _UnmountObjectFunc;
                internal static _UnmountObject UnmountObject() {
                    if (_UnmountObjectFunc == null) {
                        _UnmountObjectFunc =
                            (_UnmountObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_unmountObject"), typeof(_UnmountObject));
                    }

                    return _UnmountObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct MountObject__Args
                {

				   internal IntPtr objB;

				   internal int slot;

				   internal IntPtr txfm;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _MountObject(IntPtr _this, IntPtr objB, int slot, IntPtr txfm);
                internal delegate bool _MountObject(IntPtr _this, MountObject__Args args);
                private static _MountObject _MountObjectFunc;
                internal static _MountObject MountObject() {
                    if (_MountObjectFunc == null) {
                        _MountObjectFunc =
                            (_MountObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_mountObject"), typeof(_MountObject));
                    }

                    return _MountObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetType(IntPtr _this);
                internal delegate int _GetType(IntPtr _this, GetType__Args args);
                private static _GetType _GetTypeFunc;
                internal static _GetType GetType() {
                    if (_GetTypeFunc == null) {
                        _GetTypeFunc =
                            (_GetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSceneObject_getType"), typeof(_GetType));
                    }

                    return _GetTypeFunc;
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
                                    "fnSceneObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnSceneObject_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public float GetSpeed() {

                     InternalUnsafeMethods.GetSpeed__Args _args = new InternalUnsafeMethods.GetSpeed__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetSpeed()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetForwardVector(Point3F newForward = null, Point3F upVector = null) {

                     newForward = newForward ?? new Point3F("0 0 0");newForward.Alloc();                     upVector = upVector ?? new Point3F("0 0 1");upVector.Alloc();                     InternalUnsafeMethods.SetForwardVector__Args _args = new InternalUnsafeMethods.SetForwardVector__Args() {
                        newForward = newForward.internalStructPtr,
                        upVector = upVector.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetForwardVector()(ObjectPtr, _args);
                                          newForward.Free();                     upVector.Free();
                  }



                  public bool IsGlobalBounds() {

                     InternalUnsafeMethods.IsGlobalBounds__Args _args = new InternalUnsafeMethods.IsGlobalBounds__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsGlobalBounds()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public Box3F GetObjectBox() {

                     InternalUnsafeMethods.GetObjectBox__Args _args = new InternalUnsafeMethods.GetObjectBox__Args() {
                     };
                     Box3F.InternalStruct _engineResult = InternalUnsafeMethods.GetObjectBox()(ObjectPtr, _args);

                     return new Box3F(_engineResult);
                  }



                  public Point3F GetWorldBoxCenter() {

                     InternalUnsafeMethods.GetWorldBoxCenter__Args _args = new InternalUnsafeMethods.GetWorldBoxCenter__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetWorldBoxCenter()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Box3F GetWorldBox() {

                     InternalUnsafeMethods.GetWorldBox__Args _args = new InternalUnsafeMethods.GetWorldBox__Args() {
                     };
                     Box3F.InternalStruct _engineResult = InternalUnsafeMethods.GetWorldBox()(ObjectPtr, _args);

                     return new Box3F(_engineResult);
                  }



                  public void SetScale(Point3F scale) {

                     scale.Alloc();                     InternalUnsafeMethods.SetScale__Args _args = new InternalUnsafeMethods.SetScale__Args() {
                        scale = scale.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetScale()(ObjectPtr, _args);
                                          scale.Free();
                  }



                  public Point3F GetScale() {

                     InternalUnsafeMethods.GetScale__Args _args = new InternalUnsafeMethods.GetScale__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetScale()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public void SetTransform(TransformF txfm) {

                     txfm.Alloc();                     InternalUnsafeMethods.SetTransform__Args _args = new InternalUnsafeMethods.SetTransform__Args() {
                        txfm = txfm.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetTransform()(ObjectPtr, _args);
                                          txfm.Free();
                  }



                  public Point3F GetUpVector() {

                     InternalUnsafeMethods.GetUpVector__Args _args = new InternalUnsafeMethods.GetUpVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetUpVector()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetRightVector() {

                     InternalUnsafeMethods.GetRightVector__Args _args = new InternalUnsafeMethods.GetRightVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetRightVector()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetForwardVector() {

                     InternalUnsafeMethods.GetForwardVector__Args _args = new InternalUnsafeMethods.GetForwardVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetForwardVector()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetEulerRotation() {

                     InternalUnsafeMethods.GetEulerRotation__Args _args = new InternalUnsafeMethods.GetEulerRotation__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetEulerRotation()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public void SetPosition(Point3F pos) {

                     pos.Alloc();                     InternalUnsafeMethods.SetPosition__Args _args = new InternalUnsafeMethods.SetPosition__Args() {
                        pos = pos.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetPosition()(ObjectPtr, _args);
                                          pos.Free();
                  }



                  public Point3F GetPosition() {

                     InternalUnsafeMethods.GetPosition__Args _args = new InternalUnsafeMethods.GetPosition__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetPosition()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public TransformF GetInverseTransform() {

                     InternalUnsafeMethods.GetInverseTransform__Args _args = new InternalUnsafeMethods.GetInverseTransform__Args() {
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetInverseTransform()(ObjectPtr, _args);

                     return new TransformF(_engineResult);
                  }



                  public TransformF GetTransform() {

                     InternalUnsafeMethods.GetTransform__Args _args = new InternalUnsafeMethods.GetTransform__Args() {
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetTransform()(ObjectPtr, _args);

                     return new TransformF(_engineResult);
                  }



                  public int GetMountNodeObject(int node) {

                                          InternalUnsafeMethods.GetMountNodeObject__Args _args = new InternalUnsafeMethods.GetMountNodeObject__Args() {
                        node = node,
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountNodeObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetMountedObjectNode(int slot) {

                                          InternalUnsafeMethods.GetMountedObjectNode__Args _args = new InternalUnsafeMethods.GetMountedObjectNode__Args() {
                        slot = slot,
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountedObjectNode()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetMountedObject(int slot) {

                                          InternalUnsafeMethods.GetMountedObject__Args _args = new InternalUnsafeMethods.GetMountedObject__Args() {
                        slot = slot,
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountedObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetMountedObjectCount() {

                     InternalUnsafeMethods.GetMountedObjectCount__Args _args = new InternalUnsafeMethods.GetMountedObjectCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountedObjectCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetObjectMount() {

                     InternalUnsafeMethods.GetObjectMount__Args _args = new InternalUnsafeMethods.GetObjectMount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetObjectMount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsMounted() {

                     InternalUnsafeMethods.IsMounted__Args _args = new InternalUnsafeMethods.IsMounted__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsMounted()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void Unmount() {

                     InternalUnsafeMethods.Unmount__Args _args = new InternalUnsafeMethods.Unmount__Args() {
                     };
                     InternalUnsafeMethods.Unmount()(ObjectPtr, _args);

                  }



                  public bool UnmountObject(SceneObject target) {

                                          InternalUnsafeMethods.UnmountObject__Args _args = new InternalUnsafeMethods.UnmountObject__Args() {
                        target = target.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.UnmountObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool MountObject(SceneObject objB, int slot, TransformF txfm = null) {

                                                               txfm = txfm ?? new TransformF("0 0 0 0 0 1 0 true");txfm.Alloc();                     InternalUnsafeMethods.MountObject__Args _args = new InternalUnsafeMethods.MountObject__Args() {
                        objB = objB.ObjectPtr,
                        slot = slot,
                        txfm = txfm.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.MountObject()(ObjectPtr, _args);
                                                                                    txfm.Free();
                     return _engineResult;
                  }



                  public int GetType() {

                     InternalUnsafeMethods.GetType__Args _args = new InternalUnsafeMethods.GetType__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetType()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public MatrixF Position {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("position"));
            set => SetFieldValue("position", GenericMarshal.ToString(value));
        }


        public MatrixF Rotation {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("rotation"));
            set => SetFieldValue("rotation", GenericMarshal.ToString(value));
        }


        public Point3F Scale {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("scale"));
            set => SetFieldValue("scale", GenericMarshal.ToString(value));
        }


        public bool IsRenderEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isRenderEnabled"));
            set => SetFieldValue("isRenderEnabled", GenericMarshal.ToString(value));
        }


        public bool IsSelectionEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isSelectionEnabled"));
            set => SetFieldValue("isSelectionEnabled", GenericMarshal.ToString(value));
        }


        public SimPersistID MountPID {
            get => GenericMarshal.StringTo<SimPersistID>(GetFieldValue("mountPID"));
            set => SetFieldValue("mountPID", GenericMarshal.ToString(value));
        }


        public int MountNode {
            get => GenericMarshal.StringTo<int>(GetFieldValue("mountNode"));
            set => SetFieldValue("mountNode", GenericMarshal.ToString(value));
        }


        public MatrixF MountPos {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("mountPos"));
            set => SetFieldValue("mountPos", GenericMarshal.ToString(value));
        }


        public MatrixF MountRot {
            get => GenericMarshal.StringTo<MatrixF>(GetFieldValue("mountRot"));
            set => SetFieldValue("mountRot", GenericMarshal.ToString(value));
        }


    }
}
