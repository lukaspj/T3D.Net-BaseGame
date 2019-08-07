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

    public unsafe class GuiPopUpMenuCtrlEx : GuiTextCtrl {



        public GuiPopUpMenuCtrlEx(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiPopUpMenuCtrlEx(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiPopUpMenuCtrlEx(string pName) 
            : this(pName, false) {
        }
        
        public GuiPopUpMenuCtrlEx(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiPopUpMenuCtrlEx(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiPopUpMenuCtrlEx(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiPopUpMenuCtrlEx(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearEntry__Args
                {
				   
				   internal int entry;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearEntry(IntPtr _this, int entry);
                internal delegate void _ClearEntry(IntPtr _this, ClearEntry__Args args);
                private static _ClearEntry _ClearEntryFunc;
                internal static _ClearEntry ClearEntry() {
                    if (_ClearEntryFunc == null) {
                        _ClearEntryFunc =
                            (_ClearEntry)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_clearEntry"), typeof(_ClearEntry));
                    }
                    
                    return _ClearEntryFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ReplaceText__Args
                {
				   
				   internal int boolVal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ReplaceText(IntPtr _this, int boolVal);
                internal delegate void _ReplaceText(IntPtr _this, ReplaceText__Args args);
                private static _ReplaceText _ReplaceTextFunc;
                internal static _ReplaceText ReplaceText() {
                    if (_ReplaceTextFunc == null) {
                        _ReplaceTextFunc =
                            (_ReplaceText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_replaceText"), typeof(_ReplaceText));
                    }
                    
                    return _ReplaceTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Size__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _Size(IntPtr _this);
                internal delegate int _Size(IntPtr _this, Size__Args args);
                private static _Size _SizeFunc;
                internal static _Size Size() {
                    if (_SizeFunc == null) {
                        _SizeFunc =
                            (_Size)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_size"), typeof(_Size));
                    }
                    
                    return _SizeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindText__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindText(IntPtr _this, string text);
                internal delegate int _FindText(IntPtr _this, FindText__Args args);
                private static _FindText _FindTextFunc;
                internal static _FindText FindText() {
                    if (_FindTextFunc == null) {
                        _FindTextFunc =
                            (_FindText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_findText"), typeof(_FindText));
                    }
                    
                    return _FindTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetEnumContent__Args
                {
				   
				   internal string className;
				   
				   internal string enumName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetEnumContent(IntPtr _this, string className, string enumName);
                internal delegate void _SetEnumContent(IntPtr _this, SetEnumContent__Args args);
                private static _SetEnumContent _SetEnumContentFunc;
                internal static _SetEnumContent SetEnumContent() {
                    if (_SetEnumContentFunc == null) {
                        _SetEnumContentFunc =
                            (_SetEnumContent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_setEnumContent"), typeof(_SetEnumContent));
                    }
                    
                    return _SetEnumContentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetColorById__Args
                {
				   
				   internal int id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate ColorI.InternalStruct _GetColorById(IntPtr _this, int id);
                internal delegate ColorI.InternalStruct _GetColorById(IntPtr _this, GetColorById__Args args);
                private static _GetColorById _GetColorByIdFunc;
                internal static _GetColorById GetColorById() {
                    if (_GetColorByIdFunc == null) {
                        _GetColorByIdFunc =
                            (_GetColorById)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_getColorById"), typeof(_GetColorById));
                    }
                    
                    return _GetColorByIdFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTextById__Args
                {
				   
				   internal int id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetTextById(IntPtr _this, int id);
                internal delegate IntPtr _GetTextById(IntPtr _this, GetTextById__Args args);
                private static _GetTextById _GetTextByIdFunc;
                internal static _GetTextById GetTextById() {
                    if (_GetTextByIdFunc == null) {
                        _GetTextByIdFunc =
                            (_GetTextById)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_getTextById"), typeof(_GetTextById));
                    }
                    
                    return _GetTextByIdFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetNoneSelected__Args
                {
				   
				   internal int param;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetNoneSelected(IntPtr _this, int param);
                internal delegate void _SetNoneSelected(IntPtr _this, SetNoneSelected__Args args);
                private static _SetNoneSelected _SetNoneSelectedFunc;
                internal static _SetNoneSelected SetNoneSelected() {
                    if (_SetNoneSelectedFunc == null) {
                        _SetNoneSelectedFunc =
                            (_SetNoneSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_setNoneSelected"), typeof(_SetNoneSelected));
                    }
                    
                    return _SetNoneSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFirstSelected__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool scriptCallback;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetFirstSelected(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool scriptCallback);
                internal delegate void _SetFirstSelected(IntPtr _this, SetFirstSelected__Args args);
                private static _SetFirstSelected _SetFirstSelectedFunc;
                internal static _SetFirstSelected SetFirstSelected() {
                    if (_SetFirstSelectedFunc == null) {
                        _SetFirstSelectedFunc =
                            (_SetFirstSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_setFirstSelected"), typeof(_SetFirstSelected));
                    }
                    
                    return _SetFirstSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSelected__Args
                {
				   
				   internal int id;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool scriptCallback;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetSelected(IntPtr _this, int id, [MarshalAs(UnmanagedType.I1)]bool scriptCallback);
                internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
                private static _SetSelected _SetSelectedFunc;
                internal static _SetSelected SetSelected() {
                    if (_SetSelectedFunc == null) {
                        _SetSelectedFunc =
                            (_SetSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_setSelected"), typeof(_SetSelected));
                    }
                    
                    return _SetSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelected__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelected(IntPtr _this);
                internal delegate int _GetSelected(IntPtr _this, GetSelected__Args args);
                private static _GetSelected _GetSelectedFunc;
                internal static _GetSelected GetSelected() {
                    if (_GetSelectedFunc == null) {
                        _GetSelectedFunc =
                            (_GetSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_getSelected"), typeof(_GetSelected));
                    }
                    
                    return _GetSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ForceClose__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ForceClose(IntPtr _this);
                internal delegate void _ForceClose(IntPtr _this, ForceClose__Args args);
                private static _ForceClose _ForceCloseFunc;
                internal static _ForceClose ForceClose() {
                    if (_ForceCloseFunc == null) {
                        _ForceCloseFunc =
                            (_ForceClose)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_forceClose"), typeof(_ForceClose));
                    }
                    
                    return _ForceCloseFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ForceOnAction__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ForceOnAction(IntPtr _this);
                internal delegate void _ForceOnAction(IntPtr _this, ForceOnAction__Args args);
                private static _ForceOnAction _ForceOnActionFunc;
                internal static _ForceOnAction ForceOnAction() {
                    if (_ForceOnActionFunc == null) {
                        _ForceOnActionFunc =
                            (_ForceOnAction)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_forceOnAction"), typeof(_ForceOnAction));
                    }
                    
                    return _ForceOnActionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SortID__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SortID(IntPtr _this);
                internal delegate void _SortID(IntPtr _this, SortID__Args args);
                private static _SortID _SortIDFunc;
                internal static _SortID SortID() {
                    if (_SortIDFunc == null) {
                        _SortIDFunc =
                            (_SortID)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_sortID"), typeof(_SortID));
                    }
                    
                    return _SortIDFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Sort__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Sort(IntPtr _this);
                internal delegate void _Sort(IntPtr _this, Sort__Args args);
                private static _Sort _SortFunc;
                internal static _Sort Sort() {
                    if (_SortFunc == null) {
                        _SortFunc =
                            (_Sort)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_sort"), typeof(_Sort));
                    }
                    
                    return _SortFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Clear__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Clear(IntPtr _this);
                internal delegate void _Clear(IntPtr _this, Clear__Args args);
                private static _Clear _ClearFunc;
                internal static _Clear Clear() {
                    if (_ClearFunc == null) {
                        _ClearFunc =
                            (_Clear)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_clear"), typeof(_Clear));
                    }
                    
                    return _ClearFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetText__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetText(IntPtr _this);
                internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
                private static _GetText _GetTextFunc;
                internal static _GetText GetText() {
                    if (_GetTextFunc == null) {
                        _GetTextFunc =
                            (_GetText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_getText"), typeof(_GetText));
                    }
                    
                    return _GetTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetText__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetText(IntPtr _this, string text);
                internal delegate void _SetText(IntPtr _this, SetText__Args args);
                private static _SetText _SetTextFunc;
                internal static _SetText SetText() {
                    if (_SetTextFunc == null) {
                        _SetTextFunc =
                            (_SetText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_setText"), typeof(_SetText));
                    }
                    
                    return _SetTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddScheme__Args
                {
				   
				   internal int id;
				   
				   internal IntPtr fontColor;
				   
				   internal IntPtr fontColorHL;
				   
				   internal IntPtr fontColorSEL;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddScheme(IntPtr _this, int id, IntPtr fontColor, IntPtr fontColorHL, IntPtr fontColorSEL);
                internal delegate void _AddScheme(IntPtr _this, AddScheme__Args args);
                private static _AddScheme _AddSchemeFunc;
                internal static _AddScheme AddScheme() {
                    if (_AddSchemeFunc == null) {
                        _AddSchemeFunc =
                            (_AddScheme)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_addScheme"), typeof(_AddScheme));
                    }
                    
                    return _AddSchemeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddCategory__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddCategory(IntPtr _this, string text);
                internal delegate void _AddCategory(IntPtr _this, AddCategory__Args args);
                private static _AddCategory _AddCategoryFunc;
                internal static _AddCategory AddCategory() {
                    if (_AddCategoryFunc == null) {
                        _AddCategoryFunc =
                            (_AddCategory)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_addCategory"), typeof(_AddCategory));
                    }
                    
                    return _AddCategoryFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Add__Args
                {
				   
				   internal string name;
				   
				   internal int idNum;
				   
				   internal uint scheme;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Add(IntPtr _this, string name, int idNum, uint scheme);
                internal delegate void _Add(IntPtr _this, Add__Args args);
                private static _Add _AddFunc;
                internal static _Add Add() {
                    if (_AddFunc == null) {
                        _AddFunc =
                            (_Add)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiPopUpMenuCtrlEx_add"), typeof(_Add));
                    }
                    
                    return _AddFunc;
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
                                    "fnGuiPopUpMenuCtrlEx_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiPopUpMenuCtrlEx_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void ClearEntry(int entry) {
        
                                          InternalUnsafeMethods.ClearEntry__Args _args = new InternalUnsafeMethods.ClearEntry__Args() {
                        entry = entry,
                     };
                     InternalUnsafeMethods.ClearEntry()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void ReplaceText(int boolVal) {
        
                                          InternalUnsafeMethods.ReplaceText__Args _args = new InternalUnsafeMethods.ReplaceText__Args() {
                        boolVal = boolVal,
                     };
                     InternalUnsafeMethods.ReplaceText()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int Size() {
        
                     InternalUnsafeMethods.Size__Args _args = new InternalUnsafeMethods.Size__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.Size()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int FindText(string text) {
        
                                          InternalUnsafeMethods.FindText__Args _args = new InternalUnsafeMethods.FindText__Args() {
                        text = text,
                     };
                     int _engineResult = InternalUnsafeMethods.FindText()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetEnumContent(string className, string enumName) {
        
                                                               InternalUnsafeMethods.SetEnumContent__Args _args = new InternalUnsafeMethods.SetEnumContent__Args() {
                        className = className,
                        enumName = enumName,
                     };
                     InternalUnsafeMethods.SetEnumContent()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public ColorI GetColorById(int id) {
        
                                          InternalUnsafeMethods.GetColorById__Args _args = new InternalUnsafeMethods.GetColorById__Args() {
                        id = id,
                     };
                     ColorI.InternalStruct _engineResult = InternalUnsafeMethods.GetColorById()(ObjectPtr, _args);
                                                      
                     return new ColorI(_engineResult);
                  }
	

			
                  public string GetTextById(int id) {
        
                                          InternalUnsafeMethods.GetTextById__Args _args = new InternalUnsafeMethods.GetTextById__Args() {
                        id = id,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetTextById()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetNoneSelected(int param) {
        
                                          InternalUnsafeMethods.SetNoneSelected__Args _args = new InternalUnsafeMethods.SetNoneSelected__Args() {
                        param = param,
                     };
                     InternalUnsafeMethods.SetNoneSelected()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetFirstSelected(bool scriptCallback = true) {
        
                                          InternalUnsafeMethods.SetFirstSelected__Args _args = new InternalUnsafeMethods.SetFirstSelected__Args() {
                        scriptCallback = scriptCallback,
                     };
                     InternalUnsafeMethods.SetFirstSelected()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetSelected(int id, bool scriptCallback = true) {
        
                                                               InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
                        id = id,
                        scriptCallback = scriptCallback,
                     };
                     InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public int GetSelected() {
        
                     InternalUnsafeMethods.GetSelected__Args _args = new InternalUnsafeMethods.GetSelected__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelected()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void ForceClose() {
        
                     InternalUnsafeMethods.ForceClose__Args _args = new InternalUnsafeMethods.ForceClose__Args() {
                     };
                     InternalUnsafeMethods.ForceClose()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ForceOnAction() {
        
                     InternalUnsafeMethods.ForceOnAction__Args _args = new InternalUnsafeMethods.ForceOnAction__Args() {
                     };
                     InternalUnsafeMethods.ForceOnAction()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void SortID() {
        
                     InternalUnsafeMethods.SortID__Args _args = new InternalUnsafeMethods.SortID__Args() {
                     };
                     InternalUnsafeMethods.SortID()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Sort() {
        
                     InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
                     };
                     InternalUnsafeMethods.Sort()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Clear() {
        
                     InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
                     };
                     InternalUnsafeMethods.Clear()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetText() {
        
                     InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetText(string text) {
        
                                          InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.SetText()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddScheme(int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL) {
        
                                          fontColor.Alloc();                     fontColorHL.Alloc();                     fontColorSEL.Alloc();                     InternalUnsafeMethods.AddScheme__Args _args = new InternalUnsafeMethods.AddScheme__Args() {
                        id = id,
                        fontColor = fontColor.internalStructPtr,
                        fontColorHL = fontColorHL.internalStructPtr,
                        fontColorSEL = fontColorSEL.internalStructPtr,
                     };
                     InternalUnsafeMethods.AddScheme()(ObjectPtr, _args);
                                                               fontColor.Free();                     fontColorHL.Free();                     fontColorSEL.Free();            
                  }
	

			
                  public void AddCategory(string text) {
        
                                          InternalUnsafeMethods.AddCategory__Args _args = new InternalUnsafeMethods.AddCategory__Args() {
                        text = text,
                     };
                     InternalUnsafeMethods.AddCategory()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void Add(string name = "", int idNum = -1, uint scheme = 0) {
        
                                                                                    InternalUnsafeMethods.Add__Args _args = new InternalUnsafeMethods.Add__Args() {
                        name = name,
                        idNum = idNum,
                        scheme = scheme,
                     };
                     InternalUnsafeMethods.Add()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public int MaxPopupHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxPopupHeight"));
            set => SetFieldValue("maxPopupHeight", GenericMarshal.ToString(value));
        }


        public bool SbUsesNAColor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sbUsesNAColor"));
            set => SetFieldValue("sbUsesNAColor", GenericMarshal.ToString(value));
        }


        public bool ReverseTextList {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reverseTextList"));
            set => SetFieldValue("reverseTextList", GenericMarshal.ToString(value));
        }


        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("bitmap"));
            set => SetFieldValue("bitmap", GenericMarshal.ToString(value));
        }


        public Point2I BitmapBounds {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("bitmapBounds"));
            set => SetFieldValue("bitmapBounds", GenericMarshal.ToString(value));
        }


        public bool HotTrackCallback {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hotTrackCallback"));
            set => SetFieldValue("hotTrackCallback", GenericMarshal.ToString(value));
        }


    }
}