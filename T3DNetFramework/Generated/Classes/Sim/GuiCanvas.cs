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

    public unsafe class GuiCanvas : GuiControl {



        public GuiCanvas(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiCanvas(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiCanvas(string pName) 
            : this(pName, false) {
        }
        
        public GuiCanvas(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiCanvas(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiCanvas(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiCanvas(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ResetVideoMode__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ResetVideoMode(IntPtr _this);
                internal delegate void _ResetVideoMode(IntPtr _this, ResetVideoMode__Args args);
                private static _ResetVideoMode _ResetVideoModeFunc;
                internal static _ResetVideoMode ResetVideoMode() {
                    if (_ResetVideoModeFunc == null) {
                        _ResetVideoModeFunc =
                            (_ResetVideoMode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_resetVideoMode"), typeof(_ResetVideoMode));
                    }
                    
                    return _ResetVideoModeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CursorNudge__Args
                {
				   
				   internal float x;
				   
				   internal float y;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CursorNudge(IntPtr _this, float x, float y);
                internal delegate void _CursorNudge(IntPtr _this, CursorNudge__Args args);
                private static _CursorNudge _CursorNudgeFunc;
                internal static _CursorNudge CursorNudge() {
                    if (_CursorNudgeFunc == null) {
                        _CursorNudgeFunc =
                            (_CursorNudge)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_cursorNudge"), typeof(_CursorNudge));
                    }
                    
                    return _CursorNudgeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CursorClick__Args
                {
				   
				   internal int buttonId;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool isDown;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CursorClick(IntPtr _this, int buttonId, [MarshalAs(UnmanagedType.I1)]bool isDown);
                internal delegate void _CursorClick(IntPtr _this, CursorClick__Args args);
                private static _CursorClick _CursorClickFunc;
                internal static _CursorClick CursorClick() {
                    if (_CursorClickFunc == null) {
                        _CursorClickFunc =
                            (_CursorClick)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_cursorClick"), typeof(_CursorClick));
                    }
                    
                    return _CursorClickFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct HideWindow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _HideWindow(IntPtr _this);
                internal delegate void _HideWindow(IntPtr _this, HideWindow__Args args);
                private static _HideWindow _HideWindowFunc;
                internal static _HideWindow HideWindow() {
                    if (_HideWindowFunc == null) {
                        _HideWindowFunc =
                            (_HideWindow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_hideWindow"), typeof(_HideWindow));
                    }
                    
                    return _HideWindowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ShowWindow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ShowWindow(IntPtr _this);
                internal delegate void _ShowWindow(IntPtr _this, ShowWindow__Args args);
                private static _ShowWindow _ShowWindowFunc;
                internal static _ShowWindow ShowWindow() {
                    if (_ShowWindowFunc == null) {
                        _ShowWindowFunc =
                            (_ShowWindow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_showWindow"), typeof(_ShowWindow));
                    }
                    
                    return _ShowWindowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetVideoMode__Args
                {
				   
				   internal uint width;
				   
				   internal uint height;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool fullscreen;
				   
				   internal uint bitDepth;
				   
				   internal uint refreshRate;
				   
				   internal uint antialiasLevel;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetVideoMode(IntPtr _this, uint width, uint height, [MarshalAs(UnmanagedType.I1)]bool fullscreen, uint bitDepth, uint refreshRate, uint antialiasLevel);
                internal delegate void _SetVideoMode(IntPtr _this, SetVideoMode__Args args);
                private static _SetVideoMode _SetVideoModeFunc;
                internal static _SetVideoMode SetVideoMode() {
                    if (_SetVideoModeFunc == null) {
                        _SetVideoModeFunc =
                            (_SetVideoMode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setVideoMode"), typeof(_SetVideoMode));
                    }
                    
                    return _SetVideoModeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMenuBar__Args
                {
				   
				   internal IntPtr menu;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMenuBar(IntPtr _this, IntPtr menu);
                internal delegate void _SetMenuBar(IntPtr _this, SetMenuBar__Args args);
                private static _SetMenuBar _SetMenuBarFunc;
                internal static _SetMenuBar SetMenuBar() {
                    if (_SetMenuBarFunc == null) {
                        _SetMenuBarFunc =
                            (_SetMenuBar)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setMenuBar"), typeof(_SetMenuBar));
                    }
                    
                    return _SetMenuBarFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetFocus__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetFocus(IntPtr _this);
                internal delegate void _SetFocus(IntPtr _this, SetFocus__Args args);
                private static _SetFocus _SetFocusFunc;
                internal static _SetFocus SetFocus() {
                    if (_SetFocusFunc == null) {
                        _SetFocusFunc =
                            (_SetFocus)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setFocus"), typeof(_SetFocus));
                    }
                    
                    return _SetFocusFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RestoreWindow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RestoreWindow(IntPtr _this);
                internal delegate void _RestoreWindow(IntPtr _this, RestoreWindow__Args args);
                private static _RestoreWindow _RestoreWindowFunc;
                internal static _RestoreWindow RestoreWindow() {
                    if (_RestoreWindowFunc == null) {
                        _RestoreWindowFunc =
                            (_RestoreWindow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_restoreWindow"), typeof(_RestoreWindow));
                    }
                    
                    return _RestoreWindowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MaximizeWindow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _MaximizeWindow(IntPtr _this);
                internal delegate void _MaximizeWindow(IntPtr _this, MaximizeWindow__Args args);
                private static _MaximizeWindow _MaximizeWindowFunc;
                internal static _MaximizeWindow MaximizeWindow() {
                    if (_MaximizeWindowFunc == null) {
                        _MaximizeWindowFunc =
                            (_MaximizeWindow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_maximizeWindow"), typeof(_MaximizeWindow));
                    }
                    
                    return _MaximizeWindowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsMaximized__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsMaximized(IntPtr _this);
                internal delegate bool _IsMaximized(IntPtr _this, IsMaximized__Args args);
                private static _IsMaximized _IsMaximizedFunc;
                internal static _IsMaximized IsMaximized() {
                    if (_IsMaximizedFunc == null) {
                        _IsMaximizedFunc =
                            (_IsMaximized)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_isMaximized"), typeof(_IsMaximized));
                    }
                    
                    return _IsMaximizedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsMinimized__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsMinimized(IntPtr _this);
                internal delegate bool _IsMinimized(IntPtr _this, IsMinimized__Args args);
                private static _IsMinimized _IsMinimizedFunc;
                internal static _IsMinimized IsMinimized() {
                    if (_IsMinimizedFunc == null) {
                        _IsMinimizedFunc =
                            (_IsMinimized)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_isMinimized"), typeof(_IsMinimized));
                    }
                    
                    return _IsMinimizedFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MinimizeWindow__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _MinimizeWindow(IntPtr _this);
                internal delegate void _MinimizeWindow(IntPtr _this, MinimizeWindow__Args args);
                private static _MinimizeWindow _MinimizeWindowFunc;
                internal static _MinimizeWindow MinimizeWindow() {
                    if (_MinimizeWindowFunc == null) {
                        _MinimizeWindowFunc =
                            (_MinimizeWindow)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_minimizeWindow"), typeof(_MinimizeWindow));
                    }
                    
                    return _MinimizeWindowFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsFullscreen__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsFullscreen(IntPtr _this);
                internal delegate bool _IsFullscreen(IntPtr _this, IsFullscreen__Args args);
                private static _IsFullscreen _IsFullscreenFunc;
                internal static _IsFullscreen IsFullscreen() {
                    if (_IsFullscreenFunc == null) {
                        _IsFullscreenFunc =
                            (_IsFullscreen)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_isFullscreen"), typeof(_IsFullscreen));
                    }
                    
                    return _IsFullscreenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetWindowPosition__Args
                {
				   
				   internal IntPtr position;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetWindowPosition(IntPtr _this, IntPtr position);
                internal delegate void _SetWindowPosition(IntPtr _this, SetWindowPosition__Args args);
                private static _SetWindowPosition _SetWindowPositionFunc;
                internal static _SetWindowPosition SetWindowPosition() {
                    if (_SetWindowPositionFunc == null) {
                        _SetWindowPositionFunc =
                            (_SetWindowPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setWindowPosition"), typeof(_SetWindowPosition));
                    }
                    
                    return _SetWindowPositionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetWindowPosition__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point2I.InternalStruct _GetWindowPosition(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetWindowPosition(IntPtr _this, GetWindowPosition__Args args);
                private static _GetWindowPosition _GetWindowPositionFunc;
                internal static _GetWindowPosition GetWindowPosition() {
                    if (_GetWindowPositionFunc == null) {
                        _GetWindowPositionFunc =
                            (_GetWindowPosition)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getWindowPosition"), typeof(_GetWindowPosition));
                    }
                    
                    return _GetWindowPositionFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ScreenToClient__Args
                {
				   
				   internal IntPtr coordinate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point2I.InternalStruct _ScreenToClient(IntPtr _this, IntPtr coordinate);
                internal delegate Point2I.InternalStruct _ScreenToClient(IntPtr _this, ScreenToClient__Args args);
                private static _ScreenToClient _ScreenToClientFunc;
                internal static _ScreenToClient ScreenToClient() {
                    if (_ScreenToClientFunc == null) {
                        _ScreenToClientFunc =
                            (_ScreenToClient)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_screenToClient"), typeof(_ScreenToClient));
                    }
                    
                    return _ScreenToClientFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ClientToScreen__Args
                {
				   
				   internal IntPtr coordinate;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point2I.InternalStruct _ClientToScreen(IntPtr _this, IntPtr coordinate);
                internal delegate Point2I.InternalStruct _ClientToScreen(IntPtr _this, ClientToScreen__Args args);
                private static _ClientToScreen _ClientToScreenFunc;
                internal static _ClientToScreen ClientToScreen() {
                    if (_ClientToScreenFunc == null) {
                        _ClientToScreenFunc =
                            (_ClientToScreen)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_clientToScreen"), typeof(_ClientToScreen));
                    }
                    
                    return _ClientToScreenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ToggleFullscreen__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ToggleFullscreen(IntPtr _this);
                internal delegate void _ToggleFullscreen(IntPtr _this, ToggleFullscreen__Args args);
                private static _ToggleFullscreen _ToggleFullscreenFunc;
                internal static _ToggleFullscreen ToggleFullscreen() {
                    if (_ToggleFullscreenFunc == null) {
                        _ToggleFullscreenFunc =
                            (_ToggleFullscreen)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_toggleFullscreen"), typeof(_ToggleFullscreen));
                    }
                    
                    return _ToggleFullscreenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMode__Args
                {
				   
				   internal int modeId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetMode(IntPtr _this, int modeId);
                internal delegate IntPtr _GetMode(IntPtr _this, GetMode__Args args);
                private static _GetMode _GetModeFunc;
                internal static _GetMode GetMode() {
                    if (_GetModeFunc == null) {
                        _GetModeFunc =
                            (_GetMode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getMode"), typeof(_GetMode));
                    }
                    
                    return _GetModeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetModeCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetModeCount(IntPtr _this);
                internal delegate int _GetModeCount(IntPtr _this, GetModeCount__Args args);
                private static _GetModeCount _GetModeCountFunc;
                internal static _GetModeCount GetModeCount() {
                    if (_GetModeCountFunc == null) {
                        _GetModeCountFunc =
                            (_GetModeCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getModeCount"), typeof(_GetModeCount));
                    }
                    
                    return _GetModeCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetVideoMode__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetVideoMode(IntPtr _this);
                internal delegate IntPtr _GetVideoMode(IntPtr _this, GetVideoMode__Args args);
                private static _GetVideoMode _GetVideoModeFunc;
                internal static _GetVideoMode GetVideoMode() {
                    if (_GetVideoModeFunc == null) {
                        _GetVideoModeFunc =
                            (_GetVideoMode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getVideoMode"), typeof(_GetVideoMode));
                    }
                    
                    return _GetVideoModeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMonitorRect__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate RectI.InternalStruct _GetMonitorRect(IntPtr _this, int index);
                internal delegate RectI.InternalStruct _GetMonitorRect(IntPtr _this, GetMonitorRect__Args args);
                private static _GetMonitorRect _GetMonitorRectFunc;
                internal static _GetMonitorRect GetMonitorRect() {
                    if (_GetMonitorRectFunc == null) {
                        _GetMonitorRectFunc =
                            (_GetMonitorRect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getMonitorRect"), typeof(_GetMonitorRect));
                    }
                    
                    return _GetMonitorRectFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMonitorName__Args
                {
				   
				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetMonitorName(IntPtr _this, int index);
                internal delegate IntPtr _GetMonitorName(IntPtr _this, GetMonitorName__Args args);
                private static _GetMonitorName _GetMonitorNameFunc;
                internal static _GetMonitorName GetMonitorName() {
                    if (_GetMonitorNameFunc == null) {
                        _GetMonitorNameFunc =
                            (_GetMonitorName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getMonitorName"), typeof(_GetMonitorName));
                    }
                    
                    return _GetMonitorNameFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMonitorCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetMonitorCount(IntPtr _this);
                internal delegate int _GetMonitorCount(IntPtr _this, GetMonitorCount__Args args);
                private static _GetMonitorCount _GetMonitorCountFunc;
                internal static _GetMonitorCount GetMonitorCount() {
                    if (_GetMonitorCountFunc == null) {
                        _GetMonitorCountFunc =
                            (_GetMonitorCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getMonitorCount"), typeof(_GetMonitorCount));
                    }
                    
                    return _GetMonitorCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FindFirstMatchingMonitor__Args
                {
				   
				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _FindFirstMatchingMonitor(IntPtr _this, string name);
                internal delegate int _FindFirstMatchingMonitor(IntPtr _this, FindFirstMatchingMonitor__Args args);
                private static _FindFirstMatchingMonitor _FindFirstMatchingMonitorFunc;
                internal static _FindFirstMatchingMonitor FindFirstMatchingMonitor() {
                    if (_FindFirstMatchingMonitorFunc == null) {
                        _FindFirstMatchingMonitorFunc =
                            (_FindFirstMatchingMonitor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_findFirstMatchingMonitor"), typeof(_FindFirstMatchingMonitor));
                    }
                    
                    return _FindFirstMatchingMonitorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetWindowTitle__Args
                {
				   
				   internal string newTitle;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetWindowTitle(IntPtr _this, string newTitle);
                internal delegate void _SetWindowTitle(IntPtr _this, SetWindowTitle__Args args);
                private static _SetWindowTitle _SetWindowTitleFunc;
                internal static _SetWindowTitle SetWindowTitle() {
                    if (_SetWindowTitleFunc == null) {
                        _SetWindowTitleFunc =
                            (_SetWindowTitle)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setWindowTitle"), typeof(_SetWindowTitle));
                    }
                    
                    return _SetWindowTitleFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetExtent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point2I.InternalStruct _GetExtent(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetExtent(IntPtr _this, GetExtent__Args args);
                private static _GetExtent _GetExtentFunc;
                internal static _GetExtent GetExtent() {
                    if (_GetExtentFunc == null) {
                        _GetExtentFunc =
                            (_GetExtent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getExtent"), typeof(_GetExtent));
                    }
                    
                    return _GetExtentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMouseControl__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetMouseControl(IntPtr _this);
                internal delegate int _GetMouseControl(IntPtr _this, GetMouseControl__Args args);
                private static _GetMouseControl _GetMouseControlFunc;
                internal static _GetMouseControl GetMouseControl() {
                    if (_GetMouseControlFunc == null) {
                        _GetMouseControlFunc =
                            (_GetMouseControl)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getMouseControl"), typeof(_GetMouseControl));
                    }
                    
                    return _GetMouseControlFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCursorPos__Args
                {
				   
				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCursorPos(IntPtr _this, IntPtr pos);
                internal delegate void _SetCursorPos(IntPtr _this, SetCursorPos__Args args);
                private static _SetCursorPos _SetCursorPosFunc;
                internal static _SetCursorPos SetCursorPos() {
                    if (_SetCursorPosFunc == null) {
                        _SetCursorPosFunc =
                            (_SetCursorPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setCursorPos"), typeof(_SetCursorPos));
                    }
                    
                    return _SetCursorPosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCursorPos__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Point2I.InternalStruct _GetCursorPos(IntPtr _this);
                internal delegate Point2I.InternalStruct _GetCursorPos(IntPtr _this, GetCursorPos__Args args);
                private static _GetCursorPos _GetCursorPosFunc;
                internal static _GetCursorPos GetCursorPos() {
                    if (_GetCursorPosFunc == null) {
                        _GetCursorPosFunc =
                            (_GetCursorPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getCursorPos"), typeof(_GetCursorPos));
                    }
                    
                    return _GetCursorPosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Reset__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Reset(IntPtr _this);
                internal delegate void _Reset(IntPtr _this, Reset__Args args);
                private static _Reset _ResetFunc;
                internal static _Reset Reset() {
                    if (_ResetFunc == null) {
                        _ResetFunc =
                            (_Reset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_reset"), typeof(_Reset));
                    }
                    
                    return _ResetFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Repaint__Args
                {
				   
				   internal int elapsedMS;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _Repaint(IntPtr _this, int elapsedMS);
                internal delegate void _Repaint(IntPtr _this, Repaint__Args args);
                private static _Repaint _RepaintFunc;
                internal static _Repaint Repaint() {
                    if (_RepaintFunc == null) {
                        _RepaintFunc =
                            (_Repaint)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_repaint"), typeof(_Repaint));
                    }
                    
                    return _RepaintFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsCursorShown__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsCursorShown(IntPtr _this);
                internal delegate bool _IsCursorShown(IntPtr _this, IsCursorShown__Args args);
                private static _IsCursorShown _IsCursorShownFunc;
                internal static _IsCursorShown IsCursorShown() {
                    if (_IsCursorShownFunc == null) {
                        _IsCursorShownFunc =
                            (_IsCursorShown)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_isCursorShown"), typeof(_IsCursorShown));
                    }
                    
                    return _IsCursorShownFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct IsCursorOn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsCursorOn(IntPtr _this);
                internal delegate bool _IsCursorOn(IntPtr _this, IsCursorOn__Args args);
                private static _IsCursorOn _IsCursorOnFunc;
                internal static _IsCursorOn IsCursorOn() {
                    if (_IsCursorOnFunc == null) {
                        _IsCursorOnFunc =
                            (_IsCursorOn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_isCursorOn"), typeof(_IsCursorOn));
                    }
                    
                    return _IsCursorOnFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct HideCursor__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _HideCursor(IntPtr _this);
                internal delegate void _HideCursor(IntPtr _this, HideCursor__Args args);
                private static _HideCursor _HideCursorFunc;
                internal static _HideCursor HideCursor() {
                    if (_HideCursorFunc == null) {
                        _HideCursorFunc =
                            (_HideCursor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_hideCursor"), typeof(_HideCursor));
                    }
                    
                    return _HideCursorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ShowCursor__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ShowCursor(IntPtr _this);
                internal delegate void _ShowCursor(IntPtr _this, ShowCursor__Args args);
                private static _ShowCursor _ShowCursorFunc;
                internal static _ShowCursor ShowCursor() {
                    if (_ShowCursorFunc == null) {
                        _ShowCursorFunc =
                            (_ShowCursor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_showCursor"), typeof(_ShowCursor));
                    }
                    
                    return _ShowCursorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RenderFront__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool enable;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RenderFront(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool enable);
                internal delegate void _RenderFront(IntPtr _this, RenderFront__Args args);
                private static _RenderFront _RenderFrontFunc;
                internal static _RenderFront RenderFront() {
                    if (_RenderFrontFunc == null) {
                        _RenderFrontFunc =
                            (_RenderFront)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_renderFront"), typeof(_RenderFront));
                    }
                    
                    return _RenderFrontFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetCursor__Args
                {
				   
				   internal IntPtr cursor;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetCursor(IntPtr _this, IntPtr cursor);
                internal delegate void _SetCursor(IntPtr _this, SetCursor__Args args);
                private static _SetCursor _SetCursorFunc;
                internal static _SetCursor SetCursor() {
                    if (_SetCursorFunc == null) {
                        _SetCursorFunc =
                            (_SetCursor)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setCursor"), typeof(_SetCursor));
                    }
                    
                    return _SetCursorFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CursorOff__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CursorOff(IntPtr _this);
                internal delegate void _CursorOff(IntPtr _this, CursorOff__Args args);
                private static _CursorOff _CursorOffFunc;
                internal static _CursorOff CursorOff() {
                    if (_CursorOffFunc == null) {
                        _CursorOffFunc =
                            (_CursorOff)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_cursorOff"), typeof(_CursorOff));
                    }
                    
                    return _CursorOffFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct CursorOn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _CursorOn(IntPtr _this);
                internal delegate void _CursorOn(IntPtr _this, CursorOn__Args args);
                private static _CursorOn _CursorOnFunc;
                internal static _CursorOn CursorOn() {
                    if (_CursorOnFunc == null) {
                        _CursorOnFunc =
                            (_CursorOn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_cursorOn"), typeof(_CursorOn));
                    }
                    
                    return _CursorOnFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PopLayer__Args
                {
				   
				   internal int layer;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _PopLayer(IntPtr _this, int layer);
                internal delegate void _PopLayer(IntPtr _this, PopLayer__Args args);
                private static _PopLayer _PopLayerFunc;
                internal static _PopLayer PopLayer() {
                    if (_PopLayerFunc == null) {
                        _PopLayerFunc =
                            (_PopLayer)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_popLayer"), typeof(_PopLayer));
                    }
                    
                    return _PopLayerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PopDialog__Args
                {
				   
				   internal IntPtr gui;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _PopDialog(IntPtr _this, IntPtr gui);
                internal delegate void _PopDialog(IntPtr _this, PopDialog__Args args);
                private static _PopDialog _PopDialogFunc;
                internal static _PopDialog PopDialog() {
                    if (_PopDialogFunc == null) {
                        _PopDialogFunc =
                            (_PopDialog)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_popDialog"), typeof(_PopDialog));
                    }
                    
                    return _PopDialogFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PushDialog__Args
                {
				   
				   internal string ctrlName;
				   
				   internal int layer;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool center;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _PushDialog(IntPtr _this, string ctrlName, int layer, [MarshalAs(UnmanagedType.I1)]bool center);
                internal delegate void _PushDialog(IntPtr _this, PushDialog__Args args);
                private static _PushDialog _PushDialogFunc;
                internal static _PushDialog PushDialog() {
                    if (_PushDialogFunc == null) {
                        _PushDialogFunc =
                            (_PushDialog)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_pushDialog"), typeof(_PushDialog));
                    }
                    
                    return _PushDialogFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetContent__Args
                {
				   
				   internal IntPtr ctrl;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetContent(IntPtr _this, IntPtr ctrl);
                internal delegate void _SetContent(IntPtr _this, SetContent__Args args);
                private static _SetContent _SetContentFunc;
                internal static _SetContent SetContent() {
                    if (_SetContentFunc == null) {
                        _SetContentFunc =
                            (_SetContent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_setContent"), typeof(_SetContent));
                    }
                    
                    return _SetContentFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetContent__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetContent(IntPtr _this);
                internal delegate int _GetContent(IntPtr _this, GetContent__Args args);
                private static _GetContent _GetContentFunc;
                internal static _GetContent GetContent() {
                    if (_GetContentFunc == null) {
                        _GetContentFunc =
                            (_GetContent)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiCanvas_getContent"), typeof(_GetContent));
                    }
                    
                    return _GetContentFunc;
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
                                    "fnGuiCanvas_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiCanvas_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void ResetVideoMode() {
        
                     InternalUnsafeMethods.ResetVideoMode__Args _args = new InternalUnsafeMethods.ResetVideoMode__Args() {
                     };
                     InternalUnsafeMethods.ResetVideoMode()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void CursorNudge(float x, float y) {
        
                                                               InternalUnsafeMethods.CursorNudge__Args _args = new InternalUnsafeMethods.CursorNudge__Args() {
                        x = x,
                        y = y,
                     };
                     InternalUnsafeMethods.CursorNudge()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void CursorClick(int buttonId, bool isDown) {
        
                                                               InternalUnsafeMethods.CursorClick__Args _args = new InternalUnsafeMethods.CursorClick__Args() {
                        buttonId = buttonId,
                        isDown = isDown,
                     };
                     InternalUnsafeMethods.CursorClick()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public void HideWindow() {
        
                     InternalUnsafeMethods.HideWindow__Args _args = new InternalUnsafeMethods.HideWindow__Args() {
                     };
                     InternalUnsafeMethods.HideWindow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ShowWindow() {
        
                     InternalUnsafeMethods.ShowWindow__Args _args = new InternalUnsafeMethods.ShowWindow__Args() {
                     };
                     InternalUnsafeMethods.ShowWindow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void SetVideoMode(uint width, uint height, bool fullscreen = false, uint bitDepth = 0, uint refreshRate = 0, uint antialiasLevel = 0) {
        
                                                                                                                                                   InternalUnsafeMethods.SetVideoMode__Args _args = new InternalUnsafeMethods.SetVideoMode__Args() {
                        width = width,
                        height = height,
                        fullscreen = fullscreen,
                        bitDepth = bitDepth,
                        refreshRate = refreshRate,
                        antialiasLevel = antialiasLevel,
                     };
                     InternalUnsafeMethods.SetVideoMode()(ObjectPtr, _args);
                                                                                                                                                               
                  }
	

			
                  public void SetMenuBar(GuiControl menu) {
        
                                          InternalUnsafeMethods.SetMenuBar__Args _args = new InternalUnsafeMethods.SetMenuBar__Args() {
                        menu = menu.ObjectPtr,
                     };
                     InternalUnsafeMethods.SetMenuBar()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetFocus() {
        
                     InternalUnsafeMethods.SetFocus__Args _args = new InternalUnsafeMethods.SetFocus__Args() {
                     };
                     InternalUnsafeMethods.SetFocus()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void RestoreWindow() {
        
                     InternalUnsafeMethods.RestoreWindow__Args _args = new InternalUnsafeMethods.RestoreWindow__Args() {
                     };
                     InternalUnsafeMethods.RestoreWindow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void MaximizeWindow() {
        
                     InternalUnsafeMethods.MaximizeWindow__Args _args = new InternalUnsafeMethods.MaximizeWindow__Args() {
                     };
                     InternalUnsafeMethods.MaximizeWindow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool IsMaximized() {
        
                     InternalUnsafeMethods.IsMaximized__Args _args = new InternalUnsafeMethods.IsMaximized__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsMaximized()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool IsMinimized() {
        
                     InternalUnsafeMethods.IsMinimized__Args _args = new InternalUnsafeMethods.IsMinimized__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsMinimized()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void MinimizeWindow() {
        
                     InternalUnsafeMethods.MinimizeWindow__Args _args = new InternalUnsafeMethods.MinimizeWindow__Args() {
                     };
                     InternalUnsafeMethods.MinimizeWindow()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool IsFullscreen() {
        
                     InternalUnsafeMethods.IsFullscreen__Args _args = new InternalUnsafeMethods.IsFullscreen__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsFullscreen()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetWindowPosition(Point2I position) {
        
                     position.Alloc();                     InternalUnsafeMethods.SetWindowPosition__Args _args = new InternalUnsafeMethods.SetWindowPosition__Args() {
                        position = position.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetWindowPosition()(ObjectPtr, _args);
                                          position.Free();            
                  }
	

			
                  public Point2I GetWindowPosition() {
        
                     InternalUnsafeMethods.GetWindowPosition__Args _args = new InternalUnsafeMethods.GetWindowPosition__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetWindowPosition()(ObjectPtr, _args);
                                 
                     return new Point2I(_engineResult);
                  }
	

			
                  public Point2I ScreenToClient(Point2I coordinate) {
        
                     coordinate.Alloc();                     InternalUnsafeMethods.ScreenToClient__Args _args = new InternalUnsafeMethods.ScreenToClient__Args() {
                        coordinate = coordinate.internalStructPtr,
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.ScreenToClient()(ObjectPtr, _args);
                                          coordinate.Free();            
                     return new Point2I(_engineResult);
                  }
	

			
                  public Point2I ClientToScreen(Point2I coordinate) {
        
                     coordinate.Alloc();                     InternalUnsafeMethods.ClientToScreen__Args _args = new InternalUnsafeMethods.ClientToScreen__Args() {
                        coordinate = coordinate.internalStructPtr,
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.ClientToScreen()(ObjectPtr, _args);
                                          coordinate.Free();            
                     return new Point2I(_engineResult);
                  }
	

			
                  public void ToggleFullscreen() {
        
                     InternalUnsafeMethods.ToggleFullscreen__Args _args = new InternalUnsafeMethods.ToggleFullscreen__Args() {
                     };
                     InternalUnsafeMethods.ToggleFullscreen()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetMode(int modeId) {
        
                                          InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
                        modeId = modeId,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetModeCount() {
        
                     InternalUnsafeMethods.GetModeCount__Args _args = new InternalUnsafeMethods.GetModeCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetModeCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public string GetVideoMode() {
        
                     InternalUnsafeMethods.GetVideoMode__Args _args = new InternalUnsafeMethods.GetVideoMode__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetVideoMode()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public RectI GetMonitorRect(int index) {
        
                                          InternalUnsafeMethods.GetMonitorRect__Args _args = new InternalUnsafeMethods.GetMonitorRect__Args() {
                        index = index,
                     };
                     RectI.InternalStruct _engineResult = InternalUnsafeMethods.GetMonitorRect()(ObjectPtr, _args);
                                                      
                     return new RectI(_engineResult);
                  }
	

			
                  public string GetMonitorName(int index) {
        
                                          InternalUnsafeMethods.GetMonitorName__Args _args = new InternalUnsafeMethods.GetMonitorName__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetMonitorName()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetMonitorCount() {
        
                     InternalUnsafeMethods.GetMonitorCount__Args _args = new InternalUnsafeMethods.GetMonitorCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetMonitorCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int FindFirstMatchingMonitor(string name) {
        
                                          InternalUnsafeMethods.FindFirstMatchingMonitor__Args _args = new InternalUnsafeMethods.FindFirstMatchingMonitor__Args() {
                        name = name,
                     };
                     int _engineResult = InternalUnsafeMethods.FindFirstMatchingMonitor()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetWindowTitle(string newTitle) {
        
                                          InternalUnsafeMethods.SetWindowTitle__Args _args = new InternalUnsafeMethods.SetWindowTitle__Args() {
                        newTitle = newTitle,
                     };
                     InternalUnsafeMethods.SetWindowTitle()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public Point2I GetExtent() {
        
                     InternalUnsafeMethods.GetExtent__Args _args = new InternalUnsafeMethods.GetExtent__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetExtent()(ObjectPtr, _args);
                                 
                     return new Point2I(_engineResult);
                  }
	

			
                  public int GetMouseControl() {
        
                     InternalUnsafeMethods.GetMouseControl__Args _args = new InternalUnsafeMethods.GetMouseControl__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetMouseControl()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void SetCursorPos(Point2I pos) {
        
                     pos.Alloc();                     InternalUnsafeMethods.SetCursorPos__Args _args = new InternalUnsafeMethods.SetCursorPos__Args() {
                        pos = pos.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetCursorPos()(ObjectPtr, _args);
                                          pos.Free();            
                  }
	

			
                  public Point2I GetCursorPos() {
        
                     InternalUnsafeMethods.GetCursorPos__Args _args = new InternalUnsafeMethods.GetCursorPos__Args() {
                     };
                     Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetCursorPos()(ObjectPtr, _args);
                                 
                     return new Point2I(_engineResult);
                  }
	

			
                  public void Reset() {
        
                     InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                     };
                     InternalUnsafeMethods.Reset()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void Repaint(int elapsedMS = 0) {
        
                                          InternalUnsafeMethods.Repaint__Args _args = new InternalUnsafeMethods.Repaint__Args() {
                        elapsedMS = elapsedMS,
                     };
                     InternalUnsafeMethods.Repaint()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public bool IsCursorShown() {
        
                     InternalUnsafeMethods.IsCursorShown__Args _args = new InternalUnsafeMethods.IsCursorShown__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsCursorShown()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool IsCursorOn() {
        
                     InternalUnsafeMethods.IsCursorOn__Args _args = new InternalUnsafeMethods.IsCursorOn__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.IsCursorOn()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void HideCursor() {
        
                     InternalUnsafeMethods.HideCursor__Args _args = new InternalUnsafeMethods.HideCursor__Args() {
                     };
                     InternalUnsafeMethods.HideCursor()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ShowCursor() {
        
                     InternalUnsafeMethods.ShowCursor__Args _args = new InternalUnsafeMethods.ShowCursor__Args() {
                     };
                     InternalUnsafeMethods.ShowCursor()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void RenderFront(bool enable) {
        
                                          InternalUnsafeMethods.RenderFront__Args _args = new InternalUnsafeMethods.RenderFront__Args() {
                        enable = enable,
                     };
                     InternalUnsafeMethods.RenderFront()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetCursor(GuiCursor cursor) {
        
                                          InternalUnsafeMethods.SetCursor__Args _args = new InternalUnsafeMethods.SetCursor__Args() {
                        cursor = cursor.ObjectPtr,
                     };
                     InternalUnsafeMethods.SetCursor()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void CursorOff() {
        
                     InternalUnsafeMethods.CursorOff__Args _args = new InternalUnsafeMethods.CursorOff__Args() {
                     };
                     InternalUnsafeMethods.CursorOff()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void CursorOn() {
        
                     InternalUnsafeMethods.CursorOn__Args _args = new InternalUnsafeMethods.CursorOn__Args() {
                     };
                     InternalUnsafeMethods.CursorOn()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void PopLayer(int layer = 0) {
        
                                          InternalUnsafeMethods.PopLayer__Args _args = new InternalUnsafeMethods.PopLayer__Args() {
                        layer = layer,
                     };
                     InternalUnsafeMethods.PopLayer()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void PopDialog(GuiControl gui = null) {
        
                                          InternalUnsafeMethods.PopDialog__Args _args = new InternalUnsafeMethods.PopDialog__Args() {
                        gui = gui.ObjectPtr,
                     };
                     InternalUnsafeMethods.PopDialog()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void PushDialog(string ctrlName, int layer = 0, bool center = false) {
        
                                                                                    InternalUnsafeMethods.PushDialog__Args _args = new InternalUnsafeMethods.PushDialog__Args() {
                        ctrlName = ctrlName,
                        layer = layer,
                        center = center,
                     };
                     InternalUnsafeMethods.PushDialog()(ObjectPtr, _args);
                                                                                                
                  }
	

			
                  public void SetContent(GuiControl ctrl) {
        
                                          InternalUnsafeMethods.SetContent__Args _args = new InternalUnsafeMethods.SetContent__Args() {
                        ctrl = ctrl.ObjectPtr,
                     };
                     InternalUnsafeMethods.SetContent()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetContent() {
        
                     InternalUnsafeMethods.GetContent__Args _args = new InternalUnsafeMethods.GetContent__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetContent()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool AlwaysHandleMouseButtons {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alwaysHandleMouseButtons"));
            set => SetFieldValue("alwaysHandleMouseButtons", GenericMarshal.ToString(value));
        }


        public int NumFences {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numFences"));
            set => SetFieldValue("numFences", GenericMarshal.ToString(value));
        }


        public bool DisplayWindow {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("displayWindow"));
            set => SetFieldValue("displayWindow", GenericMarshal.ToString(value));
        }


    }
}