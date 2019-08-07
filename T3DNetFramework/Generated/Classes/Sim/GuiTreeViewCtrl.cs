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

    public unsafe class GuiTreeViewCtrl : GuiArrayCtrl {



        public GuiTreeViewCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTreeViewCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTreeViewCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTreeViewCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTreeViewCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTreeViewCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTreeViewCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemAtPosition__Args
                {
				   
				   internal IntPtr position;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetItemAtPosition(IntPtr _this, IntPtr position);
                internal delegate int _GetItemAtPosition(IntPtr _this, GetItemAtPosition__Args args);
                private static _GetItemAtPosition _GetItemAtPositionFunc;
                internal static _GetItemAtPosition GetItemAtPosition() {
                    if (_GetItemAtPositionFunc == null) {
                        _GetItemAtPositionFunc =
                            (_GetItemAtPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getItemAtPosition"), typeof(_GetItemAtPosition));
                    }
                    
                    return _GetItemAtPositionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClearFilterText__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ClearFilterText(IntPtr _this);
                internal delegate void _ClearFilterText(IntPtr _this, ClearFilterText__Args args);
                private static _ClearFilterText _ClearFilterTextFunc;
                internal static _ClearFilterText ClearFilterText() {
                    if (_ClearFilterTextFunc == null) {
                        _ClearFilterTextFunc =
                            (_ClearFilterText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_clearFilterText"), typeof(_ClearFilterText));
                    }
                    
                    return _ClearFilterTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFilterText__Args
                {
				   
				   internal string pattern;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetFilterText(IntPtr _this, string pattern);
                internal delegate void _SetFilterText(IntPtr _this, SetFilterText__Args args);
                private static _SetFilterText _SetFilterTextFunc;
                internal static _SetFilterText SetFilterText() {
                    if (_SetFilterTextFunc == null) {
                        _SetFilterTextFunc =
                            (_SetFilterText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_setFilterText"), typeof(_SetFilterText));
                    }
                    
                    return _SetFilterTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFilterText__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetFilterText(IntPtr _this);
                internal delegate IntPtr _GetFilterText(IntPtr _this, GetFilterText__Args args);
                private static _GetFilterText _GetFilterTextFunc;
                internal static _GetFilterText GetFilterText() {
                    if (_GetFilterTextFunc == null) {
                        _GetFilterTextFunc =
                            (_GetFilterText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getFilterText"), typeof(_GetFilterText));
                    }
                    
                    return _GetFilterTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsItemSelected__Args
                {
				   
				   internal int id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsItemSelected(IntPtr _this, int id);
                internal delegate bool _IsItemSelected(IntPtr _this, IsItemSelected__Args args);
                private static _IsItemSelected _IsItemSelectedFunc;
                internal static _IsItemSelected IsItemSelected() {
                    if (_IsItemSelectedFunc == null) {
                        _IsItemSelectedFunc =
                            (_IsItemSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_isItemSelected"), typeof(_IsItemSelected));
                    }
                    
                    return _IsItemSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetDebug__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetDebug(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool value);
                internal delegate void _SetDebug(IntPtr _this, SetDebug__Args args);
                private static _SetDebug _SetDebugFunc;
                internal static _SetDebug SetDebug() {
                    if (_SetDebugFunc == null) {
                        _SetDebugFunc =
                            (_SetDebug)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_setDebug"), typeof(_SetDebug));
                    }
                    
                    return _SetDebugFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ShowItemRenameCtrl__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ShowItemRenameCtrl(IntPtr _this, int itemId);
                internal delegate void _ShowItemRenameCtrl(IntPtr _this, ShowItemRenameCtrl__Args args);
                private static _ShowItemRenameCtrl _ShowItemRenameCtrlFunc;
                internal static _ShowItemRenameCtrl ShowItemRenameCtrl() {
                    if (_ShowItemRenameCtrlFunc == null) {
                        _ShowItemRenameCtrlFunc =
                            (_ShowItemRenameCtrl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_showItemRenameCtrl"), typeof(_ShowItemRenameCtrl));
                    }
                    
                    return _ShowItemRenameCtrlFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRenameValidate__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRenameValidate(IntPtr _this);
                internal delegate void _OnRenameValidate(IntPtr _this, OnRenameValidate__Args args);
                private static _OnRenameValidate _OnRenameValidateFunc;
                internal static _OnRenameValidate OnRenameValidate() {
                    if (_OnRenameValidateFunc == null) {
                        _OnRenameValidateFunc =
                            (_OnRenameValidate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_onRenameValidate"), typeof(_OnRenameValidate));
                    }
                    
                    return _OnRenameValidateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CancelRename__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CancelRename(IntPtr _this);
                internal delegate void _CancelRename(IntPtr _this, CancelRename__Args args);
                private static _CancelRename _CancelRenameFunc;
                internal static _CancelRename CancelRename() {
                    if (_CancelRenameFunc == null) {
                        _CancelRenameFunc =
                            (_CancelRename)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_cancelRename"), typeof(_CancelRename));
                    }
                    
                    return _CancelRenameFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Sort__Args
                {
				   
				   internal int parentId;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool traverseHierarchy;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool parentsFirst;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool caseSensitive;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Sort(IntPtr _this, int parentId, [MarshalAs(UnmanagedType.I1)]bool traverseHierarchy, [MarshalAs(UnmanagedType.I1)]bool parentsFirst, [MarshalAs(UnmanagedType.I1)]bool caseSensitive);
                internal delegate void _Sort(IntPtr _this, Sort__Args args);
                private static _Sort _SortFunc;
                internal static _Sort Sort() {
                    if (_SortFunc == null) {
                        _SortFunc =
                            (_Sort)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_sort"), typeof(_Sort));
                    }
                    
                    return _SortFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ScrollVisibleByObjectId__Args
                {
				   
				   internal int objectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _ScrollVisibleByObjectId(IntPtr _this, int objectId);
                internal delegate int _ScrollVisibleByObjectId(IntPtr _this, ScrollVisibleByObjectId__Args args);
                private static _ScrollVisibleByObjectId _ScrollVisibleByObjectIdFunc;
                internal static _ScrollVisibleByObjectId ScrollVisibleByObjectId() {
                    if (_ScrollVisibleByObjectIdFunc == null) {
                        _ScrollVisibleByObjectIdFunc =
                            (_ScrollVisibleByObjectId)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_scrollVisibleByObjectId"), typeof(_ScrollVisibleByObjectId));
                    }
                    
                    return _ScrollVisibleByObjectIdFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemObject__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetItemObject(IntPtr _this, int itemId);
                internal delegate int _GetItemObject(IntPtr _this, GetItemObject__Args args);
                private static _GetItemObject _GetItemObjectFunc;
                internal static _GetItemObject GetItemObject() {
                    if (_GetItemObjectFunc == null) {
                        _GetItemObjectFunc =
                            (_GetItemObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getItemObject"), typeof(_GetItemObject));
                    }
                    
                    return _GetItemObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindItemByObjectId__Args
                {
				   
				   internal int objectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindItemByObjectId(IntPtr _this, int objectId);
                internal delegate int _FindItemByObjectId(IntPtr _this, FindItemByObjectId__Args args);
                private static _FindItemByObjectId _FindItemByObjectIdFunc;
                internal static _FindItemByObjectId FindItemByObjectId() {
                    if (_FindItemByObjectIdFunc == null) {
                        _FindItemByObjectIdFunc =
                            (_FindItemByObjectId)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_findItemByObjectId"), typeof(_FindItemByObjectId));
                    }
                    
                    return _FindItemByObjectIdFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedItemList__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSelectedItemList(IntPtr _this);
                internal delegate IntPtr _GetSelectedItemList(IntPtr _this, GetSelectedItemList__Args args);
                private static _GetSelectedItemList _GetSelectedItemListFunc;
                internal static _GetSelectedItemList GetSelectedItemList() {
                    if (_GetSelectedItemListFunc == null) {
                        _GetSelectedItemListFunc =
                            (_GetSelectedItemList)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getSelectedItemList"), typeof(_GetSelectedItemList));
                    }
                    
                    return _GetSelectedItemListFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTextToRoot__Args
                {
				   
				   internal int itemId;
				   
				   internal string delimiter;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetTextToRoot(IntPtr _this, int itemId, string delimiter);
                internal delegate IntPtr _GetTextToRoot(IntPtr _this, GetTextToRoot__Args args);
                private static _GetTextToRoot _GetTextToRootFunc;
                internal static _GetTextToRoot GetTextToRoot() {
                    if (_GetTextToRootFunc == null) {
                        _GetTextToRootFunc =
                            (_GetTextToRoot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getTextToRoot"), typeof(_GetTextToRoot));
                    }
                    
                    return _GetTextToRootFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MoveItemDown__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _MoveItemDown(IntPtr _this, int itemId);
                internal delegate void _MoveItemDown(IntPtr _this, MoveItemDown__Args args);
                private static _MoveItemDown _MoveItemDownFunc;
                internal static _MoveItemDown MoveItemDown() {
                    if (_MoveItemDownFunc == null) {
                        _MoveItemDownFunc =
                            (_MoveItemDown)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_moveItemDown"), typeof(_MoveItemDown));
                    }
                    
                    return _MoveItemDownFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedItemsCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelectedItemsCount(IntPtr _this);
                internal delegate int _GetSelectedItemsCount(IntPtr _this, GetSelectedItemsCount__Args args);
                private static _GetSelectedItemsCount _GetSelectedItemsCountFunc;
                internal static _GetSelectedItemsCount GetSelectedItemsCount() {
                    if (_GetSelectedItemsCountFunc == null) {
                        _GetSelectedItemsCountFunc =
                            (_GetSelectedItemsCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getSelectedItemsCount"), typeof(_GetSelectedItemsCount));
                    }
                    
                    return _GetSelectedItemsCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MoveItemUp__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _MoveItemUp(IntPtr _this, int itemId);
                internal delegate void _MoveItemUp(IntPtr _this, MoveItemUp__Args args);
                private static _MoveItemUp _MoveItemUpFunc;
                internal static _MoveItemUp MoveItemUp() {
                    if (_MoveItemUpFunc == null) {
                        _MoveItemUpFunc =
                            (_MoveItemUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_moveItemUp"), typeof(_MoveItemUp));
                    }
                    
                    return _MoveItemUpFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedObjectList__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetSelectedObjectList(IntPtr _this);
                internal delegate IntPtr _GetSelectedObjectList(IntPtr _this, GetSelectedObjectList__Args args);
                private static _GetSelectedObjectList _GetSelectedObjectListFunc;
                internal static _GetSelectedObjectList GetSelectedObjectList() {
                    if (_GetSelectedObjectListFunc == null) {
                        _GetSelectedObjectListFunc =
                            (_GetSelectedObjectList)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getSelectedObjectList"), typeof(_GetSelectedObjectList));
                    }
                    
                    return _GetSelectedObjectListFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedObject__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelectedObject(IntPtr _this, int index);
                internal delegate int _GetSelectedObject(IntPtr _this, GetSelectedObject__Args args);
                private static _GetSelectedObject _GetSelectedObjectFunc;
                internal static _GetSelectedObject GetSelectedObject() {
                    if (_GetSelectedObjectFunc == null) {
                        _GetSelectedObjectFunc =
                            (_GetSelectedObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getSelectedObject"), typeof(_GetSelectedObject));
                    }
                    
                    return _GetSelectedObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetSelectedItem__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetSelectedItem(IntPtr _this, int index);
                internal delegate int _GetSelectedItem(IntPtr _this, GetSelectedItem__Args args);
                private static _GetSelectedItem _GetSelectedItemFunc;
                internal static _GetSelectedItem GetSelectedItem() {
                    if (_GetSelectedItemFunc == null) {
                        _GetSelectedItemFunc =
                            (_GetSelectedItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getSelectedItem"), typeof(_GetSelectedItem));
                    }
                    
                    return _GetSelectedItemFunc;
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
                                    "fnGuiTreeViewCtrl_getItemCount"), typeof(_GetItemCount));
                    }
                    
                    return _GetItemCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetPrevSibling__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetPrevSibling(IntPtr _this, int itemId);
                internal delegate int _GetPrevSibling(IntPtr _this, GetPrevSibling__Args args);
                private static _GetPrevSibling _GetPrevSiblingFunc;
                internal static _GetPrevSibling GetPrevSibling() {
                    if (_GetPrevSiblingFunc == null) {
                        _GetPrevSiblingFunc =
                            (_GetPrevSibling)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getPrevSibling"), typeof(_GetPrevSibling));
                    }
                    
                    return _GetPrevSiblingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetNextSibling__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetNextSibling(IntPtr _this, int itemId);
                internal delegate int _GetNextSibling(IntPtr _this, GetNextSibling__Args args);
                private static _GetNextSibling _GetNextSiblingFunc;
                internal static _GetNextSibling GetNextSibling() {
                    if (_GetNextSiblingFunc == null) {
                        _GetNextSiblingFunc =
                            (_GetNextSibling)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getNextSibling"), typeof(_GetNextSibling));
                    }
                    
                    return _GetNextSiblingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetParentItem__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetParentItem(IntPtr _this, int itemId);
                internal delegate int _GetParentItem(IntPtr _this, GetParentItem__Args args);
                private static _GetParentItem _GetParentItemFunc;
                internal static _GetParentItem GetParentItem() {
                    if (_GetParentItemFunc == null) {
                        _GetParentItemFunc =
                            (_GetParentItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getParentItem"), typeof(_GetParentItem));
                    }
                    
                    return _GetParentItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct BuildVisibleTree__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool forceFullUpdate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _BuildVisibleTree(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool forceFullUpdate);
                internal delegate void _BuildVisibleTree(IntPtr _this, BuildVisibleTree__Args args);
                private static _BuildVisibleTree _BuildVisibleTreeFunc;
                internal static _BuildVisibleTree BuildVisibleTree() {
                    if (_BuildVisibleTreeFunc == null) {
                        _BuildVisibleTreeFunc =
                            (_BuildVisibleTree)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_buildVisibleTree"), typeof(_BuildVisibleTree));
                    }
                    
                    return _BuildVisibleTreeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetChild__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetChild(IntPtr _this, int itemId);
                internal delegate int _GetChild(IntPtr _this, GetChild__Args args);
                private static _GetChild _GetChildFunc;
                internal static _GetChild GetChild() {
                    if (_GetChildFunc == null) {
                        _GetChildFunc =
                            (_GetChild)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getChild"), typeof(_GetChild));
                    }
                    
                    return _GetChildFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFirstRootItem__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetFirstRootItem(IntPtr _this);
                internal delegate int _GetFirstRootItem(IntPtr _this, GetFirstRootItem__Args args);
                private static _GetFirstRootItem _GetFirstRootItemFunc;
                internal static _GetFirstRootItem GetFirstRootItem() {
                    if (_GetFirstRootItemFunc == null) {
                        _GetFirstRootItemFunc =
                            (_GetFirstRootItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getFirstRootItem"), typeof(_GetFirstRootItem));
                    }
                    
                    return _GetFirstRootItemFunc;
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
                                    "fnGuiTreeViewCtrl_clear"), typeof(_Clear));
                    }
                    
                    return _ClearFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveAllChildren__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveAllChildren(IntPtr _this, int itemId);
                internal delegate void _RemoveAllChildren(IntPtr _this, RemoveAllChildren__Args args);
                private static _RemoveAllChildren _RemoveAllChildrenFunc;
                internal static _RemoveAllChildren RemoveAllChildren() {
                    if (_RemoveAllChildrenFunc == null) {
                        _RemoveAllChildrenFunc =
                            (_RemoveAllChildren)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_removeAllChildren"), typeof(_RemoveAllChildren));
                    }
                    
                    return _RemoveAllChildrenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveItem__Args
                {
				   
				   internal int itemId;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool deleteObjects;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _RemoveItem(IntPtr _this, int itemId, [MarshalAs(UnmanagedType.I1)]bool deleteObjects);
                internal delegate bool _RemoveItem(IntPtr _this, RemoveItem__Args args);
                private static _RemoveItem _RemoveItemFunc;
                internal static _RemoveItem RemoveItem() {
                    if (_RemoveItemFunc == null) {
                        _RemoveItemFunc =
                            (_RemoveItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_removeItem"), typeof(_RemoveItem));
                    }
                    
                    return _RemoveItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct EditItem__Args
                {
				   
				   internal int itemId;
				   
				   internal string newText;
				   
				   internal string newValue;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _EditItem(IntPtr _this, int itemId, string newText, string newValue);
                internal delegate bool _EditItem(IntPtr _this, EditItem__Args args);
                private static _EditItem _EditItemFunc;
                internal static _EditItem EditItem() {
                    if (_EditItemFunc == null) {
                        _EditItemFunc =
                            (_EditItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_editItem"), typeof(_EditItem));
                    }
                    
                    return _EditItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemValue__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetItemValue(IntPtr _this, int itemId);
                internal delegate IntPtr _GetItemValue(IntPtr _this, GetItemValue__Args args);
                private static _GetItemValue _GetItemValueFunc;
                internal static _GetItemValue GetItemValue() {
                    if (_GetItemValueFunc == null) {
                        _GetItemValueFunc =
                            (_GetItemValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getItemValue"), typeof(_GetItemValue));
                    }
                    
                    return _GetItemValueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetItemText__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetItemText(IntPtr _this, int itemId);
                internal delegate IntPtr _GetItemText(IntPtr _this, GetItemText__Args args);
                private static _GetItemText _GetItemTextFunc;
                internal static _GetItemText GetItemText() {
                    if (_GetItemTextFunc == null) {
                        _GetItemTextFunc =
                            (_GetItemText)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_getItemText"), typeof(_GetItemText));
                    }
                    
                    return _GetItemTextFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsParentItem__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsParentItem(IntPtr _this, int itemId);
                internal delegate bool _IsParentItem(IntPtr _this, IsParentItem__Args args);
                private static _IsParentItem _IsParentItemFunc;
                internal static _IsParentItem IsParentItem() {
                    if (_IsParentItemFunc == null) {
                        _IsParentItemFunc =
                            (_IsParentItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_isParentItem"), typeof(_IsParentItem));
                    }
                    
                    return _IsParentItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetItemImages__Args
                {
				   
				   internal int itemId;
				   
				   internal sbyte normalImage;
				   
				   internal sbyte expandedImage;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetItemImages(IntPtr _this, int itemId, sbyte normalImage, sbyte expandedImage);
                internal delegate void _SetItemImages(IntPtr _this, SetItemImages__Args args);
                private static _SetItemImages _SetItemImagesFunc;
                internal static _SetItemImages SetItemImages() {
                    if (_SetItemImagesFunc == null) {
                        _SetItemImagesFunc =
                            (_SetItemImages)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_setItemImages"), typeof(_SetItemImages));
                    }
                    
                    return _SetItemImagesFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetItemTooltip__Args
                {
				   
				   internal int itemId;
				   
				   internal string tooltip;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetItemTooltip(IntPtr _this, int itemId, string tooltip);
                internal delegate bool _SetItemTooltip(IntPtr _this, SetItemTooltip__Args args);
                private static _SetItemTooltip _SetItemTooltipFunc;
                internal static _SetItemTooltip SetItemTooltip() {
                    if (_SetItemTooltipFunc == null) {
                        _SetItemTooltipFunc =
                            (_SetItemTooltip)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_setItemTooltip"), typeof(_SetItemTooltip));
                    }
                    
                    return _SetItemTooltipFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Open__Args
                {
				   
				   internal string objName;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool okToEdit;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Open(IntPtr _this, string objName, [MarshalAs(UnmanagedType.I1)]bool okToEdit);
                internal delegate void _Open(IntPtr _this, Open__Args args);
                private static _Open _OpenFunc;
                internal static _Open Open() {
                    if (_OpenFunc == null) {
                        _OpenFunc =
                            (_Open)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_open"), typeof(_Open));
                    }
                    
                    return _OpenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct BuildIconTable__Args
                {
				   
				   internal string icons;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _BuildIconTable(IntPtr _this, string icons);
                internal delegate bool _BuildIconTable(IntPtr _this, BuildIconTable__Args args);
                private static _BuildIconTable _BuildIconTableFunc;
                internal static _BuildIconTable BuildIconTable() {
                    if (_BuildIconTableFunc == null) {
                        _BuildIconTableFunc =
                            (_BuildIconTable)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_buildIconTable"), typeof(_BuildIconTable));
                    }
                    
                    return _BuildIconTableFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ScrollVisible__Args
                {
				   
				   internal int itemID;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ScrollVisible(IntPtr _this, int itemID);
                internal delegate bool _ScrollVisible(IntPtr _this, ScrollVisible__Args args);
                private static _ScrollVisible _ScrollVisibleFunc;
                internal static _ScrollVisible ScrollVisible() {
                    if (_ScrollVisibleFunc == null) {
                        _ScrollVisibleFunc =
                            (_ScrollVisible)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_scrollVisible"), typeof(_ScrollVisible));
                    }
                    
                    return _ScrollVisibleFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MarkItem__Args
                {
				   
				   internal int itemID;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool mark;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _MarkItem(IntPtr _this, int itemID, [MarshalAs(UnmanagedType.I1)]bool mark);
                internal delegate bool _MarkItem(IntPtr _this, MarkItem__Args args);
                private static _MarkItem _MarkItemFunc;
                internal static _MarkItem MarkItem() {
                    if (_MarkItemFunc == null) {
                        _MarkItemFunc =
                            (_MarkItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_markItem"), typeof(_MarkItem));
                    }
                    
                    return _MarkItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ExpandItem__Args
                {
				   
				   internal int itemID;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool expand;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _ExpandItem(IntPtr _this, int itemID, [MarshalAs(UnmanagedType.I1)]bool expand);
                internal delegate bool _ExpandItem(IntPtr _this, ExpandItem__Args args);
                private static _ExpandItem _ExpandItemFunc;
                internal static _ExpandItem ExpandItem() {
                    if (_ExpandItemFunc == null) {
                        _ExpandItemFunc =
                            (_ExpandItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_expandItem"), typeof(_ExpandItem));
                    }
                    
                    return _ExpandItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SelectItem__Args
                {
				   
				   internal int itemID;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool select;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SelectItem(IntPtr _this, int itemID, [MarshalAs(UnmanagedType.I1)]bool select);
                internal delegate bool _SelectItem(IntPtr _this, SelectItem__Args args);
                private static _SelectItem _SelectItemFunc;
                internal static _SelectItem SelectItem() {
                    if (_SelectItemFunc == null) {
                        _SelectItemFunc =
                            (_SelectItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_selectItem"), typeof(_SelectItem));
                    }
                    
                    return _SelectItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveChildSelectionByValue__Args
                {
				   
				   internal int parentId;
				   
				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveChildSelectionByValue(IntPtr _this, int parentId, string value);
                internal delegate void _RemoveChildSelectionByValue(IntPtr _this, RemoveChildSelectionByValue__Args args);
                private static _RemoveChildSelectionByValue _RemoveChildSelectionByValueFunc;
                internal static _RemoveChildSelectionByValue RemoveChildSelectionByValue() {
                    if (_RemoveChildSelectionByValueFunc == null) {
                        _RemoveChildSelectionByValueFunc =
                            (_RemoveChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_removeChildSelectionByValue"), typeof(_RemoveChildSelectionByValue));
                    }
                    
                    return _RemoveChildSelectionByValueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveSelection__Args
                {
				   
				   internal int itemId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveSelection(IntPtr _this, int itemId);
                internal delegate void _RemoveSelection(IntPtr _this, RemoveSelection__Args args);
                private static _RemoveSelection _RemoveSelectionFunc;
                internal static _RemoveSelection RemoveSelection() {
                    if (_RemoveSelectionFunc == null) {
                        _RemoveSelectionFunc =
                            (_RemoveSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_removeSelection"), typeof(_RemoveSelection));
                    }
                    
                    return _RemoveSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddChildSelectionByValue__Args
                {
				   
				   internal int parentId;
				   
				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddChildSelectionByValue(IntPtr _this, int parentId, string value);
                internal delegate void _AddChildSelectionByValue(IntPtr _this, AddChildSelectionByValue__Args args);
                private static _AddChildSelectionByValue _AddChildSelectionByValueFunc;
                internal static _AddChildSelectionByValue AddChildSelectionByValue() {
                    if (_AddChildSelectionByValueFunc == null) {
                        _AddChildSelectionByValueFunc =
                            (_AddChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_addChildSelectionByValue"), typeof(_AddChildSelectionByValue));
                    }
                    
                    return _AddChildSelectionByValueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddSelection__Args
                {
				   
				   internal int id;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isLastSelection;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddSelection(IntPtr _this, int id, [MarshalAs(UnmanagedType.I1)]bool isLastSelection);
                internal delegate void _AddSelection(IntPtr _this, AddSelection__Args args);
                private static _AddSelection _AddSelectionFunc;
                internal static _AddSelection AddSelection() {
                    if (_AddSelectionFunc == null) {
                        _AddSelectionFunc =
                            (_AddSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_addSelection"), typeof(_AddSelection));
                    }
                    
                    return _AddSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _DeleteSelection(IntPtr _this);
                internal delegate void _DeleteSelection(IntPtr _this, DeleteSelection__Args args);
                private static _DeleteSelection _DeleteSelectionFunc;
                internal static _DeleteSelection DeleteSelection() {
                    if (_DeleteSelectionFunc == null) {
                        _DeleteSelectionFunc =
                            (_DeleteSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_deleteSelection"), typeof(_DeleteSelection));
                    }
                    
                    return _DeleteSelectionFunc;
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
                                    "fnGuiTreeViewCtrl_clearSelection"), typeof(_ClearSelection));
                    }
                    
                    return _ClearSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ToggleHideSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ToggleHideSelection(IntPtr _this);
                internal delegate void _ToggleHideSelection(IntPtr _this, ToggleHideSelection__Args args);
                private static _ToggleHideSelection _ToggleHideSelectionFunc;
                internal static _ToggleHideSelection ToggleHideSelection() {
                    if (_ToggleHideSelectionFunc == null) {
                        _ToggleHideSelectionFunc =
                            (_ToggleHideSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_toggleHideSelection"), typeof(_ToggleHideSelection));
                    }
                    
                    return _ToggleHideSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ToggleLockSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ToggleLockSelection(IntPtr _this);
                internal delegate void _ToggleLockSelection(IntPtr _this, ToggleLockSelection__Args args);
                private static _ToggleLockSelection _ToggleLockSelectionFunc;
                internal static _ToggleLockSelection ToggleLockSelection() {
                    if (_ToggleLockSelectionFunc == null) {
                        _ToggleLockSelectionFunc =
                            (_ToggleLockSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_toggleLockSelection"), typeof(_ToggleLockSelection));
                    }
                    
                    return _ToggleLockSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct HideSelection__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _HideSelection(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _HideSelection(IntPtr _this, HideSelection__Args args);
                private static _HideSelection _HideSelectionFunc;
                internal static _HideSelection HideSelection() {
                    if (_HideSelectionFunc == null) {
                        _HideSelectionFunc =
                            (_HideSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_hideSelection"), typeof(_HideSelection));
                    }
                    
                    return _HideSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct LockSelection__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool _lock;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _LockSelection(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool _lock);
                internal delegate void _LockSelection(IntPtr _this, LockSelection__Args args);
                private static _LockSelection _LockSelectionFunc;
                internal static _LockSelection LockSelection() {
                    if (_LockSelectionFunc == null) {
                        _LockSelectionFunc =
                            (_LockSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_lockSelection"), typeof(_LockSelection));
                    }
                    
                    return _LockSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InsertObject__Args
                {
				   
				   internal int parentId;
				   
				   internal IntPtr obj;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool OKToEdit;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _InsertObject(IntPtr _this, int parentId, IntPtr obj, [MarshalAs(UnmanagedType.I1)]bool OKToEdit);
                internal delegate int _InsertObject(IntPtr _this, InsertObject__Args args);
                private static _InsertObject _InsertObjectFunc;
                internal static _InsertObject InsertObject() {
                    if (_InsertObjectFunc == null) {
                        _InsertObjectFunc =
                            (_InsertObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_insertObject"), typeof(_InsertObject));
                    }
                    
                    return _InsertObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct InsertItem__Args
                {
				   
				   internal int parentId;
				   
				   internal string text;
				   
				   internal string value;
				   
				   internal string icon;
				   
				   internal int normalImage;
				   
				   internal int expandedImage;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _InsertItem(IntPtr _this, int parentId, string text, string value, string icon, int normalImage, int expandedImage);
                internal delegate int _InsertItem(IntPtr _this, InsertItem__Args args);
                private static _InsertItem _InsertItemFunc;
                internal static _InsertItem InsertItem() {
                    if (_InsertItemFunc == null) {
                        _InsertItemFunc =
                            (_InsertItem)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_insertItem"), typeof(_InsertItem));
                    }
                    
                    return _InsertItemFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindChildItemByName__Args
                {
				   
				   internal int parentId;
				   
				   internal string childName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindChildItemByName(IntPtr _this, int parentId, string childName);
                internal delegate int _FindChildItemByName(IntPtr _this, FindChildItemByName__Args args);
                private static _FindChildItemByName _FindChildItemByNameFunc;
                internal static _FindChildItemByName FindChildItemByName() {
                    if (_FindChildItemByNameFunc == null) {
                        _FindChildItemByNameFunc =
                            (_FindChildItemByName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_findChildItemByName"), typeof(_FindChildItemByName));
                    }
                    
                    return _FindChildItemByNameFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindItemByValue__Args
                {
				   
				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindItemByValue(IntPtr _this, string value);
                internal delegate int _FindItemByValue(IntPtr _this, FindItemByValue__Args args);
                private static _FindItemByValue _FindItemByValueFunc;
                internal static _FindItemByValue FindItemByValue() {
                    if (_FindItemByValueFunc == null) {
                        _FindItemByValueFunc =
                            (_FindItemByValue)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_findItemByValue"), typeof(_FindItemByValue));
                    }
                    
                    return _FindItemByValueFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindItemByName__Args
                {
				   
				   internal string text;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindItemByName(IntPtr _this, string text);
                internal delegate int _FindItemByName(IntPtr _this, FindItemByName__Args args);
                private static _FindItemByName _FindItemByNameFunc;
                internal static _FindItemByName FindItemByName() {
                    if (_FindItemByNameFunc == null) {
                        _FindItemByNameFunc =
                            (_FindItemByName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiTreeViewCtrl_findItemByName"), typeof(_FindItemByName));
                    }
                    
                    return _FindItemByNameFunc;
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
                                    "cbGuiTreeViewCtrl_onClearSelection"), typeof(_OnClearSelection));
                    }
                    
                    return _OnClearSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct HandleRenameObject__Args
                {
				   
				   internal string newName;
				   
				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _HandleRenameObject(IntPtr _this, string newName, IntPtr _object);
                internal delegate bool _HandleRenameObject(IntPtr _this, HandleRenameObject__Args args);
                private static _HandleRenameObject _HandleRenameObjectFunc;
                internal static _HandleRenameObject HandleRenameObject() {
                    if (_HandleRenameObjectFunc == null) {
                        _HandleRenameObjectFunc =
                            (_HandleRenameObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_handleRenameObject"), typeof(_HandleRenameObject));
                    }
                    
                    return _HandleRenameObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CanRenameObject__Args
                {
				   
				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CanRenameObject(IntPtr _this, IntPtr _object);
                internal delegate bool _CanRenameObject(IntPtr _this, CanRenameObject__Args args);
                private static _CanRenameObject _CanRenameObjectFunc;
                internal static _CanRenameObject CanRenameObject() {
                    if (_CanRenameObjectFunc == null) {
                        _CanRenameObjectFunc =
                            (_CanRenameObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_canRenameObject"), typeof(_CanRenameObject));
                    }
                    
                    return _CanRenameObjectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAddMultipleSelectionEnd__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAddMultipleSelectionEnd(IntPtr _this);
                internal delegate void _OnAddMultipleSelectionEnd(IntPtr _this, OnAddMultipleSelectionEnd__Args args);
                private static _OnAddMultipleSelectionEnd _OnAddMultipleSelectionEndFunc;
                internal static _OnAddMultipleSelectionEnd OnAddMultipleSelectionEnd() {
                    if (_OnAddMultipleSelectionEndFunc == null) {
                        _OnAddMultipleSelectionEndFunc =
                            (_OnAddMultipleSelectionEnd)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onAddMultipleSelectionEnd"), typeof(_OnAddMultipleSelectionEnd));
                    }
                    
                    return _OnAddMultipleSelectionEndFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAddMultipleSelectionBegin__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAddMultipleSelectionBegin(IntPtr _this);
                internal delegate void _OnAddMultipleSelectionBegin(IntPtr _this, OnAddMultipleSelectionBegin__Args args);
                private static _OnAddMultipleSelectionBegin _OnAddMultipleSelectionBeginFunc;
                internal static _OnAddMultipleSelectionBegin OnAddMultipleSelectionBegin() {
                    if (_OnAddMultipleSelectionBeginFunc == null) {
                        _OnAddMultipleSelectionBeginFunc =
                            (_OnAddMultipleSelectionBegin)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onAddMultipleSelectionBegin"), typeof(_OnAddMultipleSelectionBegin));
                    }
                    
                    return _OnAddMultipleSelectionBeginFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDragDropped__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnDragDropped(IntPtr _this);
                internal delegate void _OnDragDropped(IntPtr _this, OnDragDropped__Args args);
                private static _OnDragDropped _OnDragDroppedFunc;
                internal static _OnDragDropped OnDragDropped() {
                    if (_OnDragDroppedFunc == null) {
                        _OnDragDroppedFunc =
                            (_OnDragDropped)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onDragDropped"), typeof(_OnDragDropped));
                    }
                    
                    return _OnDragDroppedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnReparent__Args
                {
				   
				   internal int itemOrObjectId;
				   
				   internal int oldParentItemOrObjectId;
				   
				   internal int newParentItemOrObjectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnReparent(IntPtr _this, int itemOrObjectId, int oldParentItemOrObjectId, int newParentItemOrObjectId);
                internal delegate void _OnReparent(IntPtr _this, OnReparent__Args args);
                private static _OnReparent _OnReparentFunc;
                internal static _OnReparent OnReparent() {
                    if (_OnReparentFunc == null) {
                        _OnReparentFunc =
                            (_OnReparent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onReparent"), typeof(_OnReparent));
                    }
                    
                    return _OnReparentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnEndReparenting__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnEndReparenting(IntPtr _this);
                internal delegate void _OnEndReparenting(IntPtr _this, OnEndReparenting__Args args);
                private static _OnEndReparenting _OnEndReparentingFunc;
                internal static _OnEndReparenting OnEndReparenting() {
                    if (_OnEndReparentingFunc == null) {
                        _OnEndReparentingFunc =
                            (_OnEndReparenting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onEndReparenting"), typeof(_OnEndReparenting));
                    }
                    
                    return _OnEndReparentingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnBeginReparenting__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnBeginReparenting(IntPtr _this);
                internal delegate void _OnBeginReparenting(IntPtr _this, OnBeginReparenting__Args args);
                private static _OnBeginReparenting _OnBeginReparentingFunc;
                internal static _OnBeginReparenting OnBeginReparenting() {
                    if (_OnBeginReparentingFunc == null) {
                        _OnBeginReparentingFunc =
                            (_OnBeginReparenting)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onBeginReparenting"), typeof(_OnBeginReparenting));
                    }
                    
                    return _OnBeginReparentingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRightMouseUp__Args
                {
				   
				   internal int itemId;
				   
				   internal IntPtr mousePos;
				   
				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRightMouseUp(IntPtr _this, int itemId, IntPtr mousePos, IntPtr _object);
                internal delegate void _OnRightMouseUp(IntPtr _this, OnRightMouseUp__Args args);
                private static _OnRightMouseUp _OnRightMouseUpFunc;
                internal static _OnRightMouseUp OnRightMouseUp() {
                    if (_OnRightMouseUpFunc == null) {
                        _OnRightMouseUpFunc =
                            (_OnRightMouseUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onRightMouseUp"), typeof(_OnRightMouseUp));
                    }
                    
                    return _OnRightMouseUpFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRightMouseDown__Args
                {
				   
				   internal int itemId;
				   
				   internal IntPtr mousePos;
				   
				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRightMouseDown(IntPtr _this, int itemId, IntPtr mousePos, IntPtr _object);
                internal delegate void _OnRightMouseDown(IntPtr _this, OnRightMouseDown__Args args);
                private static _OnRightMouseDown _OnRightMouseDownFunc;
                internal static _OnRightMouseDown OnRightMouseDown() {
                    if (_OnRightMouseDownFunc == null) {
                        _OnRightMouseDownFunc =
                            (_OnRightMouseDown)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onRightMouseDown"), typeof(_OnRightMouseDown));
                    }
                    
                    return _OnRightMouseDownFunc;
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
                                    "cbGuiTreeViewCtrl_onMouseDragged"), typeof(_OnMouseDragged));
                    }
                    
                    return _OnMouseDraggedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnMouseUp__Args
                {
				   
				   internal int hitItemId;
				   
				   internal int mouseClickCount;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnMouseUp(IntPtr _this, int hitItemId, int mouseClickCount);
                internal delegate void _OnMouseUp(IntPtr _this, OnMouseUp__Args args);
                private static _OnMouseUp _OnMouseUpFunc;
                internal static _OnMouseUp OnMouseUp() {
                    if (_OnMouseUpFunc == null) {
                        _OnMouseUpFunc =
                            (_OnMouseUp)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onMouseUp"), typeof(_OnMouseUp));
                    }
                    
                    return _OnMouseUpFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnKeyDown__Args
                {
				   
				   internal int modifier;
				   
				   internal int keyCode;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnKeyDown(IntPtr _this, int modifier, int keyCode);
                internal delegate void _OnKeyDown(IntPtr _this, OnKeyDown__Args args);
                private static _OnKeyDown _OnKeyDownFunc;
                internal static _OnKeyDown OnKeyDown() {
                    if (_OnKeyDownFunc == null) {
                        _OnKeyDownFunc =
                            (_OnKeyDown)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onKeyDown"), typeof(_OnKeyDown));
                    }
                    
                    return _OnKeyDownFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnObjectDeleteCompleted__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnObjectDeleteCompleted(IntPtr _this);
                internal delegate void _OnObjectDeleteCompleted(IntPtr _this, OnObjectDeleteCompleted__Args args);
                private static _OnObjectDeleteCompleted _OnObjectDeleteCompletedFunc;
                internal static _OnObjectDeleteCompleted OnObjectDeleteCompleted() {
                    if (_OnObjectDeleteCompletedFunc == null) {
                        _OnObjectDeleteCompletedFunc =
                            (_OnObjectDeleteCompleted)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onObjectDeleteCompleted"), typeof(_OnObjectDeleteCompleted));
                    }
                    
                    return _OnObjectDeleteCompletedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDeleteSelection__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnDeleteSelection(IntPtr _this);
                internal delegate void _OnDeleteSelection(IntPtr _this, OnDeleteSelection__Args args);
                private static _OnDeleteSelection _OnDeleteSelectionFunc;
                internal static _OnDeleteSelection OnDeleteSelection() {
                    if (_OnDeleteSelectionFunc == null) {
                        _OnDeleteSelectionFunc =
                            (_OnDeleteSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onDeleteSelection"), typeof(_OnDeleteSelection));
                    }
                    
                    return _OnDeleteSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnUnselect__Args
                {
				   
				   internal int itemOrObjectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnUnselect(IntPtr _this, int itemOrObjectId);
                internal delegate void _OnUnselect(IntPtr _this, OnUnselect__Args args);
                private static _OnUnselect _OnUnselectFunc;
                internal static _OnUnselect OnUnselect() {
                    if (_OnUnselectFunc == null) {
                        _OnUnselectFunc =
                            (_OnUnselect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onUnselect"), typeof(_OnUnselect));
                    }
                    
                    return _OnUnselectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnRemoveSelection__Args
                {
				   
				   internal int itemOrObjectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnRemoveSelection(IntPtr _this, int itemOrObjectId);
                internal delegate void _OnRemoveSelection(IntPtr _this, OnRemoveSelection__Args args);
                private static _OnRemoveSelection _OnRemoveSelectionFunc;
                internal static _OnRemoveSelection OnRemoveSelection() {
                    if (_OnRemoveSelectionFunc == null) {
                        _OnRemoveSelectionFunc =
                            (_OnRemoveSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onRemoveSelection"), typeof(_OnRemoveSelection));
                    }
                    
                    return _OnRemoveSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnInspect__Args
                {
				   
				   internal int itemOrObjectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnInspect(IntPtr _this, int itemOrObjectId);
                internal delegate void _OnInspect(IntPtr _this, OnInspect__Args args);
                private static _OnInspect _OnInspectFunc;
                internal static _OnInspect OnInspect() {
                    if (_OnInspectFunc == null) {
                        _OnInspectFunc =
                            (_OnInspect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onInspect"), typeof(_OnInspect));
                    }
                    
                    return _OnInspectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnSelect__Args
                {
				   
				   internal int itemOrObjectId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnSelect(IntPtr _this, int itemOrObjectId);
                internal delegate void _OnSelect(IntPtr _this, OnSelect__Args args);
                private static _OnSelect _OnSelectFunc;
                internal static _OnSelect OnSelect() {
                    if (_OnSelectFunc == null) {
                        _OnSelectFunc =
                            (_OnSelect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onSelect"), typeof(_OnSelect));
                    }
                    
                    return _OnSelectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAddSelection__Args
                {
				   
				   internal int itemOrObjectId;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isLastSelection;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAddSelection(IntPtr _this, int itemOrObjectId, [MarshalAs(UnmanagedType.I1)]bool isLastSelection);
                internal delegate void _OnAddSelection(IntPtr _this, OnAddSelection__Args args);
                private static _OnAddSelection _OnAddSelectionFunc;
                internal static _OnAddSelection OnAddSelection() {
                    if (_OnAddSelectionFunc == null) {
                        _OnAddSelectionFunc =
                            (_OnAddSelection)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onAddSelection"), typeof(_OnAddSelection));
                    }
                    
                    return _OnAddSelectionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnAddGroupSelected__Args
                {
				   
				   internal IntPtr group;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnAddGroupSelected(IntPtr _this, IntPtr group);
                internal delegate void _OnAddGroupSelected(IntPtr _this, OnAddGroupSelected__Args args);
                private static _OnAddGroupSelected _OnAddGroupSelectedFunc;
                internal static _OnAddGroupSelected OnAddGroupSelected() {
                    if (_OnAddGroupSelectedFunc == null) {
                        _OnAddGroupSelectedFunc =
                            (_OnAddGroupSelected)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onAddGroupSelected"), typeof(_OnAddGroupSelected));
                    }
                    
                    return _OnAddGroupSelectedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDefineIcons__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnDefineIcons(IntPtr _this);
                internal delegate void _OnDefineIcons(IntPtr _this, OnDefineIcons__Args args);
                private static _OnDefineIcons _OnDefineIconsFunc;
                internal static _OnDefineIcons OnDefineIcons() {
                    if (_OnDefineIconsFunc == null) {
                        _OnDefineIconsFunc =
                            (_OnDefineIcons)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onDefineIcons"), typeof(_OnDefineIcons));
                    }
                    
                    return _OnDefineIconsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsValidDragTarget__Args
                {
				   
				   internal int id;
				   
				   internal string value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsValidDragTarget(IntPtr _this, int id, string value);
                internal delegate bool _IsValidDragTarget(IntPtr _this, IsValidDragTarget__Args args);
                private static _IsValidDragTarget _IsValidDragTargetFunc;
                internal static _IsValidDragTarget IsValidDragTarget() {
                    if (_IsValidDragTargetFunc == null) {
                        _IsValidDragTargetFunc =
                            (_IsValidDragTarget)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_isValidDragTarget"), typeof(_IsValidDragTarget));
                    }
                    
                    return _IsValidDragTargetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDeleteObject__Args
                {
				   
				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OnDeleteObject(IntPtr _this, IntPtr _object);
                internal delegate bool _OnDeleteObject(IntPtr _this, OnDeleteObject__Args args);
                private static _OnDeleteObject _OnDeleteObjectFunc;
                internal static _OnDeleteObject OnDeleteObject() {
                    if (_OnDeleteObjectFunc == null) {
                        _OnDeleteObjectFunc =
                            (_OnDeleteObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiTreeViewCtrl_onDeleteObject"), typeof(_OnDeleteObject));
                    }
                    
                    return _OnDeleteObjectFunc;
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
                                    "fnGuiTreeViewCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiTreeViewCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public int GetItemAtPosition(Point2I position = null) {
        
                     position = position ?? new Point2I("0 0");position.Alloc();                     InternalUnsafeMethods.GetItemAtPosition__Args _args = new InternalUnsafeMethods.GetItemAtPosition__Args() {
                        position = position.internalStructPtr,
                     };
                     int _engineResult = InternalUnsafeMethods.GetItemAtPosition()(ObjectPtr, _args);
                                          position.Free();            
                     return _engineResult;
                  }
	

			
                  public void ClearFilterText() {
        
                     InternalUnsafeMethods.ClearFilterText__Args _args = new InternalUnsafeMethods.ClearFilterText__Args() {
                     };
                     InternalUnsafeMethods.ClearFilterText()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void SetFilterText(string pattern) {
        
                                          InternalUnsafeMethods.SetFilterText__Args _args = new InternalUnsafeMethods.SetFilterText__Args() {
                        pattern = pattern,
                     };
                     InternalUnsafeMethods.SetFilterText()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetFilterText() {
        
                     InternalUnsafeMethods.GetFilterText__Args _args = new InternalUnsafeMethods.GetFilterText__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetFilterText()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public bool IsItemSelected(int id) {
        
                                          InternalUnsafeMethods.IsItemSelected__Args _args = new InternalUnsafeMethods.IsItemSelected__Args() {
                        id = id,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsItemSelected()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetDebug(bool value = true) {
        
                                          InternalUnsafeMethods.SetDebug__Args _args = new InternalUnsafeMethods.SetDebug__Args() {
                        value = value,
                     };
                     InternalUnsafeMethods.SetDebug()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void ShowItemRenameCtrl(int itemId) {
        
                                          InternalUnsafeMethods.ShowItemRenameCtrl__Args _args = new InternalUnsafeMethods.ShowItemRenameCtrl__Args() {
                        itemId = itemId,
                     };
                     InternalUnsafeMethods.ShowItemRenameCtrl()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnRenameValidate() {
        
                     InternalUnsafeMethods.OnRenameValidate__Args _args = new InternalUnsafeMethods.OnRenameValidate__Args() {
                     };
                     InternalUnsafeMethods.OnRenameValidate()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void CancelRename() {
        
                     InternalUnsafeMethods.CancelRename__Args _args = new InternalUnsafeMethods.CancelRename__Args() {
                     };
                     InternalUnsafeMethods.CancelRename()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Sort(int parentId = 0, bool traverseHierarchy = false, bool parentsFirst = false, bool caseSensitive = true) {
        
                                                                                                         InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
                        parentId = parentId,
                        traverseHierarchy = traverseHierarchy,
                        parentsFirst = parentsFirst,
                        caseSensitive = caseSensitive,
                     };
                     InternalUnsafeMethods.Sort()(ObjectPtr, _args);
                                                                                                                     
                  }
	

			
                  public int ScrollVisibleByObjectId(int objectId) {
        
                                          InternalUnsafeMethods.ScrollVisibleByObjectId__Args _args = new InternalUnsafeMethods.ScrollVisibleByObjectId__Args() {
                        objectId = objectId,
                     };
                     int _engineResult = InternalUnsafeMethods.ScrollVisibleByObjectId()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetItemObject(int itemId) {
        
                                          InternalUnsafeMethods.GetItemObject__Args _args = new InternalUnsafeMethods.GetItemObject__Args() {
                        itemId = itemId,
                     };
                     int _engineResult = InternalUnsafeMethods.GetItemObject()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int FindItemByObjectId(int objectId) {
        
                                          InternalUnsafeMethods.FindItemByObjectId__Args _args = new InternalUnsafeMethods.FindItemByObjectId__Args() {
                        objectId = objectId,
                     };
                     int _engineResult = InternalUnsafeMethods.FindItemByObjectId()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public string GetSelectedItemList() {
        
                     InternalUnsafeMethods.GetSelectedItemList__Args _args = new InternalUnsafeMethods.GetSelectedItemList__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSelectedItemList()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public string GetTextToRoot(int itemId, string delimiter = "") {
        
                                                               InternalUnsafeMethods.GetTextToRoot__Args _args = new InternalUnsafeMethods.GetTextToRoot__Args() {
                        itemId = itemId,
                        delimiter = delimiter,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetTextToRoot()(ObjectPtr, _args);
                                                                           
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void MoveItemDown(int itemId) {
        
                                          InternalUnsafeMethods.MoveItemDown__Args _args = new InternalUnsafeMethods.MoveItemDown__Args() {
                        itemId = itemId,
                     };
                     InternalUnsafeMethods.MoveItemDown()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetSelectedItemsCount() {
        
                     InternalUnsafeMethods.GetSelectedItemsCount__Args _args = new InternalUnsafeMethods.GetSelectedItemsCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelectedItemsCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void MoveItemUp(int itemId) {
        
                                          InternalUnsafeMethods.MoveItemUp__Args _args = new InternalUnsafeMethods.MoveItemUp__Args() {
                        itemId = itemId,
                     };
                     InternalUnsafeMethods.MoveItemUp()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public string GetSelectedObjectList() {
        
                     InternalUnsafeMethods.GetSelectedObjectList__Args _args = new InternalUnsafeMethods.GetSelectedObjectList__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetSelectedObjectList()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetSelectedObject(int index = 0) {
        
                                          InternalUnsafeMethods.GetSelectedObject__Args _args = new InternalUnsafeMethods.GetSelectedObject__Args() {
                        index = index,
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelectedObject()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetSelectedItem(int index = 0) {
        
                                          InternalUnsafeMethods.GetSelectedItem__Args _args = new InternalUnsafeMethods.GetSelectedItem__Args() {
                        index = index,
                     };
                     int _engineResult = InternalUnsafeMethods.GetSelectedItem()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetItemCount() {
        
                     InternalUnsafeMethods.GetItemCount__Args _args = new InternalUnsafeMethods.GetItemCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetItemCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetPrevSibling(int itemId) {
        
                                          InternalUnsafeMethods.GetPrevSibling__Args _args = new InternalUnsafeMethods.GetPrevSibling__Args() {
                        itemId = itemId,
                     };
                     int _engineResult = InternalUnsafeMethods.GetPrevSibling()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetNextSibling(int itemId) {
        
                                          InternalUnsafeMethods.GetNextSibling__Args _args = new InternalUnsafeMethods.GetNextSibling__Args() {
                        itemId = itemId,
                     };
                     int _engineResult = InternalUnsafeMethods.GetNextSibling()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetParentItem(int itemId) {
        
                                          InternalUnsafeMethods.GetParentItem__Args _args = new InternalUnsafeMethods.GetParentItem__Args() {
                        itemId = itemId,
                     };
                     int _engineResult = InternalUnsafeMethods.GetParentItem()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void BuildVisibleTree(bool forceFullUpdate = false) {
        
                                          InternalUnsafeMethods.BuildVisibleTree__Args _args = new InternalUnsafeMethods.BuildVisibleTree__Args() {
                        forceFullUpdate = forceFullUpdate,
                     };
                     InternalUnsafeMethods.BuildVisibleTree()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetChild(int itemId) {
        
                                          InternalUnsafeMethods.GetChild__Args _args = new InternalUnsafeMethods.GetChild__Args() {
                        itemId = itemId,
                     };
                     int _engineResult = InternalUnsafeMethods.GetChild()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetFirstRootItem() {
        
                     InternalUnsafeMethods.GetFirstRootItem__Args _args = new InternalUnsafeMethods.GetFirstRootItem__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetFirstRootItem()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void Clear() {
        
                     InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
                     };
                     InternalUnsafeMethods.Clear()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void RemoveAllChildren(int itemId) {
        
                                          InternalUnsafeMethods.RemoveAllChildren__Args _args = new InternalUnsafeMethods.RemoveAllChildren__Args() {
                        itemId = itemId,
                     };
                     InternalUnsafeMethods.RemoveAllChildren()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool RemoveItem(int itemId = 0, bool deleteObjects = true) {
        
                                                               InternalUnsafeMethods.RemoveItem__Args _args = new InternalUnsafeMethods.RemoveItem__Args() {
                        itemId = itemId,
                        deleteObjects = deleteObjects,
                     };
                     bool _engineResult = InternalUnsafeMethods.RemoveItem()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool EditItem(int itemId, string newText, string newValue) {
        
                                                                                    InternalUnsafeMethods.EditItem__Args _args = new InternalUnsafeMethods.EditItem__Args() {
                        itemId = itemId,
                        newText = newText,
                        newValue = newValue,
                     };
                     bool _engineResult = InternalUnsafeMethods.EditItem()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public string GetItemValue(int itemId) {
        
                                          InternalUnsafeMethods.GetItemValue__Args _args = new InternalUnsafeMethods.GetItemValue__Args() {
                        itemId = itemId,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetItemValue()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public string GetItemText(int itemId) {
        
                                          InternalUnsafeMethods.GetItemText__Args _args = new InternalUnsafeMethods.GetItemText__Args() {
                        itemId = itemId,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetItemText()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public bool IsParentItem(int itemId) {
        
                                          InternalUnsafeMethods.IsParentItem__Args _args = new InternalUnsafeMethods.IsParentItem__Args() {
                        itemId = itemId,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsParentItem()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetItemImages(int itemId, sbyte normalImage, sbyte expandedImage) {
        
                                                                                    InternalUnsafeMethods.SetItemImages__Args _args = new InternalUnsafeMethods.SetItemImages__Args() {
                        itemId = itemId,
                        normalImage = normalImage,
                        expandedImage = expandedImage,
                     };
                     InternalUnsafeMethods.SetItemImages()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public bool SetItemTooltip(int itemId, string tooltip) {
        
                                                               InternalUnsafeMethods.SetItemTooltip__Args _args = new InternalUnsafeMethods.SetItemTooltip__Args() {
                        itemId = itemId,
                        tooltip = tooltip,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetItemTooltip()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public void Open(string objName, bool okToEdit = true) {
        
                                                               InternalUnsafeMethods.Open__Args _args = new InternalUnsafeMethods.Open__Args() {
                        objName = objName,
                        okToEdit = okToEdit,
                     };
                     InternalUnsafeMethods.Open()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public bool BuildIconTable(string icons) {
        
                                          InternalUnsafeMethods.BuildIconTable__Args _args = new InternalUnsafeMethods.BuildIconTable__Args() {
                        icons = icons,
                     };
                     bool _engineResult = InternalUnsafeMethods.BuildIconTable()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool ScrollVisible(int itemID) {
        
                                          InternalUnsafeMethods.ScrollVisible__Args _args = new InternalUnsafeMethods.ScrollVisible__Args() {
                        itemID = itemID,
                     };
                     bool _engineResult = InternalUnsafeMethods.ScrollVisible()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool MarkItem(int itemID, bool mark = true) {
        
                                                               InternalUnsafeMethods.MarkItem__Args _args = new InternalUnsafeMethods.MarkItem__Args() {
                        itemID = itemID,
                        mark = mark,
                     };
                     bool _engineResult = InternalUnsafeMethods.MarkItem()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool ExpandItem(int itemID, bool expand = true) {
        
                                                               InternalUnsafeMethods.ExpandItem__Args _args = new InternalUnsafeMethods.ExpandItem__Args() {
                        itemID = itemID,
                        expand = expand,
                     };
                     bool _engineResult = InternalUnsafeMethods.ExpandItem()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool SelectItem(int itemID, bool select = true) {
        
                                                               InternalUnsafeMethods.SelectItem__Args _args = new InternalUnsafeMethods.SelectItem__Args() {
                        itemID = itemID,
                        select = select,
                     };
                     bool _engineResult = InternalUnsafeMethods.SelectItem()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public void RemoveChildSelectionByValue(int parentId, string value) {
        
                                                               InternalUnsafeMethods.RemoveChildSelectionByValue__Args _args = new InternalUnsafeMethods.RemoveChildSelectionByValue__Args() {
                        parentId = parentId,
                        value = value,
                     };
                     InternalUnsafeMethods.RemoveChildSelectionByValue()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void RemoveSelection(int itemId) {
        
                                          InternalUnsafeMethods.RemoveSelection__Args _args = new InternalUnsafeMethods.RemoveSelection__Args() {
                        itemId = itemId,
                     };
                     InternalUnsafeMethods.RemoveSelection()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddChildSelectionByValue(int parentId, string value) {
        
                                                               InternalUnsafeMethods.AddChildSelectionByValue__Args _args = new InternalUnsafeMethods.AddChildSelectionByValue__Args() {
                        parentId = parentId,
                        value = value,
                     };
                     InternalUnsafeMethods.AddChildSelectionByValue()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void AddSelection(int id, bool isLastSelection = true) {
        
                                                               InternalUnsafeMethods.AddSelection__Args _args = new InternalUnsafeMethods.AddSelection__Args() {
                        id = id,
                        isLastSelection = isLastSelection,
                     };
                     InternalUnsafeMethods.AddSelection()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void DeleteSelection() {
        
                     InternalUnsafeMethods.DeleteSelection__Args _args = new InternalUnsafeMethods.DeleteSelection__Args() {
                     };
                     InternalUnsafeMethods.DeleteSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ClearSelection() {
        
                     InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
                     };
                     InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ToggleHideSelection() {
        
                     InternalUnsafeMethods.ToggleHideSelection__Args _args = new InternalUnsafeMethods.ToggleHideSelection__Args() {
                     };
                     InternalUnsafeMethods.ToggleHideSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ToggleLockSelection() {
        
                     InternalUnsafeMethods.ToggleLockSelection__Args _args = new InternalUnsafeMethods.ToggleLockSelection__Args() {
                     };
                     InternalUnsafeMethods.ToggleLockSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void HideSelection(bool state = true) {
        
                                          InternalUnsafeMethods.HideSelection__Args _args = new InternalUnsafeMethods.HideSelection__Args() {
                        state = state,
                     };
                     InternalUnsafeMethods.HideSelection()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void LockSelection(bool _lock = true) {
        
                                          InternalUnsafeMethods.LockSelection__Args _args = new InternalUnsafeMethods.LockSelection__Args() {
                        _lock = _lock,
                     };
                     InternalUnsafeMethods.LockSelection()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int InsertObject(int parentId, SimObject obj, bool OKToEdit = false) {
        
                                                                                    InternalUnsafeMethods.InsertObject__Args _args = new InternalUnsafeMethods.InsertObject__Args() {
                        parentId = parentId,
                        obj = obj.ObjectPtr,
                        OKToEdit = OKToEdit,
                     };
                     int _engineResult = InternalUnsafeMethods.InsertObject()(ObjectPtr, _args);
                                                                                                
                     return _engineResult;
                  }
	

			
                  public int InsertItem(int parentId, string text, string value = "", string icon = "", int normalImage = 0, int expandedImage = 0) {
        
                                                                                                                                                   InternalUnsafeMethods.InsertItem__Args _args = new InternalUnsafeMethods.InsertItem__Args() {
                        parentId = parentId,
                        text = text,
                        value = value,
                        icon = icon,
                        normalImage = normalImage,
                        expandedImage = expandedImage,
                     };
                     int _engineResult = InternalUnsafeMethods.InsertItem()(ObjectPtr, _args);
                                                                                                                                                               
                     return _engineResult;
                  }
	

			
                  public int FindChildItemByName(int parentId, string childName) {
        
                                                               InternalUnsafeMethods.FindChildItemByName__Args _args = new InternalUnsafeMethods.FindChildItemByName__Args() {
                        parentId = parentId,
                        childName = childName,
                     };
                     int _engineResult = InternalUnsafeMethods.FindChildItemByName()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public int FindItemByValue(string value) {
        
                                          InternalUnsafeMethods.FindItemByValue__Args _args = new InternalUnsafeMethods.FindItemByValue__Args() {
                        value = value,
                     };
                     int _engineResult = InternalUnsafeMethods.FindItemByValue()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int FindItemByName(string text) {
        
                                          InternalUnsafeMethods.FindItemByName__Args _args = new InternalUnsafeMethods.FindItemByName__Args() {
                        text = text,
                     };
                     int _engineResult = InternalUnsafeMethods.FindItemByName()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void OnClearSelection() {
        
                     InternalUnsafeMethods.OnClearSelection__Args _args = new InternalUnsafeMethods.OnClearSelection__Args() {
                     };
                     InternalUnsafeMethods.OnClearSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool HandleRenameObject(string newName, SimObject _object) {
        
                                                               InternalUnsafeMethods.HandleRenameObject__Args _args = new InternalUnsafeMethods.HandleRenameObject__Args() {
                        newName = newName,
                        _object = _object.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.HandleRenameObject()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool CanRenameObject(SimObject _object) {
        
                                          InternalUnsafeMethods.CanRenameObject__Args _args = new InternalUnsafeMethods.CanRenameObject__Args() {
                        _object = _object.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.CanRenameObject()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void OnAddMultipleSelectionEnd() {
        
                     InternalUnsafeMethods.OnAddMultipleSelectionEnd__Args _args = new InternalUnsafeMethods.OnAddMultipleSelectionEnd__Args() {
                     };
                     InternalUnsafeMethods.OnAddMultipleSelectionEnd()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnAddMultipleSelectionBegin() {
        
                     InternalUnsafeMethods.OnAddMultipleSelectionBegin__Args _args = new InternalUnsafeMethods.OnAddMultipleSelectionBegin__Args() {
                     };
                     InternalUnsafeMethods.OnAddMultipleSelectionBegin()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnDragDropped() {
        
                     InternalUnsafeMethods.OnDragDropped__Args _args = new InternalUnsafeMethods.OnDragDropped__Args() {
                     };
                     InternalUnsafeMethods.OnDragDropped()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnReparent(int itemOrObjectId, int oldParentItemOrObjectId, int newParentItemOrObjectId) {
        
                                                                                    InternalUnsafeMethods.OnReparent__Args _args = new InternalUnsafeMethods.OnReparent__Args() {
                        itemOrObjectId = itemOrObjectId,
                        oldParentItemOrObjectId = oldParentItemOrObjectId,
                        newParentItemOrObjectId = newParentItemOrObjectId,
                     };
                     InternalUnsafeMethods.OnReparent()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public void OnEndReparenting() {
        
                     InternalUnsafeMethods.OnEndReparenting__Args _args = new InternalUnsafeMethods.OnEndReparenting__Args() {
                     };
                     InternalUnsafeMethods.OnEndReparenting()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnBeginReparenting() {
        
                     InternalUnsafeMethods.OnBeginReparenting__Args _args = new InternalUnsafeMethods.OnBeginReparenting__Args() {
                     };
                     InternalUnsafeMethods.OnBeginReparenting()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnRightMouseUp(int itemId, Point2I mousePos, SimObject _object) {
        
                                          mousePos.Alloc();                                          InternalUnsafeMethods.OnRightMouseUp__Args _args = new InternalUnsafeMethods.OnRightMouseUp__Args() {
                        itemId = itemId,
                        mousePos = mousePos.internalStructPtr,
                        _object = _object.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnRightMouseUp()(ObjectPtr, _args);
                                                               mousePos.Free();                                 
                  }
	

			
                  public void OnRightMouseDown(int itemId, Point2I mousePos, SimObject _object) {
        
                                          mousePos.Alloc();                                          InternalUnsafeMethods.OnRightMouseDown__Args _args = new InternalUnsafeMethods.OnRightMouseDown__Args() {
                        itemId = itemId,
                        mousePos = mousePos.internalStructPtr,
                        _object = _object.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnRightMouseDown()(ObjectPtr, _args);
                                                               mousePos.Free();                                 
                  }
	

			
                  public void OnMouseDragged() {
        
                     InternalUnsafeMethods.OnMouseDragged__Args _args = new InternalUnsafeMethods.OnMouseDragged__Args() {
                     };
                     InternalUnsafeMethods.OnMouseDragged()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnMouseUp(int hitItemId, int mouseClickCount) {
        
                                                               InternalUnsafeMethods.OnMouseUp__Args _args = new InternalUnsafeMethods.OnMouseUp__Args() {
                        hitItemId = hitItemId,
                        mouseClickCount = mouseClickCount,
                     };
                     InternalUnsafeMethods.OnMouseUp()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnKeyDown(int modifier, int keyCode) {
        
                                                               InternalUnsafeMethods.OnKeyDown__Args _args = new InternalUnsafeMethods.OnKeyDown__Args() {
                        modifier = modifier,
                        keyCode = keyCode,
                     };
                     InternalUnsafeMethods.OnKeyDown()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnObjectDeleteCompleted() {
        
                     InternalUnsafeMethods.OnObjectDeleteCompleted__Args _args = new InternalUnsafeMethods.OnObjectDeleteCompleted__Args() {
                     };
                     InternalUnsafeMethods.OnObjectDeleteCompleted()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnDeleteSelection() {
        
                     InternalUnsafeMethods.OnDeleteSelection__Args _args = new InternalUnsafeMethods.OnDeleteSelection__Args() {
                     };
                     InternalUnsafeMethods.OnDeleteSelection()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void OnUnselect(int itemOrObjectId) {
        
                                          InternalUnsafeMethods.OnUnselect__Args _args = new InternalUnsafeMethods.OnUnselect__Args() {
                        itemOrObjectId = itemOrObjectId,
                     };
                     InternalUnsafeMethods.OnUnselect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnRemoveSelection(int itemOrObjectId) {
        
                                          InternalUnsafeMethods.OnRemoveSelection__Args _args = new InternalUnsafeMethods.OnRemoveSelection__Args() {
                        itemOrObjectId = itemOrObjectId,
                     };
                     InternalUnsafeMethods.OnRemoveSelection()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnInspect(int itemOrObjectId) {
        
                                          InternalUnsafeMethods.OnInspect__Args _args = new InternalUnsafeMethods.OnInspect__Args() {
                        itemOrObjectId = itemOrObjectId,
                     };
                     InternalUnsafeMethods.OnInspect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnSelect(int itemOrObjectId) {
        
                                          InternalUnsafeMethods.OnSelect__Args _args = new InternalUnsafeMethods.OnSelect__Args() {
                        itemOrObjectId = itemOrObjectId,
                     };
                     InternalUnsafeMethods.OnSelect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnAddSelection(int itemOrObjectId, bool isLastSelection) {
        
                                                               InternalUnsafeMethods.OnAddSelection__Args _args = new InternalUnsafeMethods.OnAddSelection__Args() {
                        itemOrObjectId = itemOrObjectId,
                        isLastSelection = isLastSelection,
                     };
                     InternalUnsafeMethods.OnAddSelection()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void OnAddGroupSelected(SimGroup group) {
        
                                          InternalUnsafeMethods.OnAddGroupSelected__Args _args = new InternalUnsafeMethods.OnAddGroupSelected__Args() {
                        group = group.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnAddGroupSelected()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void OnDefineIcons() {
        
                     InternalUnsafeMethods.OnDefineIcons__Args _args = new InternalUnsafeMethods.OnDefineIcons__Args() {
                     };
                     InternalUnsafeMethods.OnDefineIcons()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool IsValidDragTarget(int id, string value) {
        
                                                               InternalUnsafeMethods.IsValidDragTarget__Args _args = new InternalUnsafeMethods.IsValidDragTarget__Args() {
                        id = id,
                        value = value,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsValidDragTarget()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public bool OnDeleteObject(SimObject _object) {
        
                                          InternalUnsafeMethods.OnDeleteObject__Args _args = new InternalUnsafeMethods.OnDeleteObject__Args() {
                        _object = _object.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.OnDeleteObject()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public int TabSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tabSize"));
            set => SetFieldValue("tabSize", GenericMarshal.ToString(value));
        }


        public int TextOffset {
            get => GenericMarshal.StringTo<int>(GetFieldValue("textOffset"));
            set => SetFieldValue("textOffset", GenericMarshal.ToString(value));
        }


        public bool FullRowSelect {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fullRowSelect"));
            set => SetFieldValue("fullRowSelect", GenericMarshal.ToString(value));
        }


        public int ItemHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("itemHeight"));
            set => SetFieldValue("itemHeight", GenericMarshal.ToString(value));
        }


        public bool DestroyTreeOnSleep {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("destroyTreeOnSleep"));
            set => SetFieldValue("destroyTreeOnSleep", GenericMarshal.ToString(value));
        }


        public bool MouseDragging {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("mouseDragging"));
            set => SetFieldValue("mouseDragging", GenericMarshal.ToString(value));
        }


        public bool MultipleSelections {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("multipleSelections"));
            set => SetFieldValue("multipleSelections", GenericMarshal.ToString(value));
        }


        public bool DeleteObjectAllowed {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("deleteObjectAllowed"));
            set => SetFieldValue("deleteObjectAllowed", GenericMarshal.ToString(value));
        }


        public bool DragToItemAllowed {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dragToItemAllowed"));
            set => SetFieldValue("dragToItemAllowed", GenericMarshal.ToString(value));
        }


        public bool ClearAllOnSingleSelection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clearAllOnSingleSelection"));
            set => SetFieldValue("clearAllOnSingleSelection", GenericMarshal.ToString(value));
        }


        public bool ShowRoot {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showRoot"));
            set => SetFieldValue("showRoot", GenericMarshal.ToString(value));
        }


        public bool UseInspectorTooltips {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useInspectorTooltips"));
            set => SetFieldValue("useInspectorTooltips", GenericMarshal.ToString(value));
        }


        public bool TooltipOnWidthOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tooltipOnWidthOnly"));
            set => SetFieldValue("tooltipOnWidthOnly", GenericMarshal.ToString(value));
        }


        public bool ShowObjectIds {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showObjectIds"));
            set => SetFieldValue("showObjectIds", GenericMarshal.ToString(value));
        }


        public bool ShowClassNames {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showClassNames"));
            set => SetFieldValue("showClassNames", GenericMarshal.ToString(value));
        }


        public bool ShowObjectNames {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showObjectNames"));
            set => SetFieldValue("showObjectNames", GenericMarshal.ToString(value));
        }


        public bool ShowInternalNames {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showInternalNames"));
            set => SetFieldValue("showInternalNames", GenericMarshal.ToString(value));
        }


        public bool ShowClassNameForUnnamedObjects {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showClassNameForUnnamedObjects"));
            set => SetFieldValue("showClassNameForUnnamedObjects", GenericMarshal.ToString(value));
        }


        public bool CompareToObjectID {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("compareToObjectID"));
            set => SetFieldValue("compareToObjectID", GenericMarshal.ToString(value));
        }


        public bool CanRenameObjects {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canRenameObjects"));
            set => SetFieldValue("canRenameObjects", GenericMarshal.ToString(value));
        }


        public bool RenameInternal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renameInternal"));
            set => SetFieldValue("renameInternal", GenericMarshal.ToString(value));
        }


    }
}