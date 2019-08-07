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

    public unsafe class LangTable : SimObject {



        public LangTable(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public LangTable(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public LangTable(string pName) 
            : this(pName, false) {
        }
        
        public LangTable(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public LangTable(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public LangTable(SimObject pObj) 
            : base(pObj) {
        }
        
        public LangTable(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetNumLang__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetNumLang(IntPtr _this);
                internal delegate int _GetNumLang(IntPtr _this, GetNumLang__Args args);
                private static _GetNumLang _GetNumLangFunc;
                internal static _GetNumLang GetNumLang() {
                    if (_GetNumLangFunc == null) {
                        _GetNumLangFunc =
                            (_GetNumLang)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_getNumLang"), typeof(_GetNumLang));
                    }
                    
                    return _GetNumLangFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLangName__Args
                {
				   
				   internal int langId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetLangName(IntPtr _this, int langId);
                internal delegate IntPtr _GetLangName(IntPtr _this, GetLangName__Args args);
                private static _GetLangName _GetLangNameFunc;
                internal static _GetLangName GetLangName() {
                    if (_GetLangNameFunc == null) {
                        _GetLangNameFunc =
                            (_GetLangName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_getLangName"), typeof(_GetLangName));
                    }
                    
                    return _GetLangNameFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCurrentLanguage__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetCurrentLanguage(IntPtr _this);
                internal delegate int _GetCurrentLanguage(IntPtr _this, GetCurrentLanguage__Args args);
                private static _GetCurrentLanguage _GetCurrentLanguageFunc;
                internal static _GetCurrentLanguage GetCurrentLanguage() {
                    if (_GetCurrentLanguageFunc == null) {
                        _GetCurrentLanguageFunc =
                            (_GetCurrentLanguage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_getCurrentLanguage"), typeof(_GetCurrentLanguage));
                    }
                    
                    return _GetCurrentLanguageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCurrentLanguage__Args
                {
				   
				   internal int langId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCurrentLanguage(IntPtr _this, int langId);
                internal delegate void _SetCurrentLanguage(IntPtr _this, SetCurrentLanguage__Args args);
                private static _SetCurrentLanguage _SetCurrentLanguageFunc;
                internal static _SetCurrentLanguage SetCurrentLanguage() {
                    if (_SetCurrentLanguageFunc == null) {
                        _SetCurrentLanguageFunc =
                            (_SetCurrentLanguage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_setCurrentLanguage"), typeof(_SetCurrentLanguage));
                    }
                    
                    return _SetCurrentLanguageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDefaultLanguage__Args
                {
				   
				   internal int langId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetDefaultLanguage(IntPtr _this, int langId);
                internal delegate void _SetDefaultLanguage(IntPtr _this, SetDefaultLanguage__Args args);
                private static _SetDefaultLanguage _SetDefaultLanguageFunc;
                internal static _SetDefaultLanguage SetDefaultLanguage() {
                    if (_SetDefaultLanguageFunc == null) {
                        _SetDefaultLanguageFunc =
                            (_SetDefaultLanguage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_setDefaultLanguage"), typeof(_SetDefaultLanguage));
                    }
                    
                    return _SetDefaultLanguageFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetString__Args
                {
				   
				   internal uint id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetString(IntPtr _this, uint id);
                internal delegate IntPtr _GetString(IntPtr _this, GetString__Args args);
                private static _GetString _GetStringFunc;
                internal static _GetString GetString() {
                    if (_GetStringFunc == null) {
                        _GetStringFunc =
                            (_GetString)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_getString"), typeof(_GetString));
                    }
                    
                    return _GetStringFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddLanguage__Args
                {
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string filename;
				   [MarshalAs(UnmanagedType.LPUTF8Str)]
				   internal string languageName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _AddLanguage(IntPtr _this, [MarshalAs(UnmanagedType.LPUTF8Str)]string filename, [MarshalAs(UnmanagedType.LPUTF8Str)]string languageName);
                internal delegate int _AddLanguage(IntPtr _this, AddLanguage__Args args);
                private static _AddLanguage _AddLanguageFunc;
                internal static _AddLanguage AddLanguage() {
                    if (_AddLanguageFunc == null) {
                        _AddLanguageFunc =
                            (_AddLanguage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnLangTable_addLanguage"), typeof(_AddLanguage));
                    }
                    
                    return _AddLanguageFunc;
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
                                    "fnLangTable_staticGetType"), typeof(_StaticGetType));
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
                                    "fnLangTable_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int GetNumLang() {
        
                     InternalUnsafeMethods.GetNumLang__Args _args = new InternalUnsafeMethods.GetNumLang__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetNumLang()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public string GetLangName(int langId) {
        
                                          InternalUnsafeMethods.GetLangName__Args _args = new InternalUnsafeMethods.GetLangName__Args() {
                        langId = langId,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetLangName()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetCurrentLanguage() {
        
                     InternalUnsafeMethods.GetCurrentLanguage__Args _args = new InternalUnsafeMethods.GetCurrentLanguage__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetCurrentLanguage()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetCurrentLanguage(int langId) {
        
                                          InternalUnsafeMethods.SetCurrentLanguage__Args _args = new InternalUnsafeMethods.SetCurrentLanguage__Args() {
                        langId = langId,
                     };
                     InternalUnsafeMethods.SetCurrentLanguage()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetDefaultLanguage(int langId) {
        
                                          InternalUnsafeMethods.SetDefaultLanguage__Args _args = new InternalUnsafeMethods.SetDefaultLanguage__Args() {
                        langId = langId,
                     };
                     InternalUnsafeMethods.SetDefaultLanguage()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetString(uint id) {
        
                                          InternalUnsafeMethods.GetString__Args _args = new InternalUnsafeMethods.GetString__Args() {
                        id = id,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetString()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int AddLanguage(string filename = "", string languageName = "") {
        
                                                               InternalUnsafeMethods.AddLanguage__Args _args = new InternalUnsafeMethods.AddLanguage__Args() {
                        filename = filename,
                        languageName = languageName,
                     };
                     int _engineResult = InternalUnsafeMethods.AddLanguage()(ObjectPtr, _args);
                                                                           
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