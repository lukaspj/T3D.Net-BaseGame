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
    public unsafe class GuiInspectorField : GuiControl {
        public GuiInspectorField(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiInspectorField(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiInspectorField(string pName) 
            : this(pName, false) {
        }
        
        public GuiInspectorField(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiInspectorField(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiInspectorField(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiInspectorField(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEditControl__Args
            {
                internal IntPtr editCtrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEditControl(IntPtr _this, SetEditControl__Args args);
            private static _SetEditControl _SetEditControlFunc;
            internal static _SetEditControl SetEditControl() {
                if (_SetEditControlFunc == null) {
                    _SetEditControlFunc =
                        (_SetEditControl)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_setEditControl"), typeof(_SetEditControl));
                }
                
                return _SetEditControlFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCaption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newCaption;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCaption(IntPtr _this, SetCaption__Args args);
            private static _SetCaption _SetCaptionFunc;
            internal static _SetCaption SetCaption() {
                if (_SetCaptionFunc == null) {
                    _SetCaptionFunc =
                        (_SetCaption)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_setCaption"), typeof(_SetCaption));
                }
                
                return _SetCaptionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
                if (_ResetFunc == null) {
                    _ResetFunc =
                        (_Reset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_reset"), typeof(_Reset));
                }
                
                return _ResetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetData__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetData(IntPtr _this, GetData__Args args);
            private static _GetData _GetDataFunc;
            internal static _GetData GetData() {
                if (_GetDataFunc == null) {
                    _GetDataFunc =
                        (_GetData)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_getData"), typeof(_GetData));
                }
                
                return _GetDataFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ApplyWithoutUndo__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ApplyWithoutUndo(IntPtr _this, ApplyWithoutUndo__Args args);
            private static _ApplyWithoutUndo _ApplyWithoutUndoFunc;
            internal static _ApplyWithoutUndo ApplyWithoutUndo() {
                if (_ApplyWithoutUndoFunc == null) {
                    _ApplyWithoutUndoFunc =
                        (_ApplyWithoutUndo)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_applyWithoutUndo"), typeof(_ApplyWithoutUndo));
                }
                
                return _ApplyWithoutUndoFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Apply__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newValue;
                [MarshalAs(UnmanagedType.I1)]
                internal bool callbacks;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Apply(IntPtr _this, Apply__Args args);
            private static _Apply _ApplyFunc;
            internal static _Apply Apply() {
                if (_ApplyFunc == null) {
                    _ApplyFunc =
                        (_Apply)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_apply"), typeof(_Apply));
                }
                
                return _ApplyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspectedFieldType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInspectedFieldType(IntPtr _this, GetInspectedFieldType__Args args);
            private static _GetInspectedFieldType _GetInspectedFieldTypeFunc;
            internal static _GetInspectedFieldType GetInspectedFieldType() {
                if (_GetInspectedFieldTypeFunc == null) {
                    _GetInspectedFieldTypeFunc =
                        (_GetInspectedFieldType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_getInspectedFieldType"), typeof(_GetInspectedFieldType));
                }
                
                return _GetInspectedFieldTypeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspectedFieldName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInspectedFieldName(IntPtr _this, GetInspectedFieldName__Args args);
            private static _GetInspectedFieldName _GetInspectedFieldNameFunc;
            internal static _GetInspectedFieldName GetInspectedFieldName() {
                if (_GetInspectedFieldNameFunc == null) {
                    _GetInspectedFieldNameFunc =
                        (_GetInspectedFieldName)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_getInspectedFieldName"), typeof(_GetInspectedFieldName));
                }
                
                return _GetInspectedFieldNameFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspector__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetInspector(IntPtr _this, GetInspector__Args args);
            private static _GetInspector _GetInspectorFunc;
            internal static _GetInspector GetInspector() {
                if (_GetInspectorFunc == null) {
                    _GetInspectorFunc =
                        (_GetInspector)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorField_getInspector"), typeof(_GetInspector));
                }
                
                return _GetInspectorFunc;
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
                                "fnGuiInspectorField_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiInspectorField_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void SetEditControl(GuiControl editCtrl = null) {
             InternalUnsafeMethods.SetEditControl__Args _args = new InternalUnsafeMethods.SetEditControl__Args() {
                editCtrl = editCtrl.ObjectPtr,
             };
             InternalUnsafeMethods.SetEditControl()(ObjectPtr, _args);
        }

        public void SetCaption(string newCaption) {
             InternalUnsafeMethods.SetCaption__Args _args = new InternalUnsafeMethods.SetCaption__Args() {
                newCaption = newCaption,
             };
             InternalUnsafeMethods.SetCaption()(ObjectPtr, _args);
        }

        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        public string GetData() {
             InternalUnsafeMethods.GetData__Args _args = new InternalUnsafeMethods.GetData__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetData()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void ApplyWithoutUndo(string data) {
             InternalUnsafeMethods.ApplyWithoutUndo__Args _args = new InternalUnsafeMethods.ApplyWithoutUndo__Args() {
                data = data,
             };
             InternalUnsafeMethods.ApplyWithoutUndo()(ObjectPtr, _args);
        }

        public void Apply(string newValue, bool callbacks = true) {
             InternalUnsafeMethods.Apply__Args _args = new InternalUnsafeMethods.Apply__Args() {
                newValue = newValue,
                callbacks = callbacks,
             };
             InternalUnsafeMethods.Apply()(ObjectPtr, _args);
        }

        public string GetInspectedFieldType() {
             InternalUnsafeMethods.GetInspectedFieldType__Args _args = new InternalUnsafeMethods.GetInspectedFieldType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInspectedFieldType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string GetInspectedFieldName() {
             InternalUnsafeMethods.GetInspectedFieldName__Args _args = new InternalUnsafeMethods.GetInspectedFieldName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInspectedFieldName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public int GetInspector() {
             InternalUnsafeMethods.GetInspector__Args _args = new InternalUnsafeMethods.GetInspector__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetInspector()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}