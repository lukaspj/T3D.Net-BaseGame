using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxRPGMagicSpellData : GameBaseData {



        public afxRPGMagicSpellData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxRPGMagicSpellData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxRPGMagicSpellData(string pName)
            : this(pName, false) {
        }

        public afxRPGMagicSpellData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxRPGMagicSpellData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxRPGMagicSpellData(SimObject pObj)
            : base(pObj) {
        }

        public afxRPGMagicSpellData(IntPtr pObj)
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
                                    "fnafxRPGMagicSpellData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxRPGMagicSpellData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string SpellName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spellName"));
            set => SetFieldValue("spellName", GenericMarshal.ToString(value));
        }


        public string Desc {
            get => GenericMarshal.StringTo<string>(GetFieldValue("desc"));
            set => SetFieldValue("desc", GenericMarshal.ToString(value));
        }


        public afxRPGMagicSpell_TargetType Target {
            get => GenericMarshal.StringTo<afxRPGMagicSpell_TargetType>(GetFieldValue("target"));
            set => SetFieldValue("target", GenericMarshal.ToString(value));
        }


        public float Range {
            get => GenericMarshal.StringTo<float>(GetFieldValue("range"));
            set => SetFieldValue("range", GenericMarshal.ToString(value));
        }


        public int ManaCost {
            get => GenericMarshal.StringTo<int>(GetFieldValue("manaCost"));
            set => SetFieldValue("manaCost", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<sbyte> ReagentCost {
            get => new DynamicFieldVector<sbyte>(
                    this,
                    "reagentCost",
                    8,
                    val => GenericMarshal.StringTo<sbyte>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> ReagentName {
            get => new DynamicFieldVector<string>(
                    this,
                    "reagentName",
                    8,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public float CastingDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("castingDur"));
            set => SetFieldValue("castingDur", GenericMarshal.ToString(value));
        }


        public string IconBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("iconBitmap"));
            set => SetFieldValue("iconBitmap", GenericMarshal.ToString(value));
        }


        public string SourcePack {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sourcePack"));
            set => SetFieldValue("sourcePack", GenericMarshal.ToString(value));
        }


        public bool IsPlaceholder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isPlaceholder"));
            set => SetFieldValue("isPlaceholder", GenericMarshal.ToString(value));
        }


        public sbyte FreeTargetStyle {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("freeTargetStyle"));
            set => SetFieldValue("freeTargetStyle", GenericMarshal.ToString(value));
        }


        public bool TargetOptional {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("targetOptional"));
            set => SetFieldValue("targetOptional", GenericMarshal.ToString(value));
        }


    }
}
