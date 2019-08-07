using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
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
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class ZipObject : SimObject {



        public ZipObject(bool pRegister = false)
            : base(pRegister) {
        }

        public ZipObject(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ZipObject(string pName)
            : this(pName, false) {
        }

        public ZipObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ZipObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ZipObject(SimObject pObj)
            : base(pObj) {
        }

        public ZipObject(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFileEntry__Args
                {

				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetFileEntry(IntPtr _this, int index);
                internal delegate IntPtr _GetFileEntry(IntPtr _this, GetFileEntry__Args args);
                private static _GetFileEntry _GetFileEntryFunc;
                internal static _GetFileEntry GetFileEntry() {
                    if (_GetFileEntryFunc == null) {
                        _GetFileEntryFunc =
                            (_GetFileEntry)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_getFileEntry"), typeof(_GetFileEntry));
                    }

                    return _GetFileEntryFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFileEntryCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetFileEntryCount(IntPtr _this);
                internal delegate int _GetFileEntryCount(IntPtr _this, GetFileEntryCount__Args args);
                private static _GetFileEntryCount _GetFileEntryCountFunc;
                internal static _GetFileEntryCount GetFileEntryCount() {
                    if (_GetFileEntryCountFunc == null) {
                        _GetFileEntryCountFunc =
                            (_GetFileEntryCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_getFileEntryCount"), typeof(_GetFileEntryCount));
                    }

                    return _GetFileEntryCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteFile__Args
                {

				   internal string pathInZip;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _DeleteFile(IntPtr _this, string pathInZip);
                internal delegate bool _DeleteFile(IntPtr _this, DeleteFile__Args args);
                private static _DeleteFile _DeleteFileFunc;
                internal static _DeleteFile DeleteFile() {
                    if (_DeleteFileFunc == null) {
                        _DeleteFileFunc =
                            (_DeleteFile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_deleteFile"), typeof(_DeleteFile));
                    }

                    return _DeleteFileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ExtractFile__Args
                {

				   internal string pathInZip;

				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ExtractFile(IntPtr _this, string pathInZip, string filename);
                internal delegate bool _ExtractFile(IntPtr _this, ExtractFile__Args args);
                private static _ExtractFile _ExtractFileFunc;
                internal static _ExtractFile ExtractFile() {
                    if (_ExtractFileFunc == null) {
                        _ExtractFileFunc =
                            (_ExtractFile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_extractFile"), typeof(_ExtractFile));
                    }

                    return _ExtractFileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddFile__Args
                {

				   internal string filename;

				   internal string pathInZip;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool replace;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _AddFile(IntPtr _this, string filename, string pathInZip, [MarshalAs(UnmanagedType.I1)]bool replace);
                internal delegate bool _AddFile(IntPtr _this, AddFile__Args args);
                private static _AddFile _AddFileFunc;
                internal static _AddFile AddFile() {
                    if (_AddFileFunc == null) {
                        _AddFileFunc =
                            (_AddFile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_addFile"), typeof(_AddFile));
                    }

                    return _AddFileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CloseFile__Args
                {

				   internal IntPtr stream;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _CloseFile(IntPtr _this, IntPtr stream);
                internal delegate void _CloseFile(IntPtr _this, CloseFile__Args args);
                private static _CloseFile _CloseFileFunc;
                internal static _CloseFile CloseFile() {
                    if (_CloseFileFunc == null) {
                        _CloseFileFunc =
                            (_CloseFile)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_closeFile"), typeof(_CloseFile));
                    }

                    return _CloseFileFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenFileForWrite__Args
                {

				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _OpenFileForWrite(IntPtr _this, string filename);
                internal delegate IntPtr _OpenFileForWrite(IntPtr _this, OpenFileForWrite__Args args);
                private static _OpenFileForWrite _OpenFileForWriteFunc;
                internal static _OpenFileForWrite OpenFileForWrite() {
                    if (_OpenFileForWriteFunc == null) {
                        _OpenFileForWriteFunc =
                            (_OpenFileForWrite)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_openFileForWrite"), typeof(_OpenFileForWrite));
                    }

                    return _OpenFileForWriteFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenFileForRead__Args
                {

				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _OpenFileForRead(IntPtr _this, string filename);
                internal delegate IntPtr _OpenFileForRead(IntPtr _this, OpenFileForRead__Args args);
                private static _OpenFileForRead _OpenFileForReadFunc;
                internal static _OpenFileForRead OpenFileForRead() {
                    if (_OpenFileForReadFunc == null) {
                        _OpenFileForReadFunc =
                            (_OpenFileForRead)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_openFileForRead"), typeof(_OpenFileForRead));
                    }

                    return _OpenFileForReadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CloseArchive__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _CloseArchive(IntPtr _this);
                internal delegate void _CloseArchive(IntPtr _this, CloseArchive__Args args);
                private static _CloseArchive _CloseArchiveFunc;
                internal static _CloseArchive CloseArchive() {
                    if (_CloseArchiveFunc == null) {
                        _CloseArchiveFunc =
                            (_CloseArchive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_closeArchive"), typeof(_CloseArchive));
                    }

                    return _CloseArchiveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenArchive__Args
                {

				   internal string filename;

				   internal string accessMode;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OpenArchive(IntPtr _this, string filename, string accessMode);
                internal delegate bool _OpenArchive(IntPtr _this, OpenArchive__Args args);
                private static _OpenArchive _OpenArchiveFunc;
                internal static _OpenArchive OpenArchive() {
                    if (_OpenArchiveFunc == null) {
                        _OpenArchiveFunc =
                            (_OpenArchive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnZipObject_openArchive"), typeof(_OpenArchive));
                    }

                    return _OpenArchiveFunc;
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
                                    "fnZipObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnZipObject_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public string GetFileEntry(int index) {

                                          InternalUnsafeMethods.GetFileEntry__Args _args = new InternalUnsafeMethods.GetFileEntry__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetFileEntry()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public int GetFileEntryCount() {

                     InternalUnsafeMethods.GetFileEntryCount__Args _args = new InternalUnsafeMethods.GetFileEntryCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetFileEntryCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool DeleteFile(string pathInZip) {

                                          InternalUnsafeMethods.DeleteFile__Args _args = new InternalUnsafeMethods.DeleteFile__Args() {
                        pathInZip = pathInZip,
                     };
                     bool _engineResult = InternalUnsafeMethods.DeleteFile()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool ExtractFile(string pathInZip, string filename) {

                                                               InternalUnsafeMethods.ExtractFile__Args _args = new InternalUnsafeMethods.ExtractFile__Args() {
                        pathInZip = pathInZip,
                        filename = filename,
                     };
                     bool _engineResult = InternalUnsafeMethods.ExtractFile()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool AddFile(string filename, string pathInZip, bool replace = true) {

                                                                                    InternalUnsafeMethods.AddFile__Args _args = new InternalUnsafeMethods.AddFile__Args() {
                        filename = filename,
                        pathInZip = pathInZip,
                        replace = replace,
                     };
                     bool _engineResult = InternalUnsafeMethods.AddFile()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void CloseFile(SimObject stream) {

                                          InternalUnsafeMethods.CloseFile__Args _args = new InternalUnsafeMethods.CloseFile__Args() {
                        stream = stream.ObjectPtr,
                     };
                     InternalUnsafeMethods.CloseFile()(ObjectPtr, _args);

                  }



                  public SimObject OpenFileForWrite(string filename) {

                                          InternalUnsafeMethods.OpenFileForWrite__Args _args = new InternalUnsafeMethods.OpenFileForWrite__Args() {
                        filename = filename,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.OpenFileForWrite()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public SimObject OpenFileForRead(string filename) {

                                          InternalUnsafeMethods.OpenFileForRead__Args _args = new InternalUnsafeMethods.OpenFileForRead__Args() {
                        filename = filename,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.OpenFileForRead()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public void CloseArchive() {

                     InternalUnsafeMethods.CloseArchive__Args _args = new InternalUnsafeMethods.CloseArchive__Args() {
                     };
                     InternalUnsafeMethods.CloseArchive()(ObjectPtr, _args);

                  }



                  public bool OpenArchive(string filename, string accessMode = "read") {

                                                               InternalUnsafeMethods.OpenArchive__Args _args = new InternalUnsafeMethods.OpenArchive__Args() {
                        filename = filename,
                        accessMode = accessMode,
                     };
                     bool _engineResult = InternalUnsafeMethods.OpenArchive()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
