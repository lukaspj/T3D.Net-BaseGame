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

    public unsafe class GuiFrameSetCtrl : GuiContainer {



        public GuiFrameSetCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiFrameSetCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiFrameSetCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiFrameSetCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiFrameSetCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiFrameSetCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiFrameSetCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct UpdateSizes__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _UpdateSizes(IntPtr _this);
                internal delegate void _UpdateSizes(IntPtr _this, UpdateSizes__Args args);
                private static _UpdateSizes _UpdateSizesFunc;
                internal static _UpdateSizes UpdateSizes() {
                    if (_UpdateSizesFunc == null) {
                        _UpdateSizesFunc =
                            (_UpdateSizes)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_updateSizes"), typeof(_UpdateSizes));
                    }
                    
                    return _UpdateSizesFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetRowOffset__Args
                {
				   
				   internal int index;
				   
				   internal int offset;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetRowOffset(IntPtr _this, int index, int offset);
                internal delegate void _SetRowOffset(IntPtr _this, SetRowOffset__Args args);
                private static _SetRowOffset _SetRowOffsetFunc;
                internal static _SetRowOffset SetRowOffset() {
                    if (_SetRowOffsetFunc == null) {
                        _SetRowOffsetFunc =
                            (_SetRowOffset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_setRowOffset"), typeof(_SetRowOffset));
                    }
                    
                    return _SetRowOffsetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetColumnOffset__Args
                {
				   
				   internal int index;
				   
				   internal int offset;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetColumnOffset(IntPtr _this, int index, int offset);
                internal delegate void _SetColumnOffset(IntPtr _this, SetColumnOffset__Args args);
                private static _SetColumnOffset _SetColumnOffsetFunc;
                internal static _SetColumnOffset SetColumnOffset() {
                    if (_SetColumnOffsetFunc == null) {
                        _SetColumnOffsetFunc =
                            (_SetColumnOffset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_setColumnOffset"), typeof(_SetColumnOffset));
                    }
                    
                    return _SetColumnOffsetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRowOffset__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetRowOffset(IntPtr _this, int index);
                internal delegate int _GetRowOffset(IntPtr _this, GetRowOffset__Args args);
                private static _GetRowOffset _GetRowOffsetFunc;
                internal static _GetRowOffset GetRowOffset() {
                    if (_GetRowOffsetFunc == null) {
                        _GetRowOffsetFunc =
                            (_GetRowOffset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_getRowOffset"), typeof(_GetRowOffset));
                    }
                    
                    return _GetRowOffsetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetColumnOffset__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetColumnOffset(IntPtr _this, int index);
                internal delegate int _GetColumnOffset(IntPtr _this, GetColumnOffset__Args args);
                private static _GetColumnOffset _GetColumnOffsetFunc;
                internal static _GetColumnOffset GetColumnOffset() {
                    if (_GetColumnOffsetFunc == null) {
                        _GetColumnOffsetFunc =
                            (_GetColumnOffset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_getColumnOffset"), typeof(_GetColumnOffset));
                    }
                    
                    return _GetColumnOffsetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRowCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetRowCount(IntPtr _this);
                internal delegate int _GetRowCount(IntPtr _this, GetRowCount__Args args);
                private static _GetRowCount _GetRowCountFunc;
                internal static _GetRowCount GetRowCount() {
                    if (_GetRowCountFunc == null) {
                        _GetRowCountFunc =
                            (_GetRowCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_getRowCount"), typeof(_GetRowCount));
                    }
                    
                    return _GetRowCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetColumnCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetColumnCount(IntPtr _this);
                internal delegate int _GetColumnCount(IntPtr _this, GetColumnCount__Args args);
                private static _GetColumnCount _GetColumnCountFunc;
                internal static _GetColumnCount GetColumnCount() {
                    if (_GetColumnCountFunc == null) {
                        _GetColumnCountFunc =
                            (_GetColumnCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_getColumnCount"), typeof(_GetColumnCount));
                    }
                    
                    return _GetColumnCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveRow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveRow(IntPtr _this);
                internal delegate void _RemoveRow(IntPtr _this, RemoveRow__Args args);
                private static _RemoveRow _RemoveRowFunc;
                internal static _RemoveRow RemoveRow() {
                    if (_RemoveRowFunc == null) {
                        _RemoveRowFunc =
                            (_RemoveRow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_removeRow"), typeof(_RemoveRow));
                    }
                    
                    return _RemoveRowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveColumn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveColumn(IntPtr _this);
                internal delegate void _RemoveColumn(IntPtr _this, RemoveColumn__Args args);
                private static _RemoveColumn _RemoveColumnFunc;
                internal static _RemoveColumn RemoveColumn() {
                    if (_RemoveColumnFunc == null) {
                        _RemoveColumnFunc =
                            (_RemoveColumn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_removeColumn"), typeof(_RemoveColumn));
                    }
                    
                    return _RemoveColumnFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddRow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddRow(IntPtr _this);
                internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
                private static _AddRow _AddRowFunc;
                internal static _AddRow AddRow() {
                    if (_AddRowFunc == null) {
                        _AddRowFunc =
                            (_AddRow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_addRow"), typeof(_AddRow));
                    }
                    
                    return _AddRowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddColumn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddColumn(IntPtr _this);
                internal delegate void _AddColumn(IntPtr _this, AddColumn__Args args);
                private static _AddColumn _AddColumnFunc;
                internal static _AddColumn AddColumn() {
                    if (_AddColumnFunc == null) {
                        _AddColumnFunc =
                            (_AddColumn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_addColumn"), typeof(_AddColumn));
                    }
                    
                    return _AddColumnFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFramePadding__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate RectSpacingI.InternalStruct _GetFramePadding(IntPtr _this, int index);
                internal delegate RectSpacingI.InternalStruct _GetFramePadding(IntPtr _this, GetFramePadding__Args args);
                private static _GetFramePadding _GetFramePaddingFunc;
                internal static _GetFramePadding GetFramePadding() {
                    if (_GetFramePaddingFunc == null) {
                        _GetFramePaddingFunc =
                            (_GetFramePadding)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_getFramePadding"), typeof(_GetFramePadding));
                    }
                    
                    return _GetFramePaddingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FramePadding__Args
                {
				   
				   internal int index;
				   
				   internal IntPtr padding;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FramePadding(IntPtr _this, int index, IntPtr padding);
                internal delegate void _FramePadding(IntPtr _this, FramePadding__Args args);
                private static _FramePadding _FramePaddingFunc;
                internal static _FramePadding FramePadding() {
                    if (_FramePaddingFunc == null) {
                        _FramePaddingFunc =
                            (_FramePadding)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_framePadding"), typeof(_FramePadding));
                    }
                    
                    return _FramePaddingFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FrameMinExtent__Args
                {
				   
				   internal int index;
				   
				   internal int width;
				   
				   internal int height;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FrameMinExtent(IntPtr _this, int index, int width, int height);
                internal delegate void _FrameMinExtent(IntPtr _this, FrameMinExtent__Args args);
                private static _FrameMinExtent _FrameMinExtentFunc;
                internal static _FrameMinExtent FrameMinExtent() {
                    if (_FrameMinExtentFunc == null) {
                        _FrameMinExtentFunc =
                            (_FrameMinExtent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_frameMinExtent"), typeof(_FrameMinExtent));
                    }
                    
                    return _FrameMinExtentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FrameMovable__Args
                {
				   
				   internal int index;
				   
				   internal string state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FrameMovable(IntPtr _this, int index, string state);
                internal delegate void _FrameMovable(IntPtr _this, FrameMovable__Args args);
                private static _FrameMovable _FrameMovableFunc;
                internal static _FrameMovable FrameMovable() {
                    if (_FrameMovableFunc == null) {
                        _FrameMovableFunc =
                            (_FrameMovable)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_frameMovable"), typeof(_FrameMovable));
                    }
                    
                    return _FrameMovableFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FrameBorder__Args
                {
				   
				   internal int index;
				   
				   internal string state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FrameBorder(IntPtr _this, int index, string state);
                internal delegate void _FrameBorder(IntPtr _this, FrameBorder__Args args);
                private static _FrameBorder _FrameBorderFunc;
                internal static _FrameBorder FrameBorder() {
                    if (_FrameBorderFunc == null) {
                        _FrameBorderFunc =
                            (_FrameBorder)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiFrameSetCtrl_frameBorder"), typeof(_FrameBorder));
                    }
                    
                    return _FrameBorderFunc;
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
                                    "fnGuiFrameSetCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiFrameSetCtrl_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void UpdateSizes() {
        
                     InternalUnsafeMethods.UpdateSizes__Args _args = new InternalUnsafeMethods.UpdateSizes__Args() {
                     };
                     InternalUnsafeMethods.UpdateSizes()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void SetRowOffset(int index, int offset) {
        
                                                               InternalUnsafeMethods.SetRowOffset__Args _args = new InternalUnsafeMethods.SetRowOffset__Args() {
                        index = index,
                        offset = offset,
                     };
                     InternalUnsafeMethods.SetRowOffset()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void SetColumnOffset(int index, int offset) {
        
                                                               InternalUnsafeMethods.SetColumnOffset__Args _args = new InternalUnsafeMethods.SetColumnOffset__Args() {
                        index = index,
                        offset = offset,
                     };
                     InternalUnsafeMethods.SetColumnOffset()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public int GetRowOffset(int index) {
        
                                          InternalUnsafeMethods.GetRowOffset__Args _args = new InternalUnsafeMethods.GetRowOffset__Args() {
                        index = index,
                     };
                     int _engineResult = InternalUnsafeMethods.GetRowOffset()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetColumnOffset(int index) {
        
                                          InternalUnsafeMethods.GetColumnOffset__Args _args = new InternalUnsafeMethods.GetColumnOffset__Args() {
                        index = index,
                     };
                     int _engineResult = InternalUnsafeMethods.GetColumnOffset()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public int GetRowCount() {
        
                     InternalUnsafeMethods.GetRowCount__Args _args = new InternalUnsafeMethods.GetRowCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetRowCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetColumnCount() {
        
                     InternalUnsafeMethods.GetColumnCount__Args _args = new InternalUnsafeMethods.GetColumnCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetColumnCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void RemoveRow() {
        
                     InternalUnsafeMethods.RemoveRow__Args _args = new InternalUnsafeMethods.RemoveRow__Args() {
                     };
                     InternalUnsafeMethods.RemoveRow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void RemoveColumn() {
        
                     InternalUnsafeMethods.RemoveColumn__Args _args = new InternalUnsafeMethods.RemoveColumn__Args() {
                     };
                     InternalUnsafeMethods.RemoveColumn()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void AddRow() {
        
                     InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                     };
                     InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void AddColumn() {
        
                     InternalUnsafeMethods.AddColumn__Args _args = new InternalUnsafeMethods.AddColumn__Args() {
                     };
                     InternalUnsafeMethods.AddColumn()(ObjectPtr, _args);
                                 
                  }
	

			
                  public RectSpacingI GetFramePadding(int index) {
        
                                          InternalUnsafeMethods.GetFramePadding__Args _args = new InternalUnsafeMethods.GetFramePadding__Args() {
                        index = index,
                     };
                     RectSpacingI.InternalStruct _engineResult = InternalUnsafeMethods.GetFramePadding()(ObjectPtr, _args);
                                                      
                     return new RectSpacingI(_engineResult);
                  }
	

			
                  public void FramePadding(int index, RectSpacingI padding) {
        
                                          padding.Alloc();                     InternalUnsafeMethods.FramePadding__Args _args = new InternalUnsafeMethods.FramePadding__Args() {
                        index = index,
                        padding = padding.internalStructPtr,
                     };
                     InternalUnsafeMethods.FramePadding()(ObjectPtr, _args);
                                                               padding.Free();            
                  }
	

			
                  public void FrameMinExtent(int index, int width, int height) {
        
                                                                                    InternalUnsafeMethods.FrameMinExtent__Args _args = new InternalUnsafeMethods.FrameMinExtent__Args() {
                        index = index,
                        width = width,
                        height = height,
                     };
                     InternalUnsafeMethods.FrameMinExtent()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public void FrameMovable(int index, string state = "dynamic") {
        
                                                               InternalUnsafeMethods.FrameMovable__Args _args = new InternalUnsafeMethods.FrameMovable__Args() {
                        index = index,
                        state = state,
                     };
                     InternalUnsafeMethods.FrameMovable()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void FrameBorder(int index, string state = "dynamic") {
        
                                                               InternalUnsafeMethods.FrameBorder__Args _args = new InternalUnsafeMethods.FrameBorder__Args() {
                        index = index,
                        state = state,
                     };
                     InternalUnsafeMethods.FrameBorder()(ObjectPtr, _args);
                                                                           
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


        public IntVector Rows {
            get => GenericMarshal.StringTo<IntVector>(GetFieldValue("rows"));
            set => SetFieldValue("rows", GenericMarshal.ToString(value));
        }


        public int BorderWidth {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderWidth"));
            set => SetFieldValue("borderWidth", GenericMarshal.ToString(value));
        }


        public ColorI BorderColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }


        public GuiFrameState BorderEnable {
            get => GenericMarshal.StringTo<GuiFrameState>(GetFieldValue("borderEnable"));
            set => SetFieldValue("borderEnable", GenericMarshal.ToString(value));
        }


        public GuiFrameState BorderMovable {
            get => GenericMarshal.StringTo<GuiFrameState>(GetFieldValue("borderMovable"));
            set => SetFieldValue("borderMovable", GenericMarshal.ToString(value));
        }


        public bool AutoBalance {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoBalance"));
            set => SetFieldValue("autoBalance", GenericMarshal.ToString(value));
        }


        public int FudgeFactor {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fudgeFactor"));
            set => SetFieldValue("fudgeFactor", GenericMarshal.ToString(value));
        }


    }
}