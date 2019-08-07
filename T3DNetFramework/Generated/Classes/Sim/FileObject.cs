using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {    

    public unsafe class FileObject : SimObject {



        public FileObject(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public FileObject(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public FileObject(string pName) 
            : this(pName, false) {
        }
        
        public FileObject(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public FileObject(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public FileObject(SimObject pObj) 
            : base(pObj) {
        }
        
        public FileObject(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct WriteObject__Args
                {
				   
				   internal string simName;
				   
				   internal string objName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _WriteObject(IntPtr _this, string simName, string objName);
                internal delegate void _WriteObject(IntPtr _this, WriteObject__Args args);
                private static _WriteObject _WriteObjectFunc;
                internal static _WriteObject WriteObject() {
                    if (_WriteObjectFunc == null) {
                        _WriteObjectFunc =
                            (_WriteObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_writeObject"), typeof(_WriteObject));
                    }
                    
                    return _WriteObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Close__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Close(IntPtr _this);
                internal delegate void _Close(IntPtr _this, Close__Args args);
                private static _Close _CloseFunc;
                internal static _Close Close() {
                    if (_CloseFunc == null) {
                        _CloseFunc =
                            (_Close)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_close"), typeof(_Close));
                    }
                    
                    return _CloseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct WriteLine__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _WriteLine(IntPtr _this, string text);
                internal delegate void _WriteLine(IntPtr _this, WriteLine__Args args);
                private static _WriteLine _WriteLineFunc;
                internal static _WriteLine WriteLine() {
                    if (_WriteLineFunc == null) {
                        _WriteLineFunc =
                            (_WriteLine)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_writeLine"), typeof(_WriteLine));
                    }
                    
                    return _WriteLineFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PeekLine__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _PeekLine(IntPtr _this);
                internal delegate IntPtr _PeekLine(IntPtr _this, PeekLine__Args args);
                private static _PeekLine _PeekLineFunc;
                internal static _PeekLine PeekLine() {
                    if (_PeekLineFunc == null) {
                        _PeekLineFunc =
                            (_PeekLine)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_peekLine"), typeof(_PeekLine));
                    }
                    
                    return _PeekLineFunc;
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
                                    "fnFileObject_readLine"), typeof(_ReadLine));
                    }
                    
                    return _ReadLineFunc;
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
                                    "fnFileObject_isEOF"), typeof(_IsEOF));
                    }
                    
                    return _IsEOFFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenForAppend__Args
                {
				   
				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OpenForAppend(IntPtr _this, string filename);
                internal delegate bool _OpenForAppend(IntPtr _this, OpenForAppend__Args args);
                private static _OpenForAppend _OpenForAppendFunc;
                internal static _OpenForAppend OpenForAppend() {
                    if (_OpenForAppendFunc == null) {
                        _OpenForAppendFunc =
                            (_OpenForAppend)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_openForAppend"), typeof(_OpenForAppend));
                    }
                    
                    return _OpenForAppendFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenForWrite__Args
                {
				   
				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OpenForWrite(IntPtr _this, string filename);
                internal delegate bool _OpenForWrite(IntPtr _this, OpenForWrite__Args args);
                private static _OpenForWrite _OpenForWriteFunc;
                internal static _OpenForWrite OpenForWrite() {
                    if (_OpenForWriteFunc == null) {
                        _OpenForWriteFunc =
                            (_OpenForWrite)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_openForWrite"), typeof(_OpenForWrite));
                    }
                    
                    return _OpenForWriteFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OpenForRead__Args
                {
				   
				   internal string filename;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OpenForRead(IntPtr _this, string filename);
                internal delegate bool _OpenForRead(IntPtr _this, OpenForRead__Args args);
                private static _OpenForRead _OpenForReadFunc;
                internal static _OpenForRead OpenForRead() {
                    if (_OpenForReadFunc == null) {
                        _OpenForReadFunc =
                            (_OpenForRead)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnFileObject_openForRead"), typeof(_OpenForRead));
                    }
                    
                    return _OpenForReadFunc;
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
                                    "fnFileObject_staticGetType"), typeof(_StaticGetType));
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
                                    "fnFileObject_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void WriteObject(string simName, string objName = "") {
        
                                                               InternalUnsafeMethods.WriteObject__Args _args = new InternalUnsafeMethods.WriteObject__Args() {
                        simName = simName,
                        objName = objName,
                     };
                     InternalUnsafeMethods.WriteObject()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void Close() {
        
                     InternalUnsafeMethods.Close__Args _args = new InternalUnsafeMethods.Close__Args() {
                     };
                     InternalUnsafeMethods.Close()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void WriteLine(string text) {
        
                                          InternalUnsafeMethods.WriteLine__Args _args = new InternalUnsafeMethods.WriteLine__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.WriteLine()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string PeekLine() {
        
                     InternalUnsafeMethods.PeekLine__Args _args = new InternalUnsafeMethods.PeekLine__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.PeekLine()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public string ReadLine() {
        
                     InternalUnsafeMethods.ReadLine__Args _args = new InternalUnsafeMethods.ReadLine__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.ReadLine()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public bool IsEOF() {
        
                     InternalUnsafeMethods.IsEOF__Args _args = new InternalUnsafeMethods.IsEOF__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsEOF()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool OpenForAppend(string filename) {
        
                                          InternalUnsafeMethods.OpenForAppend__Args _args = new InternalUnsafeMethods.OpenForAppend__Args() {
                        filename = filename,
                     };
                     bool _engineResult = InternalUnsafeMethods.OpenForAppend()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool OpenForWrite(string filename) {
        
                                          InternalUnsafeMethods.OpenForWrite__Args _args = new InternalUnsafeMethods.OpenForWrite__Args() {
                        filename = filename,
                     };
                     bool _engineResult = InternalUnsafeMethods.OpenForWrite()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool OpenForRead(string filename) {
        
                                          InternalUnsafeMethods.OpenForRead__Args _args = new InternalUnsafeMethods.OpenForRead__Args() {
                        filename = filename,
                     };
                     bool _engineResult = InternalUnsafeMethods.OpenForRead()(ObjectPtr, _args);
                                                      
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