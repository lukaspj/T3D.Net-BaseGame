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

    public unsafe class GuiListBoxCtrl : GuiControl {



        public GuiListBoxCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiListBoxCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiListBoxCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiListBoxCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiListBoxCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiListBoxCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiListBoxCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveFilteredItem__Args
                {
				   
				   internal string itemName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveFilteredItem(IntPtr _this, string itemName);
                internal delegate void _RemoveFilteredItem(IntPtr _this, RemoveFilteredItem__Args args);
                private static _RemoveFilteredItem _RemoveFilteredItemFunc;
                internal static _RemoveFilteredItem RemoveFilteredItem() {
                    if (_RemoveFilteredItemFunc == null) {
                        _RemoveFilteredItemFunc =
                            (_RemoveFilteredItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_removeFilteredItem"), typeof(_RemoveFilteredItem));
                    }
                    
                    return _RemoveFilteredItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddFilteredItem__Args
                {
				   
				   internal string newItem;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddFilteredItem(IntPtr _this, string newItem);
                internal delegate void _AddFilteredItem(IntPtr _this, AddFilteredItem__Args args);
                private static _AddFilteredItem _AddFilteredItemFunc;
                internal static _AddFilteredItem AddFilteredItem() {
                    if (_AddFilteredItemFunc == null) {
                        _AddFilteredItemFunc =
                            (_AddFilteredItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_addFilteredItem"), typeof(_AddFilteredItem));
                    }
                    
                    return _AddFilteredItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct DoMirror__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _DoMirror(IntPtr _this);
                internal delegate void _DoMirror(IntPtr _this, DoMirror__Args args);
                private static _DoMirror _DoMirrorFunc;
                internal static _DoMirror DoMirror() {
                    if (_DoMirrorFunc == null) {
                        _DoMirrorFunc =
                            (_DoMirror)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_doMirror"), typeof(_DoMirror));
                    }
                    
                    return _DoMirrorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLastClickItem__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetLastClickItem(IntPtr _this);
                internal delegate int _GetLastClickItem(IntPtr _this, GetLastClickItem__Args args);
                private static _GetLastClickItem _GetLastClickItemFunc;
                internal static _GetLastClickItem GetLastClickItem() {
                    if (_GetLastClickItemFunc == null) {
                        _GetLastClickItemFunc =
                            (_GetLastClickItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getLastClickItem"), typeof(_GetLastClickItem));
                    }
                    
                    return _GetLastClickItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetItemTooltip__Args
                {
				   
				   internal int index;
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetItemTooltip(IntPtr _this, int index, string text);
                internal delegate void _SetItemTooltip(IntPtr _this, SetItemTooltip__Args args);
                private static _SetItemTooltip _SetItemTooltipFunc;
                internal static _SetItemTooltip SetItemTooltip() {
                    if (_SetItemTooltipFunc == null) {
                        _SetItemTooltipFunc =
                            (_SetItemTooltip)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setItemTooltip"), typeof(_SetItemTooltip));
                    }
                    
                    return _SetItemTooltipFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetItemText__Args
                {
				   
				   internal int index;
				   
				   internal string newtext;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetItemText(IntPtr _this, int index, string newtext);
                internal delegate void _SetItemText(IntPtr _this, SetItemText__Args args);
                private static _SetItemText _SetItemTextFunc;
                internal static _SetItemText SetItemText() {
                    if (_SetItemTextFunc == null) {
                        _SetItemTextFunc =
                            (_SetItemText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setItemText"), typeof(_SetItemText));
                    }
                    
                    return _SetItemTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemObject__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetItemObject(IntPtr _this, int index);
                internal delegate IntPtr _GetItemObject(IntPtr _this, GetItemObject__Args args);
                private static _GetItemObject _GetItemObjectFunc;
                internal static _GetItemObject GetItemObject() {
                    if (_GetItemObjectFunc == null) {
                        _GetItemObjectFunc =
                            (_GetItemObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getItemObject"), typeof(_GetItemObject));
                    }
                    
                    return _GetItemObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemText__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetItemText(IntPtr _this, int index);
                internal delegate IntPtr _GetItemText(IntPtr _this, GetItemText__Args args);
                private static _GetItemText _GetItemTextFunc;
                internal static _GetItemText GetItemText() {
                    if (_GetItemTextFunc == null) {
                        _GetItemTextFunc =
                            (_GetItemText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getItemText"), typeof(_GetItemText));
                    }
                    
                    return _GetItemTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteItem__Args
                {
				   
				   internal int itemIndex;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _DeleteItem(IntPtr _this, int itemIndex);
                internal delegate void _DeleteItem(IntPtr _this, DeleteItem__Args args);
                private static _DeleteItem _DeleteItemFunc;
                internal static _DeleteItem DeleteItem() {
                    if (_DeleteItemFunc == null) {
                        _DeleteItemFunc =
                            (_DeleteItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_deleteItem"), typeof(_DeleteItem));
                    }
                    
                    return _DeleteItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InsertItem__Args
                {
				   
				   internal string text;
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _InsertItem(IntPtr _this, string text, int index);
                internal delegate void _InsertItem(IntPtr _this, InsertItem__Args args);
                private static _InsertItem _InsertItemFunc;
                internal static _InsertItem InsertItem() {
                    if (_InsertItemFunc == null) {
                        _InsertItemFunc =
                            (_InsertItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_insertItem"), typeof(_InsertItem));
                    }
                    
                    return _InsertItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearItemColor__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearItemColor(IntPtr _this, int index);
                internal delegate void _ClearItemColor(IntPtr _this, ClearItemColor__Args args);
                private static _ClearItemColor _ClearItemColorFunc;
                internal static _ClearItemColor ClearItemColor() {
                    if (_ClearItemColorFunc == null) {
                        _ClearItemColorFunc =
                            (_ClearItemColor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_clearItemColor"), typeof(_ClearItemColor));
                    }
                    
                    return _ClearItemColorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetItemColor__Args
                {
				   
				   internal int index;
				   
				   internal IntPtr color;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetItemColor(IntPtr _this, int index, IntPtr color);
                internal delegate void _SetItemColor(IntPtr _this, SetItemColor__Args args);
                private static _SetItemColor _SetItemColorFunc;
                internal static _SetItemColor SetItemColor() {
                    if (_SetItemColorFunc == null) {
                        _SetItemColorFunc =
                            (_SetItemColor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setItemColor"), typeof(_SetItemColor));
                    }
                    
                    return _SetItemColorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddItem__Args
                {
				   
				   internal string newItem;
				   
				   internal string color;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _AddItem(IntPtr _this, string newItem, string color);
                internal delegate int _AddItem(IntPtr _this, AddItem__Args args);
                private static _AddItem _AddItemFunc;
                internal static _AddItem AddItem() {
                    if (_AddItemFunc == null) {
                        _AddItemFunc =
                            (_AddItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_addItem"), typeof(_AddItem));
                    }
                    
                    return _AddItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCurSelRange__Args
                {
				   
				   internal int indexStart;
				   
				   internal int indexStop;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCurSelRange(IntPtr _this, int indexStart, int indexStop);
                internal delegate void _SetCurSelRange(IntPtr _this, SetCurSelRange__Args args);
                private static _SetCurSelRange _SetCurSelRangeFunc;
                internal static _SetCurSelRange SetCurSelRange() {
                    if (_SetCurSelRangeFunc == null) {
                        _SetCurSelRangeFunc =
                            (_SetCurSelRange)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setCurSelRange"), typeof(_SetCurSelRange));
                    }
                    
                    return _SetCurSelRangeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCurSel__Args
                {
				   
				   internal int indexId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCurSel(IntPtr _this, int indexId);
                internal delegate void _SetCurSel(IntPtr _this, SetCurSel__Args args);
                private static _SetCurSel _SetCurSelFunc;
                internal static _SetCurSel SetCurSel() {
                    if (_SetCurSelFunc == null) {
                        _SetCurSelFunc =
                            (_SetCurSel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setCurSel"), typeof(_SetCurSel));
                    }
                    
                    return _SetCurSelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindItemText__Args
                {
				   
				   internal string findText;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool bCaseSensitive;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindItemText(IntPtr _this, string findText, [MarshalAs(UnmanagedType.I1)]bool bCaseSensitive);
                internal delegate int _FindItemText(IntPtr _this, FindItemText__Args args);
                private static _FindItemText _FindItemTextFunc;
                internal static _FindItemText FindItemText() {
                    if (_FindItemTextFunc == null) {
                        _FindItemTextFunc =
                            (_FindItemText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_findItemText"), typeof(_FindItemText));
                    }
                    
                    return _FindItemTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedItems__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSelectedItems(IntPtr _this);
                internal delegate IntPtr _GetSelectedItems(IntPtr _this, GetSelectedItems__Args args);
                private static _GetSelectedItems _GetSelectedItemsFunc;
                internal static _GetSelectedItems GetSelectedItems() {
                    if (_GetSelectedItemsFunc == null) {
                        _GetSelectedItemsFunc =
                            (_GetSelectedItems)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getSelectedItems"), typeof(_GetSelectedItems));
                    }
                    
                    return _GetSelectedItemsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedItem__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelectedItem(IntPtr _this);
                internal delegate int _GetSelectedItem(IntPtr _this, GetSelectedItem__Args args);
                private static _GetSelectedItem _GetSelectedItemFunc;
                internal static _GetSelectedItem GetSelectedItem() {
                    if (_GetSelectedItemFunc == null) {
                        _GetSelectedItemFunc =
                            (_GetSelectedItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getSelectedItem"), typeof(_GetSelectedItem));
                    }
                    
                    return _GetSelectedItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelCount(IntPtr _this);
                internal delegate int _GetSelCount(IntPtr _this, GetSelCount__Args args);
                private static _GetSelCount _GetSelCountFunc;
                internal static _GetSelCount GetSelCount() {
                    if (_GetSelCountFunc == null) {
                        _GetSelCountFunc =
                            (_GetSelCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getSelCount"), typeof(_GetSelCount));
                    }
                    
                    return _GetSelCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetItemCount(IntPtr _this);
                internal delegate int _GetItemCount(IntPtr _this, GetItemCount__Args args);
                private static _GetItemCount _GetItemCountFunc;
                internal static _GetItemCount GetItemCount() {
                    if (_GetItemCountFunc == null) {
                        _GetItemCountFunc =
                            (_GetItemCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_getItemCount"), typeof(_GetItemCount));
                    }
                    
                    return _GetItemCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetSelected__Args
                {
				   
				   internal int index;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool setSelected;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetSelected(IntPtr _this, int index, [MarshalAs(UnmanagedType.I1)]bool setSelected);
                internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
                private static _SetSelected _SetSelectedFunc;
                internal static _SetSelected SetSelected() {
                    if (_SetSelectedFunc == null) {
                        _SetSelectedFunc =
                            (_SetSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setSelected"), typeof(_SetSelected));
                    }
                    
                    return _SetSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearSelection(IntPtr _this);
                internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
                private static _ClearSelection _ClearSelectionFunc;
                internal static _ClearSelection ClearSelection() {
                    if (_ClearSelectionFunc == null) {
                        _ClearSelectionFunc =
                            (_ClearSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_clearSelection"), typeof(_ClearSelection));
                    }
                    
                    return _ClearSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearItems__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearItems(IntPtr _this);
                internal delegate void _ClearItems(IntPtr _this, ClearItems__Args args);
                private static _ClearItems _ClearItemsFunc;
                internal static _ClearItems ClearItems() {
                    if (_ClearItemsFunc == null) {
                        _ClearItemsFunc =
                            (_ClearItems)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_clearItems"), typeof(_ClearItems));
                    }
                    
                    return _ClearItemsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMultipleSelection__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool allowMultSelections;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMultipleSelection(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool allowMultSelections);
                internal delegate void _SetMultipleSelection(IntPtr _this, SetMultipleSelection__Args args);
                private static _SetMultipleSelection _SetMultipleSelectionFunc;
                internal static _SetMultipleSelection SetMultipleSelection() {
                    if (_SetMultipleSelectionFunc == null) {
                        _SetMultipleSelectionFunc =
                            (_SetMultipleSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiListBoxCtrl_setMultipleSelection"), typeof(_SetMultipleSelection));
                    }
                    
                    return _SetMultipleSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsObjectMirrored__Args
                {
				   
				   internal string indexIdString;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsObjectMirrored(IntPtr _this, string indexIdString);
                internal delegate bool _IsObjectMirrored(IntPtr _this, IsObjectMirrored__Args args);
                private static _IsObjectMirrored _IsObjectMirroredFunc;
                internal static _IsObjectMirrored IsObjectMirrored() {
                    if (_IsObjectMirroredFunc == null) {
                        _IsObjectMirroredFunc =
                            (_IsObjectMirrored)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_isObjectMirrored"), typeof(_IsObjectMirrored));
                    }
                    
                    return _IsObjectMirroredFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDeleteKey__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnDeleteKey(IntPtr _this);
                internal delegate void _OnDeleteKey(IntPtr _this, OnDeleteKey__Args args);
                private static _OnDeleteKey _OnDeleteKeyFunc;
                internal static _OnDeleteKey OnDeleteKey() {
                    if (_OnDeleteKeyFunc == null) {
                        _OnDeleteKeyFunc =
                            (_OnDeleteKey)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onDeleteKey"), typeof(_OnDeleteKey));
                    }
                    
                    return _OnDeleteKeyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseUp__Args
                {
				   
				   internal int itemHit;
				   
				   internal int mouseClickCount;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnMouseUp(IntPtr _this, int itemHit, int mouseClickCount);
                internal delegate void _OnMouseUp(IntPtr _this, OnMouseUp__Args args);
                private static _OnMouseUp _OnMouseUpFunc;
                internal static _OnMouseUp OnMouseUp() {
                    if (_OnMouseUpFunc == null) {
                        _OnMouseUpFunc =
                            (_OnMouseUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onMouseUp"), typeof(_OnMouseUp));
                    }
                    
                    return _OnMouseUpFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDoubleClick__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnDoubleClick(IntPtr _this);
                internal delegate void _OnDoubleClick(IntPtr _this, OnDoubleClick__Args args);
                private static _OnDoubleClick _OnDoubleClickFunc;
                internal static _OnDoubleClick OnDoubleClick() {
                    if (_OnDoubleClickFunc == null) {
                        _OnDoubleClickFunc =
                            (_OnDoubleClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onDoubleClick"), typeof(_OnDoubleClick));
                    }
                    
                    return _OnDoubleClickFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnSelect__Args
                {
				   
				   internal int index;
				   
				   internal string itemText;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnSelect(IntPtr _this, int index, string itemText);
                internal delegate void _OnSelect(IntPtr _this, OnSelect__Args args);
                private static _OnSelect _OnSelectFunc;
                internal static _OnSelect OnSelect() {
                    if (_OnSelectFunc == null) {
                        _OnSelectFunc =
                            (_OnSelect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onSelect"), typeof(_OnSelect));
                    }
                    
                    return _OnSelectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnUnSelect__Args
                {
				   
				   internal int index;
				   
				   internal string itemText;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnUnSelect(IntPtr _this, int index, string itemText);
                internal delegate void _OnUnSelect(IntPtr _this, OnUnSelect__Args args);
                private static _OnUnSelect _OnUnSelectFunc;
                internal static _OnUnSelect OnUnSelect() {
                    if (_OnUnSelectFunc == null) {
                        _OnUnSelectFunc =
                            (_OnUnSelect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onUnSelect"), typeof(_OnUnSelect));
                    }
                    
                    return _OnUnSelectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnClearSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnClearSelection(IntPtr _this);
                internal delegate void _OnClearSelection(IntPtr _this, OnClearSelection__Args args);
                private static _OnClearSelection _OnClearSelectionFunc;
                internal static _OnClearSelection OnClearSelection() {
                    if (_OnClearSelectionFunc == null) {
                        _OnClearSelectionFunc =
                            (_OnClearSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onClearSelection"), typeof(_OnClearSelection));
                    }
                    
                    return _OnClearSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseDragged__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnMouseDragged(IntPtr _this);
                internal delegate void _OnMouseDragged(IntPtr _this, OnMouseDragged__Args args);
                private static _OnMouseDragged _OnMouseDraggedFunc;
                internal static _OnMouseDragged OnMouseDragged() {
                    if (_OnMouseDraggedFunc == null) {
                        _OnMouseDraggedFunc =
                            (_OnMouseDragged)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiListBoxCtrl_onMouseDragged"), typeof(_OnMouseDragged));
                    }
                    
                    return _OnMouseDraggedFunc;
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
                                    "fnGuiListBoxCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiListBoxCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void RemoveFilteredItem(string itemName) {
        
                                          InternalUnsafeMethods.RemoveFilteredItem__Args _args = new InternalUnsafeMethods.RemoveFilteredItem__Args() {
                        itemName = itemName,
                     };
                     InternalUnsafeMethods.RemoveFilteredItem()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddFilteredItem(string newItem) {
        
                                          InternalUnsafeMethods.AddFilteredItem__Args _args = new InternalUnsafeMethods.AddFilteredItem__Args() {
                        newItem = newItem,
                     };
                     InternalUnsafeMethods.AddFilteredItem()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void DoMirror() {
        
                     InternalUnsafeMethods.DoMirror__Args _args = new InternalUnsafeMethods.DoMirror__Args() {
                     };
                     InternalUnsafeMethods.DoMirror()(ObjectPtr, _args);
                                 
                  }
	

			
                  public int GetLastClickItem() {
        
                     InternalUnsafeMethods.GetLastClickItem__Args _args = new InternalUnsafeMethods.GetLastClickItem__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetLastClickItem()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetItemTooltip(int index, string text) {
        
                                                               InternalUnsafeMethods.SetItemTooltip__Args _args = new InternalUnsafeMethods.SetItemTooltip__Args() {
                        index = index,
                        text = text,
                     };
                     InternalUnsafeMethods.SetItemTooltip()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void SetItemText(int index, string newtext) {
        
                                                               InternalUnsafeMethods.SetItemText__Args _args = new InternalUnsafeMethods.SetItemText__Args() {
                        index = index,
                        newtext = newtext,
                     };
                     InternalUnsafeMethods.SetItemText()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public string GetItemObject(int index) {
        
                                          InternalUnsafeMethods.GetItemObject__Args _args = new InternalUnsafeMethods.GetItemObject__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetItemObject()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public string GetItemText(int index) {
        
                                          InternalUnsafeMethods.GetItemText__Args _args = new InternalUnsafeMethods.GetItemText__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetItemText()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void DeleteItem(int itemIndex) {
        
                                          InternalUnsafeMethods.DeleteItem__Args _args = new InternalUnsafeMethods.DeleteItem__Args() {
                        itemIndex = itemIndex,
                     };
                     InternalUnsafeMethods.DeleteItem()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void InsertItem(string text, int index) {
        
                                                               InternalUnsafeMethods.InsertItem__Args _args = new InternalUnsafeMethods.InsertItem__Args() {
                        text = text,
                        index = index,
                     };
                     InternalUnsafeMethods.InsertItem()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void ClearItemColor(int index) {
        
                                          InternalUnsafeMethods.ClearItemColor__Args _args = new InternalUnsafeMethods.ClearItemColor__Args() {
                        index = index,
                     };
                     InternalUnsafeMethods.ClearItemColor()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetItemColor(int index, LinearColorF color) {
        
                                          color.Alloc();                     InternalUnsafeMethods.SetItemColor__Args _args = new InternalUnsafeMethods.SetItemColor__Args() {
                        index = index,
                        color = color.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetItemColor()(ObjectPtr, _args);
                                                               color.Free();            
                  }
	

			
                  public int AddItem(string newItem, string color = "") {
        
                                                               InternalUnsafeMethods.AddItem__Args _args = new InternalUnsafeMethods.AddItem__Args() {
                        newItem = newItem,
                        color = color,
                     };
                     int _engineResult = InternalUnsafeMethods.AddItem()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public void SetCurSelRange(int indexStart, int indexStop = 999999) {
        
                                                               InternalUnsafeMethods.SetCurSelRange__Args _args = new InternalUnsafeMethods.SetCurSelRange__Args() {
                        indexStart = indexStart,
                        indexStop = indexStop,
                     };
                     InternalUnsafeMethods.SetCurSelRange()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void SetCurSel(int indexId) {
        
                                          InternalUnsafeMethods.SetCurSel__Args _args = new InternalUnsafeMethods.SetCurSel__Args() {
                        indexId = indexId,
                     };
                     InternalUnsafeMethods.SetCurSel()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int FindItemText(string findText, bool bCaseSensitive = false) {
        
                                                               InternalUnsafeMethods.FindItemText__Args _args = new InternalUnsafeMethods.FindItemText__Args() {
                        findText = findText,
                        bCaseSensitive = bCaseSensitive,
                     };
                     int _engineResult = InternalUnsafeMethods.FindItemText()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public string GetSelectedItems() {
        
                     InternalUnsafeMethods.GetSelectedItems__Args _args = new InternalUnsafeMethods.GetSelectedItems__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSelectedItems()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetSelectedItem() {
        
                     InternalUnsafeMethods.GetSelectedItem__Args _args = new InternalUnsafeMethods.GetSelectedItem__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelectedItem()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetSelCount() {
        
                     InternalUnsafeMethods.GetSelCount__Args _args = new InternalUnsafeMethods.GetSelCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetItemCount() {
        
                     InternalUnsafeMethods.GetItemCount__Args _args = new InternalUnsafeMethods.GetItemCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetItemCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetSelected(int index, bool setSelected = true) {
        
                                                               InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
                        index = index,
                        setSelected = setSelected,
                     };
                     InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void ClearSelection() {
        
                     InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
                     };
                     InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ClearItems() {
        
                     InternalUnsafeMethods.ClearItems__Args _args = new InternalUnsafeMethods.ClearItems__Args() {
                     };
                     InternalUnsafeMethods.ClearItems()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void SetMultipleSelection(bool allowMultSelections) {
        
                                          InternalUnsafeMethods.SetMultipleSelection__Args _args = new InternalUnsafeMethods.SetMultipleSelection__Args() {
                        allowMultSelections = allowMultSelections,
                     };
                     InternalUnsafeMethods.SetMultipleSelection()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool IsObjectMirrored(string indexIdString) {
        
                                          InternalUnsafeMethods.IsObjectMirrored__Args _args = new InternalUnsafeMethods.IsObjectMirrored__Args() {
                        indexIdString = indexIdString,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsObjectMirrored()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void OnDeleteKey() {
        
                     InternalUnsafeMethods.OnDeleteKey__Args _args = new InternalUnsafeMethods.OnDeleteKey__Args() {
                     };
                     InternalUnsafeMethods.OnDeleteKey()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnMouseUp(int itemHit, int mouseClickCount) {
        
                                                               InternalUnsafeMethods.OnMouseUp__Args _args = new InternalUnsafeMethods.OnMouseUp__Args() {
                        itemHit = itemHit,
                        mouseClickCount = mouseClickCount,
                     };
                     InternalUnsafeMethods.OnMouseUp()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnDoubleClick() {
        
                     InternalUnsafeMethods.OnDoubleClick__Args _args = new InternalUnsafeMethods.OnDoubleClick__Args() {
                     };
                     InternalUnsafeMethods.OnDoubleClick()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnSelect(int index, string itemText) {
        
                                                               InternalUnsafeMethods.OnSelect__Args _args = new InternalUnsafeMethods.OnSelect__Args() {
                        index = index,
                        itemText = itemText,
                     };
                     InternalUnsafeMethods.OnSelect()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnUnSelect(int index, string itemText) {
        
                                                               InternalUnsafeMethods.OnUnSelect__Args _args = new InternalUnsafeMethods.OnUnSelect__Args() {
                        index = index,
                        itemText = itemText,
                     };
                     InternalUnsafeMethods.OnUnSelect()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnClearSelection() {
        
                     InternalUnsafeMethods.OnClearSelection__Args _args = new InternalUnsafeMethods.OnClearSelection__Args() {
                     };
                     InternalUnsafeMethods.OnClearSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnMouseDragged() {
        
                     InternalUnsafeMethods.OnMouseDragged__Args _args = new InternalUnsafeMethods.OnMouseDragged__Args() {
                     };
                     InternalUnsafeMethods.OnMouseDragged()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool AllowMultipleSelections {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowMultipleSelections"));
            set => SetFieldValue("allowMultipleSelections", GenericMarshal.ToString(value));
        }


        public bool FitParentWidth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fitParentWidth"));
            set => SetFieldValue("fitParentWidth", GenericMarshal.ToString(value));
        }


        public bool ColorBullet {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("colorBullet"));
            set => SetFieldValue("colorBullet", GenericMarshal.ToString(value));
        }


        public string MirrorSet {
            get => GenericMarshal.StringTo<string>(GetFieldValue("mirrorSet"));
            set => SetFieldValue("mirrorSet", GenericMarshal.ToString(value));
        }


        public string MakeNameCallback {
            get => GenericMarshal.StringTo<string>(GetFieldValue("makeNameCallback"));
            set => SetFieldValue("makeNameCallback", GenericMarshal.ToString(value));
        }


    }
}