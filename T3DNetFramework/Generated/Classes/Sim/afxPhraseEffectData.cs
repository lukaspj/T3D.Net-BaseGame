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

    public unsafe class afxPhraseEffectData : GameBaseData {



        public afxPhraseEffectData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxPhraseEffectData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxPhraseEffectData(string pName) 
            : this(pName, false) {
        }
        
        public afxPhraseEffectData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxPhraseEffectData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxPhraseEffectData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxPhraseEffectData(IntPtr pObj) 
            : base(pObj) {
        }
        

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}
        
        
        




        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {

	

                [StructLayout(LayoutKind.Sequential)]
                internal struct PushEffect__Args
                {
				   
				   internal IntPtr effectData;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _PushEffect(IntPtr _this, IntPtr effectData);
                internal delegate void _PushEffect(IntPtr _this, PushEffect__Args args);
                private static _PushEffect _PushEffectFunc;
                internal static _PushEffect PushEffect() {
                    if (_PushEffectFunc == null) {
                        _PushEffectFunc =
                            (_PushEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxPhraseEffectData_pushEffect"), typeof(_PushEffect));
                    }
                    
                    return _PushEffectFunc;
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
                                    "fnafxPhraseEffectData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxPhraseEffectData_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void PushEffect(afxEffectBaseData effectData) {
        
                                          InternalUnsafeMethods.PushEffect__Args _args = new InternalUnsafeMethods.PushEffect__Args() {
                        effectData = effectData.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushEffect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public float Duration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("duration"));
            set => SetFieldValue("duration", GenericMarshal.ToString(value));
        }


        public int NumLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numLoops"));
            set => SetFieldValue("numLoops", GenericMarshal.ToString(value));
        }


        public int TriggerMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("triggerMask"));
            set => SetFieldValue("triggerMask", GenericMarshal.ToString(value));
        }


        public afxPhraseEffect_MatchType MatchType {
            get => GenericMarshal.StringTo<afxPhraseEffect_MatchType>(GetFieldValue("matchType"));
            set => SetFieldValue("matchType", GenericMarshal.ToString(value));
        }


        public afxPhraseEffect_StateType MatchState {
            get => GenericMarshal.StringTo<afxPhraseEffect_StateType>(GetFieldValue("matchState"));
            set => SetFieldValue("matchState", GenericMarshal.ToString(value));
        }


        public afxPhraseEffect_PhraseType PhraseType {
            get => GenericMarshal.StringTo<afxPhraseEffect_PhraseType>(GetFieldValue("phraseType"));
            set => SetFieldValue("phraseType", GenericMarshal.ToString(value));
        }


        public bool IgnoreChoreographerTriggers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreChoreographerTriggers"));
            set => SetFieldValue("ignoreChoreographerTriggers", GenericMarshal.ToString(value));
        }


        public bool IgnoreConstraintTriggers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreConstraintTriggers"));
            set => SetFieldValue("ignoreConstraintTriggers", GenericMarshal.ToString(value));
        }


        public bool IgnorePlayerTriggers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignorePlayerTriggers"));
            set => SetFieldValue("ignorePlayerTriggers", GenericMarshal.ToString(value));
        }


        public string OnTriggerCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("onTriggerCommand"));
            set => SetFieldValue("onTriggerCommand", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addEffect"));
            set => SetFieldValue("addEffect", GenericMarshal.ToString(value));
        }


    }
}