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

    public unsafe class StreamObject : SimObject {



        public StreamObject(bool pRegister = false)
            : base(pRegister) {
        }

        public StreamObject(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public StreamObject(string pName)
            : this(pName, false) {
        }

        public StreamObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public StreamObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public StreamObject(SimObject pObj)
            : base(pObj) {
        }

        public StreamObject(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct CopyFrom__Args
                {

				   internal IntPtr other;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CopyFrom(IntPtr _this, IntPtr other);
                internal delegate bool _CopyFrom(IntPtr _this, CopyFrom__Args args);
                private static _CopyFrom _CopyFromFunc;
                internal static _CopyFrom CopyFrom() {
                    if (_CopyFromFunc == null) {
                        _CopyFromFunc =
                            (_CopyFrom)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_copyFrom"), typeof(_CopyFrom));
                    }

                    return _CopyFromFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct WriteString__Args
                {

				   internal string _string;

				   internal int maxLength;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _WriteString(IntPtr _this, string _string, int maxLength);
                internal delegate void _WriteString(IntPtr _this, WriteString__Args args);
                private static _WriteString _WriteStringFunc;
                internal static _WriteString WriteString() {
                    if (_WriteStringFunc == null) {
                        _WriteStringFunc =
                            (_WriteString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_writeString"), typeof(_WriteString));
                    }

                    return _WriteStringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct WriteLongString__Args
                {

				   internal int maxLength;

				   internal string _string;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _WriteLongString(IntPtr _this, int maxLength, string _string);
                internal delegate void _WriteLongString(IntPtr _this, WriteLongString__Args args);
                private static _WriteLongString _WriteLongStringFunc;
                internal static _WriteLongString WriteLongString() {
                    if (_WriteLongStringFunc == null) {
                        _WriteLongStringFunc =
                            (_WriteLongString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_writeLongString"), typeof(_WriteLongString));
                    }

                    return _WriteLongStringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ReadLongString__Args
                {

				   internal int maxLength;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _ReadLongString(IntPtr _this, int maxLength);
                internal delegate IntPtr _ReadLongString(IntPtr _this, ReadLongString__Args args);
                private static _ReadLongString _ReadLongStringFunc;
                internal static _ReadLongString ReadLongString() {
                    if (_ReadLongStringFunc == null) {
                        _ReadLongStringFunc =
                            (_ReadLongString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_readLongString"), typeof(_ReadLongString));
                    }

                    return _ReadLongStringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ReadString__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _ReadString(IntPtr _this);
                internal delegate IntPtr _ReadString(IntPtr _this, ReadString__Args args);
                private static _ReadString _ReadStringFunc;
                internal static _ReadString ReadString() {
                    if (_ReadStringFunc == null) {
                        _ReadStringFunc =
                            (_ReadString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_readString"), typeof(_ReadString));
                    }

                    return _ReadStringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ReadSTString__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool caseSensitive;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _ReadSTString(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool caseSensitive);
                internal delegate IntPtr _ReadSTString(IntPtr _this, ReadSTString__Args args);
                private static _ReadSTString _ReadSTStringFunc;
                internal static _ReadSTString ReadSTString() {
                    if (_ReadSTStringFunc == null) {
                        _ReadSTStringFunc =
                            (_ReadSTString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_readSTString"), typeof(_ReadSTString));
                    }

                    return _ReadSTStringFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct WriteLine__Args
                {

				   internal string line;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _WriteLine(IntPtr _this, string line);
                internal delegate void _WriteLine(IntPtr _this, WriteLine__Args args);
                private static _WriteLine _WriteLineFunc;
                internal static _WriteLine WriteLine() {
                    if (_WriteLineFunc == null) {
                        _WriteLineFunc =
                            (_WriteLine)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_writeLine"), typeof(_WriteLine));
                    }

                    return _WriteLineFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ReadLine__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _ReadLine(IntPtr _this);
                internal delegate IntPtr _ReadLine(IntPtr _this, ReadLine__Args args);
                private static _ReadLine _ReadLineFunc;
                internal static _ReadLine ReadLine() {
                    if (_ReadLineFunc == null) {
                        _ReadLineFunc =
                            (_ReadLine)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_readLine"), typeof(_ReadLine));
                    }

                    return _ReadLineFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetStreamSize__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetStreamSize(IntPtr _this);
                internal delegate int _GetStreamSize(IntPtr _this, GetStreamSize__Args args);
                private static _GetStreamSize _GetStreamSizeFunc;
                internal static _GetStreamSize GetStreamSize() {
                    if (_GetStreamSizeFunc == null) {
                        _GetStreamSizeFunc =
                            (_GetStreamSize)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_getStreamSize"), typeof(_GetStreamSize));
                    }

                    return _GetStreamSizeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetPosition__Args
                {

				   internal int newPosition;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetPosition(IntPtr _this, int newPosition);
                internal delegate bool _SetPosition(IntPtr _this, SetPosition__Args args);
                private static _SetPosition _SetPositionFunc;
                internal static _SetPosition SetPosition() {
                    if (_SetPositionFunc == null) {
                        _SetPositionFunc =
                            (_SetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_setPosition"), typeof(_SetPosition));
                    }

                    return _SetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetPosition(IntPtr _this);
                internal delegate int _GetPosition(IntPtr _this, GetPosition__Args args);
                private static _GetPosition _GetPositionFunc;
                internal static _GetPosition GetPosition() {
                    if (_GetPositionFunc == null) {
                        _GetPositionFunc =
                            (_GetPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_getPosition"), typeof(_GetPosition));
                    }

                    return _GetPositionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsEOF__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsEOF(IntPtr _this);
                internal delegate bool _IsEOF(IntPtr _this, IsEOF__Args args);
                private static _IsEOF _IsEOFFunc;
                internal static _IsEOF IsEOF() {
                    if (_IsEOFFunc == null) {
                        _IsEOFFunc =
                            (_IsEOF)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_isEOF"), typeof(_IsEOF));
                    }

                    return _IsEOFFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsEOS__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsEOS(IntPtr _this);
                internal delegate bool _IsEOS(IntPtr _this, IsEOS__Args args);
                private static _IsEOS _IsEOSFunc;
                internal static _IsEOS IsEOS() {
                    if (_IsEOSFunc == null) {
                        _IsEOSFunc =
                            (_IsEOS)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_isEOS"), typeof(_IsEOS));
                    }

                    return _IsEOSFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetStatus__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetStatus(IntPtr _this);
                internal delegate IntPtr _GetStatus(IntPtr _this, GetStatus__Args args);
                private static _GetStatus _GetStatusFunc;
                internal static _GetStatus GetStatus() {
                    if (_GetStatusFunc == null) {
                        _GetStatusFunc =
                            (_GetStatus)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnStreamObject_getStatus"), typeof(_GetStatus));
                    }

                    return _GetStatusFunc;
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
                                    "fnStreamObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnStreamObject_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool CopyFrom(SimObject other) {

                                          InternalUnsafeMethods.CopyFrom__Args _args = new InternalUnsafeMethods.CopyFrom__Args() {
                        other = other.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.CopyFrom()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void WriteString(string _string, int maxLength = 256) {

                                                               InternalUnsafeMethods.WriteString__Args _args = new InternalUnsafeMethods.WriteString__Args() {
                        _string = _string,
                        maxLength = maxLength,
                     };
                     InternalUnsafeMethods.WriteString()(ObjectPtr, _args);

                  }



                  public void WriteLongString(int maxLength, string _string) {

                                                               InternalUnsafeMethods.WriteLongString__Args _args = new InternalUnsafeMethods.WriteLongString__Args() {
                        maxLength = maxLength,
                        _string = _string,
                     };
                     InternalUnsafeMethods.WriteLongString()(ObjectPtr, _args);

                  }



                  public string ReadLongString(int maxLength) {

                                          InternalUnsafeMethods.ReadLongString__Args _args = new InternalUnsafeMethods.ReadLongString__Args() {
                        maxLength = maxLength,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ReadLongString()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public string ReadString() {

                     InternalUnsafeMethods.ReadString__Args _args = new InternalUnsafeMethods.ReadString__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ReadString()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public string ReadSTString(bool caseSensitive = false) {

                                          InternalUnsafeMethods.ReadSTString__Args _args = new InternalUnsafeMethods.ReadSTString__Args() {
                        caseSensitive = caseSensitive,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ReadSTString()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void WriteLine(string line) {

                                          InternalUnsafeMethods.WriteLine__Args _args = new InternalUnsafeMethods.WriteLine__Args() {
                        line = line,
                     };
                     InternalUnsafeMethods.WriteLine()(ObjectPtr, _args);

                  }



                  public string ReadLine() {

                     InternalUnsafeMethods.ReadLine__Args _args = new InternalUnsafeMethods.ReadLine__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ReadLine()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public int GetStreamSize() {

                     InternalUnsafeMethods.GetStreamSize__Args _args = new InternalUnsafeMethods.GetStreamSize__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetStreamSize()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool SetPosition(int newPosition) {

                                          InternalUnsafeMethods.SetPosition__Args _args = new InternalUnsafeMethods.SetPosition__Args() {
                        newPosition = newPosition,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetPosition()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetPosition() {

                     InternalUnsafeMethods.GetPosition__Args _args = new InternalUnsafeMethods.GetPosition__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetPosition()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsEOF() {

                     InternalUnsafeMethods.IsEOF__Args _args = new InternalUnsafeMethods.IsEOF__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsEOF()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool IsEOS() {

                     InternalUnsafeMethods.IsEOS__Args _args = new InternalUnsafeMethods.IsEOS__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsEOS()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public string GetStatus() {

                     InternalUnsafeMethods.GetStatus__Args _args = new InternalUnsafeMethods.GetStatus__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetStatus()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
