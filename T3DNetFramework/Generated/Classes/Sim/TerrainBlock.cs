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
    public unsafe class TerrainBlock : SceneObject {
        public TerrainBlock(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public TerrainBlock(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public TerrainBlock(string pName) 
            : this(pName, false) {
        }
        
        public TerrainBlock(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public TerrainBlock(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public TerrainBlock(SimObject pObj) 
            : base(pObj) {
        }
        
        public TerrainBlock(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Import__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string terrainName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string heightMapFile;
                internal float metersPerPixel;
                internal float heightScale;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string opacityLayerFiles;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialsStr;
                [MarshalAs(UnmanagedType.I1)]
                internal bool flipYAxis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Import(Import__Args args);
            private static _Import _ImportFunc;
            internal static _Import Import() {
                if (_ImportFunc == null) {
                    _ImportFunc =
                        (_Import)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTerrainBlock_import"), typeof(_Import));
                }
                
                return _ImportFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateNew__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string terrainName;
                internal uint resolution;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialName;
                [MarshalAs(UnmanagedType.I1)]
                internal bool genNoise;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _CreateNew(CreateNew__Args args);
            private static _CreateNew _CreateNewFunc;
            internal static _CreateNew CreateNew() {
                if (_CreateNewFunc == null) {
                    _CreateNewFunc =
                        (_CreateNew)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTerrainBlock_createNew"), typeof(_CreateNew));
                }
                
                return _CreateNewFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ExportLayerMaps__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filePrefixStr;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string format;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExportLayerMaps(IntPtr _this, ExportLayerMaps__Args args);
            private static _ExportLayerMaps _ExportLayerMapsFunc;
            internal static _ExportLayerMaps ExportLayerMaps() {
                if (_ExportLayerMapsFunc == null) {
                    _ExportLayerMapsFunc =
                        (_ExportLayerMaps)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTerrainBlock_exportLayerMaps"), typeof(_ExportLayerMaps));
                }
                
                return _ExportLayerMapsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ExportHeightMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileNameStr;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string format;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExportHeightMap(IntPtr _this, ExportHeightMap__Args args);
            private static _ExportHeightMap _ExportHeightMapFunc;
            internal static _ExportHeightMap ExportHeightMap() {
                if (_ExportHeightMapFunc == null) {
                    _ExportHeightMapFunc =
                        (_ExportHeightMap)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTerrainBlock_exportHeightMap"), typeof(_ExportHeightMap));
                }
                
                return _ExportHeightMapFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Save__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Save(IntPtr _this, Save__Args args);
            private static _Save _SaveFunc;
            internal static _Save Save() {
                if (_SaveFunc == null) {
                    _SaveFunc =
                        (_Save)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnTerrainBlock_save"), typeof(_Save));
                }
                
                return _SaveFunc;
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
                                "fnTerrainBlock_staticGetType"), typeof(_StaticGetType));
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
                                "fnTerrainBlock_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public static int Import(string terrainName, string heightMapFile, float metersPerPixel, float heightScale, string opacityLayerFiles, string materialsStr, bool flipYAxis = true) {
             InternalUnsafeMethods.Import__Args _args = new InternalUnsafeMethods.Import__Args() {
                terrainName = terrainName,
                heightMapFile = heightMapFile,
                metersPerPixel = metersPerPixel,
                heightScale = heightScale,
                opacityLayerFiles = opacityLayerFiles,
                materialsStr = materialsStr,
                flipYAxis = flipYAxis,
             };
             int _engineResult = InternalUnsafeMethods.Import()(_args);
             return _engineResult;
        }

        public static int CreateNew(string terrainName, uint resolution, string materialName, bool genNoise) {
             InternalUnsafeMethods.CreateNew__Args _args = new InternalUnsafeMethods.CreateNew__Args() {
                terrainName = terrainName,
                resolution = resolution,
                materialName = materialName,
                genNoise = genNoise,
             };
             int _engineResult = InternalUnsafeMethods.CreateNew()(_args);
             return _engineResult;
        }

        public bool ExportLayerMaps(string filePrefixStr, string format = "png") {
             InternalUnsafeMethods.ExportLayerMaps__Args _args = new InternalUnsafeMethods.ExportLayerMaps__Args() {
                filePrefixStr = filePrefixStr,
                format = format,
             };
             bool _engineResult = InternalUnsafeMethods.ExportLayerMaps()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool ExportHeightMap(string fileNameStr, string format = "png") {
             InternalUnsafeMethods.ExportHeightMap__Args _args = new InternalUnsafeMethods.ExportHeightMap__Args() {
                fileNameStr = fileNameStr,
                format = format,
             };
             bool _engineResult = InternalUnsafeMethods.ExportHeightMap()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool Save(string fileName) {
             InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.Save()(ObjectPtr, _args);
             return _engineResult;
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string TerrainFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("terrainFile"));
            set => SetFieldValue("terrainFile", GenericMarshal.ToString(value));
        }

        public bool CastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("castShadows"));
            set => SetFieldValue("castShadows", GenericMarshal.ToString(value));
        }

        public float SquareSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("squareSize"));
            set => SetFieldValue("squareSize", GenericMarshal.ToString(value));
        }

        public int BaseTexSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("baseTexSize"));
            set => SetFieldValue("baseTexSize", GenericMarshal.ToString(value));
        }

        public baseTexFormat BaseTexFormat {
            get => GenericMarshal.StringTo<baseTexFormat>(GetFieldValue("baseTexFormat"));
            set => SetFieldValue("baseTexFormat", GenericMarshal.ToString(value));
        }

        public int LightMapSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lightMapSize"));
            set => SetFieldValue("lightMapSize", GenericMarshal.ToString(value));
        }

        public int ScreenError {
            get => GenericMarshal.StringTo<int>(GetFieldValue("screenError"));
            set => SetFieldValue("screenError", GenericMarshal.ToString(value));
        }

        public bool IgnoreZodiacs {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreZodiacs"));
            set => SetFieldValue("ignoreZodiacs", GenericMarshal.ToString(value));
        }
    }
}