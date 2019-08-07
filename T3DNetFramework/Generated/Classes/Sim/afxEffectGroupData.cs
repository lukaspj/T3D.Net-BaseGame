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

    public unsafe class afxEffectGroupData : afxEffectBaseData {



        public afxEffectGroupData(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public afxEffectGroupData(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public afxEffectGroupData(string pName) 
            : this(pName, false) {
        }
        
        public afxEffectGroupData(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public afxEffectGroupData(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public afxEffectGroupData(SimObject pObj) 
            : base(pObj) {
        }
        
        public afxEffectGroupData(IntPtr pObj) 
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
				   
				   internal IntPtr effect;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                
                //internal delegate void _PushEffect(IntPtr _this, IntPtr effect);
                internal delegate void _PushEffect(IntPtr _this, PushEffect__Args args);
                private static _PushEffect _PushEffectFunc;
                internal static _PushEffect PushEffect() {
                    if (_PushEffectFunc == null) {
                        _PushEffectFunc =
                            (_PushEffect)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnafxEffectGroupData_pushEffect"), typeof(_PushEffect));
                    }
                    
                    return _PushEffectFunc;
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
                                    "fnafxEffectGroupData_reset"), typeof(_Reset));
                    }
                    
                    return _ResetFunc;
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
                                    "fnafxEffectGroupData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnafxEffectGroupData_create"), typeof(_Create));
                    }
                    
                    return _CreateFunc;
                }

        }
        #endregion


			
                  public void PushEffect(afxEffectBaseData effect) {
        
                                          InternalUnsafeMethods.PushEffect__Args _args = new InternalUnsafeMethods.PushEffect__Args() {
                        effect = effect.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushEffect()(ObjectPtr, _args);
                                                      
                  }
	

			
                  public void Reset() {
        
                     InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
                     };
                     InternalUnsafeMethods.Reset()(ObjectPtr, _args);
                                 
                  }
	

			
                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
            
                     return new EngineTypeInfo(_engineResult);
                  }
	





        public bool GroupEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("groupEnabled"));
            set => SetFieldValue("groupEnabled", GenericMarshal.ToString(value));
        }


        public int Count {
            get => GenericMarshal.StringTo<int>(GetFieldValue("count"));
            set => SetFieldValue("count", GenericMarshal.ToString(value));
        }


        public sbyte IndexOffset {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("indexOffset"));
            set => SetFieldValue("indexOffset", GenericMarshal.ToString(value));
        }


        public bool AssignIndices {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("assignIndices"));
            set => SetFieldValue("assignIndices", GenericMarshal.ToString(value));
        }


        public float Delay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("delay"));
            set => SetFieldValue("delay", GenericMarshal.ToString(value));
        }


        public float Lifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }


        public float FadeInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        public float FadeOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }


        public afxEffectBaseData AddEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addEffect"));
            set => SetFieldValue("addEffect", GenericMarshal.ToString(value));
        }


    }
}