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
    public unsafe class UndoAction : SimObject {
        public UndoAction(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public UndoAction(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public UndoAction(string pName) 
            : this(pName, false) {
        }
        
        public UndoAction(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public UndoAction(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public UndoAction(SimObject pObj) 
            : base(pObj) {
        }
        
        public UndoAction(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Redo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Redo(IntPtr _this, Redo__Args args);
            private static _Redo _RedoFunc;
            internal static _Redo Redo() {
                if (_RedoFunc == null) {
                    _RedoFunc =
                        (_Redo)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnUndoAction_redo"), typeof(_Redo));
                }
                
                return _RedoFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Undo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Undo(IntPtr _this, Undo__Args args);
            private static _Undo _UndoFunc;
            internal static _Undo Undo() {
                if (_UndoFunc == null) {
                    _UndoFunc =
                        (_Undo)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnUndoAction_undo"), typeof(_Undo));
                }
                
                return _UndoFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddToManager__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string undoManager;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddToManager(IntPtr _this, AddToManager__Args args);
            private static _AddToManager _AddToManagerFunc;
            internal static _AddToManager AddToManager() {
                if (_AddToManagerFunc == null) {
                    _AddToManagerFunc =
                        (_AddToManager)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnUndoAction_addToManager"), typeof(_AddToManager));
                }
                
                return _AddToManagerFunc;
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
                                "fnUndoAction_staticGetType"), typeof(_StaticGetType));
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
                                "fnUndoAction_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public void Redo() {
             InternalUnsafeMethods.Redo__Args _args = new InternalUnsafeMethods.Redo__Args() {
             };
             InternalUnsafeMethods.Redo()(ObjectPtr, _args);
        }

        public void Undo() {
             InternalUnsafeMethods.Undo__Args _args = new InternalUnsafeMethods.Undo__Args() {
             };
             InternalUnsafeMethods.Undo()(ObjectPtr, _args);
        }

        public void AddToManager(string undoManager = "") {
             InternalUnsafeMethods.AddToManager__Args _args = new InternalUnsafeMethods.AddToManager__Args() {
                undoManager = undoManager,
             };
             InternalUnsafeMethods.AddToManager()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string ActionName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("actionName"));
            set => SetFieldValue("actionName", GenericMarshal.ToString(value));
        }
    }
}