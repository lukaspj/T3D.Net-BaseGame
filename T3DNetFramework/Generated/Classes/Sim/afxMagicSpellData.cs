using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class afxMagicSpellData : afxChoreographerData {



        public afxMagicSpellData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxMagicSpellData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public afxMagicSpellData(string pName)
            : this(pName, false) {
        }

        public afxMagicSpellData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxMagicSpellData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxMagicSpellData(SimObject pObj)
            : base(pObj) {
        }

        public afxMagicSpellData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushLingerEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushLingerEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushLingerEffect(IntPtr _this, PushLingerEffect__Args args);
                private static _PushLingerEffect _PushLingerEffectFunc;
                internal static _PushLingerEffect PushLingerEffect() {
                    if (_PushLingerEffectFunc == null) {
                        _PushLingerEffectFunc =
                            (_PushLingerEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_pushLingerEffect"), typeof(_PushLingerEffect));
                    }

                    return _PushLingerEffectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushImpactEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushImpactEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushImpactEffect(IntPtr _this, PushImpactEffect__Args args);
                private static _PushImpactEffect _PushImpactEffectFunc;
                internal static _PushImpactEffect PushImpactEffect() {
                    if (_PushImpactEffectFunc == null) {
                        _PushImpactEffectFunc =
                            (_PushImpactEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_pushImpactEffect"), typeof(_PushImpactEffect));
                    }

                    return _PushImpactEffectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushDeliveryEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushDeliveryEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushDeliveryEffect(IntPtr _this, PushDeliveryEffect__Args args);
                private static _PushDeliveryEffect _PushDeliveryEffectFunc;
                internal static _PushDeliveryEffect PushDeliveryEffect() {
                    if (_PushDeliveryEffectFunc == null) {
                        _PushDeliveryEffectFunc =
                            (_PushDeliveryEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_pushDeliveryEffect"), typeof(_PushDeliveryEffect));
                    }

                    return _PushDeliveryEffectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushLaunchEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushLaunchEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushLaunchEffect(IntPtr _this, PushLaunchEffect__Args args);
                private static _PushLaunchEffect _PushLaunchEffectFunc;
                internal static _PushLaunchEffect PushLaunchEffect() {
                    if (_PushLaunchEffectFunc == null) {
                        _PushLaunchEffectFunc =
                            (_PushLaunchEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_pushLaunchEffect"), typeof(_PushLaunchEffect));
                    }

                    return _PushLaunchEffectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushCastingEffect__Args
                {

				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushCastingEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushCastingEffect(IntPtr _this, PushCastingEffect__Args args);
                private static _PushCastingEffect _PushCastingEffectFunc;
                internal static _PushCastingEffect PushCastingEffect() {
                    if (_PushCastingEffectFunc == null) {
                        _PushCastingEffectFunc =
                            (_PushCastingEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_pushCastingEffect"), typeof(_PushCastingEffect));
                    }

                    return _PushCastingEffectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Reset__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Reset(IntPtr _this);
                internal delegate void _Reset(IntPtr _this, Reset__Args args);
                private static _Reset _ResetFunc;
                internal static _Reset Reset() {
                    if (_ResetFunc == null) {
                        _ResetFunc =
                            (_Reset)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxMagicSpellData_reset"), typeof(_Reset));
                    }

                    return _ResetFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnActivate__Args
                {

				   internal IntPtr spell;

				   internal IntPtr caster;

				   internal IntPtr target;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnActivate(IntPtr _this, IntPtr spell, IntPtr caster, IntPtr target);
                internal delegate void _OnActivate(IntPtr _this, OnActivate__Args args);
                private static _OnActivate _OnActivateFunc;
                internal static _OnActivate OnActivate() {
                    if (_OnActivateFunc == null) {
                        _OnActivateFunc =
                            (_OnActivate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onActivate"), typeof(_OnActivate));
                    }

                    return _OnActivateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnPreactivate__Args
                {

				   internal IntPtr param_holder;

				   internal IntPtr caster;

				   internal IntPtr target;

				   internal IntPtr extra;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _OnPreactivate(IntPtr _this, IntPtr param_holder, IntPtr caster, IntPtr target, IntPtr extra);
                internal delegate bool _OnPreactivate(IntPtr _this, OnPreactivate__Args args);
                private static _OnPreactivate _OnPreactivateFunc;
                internal static _OnPreactivate OnPreactivate() {
                    if (_OnPreactivateFunc == null) {
                        _OnPreactivateFunc =
                            (_OnPreactivate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onPreactivate"), typeof(_OnPreactivate));
                    }

                    return _OnPreactivateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnImpact__Args
                {

				   internal IntPtr spell;

				   internal IntPtr caster;

				   internal IntPtr impacted;

				   internal IntPtr pos;

				   internal IntPtr normal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnImpact(IntPtr _this, IntPtr spell, IntPtr caster, IntPtr impacted, IntPtr pos, IntPtr normal);
                internal delegate void _OnImpact(IntPtr _this, OnImpact__Args args);
                private static _OnImpact _OnImpactFunc;
                internal static _OnImpact OnImpact() {
                    if (_OnImpactFunc == null) {
                        _OnImpactFunc =
                            (_OnImpact)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onImpact"), typeof(_OnImpact));
                    }

                    return _OnImpactFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnLaunch__Args
                {

				   internal IntPtr spell;

				   internal IntPtr caster;

				   internal IntPtr target;

				   internal IntPtr missile;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnLaunch(IntPtr _this, IntPtr spell, IntPtr caster, IntPtr target, IntPtr missile);
                internal delegate void _OnLaunch(IntPtr _this, OnLaunch__Args args);
                private static _OnLaunch _OnLaunchFunc;
                internal static _OnLaunch OnLaunch() {
                    if (_OnLaunchFunc == null) {
                        _OnLaunchFunc =
                            (_OnLaunch)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onLaunch"), typeof(_OnLaunch));
                    }

                    return _OnLaunchFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnInterrupt__Args
                {

				   internal IntPtr spell;

				   internal IntPtr caster;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnInterrupt(IntPtr _this, IntPtr spell, IntPtr caster);
                internal delegate void _OnInterrupt(IntPtr _this, OnInterrupt__Args args);
                private static _OnInterrupt _OnInterruptFunc;
                internal static _OnInterrupt OnInterrupt() {
                    if (_OnInterruptFunc == null) {
                        _OnInterruptFunc =
                            (_OnInterrupt)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onInterrupt"), typeof(_OnInterrupt));
                    }

                    return _OnInterruptFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDeactivate__Args
                {

				   internal IntPtr spell;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDeactivate(IntPtr _this, IntPtr spell);
                internal delegate void _OnDeactivate(IntPtr _this, OnDeactivate__Args args);
                private static _OnDeactivate _OnDeactivateFunc;
                internal static _OnDeactivate OnDeactivate() {
                    if (_OnDeactivateFunc == null) {
                        _OnDeactivateFunc =
                            (_OnDeactivate)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onDeactivate"), typeof(_OnDeactivate));
                    }

                    return _OnDeactivateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDamage__Args
                {

				   internal IntPtr spell;

				   internal string label;

				   internal string flaver;

				   internal uint target_id;

				   internal float amount;

				   internal byte n;

				   internal IntPtr pos;

				   internal float ad_amount;

				   internal float radius;

				   internal float impulse;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDamage(IntPtr _this, IntPtr spell, string label, string flaver, uint target_id, float amount, byte n, IntPtr pos, float ad_amount, float radius, float impulse);
                internal delegate void _OnDamage(IntPtr _this, OnDamage__Args args);
                private static _OnDamage _OnDamageFunc;
                internal static _OnDamage OnDamage() {
                    if (_OnDamageFunc == null) {
                        _OnDamageFunc =
                            (_OnDamage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbafxMagicSpellData_onDamage"), typeof(_OnDamage));
                    }

                    return _OnDamageFunc;
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
                                    "fnafxMagicSpellData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxMagicSpellData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void PushLingerEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushLingerEffect__Args _args = new InternalUnsafeMethods.PushLingerEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushLingerEffect()(ObjectPtr, _args);

                  }



                  public void PushImpactEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushImpactEffect__Args _args = new InternalUnsafeMethods.PushImpactEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushImpactEffect()(ObjectPtr, _args);

                  }



                  public void PushDeliveryEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushDeliveryEffect__Args _args = new InternalUnsafeMethods.PushDeliveryEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushDeliveryEffect()(ObjectPtr, _args);

                  }



                  public void PushLaunchEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushLaunchEffect__Args _args = new InternalUnsafeMethods.PushLaunchEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushLaunchEffect()(ObjectPtr, _args);

                  }



                  public void PushCastingEffect(afxEffectBaseData effect) {

                                          InternalUnsafeMethods.PushCastingEffect__Args _args = new InternalUnsafeMethods.PushCastingEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushCastingEffect()(ObjectPtr, _args);

                  }



                  public void Reset() {

                     InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                     };
                     InternalUnsafeMethods.Reset()(ObjectPtr, _args);

                  }



                  public void OnActivate(afxMagicSpell spell, ShapeBase caster, SceneObject target) {

                                                                                    InternalUnsafeMethods.OnActivate__Args _args = new InternalUnsafeMethods.OnActivate__Args() {
                        spell = spell.ObjectPtr,
                        caster = caster.ObjectPtr,
                        target = target.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnActivate()(ObjectPtr, _args);

                  }



                  public bool OnPreactivate(SimObject param_holder, ShapeBase caster, SceneObject target, SimObject extra) {

                                                                                                         InternalUnsafeMethods.OnPreactivate__Args _args = new InternalUnsafeMethods.OnPreactivate__Args() {
                        param_holder = param_holder.ObjectPtr,
                        caster = caster.ObjectPtr,
                        target = target.ObjectPtr,
                        extra = extra.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.OnPreactivate()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void OnImpact(afxMagicSpell spell, ShapeBase caster, SceneObject impacted, Point3F pos, Point3F normal) {

                                                                                    pos.Alloc();                     normal.Alloc();                     InternalUnsafeMethods.OnImpact__Args _args = new InternalUnsafeMethods.OnImpact__Args() {
                        spell = spell.ObjectPtr,
                        caster = caster.ObjectPtr,
                        impacted = impacted.ObjectPtr,
                        pos = pos.internalStructPtr,
                        normal = normal.internalStructPtr,
                     };
                     InternalUnsafeMethods.OnImpact()(ObjectPtr, _args);
                                                                                                         pos.Free();                     normal.Free();
                  }



                  public void OnLaunch(afxMagicSpell spell, ShapeBase caster, SceneObject target, afxMagicMissile missile) {

                                                                                                         InternalUnsafeMethods.OnLaunch__Args _args = new InternalUnsafeMethods.OnLaunch__Args() {
                        spell = spell.ObjectPtr,
                        caster = caster.ObjectPtr,
                        target = target.ObjectPtr,
                        missile = missile.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnLaunch()(ObjectPtr, _args);

                  }



                  public void OnInterrupt(afxMagicSpell spell, ShapeBase caster) {

                                                               InternalUnsafeMethods.OnInterrupt__Args _args = new InternalUnsafeMethods.OnInterrupt__Args() {
                        spell = spell.ObjectPtr,
                        caster = caster.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnInterrupt()(ObjectPtr, _args);

                  }



                  public void OnDeactivate(afxMagicSpell spell) {

                                          InternalUnsafeMethods.OnDeactivate__Args _args = new InternalUnsafeMethods.OnDeactivate__Args() {
                        spell = spell.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnDeactivate()(ObjectPtr, _args);

                  }



                  public void OnDamage(afxMagicSpell spell, string label, string flaver, uint target_id, float amount, byte n, Point3F pos, float ad_amount, float radius, float impulse) {

                                                                                                                                                   pos.Alloc();                                                                                    InternalUnsafeMethods.OnDamage__Args _args = new InternalUnsafeMethods.OnDamage__Args() {
                        spell = spell.ObjectPtr,
                        label = label,
                        flaver = flaver,
                        target_id = target_id,
                        amount = amount,
                        n = n,
                        pos = pos.internalStructPtr,
                        ad_amount = ad_amount,
                        radius = radius,
                        impulse = impulse,
                     };
                     InternalUnsafeMethods.OnDamage()(ObjectPtr, _args);
                                                                                                                                                                        pos.Free();
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public float CastingDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("castingDur"));
            set => SetFieldValue("castingDur", GenericMarshal.ToString(value));
        }


        public int NumCastingLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numCastingLoops"));
            set => SetFieldValue("numCastingLoops", GenericMarshal.ToString(value));
        }


        public float ExtraCastingTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraCastingTime"));
            set => SetFieldValue("extraCastingTime", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddCastingEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addCastingEffect"));
            set => SetFieldValue("addCastingEffect", GenericMarshal.ToString(value));
        }


        public float DeliveryDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("deliveryDur"));
            set => SetFieldValue("deliveryDur", GenericMarshal.ToString(value));
        }


        public int NumDeliveryLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDeliveryLoops"));
            set => SetFieldValue("numDeliveryLoops", GenericMarshal.ToString(value));
        }


        public float ExtraDeliveryTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraDeliveryTime"));
            set => SetFieldValue("extraDeliveryTime", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddLaunchEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addLaunchEffect"));
            set => SetFieldValue("addLaunchEffect", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddDeliveryEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addDeliveryEffect"));
            set => SetFieldValue("addDeliveryEffect", GenericMarshal.ToString(value));
        }


        public float LingerDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lingerDur"));
            set => SetFieldValue("lingerDur", GenericMarshal.ToString(value));
        }


        public int NumLingerLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numLingerLoops"));
            set => SetFieldValue("numLingerLoops", GenericMarshal.ToString(value));
        }


        public float ExtraLingerTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraLingerTime"));
            set => SetFieldValue("extraLingerTime", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddImpactEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addImpactEffect"));
            set => SetFieldValue("addImpactEffect", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddLingerEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addLingerEffect"));
            set => SetFieldValue("addLingerEffect", GenericMarshal.ToString(value));
        }


        public bool AllowMovementInterrupts {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowMovementInterrupts"));
            set => SetFieldValue("allowMovementInterrupts", GenericMarshal.ToString(value));
        }


        public float MovementInterruptSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("movementInterruptSpeed"));
            set => SetFieldValue("movementInterruptSpeed", GenericMarshal.ToString(value));
        }


        public afxMagicMissileData Missile {
            get => GenericMarshal.StringTo<afxMagicMissileData>(GetFieldValue("missile"));
            set => SetFieldValue("missile", GenericMarshal.ToString(value));
        }


        public bool LaunchOnServerSignal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("launchOnServerSignal"));
            set => SetFieldValue("launchOnServerSignal", GenericMarshal.ToString(value));
        }


        public int PrimaryTargetTypes {
            get => GenericMarshal.StringTo<int>(GetFieldValue("primaryTargetTypes"));
            set => SetFieldValue("primaryTargetTypes", GenericMarshal.ToString(value));
        }


    }
}
