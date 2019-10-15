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
    public unsafe class GuiParticleGraphCtrl : GuiControl {
        public GuiParticleGraphCtrl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiParticleGraphCtrl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiParticleGraphCtrl(string pName) 
            : this(pName, false) {
        }
        
        public GuiParticleGraphCtrl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiParticleGraphCtrl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiParticleGraphCtrl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiParticleGraphCtrl(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetSelectedPoint__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetSelectedPoint(IntPtr _this, ResetSelectedPoint__Args args);
            private static _ResetSelectedPoint _ResetSelectedPointFunc;
            internal static _ResetSelectedPoint ResetSelectedPoint() {
                if (_ResetSelectedPointFunc == null) {
                    _ResetSelectedPointFunc =
                        (_ResetSelectedPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_resetSelectedPoint"), typeof(_ResetSelectedPoint));
                }
                
                return _ResetSelectedPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphName__Args
            {
                internal int plotID;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string graphName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphName(IntPtr _this, SetGraphName__Args args);
            private static _SetGraphName _SetGraphNameFunc;
            internal static _SetGraphName SetGraphName() {
                if (_SetGraphNameFunc == null) {
                    _SetGraphNameFunc =
                        (_SetGraphName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphName"), typeof(_SetGraphName));
                }
                
                return _SetGraphNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRenderGraphTooltip__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoRemove;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRenderGraphTooltip(IntPtr _this, SetRenderGraphTooltip__Args args);
            private static _SetRenderGraphTooltip _SetRenderGraphTooltipFunc;
            internal static _SetRenderGraphTooltip SetRenderGraphTooltip() {
                if (_SetRenderGraphTooltipFunc == null) {
                    _SetRenderGraphTooltipFunc =
                        (_SetRenderGraphTooltip)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setRenderGraphTooltip"), typeof(_SetRenderGraphTooltip));
                }
                
                return _SetRenderGraphTooltipFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetPointXMovementClamped__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoRemove;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetPointXMovementClamped(IntPtr _this, SetPointXMovementClamped__Args args);
            private static _SetPointXMovementClamped _SetPointXMovementClampedFunc;
            internal static _SetPointXMovementClamped SetPointXMovementClamped() {
                if (_SetPointXMovementClampedFunc == null) {
                    _SetPointXMovementClampedFunc =
                        (_SetPointXMovementClamped)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setPointXMovementClamped"), typeof(_SetPointXMovementClamped));
                }
                
                return _SetPointXMovementClampedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRenderAll__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoRemove;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRenderAll(IntPtr _this, SetRenderAll__Args args);
            private static _SetRenderAll _SetRenderAllFunc;
            internal static _SetRenderAll SetRenderAll() {
                if (_SetRenderAllFunc == null) {
                    _SetRenderAllFunc =
                        (_SetRenderAll)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setRenderAll"), typeof(_SetRenderAll));
                }
                
                return _SetRenderAllFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoRemove__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoRemove;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoRemove(IntPtr _this, SetAutoRemove__Args args);
            private static _SetAutoRemove _SetAutoRemoveFunc;
            internal static _SetAutoRemove SetAutoRemove() {
                if (_SetAutoRemoveFunc == null) {
                    _SetAutoRemoveFunc =
                        (_SetAutoRemove)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setAutoRemove"), typeof(_SetAutoRemove));
                }
                
                return _SetAutoRemoveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoGraphMax__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoMax;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoGraphMax(IntPtr _this, SetAutoGraphMax__Args args);
            private static _SetAutoGraphMax _SetAutoGraphMaxFunc;
            internal static _SetAutoGraphMax SetAutoGraphMax() {
                if (_SetAutoGraphMaxFunc == null) {
                    _SetAutoGraphMaxFunc =
                        (_SetAutoGraphMax)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setAutoGraphMax"), typeof(_SetAutoGraphMax));
                }
                
                return _SetAutoGraphMaxFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphHidden__Args
            {
                internal int plotID;
                [MarshalAs(UnmanagedType.I1)]
                internal bool isHidden;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphHidden(IntPtr _this, SetGraphHidden__Args args);
            private static _SetGraphHidden _SetGraphHiddenFunc;
            internal static _SetGraphHidden SetGraphHidden() {
                if (_SetGraphHiddenFunc == null) {
                    _SetGraphHiddenFunc =
                        (_SetGraphHidden)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphHidden"), typeof(_SetGraphHidden));
                }
                
                return _SetGraphHiddenFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMaxY__Args
            {
                internal int plotID;
                internal float maxX;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMaxY(IntPtr _this, SetGraphMaxY__Args args);
            private static _SetGraphMaxY _SetGraphMaxYFunc;
            internal static _SetGraphMaxY SetGraphMaxY() {
                if (_SetGraphMaxYFunc == null) {
                    _SetGraphMaxYFunc =
                        (_SetGraphMaxY)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMaxY"), typeof(_SetGraphMaxY));
                }
                
                return _SetGraphMaxYFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMaxX__Args
            {
                internal int plotID;
                internal float maxX;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMaxX(IntPtr _this, SetGraphMaxX__Args args);
            private static _SetGraphMaxX _SetGraphMaxXFunc;
            internal static _SetGraphMaxX SetGraphMaxX() {
                if (_SetGraphMaxXFunc == null) {
                    _SetGraphMaxXFunc =
                        (_SetGraphMaxX)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMaxX"), typeof(_SetGraphMaxX));
                }
                
                return _SetGraphMaxXFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMax__Args
            {
                internal int plotID;
                internal float maxX;
                internal float maxY;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMax(IntPtr _this, SetGraphMax__Args args);
            private static _SetGraphMax _SetGraphMaxFunc;
            internal static _SetGraphMax SetGraphMax() {
                if (_SetGraphMaxFunc == null) {
                    _SetGraphMaxFunc =
                        (_SetGraphMax)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMax"), typeof(_SetGraphMax));
                }
                
                return _SetGraphMaxFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMinY__Args
            {
                internal int plotID;
                internal float minX;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMinY(IntPtr _this, SetGraphMinY__Args args);
            private static _SetGraphMinY _SetGraphMinYFunc;
            internal static _SetGraphMinY SetGraphMinY() {
                if (_SetGraphMinYFunc == null) {
                    _SetGraphMinYFunc =
                        (_SetGraphMinY)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMinY"), typeof(_SetGraphMinY));
                }
                
                return _SetGraphMinYFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMinX__Args
            {
                internal int plotID;
                internal float minX;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMinX(IntPtr _this, SetGraphMinX__Args args);
            private static _SetGraphMinX _SetGraphMinXFunc;
            internal static _SetGraphMinX SetGraphMinX() {
                if (_SetGraphMinXFunc == null) {
                    _SetGraphMinXFunc =
                        (_SetGraphMinX)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMinX"), typeof(_SetGraphMinX));
                }
                
                return _SetGraphMinXFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGraphMin__Args
            {
                internal int plotID;
                internal float minX;
                internal float minY;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGraphMin(IntPtr _this, SetGraphMin__Args args);
            private static _SetGraphMin _SetGraphMinFunc;
            internal static _SetGraphMin SetGraphMin() {
                if (_SetGraphMinFunc == null) {
                    _SetGraphMinFunc =
                        (_SetGraphMin)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setGraphMin"), typeof(_SetGraphMin));
                }
                
                return _SetGraphMinFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGraphName__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetGraphName(IntPtr _this, GetGraphName__Args args);
            private static _GetGraphName _GetGraphNameFunc;
            internal static _GetGraphName GetGraphName() {
                if (_GetGraphNameFunc == null) {
                    _GetGraphNameFunc =
                        (_GetGraphName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getGraphName"), typeof(_GetGraphName));
                }
                
                return _GetGraphNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGraphMax__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetGraphMax(IntPtr _this, GetGraphMax__Args args);
            private static _GetGraphMax _GetGraphMaxFunc;
            internal static _GetGraphMax GetGraphMax() {
                if (_GetGraphMaxFunc == null) {
                    _GetGraphMaxFunc =
                        (_GetGraphMax)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getGraphMax"), typeof(_GetGraphMax));
                }
                
                return _GetGraphMaxFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGraphMin__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetGraphMin(IntPtr _this, GetGraphMin__Args args);
            private static _GetGraphMin _GetGraphMinFunc;
            internal static _GetGraphMin GetGraphMin() {
                if (_GetGraphMinFunc == null) {
                    _GetGraphMinFunc =
                        (_GetGraphMin)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getGraphMin"), typeof(_GetGraphMin));
                }
                
                return _GetGraphMinFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGraphColor__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate LinearColorF.InternalStruct _GetGraphColor(IntPtr _this, GetGraphColor__Args args);
            private static _GetGraphColor _GetGraphColorFunc;
            internal static _GetGraphColor GetGraphColor() {
                if (_GetGraphColorFunc == null) {
                    _GetGraphColorFunc =
                        (_GetGraphColor)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getGraphColor"), typeof(_GetGraphColor));
                }
                
                return _GetGraphColorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPlotIndex__Args
            {
                internal int plotID;
                internal float x;
                internal float y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetPlotIndex(IntPtr _this, GetPlotIndex__Args args);
            private static _GetPlotIndex _GetPlotIndexFunc;
            internal static _GetPlotIndex GetPlotIndex() {
                if (_GetPlotIndexFunc == null) {
                    _GetPlotIndexFunc =
                        (_GetPlotIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getPlotIndex"), typeof(_GetPlotIndex));
                }
                
                return _GetPlotIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPlotPoint__Args
            {
                internal int plotID;
                internal int samples;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetPlotPoint(IntPtr _this, GetPlotPoint__Args args);
            private static _GetPlotPoint _GetPlotPointFunc;
            internal static _GetPlotPoint GetPlotPoint() {
                if (_GetPlotPointFunc == null) {
                    _GetPlotPointFunc =
                        (_GetPlotPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getPlotPoint"), typeof(_GetPlotPoint));
                }
                
                return _GetPlotPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsExistingPoint__Args
            {
                internal int plotID;
                internal int samples;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsExistingPoint(IntPtr _this, IsExistingPoint__Args args);
            private static _IsExistingPoint _IsExistingPointFunc;
            internal static _IsExistingPoint IsExistingPoint() {
                if (_IsExistingPointFunc == null) {
                    _IsExistingPointFunc =
                        (_IsExistingPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_isExistingPoint"), typeof(_IsExistingPoint));
                }
                
                return _IsExistingPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedPoint__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedPoint(IntPtr _this, GetSelectedPoint__Args args);
            private static _GetSelectedPoint _GetSelectedPointFunc;
            internal static _GetSelectedPoint GetSelectedPoint() {
                if (_GetSelectedPointFunc == null) {
                    _GetSelectedPointFunc =
                        (_GetSelectedPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getSelectedPoint"), typeof(_GetSelectedPoint));
                }
                
                return _GetSelectedPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedPlot__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedPlot(IntPtr _this, GetSelectedPlot__Args args);
            private static _GetSelectedPlot _GetSelectedPlotFunc;
            internal static _GetSelectedPlot GetSelectedPlot() {
                if (_GetSelectedPlotFunc == null) {
                    _GetSelectedPlotFunc =
                        (_GetSelectedPlot)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_getSelectedPlot"), typeof(_GetSelectedPlot));
                }
                
                return _GetSelectedPlotFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ChangePlotPoint__Args
            {
                internal int plotID;
                internal int i;
                internal float x;
                internal float y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _ChangePlotPoint(IntPtr _this, ChangePlotPoint__Args args);
            private static _ChangePlotPoint _ChangePlotPointFunc;
            internal static _ChangePlotPoint ChangePlotPoint() {
                if (_ChangePlotPointFunc == null) {
                    _ChangePlotPointFunc =
                        (_ChangePlotPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_changePlotPoint"), typeof(_ChangePlotPoint));
                }
                
                return _ChangePlotPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct InsertPlotPoint__Args
            {
                internal int plotID;
                internal int i;
                internal float x;
                internal float y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InsertPlotPoint(IntPtr _this, InsertPlotPoint__Args args);
            private static _InsertPlotPoint _InsertPlotPointFunc;
            internal static _InsertPlotPoint InsertPlotPoint() {
                if (_InsertPlotPointFunc == null) {
                    _InsertPlotPointFunc =
                        (_InsertPlotPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_insertPlotPoint"), typeof(_InsertPlotPoint));
                }
                
                return _InsertPlotPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddPlotPoint__Args
            {
                internal int plotID;
                internal float x;
                internal float y;
                [MarshalAs(UnmanagedType.I1)]
                internal bool setAdded;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AddPlotPoint(IntPtr _this, AddPlotPoint__Args args);
            private static _AddPlotPoint _AddPlotPointFunc;
            internal static _AddPlotPoint AddPlotPoint() {
                if (_AddPlotPointFunc == null) {
                    _AddPlotPointFunc =
                        (_AddPlotPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_addPlotPoint"), typeof(_AddPlotPoint));
                }
                
                return _AddPlotPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearAllGraphs__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearAllGraphs(IntPtr _this, ClearAllGraphs__Args args);
            private static _ClearAllGraphs _ClearAllGraphsFunc;
            internal static _ClearAllGraphs ClearAllGraphs() {
                if (_ClearAllGraphsFunc == null) {
                    _ClearAllGraphsFunc =
                        (_ClearAllGraphs)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_clearAllGraphs"), typeof(_ClearAllGraphs));
                }
                
                return _ClearAllGraphsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearGraph__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearGraph(IntPtr _this, ClearGraph__Args args);
            private static _ClearGraph _ClearGraphFunc;
            internal static _ClearGraph ClearGraph() {
                if (_ClearGraphFunc == null) {
                    _ClearGraphFunc =
                        (_ClearGraph)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_clearGraph"), typeof(_ClearGraph));
                }
                
                return _ClearGraphFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedPlot__Args
            {
                internal int plotID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedPlot(IntPtr _this, SetSelectedPlot__Args args);
            private static _SetSelectedPlot _SetSelectedPlotFunc;
            internal static _SetSelectedPlot SetSelectedPlot() {
                if (_SetSelectedPlotFunc == null) {
                    _SetSelectedPlotFunc =
                        (_SetSelectedPlot)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setSelectedPlot"), typeof(_SetSelectedPlot));
                }
                
                return _SetSelectedPlotFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedPoint__Args
            {
                internal int point;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedPoint(IntPtr _this, SetSelectedPoint__Args args);
            private static _SetSelectedPoint _SetSelectedPointFunc;
            internal static _SetSelectedPoint SetSelectedPoint() {
                if (_SetSelectedPointFunc == null) {
                    _SetSelectedPointFunc =
                        (_SetSelectedPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiParticleGraphCtrl_setSelectedPoint"), typeof(_SetSelectedPoint));
                }
                
                return _SetSelectedPointFunc;
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
                                "fnGuiParticleGraphCtrl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiParticleGraphCtrl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void ResetSelectedPoint() {
             InternalUnsafeMethods.ResetSelectedPoint__Args _args = new InternalUnsafeMethods.ResetSelectedPoint__Args() {
             };
             InternalUnsafeMethods.ResetSelectedPoint()(ObjectPtr, _args);
        }

        public void SetGraphName(int plotID, string graphName) {
             InternalUnsafeMethods.SetGraphName__Args _args = new InternalUnsafeMethods.SetGraphName__Args() {
                plotID = plotID,
                graphName = graphName,
             };
             InternalUnsafeMethods.SetGraphName()(ObjectPtr, _args);
        }

        public void SetRenderGraphTooltip(bool autoRemove) {
             InternalUnsafeMethods.SetRenderGraphTooltip__Args _args = new InternalUnsafeMethods.SetRenderGraphTooltip__Args() {
                autoRemove = autoRemove,
             };
             InternalUnsafeMethods.SetRenderGraphTooltip()(ObjectPtr, _args);
        }

        public void SetPointXMovementClamped(bool autoRemove) {
             InternalUnsafeMethods.SetPointXMovementClamped__Args _args = new InternalUnsafeMethods.SetPointXMovementClamped__Args() {
                autoRemove = autoRemove,
             };
             InternalUnsafeMethods.SetPointXMovementClamped()(ObjectPtr, _args);
        }

        public void SetRenderAll(bool autoRemove) {
             InternalUnsafeMethods.SetRenderAll__Args _args = new InternalUnsafeMethods.SetRenderAll__Args() {
                autoRemove = autoRemove,
             };
             InternalUnsafeMethods.SetRenderAll()(ObjectPtr, _args);
        }

        public void SetAutoRemove(bool autoRemove) {
             InternalUnsafeMethods.SetAutoRemove__Args _args = new InternalUnsafeMethods.SetAutoRemove__Args() {
                autoRemove = autoRemove,
             };
             InternalUnsafeMethods.SetAutoRemove()(ObjectPtr, _args);
        }

        public void SetAutoGraphMax(bool autoMax) {
             InternalUnsafeMethods.SetAutoGraphMax__Args _args = new InternalUnsafeMethods.SetAutoGraphMax__Args() {
                autoMax = autoMax,
             };
             InternalUnsafeMethods.SetAutoGraphMax()(ObjectPtr, _args);
        }

        public void SetGraphHidden(int plotID, bool isHidden) {
             InternalUnsafeMethods.SetGraphHidden__Args _args = new InternalUnsafeMethods.SetGraphHidden__Args() {
                plotID = plotID,
                isHidden = isHidden,
             };
             InternalUnsafeMethods.SetGraphHidden()(ObjectPtr, _args);
        }

        public void SetGraphMaxY(int plotID, float maxX) {
             InternalUnsafeMethods.SetGraphMaxY__Args _args = new InternalUnsafeMethods.SetGraphMaxY__Args() {
                plotID = plotID,
                maxX = maxX,
             };
             InternalUnsafeMethods.SetGraphMaxY()(ObjectPtr, _args);
        }

        public void SetGraphMaxX(int plotID, float maxX) {
             InternalUnsafeMethods.SetGraphMaxX__Args _args = new InternalUnsafeMethods.SetGraphMaxX__Args() {
                plotID = plotID,
                maxX = maxX,
             };
             InternalUnsafeMethods.SetGraphMaxX()(ObjectPtr, _args);
        }

        public void SetGraphMax(int plotID, float maxX, float maxY) {
             InternalUnsafeMethods.SetGraphMax__Args _args = new InternalUnsafeMethods.SetGraphMax__Args() {
                plotID = plotID,
                maxX = maxX,
                maxY = maxY,
             };
             InternalUnsafeMethods.SetGraphMax()(ObjectPtr, _args);
        }

        public void SetGraphMinY(int plotID, float minX) {
             InternalUnsafeMethods.SetGraphMinY__Args _args = new InternalUnsafeMethods.SetGraphMinY__Args() {
                plotID = plotID,
                minX = minX,
             };
             InternalUnsafeMethods.SetGraphMinY()(ObjectPtr, _args);
        }

        public void SetGraphMinX(int plotID, float minX) {
             InternalUnsafeMethods.SetGraphMinX__Args _args = new InternalUnsafeMethods.SetGraphMinX__Args() {
                plotID = plotID,
                minX = minX,
             };
             InternalUnsafeMethods.SetGraphMinX()(ObjectPtr, _args);
        }

        public void SetGraphMin(int plotID, float minX, float minY) {
             InternalUnsafeMethods.SetGraphMin__Args _args = new InternalUnsafeMethods.SetGraphMin__Args() {
                plotID = plotID,
                minX = minX,
                minY = minY,
             };
             InternalUnsafeMethods.SetGraphMin()(ObjectPtr, _args);
        }

        public string GetGraphName(int plotID) {
             InternalUnsafeMethods.GetGraphName__Args _args = new InternalUnsafeMethods.GetGraphName__Args() {
                plotID = plotID,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGraphName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public Point2F GetGraphMax(int plotID) {
             InternalUnsafeMethods.GetGraphMax__Args _args = new InternalUnsafeMethods.GetGraphMax__Args() {
                plotID = plotID,
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetGraphMax()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        public Point2F GetGraphMin(int plotID) {
             InternalUnsafeMethods.GetGraphMin__Args _args = new InternalUnsafeMethods.GetGraphMin__Args() {
                plotID = plotID,
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetGraphMin()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        public LinearColorF GetGraphColor(int plotID) {
             InternalUnsafeMethods.GetGraphColor__Args _args = new InternalUnsafeMethods.GetGraphColor__Args() {
                plotID = plotID,
             };
             LinearColorF.InternalStruct _engineResult = InternalUnsafeMethods.GetGraphColor()(ObjectPtr, _args);
             return new LinearColorF(_engineResult);
        }

        public int GetPlotIndex(int plotID, float x, float y) {
             InternalUnsafeMethods.GetPlotIndex__Args _args = new InternalUnsafeMethods.GetPlotIndex__Args() {
                plotID = plotID,
                x = x,
                y = y,
             };
             int _engineResult = InternalUnsafeMethods.GetPlotIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public Point2F GetPlotPoint(int plotID, int samples) {
             InternalUnsafeMethods.GetPlotPoint__Args _args = new InternalUnsafeMethods.GetPlotPoint__Args() {
                plotID = plotID,
                samples = samples,
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetPlotPoint()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        public bool IsExistingPoint(int plotID, int samples) {
             InternalUnsafeMethods.IsExistingPoint__Args _args = new InternalUnsafeMethods.IsExistingPoint__Args() {
                plotID = plotID,
                samples = samples,
             };
             bool _engineResult = InternalUnsafeMethods.IsExistingPoint()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetSelectedPoint() {
             InternalUnsafeMethods.GetSelectedPoint__Args _args = new InternalUnsafeMethods.GetSelectedPoint__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedPoint()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetSelectedPlot() {
             InternalUnsafeMethods.GetSelectedPlot__Args _args = new InternalUnsafeMethods.GetSelectedPlot__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedPlot()(ObjectPtr, _args);
             return _engineResult;
        }

        public int ChangePlotPoint(int plotID, int i, float x, float y) {
             InternalUnsafeMethods.ChangePlotPoint__Args _args = new InternalUnsafeMethods.ChangePlotPoint__Args() {
                plotID = plotID,
                i = i,
                x = x,
                y = y,
             };
             int _engineResult = InternalUnsafeMethods.ChangePlotPoint()(ObjectPtr, _args);
             return _engineResult;
        }

        public void InsertPlotPoint(int plotID, int i, float x, float y) {
             InternalUnsafeMethods.InsertPlotPoint__Args _args = new InternalUnsafeMethods.InsertPlotPoint__Args() {
                plotID = plotID,
                i = i,
                x = x,
                y = y,
             };
             InternalUnsafeMethods.InsertPlotPoint()(ObjectPtr, _args);
        }

        public int AddPlotPoint(int plotID, float x, float y, bool setAdded = true) {
             InternalUnsafeMethods.AddPlotPoint__Args _args = new InternalUnsafeMethods.AddPlotPoint__Args() {
                plotID = plotID,
                x = x,
                y = y,
                setAdded = setAdded,
             };
             int _engineResult = InternalUnsafeMethods.AddPlotPoint()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ClearAllGraphs() {
             InternalUnsafeMethods.ClearAllGraphs__Args _args = new InternalUnsafeMethods.ClearAllGraphs__Args() {
             };
             InternalUnsafeMethods.ClearAllGraphs()(ObjectPtr, _args);
        }

        public void ClearGraph(int plotID) {
             InternalUnsafeMethods.ClearGraph__Args _args = new InternalUnsafeMethods.ClearGraph__Args() {
                plotID = plotID,
             };
             InternalUnsafeMethods.ClearGraph()(ObjectPtr, _args);
        }

        public void SetSelectedPlot(int plotID) {
             InternalUnsafeMethods.SetSelectedPlot__Args _args = new InternalUnsafeMethods.SetSelectedPlot__Args() {
                plotID = plotID,
             };
             InternalUnsafeMethods.SetSelectedPlot()(ObjectPtr, _args);
        }

        public void SetSelectedPoint(int point) {
             InternalUnsafeMethods.SetSelectedPoint__Args _args = new InternalUnsafeMethods.SetSelectedPoint__Args() {
                point = point,
             };
             InternalUnsafeMethods.SetSelectedPoint()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}