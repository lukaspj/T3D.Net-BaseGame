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

    public unsafe class GuiShapeEdPreview : EditTSCtrl {



        public GuiShapeEdPreview(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiShapeEdPreview(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiShapeEdPreview(string pName) 
            : this(pName, false) {
        }
        
        public GuiShapeEdPreview(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiShapeEdPreview(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiShapeEdPreview(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiShapeEdPreview(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct UnmountAll__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _UnmountAll(IntPtr _this);
                internal delegate void _UnmountAll(IntPtr _this, UnmountAll__Args args);
                private static _UnmountAll _UnmountAllFunc;
                internal static _UnmountAll UnmountAll() {
                    if (_UnmountAllFunc == null) {
                        _UnmountAllFunc =
                            (_UnmountAll)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_unmountAll"), typeof(_UnmountAll));
                    }
                    
                    return _UnmountAllFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct UnmountShape__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _UnmountShape(IntPtr _this, int slot);
                internal delegate void _UnmountShape(IntPtr _this, UnmountShape__Args args);
                private static _UnmountShape _UnmountShapeFunc;
                internal static _UnmountShape UnmountShape() {
                    if (_UnmountShapeFunc == null) {
                        _UnmountShapeFunc =
                            (_UnmountShape)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_unmountShape"), typeof(_UnmountShape));
                    }
                    
                    return _UnmountShapeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountThreadDir__Args
                {
				   
				   internal int slot;
				   
				   internal float dir;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountThreadDir(IntPtr _this, int slot, float dir);
                internal delegate void _SetMountThreadDir(IntPtr _this, SetMountThreadDir__Args args);
                private static _SetMountThreadDir _SetMountThreadDirFunc;
                internal static _SetMountThreadDir SetMountThreadDir() {
                    if (_SetMountThreadDirFunc == null) {
                        _SetMountThreadDirFunc =
                            (_SetMountThreadDir)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setMountThreadDir"), typeof(_SetMountThreadDir));
                    }
                    
                    return _SetMountThreadDirFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountThreadDir__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetMountThreadDir(IntPtr _this, int slot);
                internal delegate float _GetMountThreadDir(IntPtr _this, GetMountThreadDir__Args args);
                private static _GetMountThreadDir _GetMountThreadDirFunc;
                internal static _GetMountThreadDir GetMountThreadDir() {
                    if (_GetMountThreadDirFunc == null) {
                        _GetMountThreadDirFunc =
                            (_GetMountThreadDir)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getMountThreadDir"), typeof(_GetMountThreadDir));
                    }
                    
                    return _GetMountThreadDirFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountThreadPos__Args
                {
				   
				   internal int slot;
				   
				   internal float pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountThreadPos(IntPtr _this, int slot, float pos);
                internal delegate void _SetMountThreadPos(IntPtr _this, SetMountThreadPos__Args args);
                private static _SetMountThreadPos _SetMountThreadPosFunc;
                internal static _SetMountThreadPos SetMountThreadPos() {
                    if (_SetMountThreadPosFunc == null) {
                        _SetMountThreadPosFunc =
                            (_SetMountThreadPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setMountThreadPos"), typeof(_SetMountThreadPos));
                    }
                    
                    return _SetMountThreadPosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountThreadPos__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate float _GetMountThreadPos(IntPtr _this, int slot);
                internal delegate float _GetMountThreadPos(IntPtr _this, GetMountThreadPos__Args args);
                private static _GetMountThreadPos _GetMountThreadPosFunc;
                internal static _GetMountThreadPos GetMountThreadPos() {
                    if (_GetMountThreadPosFunc == null) {
                        _GetMountThreadPosFunc =
                            (_GetMountThreadPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getMountThreadPos"), typeof(_GetMountThreadPos));
                    }
                    
                    return _GetMountThreadPosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountThreadSequence__Args
                {
				   
				   internal int slot;
				   
				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountThreadSequence(IntPtr _this, int slot, string name);
                internal delegate void _SetMountThreadSequence(IntPtr _this, SetMountThreadSequence__Args args);
                private static _SetMountThreadSequence _SetMountThreadSequenceFunc;
                internal static _SetMountThreadSequence SetMountThreadSequence() {
                    if (_SetMountThreadSequenceFunc == null) {
                        _SetMountThreadSequenceFunc =
                            (_SetMountThreadSequence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setMountThreadSequence"), typeof(_SetMountThreadSequence));
                    }
                    
                    return _SetMountThreadSequenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMountThreadSequence__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetMountThreadSequence(IntPtr _this, int slot);
                internal delegate IntPtr _GetMountThreadSequence(IntPtr _this, GetMountThreadSequence__Args args);
                private static _GetMountThreadSequence _GetMountThreadSequenceFunc;
                internal static _GetMountThreadSequence GetMountThreadSequence() {
                    if (_GetMountThreadSequenceFunc == null) {
                        _GetMountThreadSequenceFunc =
                            (_GetMountThreadSequence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getMountThreadSequence"), typeof(_GetMountThreadSequence));
                    }
                    
                    return _GetMountThreadSequenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMountNode__Args
                {
				   
				   internal int slot;
				   
				   internal string nodeName;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMountNode(IntPtr _this, int slot, string nodeName);
                internal delegate void _SetMountNode(IntPtr _this, SetMountNode__Args args);
                private static _SetMountNode _SetMountNodeFunc;
                internal static _SetMountNode SetMountNode() {
                    if (_SetMountNodeFunc == null) {
                        _SetMountNodeFunc =
                            (_SetMountNode)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setMountNode"), typeof(_SetMountNode));
                    }
                    
                    return _SetMountNodeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct MountShape__Args
                {
				   
				   internal string shapePath;
				   
				   internal string nodeName;
				   
				   internal string type;
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _MountShape(IntPtr _this, string shapePath, string nodeName, string type, int slot);
                internal delegate bool _MountShape(IntPtr _this, MountShape__Args args);
                private static _MountShape _MountShapeFunc;
                internal static _MountShape MountShape() {
                    if (_MountShapeFunc == null) {
                        _MountShapeFunc =
                            (_MountShape)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_mountShape"), typeof(_MountShape));
                    }
                    
                    return _MountShapeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RefreshThreadSequences__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RefreshThreadSequences(IntPtr _this);
                internal delegate void _RefreshThreadSequences(IntPtr _this, RefreshThreadSequences__Args args);
                private static _RefreshThreadSequences _RefreshThreadSequencesFunc;
                internal static _RefreshThreadSequences RefreshThreadSequences() {
                    if (_RefreshThreadSequencesFunc == null) {
                        _RefreshThreadSequencesFunc =
                            (_RefreshThreadSequences)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_refreshThreadSequences"), typeof(_RefreshThreadSequences));
                    }
                    
                    return _RefreshThreadSequencesFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetThreadSequence__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetThreadSequence(IntPtr _this);
                internal delegate IntPtr _GetThreadSequence(IntPtr _this, GetThreadSequence__Args args);
                private static _GetThreadSequence _GetThreadSequenceFunc;
                internal static _GetThreadSequence GetThreadSequence() {
                    if (_GetThreadSequenceFunc == null) {
                        _GetThreadSequenceFunc =
                            (_GetThreadSequence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getThreadSequence"), typeof(_GetThreadSequence));
                    }
                    
                    return _GetThreadSequenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetThreadSequence__Args
                {
				   
				   internal string name;
				   
				   internal float duration;
				   
				   internal float pos;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool play;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetThreadSequence(IntPtr _this, string name, float duration, float pos, [MarshalAs(UnmanagedType.I1)]bool play);
                internal delegate void _SetThreadSequence(IntPtr _this, SetThreadSequence__Args args);
                private static _SetThreadSequence _SetThreadSequenceFunc;
                internal static _SetThreadSequence SetThreadSequence() {
                    if (_SetThreadSequenceFunc == null) {
                        _SetThreadSequenceFunc =
                            (_SetThreadSequence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setThreadSequence"), typeof(_SetThreadSequence));
                    }
                    
                    return _SetThreadSequenceFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTimeScale__Args
                {
				   
				   internal float scale;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetTimeScale(IntPtr _this, float scale);
                internal delegate void _SetTimeScale(IntPtr _this, SetTimeScale__Args args);
                private static _SetTimeScale _SetTimeScaleFunc;
                internal static _SetTimeScale SetTimeScale() {
                    if (_SetTimeScaleFunc == null) {
                        _SetTimeScaleFunc =
                            (_SetTimeScale)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setTimeScale"), typeof(_SetTimeScale));
                    }
                    
                    return _SetTimeScaleFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetThreadCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetThreadCount(IntPtr _this);
                internal delegate int _GetThreadCount(IntPtr _this, GetThreadCount__Args args);
                private static _GetThreadCount _GetThreadCountFunc;
                internal static _GetThreadCount GetThreadCount() {
                    if (_GetThreadCountFunc == null) {
                        _GetThreadCountFunc =
                            (_GetThreadCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getThreadCount"), typeof(_GetThreadCount));
                    }
                    
                    return _GetThreadCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveThread__Args
                {
				   
				   internal int slot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RemoveThread(IntPtr _this, int slot);
                internal delegate void _RemoveThread(IntPtr _this, RemoveThread__Args args);
                private static _RemoveThread _RemoveThreadFunc;
                internal static _RemoveThread RemoveThread() {
                    if (_RemoveThreadFunc == null) {
                        _RemoveThreadFunc =
                            (_RemoveThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_removeThread"), typeof(_RemoveThread));
                    }
                    
                    return _RemoveThreadFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddThread__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _AddThread(IntPtr _this);
                internal delegate void _AddThread(IntPtr _this, AddThread__Args args);
                private static _AddThread _AddThreadFunc;
                internal static _AddThread AddThread() {
                    if (_AddThreadFunc == null) {
                        _AddThreadFunc =
                            (_AddThread)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_addThread"), typeof(_AddThread));
                    }
                    
                    return _AddThreadFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ExportToCollada__Args
                {
				   
				   internal string path;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _ExportToCollada(IntPtr _this, string path);
                internal delegate void _ExportToCollada(IntPtr _this, ExportToCollada__Args args);
                private static _ExportToCollada _ExportToColladaFunc;
                internal static _ExportToCollada ExportToCollada() {
                    if (_ExportToColladaFunc == null) {
                        _ExportToColladaFunc =
                            (_ExportToCollada)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_exportToCollada"), typeof(_ExportToCollada));
                    }
                    
                    return _ExportToColladaFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAllMeshesHidden__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool hidden;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetAllMeshesHidden(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool hidden);
                internal delegate void _SetAllMeshesHidden(IntPtr _this, SetAllMeshesHidden__Args args);
                private static _SetAllMeshesHidden _SetAllMeshesHiddenFunc;
                internal static _SetAllMeshesHidden SetAllMeshesHidden() {
                    if (_SetAllMeshesHiddenFunc == null) {
                        _SetAllMeshesHiddenFunc =
                            (_SetAllMeshesHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setAllMeshesHidden"), typeof(_SetAllMeshesHidden));
                    }
                    
                    return _SetAllMeshesHiddenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetMeshHidden__Args
                {
				   
				   internal string name;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool hidden;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetMeshHidden(IntPtr _this, string name, [MarshalAs(UnmanagedType.I1)]bool hidden);
                internal delegate void _SetMeshHidden(IntPtr _this, SetMeshHidden__Args args);
                private static _SetMeshHidden _SetMeshHiddenFunc;
                internal static _SetMeshHidden SetMeshHidden() {
                    if (_SetMeshHiddenFunc == null) {
                        _SetMeshHiddenFunc =
                            (_SetMeshHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setMeshHidden"), typeof(_SetMeshHidden));
                    }
                    
                    return _SetMeshHiddenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetMeshHidden__Args
                {
				   
				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetMeshHidden(IntPtr _this, string name);
                internal delegate bool _GetMeshHidden(IntPtr _this, GetMeshHidden__Args args);
                private static _GetMeshHidden _GetMeshHiddenFunc;
                internal static _GetMeshHidden GetMeshHidden() {
                    if (_GetMeshHiddenFunc == null) {
                        _GetMeshHiddenFunc =
                            (_GetMeshHidden)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_getMeshHidden"), typeof(_GetMeshHidden));
                    }
                    
                    return _GetMeshHiddenFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct ComputeShapeBounds__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate Box3F.InternalStruct _ComputeShapeBounds(IntPtr _this);
                internal delegate Box3F.InternalStruct _ComputeShapeBounds(IntPtr _this, ComputeShapeBounds__Args args);
                private static _ComputeShapeBounds _ComputeShapeBoundsFunc;
                internal static _ComputeShapeBounds ComputeShapeBounds() {
                    if (_ComputeShapeBoundsFunc == null) {
                        _ComputeShapeBoundsFunc =
                            (_ComputeShapeBounds)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_computeShapeBounds"), typeof(_ComputeShapeBounds));
                    }
                    
                    return _ComputeShapeBoundsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct UpdateNodeTransforms__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _UpdateNodeTransforms(IntPtr _this);
                internal delegate void _UpdateNodeTransforms(IntPtr _this, UpdateNodeTransforms__Args args);
                private static _UpdateNodeTransforms _UpdateNodeTransformsFunc;
                internal static _UpdateNodeTransforms UpdateNodeTransforms() {
                    if (_UpdateNodeTransformsFunc == null) {
                        _UpdateNodeTransformsFunc =
                            (_UpdateNodeTransforms)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_updateNodeTransforms"), typeof(_UpdateNodeTransforms));
                    }
                    
                    return _UpdateNodeTransformsFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RefreshShape__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _RefreshShape(IntPtr _this);
                internal delegate void _RefreshShape(IntPtr _this, RefreshShape__Args args);
                private static _RefreshShape _RefreshShapeFunc;
                internal static _RefreshShape RefreshShape() {
                    if (_RefreshShapeFunc == null) {
                        _RefreshShapeFunc =
                            (_RefreshShape)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_refreshShape"), typeof(_RefreshShape));
                    }
                    
                    return _RefreshShapeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct FitToShape__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _FitToShape(IntPtr _this);
                internal delegate void _FitToShape(IntPtr _this, FitToShape__Args args);
                private static _FitToShape _FitToShapeFunc;
                internal static _FitToShape FitToShape() {
                    if (_FitToShapeFunc == null) {
                        _FitToShapeFunc =
                            (_FitToShape)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_fitToShape"), typeof(_FitToShape));
                    }
                    
                    return _FitToShapeFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetModel__Args
                {
				   
				   internal string shapePath;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _SetModel(IntPtr _this, string shapePath);
                internal delegate bool _SetModel(IntPtr _this, SetModel__Args args);
                private static _SetModel _SetModelFunc;
                internal static _SetModel SetModel() {
                    if (_SetModelFunc == null) {
                        _SetModelFunc =
                            (_SetModel)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setModel"), typeof(_SetModel));
                    }
                    
                    return _SetModelFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct SetOrbitPos__Args
                {
				   
				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _SetOrbitPos(IntPtr _this, IntPtr pos);
                internal delegate void _SetOrbitPos(IntPtr _this, SetOrbitPos__Args args);
                private static _SetOrbitPos _SetOrbitPosFunc;
                internal static _SetOrbitPos SetOrbitPos() {
                    if (_SetOrbitPosFunc == null) {
                        _SetOrbitPosFunc =
                            (_SetOrbitPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiShapeEdPreview_setOrbitPos"), typeof(_SetOrbitPos));
                    }
                    
                    return _SetOrbitPosFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct OnThreadPosChanged__Args
                {
				   
				   internal float pos;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool inTransition;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _OnThreadPosChanged(IntPtr _this, float pos, [MarshalAs(UnmanagedType.I1)]bool inTransition);
                internal delegate void _OnThreadPosChanged(IntPtr _this, OnThreadPosChanged__Args args);
                private static _OnThreadPosChanged _OnThreadPosChangedFunc;
                internal static _OnThreadPosChanged OnThreadPosChanged() {
                    if (_OnThreadPosChangedFunc == null) {
                        _OnThreadPosChangedFunc =
                            (_OnThreadPosChanged)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbGuiShapeEdPreview_onThreadPosChanged"), typeof(_OnThreadPosChanged));
                    }
                    
                    return _OnThreadPosChangedFunc;
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
                                    "fnGuiShapeEdPreview_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiShapeEdPreview_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void UnmountAll() {
        
                     InternalUnsafeMethods.UnmountAll__Args _args = new InternalUnsafeMethods.UnmountAll__Args() {
                     };
                     InternalUnsafeMethods.UnmountAll()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void UnmountShape(int slot) {
        
                                          InternalUnsafeMethods.UnmountShape__Args _args = new InternalUnsafeMethods.UnmountShape__Args() {
                        slot = slot,
                     };
                     InternalUnsafeMethods.UnmountShape()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetMountThreadDir(int slot, float dir) {
        
                                                               InternalUnsafeMethods.SetMountThreadDir__Args _args = new InternalUnsafeMethods.SetMountThreadDir__Args() {
                        slot = slot,
                        dir = dir,
                     };
                     InternalUnsafeMethods.SetMountThreadDir()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public float GetMountThreadDir(int slot) {
        
                                          InternalUnsafeMethods.GetMountThreadDir__Args _args = new InternalUnsafeMethods.GetMountThreadDir__Args() {
                        slot = slot,
                     };
                     float _engineResult = InternalUnsafeMethods.GetMountThreadDir()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetMountThreadPos(int slot, float pos) {
        
                                                               InternalUnsafeMethods.SetMountThreadPos__Args _args = new InternalUnsafeMethods.SetMountThreadPos__Args() {
                        slot = slot,
                        pos = pos,
                     };
                     InternalUnsafeMethods.SetMountThreadPos()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public float GetMountThreadPos(int slot) {
        
                                          InternalUnsafeMethods.GetMountThreadPos__Args _args = new InternalUnsafeMethods.GetMountThreadPos__Args() {
                        slot = slot,
                     };
                     float _engineResult = InternalUnsafeMethods.GetMountThreadPos()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetMountThreadSequence(int slot, string name) {
        
                                                               InternalUnsafeMethods.SetMountThreadSequence__Args _args = new InternalUnsafeMethods.SetMountThreadSequence__Args() {
                        slot = slot,
                        name = name,
                     };
                     InternalUnsafeMethods.SetMountThreadSequence()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public string GetMountThreadSequence(int slot) {
        
                                          InternalUnsafeMethods.GetMountThreadSequence__Args _args = new InternalUnsafeMethods.GetMountThreadSequence__Args() {
                        slot = slot,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetMountThreadSequence()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetMountNode(int slot, string nodeName) {
        
                                                               InternalUnsafeMethods.SetMountNode__Args _args = new InternalUnsafeMethods.SetMountNode__Args() {
                        slot = slot,
                        nodeName = nodeName,
                     };
                     InternalUnsafeMethods.SetMountNode()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public bool MountShape(string shapePath, string nodeName, string type, int slot) {
        
                                                                                                         InternalUnsafeMethods.MountShape__Args _args = new InternalUnsafeMethods.MountShape__Args() {
                        shapePath = shapePath,
                        nodeName = nodeName,
                        type = type,
                        slot = slot,
                     };
                     bool _engineResult = InternalUnsafeMethods.MountShape()(ObjectPtr, _args);
                                                                                                                     
                     return _engineResult;
                  }
	

			
                  public void RefreshThreadSequences() {
        
                     InternalUnsafeMethods.RefreshThreadSequences__Args _args = new InternalUnsafeMethods.RefreshThreadSequences__Args() {
                     };
                     InternalUnsafeMethods.RefreshThreadSequences()(ObjectPtr, _args);
                                 
                  }
	

			
                  public string GetThreadSequence() {
        
                     InternalUnsafeMethods.GetThreadSequence__Args _args = new InternalUnsafeMethods.GetThreadSequence__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetThreadSequence()(ObjectPtr, _args);
                                 
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public void SetThreadSequence(string name, float duration = 0f, float pos = 0f, bool play = false) {
        
                                                                                                         InternalUnsafeMethods.SetThreadSequence__Args _args = new InternalUnsafeMethods.SetThreadSequence__Args() {
                        name = name,
                        duration = duration,
                        pos = pos,
                        play = play,
                     };
                     InternalUnsafeMethods.SetThreadSequence()(ObjectPtr, _args);
                                                                                                                     
                  }
	

			
                  public void SetTimeScale(float scale) {
        
                                          InternalUnsafeMethods.SetTimeScale__Args _args = new InternalUnsafeMethods.SetTimeScale__Args() {
                        scale = scale,
                     };
                     InternalUnsafeMethods.SetTimeScale()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public int GetThreadCount() {
        
                     InternalUnsafeMethods.GetThreadCount__Args _args = new InternalUnsafeMethods.GetThreadCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetThreadCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public void RemoveThread(int slot) {
        
                                          InternalUnsafeMethods.RemoveThread__Args _args = new InternalUnsafeMethods.RemoveThread__Args() {
                        slot = slot,
                     };
                     InternalUnsafeMethods.RemoveThread()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void AddThread() {
        
                     InternalUnsafeMethods.AddThread__Args _args = new InternalUnsafeMethods.AddThread__Args() {
                     };
                     InternalUnsafeMethods.AddThread()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void ExportToCollada(string path) {
        
                                          InternalUnsafeMethods.ExportToCollada__Args _args = new InternalUnsafeMethods.ExportToCollada__Args() {
                        path = path,
                     };
                     InternalUnsafeMethods.ExportToCollada()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetAllMeshesHidden(bool hidden) {
        
                                          InternalUnsafeMethods.SetAllMeshesHidden__Args _args = new InternalUnsafeMethods.SetAllMeshesHidden__Args() {
                        hidden = hidden,
                     };
                     InternalUnsafeMethods.SetAllMeshesHidden()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void SetMeshHidden(string name, bool hidden) {
        
                                                               InternalUnsafeMethods.SetMeshHidden__Args _args = new InternalUnsafeMethods.SetMeshHidden__Args() {
                        name = name,
                        hidden = hidden,
                     };
                     InternalUnsafeMethods.SetMeshHidden()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public bool GetMeshHidden(string name) {
        
                                          InternalUnsafeMethods.GetMeshHidden__Args _args = new InternalUnsafeMethods.GetMeshHidden__Args() {
                        name = name,
                     };
                     bool _engineResult = InternalUnsafeMethods.GetMeshHidden()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public Box3F ComputeShapeBounds() {
        
                     InternalUnsafeMethods.ComputeShapeBounds__Args _args = new InternalUnsafeMethods.ComputeShapeBounds__Args() {
                     };
                     Box3F.InternalStruct _engineResult = InternalUnsafeMethods.ComputeShapeBounds()(ObjectPtr, _args);
                                 
                     return new Box3F(_engineResult);
                  }
	

			
                  public void UpdateNodeTransforms() {
        
                     InternalUnsafeMethods.UpdateNodeTransforms__Args _args = new InternalUnsafeMethods.UpdateNodeTransforms__Args() {
                     };
                     InternalUnsafeMethods.UpdateNodeTransforms()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void RefreshShape() {
        
                     InternalUnsafeMethods.RefreshShape__Args _args = new InternalUnsafeMethods.RefreshShape__Args() {
                     };
                     InternalUnsafeMethods.RefreshShape()(ObjectPtr, _args);
                                 
                  }
	

			
                  public void FitToShape() {
        
                     InternalUnsafeMethods.FitToShape__Args _args = new InternalUnsafeMethods.FitToShape__Args() {
                     };
                     InternalUnsafeMethods.FitToShape()(ObjectPtr, _args);
                                 
                  }
	

			
                  public bool SetModel(string shapePath) {
        
                                          InternalUnsafeMethods.SetModel__Args _args = new InternalUnsafeMethods.SetModel__Args() {
                        shapePath = shapePath,
                     };
                     bool _engineResult = InternalUnsafeMethods.SetModel()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public void SetOrbitPos(Point3F pos) {
        
                     pos.Alloc();                     InternalUnsafeMethods.SetOrbitPos__Args _args = new InternalUnsafeMethods.SetOrbitPos__Args() {
                        pos = pos.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetOrbitPos()(ObjectPtr, _args);
                                          pos.Free();            
                  }
	

			
                  public void OnThreadPosChanged(float pos, bool inTransition) {
        
                                                               InternalUnsafeMethods.OnThreadPosChanged__Args _args = new InternalUnsafeMethods.OnThreadPosChanged__Args() {
                        pos = pos,
                        inTransition = inTransition,
                     };
                     InternalUnsafeMethods.OnThreadPosChanged()(ObjectPtr, _args);
                                                                           
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool EditSun {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("editSun"));
            set => SetFieldValue("editSun", GenericMarshal.ToString(value));
        }


        public int SelectedNode {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedNode"));
            set => SetFieldValue("selectedNode", GenericMarshal.ToString(value));
        }


        public int SelectedObject {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedObject"));
            set => SetFieldValue("selectedObject", GenericMarshal.ToString(value));
        }


        public int SelectedObjDetail {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedObjDetail"));
            set => SetFieldValue("selectedObjDetail", GenericMarshal.ToString(value));
        }


        public Point2I GridDimension {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("gridDimension"));
            set => SetFieldValue("gridDimension", GenericMarshal.ToString(value));
        }


        public bool RenderGrid {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderGrid"));
            set => SetFieldValue("renderGrid", GenericMarshal.ToString(value));
        }


        public bool RenderNodes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderNodes"));
            set => SetFieldValue("renderNodes", GenericMarshal.ToString(value));
        }


        public bool RenderGhost {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderGhost"));
            set => SetFieldValue("renderGhost", GenericMarshal.ToString(value));
        }


        public bool RenderBounds {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderBounds"));
            set => SetFieldValue("renderBounds", GenericMarshal.ToString(value));
        }


        public bool RenderObjBox {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderObjBox"));
            set => SetFieldValue("renderObjBox", GenericMarshal.ToString(value));
        }


        public bool RenderColMeshes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderColMeshes"));
            set => SetFieldValue("renderColMeshes", GenericMarshal.ToString(value));
        }


        public bool RenderMounts {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderMounts"));
            set => SetFieldValue("renderMounts", GenericMarshal.ToString(value));
        }


        public ColorI SunDiffuse {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("sunDiffuse"));
            set => SetFieldValue("sunDiffuse", GenericMarshal.ToString(value));
        }


        public ColorI SunAmbient {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("sunAmbient"));
            set => SetFieldValue("sunAmbient", GenericMarshal.ToString(value));
        }


        public float SunAngleX {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sunAngleX"));
            set => SetFieldValue("sunAngleX", GenericMarshal.ToString(value));
        }


        public float SunAngleZ {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sunAngleZ"));
            set => SetFieldValue("sunAngleZ", GenericMarshal.ToString(value));
        }


        public int ActiveThread {
            get => GenericMarshal.StringTo<int>(GetFieldValue("activeThread"));
            set => SetFieldValue("activeThread", GenericMarshal.ToString(value));
        }


        public float ThreadPos {
            get => GenericMarshal.StringTo<float>(GetFieldValue("threadPos"));
            set => SetFieldValue("threadPos", GenericMarshal.ToString(value));
        }


        public int ThreadDirection {
            get => GenericMarshal.StringTo<int>(GetFieldValue("threadDirection"));
            set => SetFieldValue("threadDirection", GenericMarshal.ToString(value));
        }


        public bool ThreadPingPong {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("threadPingPong"));
            set => SetFieldValue("threadPingPong", GenericMarshal.ToString(value));
        }


        public bool FixedDetail {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fixedDetail"));
            set => SetFieldValue("fixedDetail", GenericMarshal.ToString(value));
        }


        public float OrbitDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("orbitDist"));
            set => SetFieldValue("orbitDist", GenericMarshal.ToString(value));
        }


        public int CurrentDL {
            get => GenericMarshal.StringTo<int>(GetFieldValue("currentDL"));
            set => SetFieldValue("currentDL", GenericMarshal.ToString(value));
        }


        public int DetailSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("detailSize"));
            set => SetFieldValue("detailSize", GenericMarshal.ToString(value));
        }


        public int DetailPolys {
            get => GenericMarshal.StringTo<int>(GetFieldValue("detailPolys"));
            set => SetFieldValue("detailPolys", GenericMarshal.ToString(value));
        }


        public float PixelSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pixelSize"));
            set => SetFieldValue("pixelSize", GenericMarshal.ToString(value));
        }


        public int NumMaterials {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numMaterials"));
            set => SetFieldValue("numMaterials", GenericMarshal.ToString(value));
        }


        public int NumDrawCalls {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDrawCalls"));
            set => SetFieldValue("numDrawCalls", GenericMarshal.ToString(value));
        }


        public int NumBones {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numBones"));
            set => SetFieldValue("numBones", GenericMarshal.ToString(value));
        }


        public int NumWeights {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numWeights"));
            set => SetFieldValue("numWeights", GenericMarshal.ToString(value));
        }


        public int ColMeshes {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colMeshes"));
            set => SetFieldValue("colMeshes", GenericMarshal.ToString(value));
        }


        public int ColPolys {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colPolys"));
            set => SetFieldValue("colPolys", GenericMarshal.ToString(value));
        }


    }
}