using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Net;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Functions {

    public static unsafe class SDLInputManager {

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMappingForIndex__Args
            {
                internal int mappingIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMappingForIndex(GameControllerMappingForIndex__Args args);
            private static _GameControllerMappingForIndex _GameControllerMappingForIndexFunc;
            internal static _GameControllerMappingForIndex GameControllerMappingForIndex() {
                if (_GameControllerMappingForIndexFunc == null) {
                    _GameControllerMappingForIndexFunc =
                        (_GameControllerMappingForIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerMappingForIndex"), typeof(_GameControllerMappingForIndex));
                }
                
                return _GameControllerMappingForIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerNumMappings__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerNumMappings(GameControllerNumMappings__Args args);
            private static _GameControllerNumMappings _GameControllerNumMappingsFunc;
            internal static _GameControllerNumMappings GameControllerNumMappings() {
                if (_GameControllerNumMappingsFunc == null) {
                    _GameControllerNumMappingsFunc =
                        (_GameControllerNumMappings)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerNumMappings"), typeof(_GameControllerNumMappings));
                }
                
                return _GameControllerNumMappingsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerAddMappingsFromFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerAddMappingsFromFile(GameControllerAddMappingsFromFile__Args args);
            private static _GameControllerAddMappingsFromFile _GameControllerAddMappingsFromFileFunc;
            internal static _GameControllerAddMappingsFromFile GameControllerAddMappingsFromFile() {
                if (_GameControllerAddMappingsFromFileFunc == null) {
                    _GameControllerAddMappingsFromFileFunc =
                        (_GameControllerAddMappingsFromFile)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerAddMappingsFromFile"), typeof(_GameControllerAddMappingsFromFile));
                }
                
                return _GameControllerAddMappingsFromFileFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerAddMapping__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string mappingString;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerAddMapping(GameControllerAddMapping__Args args);
            private static _GameControllerAddMapping _GameControllerAddMappingFunc;
            internal static _GameControllerAddMapping GameControllerAddMapping() {
                if (_GameControllerAddMappingFunc == null) {
                    _GameControllerAddMappingFunc =
                        (_GameControllerAddMapping)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerAddMapping"), typeof(_GameControllerAddMapping));
                }
                
                return _GameControllerAddMappingFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMappingForGUID__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string guidStr;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMappingForGUID(GameControllerMappingForGUID__Args args);
            private static _GameControllerMappingForGUID _GameControllerMappingForGUIDFunc;
            internal static _GameControllerMappingForGUID GameControllerMappingForGUID() {
                if (_GameControllerMappingForGUIDFunc == null) {
                    _GameControllerMappingForGUIDFunc =
                        (_GameControllerMappingForGUID)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerMappingForGUID"), typeof(_GameControllerMappingForGUID));
                }
                
                return _GameControllerMappingForGUIDFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMapping__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMapping(GameControllerMapping__Args args);
            private static _GameControllerMapping _GameControllerMappingFunc;
            internal static _GameControllerMapping GameControllerMapping() {
                if (_GameControllerMappingFunc == null) {
                    _GameControllerMappingFunc =
                        (_GameControllerMapping)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GameControllerMapping"), typeof(_GameControllerMapping));
                }
                
                return _GameControllerMappingFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerGetButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerGetButtons(ControllerGetButtons__Args args);
            private static _ControllerGetButtons _ControllerGetButtonsFunc;
            internal static _ControllerGetButtons ControllerGetButtons() {
                if (_ControllerGetButtonsFunc == null) {
                    _ControllerGetButtonsFunc =
                        (_ControllerGetButtons)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_ControllerGetButtons"), typeof(_ControllerGetButtons));
                }
                
                return _ControllerGetButtonsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerGetAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerGetAxes(ControllerGetAxes__Args args);
            private static _ControllerGetAxes _ControllerGetAxesFunc;
            internal static _ControllerGetAxes ControllerGetAxes() {
                if (_ControllerGetAxesFunc == null) {
                    _ControllerGetAxesFunc =
                        (_ControllerGetAxes)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_ControllerGetAxes"), typeof(_ControllerGetAxes));
                }
                
                return _ControllerGetAxesFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetHats__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetHats(JoystickGetHats__Args args);
            private static _JoystickGetHats _JoystickGetHatsFunc;
            internal static _JoystickGetHats JoystickGetHats() {
                if (_JoystickGetHatsFunc == null) {
                    _JoystickGetHatsFunc =
                        (_JoystickGetHats)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickGetHats"), typeof(_JoystickGetHats));
                }
                
                return _JoystickGetHatsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetButtons(JoystickGetButtons__Args args);
            private static _JoystickGetButtons _JoystickGetButtonsFunc;
            internal static _JoystickGetButtons JoystickGetButtons() {
                if (_JoystickGetButtonsFunc == null) {
                    _JoystickGetButtonsFunc =
                        (_JoystickGetButtons)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickGetButtons"), typeof(_JoystickGetButtons));
                }
                
                return _JoystickGetButtonsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetAxes(JoystickGetAxes__Args args);
            private static _JoystickGetAxes _JoystickGetAxesFunc;
            internal static _JoystickGetAxes JoystickGetAxes() {
                if (_JoystickGetAxesFunc == null) {
                    _JoystickGetAxesFunc =
                        (_JoystickGetAxes)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickGetAxes"), typeof(_JoystickGetAxes));
                }
                
                return _JoystickGetAxesFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetSpecs__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetSpecs(JoystickGetSpecs__Args args);
            private static _JoystickGetSpecs _JoystickGetSpecsFunc;
            internal static _JoystickGetSpecs JoystickGetSpecs() {
                if (_JoystickGetSpecsFunc == null) {
                    _JoystickGetSpecsFunc =
                        (_JoystickGetSpecs)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickGetSpecs"), typeof(_JoystickGetSpecs));
                }
                
                return _JoystickGetSpecsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickPowerLevel__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickPowerLevel(JoystickPowerLevel__Args args);
            private static _JoystickPowerLevel _JoystickPowerLevelFunc;
            internal static _JoystickPowerLevel JoystickPowerLevel() {
                if (_JoystickPowerLevelFunc == null) {
                    _JoystickPowerLevelFunc =
                        (_JoystickPowerLevel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickPowerLevel"), typeof(_JoystickPowerLevel));
                }
                
                return _JoystickPowerLevelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickIsHaptic__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _JoystickIsHaptic(JoystickIsHaptic__Args args);
            private static _JoystickIsHaptic _JoystickIsHapticFunc;
            internal static _JoystickIsHaptic JoystickIsHaptic() {
                if (_JoystickIsHapticFunc == null) {
                    _JoystickIsHapticFunc =
                        (_JoystickIsHaptic)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickIsHaptic"), typeof(_JoystickIsHaptic));
                }
                
                return _JoystickIsHapticFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsGameController__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsGameController(IsGameController__Args args);
            private static _IsGameController _IsGameControllerFunc;
            internal static _IsGameController IsGameController() {
                if (_IsGameControllerFunc == null) {
                    _IsGameControllerFunc =
                        (_IsGameController)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_IsGameController"), typeof(_IsGameController));
                }
                
                return _IsGameControllerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumHats__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumHats(JoystickNumHats__Args args);
            private static _JoystickNumHats _JoystickNumHatsFunc;
            internal static _JoystickNumHats JoystickNumHats() {
                if (_JoystickNumHatsFunc == null) {
                    _JoystickNumHatsFunc =
                        (_JoystickNumHats)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickNumHats"), typeof(_JoystickNumHats));
                }
                
                return _JoystickNumHatsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumButtons(JoystickNumButtons__Args args);
            private static _JoystickNumButtons _JoystickNumButtonsFunc;
            internal static _JoystickNumButtons JoystickNumButtons() {
                if (_JoystickNumButtonsFunc == null) {
                    _JoystickNumButtonsFunc =
                        (_JoystickNumButtons)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickNumButtons"), typeof(_JoystickNumButtons));
                }
                
                return _JoystickNumButtonsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumBalls__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumBalls(JoystickNumBalls__Args args);
            private static _JoystickNumBalls _JoystickNumBallsFunc;
            internal static _JoystickNumBalls JoystickNumBalls() {
                if (_JoystickNumBallsFunc == null) {
                    _JoystickNumBallsFunc =
                        (_JoystickNumBalls)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickNumBalls"), typeof(_JoystickNumBalls));
                }
                
                return _JoystickNumBallsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumAxes(JoystickNumAxes__Args args);
            private static _JoystickNumAxes _JoystickNumAxesFunc;
            internal static _JoystickNumAxes JoystickNumAxes() {
                if (_JoystickNumAxesFunc == null) {
                    _JoystickNumAxesFunc =
                        (_JoystickNumAxes)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickNumAxes"), typeof(_JoystickNumAxes));
                }
                
                return _JoystickNumAxesFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDeviceType__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDeviceType(GetDeviceType__Args args);
            private static _GetDeviceType _GetDeviceTypeFunc;
            internal static _GetDeviceType GetDeviceType() {
                if (_GetDeviceTypeFunc == null) {
                    _GetDeviceTypeFunc =
                        (_GetDeviceType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GetDeviceType"), typeof(_GetDeviceType));
                }
                
                return _GetDeviceTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProductVersion__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetProductVersion(GetProductVersion__Args args);
            private static _GetProductVersion _GetProductVersionFunc;
            internal static _GetProductVersion GetProductVersion() {
                if (_GetProductVersionFunc == null) {
                    _GetProductVersionFunc =
                        (_GetProductVersion)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GetProductVersion"), typeof(_GetProductVersion));
                }
                
                return _GetProductVersionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProduct__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetProduct(GetProduct__Args args);
            private static _GetProduct _GetProductFunc;
            internal static _GetProduct GetProduct() {
                if (_GetProductFunc == null) {
                    _GetProductFunc =
                        (_GetProduct)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GetProduct"), typeof(_GetProduct));
                }
                
                return _GetProductFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetVendor__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetVendor(GetVendor__Args args);
            private static _GetVendor _GetVendorFunc;
            internal static _GetVendor GetVendor() {
                if (_GetVendorFunc == null) {
                    _GetVendorFunc =
                        (_GetVendor)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_GetVendor"), typeof(_GetVendor));
                }
                
                return _GetVendorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetGUID__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetGUID(JoystickGetGUID__Args args);
            private static _JoystickGetGUID _JoystickGetGUIDFunc;
            internal static _JoystickGetGUID JoystickGetGUID() {
                if (_JoystickGetGUIDFunc == null) {
                    _JoystickGetGUIDFunc =
                        (_JoystickGetGUID)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickGetGUID"), typeof(_JoystickGetGUID));
                }
                
                return _JoystickGetGUIDFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerNameForIndex__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerNameForIndex(ControllerNameForIndex__Args args);
            private static _ControllerNameForIndex _ControllerNameForIndexFunc;
            internal static _ControllerNameForIndex ControllerNameForIndex() {
                if (_ControllerNameForIndexFunc == null) {
                    _ControllerNameForIndexFunc =
                        (_ControllerNameForIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_ControllerNameForIndex"), typeof(_ControllerNameForIndex));
                }
                
                return _ControllerNameForIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNameForIndex__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickNameForIndex(JoystickNameForIndex__Args args);
            private static _JoystickNameForIndex _JoystickNameForIndexFunc;
            internal static _JoystickNameForIndex JoystickNameForIndex() {
                if (_JoystickNameForIndexFunc == null) {
                    _JoystickNameForIndexFunc =
                        (_JoystickNameForIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_JoystickNameForIndex"), typeof(_JoystickNameForIndex));
                }
                
                return _JoystickNameForIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTorqueInstFromDevice__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTorqueInstFromDevice(GetTorqueInstFromDevice__Args args);
            private static _GetTorqueInstFromDevice _GetTorqueInstFromDeviceFunc;
            internal static _GetTorqueInstFromDevice GetTorqueInstFromDevice() {
                if (_GetTorqueInstFromDeviceFunc == null) {
                    _GetTorqueInstFromDeviceFunc =
                        (_GetTorqueInstFromDevice)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_getTorqueInstFromDevice"), typeof(_GetTorqueInstFromDevice));
                }
                
                return _GetTorqueInstFromDeviceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct CloseDevice__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CloseDevice(CloseDevice__Args args);
            private static _CloseDevice _CloseDeviceFunc;
            internal static _CloseDevice CloseDevice() {
                if (_CloseDeviceFunc == null) {
                    _CloseDeviceFunc =
                        (_CloseDevice)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_closeDevice"), typeof(_CloseDevice));
                }
                
                return _CloseDeviceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenAsController__Args
            {
                internal int sdlIndex;
                internal int torqueInstId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _OpenAsController(OpenAsController__Args args);
            private static _OpenAsController _OpenAsControllerFunc;
            internal static _OpenAsController OpenAsController() {
                if (_OpenAsControllerFunc == null) {
                    _OpenAsControllerFunc =
                        (_OpenAsController)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_openAsController"), typeof(_OpenAsController));
                }
                
                return _OpenAsControllerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenAsJoystick__Args
            {
                internal int sdlIndex;
                internal int torqueInstId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _OpenAsJoystick(OpenAsJoystick__Args args);
            private static _OpenAsJoystick _OpenAsJoystickFunc;
            internal static _OpenAsJoystick OpenAsJoystick() {
                if (_OpenAsJoystickFunc == null) {
                    _OpenAsJoystickFunc =
                        (_OpenAsJoystick)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_openAsJoystick"), typeof(_OpenAsJoystick));
                }
                
                return _OpenAsJoystickFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDeviceOpenState__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDeviceOpenState(GetDeviceOpenState__Args args);
            private static _GetDeviceOpenState _GetDeviceOpenStateFunc;
            internal static _GetDeviceOpenState GetDeviceOpenState() {
                if (_GetDeviceOpenStateFunc == null) {
                    _GetDeviceOpenStateFunc =
                        (_GetDeviceOpenState)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_getDeviceOpenState"), typeof(_GetDeviceOpenState));
                }
                
                return _GetDeviceOpenStateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct NumJoysticks__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _NumJoysticks(NumJoysticks__Args args);
            private static _NumJoysticks _NumJoysticksFunc;
            internal static _NumJoysticks NumJoysticks() {
                if (_NumJoysticksFunc == null) {
                    _NumJoysticksFunc =
                        (_NumJoysticks)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSDLInputManager_numJoysticks"), typeof(_NumJoysticks));
                }
                
                return _NumJoysticksFunc;
            }
        }
        #endregion

        public static string GameControllerMappingForIndex(int mappingIndex) {
             InternalUnsafeMethods.GameControllerMappingForIndex__Args _args = new InternalUnsafeMethods.GameControllerMappingForIndex__Args() {
                mappingIndex = mappingIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMappingForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static int GameControllerNumMappings() {
             InternalUnsafeMethods.GameControllerNumMappings__Args _args = new InternalUnsafeMethods.GameControllerNumMappings__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GameControllerNumMappings()(_args);
             return _engineResult;
        }

        public static int GameControllerAddMappingsFromFile(string fileName) {
             InternalUnsafeMethods.GameControllerAddMappingsFromFile__Args _args = new InternalUnsafeMethods.GameControllerAddMappingsFromFile__Args() {
                fileName = fileName,
             };
             int _engineResult = InternalUnsafeMethods.GameControllerAddMappingsFromFile()(_args);
             return _engineResult;
        }

        public static int GameControllerAddMapping(string mappingString) {
             InternalUnsafeMethods.GameControllerAddMapping__Args _args = new InternalUnsafeMethods.GameControllerAddMapping__Args() {
                mappingString = mappingString,
             };
             int _engineResult = InternalUnsafeMethods.GameControllerAddMapping()(_args);
             return _engineResult;
        }

        public static string GameControllerMappingForGUID(string guidStr) {
             InternalUnsafeMethods.GameControllerMappingForGUID__Args _args = new InternalUnsafeMethods.GameControllerMappingForGUID__Args() {
                guidStr = guidStr,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMappingForGUID()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string GameControllerMapping(int sdlIndex = 0) {
             InternalUnsafeMethods.GameControllerMapping__Args _args = new InternalUnsafeMethods.GameControllerMapping__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMapping()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string ControllerGetButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerGetButtons__Args _args = new InternalUnsafeMethods.ControllerGetButtons__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerGetButtons()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string ControllerGetAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerGetAxes__Args _args = new InternalUnsafeMethods.ControllerGetAxes__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerGetAxes()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string JoystickGetHats(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetHats__Args _args = new InternalUnsafeMethods.JoystickGetHats__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetHats()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string JoystickGetButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetButtons__Args _args = new InternalUnsafeMethods.JoystickGetButtons__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetButtons()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string JoystickGetAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetAxes__Args _args = new InternalUnsafeMethods.JoystickGetAxes__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetAxes()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string JoystickGetSpecs(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetSpecs__Args _args = new InternalUnsafeMethods.JoystickGetSpecs__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetSpecs()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static SDLPowerEnum JoystickPowerLevel(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickPowerLevel__Args _args = new InternalUnsafeMethods.JoystickPowerLevel__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickPowerLevel()(_args);
             return (SDLPowerEnum)_engineResult;
        }

        public static bool JoystickIsHaptic(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickIsHaptic__Args _args = new InternalUnsafeMethods.JoystickIsHaptic__Args() {
                sdlIndex = sdlIndex,
             };
             bool _engineResult = InternalUnsafeMethods.JoystickIsHaptic()(_args);
             return _engineResult;
        }

        public static bool IsGameController(int sdlIndex = 0) {
             InternalUnsafeMethods.IsGameController__Args _args = new InternalUnsafeMethods.IsGameController__Args() {
                sdlIndex = sdlIndex,
             };
             bool _engineResult = InternalUnsafeMethods.IsGameController()(_args);
             return _engineResult;
        }

        public static int JoystickNumHats(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumHats__Args _args = new InternalUnsafeMethods.JoystickNumHats__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumHats()(_args);
             return _engineResult;
        }

        public static int JoystickNumButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumButtons__Args _args = new InternalUnsafeMethods.JoystickNumButtons__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumButtons()(_args);
             return _engineResult;
        }

        public static int JoystickNumBalls(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumBalls__Args _args = new InternalUnsafeMethods.JoystickNumBalls__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumBalls()(_args);
             return _engineResult;
        }

        public static int JoystickNumAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumAxes__Args _args = new InternalUnsafeMethods.JoystickNumAxes__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumAxes()(_args);
             return _engineResult;
        }

        public static SDLJoystickType GetDeviceType(int sdlIndex = 0) {
             InternalUnsafeMethods.GetDeviceType__Args _args = new InternalUnsafeMethods.GetDeviceType__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetDeviceType()(_args);
             return (SDLJoystickType)_engineResult;
        }

        public static int GetProductVersion(int sdlIndex = 0) {
             InternalUnsafeMethods.GetProductVersion__Args _args = new InternalUnsafeMethods.GetProductVersion__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetProductVersion()(_args);
             return _engineResult;
        }

        public static int GetProduct(int sdlIndex = 0) {
             InternalUnsafeMethods.GetProduct__Args _args = new InternalUnsafeMethods.GetProduct__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetProduct()(_args);
             return _engineResult;
        }

        public static int GetVendor(int sdlIndex = 0) {
             InternalUnsafeMethods.GetVendor__Args _args = new InternalUnsafeMethods.GetVendor__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetVendor()(_args);
             return _engineResult;
        }

        public static string JoystickGetGUID(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetGUID__Args _args = new InternalUnsafeMethods.JoystickGetGUID__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetGUID()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string ControllerNameForIndex(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerNameForIndex__Args _args = new InternalUnsafeMethods.ControllerNameForIndex__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerNameForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string JoystickNameForIndex(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNameForIndex__Args _args = new InternalUnsafeMethods.JoystickNameForIndex__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickNameForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static string GetTorqueInstFromDevice(int sdlIndex = 0) {
             InternalUnsafeMethods.GetTorqueInstFromDevice__Args _args = new InternalUnsafeMethods.GetTorqueInstFromDevice__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTorqueInstFromDevice()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static void CloseDevice(int sdlIndex = 0) {
             InternalUnsafeMethods.CloseDevice__Args _args = new InternalUnsafeMethods.CloseDevice__Args() {
                sdlIndex = sdlIndex,
             };
             InternalUnsafeMethods.CloseDevice()(_args);
        }

        public static int OpenAsController(int sdlIndex = 0, int torqueInstId = 0) {
             InternalUnsafeMethods.OpenAsController__Args _args = new InternalUnsafeMethods.OpenAsController__Args() {
                sdlIndex = sdlIndex,
                torqueInstId = torqueInstId,
             };
             int _engineResult = InternalUnsafeMethods.OpenAsController()(_args);
             return _engineResult;
        }

        public static int OpenAsJoystick(int sdlIndex = 0, int torqueInstId = 0) {
             InternalUnsafeMethods.OpenAsJoystick__Args _args = new InternalUnsafeMethods.OpenAsJoystick__Args() {
                sdlIndex = sdlIndex,
                torqueInstId = torqueInstId,
             };
             int _engineResult = InternalUnsafeMethods.OpenAsJoystick()(_args);
             return _engineResult;
        }

        public static int GetDeviceOpenState(int sdlIndex = 0) {
             InternalUnsafeMethods.GetDeviceOpenState__Args _args = new InternalUnsafeMethods.GetDeviceOpenState__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetDeviceOpenState()(_args);
             return _engineResult;
        }

        public static int NumJoysticks() {
             InternalUnsafeMethods.NumJoysticks__Args _args = new InternalUnsafeMethods.NumJoysticks__Args() {
             };
             int _engineResult = InternalUnsafeMethods.NumJoysticks()(_args);
             return _engineResult;
        }

    }
}