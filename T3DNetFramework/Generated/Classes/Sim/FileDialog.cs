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
    public unsafe class FileDialog : SimObject {
        public FileDialog(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public FileDialog(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public FileDialog(string pName) 
            : this(pName, false) {
        }
        
        public FileDialog(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public FileDialog(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public FileDialog(SimObject pObj) 
            : base(pObj) {
        }
        
        public FileDialog(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Execute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Execute(IntPtr _this, Execute__Args args);
            private static _Execute _ExecuteFunc;
            internal static _Execute Execute() {
                if (_ExecuteFunc == null) {
                    _ExecuteFunc =
                        (_Execute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnFileDialog_Execute"), typeof(_Execute));
                }
                
                return _ExecuteFunc;
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
                                "fnFileDialog_staticGetType"), typeof(_StaticGetType));
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
                                "fnFileDialog_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public bool Execute() {
             InternalUnsafeMethods.Execute__Args _args = new InternalUnsafeMethods.Execute__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.Execute()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string DefaultPath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("defaultPath"));
            set => SetFieldValue("defaultPath", GenericMarshal.ToString(value));
        }

        public string DefaultFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("defaultFile"));
            set => SetFieldValue("defaultFile", GenericMarshal.ToString(value));
        }

        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }

        public string Filters {
            get => GenericMarshal.StringTo<string>(GetFieldValue("filters"));
            set => SetFieldValue("filters", GenericMarshal.ToString(value));
        }

        public string Title {
            get => GenericMarshal.StringTo<string>(GetFieldValue("title"));
            set => SetFieldValue("title", GenericMarshal.ToString(value));
        }

        public bool ChangePath {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("changePath"));
            set => SetFieldValue("changePath", GenericMarshal.ToString(value));
        }

        public bool ForceRelativePath {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("forceRelativePath"));
            set => SetFieldValue("forceRelativePath", GenericMarshal.ToString(value));
        }
    }
}