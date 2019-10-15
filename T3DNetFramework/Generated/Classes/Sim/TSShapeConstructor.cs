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
    public unsafe class TSShapeConstructor : SimObject {
        public TSShapeConstructor(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public TSShapeConstructor(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public TSShapeConstructor(string pName) 
            : this(pName, false) {
        }
        
        public TSShapeConstructor(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public TSShapeConstructor(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public TSShapeConstructor(SimObject pObj) 
            : base(pObj) {
        }
        
        public TSShapeConstructor(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveTrigger__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int keyframe;
                internal int state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveTrigger(IntPtr _this, RemoveTrigger__Args args);
            private static _RemoveTrigger _RemoveTriggerFunc;
            internal static _RemoveTrigger RemoveTrigger() {
                if (_RemoveTriggerFunc == null) {
                    _RemoveTriggerFunc =
                        (_RemoveTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeTrigger"), typeof(_RemoveTrigger));
                }
                
                return _RemoveTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddTrigger__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int keyframe;
                internal int state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddTrigger(IntPtr _this, AddTrigger__Args args);
            private static _AddTrigger _AddTriggerFunc;
            internal static _AddTrigger AddTrigger() {
                if (_AddTriggerFunc == null) {
                    _AddTriggerFunc =
                        (_AddTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addTrigger"), typeof(_AddTrigger));
                }
                
                return _AddTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTrigger__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTrigger(IntPtr _this, GetTrigger__Args args);
            private static _GetTrigger _GetTriggerFunc;
            internal static _GetTrigger GetTrigger() {
                if (_GetTriggerFunc == null) {
                    _GetTriggerFunc =
                        (_GetTrigger)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getTrigger"), typeof(_GetTrigger));
                }
                
                return _GetTriggerFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTriggerCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTriggerCount(IntPtr _this, GetTriggerCount__Args args);
            private static _GetTriggerCount _GetTriggerCountFunc;
            internal static _GetTriggerCount GetTriggerCount() {
                if (_GetTriggerCountFunc == null) {
                    _GetTriggerCountFunc =
                        (_GetTriggerCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getTriggerCount"), typeof(_GetTriggerCount));
                }
                
                return _GetTriggerCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveSequence__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveSequence(IntPtr _this, RemoveSequence__Args args);
            private static _RemoveSequence _RemoveSequenceFunc;
            internal static _RemoveSequence RemoveSequence() {
                if (_RemoveSequenceFunc == null) {
                    _RemoveSequenceFunc =
                        (_RemoveSequence)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeSequence"), typeof(_RemoveSequence));
                }
                
                return _RemoveSequenceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddSequence__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string source;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int start;
                internal int end;
                [MarshalAs(UnmanagedType.I1)]
                internal bool padRot;
                [MarshalAs(UnmanagedType.I1)]
                internal bool padTrans;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddSequence(IntPtr _this, AddSequence__Args args);
            private static _AddSequence _AddSequenceFunc;
            internal static _AddSequence AddSequence() {
                if (_AddSequenceFunc == null) {
                    _AddSequenceFunc =
                        (_AddSequence)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addSequence"), typeof(_AddSequence));
                }
                
                return _AddSequenceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameSequence__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RenameSequence(IntPtr _this, RenameSequence__Args args);
            private static _RenameSequence _RenameSequenceFunc;
            internal static _RenameSequence RenameSequence() {
                if (_RenameSequenceFunc == null) {
                    _RenameSequenceFunc =
                        (_RenameSequence)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_renameSequence"), typeof(_RenameSequence));
                }
                
                return _RenameSequenceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSequenceBlend__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.I1)]
                internal bool blend;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string blendSeq;
                internal int blendFrame;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetSequenceBlend(IntPtr _this, SetSequenceBlend__Args args);
            private static _SetSequenceBlend _SetSequenceBlendFunc;
            internal static _SetSequenceBlend SetSequenceBlend() {
                if (_SetSequenceBlendFunc == null) {
                    _SetSequenceBlendFunc =
                        (_SetSequenceBlend)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setSequenceBlend"), typeof(_SetSequenceBlend));
                }
                
                return _SetSequenceBlendFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceBlend__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSequenceBlend(IntPtr _this, GetSequenceBlend__Args args);
            private static _GetSequenceBlend _GetSequenceBlendFunc;
            internal static _GetSequenceBlend GetSequenceBlend() {
                if (_GetSequenceBlendFunc == null) {
                    _GetSequenceBlendFunc =
                        (_GetSequenceBlend)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceBlend"), typeof(_GetSequenceBlend));
                }
                
                return _GetSequenceBlendFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSequenceCyclic__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.I1)]
                internal bool cyclic;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetSequenceCyclic(IntPtr _this, SetSequenceCyclic__Args args);
            private static _SetSequenceCyclic _SetSequenceCyclicFunc;
            internal static _SetSequenceCyclic SetSequenceCyclic() {
                if (_SetSequenceCyclicFunc == null) {
                    _SetSequenceCyclicFunc =
                        (_SetSequenceCyclic)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setSequenceCyclic"), typeof(_SetSequenceCyclic));
                }
                
                return _SetSequenceCyclicFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceCyclic__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetSequenceCyclic(IntPtr _this, GetSequenceCyclic__Args args);
            private static _GetSequenceCyclic _GetSequenceCyclicFunc;
            internal static _GetSequenceCyclic GetSequenceCyclic() {
                if (_GetSequenceCyclicFunc == null) {
                    _GetSequenceCyclicFunc =
                        (_GetSequenceCyclic)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceCyclic"), typeof(_GetSequenceCyclic));
                }
                
                return _GetSequenceCyclicFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSequenceGroundSpeed__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal IntPtr transSpeed;
                internal IntPtr rotSpeed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetSequenceGroundSpeed(IntPtr _this, SetSequenceGroundSpeed__Args args);
            private static _SetSequenceGroundSpeed _SetSequenceGroundSpeedFunc;
            internal static _SetSequenceGroundSpeed SetSequenceGroundSpeed() {
                if (_SetSequenceGroundSpeedFunc == null) {
                    _SetSequenceGroundSpeedFunc =
                        (_SetSequenceGroundSpeed)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setSequenceGroundSpeed"), typeof(_SetSequenceGroundSpeed));
                }
                
                return _SetSequenceGroundSpeedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceGroundSpeed__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSequenceGroundSpeed(IntPtr _this, GetSequenceGroundSpeed__Args args);
            private static _GetSequenceGroundSpeed _GetSequenceGroundSpeedFunc;
            internal static _GetSequenceGroundSpeed GetSequenceGroundSpeed() {
                if (_GetSequenceGroundSpeedFunc == null) {
                    _GetSequenceGroundSpeedFunc =
                        (_GetSequenceGroundSpeed)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceGroundSpeed"), typeof(_GetSequenceGroundSpeed));
                }
                
                return _GetSequenceGroundSpeedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSequencePriority__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal float priority;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetSequencePriority(IntPtr _this, SetSequencePriority__Args args);
            private static _SetSequencePriority _SetSequencePriorityFunc;
            internal static _SetSequencePriority SetSequencePriority() {
                if (_SetSequencePriorityFunc == null) {
                    _SetSequencePriorityFunc =
                        (_SetSequencePriority)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setSequencePriority"), typeof(_SetSequencePriority));
                }
                
                return _SetSequencePriorityFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequencePriority__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSequencePriority(IntPtr _this, GetSequencePriority__Args args);
            private static _GetSequencePriority _GetSequencePriorityFunc;
            internal static _GetSequencePriority GetSequencePriority() {
                if (_GetSequencePriorityFunc == null) {
                    _GetSequencePriorityFunc =
                        (_GetSequencePriority)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequencePriority"), typeof(_GetSequencePriority));
                }
                
                return _GetSequencePriorityFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceFrameCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSequenceFrameCount(IntPtr _this, GetSequenceFrameCount__Args args);
            private static _GetSequenceFrameCount _GetSequenceFrameCountFunc;
            internal static _GetSequenceFrameCount GetSequenceFrameCount() {
                if (_GetSequenceFrameCountFunc == null) {
                    _GetSequenceFrameCountFunc =
                        (_GetSequenceFrameCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceFrameCount"), typeof(_GetSequenceFrameCount));
                }
                
                return _GetSequenceFrameCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceSource__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSequenceSource(IntPtr _this, GetSequenceSource__Args args);
            private static _GetSequenceSource _GetSequenceSourceFunc;
            internal static _GetSequenceSource GetSequenceSource() {
                if (_GetSequenceSourceFunc == null) {
                    _GetSequenceSourceFunc =
                        (_GetSequenceSource)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceSource"), typeof(_GetSequenceSource));
                }
                
                return _GetSequenceSourceFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSequenceName(IntPtr _this, GetSequenceName__Args args);
            private static _GetSequenceName _GetSequenceNameFunc;
            internal static _GetSequenceName GetSequenceName() {
                if (_GetSequenceNameFunc == null) {
                    _GetSequenceNameFunc =
                        (_GetSequenceName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceName"), typeof(_GetSequenceName));
                }
                
                return _GetSequenceNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSequenceIndex(IntPtr _this, GetSequenceIndex__Args args);
            private static _GetSequenceIndex _GetSequenceIndexFunc;
            internal static _GetSequenceIndex GetSequenceIndex() {
                if (_GetSequenceIndexFunc == null) {
                    _GetSequenceIndexFunc =
                        (_GetSequenceIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceIndex"), typeof(_GetSequenceIndex));
                }
                
                return _GetSequenceIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSequenceCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSequenceCount(IntPtr _this, GetSequenceCount__Args args);
            private static _GetSequenceCount _GetSequenceCountFunc;
            internal static _GetSequenceCount GetSequenceCount() {
                if (_GetSequenceCountFunc == null) {
                    _GetSequenceCountFunc =
                        (_GetSequenceCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getSequenceCount"), typeof(_GetSequenceCount));
                }
                
                return _GetSequenceCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveImposter__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveImposter(IntPtr _this, RemoveImposter__Args args);
            private static _RemoveImposter _RemoveImposterFunc;
            internal static _RemoveImposter RemoveImposter() {
                if (_RemoveImposterFunc == null) {
                    _RemoveImposterFunc =
                        (_RemoveImposter)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeImposter"), typeof(_RemoveImposter));
                }
                
                return _RemoveImposterFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddImposter__Args
            {
                internal int size;
                internal int equatorSteps;
                internal int polarSteps;
                internal int dl;
                internal int dim;
                [MarshalAs(UnmanagedType.I1)]
                internal bool includePoles;
                internal float polarAngle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AddImposter(IntPtr _this, AddImposter__Args args);
            private static _AddImposter _AddImposterFunc;
            internal static _AddImposter AddImposter() {
                if (_AddImposterFunc == null) {
                    _AddImposterFunc =
                        (_AddImposter)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addImposter"), typeof(_AddImposter));
                }
                
                return _AddImposterFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetImposterSettings__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetImposterSettings(IntPtr _this, GetImposterSettings__Args args);
            private static _GetImposterSettings _GetImposterSettingsFunc;
            internal static _GetImposterSettings GetImposterSettings() {
                if (_GetImposterSettingsFunc == null) {
                    _GetImposterSettingsFunc =
                        (_GetImposterSettings)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getImposterSettings"), typeof(_GetImposterSettings));
                }
                
                return _GetImposterSettingsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetImposterDetailLevel__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetImposterDetailLevel(IntPtr _this, GetImposterDetailLevel__Args args);
            private static _GetImposterDetailLevel _GetImposterDetailLevelFunc;
            internal static _GetImposterDetailLevel GetImposterDetailLevel() {
                if (_GetImposterDetailLevelFunc == null) {
                    _GetImposterDetailLevelFunc =
                        (_GetImposterDetailLevel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getImposterDetailLevel"), typeof(_GetImposterDetailLevel));
                }
                
                return _GetImposterDetailLevelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDetailLevelSize__Args
            {
                internal int index;
                internal int newSize;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _SetDetailLevelSize(IntPtr _this, SetDetailLevelSize__Args args);
            private static _SetDetailLevelSize _SetDetailLevelSizeFunc;
            internal static _SetDetailLevelSize SetDetailLevelSize() {
                if (_SetDetailLevelSizeFunc == null) {
                    _SetDetailLevelSizeFunc =
                        (_SetDetailLevelSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setDetailLevelSize"), typeof(_SetDetailLevelSize));
                }
                
                return _SetDetailLevelSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveDetailLevel__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveDetailLevel(IntPtr _this, RemoveDetailLevel__Args args);
            private static _RemoveDetailLevel _RemoveDetailLevelFunc;
            internal static _RemoveDetailLevel RemoveDetailLevel() {
                if (_RemoveDetailLevelFunc == null) {
                    _RemoveDetailLevelFunc =
                        (_RemoveDetailLevel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeDetailLevel"), typeof(_RemoveDetailLevel));
                }
                
                return _RemoveDetailLevelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameDetailLevel__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RenameDetailLevel(IntPtr _this, RenameDetailLevel__Args args);
            private static _RenameDetailLevel _RenameDetailLevelFunc;
            internal static _RenameDetailLevel RenameDetailLevel() {
                if (_RenameDetailLevelFunc == null) {
                    _RenameDetailLevelFunc =
                        (_RenameDetailLevel)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_renameDetailLevel"), typeof(_RenameDetailLevel));
                }
                
                return _RenameDetailLevelFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailLevelIndex__Args
            {
                internal int size;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDetailLevelIndex(IntPtr _this, GetDetailLevelIndex__Args args);
            private static _GetDetailLevelIndex _GetDetailLevelIndexFunc;
            internal static _GetDetailLevelIndex GetDetailLevelIndex() {
                if (_GetDetailLevelIndexFunc == null) {
                    _GetDetailLevelIndexFunc =
                        (_GetDetailLevelIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getDetailLevelIndex"), typeof(_GetDetailLevelIndex));
                }
                
                return _GetDetailLevelIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailLevelSize__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDetailLevelSize(IntPtr _this, GetDetailLevelSize__Args args);
            private static _GetDetailLevelSize _GetDetailLevelSizeFunc;
            internal static _GetDetailLevelSize GetDetailLevelSize() {
                if (_GetDetailLevelSizeFunc == null) {
                    _GetDetailLevelSizeFunc =
                        (_GetDetailLevelSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getDetailLevelSize"), typeof(_GetDetailLevelSize));
                }
                
                return _GetDetailLevelSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailLevelName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailLevelName(IntPtr _this, GetDetailLevelName__Args args);
            private static _GetDetailLevelName _GetDetailLevelNameFunc;
            internal static _GetDetailLevelName GetDetailLevelName() {
                if (_GetDetailLevelNameFunc == null) {
                    _GetDetailLevelNameFunc =
                        (_GetDetailLevelName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getDetailLevelName"), typeof(_GetDetailLevelName));
                }
                
                return _GetDetailLevelNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailLevelCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDetailLevelCount(IntPtr _this, GetDetailLevelCount__Args args);
            private static _GetDetailLevelCount _GetDetailLevelCountFunc;
            internal static _GetDetailLevelCount GetDetailLevelCount() {
                if (_GetDetailLevelCountFunc == null) {
                    _GetDetailLevelCountFunc =
                        (_GetDetailLevelCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getDetailLevelCount"), typeof(_GetDetailLevelCount));
                }
                
                return _GetDetailLevelCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBounds__Args
            {
                internal IntPtr bbox;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetBounds(IntPtr _this, SetBounds__Args args);
            private static _SetBounds _SetBoundsFunc;
            internal static _SetBounds SetBounds() {
                if (_SetBoundsFunc == null) {
                    _SetBoundsFunc =
                        (_SetBounds)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setBounds"), typeof(_SetBounds));
                }
                
                return _SetBoundsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBounds__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Box3F.InternalStruct _GetBounds(IntPtr _this, GetBounds__Args args);
            private static _GetBounds _GetBoundsFunc;
            internal static _GetBounds GetBounds() {
                if (_GetBoundsFunc == null) {
                    _GetBoundsFunc =
                        (_GetBounds)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getBounds"), typeof(_GetBounds));
                }
                
                return _GetBoundsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveMesh__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveMesh(IntPtr _this, RemoveMesh__Args args);
            private static _RemoveMesh _RemoveMeshFunc;
            internal static _RemoveMesh RemoveMesh() {
                if (_RemoveMeshFunc == null) {
                    _RemoveMeshFunc =
                        (_RemoveMesh)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeMesh"), typeof(_RemoveMesh));
                }
                
                return _RemoveMeshFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddMesh__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string meshName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string srcShape;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string srcMesh;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddMesh(IntPtr _this, AddMesh__Args args);
            private static _AddMesh _AddMeshFunc;
            internal static _AddMesh AddMesh() {
                if (_AddMeshFunc == null) {
                    _AddMeshFunc =
                        (_AddMesh)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addMesh"), typeof(_AddMesh));
                }
                
                return _AddMeshFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMeshMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string meshName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string matName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMeshMaterial(IntPtr _this, SetMeshMaterial__Args args);
            private static _SetMeshMaterial _SetMeshMaterialFunc;
            internal static _SetMeshMaterial SetMeshMaterial() {
                if (_SetMeshMaterialFunc == null) {
                    _SetMeshMaterialFunc =
                        (_SetMeshMaterial)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setMeshMaterial"), typeof(_SetMeshMaterial));
                }
                
                return _SetMeshMaterialFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMeshMaterial(IntPtr _this, GetMeshMaterial__Args args);
            private static _GetMeshMaterial _GetMeshMaterialFunc;
            internal static _GetMeshMaterial GetMeshMaterial() {
                if (_GetMeshMaterialFunc == null) {
                    _GetMeshMaterialFunc =
                        (_GetMeshMaterial)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getMeshMaterial"), typeof(_GetMeshMaterial));
                }
                
                return _GetMeshMaterialFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMeshType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMeshType(IntPtr _this, SetMeshType__Args args);
            private static _SetMeshType _SetMeshTypeFunc;
            internal static _SetMeshType SetMeshType() {
                if (_SetMeshTypeFunc == null) {
                    _SetMeshTypeFunc =
                        (_SetMeshType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setMeshType"), typeof(_SetMeshType));
                }
                
                return _SetMeshTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMeshType(IntPtr _this, GetMeshType__Args args);
            private static _GetMeshType _GetMeshTypeFunc;
            internal static _GetMeshType GetMeshType() {
                if (_GetMeshTypeFunc == null) {
                    _GetMeshTypeFunc =
                        (_GetMeshType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getMeshType"), typeof(_GetMeshType));
                }
                
                return _GetMeshTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMeshSize__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int size;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMeshSize(IntPtr _this, SetMeshSize__Args args);
            private static _SetMeshSize _SetMeshSizeFunc;
            internal static _SetMeshSize SetMeshSize() {
                if (_SetMeshSizeFunc == null) {
                    _SetMeshSizeFunc =
                        (_SetMeshSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setMeshSize"), typeof(_SetMeshSize));
                }
                
                return _SetMeshSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshSize__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMeshSize(IntPtr _this, GetMeshSize__Args args);
            private static _GetMeshSize _GetMeshSizeFunc;
            internal static _GetMeshSize GetMeshSize() {
                if (_GetMeshSizeFunc == null) {
                    _GetMeshSizeFunc =
                        (_GetMeshSize)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getMeshSize"), typeof(_GetMeshSize));
                }
                
                return _GetMeshSizeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMeshName(IntPtr _this, GetMeshName__Args args);
            private static _GetMeshName _GetMeshNameFunc;
            internal static _GetMeshName GetMeshName() {
                if (_GetMeshNameFunc == null) {
                    _GetMeshNameFunc =
                        (_GetMeshName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getMeshName"), typeof(_GetMeshName));
                }
                
                return _GetMeshNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMeshCount(IntPtr _this, GetMeshCount__Args args);
            private static _GetMeshCount _GetMeshCountFunc;
            internal static _GetMeshCount GetMeshCount() {
                if (_GetMeshCountFunc == null) {
                    _GetMeshCountFunc =
                        (_GetMeshCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getMeshCount"), typeof(_GetMeshCount));
                }
                
                return _GetMeshCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveObject(IntPtr _this, RemoveObject__Args args);
            private static _RemoveObject _RemoveObjectFunc;
            internal static _RemoveObject RemoveObject() {
                if (_RemoveObjectFunc == null) {
                    _RemoveObjectFunc =
                        (_RemoveObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeObject"), typeof(_RemoveObject));
                }
                
                return _RemoveObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RenameObject(IntPtr _this, RenameObject__Args args);
            private static _RenameObject _RenameObjectFunc;
            internal static _RenameObject RenameObject() {
                if (_RenameObjectFunc == null) {
                    _RenameObjectFunc =
                        (_RenameObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_renameObject"), typeof(_RenameObject));
                }
                
                return _RenameObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetObjectNode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string nodeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetObjectNode(IntPtr _this, SetObjectNode__Args args);
            private static _SetObjectNode _SetObjectNodeFunc;
            internal static _SetObjectNode SetObjectNode() {
                if (_SetObjectNodeFunc == null) {
                    _SetObjectNodeFunc =
                        (_SetObjectNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setObjectNode"), typeof(_SetObjectNode));
                }
                
                return _SetObjectNodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectNode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetObjectNode(IntPtr _this, GetObjectNode__Args args);
            private static _GetObjectNode _GetObjectNodeFunc;
            internal static _GetObjectNode GetObjectNode() {
                if (_GetObjectNodeFunc == null) {
                    _GetObjectNodeFunc =
                        (_GetObjectNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getObjectNode"), typeof(_GetObjectNode));
                }
                
                return _GetObjectNodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetObjectIndex(IntPtr _this, GetObjectIndex__Args args);
            private static _GetObjectIndex _GetObjectIndexFunc;
            internal static _GetObjectIndex GetObjectIndex() {
                if (_GetObjectIndexFunc == null) {
                    _GetObjectIndexFunc =
                        (_GetObjectIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getObjectIndex"), typeof(_GetObjectIndex));
                }
                
                return _GetObjectIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetObjectName(IntPtr _this, GetObjectName__Args args);
            private static _GetObjectName _GetObjectNameFunc;
            internal static _GetObjectName GetObjectName() {
                if (_GetObjectNameFunc == null) {
                    _GetObjectNameFunc =
                        (_GetObjectName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getObjectName"), typeof(_GetObjectName));
                }
                
                return _GetObjectNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetObjectCount(IntPtr _this, GetObjectCount__Args args);
            private static _GetObjectCount _GetObjectCountFunc;
            internal static _GetObjectCount GetObjectCount() {
                if (_GetObjectCountFunc == null) {
                    _GetObjectCountFunc =
                        (_GetObjectCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getObjectCount"), typeof(_GetObjectCount));
                }
                
                return _GetObjectCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTargetName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTargetName(IntPtr _this, GetTargetName__Args args);
            private static _GetTargetName _GetTargetNameFunc;
            internal static _GetTargetName GetTargetName() {
                if (_GetTargetNameFunc == null) {
                    _GetTargetNameFunc =
                        (_GetTargetName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getTargetName"), typeof(_GetTargetName));
                }
                
                return _GetTargetNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTargetCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTargetCount(IntPtr _this, GetTargetCount__Args args);
            private static _GetTargetCount _GetTargetCountFunc;
            internal static _GetTargetCount GetTargetCount() {
                if (_GetTargetCountFunc == null) {
                    _GetTargetCountFunc =
                        (_GetTargetCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getTargetCount"), typeof(_GetTargetCount));
                }
                
                return _GetTargetCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveNode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RemoveNode(IntPtr _this, RemoveNode__Args args);
            private static _RemoveNode _RemoveNodeFunc;
            internal static _RemoveNode RemoveNode() {
                if (_RemoveNodeFunc == null) {
                    _RemoveNodeFunc =
                        (_RemoveNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_removeNode"), typeof(_RemoveNode));
                }
                
                return _RemoveNodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddNode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string parentName;
                internal IntPtr txfm;
                [MarshalAs(UnmanagedType.I1)]
                internal bool isWorld;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddNode(IntPtr _this, AddNode__Args args);
            private static _AddNode _AddNodeFunc;
            internal static _AddNode AddNode() {
                if (_AddNodeFunc == null) {
                    _AddNodeFunc =
                        (_AddNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addNode"), typeof(_AddNode));
                }
                
                return _AddNodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameNode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RenameNode(IntPtr _this, RenameNode__Args args);
            private static _RenameNode _RenameNodeFunc;
            internal static _RenameNode RenameNode() {
                if (_RenameNodeFunc == null) {
                    _RenameNodeFunc =
                        (_RenameNode)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_renameNode"), typeof(_RenameNode));
                }
                
                return _RenameNodeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeTransform__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal IntPtr txfm;
                [MarshalAs(UnmanagedType.I1)]
                internal bool isWorld;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetNodeTransform(IntPtr _this, SetNodeTransform__Args args);
            private static _SetNodeTransform _SetNodeTransformFunc;
            internal static _SetNodeTransform SetNodeTransform() {
                if (_SetNodeTransformFunc == null) {
                    _SetNodeTransformFunc =
                        (_SetNodeTransform)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setNodeTransform"), typeof(_SetNodeTransform));
                }
                
                return _SetNodeTransformFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeTransform__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.I1)]
                internal bool isWorld;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate TransformF.InternalStruct _GetNodeTransform(IntPtr _this, GetNodeTransform__Args args);
            private static _GetNodeTransform _GetNodeTransformFunc;
            internal static _GetNodeTransform GetNodeTransform() {
                if (_GetNodeTransformFunc == null) {
                    _GetNodeTransformFunc =
                        (_GetNodeTransform)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeTransform"), typeof(_GetNodeTransform));
                }
                
                return _GetNodeTransformFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeObjectName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNodeObjectName(IntPtr _this, GetNodeObjectName__Args args);
            private static _GetNodeObjectName _GetNodeObjectNameFunc;
            internal static _GetNodeObjectName GetNodeObjectName() {
                if (_GetNodeObjectNameFunc == null) {
                    _GetNodeObjectNameFunc =
                        (_GetNodeObjectName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeObjectName"), typeof(_GetNodeObjectName));
                }
                
                return _GetNodeObjectNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeObjectCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNodeObjectCount(IntPtr _this, GetNodeObjectCount__Args args);
            private static _GetNodeObjectCount _GetNodeObjectCountFunc;
            internal static _GetNodeObjectCount GetNodeObjectCount() {
                if (_GetNodeObjectCountFunc == null) {
                    _GetNodeObjectCountFunc =
                        (_GetNodeObjectCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeObjectCount"), typeof(_GetNodeObjectCount));
                }
                
                return _GetNodeObjectCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeChildName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNodeChildName(IntPtr _this, GetNodeChildName__Args args);
            private static _GetNodeChildName _GetNodeChildNameFunc;
            internal static _GetNodeChildName GetNodeChildName() {
                if (_GetNodeChildNameFunc == null) {
                    _GetNodeChildNameFunc =
                        (_GetNodeChildName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeChildName"), typeof(_GetNodeChildName));
                }
                
                return _GetNodeChildNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeChildCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNodeChildCount(IntPtr _this, GetNodeChildCount__Args args);
            private static _GetNodeChildCount _GetNodeChildCountFunc;
            internal static _GetNodeChildCount GetNodeChildCount() {
                if (_GetNodeChildCountFunc == null) {
                    _GetNodeChildCountFunc =
                        (_GetNodeChildCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeChildCount"), typeof(_GetNodeChildCount));
                }
                
                return _GetNodeChildCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeParent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string parentName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetNodeParent(IntPtr _this, SetNodeParent__Args args);
            private static _SetNodeParent _SetNodeParentFunc;
            internal static _SetNodeParent SetNodeParent() {
                if (_SetNodeParentFunc == null) {
                    _SetNodeParentFunc =
                        (_SetNodeParent)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_setNodeParent"), typeof(_SetNodeParent));
                }
                
                return _SetNodeParentFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeParentName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNodeParentName(IntPtr _this, GetNodeParentName__Args args);
            private static _GetNodeParentName _GetNodeParentNameFunc;
            internal static _GetNodeParentName GetNodeParentName() {
                if (_GetNodeParentNameFunc == null) {
                    _GetNodeParentNameFunc =
                        (_GetNodeParentName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeParentName"), typeof(_GetNodeParentName));
                }
                
                return _GetNodeParentNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNodeName(IntPtr _this, GetNodeName__Args args);
            private static _GetNodeName _GetNodeNameFunc;
            internal static _GetNodeName GetNodeName() {
                if (_GetNodeNameFunc == null) {
                    _GetNodeNameFunc =
                        (_GetNodeName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeName"), typeof(_GetNodeName));
                }
                
                return _GetNodeNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNodeIndex(IntPtr _this, GetNodeIndex__Args args);
            private static _GetNodeIndex _GetNodeIndexFunc;
            internal static _GetNodeIndex GetNodeIndex() {
                if (_GetNodeIndexFunc == null) {
                    _GetNodeIndexFunc =
                        (_GetNodeIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeIndex"), typeof(_GetNodeIndex));
                }
                
                return _GetNodeIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNodeCount(IntPtr _this, GetNodeCount__Args args);
            private static _GetNodeCount _GetNodeCountFunc;
            internal static _GetNodeCount GetNodeCount() {
                if (_GetNodeCountFunc == null) {
                    _GetNodeCountFunc =
                        (_GetNodeCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_getNodeCount"), typeof(_GetNodeCount));
                }
                
                return _GetNodeCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct NotifyShapeChanged__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _NotifyShapeChanged(IntPtr _this, NotifyShapeChanged__Args args);
            private static _NotifyShapeChanged _NotifyShapeChangedFunc;
            internal static _NotifyShapeChanged NotifyShapeChanged() {
                if (_NotifyShapeChangedFunc == null) {
                    _NotifyShapeChangedFunc =
                        (_NotifyShapeChanged)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_notifyShapeChanged"), typeof(_NotifyShapeChanged));
                }
                
                return _NotifyShapeChangedFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct WriteChangeSet__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _WriteChangeSet(IntPtr _this, WriteChangeSet__Args args);
            private static _WriteChangeSet _WriteChangeSetFunc;
            internal static _WriteChangeSet WriteChangeSet() {
                if (_WriteChangeSetFunc == null) {
                    _WriteChangeSetFunc =
                        (_WriteChangeSet)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_writeChangeSet"), typeof(_WriteChangeSet));
                }
                
                return _WriteChangeSetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveShape__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SaveShape(IntPtr _this, SaveShape__Args args);
            private static _SaveShape _SaveShapeFunc;
            internal static _SaveShape SaveShape() {
                if (_SaveShapeFunc == null) {
                    _SaveShapeFunc =
                        (_SaveShape)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_saveShape"), typeof(_SaveShape));
                }
                
                return _SaveShapeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpShape__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpShape(IntPtr _this, DumpShape__Args args);
            private static _DumpShape _DumpShapeFunc;
            internal static _DumpShape DumpShape() {
                if (_DumpShapeFunc == null) {
                    _DumpShapeFunc =
                        (_DumpShape)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_dumpShape"), typeof(_DumpShape));
                }
                
                return _DumpShapeFunc;
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
                                "fnTSShapeConstructor_staticGetType"), typeof(_StaticGetType));
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
                                "fnTSShapeConstructor_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnUnload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnUnload(IntPtr _this, OnUnload__Args args);
            private static _OnUnload _OnUnloadFunc;
            internal static _OnUnload OnUnload() {
                if (_OnUnloadFunc == null) {
                    _OnUnloadFunc =
                        (_OnUnload)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTSShapeConstructor_onUnload"), typeof(_OnUnload));
                }
                
                return _OnUnloadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLoad__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLoad(IntPtr _this, OnLoad__Args args);
            private static _OnLoad _OnLoadFunc;
            internal static _OnLoad OnLoad() {
                if (_OnLoadFunc == null) {
                    _OnLoadFunc =
                        (_OnLoad)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbTSShapeConstructor_onLoad"), typeof(_OnLoad));
                }
                
                return _OnLoadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddCollisionDetail__Args
            {
                internal int size;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string target;
                internal int depth;
                internal float merge;
                internal float concavity;
                internal int maxVerts;
                internal float boxMaxError;
                internal float sphereMaxError;
                internal float capsuleMaxError;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddCollisionDetail(IntPtr _this, AddCollisionDetail__Args args);
            private static _AddCollisionDetail _AddCollisionDetailFunc;
            internal static _AddCollisionDetail AddCollisionDetail() {
                if (_AddCollisionDetailFunc == null) {
                    _AddCollisionDetailFunc =
                        (_AddCollisionDetail)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addCollisionDetail"), typeof(_AddCollisionDetail));
                }
                
                return _AddCollisionDetailFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddPrimitive__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string meshName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string _params;
                internal IntPtr txfm;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string nodeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddPrimitive(IntPtr _this, AddPrimitive__Args args);
            private static _AddPrimitive _AddPrimitiveFunc;
            internal static _AddPrimitive AddPrimitive() {
                if (_AddPrimitiveFunc == null) {
                    _AddPrimitiveFunc =
                        (_AddPrimitive)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTSShapeConstructor_addPrimitive"), typeof(_AddPrimitive));
                }
                
                return _AddPrimitiveFunc;
            }
        }
        #endregion

        public bool RemoveTrigger(string name, int keyframe, int state) {
             InternalUnsafeMethods.RemoveTrigger__Args _args = new InternalUnsafeMethods.RemoveTrigger__Args() {
                name = name,
                keyframe = keyframe,
                state = state,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveTrigger()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool AddTrigger(string name, int keyframe, int state) {
             InternalUnsafeMethods.AddTrigger__Args _args = new InternalUnsafeMethods.AddTrigger__Args() {
                name = name,
                keyframe = keyframe,
                state = state,
             };
             bool _engineResult = InternalUnsafeMethods.AddTrigger()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetTrigger(string name, int index) {
             InternalUnsafeMethods.GetTrigger__Args _args = new InternalUnsafeMethods.GetTrigger__Args() {
                name = name,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTrigger()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetTriggerCount(string name) {
             InternalUnsafeMethods.GetTriggerCount__Args _args = new InternalUnsafeMethods.GetTriggerCount__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetTriggerCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RemoveSequence(string name) {
             InternalUnsafeMethods.RemoveSequence__Args _args = new InternalUnsafeMethods.RemoveSequence__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveSequence()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool AddSequence(string source, string name, int start = 0, int end = -1, bool padRot = true, bool padTrans = false) {
             InternalUnsafeMethods.AddSequence__Args _args = new InternalUnsafeMethods.AddSequence__Args() {
                source = source,
                name = name,
                start = start,
                end = end,
                padRot = padRot,
                padTrans = padTrans,
             };
             bool _engineResult = InternalUnsafeMethods.AddSequence()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RenameSequence(string oldName, string newName) {
             InternalUnsafeMethods.RenameSequence__Args _args = new InternalUnsafeMethods.RenameSequence__Args() {
                oldName = oldName,
                newName = newName,
             };
             bool _engineResult = InternalUnsafeMethods.RenameSequence()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetSequenceBlend(string name, bool blend, string blendSeq, int blendFrame) {
             InternalUnsafeMethods.SetSequenceBlend__Args _args = new InternalUnsafeMethods.SetSequenceBlend__Args() {
                name = name,
                blend = blend,
                blendSeq = blendSeq,
                blendFrame = blendFrame,
             };
             bool _engineResult = InternalUnsafeMethods.SetSequenceBlend()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetSequenceBlend(string name) {
             InternalUnsafeMethods.GetSequenceBlend__Args _args = new InternalUnsafeMethods.GetSequenceBlend__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSequenceBlend()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetSequenceCyclic(string name, bool cyclic) {
             InternalUnsafeMethods.SetSequenceCyclic__Args _args = new InternalUnsafeMethods.SetSequenceCyclic__Args() {
                name = name,
                cyclic = cyclic,
             };
             bool _engineResult = InternalUnsafeMethods.SetSequenceCyclic()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool GetSequenceCyclic(string name) {
             InternalUnsafeMethods.GetSequenceCyclic__Args _args = new InternalUnsafeMethods.GetSequenceCyclic__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.GetSequenceCyclic()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetSequenceGroundSpeed(string name, Point3F transSpeed, Point3F rotSpeed = null) {
transSpeed.Alloc();rotSpeed = rotSpeed ?? new Point3F("0 0 0");
rotSpeed.Alloc();             InternalUnsafeMethods.SetSequenceGroundSpeed__Args _args = new InternalUnsafeMethods.SetSequenceGroundSpeed__Args() {
                name = name,
                transSpeed = transSpeed.internalStructPtr,
                rotSpeed = rotSpeed.internalStructPtr,
             };
             bool _engineResult = InternalUnsafeMethods.SetSequenceGroundSpeed()(ObjectPtr, _args);
transSpeed.Free();rotSpeed.Free();             return _engineResult;
        }

        public string GetSequenceGroundSpeed(string name) {
             InternalUnsafeMethods.GetSequenceGroundSpeed__Args _args = new InternalUnsafeMethods.GetSequenceGroundSpeed__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSequenceGroundSpeed()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetSequencePriority(string name, float priority) {
             InternalUnsafeMethods.SetSequencePriority__Args _args = new InternalUnsafeMethods.SetSequencePriority__Args() {
                name = name,
                priority = priority,
             };
             bool _engineResult = InternalUnsafeMethods.SetSequencePriority()(ObjectPtr, _args);
             return _engineResult;
        }

        public float GetSequencePriority(string name) {
             InternalUnsafeMethods.GetSequencePriority__Args _args = new InternalUnsafeMethods.GetSequencePriority__Args() {
                name = name,
             };
             float _engineResult = InternalUnsafeMethods.GetSequencePriority()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetSequenceFrameCount(string name) {
             InternalUnsafeMethods.GetSequenceFrameCount__Args _args = new InternalUnsafeMethods.GetSequenceFrameCount__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetSequenceFrameCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetSequenceSource(string name) {
             InternalUnsafeMethods.GetSequenceSource__Args _args = new InternalUnsafeMethods.GetSequenceSource__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSequenceSource()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string GetSequenceName(int index) {
             InternalUnsafeMethods.GetSequenceName__Args _args = new InternalUnsafeMethods.GetSequenceName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSequenceName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetSequenceIndex(string name) {
             InternalUnsafeMethods.GetSequenceIndex__Args _args = new InternalUnsafeMethods.GetSequenceIndex__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetSequenceIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetSequenceCount() {
             InternalUnsafeMethods.GetSequenceCount__Args _args = new InternalUnsafeMethods.GetSequenceCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSequenceCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RemoveImposter() {
             InternalUnsafeMethods.RemoveImposter__Args _args = new InternalUnsafeMethods.RemoveImposter__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.RemoveImposter()(ObjectPtr, _args);
             return _engineResult;
        }

        public int AddImposter(int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle) {
             InternalUnsafeMethods.AddImposter__Args _args = new InternalUnsafeMethods.AddImposter__Args() {
                size = size,
                equatorSteps = equatorSteps,
                polarSteps = polarSteps,
                dl = dl,
                dim = dim,
                includePoles = includePoles,
                polarAngle = polarAngle,
             };
             int _engineResult = InternalUnsafeMethods.AddImposter()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetImposterSettings(int index) {
             InternalUnsafeMethods.GetImposterSettings__Args _args = new InternalUnsafeMethods.GetImposterSettings__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetImposterSettings()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetImposterDetailLevel() {
             InternalUnsafeMethods.GetImposterDetailLevel__Args _args = new InternalUnsafeMethods.GetImposterDetailLevel__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetImposterDetailLevel()(ObjectPtr, _args);
             return _engineResult;
        }

        public int SetDetailLevelSize(int index, int newSize) {
             InternalUnsafeMethods.SetDetailLevelSize__Args _args = new InternalUnsafeMethods.SetDetailLevelSize__Args() {
                index = index,
                newSize = newSize,
             };
             int _engineResult = InternalUnsafeMethods.SetDetailLevelSize()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RemoveDetailLevel(int index) {
             InternalUnsafeMethods.RemoveDetailLevel__Args _args = new InternalUnsafeMethods.RemoveDetailLevel__Args() {
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveDetailLevel()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RenameDetailLevel(string oldName, string newName) {
             InternalUnsafeMethods.RenameDetailLevel__Args _args = new InternalUnsafeMethods.RenameDetailLevel__Args() {
                oldName = oldName,
                newName = newName,
             };
             bool _engineResult = InternalUnsafeMethods.RenameDetailLevel()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetDetailLevelIndex(int size) {
             InternalUnsafeMethods.GetDetailLevelIndex__Args _args = new InternalUnsafeMethods.GetDetailLevelIndex__Args() {
                size = size,
             };
             int _engineResult = InternalUnsafeMethods.GetDetailLevelIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetDetailLevelSize(int index) {
             InternalUnsafeMethods.GetDetailLevelSize__Args _args = new InternalUnsafeMethods.GetDetailLevelSize__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetDetailLevelSize()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetDetailLevelName(int index) {
             InternalUnsafeMethods.GetDetailLevelName__Args _args = new InternalUnsafeMethods.GetDetailLevelName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailLevelName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetDetailLevelCount() {
             InternalUnsafeMethods.GetDetailLevelCount__Args _args = new InternalUnsafeMethods.GetDetailLevelCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDetailLevelCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetBounds(Box3F bbox) {
bbox.Alloc();             InternalUnsafeMethods.SetBounds__Args _args = new InternalUnsafeMethods.SetBounds__Args() {
                bbox = bbox.internalStructPtr,
             };
             bool _engineResult = InternalUnsafeMethods.SetBounds()(ObjectPtr, _args);
bbox.Free();             return _engineResult;
        }

        public Box3F GetBounds() {
             InternalUnsafeMethods.GetBounds__Args _args = new InternalUnsafeMethods.GetBounds__Args() {
             };
             Box3F.InternalStruct _engineResult = InternalUnsafeMethods.GetBounds()(ObjectPtr, _args);
             return new Box3F(_engineResult);
        }

        public bool RemoveMesh(string name) {
             InternalUnsafeMethods.RemoveMesh__Args _args = new InternalUnsafeMethods.RemoveMesh__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveMesh()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool AddMesh(string meshName, string srcShape, string srcMesh) {
             InternalUnsafeMethods.AddMesh__Args _args = new InternalUnsafeMethods.AddMesh__Args() {
                meshName = meshName,
                srcShape = srcShape,
                srcMesh = srcMesh,
             };
             bool _engineResult = InternalUnsafeMethods.AddMesh()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetMeshMaterial(string meshName, string matName) {
             InternalUnsafeMethods.SetMeshMaterial__Args _args = new InternalUnsafeMethods.SetMeshMaterial__Args() {
                meshName = meshName,
                matName = matName,
             };
             bool _engineResult = InternalUnsafeMethods.SetMeshMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetMeshMaterial(string name) {
             InternalUnsafeMethods.GetMeshMaterial__Args _args = new InternalUnsafeMethods.GetMeshMaterial__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMeshMaterial()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetMeshType(string name, string type) {
             InternalUnsafeMethods.SetMeshType__Args _args = new InternalUnsafeMethods.SetMeshType__Args() {
                name = name,
                type = type,
             };
             bool _engineResult = InternalUnsafeMethods.SetMeshType()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetMeshType(string name) {
             InternalUnsafeMethods.GetMeshType__Args _args = new InternalUnsafeMethods.GetMeshType__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMeshType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool SetMeshSize(string name, int size) {
             InternalUnsafeMethods.SetMeshSize__Args _args = new InternalUnsafeMethods.SetMeshSize__Args() {
                name = name,
                size = size,
             };
             bool _engineResult = InternalUnsafeMethods.SetMeshSize()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetMeshSize(string name, int index) {
             InternalUnsafeMethods.GetMeshSize__Args _args = new InternalUnsafeMethods.GetMeshSize__Args() {
                name = name,
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetMeshSize()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetMeshName(string name, int index) {
             InternalUnsafeMethods.GetMeshName__Args _args = new InternalUnsafeMethods.GetMeshName__Args() {
                name = name,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMeshName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetMeshCount(string name) {
             InternalUnsafeMethods.GetMeshCount__Args _args = new InternalUnsafeMethods.GetMeshCount__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetMeshCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RemoveObject(string name) {
             InternalUnsafeMethods.RemoveObject__Args _args = new InternalUnsafeMethods.RemoveObject__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveObject()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RenameObject(string oldName, string newName) {
             InternalUnsafeMethods.RenameObject__Args _args = new InternalUnsafeMethods.RenameObject__Args() {
                oldName = oldName,
                newName = newName,
             };
             bool _engineResult = InternalUnsafeMethods.RenameObject()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetObjectNode(string objName, string nodeName) {
             InternalUnsafeMethods.SetObjectNode__Args _args = new InternalUnsafeMethods.SetObjectNode__Args() {
                objName = objName,
                nodeName = nodeName,
             };
             bool _engineResult = InternalUnsafeMethods.SetObjectNode()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetObjectNode(string name) {
             InternalUnsafeMethods.GetObjectNode__Args _args = new InternalUnsafeMethods.GetObjectNode__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetObjectNode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetObjectIndex(string name) {
             InternalUnsafeMethods.GetObjectIndex__Args _args = new InternalUnsafeMethods.GetObjectIndex__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetObjectIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetObjectName(int index) {
             InternalUnsafeMethods.GetObjectName__Args _args = new InternalUnsafeMethods.GetObjectName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetObjectName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetObjectCount() {
             InternalUnsafeMethods.GetObjectCount__Args _args = new InternalUnsafeMethods.GetObjectCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetObjectCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetTargetName(int index) {
             InternalUnsafeMethods.GetTargetName__Args _args = new InternalUnsafeMethods.GetTargetName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTargetName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetTargetCount() {
             InternalUnsafeMethods.GetTargetCount__Args _args = new InternalUnsafeMethods.GetTargetCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetTargetCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool RemoveNode(string name) {
             InternalUnsafeMethods.RemoveNode__Args _args = new InternalUnsafeMethods.RemoveNode__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.RemoveNode()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool AddNode(string name, string parentName, TransformF txfm = null, bool isWorld = false) {
txfm = txfm ?? new TransformF("0 0 0 0 0 1 0 true");
txfm.Alloc();             InternalUnsafeMethods.AddNode__Args _args = new InternalUnsafeMethods.AddNode__Args() {
                name = name,
                parentName = parentName,
                txfm = txfm.internalStructPtr,
                isWorld = isWorld,
             };
             bool _engineResult = InternalUnsafeMethods.AddNode()(ObjectPtr, _args);
txfm.Free();             return _engineResult;
        }

        public bool RenameNode(string oldName, string newName) {
             InternalUnsafeMethods.RenameNode__Args _args = new InternalUnsafeMethods.RenameNode__Args() {
                oldName = oldName,
                newName = newName,
             };
             bool _engineResult = InternalUnsafeMethods.RenameNode()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetNodeTransform(string name, TransformF txfm, bool isWorld = false) {
txfm.Alloc();             InternalUnsafeMethods.SetNodeTransform__Args _args = new InternalUnsafeMethods.SetNodeTransform__Args() {
                name = name,
                txfm = txfm.internalStructPtr,
                isWorld = isWorld,
             };
             bool _engineResult = InternalUnsafeMethods.SetNodeTransform()(ObjectPtr, _args);
txfm.Free();             return _engineResult;
        }

        public TransformF GetNodeTransform(string name, bool isWorld = false) {
             InternalUnsafeMethods.GetNodeTransform__Args _args = new InternalUnsafeMethods.GetNodeTransform__Args() {
                name = name,
                isWorld = isWorld,
             };
             TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetNodeTransform()(ObjectPtr, _args);
             return new TransformF(_engineResult);
        }

        public string GetNodeObjectName(string name, int index) {
             InternalUnsafeMethods.GetNodeObjectName__Args _args = new InternalUnsafeMethods.GetNodeObjectName__Args() {
                name = name,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNodeObjectName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetNodeObjectCount(string name) {
             InternalUnsafeMethods.GetNodeObjectCount__Args _args = new InternalUnsafeMethods.GetNodeObjectCount__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetNodeObjectCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetNodeChildName(string name, int index) {
             InternalUnsafeMethods.GetNodeChildName__Args _args = new InternalUnsafeMethods.GetNodeChildName__Args() {
                name = name,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNodeChildName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetNodeChildCount(string name) {
             InternalUnsafeMethods.GetNodeChildCount__Args _args = new InternalUnsafeMethods.GetNodeChildCount__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetNodeChildCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool SetNodeParent(string name, string parentName) {
             InternalUnsafeMethods.SetNodeParent__Args _args = new InternalUnsafeMethods.SetNodeParent__Args() {
                name = name,
                parentName = parentName,
             };
             bool _engineResult = InternalUnsafeMethods.SetNodeParent()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetNodeParentName(string name) {
             InternalUnsafeMethods.GetNodeParentName__Args _args = new InternalUnsafeMethods.GetNodeParentName__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNodeParentName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string GetNodeName(int index) {
             InternalUnsafeMethods.GetNodeName__Args _args = new InternalUnsafeMethods.GetNodeName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNodeName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetNodeIndex(string name) {
             InternalUnsafeMethods.GetNodeIndex__Args _args = new InternalUnsafeMethods.GetNodeIndex__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetNodeIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetNodeCount() {
             InternalUnsafeMethods.GetNodeCount__Args _args = new InternalUnsafeMethods.GetNodeCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNodeCount()(ObjectPtr, _args);
             return _engineResult;
        }

        public void NotifyShapeChanged() {
             InternalUnsafeMethods.NotifyShapeChanged__Args _args = new InternalUnsafeMethods.NotifyShapeChanged__Args() {
             };
             InternalUnsafeMethods.NotifyShapeChanged()(ObjectPtr, _args);
        }

        public void WriteChangeSet() {
             InternalUnsafeMethods.WriteChangeSet__Args _args = new InternalUnsafeMethods.WriteChangeSet__Args() {
             };
             InternalUnsafeMethods.WriteChangeSet()(ObjectPtr, _args);
        }

        public void SaveShape(string filename) {
             InternalUnsafeMethods.SaveShape__Args _args = new InternalUnsafeMethods.SaveShape__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.SaveShape()(ObjectPtr, _args);
        }

        public void DumpShape(string filename = "") {
             InternalUnsafeMethods.DumpShape__Args _args = new InternalUnsafeMethods.DumpShape__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.DumpShape()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public void OnUnload() {
             InternalUnsafeMethods.OnUnload__Args _args = new InternalUnsafeMethods.OnUnload__Args() {
             };
             InternalUnsafeMethods.OnUnload()(ObjectPtr, _args);
        }

        public void OnLoad() {
             InternalUnsafeMethods.OnLoad__Args _args = new InternalUnsafeMethods.OnLoad__Args() {
             };
             InternalUnsafeMethods.OnLoad()(ObjectPtr, _args);
        }

        public bool AddCollisionDetail(int size, string type, string target, int depth = 4, float merge = 30f, float concavity = 30f, int maxVerts = 32, float boxMaxError = 0f, float sphereMaxError = 0f, float capsuleMaxError = 0f) {
             InternalUnsafeMethods.AddCollisionDetail__Args _args = new InternalUnsafeMethods.AddCollisionDetail__Args() {
                size = size,
                type = type,
                target = target,
                depth = depth,
                merge = merge,
                concavity = concavity,
                maxVerts = maxVerts,
                boxMaxError = boxMaxError,
                sphereMaxError = sphereMaxError,
                capsuleMaxError = capsuleMaxError,
             };
             bool _engineResult = InternalUnsafeMethods.AddCollisionDetail()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool AddPrimitive(string meshName, string type, string _params, TransformF txfm, string nodeName) {
txfm.Alloc();             InternalUnsafeMethods.AddPrimitive__Args _args = new InternalUnsafeMethods.AddPrimitive__Args() {
                meshName = meshName,
                type = type,
                _params = _params,
                txfm = txfm.internalStructPtr,
                nodeName = nodeName,
             };
             bool _engineResult = InternalUnsafeMethods.AddPrimitive()(ObjectPtr, _args);
txfm.Free();             return _engineResult;
        }

        public string BaseShape {
            get => GenericMarshal.StringTo<string>(GetFieldValue("baseShape"));
            set => SetFieldValue("baseShape", GenericMarshal.ToString(value));
        }

        public TSShapeConstructorUpAxis UpAxis {
            get => GenericMarshal.StringTo<TSShapeConstructorUpAxis>(GetFieldValue("upAxis"));
            set => SetFieldValue("upAxis", GenericMarshal.ToString(value));
        }

        public float Unit {
            get => GenericMarshal.StringTo<float>(GetFieldValue("unit"));
            set => SetFieldValue("unit", GenericMarshal.ToString(value));
        }

        public TSShapeConstructorLodType LodType {
            get => GenericMarshal.StringTo<TSShapeConstructorLodType>(GetFieldValue("lodType"));
            set => SetFieldValue("lodType", GenericMarshal.ToString(value));
        }

        public int SingleDetailSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("singleDetailSize"));
            set => SetFieldValue("singleDetailSize", GenericMarshal.ToString(value));
        }

        public string MatNamePrefix {
            get => GenericMarshal.StringTo<string>(GetFieldValue("matNamePrefix"));
            set => SetFieldValue("matNamePrefix", GenericMarshal.ToString(value));
        }

        public string AlwaysImport {
            get => GenericMarshal.StringTo<string>(GetFieldValue("alwaysImport"));
            set => SetFieldValue("alwaysImport", GenericMarshal.ToString(value));
        }

        public string NeverImport {
            get => GenericMarshal.StringTo<string>(GetFieldValue("neverImport"));
            set => SetFieldValue("neverImport", GenericMarshal.ToString(value));
        }

        public string AlwaysImportMesh {
            get => GenericMarshal.StringTo<string>(GetFieldValue("alwaysImportMesh"));
            set => SetFieldValue("alwaysImportMesh", GenericMarshal.ToString(value));
        }

        public string NeverImportMesh {
            get => GenericMarshal.StringTo<string>(GetFieldValue("neverImportMesh"));
            set => SetFieldValue("neverImportMesh", GenericMarshal.ToString(value));
        }

        public string NeverImportMat {
            get => GenericMarshal.StringTo<string>(GetFieldValue("neverImportMat"));
            set => SetFieldValue("neverImportMat", GenericMarshal.ToString(value));
        }

        public bool IgnoreNodeScale {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreNodeScale"));
            set => SetFieldValue("ignoreNodeScale", GenericMarshal.ToString(value));
        }

        public bool AdjustCenter {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("adjustCenter"));
            set => SetFieldValue("adjustCenter", GenericMarshal.ToString(value));
        }

        public bool AdjustFloor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("adjustFloor"));
            set => SetFieldValue("adjustFloor", GenericMarshal.ToString(value));
        }

        public bool ForceUpdateMaterials {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("forceUpdateMaterials"));
            set => SetFieldValue("forceUpdateMaterials", GenericMarshal.ToString(value));
        }

        public string Sequence {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sequence"));
            set => SetFieldValue("sequence", GenericMarshal.ToString(value));
        }
    }
}