using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Classes.Sim {    
    public unsafe class GuiTextListCtrl : GuiArrayCtrl {
        public GuiTextListCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiTextListCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiTextListCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiTextListCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiTextListCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiTextListCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiTextListCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRowActive__Args
            {
                internal int rowNum;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRowActive(IntPtr _this, IsRowActive__Args args);
            private static _IsRowActive _IsRowActiveFunc;
            internal static _IsRowActive IsRowActive() {
                if (_IsRowActiveFunc == null) {
                    _IsRowActiveFunc =
                        (_IsRowActive)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_isRowActive"), typeof(_IsRowActive));
                }
                
                return _IsRowActiveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowActive__Args
            {
                internal int rowNum;
                [MarshalAs(UnmanagedType.I1)]
                internal bool active;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowActive(IntPtr _this, SetRowActive__Args args);
            private static _SetRowActive _SetRowActiveFunc;
            internal static _SetRowActive SetRowActive() {
                if (_SetRowActiveFunc == null) {
                    _SetRowActiveFunc =
                        (_SetRowActive)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_setRowActive"), typeof(_SetRowActive));
                }
                
                return _SetRowActiveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct FindTextIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string needle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindTextIndex(IntPtr _this, FindTextIndex__Args args);
            private static _FindTextIndex _FindTextIndexFunc;
            internal static _FindTextIndex FindTextIndex() {
                if (_FindTextIndexFunc == null) {
                    _FindTextIndexFunc =
                        (_FindTextIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_findTextIndex"), typeof(_FindTextIndex));
                }
                
                return _FindTextIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ScrollVisible__Args
            {
                internal int rowNum;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ScrollVisible(IntPtr _this, ScrollVisible__Args args);
            private static _ScrollVisible _ScrollVisibleFunc;
            internal static _ScrollVisible ScrollVisible() {
                if (_ScrollVisibleFunc == null) {
                    _ScrollVisibleFunc =
                        (_ScrollVisible)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_scrollVisible"), typeof(_ScrollVisible));
                }
                
                return _ScrollVisibleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveRow__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveRow(IntPtr _this, RemoveRow__Args args);
            private static _RemoveRow _RemoveRowFunc;
            internal static _RemoveRow RemoveRow() {
                if (_RemoveRowFunc == null) {
                    _RemoveRowFunc =
                        (_RemoveRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_removeRow"), typeof(_RemoveRow));
                }
                
                return _RemoveRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveRowById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveRowById(IntPtr _this, RemoveRowById__Args args);
            private static _RemoveRowById _RemoveRowByIdFunc;
            internal static _RemoveRowById RemoveRowById() {
                if (_RemoveRowByIdFunc == null) {
                    _RemoveRowByIdFunc =
                        (_RemoveRowById)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_removeRowById"), typeof(_RemoveRowById));
                }
                
                return _RemoveRowByIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowText__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRowText(IntPtr _this, GetRowText__Args args);
            private static _GetRowText _GetRowTextFunc;
            internal static _GetRowText GetRowText() {
                if (_GetRowTextFunc == null) {
                    _GetRowTextFunc =
                        (_GetRowText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getRowText"), typeof(_GetRowText));
                }
                
                return _GetRowTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowNumById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowNumById(IntPtr _this, GetRowNumById__Args args);
            private static _GetRowNumById _GetRowNumByIdFunc;
            internal static _GetRowNumById GetRowNumById() {
                if (_GetRowNumByIdFunc == null) {
                    _GetRowNumByIdFunc =
                        (_GetRowNumById)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getRowNumById"), typeof(_GetRowNumById));
                }
                
                return _GetRowNumByIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowTextById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRowTextById(IntPtr _this, GetRowTextById__Args args);
            private static _GetRowTextById _GetRowTextByIdFunc;
            internal static _GetRowTextById GetRowTextById() {
                if (_GetRowTextByIdFunc == null) {
                    _GetRowTextByIdFunc =
                        (_GetRowTextById)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getRowTextById"), typeof(_GetRowTextById));
                }
                
                return _GetRowTextByIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowId__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowId(IntPtr _this, GetRowId__Args args);
            private static _GetRowId _GetRowIdFunc;
            internal static _GetRowId GetRowId() {
                if (_GetRowIdFunc == null) {
                    _GetRowIdFunc =
                        (_GetRowId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getRowId"), typeof(_GetRowId));
                }
                
                return _GetRowIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RowCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _RowCount(IntPtr _this, RowCount__Args args);
            private static _RowCount _RowCountFunc;
            internal static _RowCount RowCount() {
                if (_RowCountFunc == null) {
                    _RowCountFunc =
                        (_RowCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_rowCount"), typeof(_RowCount));
                }
                
                return _RowCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
                if (_ClearFunc == null) {
                    _ClearFunc =
                        (_Clear)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_clear"), typeof(_Clear));
                }
                
                return _ClearFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SortNumerical__Args
            {
                internal int columnID;
                [MarshalAs(UnmanagedType.I1)]
                internal bool increasing;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SortNumerical(IntPtr _this, SortNumerical__Args args);
            private static _SortNumerical _SortNumericalFunc;
            internal static _SortNumerical SortNumerical() {
                if (_SortNumericalFunc == null) {
                    _SortNumericalFunc =
                        (_SortNumerical)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_sortNumerical"), typeof(_SortNumerical));
                }
                
                return _SortNumericalFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Sort__Args
            {
                internal int columnId;
                [MarshalAs(UnmanagedType.I1)]
                internal bool increasing;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sort(IntPtr _this, Sort__Args args);
            private static _Sort _SortFunc;
            internal static _Sort Sort() {
                if (_SortFunc == null) {
                    _SortFunc =
                        (_Sort)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_sort"), typeof(_Sort));
                }
                
                return _SortFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowById__Args
            {
                internal int id;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowById(IntPtr _this, SetRowById__Args args);
            private static _SetRowById _SetRowByIdFunc;
            internal static _SetRowById SetRowById() {
                if (_SetRowByIdFunc == null) {
                    _SetRowByIdFunc =
                        (_SetRowById)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_setRowById"), typeof(_SetRowById));
                }
                
                return _SetRowByIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddRow__Args
            {
                internal int id;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AddRow(IntPtr _this, AddRow__Args args);
            private static _AddRow _AddRowFunc;
            internal static _AddRow AddRow() {
                if (_AddRowFunc == null) {
                    _AddRowFunc =
                        (_AddRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_addRow"), typeof(_AddRow));
                }
                
                return _AddRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
            private static _ClearSelection _ClearSelectionFunc;
            internal static _ClearSelection ClearSelection() {
                if (_ClearSelectionFunc == null) {
                    _ClearSelectionFunc =
                        (_ClearSelection)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_clearSelection"), typeof(_ClearSelection));
                }
                
                return _ClearSelectionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedRow(IntPtr _this, GetSelectedRow__Args args);
            private static _GetSelectedRow _GetSelectedRowFunc;
            internal static _GetSelectedRow GetSelectedRow() {
                if (_GetSelectedRowFunc == null) {
                    _GetSelectedRowFunc =
                        (_GetSelectedRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getSelectedRow"), typeof(_GetSelectedRow));
                }
                
                return _GetSelectedRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedRow__Args
            {
                internal int rowNum;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedRow(IntPtr _this, SetSelectedRow__Args args);
            private static _SetSelectedRow _SetSelectedRowFunc;
            internal static _SetSelectedRow SetSelectedRow() {
                if (_SetSelectedRowFunc == null) {
                    _SetSelectedRowFunc =
                        (_SetSelectedRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_setSelectedRow"), typeof(_SetSelectedRow));
                }
                
                return _SetSelectedRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedById(IntPtr _this, SetSelectedById__Args args);
            private static _SetSelectedById _SetSelectedByIdFunc;
            internal static _SetSelectedById SetSelectedById() {
                if (_SetSelectedByIdFunc == null) {
                    _SetSelectedByIdFunc =
                        (_SetSelectedById)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_setSelectedById"), typeof(_SetSelectedById));
                }
                
                return _SetSelectedByIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedId(IntPtr _this, GetSelectedId__Args args);
            private static _GetSelectedId _GetSelectedIdFunc;
            internal static _GetSelectedId GetSelectedId() {
                if (_GetSelectedIdFunc == null) {
                    _GetSelectedIdFunc =
                        (_GetSelectedId)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_getSelectedId"), typeof(_GetSelectedId));
                }
                
                return _GetSelectedIdFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDeleteKey__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDeleteKey(IntPtr _this, OnDeleteKey__Args args);
            private static _OnDeleteKey _OnDeleteKeyFunc;
            internal static _OnDeleteKey OnDeleteKey() {
                if (_OnDeleteKeyFunc == null) {
                    _OnDeleteKeyFunc =
                        (_OnDeleteKey)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiTextListCtrl_onDeleteKey"), typeof(_OnDeleteKey));
                }
                
                return _OnDeleteKeyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSelect__Args
            {
                internal int cellid;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSelect(IntPtr _this, OnSelect__Args args);
            private static _OnSelect _OnSelectFunc;
            internal static _OnSelect OnSelect() {
                if (_OnSelectFunc == null) {
                    _OnSelectFunc =
                        (_OnSelect)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiTextListCtrl_onSelect"), typeof(_OnSelect));
                }
                
                return _OnSelectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_staticGetType"), typeof(_StaticGetType));
                }
                
                return _StaticGetTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiTextListCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool IsRowActive(int rowNum) {
             InternalUnsafeMethods.IsRowActive__Args _args = new InternalUnsafeMethods.IsRowActive__Args() {
                rowNum = rowNum,
             };
             bool _engineResult = InternalUnsafeMethods.IsRowActive()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetRowActive(int rowNum, bool active) {
             InternalUnsafeMethods.SetRowActive__Args _args = new InternalUnsafeMethods.SetRowActive__Args() {
                rowNum = rowNum,
                active = active,
             };
             InternalUnsafeMethods.SetRowActive()(ObjectPtr, _args);
        }

        public int FindTextIndex(string needle) {
             InternalUnsafeMethods.FindTextIndex__Args _args = new InternalUnsafeMethods.FindTextIndex__Args() {
                needle = needle,
             };
             int _engineResult = InternalUnsafeMethods.FindTextIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ScrollVisible(int rowNum) {
             InternalUnsafeMethods.ScrollVisible__Args _args = new InternalUnsafeMethods.ScrollVisible__Args() {
                rowNum = rowNum,
             };
             InternalUnsafeMethods.ScrollVisible()(ObjectPtr, _args);
        }

        public void RemoveRow(int index) {
             InternalUnsafeMethods.RemoveRow__Args _args = new InternalUnsafeMethods.RemoveRow__Args() {
                index = index,
             };
             InternalUnsafeMethods.RemoveRow()(ObjectPtr, _args);
        }

        public void RemoveRowById(int id) {
             InternalUnsafeMethods.RemoveRowById__Args _args = new InternalUnsafeMethods.RemoveRowById__Args() {
                id = id,
             };
             InternalUnsafeMethods.RemoveRowById()(ObjectPtr, _args);
        }

        public string GetRowText(int index) {
             InternalUnsafeMethods.GetRowText__Args _args = new InternalUnsafeMethods.GetRowText__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRowText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetRowNumById(int id) {
             InternalUnsafeMethods.GetRowNumById__Args _args = new InternalUnsafeMethods.GetRowNumById__Args() {
                id = id,
             };
             int _engineResult = InternalUnsafeMethods.GetRowNumById()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetRowTextById(int id) {
             InternalUnsafeMethods.GetRowTextById__Args _args = new InternalUnsafeMethods.GetRowTextById__Args() {
                id = id,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRowTextById()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetRowId(int index) {
             InternalUnsafeMethods.GetRowId__Args _args = new InternalUnsafeMethods.GetRowId__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetRowId()(ObjectPtr, _args);
             return _engineResult;
        }

        public int RowCount() {
             InternalUnsafeMethods.RowCount__Args _args = new InternalUnsafeMethods.RowCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.RowCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        public void SortNumerical(int columnID, bool increasing = true) {
             InternalUnsafeMethods.SortNumerical__Args _args = new InternalUnsafeMethods.SortNumerical__Args() {
                columnID = columnID,
                increasing = increasing,
             };
             InternalUnsafeMethods.SortNumerical()(ObjectPtr, _args);
        }

        public void Sort(int columnId, bool increasing = true) {
             InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
                columnId = columnId,
                increasing = increasing,
             };
             InternalUnsafeMethods.Sort()(ObjectPtr, _args);
        }

        public void SetRowById(int id, string text) {
             InternalUnsafeMethods.SetRowById__Args _args = new InternalUnsafeMethods.SetRowById__Args() {
                id = id,
                text = text,
             };
             InternalUnsafeMethods.SetRowById()(ObjectPtr, _args);
        }

        public int AddRow(int id = 0, string text = "", int index = -1) {
             InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                id = id,
                text = text,
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ClearSelection() {
             InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
             };
             InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
        }

        public int GetSelectedRow() {
             InternalUnsafeMethods.GetSelectedRow__Args _args = new InternalUnsafeMethods.GetSelectedRow__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedRow()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetSelectedRow(int rowNum) {
             InternalUnsafeMethods.SetSelectedRow__Args _args = new InternalUnsafeMethods.SetSelectedRow__Args() {
                rowNum = rowNum,
             };
             InternalUnsafeMethods.SetSelectedRow()(ObjectPtr, _args);
        }

        public void SetSelectedById(int id) {
             InternalUnsafeMethods.SetSelectedById__Args _args = new InternalUnsafeMethods.SetSelectedById__Args() {
                id = id,
             };
             InternalUnsafeMethods.SetSelectedById()(ObjectPtr, _args);
        }

        public int GetSelectedId() {
             InternalUnsafeMethods.GetSelectedId__Args _args = new InternalUnsafeMethods.GetSelectedId__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedId()(ObjectPtr, _args);
             return _engineResult;
        }

        public void OnDeleteKey(int id) {
             InternalUnsafeMethods.OnDeleteKey__Args _args = new InternalUnsafeMethods.OnDeleteKey__Args() {
                id = id,
             };
             InternalUnsafeMethods.OnDeleteKey()(ObjectPtr, _args);
        }

        public void OnSelect(int cellid, string text) {
             InternalUnsafeMethods.OnSelect__Args _args = new InternalUnsafeMethods.OnSelect__Args() {
                cellid = cellid,
                text = text,
             };
             InternalUnsafeMethods.OnSelect()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public IntVector Columns {
            get => GenericMarshal.StringTo<IntVector>(GetFieldValue("columns"));
            set => SetFieldValue("columns", GenericMarshal.ToString(value));
        }

        public bool FitParentWidth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fitParentWidth"));
            set => SetFieldValue("fitParentWidth", GenericMarshal.ToString(value));
        }

        public bool ClipColumnText {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clipColumnText"));
            set => SetFieldValue("clipColumnText", GenericMarshal.ToString(value));
        }
    }
}