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
    /// <summary>A base class for cross platform menu controls that are gamepad friendly.</summary>
    /// <description>
    /// This class is used to build row-based menu GUIs that can be easily navigated using the keyboard, mouse or gamepad. The desired row can be selected using the mouse, or by navigating using the Up and Down buttons.
    /// </description>
    /// <code>
    /// new GuiGameListMenuCtrl()
    /// {
    ///    debugRender = "0";
    ///    callbackOnA = "applyOptions();";
    ///    callbackOnB = "Canvas.setContent(MainMenuGui);";
    ///    callbackOnX = "";
    ///    callbackOnY = "revertOptions();";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    /// <see cref="GuiGameListMenuProfile" />
    public unsafe class GuiGameListMenuCtrl : GuiControl {
        public GuiGameListMenuCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiGameListMenuCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiGameListMenuCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiGameListMenuCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiGameListMenuCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiGameListMenuCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiGameListMenuCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
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
                                "fnGuiGameListMenuCtrl_getSelectedRow"), typeof(_GetSelectedRow));
                }
                
                return _GetSelectedRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelected__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
            private static _SetSelected _SetSelectedFunc;
            internal static _SetSelected SetSelected() {
                if (_SetSelectedFunc == null) {
                    _SetSelectedFunc =
                        (_SetSelected)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_setSelected"), typeof(_SetSelected));
                }
                
                return _SetSelectedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowLabel__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowLabel(IntPtr _this, SetRowLabel__Args args);
            private static _SetRowLabel _SetRowLabelFunc;
            internal static _SetRowLabel SetRowLabel() {
                if (_SetRowLabelFunc == null) {
                    _SetRowLabelFunc =
                        (_SetRowLabel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_setRowLabel"), typeof(_SetRowLabel));
                }
                
                return _SetRowLabelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowLabel__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRowLabel(IntPtr _this, GetRowLabel__Args args);
            private static _GetRowLabel _GetRowLabelFunc;
            internal static _GetRowLabel GetRowLabel() {
                if (_GetRowLabelFunc == null) {
                    _GetRowLabelFunc =
                        (_GetRowLabel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_getRowLabel"), typeof(_GetRowLabel));
                }
                
                return _GetRowLabelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowCount(IntPtr _this, GetRowCount__Args args);
            private static _GetRowCount _GetRowCountFunc;
            internal static _GetRowCount GetRowCount() {
                if (_GetRowCountFunc == null) {
                    _GetRowCountFunc =
                        (_GetRowCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_getRowCount"), typeof(_GetRowCount));
                }
                
                return _GetRowCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ActivateRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ActivateRow(IntPtr _this, ActivateRow__Args args);
            private static _ActivateRow _ActivateRowFunc;
            internal static _ActivateRow ActivateRow() {
                if (_ActivateRowFunc == null) {
                    _ActivateRowFunc =
                        (_ActivateRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_activateRow"), typeof(_ActivateRow));
                }
                
                return _ActivateRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowEnabled__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowEnabled(IntPtr _this, SetRowEnabled__Args args);
            private static _SetRowEnabled _SetRowEnabledFunc;
            internal static _SetRowEnabled SetRowEnabled() {
                if (_SetRowEnabledFunc == null) {
                    _SetRowEnabledFunc =
                        (_SetRowEnabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_setRowEnabled"), typeof(_SetRowEnabled));
                }
                
                return _SetRowEnabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRowEnabled__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRowEnabled(IntPtr _this, IsRowEnabled__Args args);
            private static _IsRowEnabled _IsRowEnabledFunc;
            internal static _IsRowEnabled IsRowEnabled() {
                if (_IsRowEnabledFunc == null) {
                    _IsRowEnabledFunc =
                        (_IsRowEnabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_isRowEnabled"), typeof(_IsRowEnabled));
                }
                
                return _IsRowEnabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddRow__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                internal int icon;
                internal int yPad;
                [MarshalAs(UnmanagedType.I1)]
                internal bool useHighlightIcon;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
            private static _AddRow _AddRowFunc;
            internal static _AddRow AddRow() {
                if (_AddRowFunc == null) {
                    _AddRowFunc =
                        (_AddRow)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiGameListMenuCtrl_addRow"), typeof(_AddRow));
                }
                
                return _AddRowFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnChange__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnChange(IntPtr _this, OnChange__Args args);
            private static _OnChange _OnChangeFunc;
            internal static _OnChange OnChange() {
                if (_OnChangeFunc == null) {
                    _OnChangeFunc =
                        (_OnChange)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbGuiGameListMenuCtrl_onChange"), typeof(_OnChange));
                }
                
                return _OnChangeFunc;
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
                                "fnGuiGameListMenuCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiGameListMenuCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Gets the index of the currently selected row.
        /// </description>
        /// <returns>Index of the selected row.</returns>
        public int GetSelectedRow() {
             InternalUnsafeMethods.GetSelectedRow__Args _args = new InternalUnsafeMethods.GetSelectedRow__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedRow()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sets the selected row. Only rows that are enabled can be selected.
        /// </description>
        /// <param name="row">Index of the row to set as selected.</param>
        public void SetSelected(int row) {
             InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
                row = row,
             };
             InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the label on the given row.
        /// </description>
        /// <param name="row">Index of the row to set the label on.</param>
        /// <param name="label">Text to set as the label of the row.</param>
        public void SetRowLabel(int row, string label) {
             InternalUnsafeMethods.SetRowLabel__Args _args = new InternalUnsafeMethods.SetRowLabel__Args() {
                row = row,
                label = label,
             };
             InternalUnsafeMethods.SetRowLabel()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the label displayed on the specified row.
        /// </description>
        /// <param name="row">Index of the row to get the label of.</param>
        /// <returns>The label for the row.</returns>
        public string GetRowLabel(int row) {
             InternalUnsafeMethods.GetRowLabel__Args _args = new InternalUnsafeMethods.GetRowLabel__Args() {
                row = row,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRowLabel()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of rows on the control.
        /// </description>
        /// <returns>(int) The number of rows on the control.</returns>
        public int GetRowCount() {
             InternalUnsafeMethods.GetRowCount__Args _args = new InternalUnsafeMethods.GetRowCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRowCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Activates the current row. The script callback of  the current row will be called (if it has one).
        /// </description>
        public void ActivateRow() {
             InternalUnsafeMethods.ActivateRow__Args _args = new InternalUnsafeMethods.ActivateRow__Args() {
             };
             InternalUnsafeMethods.ActivateRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets a row's enabled status according to the given parameters.
        /// </description>
        /// <param name="row">The index to check for validity.</param>
        /// <param name="enabled">Indicate true to enable the row or false to disable it.</param>
        public void SetRowEnabled(int row, bool enabled) {
             InternalUnsafeMethods.SetRowEnabled__Args _args = new InternalUnsafeMethods.SetRowEnabled__Args() {
                row = row,
                enabled = enabled,
             };
             InternalUnsafeMethods.SetRowEnabled()(ObjectPtr, _args);
        }

        /// <description>
        /// Determines if the specified row is enabled or disabled.
        /// </description>
        /// <param name="row">The row to set the enabled status of.</param>
        /// <returns>True if the specified row is enabled. False if the row is not enabled or the given index was not valid.</returns>
        public bool IsRowEnabled(int row) {
             InternalUnsafeMethods.IsRowEnabled__Args _args = new InternalUnsafeMethods.IsRowEnabled__Args() {
                row = row,
             };
             bool _engineResult = InternalUnsafeMethods.IsRowEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="useHighlightIcon">[optional] Does this row use the highlight icon?.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        public void AddRow(string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true) {
             InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                label = label,
                callback = callback,
                icon = icon,
                yPad = yPad,
                useHighlightIcon = useHighlightIcon,
                enabled = enabled,
             };
             InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the selected row changes.
        /// </description>
        public virtual void OnChange() {
             InternalUnsafeMethods.OnChange__Args _args = new InternalUnsafeMethods.OnChange__Args() {
             };
             InternalUnsafeMethods.OnChange()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiGameListMenuCtrl class.
        /// </description>
        /// <returns>The type info object for GuiGameListMenuCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Enable debug rendering
        /// </description>
        /// </value>
        public bool DebugRender {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("debugRender"));
            set => SetFieldValue("debugRender", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'A' button is pressed. 'A' inputs are Keyboard: A, Return, Space; Gamepad: A, Start
        /// </description>
        /// </value>
        public string CallbackOnA {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnA"));
            set => SetFieldValue("callbackOnA", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'B' button is pressed. 'B' inputs are Keyboard: B, Esc, Backspace, Delete; Gamepad: B, Back
        /// </description>
        /// </value>
        public string CallbackOnB {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnB"));
            set => SetFieldValue("callbackOnB", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'X' button is pressed. 'X' inputs are Keyboard: X; Gamepad: X
        /// </description>
        /// </value>
        public string CallbackOnX {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnX"));
            set => SetFieldValue("callbackOnX", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'Y' button is pressed. 'Y' inputs are Keyboard: Y; Gamepad: Y
        /// </description>
        /// </value>
        public string CallbackOnY {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnY"));
            set => SetFieldValue("callbackOnY", GenericMarshal.ToString(value));
        }
    }
}