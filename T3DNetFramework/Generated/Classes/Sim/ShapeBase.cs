using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class ShapeBase : GameBase {



        public ShapeBase(bool pRegister = false)
            : base(pRegister) {
        }

        public ShapeBase(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ShapeBase(string pName)
            : this(pName, false) {
        }

        public ShapeBase(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ShapeBase(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ShapeBase(SimObject pObj)
            : base(pObj) {
        }

        public ShapeBase(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetModelFile__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetModelFile(IntPtr _this);
                internal delegate IntPtr _GetModelFile(IntPtr _this, GetModelFile__Args args);
                private static _GetModelFile _GetModelFileFunc;
                internal static _GetModelFile GetModelFile() {
                    if (_GetModelFileFunc == null) {
                        _GetModelFileFunc =
                            (_GetModelFile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getModelFile"), typeof(_GetModelFile));
                    }

                    return _GetModelFileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ChangeMaterial__Args
                {

				   internal string mapTo;

				   internal IntPtr oldMat;

				   internal IntPtr newMat;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ChangeMaterial(IntPtr _this, string mapTo, IntPtr oldMat, IntPtr newMat);
                internal delegate void _ChangeMaterial(IntPtr _this, ChangeMaterial__Args args);
                private static _ChangeMaterial _ChangeMaterialFunc;
                internal static _ChangeMaterial ChangeMaterial() {
                    if (_ChangeMaterialFunc == null) {
                        _ChangeMaterialFunc =
                            (_ChangeMaterial)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_changeMaterial"), typeof(_ChangeMaterial));
                    }

                    return _ChangeMaterialFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTargetCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetTargetCount(IntPtr _this);
                internal delegate int _GetTargetCount(IntPtr _this, GetTargetCount__Args args);
                private static _GetTargetCount _GetTargetCountFunc;
                internal static _GetTargetCount GetTargetCount() {
                    if (_GetTargetCountFunc == null) {
                        _GetTargetCountFunc =
                            (_GetTargetCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getTargetCount"), typeof(_GetTargetCount));
                    }

                    return _GetTargetCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTargetName__Args
                {

				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetTargetName(IntPtr _this, int index);
                internal delegate IntPtr _GetTargetName(IntPtr _this, GetTargetName__Args args);
                private static _GetTargetName _GetTargetNameFunc;
                internal static _GetTargetName GetTargetName() {
                    if (_GetTargetNameFunc == null) {
                        _GetTargetNameFunc =
                            (_GetTargetName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getTargetName"), typeof(_GetTargetName));
                    }

                    return _GetTargetNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DumpMeshVisibility__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DumpMeshVisibility(IntPtr _this);
                internal delegate void _DumpMeshVisibility(IntPtr _this, DumpMeshVisibility__Args args);
                private static _DumpMeshVisibility _DumpMeshVisibilityFunc;
                internal static _DumpMeshVisibility DumpMeshVisibility() {
                    if (_DumpMeshVisibilityFunc == null) {
                        _DumpMeshVisibilityFunc =
                            (_DumpMeshVisibility)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_dumpMeshVisibility"), typeof(_DumpMeshVisibility));
                    }

                    return _DumpMeshVisibilityFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMeshHidden__Args
                {

				   internal string name;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool hide;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetMeshHidden(IntPtr _this, string name, [MarshalAs(UnmanagedType.I1)]bool hide);
                internal delegate void _SetMeshHidden(IntPtr _this, SetMeshHidden__Args args);
                private static _SetMeshHidden _SetMeshHiddenFunc;
                internal static _SetMeshHidden SetMeshHidden() {
                    if (_SetMeshHiddenFunc == null) {
                        _SetMeshHiddenFunc =
                            (_SetMeshHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setMeshHidden"), typeof(_SetMeshHidden));
                    }

                    return _SetMeshHiddenFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAllMeshesHidden__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool hide;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetAllMeshesHidden(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool hide);
                internal delegate void _SetAllMeshesHidden(IntPtr _this, SetAllMeshesHidden__Args args);
                private static _SetAllMeshesHidden _SetAllMeshesHiddenFunc;
                internal static _SetAllMeshesHidden SetAllMeshesHidden() {
                    if (_SetAllMeshesHiddenFunc == null) {
                        _SetAllMeshesHiddenFunc =
                            (_SetAllMeshesHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setAllMeshesHidden"), typeof(_SetAllMeshesHidden));
                    }

                    return _SetAllMeshesHiddenFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSkinName__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetSkinName(IntPtr _this);
                internal delegate IntPtr _GetSkinName(IntPtr _this, GetSkinName__Args args);
                private static _GetSkinName _GetSkinNameFunc;
                internal static _GetSkinName GetSkinName() {
                    if (_GetSkinNameFunc == null) {
                        _GetSkinNameFunc =
                            (_GetSkinName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getSkinName"), typeof(_GetSkinName));
                    }

                    return _GetSkinNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSkinName__Args
                {

				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetSkinName(IntPtr _this, string name);
                internal delegate void _SetSkinName(IntPtr _this, SetSkinName__Args args);
                private static _SetSkinName _SetSkinNameFunc;
                internal static _SetSkinName SetSkinName() {
                    if (_SetSkinNameFunc == null) {
                        _SetSkinNameFunc =
                            (_SetSkinName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setSkinName"), typeof(_SetSkinName));
                    }

                    return _SetSkinNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetShapeName__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetShapeName(IntPtr _this);
                internal delegate IntPtr _GetShapeName(IntPtr _this, GetShapeName__Args args);
                private static _GetShapeName _GetShapeNameFunc;
                internal static _GetShapeName GetShapeName() {
                    if (_GetShapeNameFunc == null) {
                        _GetShapeNameFunc =
                            (_GetShapeName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getShapeName"), typeof(_GetShapeName));
                    }

                    return _GetShapeNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetShapeName__Args
                {

				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetShapeName(IntPtr _this, string name);
                internal delegate void _SetShapeName(IntPtr _this, SetShapeName__Args args);
                private static _SetShapeName _SetShapeNameFunc;
                internal static _SetShapeName SetShapeName() {
                    if (_SetShapeNameFunc == null) {
                        _SetShapeNameFunc =
                            (_SetShapeName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setShapeName"), typeof(_SetShapeName));
                    }

                    return _SetShapeNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDamageVector__Args
                {

				   internal IntPtr vec;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetDamageVector(IntPtr _this, IntPtr vec);
                internal delegate void _SetDamageVector(IntPtr _this, SetDamageVector__Args args);
                private static _SetDamageVector _SetDamageVectorFunc;
                internal static _SetDamageVector SetDamageVector() {
                    if (_SetDamageVectorFunc == null) {
                        _SetDamageVectorFunc =
                            (_SetDamageVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setDamageVector"), typeof(_SetDamageVector));
                    }

                    return _SetDamageVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StartFade__Args
                {

				   internal int time;

				   internal int delay;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool fadeOut;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _StartFade(IntPtr _this, int time, int delay, [MarshalAs(UnmanagedType.I1)]bool fadeOut);
                internal delegate void _StartFade(IntPtr _this, StartFade__Args args);
                private static _StartFade _StartFadeFunc;
                internal static _StartFade StartFade() {
                    if (_StartFadeFunc == null) {
                        _StartFadeFunc =
                            (_StartFade)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_startFade"), typeof(_StartFade));
                    }

                    return _StartFadeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCameraFov__Args
                {

				   internal float fov;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetCameraFov(IntPtr _this, float fov);
                internal delegate void _SetCameraFov(IntPtr _this, SetCameraFov__Args args);
                private static _SetCameraFov _SetCameraFovFunc;
                internal static _SetCameraFov SetCameraFov() {
                    if (_SetCameraFovFunc == null) {
                        _SetCameraFovFunc =
                            (_SetCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setCameraFov"), typeof(_SetCameraFov));
                    }

                    return _SetCameraFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCameraFov__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetCameraFov(IntPtr _this);
                internal delegate float _GetCameraFov(IntPtr _this, GetCameraFov__Args args);
                private static _GetCameraFov _GetCameraFovFunc;
                internal static _GetCameraFov GetCameraFov() {
                    if (_GetCameraFovFunc == null) {
                        _GetCameraFovFunc =
                            (_GetCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getCameraFov"), typeof(_GetCameraFov));
                    }

                    return _GetCameraFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDefaultCameraFov__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDefaultCameraFov(IntPtr _this);
                internal delegate float _GetDefaultCameraFov(IntPtr _this, GetDefaultCameraFov__Args args);
                private static _GetDefaultCameraFov _GetDefaultCameraFovFunc;
                internal static _GetDefaultCameraFov GetDefaultCameraFov() {
                    if (_GetDefaultCameraFovFunc == null) {
                        _GetDefaultCameraFovFunc =
                            (_GetDefaultCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getDefaultCameraFov"), typeof(_GetDefaultCameraFov));
                    }

                    return _GetDefaultCameraFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetWhiteOut__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetWhiteOut(IntPtr _this);
                internal delegate float _GetWhiteOut(IntPtr _this, GetWhiteOut__Args args);
                private static _GetWhiteOut _GetWhiteOutFunc;
                internal static _GetWhiteOut GetWhiteOut() {
                    if (_GetWhiteOutFunc == null) {
                        _GetWhiteOutFunc =
                            (_GetWhiteOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getWhiteOut"), typeof(_GetWhiteOut));
                    }

                    return _GetWhiteOutFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetWhiteOut__Args
                {

				   internal float level;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetWhiteOut(IntPtr _this, float level);
                internal delegate void _SetWhiteOut(IntPtr _this, SetWhiteOut__Args args);
                private static _SetWhiteOut _SetWhiteOutFunc;
                internal static _SetWhiteOut SetWhiteOut() {
                    if (_SetWhiteOutFunc == null) {
                        _SetWhiteOutFunc =
                            (_SetWhiteOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setWhiteOut"), typeof(_SetWhiteOut));
                    }

                    return _SetWhiteOutFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDamageFlash__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDamageFlash(IntPtr _this);
                internal delegate float _GetDamageFlash(IntPtr _this, GetDamageFlash__Args args);
                private static _GetDamageFlash _GetDamageFlashFunc;
                internal static _GetDamageFlash GetDamageFlash() {
                    if (_GetDamageFlashFunc == null) {
                        _GetDamageFlashFunc =
                            (_GetDamageFlash)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getDamageFlash"), typeof(_GetDamageFlash));
                    }

                    return _GetDamageFlashFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDamageFlash__Args
                {

				   internal float level;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetDamageFlash(IntPtr _this, float level);
                internal delegate void _SetDamageFlash(IntPtr _this, SetDamageFlash__Args args);
                private static _SetDamageFlash _SetDamageFlashFunc;
                internal static _SetDamageFlash SetDamageFlash() {
                    if (_SetDamageFlashFunc == null) {
                        _SetDamageFlashFunc =
                            (_SetDamageFlash)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setDamageFlash"), typeof(_SetDamageFlash));
                    }

                    return _SetDamageFlashFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsCloaked__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsCloaked(IntPtr _this);
                internal delegate bool _IsCloaked(IntPtr _this, IsCloaked__Args args);
                private static _IsCloaked _IsCloakedFunc;
                internal static _IsCloaked IsCloaked() {
                    if (_IsCloakedFunc == null) {
                        _IsCloakedFunc =
                            (_IsCloaked)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isCloaked"), typeof(_IsCloaked));
                    }

                    return _IsCloakedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCloaked__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool cloak;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetCloaked(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool cloak);
                internal delegate void _SetCloaked(IntPtr _this, SetCloaked__Args args);
                private static _SetCloaked _SetCloakedFunc;
                internal static _SetCloaked SetCloaked() {
                    if (_SetCloakedFunc == null) {
                        _SetCloakedFunc =
                            (_SetCloaked)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setCloaked"), typeof(_SetCloaked));
                    }

                    return _SetCloakedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CanCloak__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CanCloak(IntPtr _this);
                internal delegate bool _CanCloak(IntPtr _this, CanCloak__Args args);
                private static _CanCloak _CanCloakFunc;
                internal static _CanCloak CanCloak() {
                    if (_CanCloakFunc == null) {
                        _CanCloakFunc =
                            (_CanCloak)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_canCloak"), typeof(_CanCloak));
                    }

                    return _CanCloakFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControllingObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetControllingObject(IntPtr _this);
                internal delegate int _GetControllingObject(IntPtr _this, GetControllingObject__Args args);
                private static _GetControllingObject _GetControllingObjectFunc;
                internal static _GetControllingObject GetControllingObject() {
                    if (_GetControllingObjectFunc == null) {
                        _GetControllingObjectFunc =
                            (_GetControllingObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getControllingObject"), typeof(_GetControllingObject));
                    }

                    return _GetControllingObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControllingClient__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetControllingClient(IntPtr _this);
                internal delegate int _GetControllingClient(IntPtr _this, GetControllingClient__Args args);
                private static _GetControllingClient _GetControllingClientFunc;
                internal static _GetControllingClient GetControllingClient() {
                    if (_GetControllingClientFunc == null) {
                        _GetControllingClientFunc =
                            (_GetControllingClient)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getControllingClient"), typeof(_GetControllingClient));
                    }

                    return _GetControllingClientFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRechargeRate__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetRechargeRate(IntPtr _this);
                internal delegate float _GetRechargeRate(IntPtr _this, GetRechargeRate__Args args);
                private static _GetRechargeRate _GetRechargeRateFunc;
                internal static _GetRechargeRate GetRechargeRate() {
                    if (_GetRechargeRateFunc == null) {
                        _GetRechargeRateFunc =
                            (_GetRechargeRate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getRechargeRate"), typeof(_GetRechargeRate));
                    }

                    return _GetRechargeRateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetRechargeRate__Args
                {

				   internal float rate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetRechargeRate(IntPtr _this, float rate);
                internal delegate void _SetRechargeRate(IntPtr _this, SetRechargeRate__Args args);
                private static _SetRechargeRate _SetRechargeRateFunc;
                internal static _SetRechargeRate SetRechargeRate() {
                    if (_SetRechargeRateFunc == null) {
                        _SetRechargeRateFunc =
                            (_SetRechargeRate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setRechargeRate"), typeof(_SetRechargeRate));
                    }

                    return _SetRechargeRateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRepairRate__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetRepairRate(IntPtr _this);
                internal delegate float _GetRepairRate(IntPtr _this, GetRepairRate__Args args);
                private static _GetRepairRate _GetRepairRateFunc;
                internal static _GetRepairRate GetRepairRate() {
                    if (_GetRepairRateFunc == null) {
                        _GetRepairRateFunc =
                            (_GetRepairRate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getRepairRate"), typeof(_GetRepairRate));
                    }

                    return _GetRepairRateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetRepairRate__Args
                {

				   internal float rate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetRepairRate(IntPtr _this, float rate);
                internal delegate void _SetRepairRate(IntPtr _this, SetRepairRate__Args args);
                private static _SetRepairRate _SetRepairRateFunc;
                internal static _SetRepairRate SetRepairRate() {
                    if (_SetRepairRateFunc == null) {
                        _SetRepairRateFunc =
                            (_SetRepairRate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setRepairRate"), typeof(_SetRepairRate));
                    }

                    return _SetRepairRateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyRepair__Args
                {

				   internal float amount;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ApplyRepair(IntPtr _this, float amount);
                internal delegate void _ApplyRepair(IntPtr _this, ApplyRepair__Args args);
                private static _ApplyRepair _ApplyRepairFunc;
                internal static _ApplyRepair ApplyRepair() {
                    if (_ApplyRepairFunc == null) {
                        _ApplyRepairFunc =
                            (_ApplyRepair)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_applyRepair"), typeof(_ApplyRepair));
                    }

                    return _ApplyRepairFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyDamage__Args
                {

				   internal float amount;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ApplyDamage(IntPtr _this, float amount);
                internal delegate void _ApplyDamage(IntPtr _this, ApplyDamage__Args args);
                private static _ApplyDamage _ApplyDamageFunc;
                internal static _ApplyDamage ApplyDamage() {
                    if (_ApplyDamageFunc == null) {
                        _ApplyDamageFunc =
                            (_ApplyDamage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_applyDamage"), typeof(_ApplyDamage));
                    }

                    return _ApplyDamageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct BlowUp__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _BlowUp(IntPtr _this);
                internal delegate void _BlowUp(IntPtr _this, BlowUp__Args args);
                private static _BlowUp _BlowUpFunc;
                internal static _BlowUp BlowUp() {
                    if (_BlowUpFunc == null) {
                        _BlowUpFunc =
                            (_BlowUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_blowUp"), typeof(_BlowUp));
                    }

                    return _BlowUpFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsEnabled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsEnabled(IntPtr _this);
                internal delegate bool _IsEnabled(IntPtr _this, IsEnabled__Args args);
                private static _IsEnabled _IsEnabledFunc;
                internal static _IsEnabled IsEnabled() {
                    if (_IsEnabledFunc == null) {
                        _IsEnabledFunc =
                            (_IsEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isEnabled"), typeof(_IsEnabled));
                    }

                    return _IsEnabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsDisabled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsDisabled(IntPtr _this);
                internal delegate bool _IsDisabled(IntPtr _this, IsDisabled__Args args);
                private static _IsDisabled _IsDisabledFunc;
                internal static _IsDisabled IsDisabled() {
                    if (_IsDisabledFunc == null) {
                        _IsDisabledFunc =
                            (_IsDisabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isDisabled"), typeof(_IsDisabled));
                    }

                    return _IsDisabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsDestroyed__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsDestroyed(IntPtr _this);
                internal delegate bool _IsDestroyed(IntPtr _this, IsDestroyed__Args args);
                private static _IsDestroyed _IsDestroyedFunc;
                internal static _IsDestroyed IsDestroyed() {
                    if (_IsDestroyedFunc == null) {
                        _IsDestroyedFunc =
                            (_IsDestroyed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isDestroyed"), typeof(_IsDestroyed));
                    }

                    return _IsDestroyedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDamageState__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetDamageState(IntPtr _this);
                internal delegate IntPtr _GetDamageState(IntPtr _this, GetDamageState__Args args);
                private static _GetDamageState _GetDamageStateFunc;
                internal static _GetDamageState GetDamageState() {
                    if (_GetDamageStateFunc == null) {
                        _GetDamageStateFunc =
                            (_GetDamageState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getDamageState"), typeof(_GetDamageState));
                    }

                    return _GetDamageStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDamageState__Args
                {

				   internal string state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetDamageState(IntPtr _this, string state);
                internal delegate bool _SetDamageState(IntPtr _this, SetDamageState__Args args);
                private static _SetDamageState _SetDamageStateFunc;
                internal static _SetDamageState SetDamageState() {
                    if (_SetDamageStateFunc == null) {
                        _SetDamageStateFunc =
                            (_SetDamageState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setDamageState"), typeof(_SetDamageState));
                    }

                    return _SetDamageStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMaxDamage__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetMaxDamage(IntPtr _this);
                internal delegate float _GetMaxDamage(IntPtr _this, GetMaxDamage__Args args);
                private static _GetMaxDamage _GetMaxDamageFunc;
                internal static _GetMaxDamage GetMaxDamage() {
                    if (_GetMaxDamageFunc == null) {
                        _GetMaxDamageFunc =
                            (_GetMaxDamage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getMaxDamage"), typeof(_GetMaxDamage));
                    }

                    return _GetMaxDamageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDamagePercent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDamagePercent(IntPtr _this);
                internal delegate float _GetDamagePercent(IntPtr _this, GetDamagePercent__Args args);
                private static _GetDamagePercent _GetDamagePercentFunc;
                internal static _GetDamagePercent GetDamagePercent() {
                    if (_GetDamagePercentFunc == null) {
                        _GetDamagePercentFunc =
                            (_GetDamagePercent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getDamagePercent"), typeof(_GetDamagePercent));
                    }

                    return _GetDamagePercentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDamageLevel__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDamageLevel(IntPtr _this);
                internal delegate float _GetDamageLevel(IntPtr _this, GetDamageLevel__Args args);
                private static _GetDamageLevel _GetDamageLevelFunc;
                internal static _GetDamageLevel GetDamageLevel() {
                    if (_GetDamageLevelFunc == null) {
                        _GetDamageLevelFunc =
                            (_GetDamageLevel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getDamageLevel"), typeof(_GetDamageLevel));
                    }

                    return _GetDamageLevelFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDamageLevel__Args
                {

				   internal float level;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetDamageLevel(IntPtr _this, float level);
                internal delegate void _SetDamageLevel(IntPtr _this, SetDamageLevel__Args args);
                private static _SetDamageLevel _SetDamageLevelFunc;
                internal static _SetDamageLevel SetDamageLevel() {
                    if (_SetDamageLevelFunc == null) {
                        _SetDamageLevelFunc =
                            (_SetDamageLevel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setDamageLevel"), typeof(_SetDamageLevel));
                    }

                    return _SetDamageLevelFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEnergyPercent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetEnergyPercent(IntPtr _this);
                internal delegate float _GetEnergyPercent(IntPtr _this, GetEnergyPercent__Args args);
                private static _GetEnergyPercent _GetEnergyPercentFunc;
                internal static _GetEnergyPercent GetEnergyPercent() {
                    if (_GetEnergyPercentFunc == null) {
                        _GetEnergyPercentFunc =
                            (_GetEnergyPercent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getEnergyPercent"), typeof(_GetEnergyPercent));
                    }

                    return _GetEnergyPercentFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEnergyLevel__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetEnergyLevel(IntPtr _this);
                internal delegate float _GetEnergyLevel(IntPtr _this, GetEnergyLevel__Args args);
                private static _GetEnergyLevel _GetEnergyLevelFunc;
                internal static _GetEnergyLevel GetEnergyLevel() {
                    if (_GetEnergyLevelFunc == null) {
                        _GetEnergyLevelFunc =
                            (_GetEnergyLevel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getEnergyLevel"), typeof(_GetEnergyLevel));
                    }

                    return _GetEnergyLevelFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetEnergyLevel__Args
                {

				   internal float level;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetEnergyLevel(IntPtr _this, float level);
                internal delegate void _SetEnergyLevel(IntPtr _this, SetEnergyLevel__Args args);
                private static _SetEnergyLevel _SetEnergyLevelFunc;
                internal static _SetEnergyLevel SetEnergyLevel() {
                    if (_SetEnergyLevelFunc == null) {
                        _SetEnergyLevelFunc =
                            (_SetEnergyLevel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setEnergyLevel"), typeof(_SetEnergyLevel));
                    }

                    return _SetEnergyLevelFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLookAtPoint__Args
                {

				   internal float distance;

				   internal uint typeMask;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetLookAtPoint(IntPtr _this, float distance, uint typeMask);
                internal delegate IntPtr _GetLookAtPoint(IntPtr _this, GetLookAtPoint__Args args);
                private static _GetLookAtPoint _GetLookAtPointFunc;
                internal static _GetLookAtPoint GetLookAtPoint() {
                    if (_GetLookAtPointFunc == null) {
                        _GetLookAtPointFunc =
                            (_GetLookAtPoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getLookAtPoint"), typeof(_GetLookAtPoint));
                    }

                    return _GetLookAtPointFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEyeTransform__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate TransformF.InternalStruct _GetEyeTransform(IntPtr _this);
                internal delegate TransformF.InternalStruct _GetEyeTransform(IntPtr _this, GetEyeTransform__Args args);
                private static _GetEyeTransform _GetEyeTransformFunc;
                internal static _GetEyeTransform GetEyeTransform() {
                    if (_GetEyeTransformFunc == null) {
                        _GetEyeTransformFunc =
                            (_GetEyeTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getEyeTransform"), typeof(_GetEyeTransform));
                    }

                    return _GetEyeTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEyePoint__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetEyePoint(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetEyePoint(IntPtr _this, GetEyePoint__Args args);
                private static _GetEyePoint _GetEyePointFunc;
                internal static _GetEyePoint GetEyePoint() {
                    if (_GetEyePointFunc == null) {
                        _GetEyePointFunc =
                            (_GetEyePoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getEyePoint"), typeof(_GetEyePoint));
                    }

                    return _GetEyePointFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetEyeVector__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetEyeVector(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetEyeVector(IntPtr _this, GetEyeVector__Args args);
                private static _GetEyeVector _GetEyeVectorFunc;
                internal static _GetEyeVector GetEyeVector() {
                    if (_GetEyeVectorFunc == null) {
                        _GetEyeVectorFunc =
                            (_GetEyeVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getEyeVector"), typeof(_GetEyeVector));
                    }

                    return _GetEyeVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ApplyImpulse__Args
                {

				   internal IntPtr pos;

				   internal IntPtr vec;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ApplyImpulse(IntPtr _this, IntPtr pos, IntPtr vec);
                internal delegate bool _ApplyImpulse(IntPtr _this, ApplyImpulse__Args args);
                private static _ApplyImpulse _ApplyImpulseFunc;
                internal static _ApplyImpulse ApplyImpulse() {
                    if (_ApplyImpulseFunc == null) {
                        _ApplyImpulseFunc =
                            (_ApplyImpulse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_applyImpulse"), typeof(_ApplyImpulse));
                    }

                    return _ApplyImpulseFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetVelocity__Args
                {

				   internal IntPtr vel;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetVelocity(IntPtr _this, IntPtr vel);
                internal delegate bool _SetVelocity(IntPtr _this, SetVelocity__Args args);
                private static _SetVelocity _SetVelocityFunc;
                internal static _SetVelocity SetVelocity() {
                    if (_SetVelocityFunc == null) {
                        _SetVelocityFunc =
                            (_SetVelocity)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setVelocity"), typeof(_SetVelocity));
                    }

                    return _SetVelocityFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetVelocity__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetVelocity(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetVelocity(IntPtr _this, GetVelocity__Args args);
                private static _GetVelocity _GetVelocityFunc;
                internal static _GetVelocity GetVelocity() {
                    if (_GetVelocityFunc == null) {
                        _GetVelocityFunc =
                            (_GetVelocity)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getVelocity"), typeof(_GetVelocity));
                    }

                    return _GetVelocityFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAIRepairPoint__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetAIRepairPoint(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetAIRepairPoint(IntPtr _this, GetAIRepairPoint__Args args);
                private static _GetAIRepairPoint _GetAIRepairPointFunc;
                internal static _GetAIRepairPoint GetAIRepairPoint() {
                    if (_GetAIRepairPointFunc == null) {
                        _GetAIRepairPointFunc =
                            (_GetAIRepairPoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getAIRepairPoint"), typeof(_GetAIRepairPoint));
                    }

                    return _GetAIRepairPointFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSlotTransform__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate TransformF.InternalStruct _GetSlotTransform(IntPtr _this, int slot);
                internal delegate TransformF.InternalStruct _GetSlotTransform(IntPtr _this, GetSlotTransform__Args args);
                private static _GetSlotTransform _GetSlotTransformFunc;
                internal static _GetSlotTransform GetSlotTransform() {
                    if (_GetSlotTransformFunc == null) {
                        _GetSlotTransformFunc =
                            (_GetSlotTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getSlotTransform"), typeof(_GetSlotTransform));
                    }

                    return _GetSlotTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMuzzlePoint__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetMuzzlePoint(IntPtr _this, int slot);
                internal delegate Point3F.InternalStruct _GetMuzzlePoint(IntPtr _this, GetMuzzlePoint__Args args);
                private static _GetMuzzlePoint _GetMuzzlePointFunc;
                internal static _GetMuzzlePoint GetMuzzlePoint() {
                    if (_GetMuzzlePointFunc == null) {
                        _GetMuzzlePointFunc =
                            (_GetMuzzlePoint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getMuzzlePoint"), typeof(_GetMuzzlePoint));
                    }

                    return _GetMuzzlePointFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMuzzleVector__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetMuzzleVector(IntPtr _this, int slot);
                internal delegate Point3F.InternalStruct _GetMuzzleVector(IntPtr _this, GetMuzzleVector__Args args);
                private static _GetMuzzleVector _GetMuzzleVectorFunc;
                internal static _GetMuzzleVector GetMuzzleVector() {
                    if (_GetMuzzleVectorFunc == null) {
                        _GetMuzzleVectorFunc =
                            (_GetMuzzleVector)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getMuzzleVector"), typeof(_GetMuzzleVector));
                    }

                    return _GetMuzzleVectorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageScriptAnimPrefix__Args
                {

				   internal int slot;

				   internal string prefix;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetImageScriptAnimPrefix(IntPtr _this, int slot, string prefix);
                internal delegate void _SetImageScriptAnimPrefix(IntPtr _this, SetImageScriptAnimPrefix__Args args);
                private static _SetImageScriptAnimPrefix _SetImageScriptAnimPrefixFunc;
                internal static _SetImageScriptAnimPrefix SetImageScriptAnimPrefix() {
                    if (_SetImageScriptAnimPrefixFunc == null) {
                        _SetImageScriptAnimPrefixFunc =
                            (_SetImageScriptAnimPrefix)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageScriptAnimPrefix"), typeof(_SetImageScriptAnimPrefix));
                    }

                    return _SetImageScriptAnimPrefixFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageScriptAnimPrefix__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetImageScriptAnimPrefix(IntPtr _this, int slot);
                internal delegate IntPtr _GetImageScriptAnimPrefix(IntPtr _this, GetImageScriptAnimPrefix__Args args);
                private static _GetImageScriptAnimPrefix _GetImageScriptAnimPrefixFunc;
                internal static _GetImageScriptAnimPrefix GetImageScriptAnimPrefix() {
                    if (_GetImageScriptAnimPrefixFunc == null) {
                        _GetImageScriptAnimPrefixFunc =
                            (_GetImageScriptAnimPrefix)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageScriptAnimPrefix"), typeof(_GetImageScriptAnimPrefix));
                    }

                    return _GetImageScriptAnimPrefixFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageTarget__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetImageTarget(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate bool _SetImageTarget(IntPtr _this, SetImageTarget__Args args);
                private static _SetImageTarget _SetImageTargetFunc;
                internal static _SetImageTarget SetImageTarget() {
                    if (_SetImageTargetFunc == null) {
                        _SetImageTargetFunc =
                            (_SetImageTarget)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageTarget"), typeof(_SetImageTarget));
                    }

                    return _SetImageTargetFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageTarget__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageTarget(IntPtr _this, int slot);
                internal delegate bool _GetImageTarget(IntPtr _this, GetImageTarget__Args args);
                private static _GetImageTarget _GetImageTargetFunc;
                internal static _GetImageTarget GetImageTarget() {
                    if (_GetImageTargetFunc == null) {
                        _GetImageTargetFunc =
                            (_GetImageTarget)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageTarget"), typeof(_GetImageTarget));
                    }

                    return _GetImageTargetFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageLoaded__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetImageLoaded(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate bool _SetImageLoaded(IntPtr _this, SetImageLoaded__Args args);
                private static _SetImageLoaded _SetImageLoadedFunc;
                internal static _SetImageLoaded SetImageLoaded() {
                    if (_SetImageLoadedFunc == null) {
                        _SetImageLoadedFunc =
                            (_SetImageLoaded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageLoaded"), typeof(_SetImageLoaded));
                    }

                    return _SetImageLoadedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageLoaded__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageLoaded(IntPtr _this, int slot);
                internal delegate bool _GetImageLoaded(IntPtr _this, GetImageLoaded__Args args);
                private static _GetImageLoaded _GetImageLoadedFunc;
                internal static _GetImageLoaded GetImageLoaded() {
                    if (_GetImageLoadedFunc == null) {
                        _GetImageLoadedFunc =
                            (_GetImageLoaded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageLoaded"), typeof(_GetImageLoaded));
                    }

                    return _GetImageLoadedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageAmmo__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetImageAmmo(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate bool _SetImageAmmo(IntPtr _this, SetImageAmmo__Args args);
                private static _SetImageAmmo _SetImageAmmoFunc;
                internal static _SetImageAmmo SetImageAmmo() {
                    if (_SetImageAmmoFunc == null) {
                        _SetImageAmmoFunc =
                            (_SetImageAmmo)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageAmmo"), typeof(_SetImageAmmo));
                    }

                    return _SetImageAmmoFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageAmmo__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageAmmo(IntPtr _this, int slot);
                internal delegate bool _GetImageAmmo(IntPtr _this, GetImageAmmo__Args args);
                private static _GetImageAmmo _GetImageAmmoFunc;
                internal static _GetImageAmmo GetImageAmmo() {
                    if (_GetImageAmmoFunc == null) {
                        _GetImageAmmoFunc =
                            (_GetImageAmmo)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageAmmo"), typeof(_GetImageAmmo));
                    }

                    return _GetImageAmmoFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageAltTrigger__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetImageAltTrigger(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate bool _SetImageAltTrigger(IntPtr _this, SetImageAltTrigger__Args args);
                private static _SetImageAltTrigger _SetImageAltTriggerFunc;
                internal static _SetImageAltTrigger SetImageAltTrigger() {
                    if (_SetImageAltTriggerFunc == null) {
                        _SetImageAltTriggerFunc =
                            (_SetImageAltTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageAltTrigger"), typeof(_SetImageAltTrigger));
                    }

                    return _SetImageAltTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageAltTrigger__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageAltTrigger(IntPtr _this, int slot);
                internal delegate bool _GetImageAltTrigger(IntPtr _this, GetImageAltTrigger__Args args);
                private static _GetImageAltTrigger _GetImageAltTriggerFunc;
                internal static _GetImageAltTrigger GetImageAltTrigger() {
                    if (_GetImageAltTriggerFunc == null) {
                        _GetImageAltTriggerFunc =
                            (_GetImageAltTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageAltTrigger"), typeof(_GetImageAltTrigger));
                    }

                    return _GetImageAltTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageGenericTrigger__Args
                {

				   internal int slot;

				   internal int trigger;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _SetImageGenericTrigger(IntPtr _this, int slot, int trigger, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate int _SetImageGenericTrigger(IntPtr _this, SetImageGenericTrigger__Args args);
                private static _SetImageGenericTrigger _SetImageGenericTriggerFunc;
                internal static _SetImageGenericTrigger SetImageGenericTrigger() {
                    if (_SetImageGenericTriggerFunc == null) {
                        _SetImageGenericTriggerFunc =
                            (_SetImageGenericTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageGenericTrigger"), typeof(_SetImageGenericTrigger));
                    }

                    return _SetImageGenericTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageGenericTrigger__Args
                {

				   internal int slot;

				   internal int trigger;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageGenericTrigger(IntPtr _this, int slot, int trigger);
                internal delegate bool _GetImageGenericTrigger(IntPtr _this, GetImageGenericTrigger__Args args);
                private static _GetImageGenericTrigger _GetImageGenericTriggerFunc;
                internal static _GetImageGenericTrigger GetImageGenericTrigger() {
                    if (_GetImageGenericTriggerFunc == null) {
                        _GetImageGenericTriggerFunc =
                            (_GetImageGenericTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageGenericTrigger"), typeof(_GetImageGenericTrigger));
                    }

                    return _GetImageGenericTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetImageTrigger__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetImageTrigger(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate bool _SetImageTrigger(IntPtr _this, SetImageTrigger__Args args);
                private static _SetImageTrigger _SetImageTriggerFunc;
                internal static _SetImageTrigger SetImageTrigger() {
                    if (_SetImageTriggerFunc == null) {
                        _SetImageTriggerFunc =
                            (_SetImageTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setImageTrigger"), typeof(_SetImageTrigger));
                    }

                    return _SetImageTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageTrigger__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetImageTrigger(IntPtr _this, int slot);
                internal delegate bool _GetImageTrigger(IntPtr _this, GetImageTrigger__Args args);
                private static _GetImageTrigger _GetImageTriggerFunc;
                internal static _GetImageTrigger GetImageTrigger() {
                    if (_GetImageTriggerFunc == null) {
                        _GetImageTriggerFunc =
                            (_GetImageTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageTrigger"), typeof(_GetImageTrigger));
                    }

                    return _GetImageTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct HasImageState__Args
                {

				   internal int slot;

				   internal string state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _HasImageState(IntPtr _this, int slot, string state);
                internal delegate bool _HasImageState(IntPtr _this, HasImageState__Args args);
                private static _HasImageState _HasImageStateFunc;
                internal static _HasImageState HasImageState() {
                    if (_HasImageStateFunc == null) {
                        _HasImageStateFunc =
                            (_HasImageState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_hasImageState"), typeof(_HasImageState));
                    }

                    return _HasImageStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageState__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetImageState(IntPtr _this, int slot);
                internal delegate IntPtr _GetImageState(IntPtr _this, GetImageState__Args args);
                private static _GetImageState _GetImageStateFunc;
                internal static _GetImageState GetImageState() {
                    if (_GetImageStateFunc == null) {
                        _GetImageStateFunc =
                            (_GetImageState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageState"), typeof(_GetImageState));
                    }

                    return _GetImageStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetImageSkinTag__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetImageSkinTag(IntPtr _this, int slot);
                internal delegate int _GetImageSkinTag(IntPtr _this, GetImageSkinTag__Args args);
                private static _GetImageSkinTag _GetImageSkinTagFunc;
                internal static _GetImageSkinTag GetImageSkinTag() {
                    if (_GetImageSkinTagFunc == null) {
                        _GetImageSkinTagFunc =
                            (_GetImageSkinTag)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getImageSkinTag"), typeof(_GetImageSkinTag));
                    }

                    return _GetImageSkinTagFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountSlot__Args
                {

				   internal IntPtr image;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountSlot(IntPtr _this, IntPtr image);
                internal delegate int _GetMountSlot(IntPtr _this, GetMountSlot__Args args);
                private static _GetMountSlot _GetMountSlotFunc;
                internal static _GetMountSlot GetMountSlot() {
                    if (_GetMountSlotFunc == null) {
                        _GetMountSlotFunc =
                            (_GetMountSlot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getMountSlot"), typeof(_GetMountSlot));
                    }

                    return _GetMountSlotFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsImageMounted__Args
                {

				   internal IntPtr image;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsImageMounted(IntPtr _this, IntPtr image);
                internal delegate bool _IsImageMounted(IntPtr _this, IsImageMounted__Args args);
                private static _IsImageMounted _IsImageMountedFunc;
                internal static _IsImageMounted IsImageMounted() {
                    if (_IsImageMountedFunc == null) {
                        _IsImageMountedFunc =
                            (_IsImageMounted)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isImageMounted"), typeof(_IsImageMounted));
                    }

                    return _IsImageMountedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsImageFiring__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsImageFiring(IntPtr _this, int slot);
                internal delegate bool _IsImageFiring(IntPtr _this, IsImageFiring__Args args);
                private static _IsImageFiring _IsImageFiringFunc;
                internal static _IsImageFiring IsImageFiring() {
                    if (_IsImageFiringFunc == null) {
                        _IsImageFiringFunc =
                            (_IsImageFiring)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isImageFiring"), typeof(_IsImageFiring));
                    }

                    return _IsImageFiringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPendingImage__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetPendingImage(IntPtr _this, int slot);
                internal delegate int _GetPendingImage(IntPtr _this, GetPendingImage__Args args);
                private static _GetPendingImage _GetPendingImageFunc;
                internal static _GetPendingImage GetPendingImage() {
                    if (_GetPendingImageFunc == null) {
                        _GetPendingImageFunc =
                            (_GetPendingImage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getPendingImage"), typeof(_GetPendingImage));
                    }

                    return _GetPendingImageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountedImage__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetMountedImage(IntPtr _this, int slot);
                internal delegate int _GetMountedImage(IntPtr _this, GetMountedImage__Args args);
                private static _GetMountedImage _GetMountedImageFunc;
                internal static _GetMountedImage GetMountedImage() {
                    if (_GetMountedImageFunc == null) {
                        _GetMountedImageFunc =
                            (_GetMountedImage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_getMountedImage"), typeof(_GetMountedImage));
                    }

                    return _GetMountedImageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct UnmountImage__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _UnmountImage(IntPtr _this, int slot);
                internal delegate bool _UnmountImage(IntPtr _this, UnmountImage__Args args);
                private static _UnmountImage _UnmountImageFunc;
                internal static _UnmountImage UnmountImage() {
                    if (_UnmountImageFunc == null) {
                        _UnmountImageFunc =
                            (_UnmountImage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_unmountImage"), typeof(_UnmountImage));
                    }

                    return _UnmountImageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct MountImage__Args
                {

				   internal IntPtr image;

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool loaded;

				   internal string skinTag;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _MountImage(IntPtr _this, IntPtr image, int slot, [MarshalAs(UnmanagedType.I1)]bool loaded, string skinTag);
                internal delegate bool _MountImage(IntPtr _this, MountImage__Args args);
                private static _MountImage _MountImageFunc;
                internal static _MountImage MountImage() {
                    if (_MountImageFunc == null) {
                        _MountImageFunc =
                            (_MountImage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_mountImage"), typeof(_MountImage));
                    }

                    return _MountImageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PauseThread__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PauseThread(IntPtr _this, int slot);
                internal delegate bool _PauseThread(IntPtr _this, PauseThread__Args args);
                private static _PauseThread _PauseThreadFunc;
                internal static _PauseThread PauseThread() {
                    if (_PauseThreadFunc == null) {
                        _PauseThreadFunc =
                            (_PauseThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_pauseThread"), typeof(_PauseThread));
                    }

                    return _PauseThreadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DestroyThread__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _DestroyThread(IntPtr _this, int slot);
                internal delegate bool _DestroyThread(IntPtr _this, DestroyThread__Args args);
                private static _DestroyThread _DestroyThreadFunc;
                internal static _DestroyThread DestroyThread() {
                    if (_DestroyThreadFunc == null) {
                        _DestroyThreadFunc =
                            (_DestroyThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_destroyThread"), typeof(_DestroyThread));
                    }

                    return _DestroyThreadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StopThread__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _StopThread(IntPtr _this, int slot);
                internal delegate bool _StopThread(IntPtr _this, StopThread__Args args);
                private static _StopThread _StopThreadFunc;
                internal static _StopThread StopThread() {
                    if (_StopThreadFunc == null) {
                        _StopThreadFunc =
                            (_StopThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_stopThread"), typeof(_StopThread));
                    }

                    return _StopThreadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetThreadPosition__Args
                {

				   internal int slot;

				   internal float pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetThreadPosition(IntPtr _this, int slot, float pos);
                internal delegate bool _SetThreadPosition(IntPtr _this, SetThreadPosition__Args args);
                private static _SetThreadPosition _SetThreadPositionFunc;
                internal static _SetThreadPosition SetThreadPosition() {
                    if (_SetThreadPositionFunc == null) {
                        _SetThreadPositionFunc =
                            (_SetThreadPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setThreadPosition"), typeof(_SetThreadPosition));
                    }

                    return _SetThreadPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetThreadTimeScale__Args
                {

				   internal int slot;

				   internal float scale;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetThreadTimeScale(IntPtr _this, int slot, float scale);
                internal delegate bool _SetThreadTimeScale(IntPtr _this, SetThreadTimeScale__Args args);
                private static _SetThreadTimeScale _SetThreadTimeScaleFunc;
                internal static _SetThreadTimeScale SetThreadTimeScale() {
                    if (_SetThreadTimeScaleFunc == null) {
                        _SetThreadTimeScaleFunc =
                            (_SetThreadTimeScale)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setThreadTimeScale"), typeof(_SetThreadTimeScale));
                    }

                    return _SetThreadTimeScaleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetThreadDir__Args
                {

				   internal int slot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool fwd;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetThreadDir(IntPtr _this, int slot, [MarshalAs(UnmanagedType.I1)]bool fwd);
                internal delegate bool _SetThreadDir(IntPtr _this, SetThreadDir__Args args);
                private static _SetThreadDir _SetThreadDirFunc;
                internal static _SetThreadDir SetThreadDir() {
                    if (_SetThreadDirFunc == null) {
                        _SetThreadDirFunc =
                            (_SetThreadDir)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setThreadDir"), typeof(_SetThreadDir));
                    }

                    return _SetThreadDirFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PlayThread__Args
                {

				   internal int slot;

				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PlayThread(IntPtr _this, int slot, string name);
                internal delegate bool _PlayThread(IntPtr _this, PlayThread__Args args);
                private static _PlayThread _PlayThreadFunc;
                internal static _PlayThread PlayThread() {
                    if (_PlayThreadFunc == null) {
                        _PlayThreadFunc =
                            (_PlayThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_playThread"), typeof(_PlayThread));
                    }

                    return _PlayThreadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StopAudio__Args
                {

				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _StopAudio(IntPtr _this, int slot);
                internal delegate bool _StopAudio(IntPtr _this, StopAudio__Args args);
                private static _StopAudio _StopAudioFunc;
                internal static _StopAudio StopAudio() {
                    if (_StopAudioFunc == null) {
                        _StopAudioFunc =
                            (_StopAudio)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_stopAudio"), typeof(_StopAudio));
                    }

                    return _StopAudioFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PlayAudio__Args
                {

				   internal int slot;

				   internal IntPtr track;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PlayAudio(IntPtr _this, int slot, IntPtr track);
                internal delegate bool _PlayAudio(IntPtr _this, PlayAudio__Args args);
                private static _PlayAudio _PlayAudioFunc;
                internal static _PlayAudio PlayAudio() {
                    if (_PlayAudioFunc == null) {
                        _PlayAudioFunc =
                            (_PlayAudio)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_playAudio"), typeof(_PlayAudio));
                    }

                    return _PlayAudioFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsHidden__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsHidden(IntPtr _this);
                internal delegate bool _IsHidden(IntPtr _this, IsHidden__Args args);
                private static _IsHidden _IsHiddenFunc;
                internal static _IsHidden IsHidden() {
                    if (_IsHiddenFunc == null) {
                        _IsHiddenFunc =
                            (_IsHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_isHidden"), typeof(_IsHidden));
                    }

                    return _IsHiddenFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetHidden__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool show;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetHidden(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool show);
                internal delegate void _SetHidden(IntPtr _this, SetHidden__Args args);
                private static _SetHidden _SetHiddenFunc;
                internal static _SetHidden SetHidden() {
                    if (_SetHiddenFunc == null) {
                        _SetHiddenFunc =
                            (_SetHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBase_setHidden"), typeof(_SetHidden));
                    }

                    return _SetHiddenFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ValidateCameraFov__Args
                {

				   internal float fov;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _ValidateCameraFov(IntPtr _this, float fov);
                internal delegate float _ValidateCameraFov(IntPtr _this, ValidateCameraFov__Args args);
                private static _ValidateCameraFov _ValidateCameraFovFunc;
                internal static _ValidateCameraFov ValidateCameraFov() {
                    if (_ValidateCameraFovFunc == null) {
                        _ValidateCameraFovFunc =
                            (_ValidateCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBase_validateCameraFov"), typeof(_ValidateCameraFov));
                    }

                    return _ValidateCameraFovFunc;
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
                                    "fnShapeBase_staticGetType"), typeof(_StaticGetType));
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
                                    "fnShapeBase_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public string GetModelFile() {

                     InternalUnsafeMethods.GetModelFile__Args _args = new InternalUnsafeMethods.GetModelFile__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetModelFile()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void ChangeMaterial(string mapTo, Material oldMat, Material newMat) {

                                                                                    InternalUnsafeMethods.ChangeMaterial__Args _args = new InternalUnsafeMethods.ChangeMaterial__Args() {
                        mapTo = mapTo,
                        oldMat = oldMat.ObjectPtr,
                        newMat = newMat.ObjectPtr,
                     };
                     InternalUnsafeMethods.ChangeMaterial()(ObjectPtr, _args);

                  }



                  public int GetTargetCount() {

                     InternalUnsafeMethods.GetTargetCount__Args _args = new InternalUnsafeMethods.GetTargetCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetTargetCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetTargetName(int index) {

                                          InternalUnsafeMethods.GetTargetName__Args _args = new InternalUnsafeMethods.GetTargetName__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetTargetName()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void DumpMeshVisibility() {

                     InternalUnsafeMethods.DumpMeshVisibility__Args _args = new InternalUnsafeMethods.DumpMeshVisibility__Args() {
                     };
                     InternalUnsafeMethods.DumpMeshVisibility()(ObjectPtr, _args);

                  }



                  public void SetMeshHidden(string name, bool hide) {

                                                               InternalUnsafeMethods.SetMeshHidden__Args _args = new InternalUnsafeMethods.SetMeshHidden__Args() {
                        name = name,
                        hide = hide,
                     };
                     InternalUnsafeMethods.SetMeshHidden()(ObjectPtr, _args);

                  }



                  public void SetAllMeshesHidden(bool hide) {

                                          InternalUnsafeMethods.SetAllMeshesHidden__Args _args = new InternalUnsafeMethods.SetAllMeshesHidden__Args() {
                        hide = hide,
                     };
                     InternalUnsafeMethods.SetAllMeshesHidden()(ObjectPtr, _args);

                  }



                  public string GetSkinName() {

                     InternalUnsafeMethods.GetSkinName__Args _args = new InternalUnsafeMethods.GetSkinName__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSkinName()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetSkinName(string name) {

                                          InternalUnsafeMethods.SetSkinName__Args _args = new InternalUnsafeMethods.SetSkinName__Args() {
                        name = name,
                     };
                     InternalUnsafeMethods.SetSkinName()(ObjectPtr, _args);

                  }



                  public string GetShapeName() {

                     InternalUnsafeMethods.GetShapeName__Args _args = new InternalUnsafeMethods.GetShapeName__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetShapeName()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetShapeName(string name) {

                                          InternalUnsafeMethods.SetShapeName__Args _args = new InternalUnsafeMethods.SetShapeName__Args() {
                        name = name,
                     };
                     InternalUnsafeMethods.SetShapeName()(ObjectPtr, _args);

                  }



                  public void SetDamageVector(Point3F vec) {

                     vec.Alloc();                     InternalUnsafeMethods.SetDamageVector__Args _args = new InternalUnsafeMethods.SetDamageVector__Args() {
                        vec = vec.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetDamageVector()(ObjectPtr, _args);
                                          vec.Free();
                  }



                  public void StartFade(int time, int delay, bool fadeOut) {

                                                                                    InternalUnsafeMethods.StartFade__Args _args = new InternalUnsafeMethods.StartFade__Args() {
                        time = time,
                        delay = delay,
                        fadeOut = fadeOut,
                     };
                     InternalUnsafeMethods.StartFade()(ObjectPtr, _args);

                  }



                  public void SetCameraFov(float fov) {

                                          InternalUnsafeMethods.SetCameraFov__Args _args = new InternalUnsafeMethods.SetCameraFov__Args() {
                        fov = fov,
                     };
                     InternalUnsafeMethods.SetCameraFov()(ObjectPtr, _args);

                  }



                  public float GetCameraFov() {

                     InternalUnsafeMethods.GetCameraFov__Args _args = new InternalUnsafeMethods.GetCameraFov__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetCameraFov()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetDefaultCameraFov() {

                     InternalUnsafeMethods.GetDefaultCameraFov__Args _args = new InternalUnsafeMethods.GetDefaultCameraFov__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDefaultCameraFov()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetWhiteOut() {

                     InternalUnsafeMethods.GetWhiteOut__Args _args = new InternalUnsafeMethods.GetWhiteOut__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetWhiteOut()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetWhiteOut(float level) {

                                          InternalUnsafeMethods.SetWhiteOut__Args _args = new InternalUnsafeMethods.SetWhiteOut__Args() {
                        level = level,
                     };
                     InternalUnsafeMethods.SetWhiteOut()(ObjectPtr, _args);

                  }



                  public float GetDamageFlash() {

                     InternalUnsafeMethods.GetDamageFlash__Args _args = new InternalUnsafeMethods.GetDamageFlash__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDamageFlash()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetDamageFlash(float level) {

                                          InternalUnsafeMethods.SetDamageFlash__Args _args = new InternalUnsafeMethods.SetDamageFlash__Args() {
                        level = level,
                     };
                     InternalUnsafeMethods.SetDamageFlash()(ObjectPtr, _args);

                  }



                  public bool IsCloaked() {

                     InternalUnsafeMethods.IsCloaked__Args _args = new InternalUnsafeMethods.IsCloaked__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsCloaked()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetCloaked(bool cloak) {

                                          InternalUnsafeMethods.SetCloaked__Args _args = new InternalUnsafeMethods.SetCloaked__Args() {
                        cloak = cloak,
                     };
                     InternalUnsafeMethods.SetCloaked()(ObjectPtr, _args);

                  }



                  public bool CanCloak() {

                     InternalUnsafeMethods.CanCloak__Args _args = new InternalUnsafeMethods.CanCloak__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.CanCloak()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetControllingObject() {

                     InternalUnsafeMethods.GetControllingObject__Args _args = new InternalUnsafeMethods.GetControllingObject__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetControllingObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetControllingClient() {

                     InternalUnsafeMethods.GetControllingClient__Args _args = new InternalUnsafeMethods.GetControllingClient__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetControllingClient()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetRechargeRate() {

                     InternalUnsafeMethods.GetRechargeRate__Args _args = new InternalUnsafeMethods.GetRechargeRate__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetRechargeRate()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetRechargeRate(float rate) {

                                          InternalUnsafeMethods.SetRechargeRate__Args _args = new InternalUnsafeMethods.SetRechargeRate__Args() {
                        rate = rate,
                     };
                     InternalUnsafeMethods.SetRechargeRate()(ObjectPtr, _args);

                  }



                  public float GetRepairRate() {

                     InternalUnsafeMethods.GetRepairRate__Args _args = new InternalUnsafeMethods.GetRepairRate__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetRepairRate()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetRepairRate(float rate) {

                                          InternalUnsafeMethods.SetRepairRate__Args _args = new InternalUnsafeMethods.SetRepairRate__Args() {
                        rate = rate,
                     };
                     InternalUnsafeMethods.SetRepairRate()(ObjectPtr, _args);

                  }



                  public void ApplyRepair(float amount) {

                                          InternalUnsafeMethods.ApplyRepair__Args _args = new InternalUnsafeMethods.ApplyRepair__Args() {
                        amount = amount,
                     };
                     InternalUnsafeMethods.ApplyRepair()(ObjectPtr, _args);

                  }



                  public void ApplyDamage(float amount) {

                                          InternalUnsafeMethods.ApplyDamage__Args _args = new InternalUnsafeMethods.ApplyDamage__Args() {
                        amount = amount,
                     };
                     InternalUnsafeMethods.ApplyDamage()(ObjectPtr, _args);

                  }



                  public void BlowUp() {

                     InternalUnsafeMethods.BlowUp__Args _args = new InternalUnsafeMethods.BlowUp__Args() {
                     };
                     InternalUnsafeMethods.BlowUp()(ObjectPtr, _args);

                  }



                  public bool IsEnabled() {

                     InternalUnsafeMethods.IsEnabled__Args _args = new InternalUnsafeMethods.IsEnabled__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsEnabled()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsDisabled() {

                     InternalUnsafeMethods.IsDisabled__Args _args = new InternalUnsafeMethods.IsDisabled__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsDisabled()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsDestroyed() {

                     InternalUnsafeMethods.IsDestroyed__Args _args = new InternalUnsafeMethods.IsDestroyed__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsDestroyed()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetDamageState() {

                     InternalUnsafeMethods.GetDamageState__Args _args = new InternalUnsafeMethods.GetDamageState__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetDamageState()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public bool SetDamageState(string state) {

                                          InternalUnsafeMethods.SetDamageState__Args _args = new InternalUnsafeMethods.SetDamageState__Args() {
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetDamageState()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetMaxDamage() {

                     InternalUnsafeMethods.GetMaxDamage__Args _args = new InternalUnsafeMethods.GetMaxDamage__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetMaxDamage()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetDamagePercent() {

                     InternalUnsafeMethods.GetDamagePercent__Args _args = new InternalUnsafeMethods.GetDamagePercent__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDamagePercent()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetDamageLevel() {

                     InternalUnsafeMethods.GetDamageLevel__Args _args = new InternalUnsafeMethods.GetDamageLevel__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDamageLevel()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetDamageLevel(float level) {

                                          InternalUnsafeMethods.SetDamageLevel__Args _args = new InternalUnsafeMethods.SetDamageLevel__Args() {
                        level = level,
                     };
                     InternalUnsafeMethods.SetDamageLevel()(ObjectPtr, _args);

                  }



                  public float GetEnergyPercent() {

                     InternalUnsafeMethods.GetEnergyPercent__Args _args = new InternalUnsafeMethods.GetEnergyPercent__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetEnergyPercent()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetEnergyLevel() {

                     InternalUnsafeMethods.GetEnergyLevel__Args _args = new InternalUnsafeMethods.GetEnergyLevel__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetEnergyLevel()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetEnergyLevel(float level) {

                                          InternalUnsafeMethods.SetEnergyLevel__Args _args = new InternalUnsafeMethods.SetEnergyLevel__Args() {
                        level = level,
                     };
                     InternalUnsafeMethods.SetEnergyLevel()(ObjectPtr, _args);

                  }



                  public string GetLookAtPoint(float distance = 2000f, uint typeMask = 4294967295) {

                                                               InternalUnsafeMethods.GetLookAtPoint__Args _args = new InternalUnsafeMethods.GetLookAtPoint__Args() {
                        distance = distance,
                        typeMask = typeMask,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetLookAtPoint()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public TransformF GetEyeTransform() {

                     InternalUnsafeMethods.GetEyeTransform__Args _args = new InternalUnsafeMethods.GetEyeTransform__Args() {
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetEyeTransform()(ObjectPtr, _args);

                     return new TransformF(_engineResult);
                  }



                  public Point3F GetEyePoint() {

                     InternalUnsafeMethods.GetEyePoint__Args _args = new InternalUnsafeMethods.GetEyePoint__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetEyePoint()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetEyeVector() {

                     InternalUnsafeMethods.GetEyeVector__Args _args = new InternalUnsafeMethods.GetEyeVector__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetEyeVector()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public bool ApplyImpulse(Point3F pos, Point3F vec) {

                     pos.Alloc();                     vec.Alloc();                     InternalUnsafeMethods.ApplyImpulse__Args _args = new InternalUnsafeMethods.ApplyImpulse__Args() {
                        pos = pos.internalStructPtr,
                        vec = vec.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.ApplyImpulse()(ObjectPtr, _args);
                                          pos.Free();                     vec.Free();
                     return _engineResult;
                  }



                  public bool SetVelocity(Point3F vel) {

                     vel.Alloc();                     InternalUnsafeMethods.SetVelocity__Args _args = new InternalUnsafeMethods.SetVelocity__Args() {
                        vel = vel.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetVelocity()(ObjectPtr, _args);
                                          vel.Free();
                     return _engineResult;
                  }



                  public Point3F GetVelocity() {

                     InternalUnsafeMethods.GetVelocity__Args _args = new InternalUnsafeMethods.GetVelocity__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetVelocity()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetAIRepairPoint() {

                     InternalUnsafeMethods.GetAIRepairPoint__Args _args = new InternalUnsafeMethods.GetAIRepairPoint__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetAIRepairPoint()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public TransformF GetSlotTransform(int slot) {

                                          InternalUnsafeMethods.GetSlotTransform__Args _args = new InternalUnsafeMethods.GetSlotTransform__Args() {
                        slot = slot,
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetSlotTransform()(ObjectPtr, _args);

                     return new TransformF(_engineResult);
                  }



                  public Point3F GetMuzzlePoint(int slot) {

                                          InternalUnsafeMethods.GetMuzzlePoint__Args _args = new InternalUnsafeMethods.GetMuzzlePoint__Args() {
                        slot = slot,
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMuzzlePoint()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetMuzzleVector(int slot) {

                                          InternalUnsafeMethods.GetMuzzleVector__Args _args = new InternalUnsafeMethods.GetMuzzleVector__Args() {
                        slot = slot,
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMuzzleVector()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public void SetImageScriptAnimPrefix(int slot, string prefix) {

                                                               InternalUnsafeMethods.SetImageScriptAnimPrefix__Args _args = new InternalUnsafeMethods.SetImageScriptAnimPrefix__Args() {
                        slot = slot,
                        prefix = prefix,
                     };
                     InternalUnsafeMethods.SetImageScriptAnimPrefix()(ObjectPtr, _args);

                  }



                  public string GetImageScriptAnimPrefix(int slot) {

                                          InternalUnsafeMethods.GetImageScriptAnimPrefix__Args _args = new InternalUnsafeMethods.GetImageScriptAnimPrefix__Args() {
                        slot = slot,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetImageScriptAnimPrefix()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public bool SetImageTarget(int slot, bool state) {

                                                               InternalUnsafeMethods.SetImageTarget__Args _args = new InternalUnsafeMethods.SetImageTarget__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetImageTarget()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageTarget(int slot) {

                                          InternalUnsafeMethods.GetImageTarget__Args _args = new InternalUnsafeMethods.GetImageTarget__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageTarget()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetImageLoaded(int slot, bool state) {

                                                               InternalUnsafeMethods.SetImageLoaded__Args _args = new InternalUnsafeMethods.SetImageLoaded__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetImageLoaded()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageLoaded(int slot) {

                                          InternalUnsafeMethods.GetImageLoaded__Args _args = new InternalUnsafeMethods.GetImageLoaded__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageLoaded()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetImageAmmo(int slot, bool state) {

                                                               InternalUnsafeMethods.SetImageAmmo__Args _args = new InternalUnsafeMethods.SetImageAmmo__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetImageAmmo()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageAmmo(int slot) {

                                          InternalUnsafeMethods.GetImageAmmo__Args _args = new InternalUnsafeMethods.GetImageAmmo__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageAmmo()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetImageAltTrigger(int slot, bool state) {

                                                               InternalUnsafeMethods.SetImageAltTrigger__Args _args = new InternalUnsafeMethods.SetImageAltTrigger__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetImageAltTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageAltTrigger(int slot) {

                                          InternalUnsafeMethods.GetImageAltTrigger__Args _args = new InternalUnsafeMethods.GetImageAltTrigger__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageAltTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int SetImageGenericTrigger(int slot, int trigger, bool state) {

                                                                                    InternalUnsafeMethods.SetImageGenericTrigger__Args _args = new InternalUnsafeMethods.SetImageGenericTrigger__Args() {
                        slot = slot,
                        trigger = trigger,
                        state = state,
                     };
                     int _engineResult = InternalUnsafeMethods.SetImageGenericTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageGenericTrigger(int slot, int trigger) {

                                                               InternalUnsafeMethods.GetImageGenericTrigger__Args _args = new InternalUnsafeMethods.GetImageGenericTrigger__Args() {
                        slot = slot,
                        trigger = trigger,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageGenericTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetImageTrigger(int slot, bool state) {

                                                               InternalUnsafeMethods.SetImageTrigger__Args _args = new InternalUnsafeMethods.SetImageTrigger__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetImageTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool GetImageTrigger(int slot) {

                                          InternalUnsafeMethods.GetImageTrigger__Args _args = new InternalUnsafeMethods.GetImageTrigger__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetImageTrigger()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool HasImageState(int slot, string state) {

                                                               InternalUnsafeMethods.HasImageState__Args _args = new InternalUnsafeMethods.HasImageState__Args() {
                        slot = slot,
                        state = state,
                     };
                     bool _engineResult = InternalUnsafeMethods.HasImageState()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetImageState(int slot) {

                                          InternalUnsafeMethods.GetImageState__Args _args = new InternalUnsafeMethods.GetImageState__Args() {
                        slot = slot,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetImageState()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public int GetImageSkinTag(int slot) {

                                          InternalUnsafeMethods.GetImageSkinTag__Args _args = new InternalUnsafeMethods.GetImageSkinTag__Args() {
                        slot = slot,
                     };
                     int _engineResult = InternalUnsafeMethods.GetImageSkinTag()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetMountSlot(ShapeBaseImageData image) {

                                          InternalUnsafeMethods.GetMountSlot__Args _args = new InternalUnsafeMethods.GetMountSlot__Args() {
                        image = image.ObjectPtr,
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountSlot()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsImageMounted(ShapeBaseImageData image) {

                                          InternalUnsafeMethods.IsImageMounted__Args _args = new InternalUnsafeMethods.IsImageMounted__Args() {
                        image = image.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsImageMounted()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsImageFiring(int slot) {

                                          InternalUnsafeMethods.IsImageFiring__Args _args = new InternalUnsafeMethods.IsImageFiring__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsImageFiring()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetPendingImage(int slot) {

                                          InternalUnsafeMethods.GetPendingImage__Args _args = new InternalUnsafeMethods.GetPendingImage__Args() {
                        slot = slot,
                     };
                     int _engineResult = InternalUnsafeMethods.GetPendingImage()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetMountedImage(int slot) {

                                          InternalUnsafeMethods.GetMountedImage__Args _args = new InternalUnsafeMethods.GetMountedImage__Args() {
                        slot = slot,
                     };
                     int _engineResult = InternalUnsafeMethods.GetMountedImage()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool UnmountImage(int slot) {

                                          InternalUnsafeMethods.UnmountImage__Args _args = new InternalUnsafeMethods.UnmountImage__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.UnmountImage()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool MountImage(ShapeBaseImageData image, int slot, bool loaded = true, string skinTag = "") {

                                                                                                         InternalUnsafeMethods.MountImage__Args _args = new InternalUnsafeMethods.MountImage__Args() {
                        image = image.ObjectPtr,
                        slot = slot,
                        loaded = loaded,
                        skinTag = skinTag,
                     };
                     bool _engineResult = InternalUnsafeMethods.MountImage()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool PauseThread(int slot) {

                                          InternalUnsafeMethods.PauseThread__Args _args = new InternalUnsafeMethods.PauseThread__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.PauseThread()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool DestroyThread(int slot) {

                                          InternalUnsafeMethods.DestroyThread__Args _args = new InternalUnsafeMethods.DestroyThread__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.DestroyThread()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool StopThread(int slot) {

                                          InternalUnsafeMethods.StopThread__Args _args = new InternalUnsafeMethods.StopThread__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.StopThread()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetThreadPosition(int slot, float pos) {

                                                               InternalUnsafeMethods.SetThreadPosition__Args _args = new InternalUnsafeMethods.SetThreadPosition__Args() {
                        slot = slot,
                        pos = pos,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetThreadPosition()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetThreadTimeScale(int slot, float scale) {

                                                               InternalUnsafeMethods.SetThreadTimeScale__Args _args = new InternalUnsafeMethods.SetThreadTimeScale__Args() {
                        slot = slot,
                        scale = scale,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetThreadTimeScale()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetThreadDir(int slot, bool fwd) {

                                                               InternalUnsafeMethods.SetThreadDir__Args _args = new InternalUnsafeMethods.SetThreadDir__Args() {
                        slot = slot,
                        fwd = fwd,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetThreadDir()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool PlayThread(int slot, string name = "") {

                                                               InternalUnsafeMethods.PlayThread__Args _args = new InternalUnsafeMethods.PlayThread__Args() {
                        slot = slot,
                        name = name,
                     };
                     bool _engineResult = InternalUnsafeMethods.PlayThread()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool StopAudio(int slot) {

                                          InternalUnsafeMethods.StopAudio__Args _args = new InternalUnsafeMethods.StopAudio__Args() {
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.StopAudio()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool PlayAudio(int slot, SFXTrack track) {

                                                               InternalUnsafeMethods.PlayAudio__Args _args = new InternalUnsafeMethods.PlayAudio__Args() {
                        slot = slot,
                        track = track.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.PlayAudio()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsHidden() {

                     InternalUnsafeMethods.IsHidden__Args _args = new InternalUnsafeMethods.IsHidden__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsHidden()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetHidden(bool show) {

                                          InternalUnsafeMethods.SetHidden__Args _args = new InternalUnsafeMethods.SetHidden__Args() {
                        show = show,
                     };
                     InternalUnsafeMethods.SetHidden()(ObjectPtr, _args);

                  }



                  public float ValidateCameraFov(float fov) {

                                          InternalUnsafeMethods.ValidateCameraFov__Args _args = new InternalUnsafeMethods.ValidateCameraFov__Args() {
                        fov = fov,
                     };
                     float _engineResult = InternalUnsafeMethods.ValidateCameraFov()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string Skin {
            get => GenericMarshal.StringTo<string>(GetFieldValue("skin"));
            set => SetFieldValue("skin", GenericMarshal.ToString(value));
        }


        public bool IsAIControlled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isAIControlled"));
            set => SetFieldValue("isAIControlled", GenericMarshal.ToString(value));
        }


    }
}
