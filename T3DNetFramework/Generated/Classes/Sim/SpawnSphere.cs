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
    public unsafe class SpawnSphere : MissionMarker {
        public SpawnSphere(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SpawnSphere(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SpawnSphere(string pName) 
            : this(pName, false) {
        }
        
        public SpawnSphere(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SpawnSphere(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SpawnSphere(SimObject pObj) 
            : base(pObj) {
        }
        
        public SpawnSphere(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SpawnObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string additionalProps;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _SpawnObject(IntPtr _this, SpawnObject__Args args);
            private static _SpawnObject _SpawnObjectFunc;
            internal static _SpawnObject SpawnObject() {
                if (_SpawnObjectFunc == null) {
                    _SpawnObjectFunc =
                        (_SpawnObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSpawnSphere_spawnObject"), typeof(_SpawnObject));
                }
                
                return _SpawnObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
            private static _OnAdd _OnAddFunc;
            internal static _OnAdd OnAdd() {
                if (_OnAddFunc == null) {
                    _OnAddFunc =
                        (_OnAdd)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbSpawnSphere_onAdd"), typeof(_OnAdd));
                }
                
                return _OnAddFunc;
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
                                "fnSpawnSphere_staticGetType"), typeof(_StaticGetType));
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
                                "fnSpawnSphere_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public int SpawnObject(string additionalProps) {
             InternalUnsafeMethods.SpawnObject__Args _args = new InternalUnsafeMethods.SpawnObject__Args() {
                additionalProps = additionalProps,
             };
             int _engineResult = InternalUnsafeMethods.SpawnObject()(ObjectPtr, _args);
             return _engineResult;
        }

        public void OnAdd(uint objectId) {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public string SpawnClass {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnClass"));
            set => SetFieldValue("spawnClass", GenericMarshal.ToString(value));
        }

        public string SpawnDatablock {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnDatablock"));
            set => SetFieldValue("spawnDatablock", GenericMarshal.ToString(value));
        }

        public string SpawnProperties {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnProperties"));
            set => SetFieldValue("spawnProperties", GenericMarshal.ToString(value));
        }

        public string SpawnScript {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnScript"));
            set => SetFieldValue("spawnScript", GenericMarshal.ToString(value));
        }

        public bool AutoSpawn {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSpawn"));
            set => SetFieldValue("autoSpawn", GenericMarshal.ToString(value));
        }

        public bool SpawnTransform {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("spawnTransform"));
            set => SetFieldValue("spawnTransform", GenericMarshal.ToString(value));
        }

        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }

        public float SphereWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sphereWeight"));
            set => SetFieldValue("sphereWeight", GenericMarshal.ToString(value));
        }

        public float IndoorWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("indoorWeight"));
            set => SetFieldValue("indoorWeight", GenericMarshal.ToString(value));
        }

        public float OutdoorWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("outdoorWeight"));
            set => SetFieldValue("outdoorWeight", GenericMarshal.ToString(value));
        }
    }
}