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

    public static unsafe class BanList {

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Export__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Export(Export__Args args);
            private static _Export _ExportFunc;
            internal static _Export Export() {
                if (_ExportFunc == null) {
                    _ExportFunc =
                        (_Export)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnBanList_export"), typeof(_Export));
                }
                
                return _ExportFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsBanned__Args
            {
                internal int uniqueId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string transportAddress;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsBanned(IsBanned__Args args);
            private static _IsBanned _IsBannedFunc;
            internal static _IsBanned IsBanned() {
                if (_IsBannedFunc == null) {
                    _IsBannedFunc =
                        (_IsBanned)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnBanList_isBanned"), typeof(_IsBanned));
                }
                
                return _IsBannedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveBan__Args
            {
                internal int uniqueId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string transportAddress;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveBan(RemoveBan__Args args);
            private static _RemoveBan _RemoveBanFunc;
            internal static _RemoveBan RemoveBan() {
                if (_RemoveBanFunc == null) {
                    _RemoveBanFunc =
                        (_RemoveBan)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnBanList_removeBan"), typeof(_RemoveBan));
                }
                
                return _RemoveBanFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Add__Args
            {
                internal int uniqueId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string transportAddress;
                internal int banLength;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Add(Add__Args args);
            private static _Add _AddFunc;
            internal static _Add Add() {
                if (_AddFunc == null) {
                    _AddFunc =
                        (_Add)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnBanList_add"), typeof(_Add));
                }
                
                return _AddFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddAbsolute__Args
            {
                internal int uniqueId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string transportAddress;
                internal int banTime;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddAbsolute(AddAbsolute__Args args);
            private static _AddAbsolute _AddAbsoluteFunc;
            internal static _AddAbsolute AddAbsolute() {
                if (_AddAbsoluteFunc == null) {
                    _AddAbsoluteFunc =
                        (_AddAbsolute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnBanList_addAbsolute"), typeof(_AddAbsolute));
                }
                
                return _AddAbsoluteFunc;
            }
        }
        #endregion

        public static void Export(string filename) {
             InternalUnsafeMethods.Export__Args _args = new InternalUnsafeMethods.Export__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.Export()(_args);
        }

        public static bool IsBanned(int uniqueId, string transportAddress) {
             InternalUnsafeMethods.IsBanned__Args _args = new InternalUnsafeMethods.IsBanned__Args() {
                uniqueId = uniqueId,
                transportAddress = transportAddress,
             };
             bool _engineResult = InternalUnsafeMethods.IsBanned()(_args);
             return _engineResult;
        }

        public static void RemoveBan(int uniqueId, string transportAddress) {
             InternalUnsafeMethods.RemoveBan__Args _args = new InternalUnsafeMethods.RemoveBan__Args() {
                uniqueId = uniqueId,
                transportAddress = transportAddress,
             };
             InternalUnsafeMethods.RemoveBan()(_args);
        }

        public static void Add(int uniqueId, string transportAddress, int banLength) {
             InternalUnsafeMethods.Add__Args _args = new InternalUnsafeMethods.Add__Args() {
                uniqueId = uniqueId,
                transportAddress = transportAddress,
                banLength = banLength,
             };
             InternalUnsafeMethods.Add()(_args);
        }

        public static void AddAbsolute(int uniqueId, string transportAddress, int banTime) {
             InternalUnsafeMethods.AddAbsolute__Args _args = new InternalUnsafeMethods.AddAbsolute__Args() {
                uniqueId = uniqueId,
                transportAddress = transportAddress,
                banTime = banTime,
             };
             InternalUnsafeMethods.AddAbsolute()(_args);
        }

    }
}