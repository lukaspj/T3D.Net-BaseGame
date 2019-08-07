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

    public unsafe class ModuleDefinition : SimSet {



        public ModuleDefinition(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public ModuleDefinition(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public ModuleDefinition(string pName) 
            : this(pName, false) {
        }
        
        public ModuleDefinition(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public ModuleDefinition(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public ModuleDefinition(SimObject pObj) 
            : base(pObj) {
        }
        
        public ModuleDefinition(IntPtr pObj) 
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
                
                //internal delegate IntPtr _StaticGetType();
                internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
                private static _StaticGetType _StaticGetTypeFunc;
                internal static _StaticGetType StaticGetType() {
                    if (_StaticGetTypeFunc == null) {
                        _StaticGetTypeFunc =
                            (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_staticGetType"), typeof(_StaticGetType));
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
                                    "fnModuleDefinition_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveDependency__Args
                {
				   
				   internal string pModuleId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _RemoveDependency(IntPtr _this, string pModuleId);
                internal delegate bool _RemoveDependency(IntPtr _this, RemoveDependency__Args args);
                private static _RemoveDependency _RemoveDependencyFunc;
                internal static _RemoveDependency RemoveDependency() {
                    if (_RemoveDependencyFunc == null) {
                        _RemoveDependencyFunc =
                            (_RemoveDependency)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_removeDependency"), typeof(_RemoveDependency));
                    }
                    
                    return _RemoveDependencyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct AddDependency__Args
                {
				   
				   internal string pModuleId;
				   
				   internal uint versionId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _AddDependency(IntPtr _this, string pModuleId, uint versionId);
                internal delegate bool _AddDependency(IntPtr _this, AddDependency__Args args);
                private static _AddDependency _AddDependencyFunc;
                internal static _AddDependency AddDependency() {
                    if (_AddDependencyFunc == null) {
                        _AddDependencyFunc =
                            (_AddDependency)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_addDependency"), typeof(_AddDependency));
                    }
                    
                    return _AddDependencyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDependency__Args
                {
				   
				   internal uint dependencyIndex;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate IntPtr _GetDependency(IntPtr _this, uint dependencyIndex);
                internal delegate IntPtr _GetDependency(IntPtr _this, GetDependency__Args args);
                private static _GetDependency _GetDependencyFunc;
                internal static _GetDependency GetDependency() {
                    if (_GetDependencyFunc == null) {
                        _GetDependencyFunc =
                            (_GetDependency)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_getDependency"), typeof(_GetDependency));
                    }
                    
                    return _GetDependencyFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDependencyCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetDependencyCount(IntPtr _this);
                internal delegate int _GetDependencyCount(IntPtr _this, GetDependencyCount__Args args);
                private static _GetDependencyCount _GetDependencyCountFunc;
                internal static _GetDependencyCount GetDependencyCount() {
                    if (_GetDependencyCountFunc == null) {
                        _GetDependencyCountFunc =
                            (_GetDependencyCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_getDependencyCount"), typeof(_GetDependencyCount));
                    }
                    
                    return _GetDependencyCountFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct GetModuleManager__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate int _GetModuleManager(IntPtr _this);
                internal delegate int _GetModuleManager(IntPtr _this, GetModuleManager__Args args);
                private static _GetModuleManager _GetModuleManagerFunc;
                internal static _GetModuleManager GetModuleManager() {
                    if (_GetModuleManagerFunc == null) {
                        _GetModuleManagerFunc =
                            (_GetModuleManager)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_getModuleManager"), typeof(_GetModuleManager));
                    }
                    
                    return _GetModuleManagerFunc;
                }

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct Save__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Save(IntPtr _this);
                internal delegate bool _Save(IntPtr _this, Save__Args args);
                private static _Save _SaveFunc;
                internal static _Save Save() {
                    if (_SaveFunc == null) {
                        _SaveFunc =
                            (_Save)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnModuleDefinition_save"), typeof(_Save));
                    }
                    
                    return _SaveFunc;
                }

        }
        #endregion


			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	



			
                  public bool RemoveDependency(string pModuleId = "") {
        
                                          InternalUnsafeMethods.RemoveDependency__Args _args = new InternalUnsafeMethods.RemoveDependency__Args() {
                        pModuleId = pModuleId,
                     };
                     bool _engineResult = InternalUnsafeMethods.RemoveDependency()(ObjectPtr, _args);
                                                      
                     return _engineResult;
                  }
	

			
                  public bool AddDependency(string pModuleId = "", uint versionId = 0) {
        
                                                               InternalUnsafeMethods.AddDependency__Args _args = new InternalUnsafeMethods.AddDependency__Args() {
                        pModuleId = pModuleId,
                        versionId = versionId,
                     };
                     bool _engineResult = InternalUnsafeMethods.AddDependency()(ObjectPtr, _args);
                                                                           
                     return _engineResult;
                  }
	

			
                  public string GetDependency(uint dependencyIndex = 0) {
        
                                          InternalUnsafeMethods.GetDependency__Args _args = new InternalUnsafeMethods.GetDependency__Args() {
                        dependencyIndex = dependencyIndex,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetDependency()(ObjectPtr, _args);
                                                      
                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }
	

			
                  public int GetDependencyCount() {
        
                     InternalUnsafeMethods.GetDependencyCount__Args _args = new InternalUnsafeMethods.GetDependencyCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetDependencyCount()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public int GetModuleManager() {
        
                     InternalUnsafeMethods.GetModuleManager__Args _args = new InternalUnsafeMethods.GetModuleManager__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetModuleManager()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	

			
                  public bool Save() {
        
                     InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.Save()(ObjectPtr, _args);
                                 
                     return _engineResult;
                  }
	



        public string ModuleId {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ModuleId"));
            set => SetFieldValue("ModuleId", GenericMarshal.ToString(value));
        }


        public int VersionId {
            get => GenericMarshal.StringTo<int>(GetFieldValue("VersionId"));
            set => SetFieldValue("VersionId", GenericMarshal.ToString(value));
        }


        public int BuildId {
            get => GenericMarshal.StringTo<int>(GetFieldValue("BuildId"));
            set => SetFieldValue("BuildId", GenericMarshal.ToString(value));
        }


        public bool Enabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enabled"));
            set => SetFieldValue("enabled", GenericMarshal.ToString(value));
        }


        public bool Synchronized {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("Synchronized"));
            set => SetFieldValue("Synchronized", GenericMarshal.ToString(value));
        }


        public bool Deprecated {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("Deprecated"));
            set => SetFieldValue("Deprecated", GenericMarshal.ToString(value));
        }


        public bool CriticalMerge {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("CriticalMerge"));
            set => SetFieldValue("CriticalMerge", GenericMarshal.ToString(value));
        }


        public bool OverrideExistingObjects {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("OverrideExistingObjects"));
            set => SetFieldValue("OverrideExistingObjects", GenericMarshal.ToString(value));
        }


        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


        public string Author {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Author"));
            set => SetFieldValue("Author", GenericMarshal.ToString(value));
        }


        public string Group {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Group"));
            set => SetFieldValue("Group", GenericMarshal.ToString(value));
        }


        public string Type {
            get => GenericMarshal.StringTo<string>(GetFieldValue("type"));
            set => SetFieldValue("type", GenericMarshal.ToString(value));
        }


        public string Dependencies {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Dependencies"));
            set => SetFieldValue("Dependencies", GenericMarshal.ToString(value));
        }


        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("scriptFile"));
            set => SetFieldValue("scriptFile", GenericMarshal.ToString(value));
        }


        public string CreateFunction {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CreateFunction"));
            set => SetFieldValue("CreateFunction", GenericMarshal.ToString(value));
        }


        public string DestroyFunction {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DestroyFunction"));
            set => SetFieldValue("DestroyFunction", GenericMarshal.ToString(value));
        }


        public string AssetTagsManifest {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetTagsManifest"));
            set => SetFieldValue("AssetTagsManifest", GenericMarshal.ToString(value));
        }


        public int ScopeSet {
            get => GenericMarshal.StringTo<int>(GetFieldValue("ScopeSet"));
            set => SetFieldValue("ScopeSet", GenericMarshal.ToString(value));
        }


        public string ModulePath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ModulePath"));
            set => SetFieldValue("ModulePath", GenericMarshal.ToString(value));
        }


        public string ModuleFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ModuleFile"));
            set => SetFieldValue("ModuleFile", GenericMarshal.ToString(value));
        }


        public string ModuleFilePath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ModuleFilePath"));
            set => SetFieldValue("ModuleFilePath", GenericMarshal.ToString(value));
        }


        public string ModuleScriptFilePath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ModuleScriptFilePath"));
            set => SetFieldValue("ModuleScriptFilePath", GenericMarshal.ToString(value));
        }


        public string Signature {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Signature"));
            set => SetFieldValue("Signature", GenericMarshal.ToString(value));
        }


    }
}