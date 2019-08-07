using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim.Net {

    public unsafe class GameConnection : NetConnection {



        public GameConnection(bool pRegister = false)
            : base(pRegister) {
        }

        public GameConnection(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GameConnection(string pName)
            : this(pName, false) {
        }

        public GameConnection(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GameConnection(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GameConnection(SimObject pObj)
            : base(pObj) {
        }

        public GameConnection(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct LoadDatablockCache_Continue__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _LoadDatablockCache_Continue(IntPtr _this);
                internal delegate bool _LoadDatablockCache_Continue(IntPtr _this, LoadDatablockCache_Continue__Args args);
                private static _LoadDatablockCache_Continue _LoadDatablockCache_ContinueFunc;
                internal static _LoadDatablockCache_Continue LoadDatablockCache_Continue() {
                    if (_LoadDatablockCache_ContinueFunc == null) {
                        _LoadDatablockCache_ContinueFunc =
                            (_LoadDatablockCache_Continue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_loadDatablockCache_Continue"), typeof(_LoadDatablockCache_Continue));
                    }

                    return _LoadDatablockCache_ContinueFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct LoadDatablockCache_Begin__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _LoadDatablockCache_Begin(IntPtr _this);
                internal delegate bool _LoadDatablockCache_Begin(IntPtr _this, LoadDatablockCache_Begin__Args args);
                private static _LoadDatablockCache_Begin _LoadDatablockCache_BeginFunc;
                internal static _LoadDatablockCache_Begin LoadDatablockCache_Begin() {
                    if (_LoadDatablockCache_BeginFunc == null) {
                        _LoadDatablockCache_BeginFunc =
                            (_LoadDatablockCache_Begin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_loadDatablockCache_Begin"), typeof(_LoadDatablockCache_Begin));
                    }

                    return _LoadDatablockCache_BeginFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct LoadDatablockCache__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _LoadDatablockCache(IntPtr _this);
                internal delegate void _LoadDatablockCache(IntPtr _this, LoadDatablockCache__Args args);
                private static _LoadDatablockCache _LoadDatablockCacheFunc;
                internal static _LoadDatablockCache LoadDatablockCache() {
                    if (_LoadDatablockCacheFunc == null) {
                        _LoadDatablockCacheFunc =
                            (_LoadDatablockCache)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_loadDatablockCache"), typeof(_LoadDatablockCache));
                    }

                    return _LoadDatablockCacheFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SaveDatablockCache__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SaveDatablockCache(IntPtr _this);
                internal delegate void _SaveDatablockCache(IntPtr _this, SaveDatablockCache__Args args);
                private static _SaveDatablockCache _SaveDatablockCacheFunc;
                internal static _SaveDatablockCache SaveDatablockCache() {
                    if (_SaveDatablockCacheFunc == null) {
                        _SaveDatablockCacheFunc =
                            (_SaveDatablockCache)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_saveDatablockCache"), typeof(_SaveDatablockCache));
                    }

                    return _SaveDatablockCacheFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSelectedObjFromPreSelected__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetSelectedObjFromPreSelected(IntPtr _this);
                internal delegate void _SetSelectedObjFromPreSelected(IntPtr _this, SetSelectedObjFromPreSelected__Args args);
                private static _SetSelectedObjFromPreSelected _SetSelectedObjFromPreSelectedFunc;
                internal static _SetSelectedObjFromPreSelected SetSelectedObjFromPreSelected() {
                    if (_SetSelectedObjFromPreSelectedFunc == null) {
                        _SetSelectedObjFromPreSelectedFunc =
                            (_SetSelectedObjFromPreSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setSelectedObjFromPreSelected"), typeof(_SetSelectedObjFromPreSelected));
                    }

                    return _SetSelectedObjFromPreSelectedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearPreSelectedObj__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearPreSelectedObj(IntPtr _this);
                internal delegate void _ClearPreSelectedObj(IntPtr _this, ClearPreSelectedObj__Args args);
                private static _ClearPreSelectedObj _ClearPreSelectedObjFunc;
                internal static _ClearPreSelectedObj ClearPreSelectedObj() {
                    if (_ClearPreSelectedObjFunc == null) {
                        _ClearPreSelectedObjFunc =
                            (_ClearPreSelectedObj)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_clearPreSelectedObj"), typeof(_ClearPreSelectedObj));
                    }

                    return _ClearPreSelectedObjFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPreSelectedObjFromRollover__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetPreSelectedObjFromRollover(IntPtr _this);
                internal delegate void _SetPreSelectedObjFromRollover(IntPtr _this, SetPreSelectedObjFromRollover__Args args);
                private static _SetPreSelectedObjFromRollover _SetPreSelectedObjFromRolloverFunc;
                internal static _SetPreSelectedObjFromRollover SetPreSelectedObjFromRollover() {
                    if (_SetPreSelectedObjFromRolloverFunc == null) {
                        _SetPreSelectedObjFromRolloverFunc =
                            (_SetPreSelectedObjFromRollover)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setPreSelectedObjFromRollover"), typeof(_SetPreSelectedObjFromRollover));
                    }

                    return _SetPreSelectedObjFromRolloverFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearSelectedObj__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool propagate_to_client;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearSelectedObj(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool propagate_to_client);
                internal delegate void _ClearSelectedObj(IntPtr _this, ClearSelectedObj__Args args);
                private static _ClearSelectedObj _ClearSelectedObjFunc;
                internal static _ClearSelectedObj ClearSelectedObj() {
                    if (_ClearSelectedObjFunc == null) {
                        _ClearSelectedObjFunc =
                            (_ClearSelectedObj)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_clearSelectedObj"), typeof(_ClearSelectedObj));
                    }

                    return _ClearSelectedObjFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedObj__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetSelectedObj(IntPtr _this);
                internal delegate IntPtr _GetSelectedObj(IntPtr _this, GetSelectedObj__Args args);
                private static _GetSelectedObj _GetSelectedObjFunc;
                internal static _GetSelectedObj GetSelectedObj() {
                    if (_GetSelectedObjFunc == null) {
                        _GetSelectedObjFunc =
                            (_GetSelectedObj)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getSelectedObj"), typeof(_GetSelectedObj));
                    }

                    return _GetSelectedObjFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSelectedObj__Args
                {

				   internal IntPtr obj;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool propagate_to_client;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetSelectedObj(IntPtr _this, IntPtr obj, [MarshalAs(UnmanagedType.I1)]bool propagate_to_client);
                internal delegate bool _SetSelectedObj(IntPtr _this, SetSelectedObj__Args args);
                private static _SetSelectedObj _SetSelectedObjFunc;
                internal static _SetSelectedObj SetSelectedObj() {
                    if (_SetSelectedObjFunc == null) {
                        _SetSelectedObjFunc =
                            (_SetSelectedObj)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setSelectedObj"), typeof(_SetSelectedObj));
                    }

                    return _SetSelectedObjFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetVisibleGhostDistance__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetVisibleGhostDistance(IntPtr _this);
                internal delegate float _GetVisibleGhostDistance(IntPtr _this, GetVisibleGhostDistance__Args args);
                private static _GetVisibleGhostDistance _GetVisibleGhostDistanceFunc;
                internal static _GetVisibleGhostDistance GetVisibleGhostDistance() {
                    if (_GetVisibleGhostDistanceFunc == null) {
                        _GetVisibleGhostDistanceFunc =
                            (_GetVisibleGhostDistance)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getVisibleGhostDistance"), typeof(_GetVisibleGhostDistance));
                    }

                    return _GetVisibleGhostDistanceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetVisibleGhostDistance__Args
                {

				   internal float dist;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetVisibleGhostDistance(IntPtr _this, float dist);
                internal delegate void _SetVisibleGhostDistance(IntPtr _this, SetVisibleGhostDistance__Args args);
                private static _SetVisibleGhostDistance _SetVisibleGhostDistanceFunc;
                internal static _SetVisibleGhostDistance SetVisibleGhostDistance() {
                    if (_SetVisibleGhostDistanceFunc == null) {
                        _SetVisibleGhostDistanceFunc =
                            (_SetVisibleGhostDistance)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setVisibleGhostDistance"), typeof(_SetVisibleGhostDistance));
                    }

                    return _SetVisibleGhostDistanceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControlSchemeAbsoluteRotation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetControlSchemeAbsoluteRotation(IntPtr _this);
                internal delegate bool _GetControlSchemeAbsoluteRotation(IntPtr _this, GetControlSchemeAbsoluteRotation__Args args);
                private static _GetControlSchemeAbsoluteRotation _GetControlSchemeAbsoluteRotationFunc;
                internal static _GetControlSchemeAbsoluteRotation GetControlSchemeAbsoluteRotation() {
                    if (_GetControlSchemeAbsoluteRotationFunc == null) {
                        _GetControlSchemeAbsoluteRotationFunc =
                            (_GetControlSchemeAbsoluteRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getControlSchemeAbsoluteRotation"), typeof(_GetControlSchemeAbsoluteRotation));
                    }

                    return _GetControlSchemeAbsoluteRotationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetControlSchemeParameters__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool absoluteRotation;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool addYawToAbsRot;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool addPitchToAbsRot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetControlSchemeParameters(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool absoluteRotation, [MarshalAs(UnmanagedType.I1)]bool addYawToAbsRot, [MarshalAs(UnmanagedType.I1)]bool addPitchToAbsRot);
                internal delegate void _SetControlSchemeParameters(IntPtr _this, SetControlSchemeParameters__Args args);
                private static _SetControlSchemeParameters _SetControlSchemeParametersFunc;
                internal static _SetControlSchemeParameters SetControlSchemeParameters() {
                    if (_SetControlSchemeParametersFunc == null) {
                        _SetControlSchemeParametersFunc =
                            (_SetControlSchemeParameters)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setControlSchemeParameters"), typeof(_SetControlSchemeParameters));
                    }

                    return _SetControlSchemeParametersFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFirstPerson__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool firstPerson;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetFirstPerson(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool firstPerson);
                internal delegate void _SetFirstPerson(IntPtr _this, SetFirstPerson__Args args);
                private static _SetFirstPerson _SetFirstPersonFunc;
                internal static _SetFirstPerson SetFirstPerson() {
                    if (_SetFirstPersonFunc == null) {
                        _SetFirstPersonFunc =
                            (_SetFirstPerson)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setFirstPerson"), typeof(_SetFirstPerson));
                    }

                    return _SetFirstPersonFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsFirstPerson__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsFirstPerson(IntPtr _this);
                internal delegate bool _IsFirstPerson(IntPtr _this, IsFirstPerson__Args args);
                private static _IsFirstPerson _IsFirstPersonFunc;
                internal static _IsFirstPerson IsFirstPerson() {
                    if (_IsFirstPersonFunc == null) {
                        _IsFirstPersonFunc =
                            (_IsFirstPerson)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_isFirstPerson"), typeof(_IsFirstPerson));
                    }

                    return _IsFirstPersonFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearCameraObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearCameraObject(IntPtr _this);
                internal delegate void _ClearCameraObject(IntPtr _this, ClearCameraObject__Args args);
                private static _ClearCameraObject _ClearCameraObjectFunc;
                internal static _ClearCameraObject ClearCameraObject() {
                    if (_ClearCameraObjectFunc == null) {
                        _ClearCameraObjectFunc =
                            (_ClearCameraObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_clearCameraObject"), typeof(_ClearCameraObject));
                    }

                    return _ClearCameraObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCameraObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetCameraObject(IntPtr _this);
                internal delegate IntPtr _GetCameraObject(IntPtr _this, GetCameraObject__Args args);
                private static _GetCameraObject _GetCameraObjectFunc;
                internal static _GetCameraObject GetCameraObject() {
                    if (_GetCameraObjectFunc == null) {
                        _GetCameraObjectFunc =
                            (_GetCameraObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getCameraObject"), typeof(_GetCameraObject));
                    }

                    return _GetCameraObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCameraObject__Args
                {

				   internal IntPtr camera;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetCameraObject(IntPtr _this, IntPtr camera);
                internal delegate bool _SetCameraObject(IntPtr _this, SetCameraObject__Args args);
                private static _SetCameraObject _SetCameraObjectFunc;
                internal static _SetCameraObject SetCameraObject() {
                    if (_SetCameraObjectFunc == null) {
                        _SetCameraObjectFunc =
                            (_SetCameraObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setCameraObject"), typeof(_SetCameraObject));
                    }

                    return _SetCameraObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetServerConnection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetServerConnection();
                internal delegate int _GetServerConnection(GetServerConnection__Args args);
                private static _GetServerConnection _GetServerConnectionFunc;
                internal static _GetServerConnection GetServerConnection() {
                    if (_GetServerConnectionFunc == null) {
                        _GetServerConnectionFunc =
                            (_GetServerConnection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getServerConnection"), typeof(_GetServerConnection));
                    }

                    return _GetServerConnectionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ListClassIDs__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ListClassIDs(IntPtr _this);
                internal delegate void _ListClassIDs(IntPtr _this, ListClassIDs__Args args);
                private static _ListClassIDs _ListClassIDsFunc;
                internal static _ListClassIDs ListClassIDs() {
                    if (_ListClassIDsFunc == null) {
                        _ListClassIDsFunc =
                            (_ListClassIDs)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_listClassIDs"), typeof(_ListClassIDs));
                    }

                    return _ListClassIDsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsDemoRecording__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsDemoRecording(IntPtr _this);
                internal delegate bool _IsDemoRecording(IntPtr _this, IsDemoRecording__Args args);
                private static _IsDemoRecording _IsDemoRecordingFunc;
                internal static _IsDemoRecording IsDemoRecording() {
                    if (_IsDemoRecordingFunc == null) {
                        _IsDemoRecordingFunc =
                            (_IsDemoRecording)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_isDemoRecording"), typeof(_IsDemoRecording));
                    }

                    return _IsDemoRecordingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsDemoPlaying__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsDemoPlaying(IntPtr _this);
                internal delegate bool _IsDemoPlaying(IntPtr _this, IsDemoPlaying__Args args);
                private static _IsDemoPlaying _IsDemoPlayingFunc;
                internal static _IsDemoPlaying IsDemoPlaying() {
                    if (_IsDemoPlayingFunc == null) {
                        _IsDemoPlayingFunc =
                            (_IsDemoPlaying)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_isDemoPlaying"), typeof(_IsDemoPlaying));
                    }

                    return _IsDemoPlayingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PlayDemo__Args
                {

				   internal string demoFileName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _PlayDemo(IntPtr _this, string demoFileName);
                internal delegate bool _PlayDemo(IntPtr _this, PlayDemo__Args args);
                private static _PlayDemo _PlayDemoFunc;
                internal static _PlayDemo PlayDemo() {
                    if (_PlayDemoFunc == null) {
                        _PlayDemoFunc =
                            (_PlayDemo)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_playDemo"), typeof(_PlayDemo));
                    }

                    return _PlayDemoFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StopRecording__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _StopRecording(IntPtr _this);
                internal delegate void _StopRecording(IntPtr _this, StopRecording__Args args);
                private static _StopRecording _StopRecordingFunc;
                internal static _StopRecording StopRecording() {
                    if (_StopRecordingFunc == null) {
                        _StopRecordingFunc =
                            (_StopRecording)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_stopRecording"), typeof(_StopRecording));
                    }

                    return _StopRecordingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StartRecording__Args
                {

				   internal string fileName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _StartRecording(IntPtr _this, string fileName);
                internal delegate void _StartRecording(IntPtr _this, StartRecording__Args args);
                private static _StartRecording _StartRecordingFunc;
                internal static _StartRecording StartRecording() {
                    if (_StartRecordingFunc == null) {
                        _StartRecordingFunc =
                            (_StartRecording)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_startRecording"), typeof(_StartRecording));
                    }

                    return _StartRecordingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Delete__Args
                {

				   internal string reason;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Delete(IntPtr _this, string reason);
                internal delegate void _Delete(IntPtr _this, Delete__Args args);
                private static _Delete _DeleteFunc;
                internal static _Delete Delete() {
                    if (_DeleteFunc == null) {
                        _DeleteFunc =
                            (_Delete)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_delete"), typeof(_Delete));
                    }

                    return _DeleteFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMissionCRC__Args
                {

				   internal int CRC;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetMissionCRC(IntPtr _this, int CRC);
                internal delegate void _SetMissionCRC(IntPtr _this, SetMissionCRC__Args args);
                private static _SetMissionCRC _SetMissionCRCFunc;
                internal static _SetMissionCRC SetMissionCRC() {
                    if (_SetMissionCRCFunc == null) {
                        _SetMissionCRCFunc =
                            (_SetMissionCRC)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setMissionCRC"), typeof(_SetMissionCRC));
                    }

                    return _SetMissionCRCFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetBlackOut__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool doFade;

				   internal int timeMS;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetBlackOut(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool doFade, int timeMS);
                internal delegate void _SetBlackOut(IntPtr _this, SetBlackOut__Args args);
                private static _SetBlackOut _SetBlackOutFunc;
                internal static _SetBlackOut SetBlackOut() {
                    if (_SetBlackOutFunc == null) {
                        _SetBlackOutFunc =
                            (_SetBlackOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setBlackOut"), typeof(_SetBlackOut));
                    }

                    return _SetBlackOutFunc;
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
                                    "fnGameConnection_getWhiteOut"), typeof(_GetWhiteOut));
                    }

                    return _GetWhiteOutFunc;
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
                                    "fnGameConnection_getDamageFlash"), typeof(_GetDamageFlash));
                    }

                    return _GetDamageFlashFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControlCameraFov__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetControlCameraFov(IntPtr _this);
                internal delegate float _GetControlCameraFov(IntPtr _this, GetControlCameraFov__Args args);
                private static _GetControlCameraFov _GetControlCameraFovFunc;
                internal static _GetControlCameraFov GetControlCameraFov() {
                    if (_GetControlCameraFovFunc == null) {
                        _GetControlCameraFovFunc =
                            (_GetControlCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getControlCameraFov"), typeof(_GetControlCameraFov));
                    }

                    return _GetControlCameraFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetControlCameraFov__Args
                {

				   internal float newFOV;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetControlCameraFov(IntPtr _this, float newFOV);
                internal delegate void _SetControlCameraFov(IntPtr _this, SetControlCameraFov__Args args);
                private static _SetControlCameraFov _SetControlCameraFovFunc;
                internal static _SetControlCameraFov SetControlCameraFov() {
                    if (_SetControlCameraFovFunc == null) {
                        _SetControlCameraFovFunc =
                            (_SetControlCameraFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setControlCameraFov"), typeof(_SetControlCameraFov));
                    }

                    return _SetControlCameraFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControlCameraDefaultFov__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetControlCameraDefaultFov(IntPtr _this);
                internal delegate float _GetControlCameraDefaultFov(IntPtr _this, GetControlCameraDefaultFov__Args args);
                private static _GetControlCameraDefaultFov _GetControlCameraDefaultFovFunc;
                internal static _GetControlCameraDefaultFov GetControlCameraDefaultFov() {
                    if (_GetControlCameraDefaultFovFunc == null) {
                        _GetControlCameraDefaultFovFunc =
                            (_GetControlCameraDefaultFov)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getControlCameraDefaultFov"), typeof(_GetControlCameraDefaultFov));
                    }

                    return _GetControlCameraDefaultFovFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ChaseCam__Args
                {

				   internal int size;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ChaseCam(IntPtr _this, int size);
                internal delegate bool _ChaseCam(IntPtr _this, ChaseCam__Args args);
                private static _ChaseCam _ChaseCamFunc;
                internal static _ChaseCam ChaseCam() {
                    if (_ChaseCamFunc == null) {
                        _ChaseCamFunc =
                            (_ChaseCam)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_chaseCam"), typeof(_ChaseCam));
                    }

                    return _ChaseCamFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Play3D__Args
                {

				   internal IntPtr profile;

				   internal IntPtr location;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Play3D(IntPtr _this, IntPtr profile, IntPtr location);
                internal delegate bool _Play3D(IntPtr _this, Play3D__Args args);
                private static _Play3D _Play3DFunc;
                internal static _Play3D Play3D() {
                    if (_Play3DFunc == null) {
                        _Play3DFunc =
                            (_Play3D)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_play3D"), typeof(_Play3D));
                    }

                    return _Play3DFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Play2D__Args
                {

				   internal IntPtr profile;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Play2D(IntPtr _this, IntPtr profile);
                internal delegate bool _Play2D(IntPtr _this, Play2D__Args args);
                private static _Play2D _Play2DFunc;
                internal static _Play2D Play2D() {
                    if (_Play2DFunc == null) {
                        _Play2DFunc =
                            (_Play2D)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_play2D"), typeof(_Play2D));
                    }

                    return _Play2DFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsControlObjectRotDampedCamera__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsControlObjectRotDampedCamera(IntPtr _this);
                internal delegate bool _IsControlObjectRotDampedCamera(IntPtr _this, IsControlObjectRotDampedCamera__Args args);
                private static _IsControlObjectRotDampedCamera _IsControlObjectRotDampedCameraFunc;
                internal static _IsControlObjectRotDampedCamera IsControlObjectRotDampedCamera() {
                    if (_IsControlObjectRotDampedCameraFunc == null) {
                        _IsControlObjectRotDampedCameraFunc =
                            (_IsControlObjectRotDampedCamera)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_isControlObjectRotDampedCamera"), typeof(_IsControlObjectRotDampedCamera));
                    }

                    return _IsControlObjectRotDampedCameraFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsAIControlled__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsAIControlled(IntPtr _this);
                internal delegate bool _IsAIControlled(IntPtr _this, IsAIControlled__Args args);
                private static _IsAIControlled _IsAIControlledFunc;
                internal static _IsAIControlled IsAIControlled() {
                    if (_IsAIControlledFunc == null) {
                        _IsAIControlledFunc =
                            (_IsAIControlled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_isAIControlled"), typeof(_IsAIControlled));
                    }

                    return _IsAIControlledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetControlObject__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetControlObject(IntPtr _this);
                internal delegate IntPtr _GetControlObject(IntPtr _this, GetControlObject__Args args);
                private static _GetControlObject _GetControlObjectFunc;
                internal static _GetControlObject GetControlObject() {
                    if (_GetControlObjectFunc == null) {
                        _GetControlObjectFunc =
                            (_GetControlObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_getControlObject"), typeof(_GetControlObject));
                    }

                    return _GetControlObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearDisplayDevice__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ClearDisplayDevice(IntPtr _this);
                internal delegate void _ClearDisplayDevice(IntPtr _this, ClearDisplayDevice__Args args);
                private static _ClearDisplayDevice _ClearDisplayDeviceFunc;
                internal static _ClearDisplayDevice ClearDisplayDevice() {
                    if (_ClearDisplayDeviceFunc == null) {
                        _ClearDisplayDeviceFunc =
                            (_ClearDisplayDevice)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_clearDisplayDevice"), typeof(_ClearDisplayDevice));
                    }

                    return _ClearDisplayDeviceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetControlObject__Args
                {

				   internal IntPtr ctrlObj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetControlObject(IntPtr _this, IntPtr ctrlObj);
                internal delegate bool _SetControlObject(IntPtr _this, SetControlObject__Args args);
                private static _SetControlObject _SetControlObjectFunc;
                internal static _SetControlObject SetControlObject() {
                    if (_SetControlObjectFunc == null) {
                        _SetControlObjectFunc =
                            (_SetControlObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setControlObject"), typeof(_SetControlObject));
                    }

                    return _SetControlObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ResetGhosting__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ResetGhosting(IntPtr _this);
                internal delegate void _ResetGhosting(IntPtr _this, ResetGhosting__Args args);
                private static _ResetGhosting _ResetGhostingFunc;
                internal static _ResetGhosting ResetGhosting() {
                    if (_ResetGhostingFunc == null) {
                        _ResetGhostingFunc =
                            (_ResetGhosting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_resetGhosting"), typeof(_ResetGhosting));
                    }

                    return _ResetGhostingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ActivateGhosting__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ActivateGhosting(IntPtr _this);
                internal delegate void _ActivateGhosting(IntPtr _this, ActivateGhosting__Args args);
                private static _ActivateGhosting _ActivateGhostingFunc;
                internal static _ActivateGhosting ActivateGhosting() {
                    if (_ActivateGhostingFunc == null) {
                        _ActivateGhostingFunc =
                            (_ActivateGhosting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_activateGhosting"), typeof(_ActivateGhosting));
                    }

                    return _ActivateGhostingFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct TransmitDataBlocks__Args
                {

				   internal int sequence;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _TransmitDataBlocks(IntPtr _this, int sequence);
                internal delegate void _TransmitDataBlocks(IntPtr _this, TransmitDataBlocks__Args args);
                private static _TransmitDataBlocks _TransmitDataBlocksFunc;
                internal static _TransmitDataBlocks TransmitDataBlocks() {
                    if (_TransmitDataBlocksFunc == null) {
                        _TransmitDataBlocksFunc =
                            (_TransmitDataBlocks)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_transmitDataBlocks"), typeof(_TransmitDataBlocks));
                    }

                    return _TransmitDataBlocksFunc;
                }


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _SetConnectArgs(IntPtr _this, ref StringVector.InternalStruct args);
                private static _SetConnectArgs _SetConnectArgsFunc;
                internal static _SetConnectArgs SetConnectArgs() {
                    if (_SetConnectArgsFunc == null) {
                        _SetConnectArgsFunc =
                            (_SetConnectArgs)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setConnectArgs"), typeof(_SetConnectArgs));
                    }

                    return _SetConnectArgsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetJoinPassword__Args
                {

				   internal string password;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetJoinPassword(IntPtr _this, string password);
                internal delegate void _SetJoinPassword(IntPtr _this, SetJoinPassword__Args args);
                private static _SetJoinPassword _SetJoinPasswordFunc;
                internal static _SetJoinPassword SetJoinPassword() {
                    if (_SetJoinPasswordFunc == null) {
                        _SetJoinPasswordFunc =
                            (_SetJoinPassword)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGameConnection_setJoinPassword"), typeof(_SetJoinPassword));
                    }

                    return _SetJoinPasswordFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnFlash__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnFlash(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _OnFlash(IntPtr _this, OnFlash__Args args);
                private static _OnFlash _OnFlashFunc;
                internal static _OnFlash OnFlash() {
                    if (_OnFlashFunc == null) {
                        _OnFlashFunc =
                            (_OnFlash)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onFlash"), typeof(_OnFlash));
                    }

                    return _OnFlashFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDataBlocksDone__Args
                {

				   internal uint sequence;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDataBlocksDone(IntPtr _this, uint sequence);
                internal delegate void _OnDataBlocksDone(IntPtr _this, OnDataBlocksDone__Args args);
                private static _OnDataBlocksDone _OnDataBlocksDoneFunc;
                internal static _OnDataBlocksDone OnDataBlocksDone() {
                    if (_OnDataBlocksDoneFunc == null) {
                        _OnDataBlocksDoneFunc =
                            (_OnDataBlocksDone)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onDataBlocksDone"), typeof(_OnDataBlocksDone));
                    }

                    return _OnDataBlocksDoneFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLagIcon__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetLagIcon(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _SetLagIcon(IntPtr _this, SetLagIcon__Args args);
                private static _SetLagIcon _SetLagIconFunc;
                internal static _SetLagIcon SetLagIcon() {
                    if (_SetLagIconFunc == null) {
                        _SetLagIconFunc =
                            (_SetLagIcon)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_setLagIcon"), typeof(_SetLagIcon));
                    }

                    return _SetLagIconFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnControlObjectChange__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnControlObjectChange(IntPtr _this);
                internal delegate void _OnControlObjectChange(IntPtr _this, OnControlObjectChange__Args args);
                private static _OnControlObjectChange _OnControlObjectChangeFunc;
                internal static _OnControlObjectChange OnControlObjectChange() {
                    if (_OnControlObjectChangeFunc == null) {
                        _OnControlObjectChangeFunc =
                            (_OnControlObjectChange)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onControlObjectChange"), typeof(_OnControlObjectChange));
                    }

                    return _OnControlObjectChangeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct InitialControlSet__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _InitialControlSet(IntPtr _this);
                internal delegate void _InitialControlSet(IntPtr _this, InitialControlSet__Args args);
                private static _InitialControlSet _InitialControlSetFunc;
                internal static _InitialControlSet InitialControlSet() {
                    if (_InitialControlSetFunc == null) {
                        _InitialControlSetFunc =
                            (_InitialControlSet)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_initialControlSet"), typeof(_InitialControlSet));
                    }

                    return _InitialControlSetFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDrop__Args
                {

				   internal string disconnectReason;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDrop(IntPtr _this, string disconnectReason);
                internal delegate void _OnDrop(IntPtr _this, OnDrop__Args args);
                private static _OnDrop _OnDropFunc;
                internal static _OnDrop OnDrop() {
                    if (_OnDropFunc == null) {
                        _OnDropFunc =
                            (_OnDrop)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onDrop"), typeof(_OnDrop));
                    }

                    return _OnDropFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectionError__Args
                {

				   internal string errorString;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectionError(IntPtr _this, string errorString);
                internal delegate void _OnConnectionError(IntPtr _this, OnConnectionError__Args args);
                private static _OnConnectionError _OnConnectionErrorFunc;
                internal static _OnConnectionError OnConnectionError() {
                    if (_OnConnectionErrorFunc == null) {
                        _OnConnectionErrorFunc =
                            (_OnConnectionError)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectionError"), typeof(_OnConnectionError));
                    }

                    return _OnConnectionErrorFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectRequestRejected__Args
                {

				   internal string reason;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectRequestRejected(IntPtr _this, string reason);
                internal delegate void _OnConnectRequestRejected(IntPtr _this, OnConnectRequestRejected__Args args);
                private static _OnConnectRequestRejected _OnConnectRequestRejectedFunc;
                internal static _OnConnectRequestRejected OnConnectRequestRejected() {
                    if (_OnConnectRequestRejectedFunc == null) {
                        _OnConnectRequestRejectedFunc =
                            (_OnConnectRequestRejected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectRequestRejected"), typeof(_OnConnectRequestRejected));
                    }

                    return _OnConnectRequestRejectedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectionDropped__Args
                {

				   internal string reason;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectionDropped(IntPtr _this, string reason);
                internal delegate void _OnConnectionDropped(IntPtr _this, OnConnectionDropped__Args args);
                private static _OnConnectionDropped _OnConnectionDroppedFunc;
                internal static _OnConnectionDropped OnConnectionDropped() {
                    if (_OnConnectionDroppedFunc == null) {
                        _OnConnectionDroppedFunc =
                            (_OnConnectionDropped)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectionDropped"), typeof(_OnConnectionDropped));
                    }

                    return _OnConnectionDroppedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectRequestTimedOut__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectRequestTimedOut(IntPtr _this);
                internal delegate void _OnConnectRequestTimedOut(IntPtr _this, OnConnectRequestTimedOut__Args args);
                private static _OnConnectRequestTimedOut _OnConnectRequestTimedOutFunc;
                internal static _OnConnectRequestTimedOut OnConnectRequestTimedOut() {
                    if (_OnConnectRequestTimedOutFunc == null) {
                        _OnConnectRequestTimedOutFunc =
                            (_OnConnectRequestTimedOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectRequestTimedOut"), typeof(_OnConnectRequestTimedOut));
                    }

                    return _OnConnectRequestTimedOutFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectionAccepted__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectionAccepted(IntPtr _this);
                internal delegate void _OnConnectionAccepted(IntPtr _this, OnConnectionAccepted__Args args);
                private static _OnConnectionAccepted _OnConnectionAcceptedFunc;
                internal static _OnConnectionAccepted OnConnectionAccepted() {
                    if (_OnConnectionAcceptedFunc == null) {
                        _OnConnectionAcceptedFunc =
                            (_OnConnectionAccepted)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectionAccepted"), typeof(_OnConnectionAccepted));
                    }

                    return _OnConnectionAcceptedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnConnectionTimedOut__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnConnectionTimedOut(IntPtr _this);
                internal delegate void _OnConnectionTimedOut(IntPtr _this, OnConnectionTimedOut__Args args);
                private static _OnConnectionTimedOut _OnConnectionTimedOutFunc;
                internal static _OnConnectionTimedOut OnConnectionTimedOut() {
                    if (_OnConnectionTimedOutFunc == null) {
                        _OnConnectionTimedOutFunc =
                            (_OnConnectionTimedOut)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGameConnection_onConnectionTimedOut"), typeof(_OnConnectionTimedOut));
                    }

                    return _OnConnectionTimedOutFunc;
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
                                    "fnGameConnection_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGameConnection_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool LoadDatablockCache_Continue() {

                     InternalUnsafeMethods.LoadDatablockCache_Continue__Args _args = new InternalUnsafeMethods.LoadDatablockCache_Continue__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.LoadDatablockCache_Continue()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool LoadDatablockCache_Begin() {

                     InternalUnsafeMethods.LoadDatablockCache_Begin__Args _args = new InternalUnsafeMethods.LoadDatablockCache_Begin__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.LoadDatablockCache_Begin()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void LoadDatablockCache() {

                     InternalUnsafeMethods.LoadDatablockCache__Args _args = new InternalUnsafeMethods.LoadDatablockCache__Args() {
                     };
                     InternalUnsafeMethods.LoadDatablockCache()(ObjectPtr, _args);

                  }



                  public void SaveDatablockCache() {

                     InternalUnsafeMethods.SaveDatablockCache__Args _args = new InternalUnsafeMethods.SaveDatablockCache__Args() {
                     };
                     InternalUnsafeMethods.SaveDatablockCache()(ObjectPtr, _args);

                  }



                  public void SetSelectedObjFromPreSelected() {

                     InternalUnsafeMethods.SetSelectedObjFromPreSelected__Args _args = new InternalUnsafeMethods.SetSelectedObjFromPreSelected__Args() {
                     };
                     InternalUnsafeMethods.SetSelectedObjFromPreSelected()(ObjectPtr, _args);

                  }



                  public void ClearPreSelectedObj() {

                     InternalUnsafeMethods.ClearPreSelectedObj__Args _args = new InternalUnsafeMethods.ClearPreSelectedObj__Args() {
                     };
                     InternalUnsafeMethods.ClearPreSelectedObj()(ObjectPtr, _args);

                  }



                  public void SetPreSelectedObjFromRollover() {

                     InternalUnsafeMethods.SetPreSelectedObjFromRollover__Args _args = new InternalUnsafeMethods.SetPreSelectedObjFromRollover__Args() {
                     };
                     InternalUnsafeMethods.SetPreSelectedObjFromRollover()(ObjectPtr, _args);

                  }



                  public void ClearSelectedObj(bool propagate_to_client = false) {

                                          InternalUnsafeMethods.ClearSelectedObj__Args _args = new InternalUnsafeMethods.ClearSelectedObj__Args() {
                        propagate_to_client = propagate_to_client,
                     };
                     InternalUnsafeMethods.ClearSelectedObj()(ObjectPtr, _args);

                  }



                  public SimObject GetSelectedObj() {

                     InternalUnsafeMethods.GetSelectedObj__Args _args = new InternalUnsafeMethods.GetSelectedObj__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSelectedObj()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public bool SetSelectedObj(SceneObject obj, bool propagate_to_client = false) {

                                                               InternalUnsafeMethods.SetSelectedObj__Args _args = new InternalUnsafeMethods.SetSelectedObj__Args() {
                        obj = obj.ObjectPtr,
                        propagate_to_client = propagate_to_client,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetSelectedObj()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetVisibleGhostDistance() {

                     InternalUnsafeMethods.GetVisibleGhostDistance__Args _args = new InternalUnsafeMethods.GetVisibleGhostDistance__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetVisibleGhostDistance()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetVisibleGhostDistance(float dist) {

                                          InternalUnsafeMethods.SetVisibleGhostDistance__Args _args = new InternalUnsafeMethods.SetVisibleGhostDistance__Args() {
                        dist = dist,
                     };
                     InternalUnsafeMethods.SetVisibleGhostDistance()(ObjectPtr, _args);

                  }



                  public bool GetControlSchemeAbsoluteRotation() {

                     InternalUnsafeMethods.GetControlSchemeAbsoluteRotation__Args _args = new InternalUnsafeMethods.GetControlSchemeAbsoluteRotation__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.GetControlSchemeAbsoluteRotation()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetControlSchemeParameters(bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot) {

                                                                                    InternalUnsafeMethods.SetControlSchemeParameters__Args _args = new InternalUnsafeMethods.SetControlSchemeParameters__Args() {
                        absoluteRotation = absoluteRotation,
                        addYawToAbsRot = addYawToAbsRot,
                        addPitchToAbsRot = addPitchToAbsRot,
                     };
                     InternalUnsafeMethods.SetControlSchemeParameters()(ObjectPtr, _args);

                  }



                  public void SetFirstPerson(bool firstPerson) {

                                          InternalUnsafeMethods.SetFirstPerson__Args _args = new InternalUnsafeMethods.SetFirstPerson__Args() {
                        firstPerson = firstPerson,
                     };
                     InternalUnsafeMethods.SetFirstPerson()(ObjectPtr, _args);

                  }



                  public bool IsFirstPerson() {

                     InternalUnsafeMethods.IsFirstPerson__Args _args = new InternalUnsafeMethods.IsFirstPerson__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsFirstPerson()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void ClearCameraObject() {

                     InternalUnsafeMethods.ClearCameraObject__Args _args = new InternalUnsafeMethods.ClearCameraObject__Args() {
                     };
                     InternalUnsafeMethods.ClearCameraObject()(ObjectPtr, _args);

                  }



                  public SimObject GetCameraObject() {

                     InternalUnsafeMethods.GetCameraObject__Args _args = new InternalUnsafeMethods.GetCameraObject__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetCameraObject()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public bool SetCameraObject(GameBase camera) {

                                          InternalUnsafeMethods.SetCameraObject__Args _args = new InternalUnsafeMethods.SetCameraObject__Args() {
                        camera = camera.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetCameraObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static int GetServerConnection() {
                     InternalUnsafeMethods.GetServerConnection__Args _args = new InternalUnsafeMethods.GetServerConnection__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetServerConnection()(_args);

                     return _engineResult;
                  }



                  public void ListClassIDs() {

                     InternalUnsafeMethods.ListClassIDs__Args _args = new InternalUnsafeMethods.ListClassIDs__Args() {
                     };
                     InternalUnsafeMethods.ListClassIDs()(ObjectPtr, _args);

                  }



                  public bool IsDemoRecording() {

                     InternalUnsafeMethods.IsDemoRecording__Args _args = new InternalUnsafeMethods.IsDemoRecording__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsDemoRecording()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsDemoPlaying() {

                     InternalUnsafeMethods.IsDemoPlaying__Args _args = new InternalUnsafeMethods.IsDemoPlaying__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsDemoPlaying()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool PlayDemo(string demoFileName) {

                                          InternalUnsafeMethods.PlayDemo__Args _args = new InternalUnsafeMethods.PlayDemo__Args() {
                        demoFileName = demoFileName,
                     };
                     bool _engineResult = InternalUnsafeMethods.PlayDemo()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void StopRecording() {

                     InternalUnsafeMethods.StopRecording__Args _args = new InternalUnsafeMethods.StopRecording__Args() {
                     };
                     InternalUnsafeMethods.StopRecording()(ObjectPtr, _args);

                  }



                  public void StartRecording(string fileName) {

                                          InternalUnsafeMethods.StartRecording__Args _args = new InternalUnsafeMethods.StartRecording__Args() {
                        fileName = fileName,
                     };
                     InternalUnsafeMethods.StartRecording()(ObjectPtr, _args);

                  }



                  public void Delete(string reason = "") {

                                          InternalUnsafeMethods.Delete__Args _args = new InternalUnsafeMethods.Delete__Args() {
                        reason = reason,
                     };
                     InternalUnsafeMethods.Delete()(ObjectPtr, _args);

                  }



                  public void SetMissionCRC(int CRC) {

                                          InternalUnsafeMethods.SetMissionCRC__Args _args = new InternalUnsafeMethods.SetMissionCRC__Args() {
                        CRC = CRC,
                     };
                     InternalUnsafeMethods.SetMissionCRC()(ObjectPtr, _args);

                  }



                  public void SetBlackOut(bool doFade, int timeMS) {

                                                               InternalUnsafeMethods.SetBlackOut__Args _args = new InternalUnsafeMethods.SetBlackOut__Args() {
                        doFade = doFade,
                        timeMS = timeMS,
                     };
                     InternalUnsafeMethods.SetBlackOut()(ObjectPtr, _args);

                  }



                  public float GetWhiteOut() {

                     InternalUnsafeMethods.GetWhiteOut__Args _args = new InternalUnsafeMethods.GetWhiteOut__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetWhiteOut()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetDamageFlash() {

                     InternalUnsafeMethods.GetDamageFlash__Args _args = new InternalUnsafeMethods.GetDamageFlash__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetDamageFlash()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public float GetControlCameraFov() {

                     InternalUnsafeMethods.GetControlCameraFov__Args _args = new InternalUnsafeMethods.GetControlCameraFov__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetControlCameraFov()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetControlCameraFov(float newFOV) {

                                          InternalUnsafeMethods.SetControlCameraFov__Args _args = new InternalUnsafeMethods.SetControlCameraFov__Args() {
                        newFOV = newFOV,
                     };
                     InternalUnsafeMethods.SetControlCameraFov()(ObjectPtr, _args);

                  }



                  public float GetControlCameraDefaultFov() {

                     InternalUnsafeMethods.GetControlCameraDefaultFov__Args _args = new InternalUnsafeMethods.GetControlCameraDefaultFov__Args() {
                     };
                     float _engineResult = InternalUnsafeMethods.GetControlCameraDefaultFov()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool ChaseCam(int size) {

                                          InternalUnsafeMethods.ChaseCam__Args _args = new InternalUnsafeMethods.ChaseCam__Args() {
                        size = size,
                     };
                     bool _engineResult = InternalUnsafeMethods.ChaseCam()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool Play3D(SFXProfile profile, TransformF location) {

                                          location.Alloc();                     InternalUnsafeMethods.Play3D__Args _args = new InternalUnsafeMethods.Play3D__Args() {
                        profile = profile.ObjectPtr,
                        location = location.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.Play3D()(ObjectPtr, _args);
                                                               location.Free();
                     return _engineResult;
                  }



                  public bool Play2D(SFXProfile profile) {

                                          InternalUnsafeMethods.Play2D__Args _args = new InternalUnsafeMethods.Play2D__Args() {
                        profile = profile.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.Play2D()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsControlObjectRotDampedCamera() {

                     InternalUnsafeMethods.IsControlObjectRotDampedCamera__Args _args = new InternalUnsafeMethods.IsControlObjectRotDampedCamera__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsControlObjectRotDampedCamera()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsAIControlled() {

                     InternalUnsafeMethods.IsAIControlled__Args _args = new InternalUnsafeMethods.IsAIControlled__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsAIControlled()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public GameBase GetControlObject() {

                     InternalUnsafeMethods.GetControlObject__Args _args = new InternalUnsafeMethods.GetControlObject__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetControlObject()(ObjectPtr, _args);

                     return new GameBase(_engineResult);
                  }



                  public void ClearDisplayDevice() {

                     InternalUnsafeMethods.ClearDisplayDevice__Args _args = new InternalUnsafeMethods.ClearDisplayDevice__Args() {
                     };
                     InternalUnsafeMethods.ClearDisplayDevice()(ObjectPtr, _args);

                  }



                  public bool SetControlObject(GameBase ctrlObj) {

                                          InternalUnsafeMethods.SetControlObject__Args _args = new InternalUnsafeMethods.SetControlObject__Args() {
                        ctrlObj = ctrlObj.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetControlObject()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void ResetGhosting() {

                     InternalUnsafeMethods.ResetGhosting__Args _args = new InternalUnsafeMethods.ResetGhosting__Args() {
                     };
                     InternalUnsafeMethods.ResetGhosting()(ObjectPtr, _args);

                  }



                  public void ActivateGhosting() {

                     InternalUnsafeMethods.ActivateGhosting__Args _args = new InternalUnsafeMethods.ActivateGhosting__Args() {
                     };
                     InternalUnsafeMethods.ActivateGhosting()(ObjectPtr, _args);

                  }



                  public void TransmitDataBlocks(int sequence) {

                                          InternalUnsafeMethods.TransmitDataBlocks__Args _args = new InternalUnsafeMethods.TransmitDataBlocks__Args() {
                        sequence = sequence,
                     };
                     InternalUnsafeMethods.TransmitDataBlocks()(ObjectPtr, _args);

                  }


								public void SetConnectArgs(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.SetConnectArgs()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}


                  public void SetJoinPassword(string password) {

                                          InternalUnsafeMethods.SetJoinPassword__Args _args = new InternalUnsafeMethods.SetJoinPassword__Args() {
                        password = password,
                     };
                     InternalUnsafeMethods.SetJoinPassword()(ObjectPtr, _args);

                  }



                  public void OnFlash(bool state) {

                                          InternalUnsafeMethods.OnFlash__Args _args = new InternalUnsafeMethods.OnFlash__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.OnFlash()(ObjectPtr, _args);

                  }



                  public void OnDataBlocksDone(uint sequence) {

                                          InternalUnsafeMethods.OnDataBlocksDone__Args _args = new InternalUnsafeMethods.OnDataBlocksDone__Args() {
                        sequence = sequence,
                     };
                     InternalUnsafeMethods.OnDataBlocksDone()(ObjectPtr, _args);

                  }



                  public void SetLagIcon(bool state) {

                                          InternalUnsafeMethods.SetLagIcon__Args _args = new InternalUnsafeMethods.SetLagIcon__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.SetLagIcon()(ObjectPtr, _args);

                  }



                  public void OnControlObjectChange() {

                     InternalUnsafeMethods.OnControlObjectChange__Args _args = new InternalUnsafeMethods.OnControlObjectChange__Args() {
                     };
                     InternalUnsafeMethods.OnControlObjectChange()(ObjectPtr, _args);

                  }



                  public void InitialControlSet() {

                     InternalUnsafeMethods.InitialControlSet__Args _args = new InternalUnsafeMethods.InitialControlSet__Args() {
                     };
                     InternalUnsafeMethods.InitialControlSet()(ObjectPtr, _args);

                  }



                  public void OnDrop(string disconnectReason) {

                                          InternalUnsafeMethods.OnDrop__Args _args = new InternalUnsafeMethods.OnDrop__Args() {
                        disconnectReason = disconnectReason,
                     };
                     InternalUnsafeMethods.OnDrop()(ObjectPtr, _args);

                  }



                  public void OnConnectionError(string errorString) {

                                          InternalUnsafeMethods.OnConnectionError__Args _args = new InternalUnsafeMethods.OnConnectionError__Args() {
                        errorString = errorString,
                     };
                     InternalUnsafeMethods.OnConnectionError()(ObjectPtr, _args);

                  }



                  public void OnConnectRequestRejected(string reason) {

                                          InternalUnsafeMethods.OnConnectRequestRejected__Args _args = new InternalUnsafeMethods.OnConnectRequestRejected__Args() {
                        reason = reason,
                     };
                     InternalUnsafeMethods.OnConnectRequestRejected()(ObjectPtr, _args);

                  }



                  public void OnConnectionDropped(string reason) {

                                          InternalUnsafeMethods.OnConnectionDropped__Args _args = new InternalUnsafeMethods.OnConnectionDropped__Args() {
                        reason = reason,
                     };
                     InternalUnsafeMethods.OnConnectionDropped()(ObjectPtr, _args);

                  }



                  public void OnConnectRequestTimedOut() {

                     InternalUnsafeMethods.OnConnectRequestTimedOut__Args _args = new InternalUnsafeMethods.OnConnectRequestTimedOut__Args() {
                     };
                     InternalUnsafeMethods.OnConnectRequestTimedOut()(ObjectPtr, _args);

                  }



                  public void OnConnectionAccepted() {

                     InternalUnsafeMethods.OnConnectionAccepted__Args _args = new InternalUnsafeMethods.OnConnectionAccepted__Args() {
                     };
                     InternalUnsafeMethods.OnConnectionAccepted()(ObjectPtr, _args);

                  }



                  public void OnConnectionTimedOut() {

                     InternalUnsafeMethods.OnConnectionTimedOut__Args _args = new InternalUnsafeMethods.OnConnectionTimedOut__Args() {
                     };
                     InternalUnsafeMethods.OnConnectionTimedOut()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
