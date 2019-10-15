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
    public unsafe class Taml : SimObject {
        public Taml(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public Taml(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public Taml(string pName) 
            : this(pName, false) {
        }
        
        public Taml(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public Taml(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public Taml(SimObject pObj) 
            : base(pObj) {
        }
        
        public Taml(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
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
                                "fnTaml_staticGetType"), typeof(_StaticGetType));
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
                                "fnTaml_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Read__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Read(IntPtr _this, Read__Args args);
            private static _Read _ReadFunc;
            internal static _Read Read() {
                if (_ReadFunc == null) {
                    _ReadFunc =
                        (_Read)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_read"), typeof(_Read));
                }
                
                return _ReadFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Write__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Write(IntPtr _this, Write__Args args);
            private static _Write _WriteFunc;
            internal static _Write Write() {
                if (_WriteFunc == null) {
                    _WriteFunc =
                        (_Write)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_write"), typeof(_Write));
                }
                
                return _WriteFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetJSONStrict__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetJSONStrict(IntPtr _this, GetJSONStrict__Args args);
            private static _GetJSONStrict _GetJSONStrictFunc;
            internal static _GetJSONStrict GetJSONStrict() {
                if (_GetJSONStrictFunc == null) {
                    _GetJSONStrictFunc =
                        (_GetJSONStrict)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getJSONStrict"), typeof(_GetJSONStrict));
                }
                
                return _GetJSONStrictFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetJSONStrict__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool strict;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetJSONStrict(IntPtr _this, SetJSONStrict__Args args);
            private static _SetJSONStrict _SetJSONStrictFunc;
            internal static _SetJSONStrict SetJSONStrict() {
                if (_SetJSONStrictFunc == null) {
                    _SetJSONStrictFunc =
                        (_SetJSONStrict)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setJSONStrict"), typeof(_SetJSONStrict));
                }
                
                return _SetJSONStrictFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBinaryCompression__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetBinaryCompression(IntPtr _this, GetBinaryCompression__Args args);
            private static _GetBinaryCompression _GetBinaryCompressionFunc;
            internal static _GetBinaryCompression GetBinaryCompression() {
                if (_GetBinaryCompressionFunc == null) {
                    _GetBinaryCompressionFunc =
                        (_GetBinaryCompression)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getBinaryCompression"), typeof(_GetBinaryCompression));
                }
                
                return _GetBinaryCompressionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBinaryCompression__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool compressed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBinaryCompression(IntPtr _this, SetBinaryCompression__Args args);
            private static _SetBinaryCompression _SetBinaryCompressionFunc;
            internal static _SetBinaryCompression SetBinaryCompression() {
                if (_SetBinaryCompressionFunc == null) {
                    _SetBinaryCompressionFunc =
                        (_SetBinaryCompression)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setBinaryCompression"), typeof(_SetBinaryCompression));
                }
                
                return _SetBinaryCompressionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormatBinaryExtension__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAutoFormatBinaryExtension(IntPtr _this, GetAutoFormatBinaryExtension__Args args);
            private static _GetAutoFormatBinaryExtension _GetAutoFormatBinaryExtensionFunc;
            internal static _GetAutoFormatBinaryExtension GetAutoFormatBinaryExtension() {
                if (_GetAutoFormatBinaryExtensionFunc == null) {
                    _GetAutoFormatBinaryExtensionFunc =
                        (_GetAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getAutoFormatBinaryExtension"), typeof(_GetAutoFormatBinaryExtension));
                }
                
                return _GetAutoFormatBinaryExtensionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormatBinaryExtension__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string extension;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormatBinaryExtension(IntPtr _this, SetAutoFormatBinaryExtension__Args args);
            private static _SetAutoFormatBinaryExtension _SetAutoFormatBinaryExtensionFunc;
            internal static _SetAutoFormatBinaryExtension SetAutoFormatBinaryExtension() {
                if (_SetAutoFormatBinaryExtensionFunc == null) {
                    _SetAutoFormatBinaryExtensionFunc =
                        (_SetAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setAutoFormatBinaryExtension"), typeof(_SetAutoFormatBinaryExtension));
                }
                
                return _SetAutoFormatBinaryExtensionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormatXmlExtension__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAutoFormatXmlExtension(IntPtr _this, GetAutoFormatXmlExtension__Args args);
            private static _GetAutoFormatXmlExtension _GetAutoFormatXmlExtensionFunc;
            internal static _GetAutoFormatXmlExtension GetAutoFormatXmlExtension() {
                if (_GetAutoFormatXmlExtensionFunc == null) {
                    _GetAutoFormatXmlExtensionFunc =
                        (_GetAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getAutoFormatXmlExtension"), typeof(_GetAutoFormatXmlExtension));
                }
                
                return _GetAutoFormatXmlExtensionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormatXmlExtension__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string extension;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormatXmlExtension(IntPtr _this, SetAutoFormatXmlExtension__Args args);
            private static _SetAutoFormatXmlExtension _SetAutoFormatXmlExtensionFunc;
            internal static _SetAutoFormatXmlExtension SetAutoFormatXmlExtension() {
                if (_SetAutoFormatXmlExtensionFunc == null) {
                    _SetAutoFormatXmlExtensionFunc =
                        (_SetAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setAutoFormatXmlExtension"), typeof(_SetAutoFormatXmlExtension));
                }
                
                return _SetAutoFormatXmlExtensionFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProgenitorUpdate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetProgenitorUpdate(IntPtr _this, GetProgenitorUpdate__Args args);
            private static _GetProgenitorUpdate _GetProgenitorUpdateFunc;
            internal static _GetProgenitorUpdate GetProgenitorUpdate() {
                if (_GetProgenitorUpdateFunc == null) {
                    _GetProgenitorUpdateFunc =
                        (_GetProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getProgenitorUpdate"), typeof(_GetProgenitorUpdate));
                }
                
                return _GetProgenitorUpdateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetProgenitorUpdate__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool progenitorUpdate;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetProgenitorUpdate(IntPtr _this, SetProgenitorUpdate__Args args);
            private static _SetProgenitorUpdate _SetProgenitorUpdateFunc;
            internal static _SetProgenitorUpdate SetProgenitorUpdate() {
                if (_SetProgenitorUpdateFunc == null) {
                    _SetProgenitorUpdateFunc =
                        (_SetProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setProgenitorUpdate"), typeof(_SetProgenitorUpdate));
                }
                
                return _SetProgenitorUpdateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWriteDefaults__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetWriteDefaults(IntPtr _this, GetWriteDefaults__Args args);
            private static _GetWriteDefaults _GetWriteDefaultsFunc;
            internal static _GetWriteDefaults GetWriteDefaults() {
                if (_GetWriteDefaultsFunc == null) {
                    _GetWriteDefaultsFunc =
                        (_GetWriteDefaults)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getWriteDefaults"), typeof(_GetWriteDefaults));
                }
                
                return _GetWriteDefaultsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetWriteDefaults__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool writeDefaults;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetWriteDefaults(IntPtr _this, SetWriteDefaults__Args args);
            private static _SetWriteDefaults _SetWriteDefaultsFunc;
            internal static _SetWriteDefaults SetWriteDefaults() {
                if (_SetWriteDefaultsFunc == null) {
                    _SetWriteDefaultsFunc =
                        (_SetWriteDefaults)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setWriteDefaults"), typeof(_SetWriteDefaults));
                }
                
                return _SetWriteDefaultsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormat__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetAutoFormat(IntPtr _this, GetAutoFormat__Args args);
            private static _GetAutoFormat _GetAutoFormatFunc;
            internal static _GetAutoFormat GetAutoFormat() {
                if (_GetAutoFormatFunc == null) {
                    _GetAutoFormatFunc =
                        (_GetAutoFormat)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getAutoFormat"), typeof(_GetAutoFormat));
                }
                
                return _GetAutoFormatFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormat__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoFormat;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormat(IntPtr _this, SetAutoFormat__Args args);
            private static _SetAutoFormat _SetAutoFormatFunc;
            internal static _SetAutoFormat SetAutoFormat() {
                if (_SetAutoFormatFunc == null) {
                    _SetAutoFormatFunc =
                        (_SetAutoFormat)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setAutoFormat"), typeof(_SetAutoFormat));
                }
                
                return _SetAutoFormatFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFormat__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFormat(IntPtr _this, GetFormat__Args args);
            private static _GetFormat _GetFormatFunc;
            internal static _GetFormat GetFormat() {
                if (_GetFormatFunc == null) {
                    _GetFormatFunc =
                        (_GetFormat)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_getFormat"), typeof(_GetFormat));
                }
                
                return _GetFormatFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFormat__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string formatName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFormat(IntPtr _this, SetFormat__Args args);
            private static _SetFormat _SetFormatFunc;
            internal static _SetFormat SetFormat() {
                if (_SetFormatFunc == null) {
                    _SetFormatFunc =
                        (_SetFormat)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTaml_setFormat"), typeof(_SetFormat));
                }
                
                return _SetFormatFunc;
            }
        }
        #endregion

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public SimObject Read(string filename) {
             InternalUnsafeMethods.Read__Args _args = new InternalUnsafeMethods.Read__Args() {
                filename = filename,
             };
             IntPtr _engineResult = InternalUnsafeMethods.Read()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        public bool Write(SimObject obj, string filename) {
             InternalUnsafeMethods.Write__Args _args = new InternalUnsafeMethods.Write__Args() {
                obj = obj.ObjectPtr,
                filename = filename,
             };
             bool _engineResult = InternalUnsafeMethods.Write()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool GetJSONStrict() {
             InternalUnsafeMethods.GetJSONStrict__Args _args = new InternalUnsafeMethods.GetJSONStrict__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetJSONStrict()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetJSONStrict(bool strict) {
             InternalUnsafeMethods.SetJSONStrict__Args _args = new InternalUnsafeMethods.SetJSONStrict__Args() {
                strict = strict,
             };
             InternalUnsafeMethods.SetJSONStrict()(ObjectPtr, _args);
        }

        public bool GetBinaryCompression() {
             InternalUnsafeMethods.GetBinaryCompression__Args _args = new InternalUnsafeMethods.GetBinaryCompression__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetBinaryCompression()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetBinaryCompression(bool compressed) {
             InternalUnsafeMethods.SetBinaryCompression__Args _args = new InternalUnsafeMethods.SetBinaryCompression__Args() {
                compressed = compressed,
             };
             InternalUnsafeMethods.SetBinaryCompression()(ObjectPtr, _args);
        }

        public string GetAutoFormatBinaryExtension() {
             InternalUnsafeMethods.GetAutoFormatBinaryExtension__Args _args = new InternalUnsafeMethods.GetAutoFormatBinaryExtension__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAutoFormatBinaryExtension()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetAutoFormatBinaryExtension(string extension) {
             InternalUnsafeMethods.SetAutoFormatBinaryExtension__Args _args = new InternalUnsafeMethods.SetAutoFormatBinaryExtension__Args() {
                extension = extension,
             };
             InternalUnsafeMethods.SetAutoFormatBinaryExtension()(ObjectPtr, _args);
        }

        public string GetAutoFormatXmlExtension() {
             InternalUnsafeMethods.GetAutoFormatXmlExtension__Args _args = new InternalUnsafeMethods.GetAutoFormatXmlExtension__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAutoFormatXmlExtension()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetAutoFormatXmlExtension(string extension) {
             InternalUnsafeMethods.SetAutoFormatXmlExtension__Args _args = new InternalUnsafeMethods.SetAutoFormatXmlExtension__Args() {
                extension = extension,
             };
             InternalUnsafeMethods.SetAutoFormatXmlExtension()(ObjectPtr, _args);
        }

        public bool GetProgenitorUpdate() {
             InternalUnsafeMethods.GetProgenitorUpdate__Args _args = new InternalUnsafeMethods.GetProgenitorUpdate__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetProgenitorUpdate()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetProgenitorUpdate(bool progenitorUpdate) {
             InternalUnsafeMethods.SetProgenitorUpdate__Args _args = new InternalUnsafeMethods.SetProgenitorUpdate__Args() {
                progenitorUpdate = progenitorUpdate,
             };
             InternalUnsafeMethods.SetProgenitorUpdate()(ObjectPtr, _args);
        }

        public bool GetWriteDefaults() {
             InternalUnsafeMethods.GetWriteDefaults__Args _args = new InternalUnsafeMethods.GetWriteDefaults__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetWriteDefaults()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetWriteDefaults(bool writeDefaults) {
             InternalUnsafeMethods.SetWriteDefaults__Args _args = new InternalUnsafeMethods.SetWriteDefaults__Args() {
                writeDefaults = writeDefaults,
             };
             InternalUnsafeMethods.SetWriteDefaults()(ObjectPtr, _args);
        }

        public bool GetAutoFormat() {
             InternalUnsafeMethods.GetAutoFormat__Args _args = new InternalUnsafeMethods.GetAutoFormat__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetAutoFormat()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetAutoFormat(bool autoFormat) {
             InternalUnsafeMethods.SetAutoFormat__Args _args = new InternalUnsafeMethods.SetAutoFormat__Args() {
                autoFormat = autoFormat,
             };
             InternalUnsafeMethods.SetAutoFormat()(ObjectPtr, _args);
        }

        public string GetFormat() {
             InternalUnsafeMethods.GetFormat__Args _args = new InternalUnsafeMethods.GetFormat__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFormat()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void SetFormat(string formatName) {
             InternalUnsafeMethods.SetFormat__Args _args = new InternalUnsafeMethods.SetFormat__Args() {
                formatName = formatName,
             };
             InternalUnsafeMethods.SetFormat()(ObjectPtr, _args);
        }

        public _TamlFormatMode Format {
            get => GenericMarshal.StringTo<_TamlFormatMode>(GetFieldValue("Format"));
            set => SetFieldValue("Format", GenericMarshal.ToString(value));
        }

        public bool JSONStrict {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("JSONStrict"));
            set => SetFieldValue("JSONStrict", GenericMarshal.ToString(value));
        }

        public bool BinaryCompression {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("BinaryCompression"));
            set => SetFieldValue("BinaryCompression", GenericMarshal.ToString(value));
        }

        public bool WriteDefaults {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("WriteDefaults"));
            set => SetFieldValue("WriteDefaults", GenericMarshal.ToString(value));
        }

        public bool ProgenitorUpdate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ProgenitorUpdate"));
            set => SetFieldValue("ProgenitorUpdate", GenericMarshal.ToString(value));
        }

        public bool AutoFormat {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AutoFormat"));
            set => SetFieldValue("AutoFormat", GenericMarshal.ToString(value));
        }

        public string AutoFormatXmlExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatXmlExtension"));
            set => SetFieldValue("AutoFormatXmlExtension", GenericMarshal.ToString(value));
        }

        public string AutoFormatBinaryExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatBinaryExtension"));
            set => SetFieldValue("AutoFormatBinaryExtension", GenericMarshal.ToString(value));
        }

        public string AutoFormatJSONExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatJSONExtension"));
            set => SetFieldValue("AutoFormatJSONExtension", GenericMarshal.ToString(value));
        }
    }
}