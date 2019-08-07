using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiGraphCtrl : GuiControl {



        public GuiGraphCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiGraphCtrl(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiGraphCtrl(string pName)
            : this(pName, false) {
        }

        public GuiGraphCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiGraphCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiGraphCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiGraphCtrl(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _MatchScale(IntPtr _this, ref StringVector.InternalStruct args);
                private static _MatchScale _MatchScaleFunc;
                internal static _MatchScale MatchScale() {
                    if (_MatchScaleFunc == null) {
                        _MatchScaleFunc =
                            (_MatchScale)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_matchScale"), typeof(_MatchScale));
                    }

                    return _MatchScaleFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetGraphType__Args
                {

				   internal int plotId;

				   internal int graphType;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetGraphType(IntPtr _this, int plotId, int graphType);
                internal delegate void _SetGraphType(IntPtr _this, SetGraphType__Args args);
                private static _SetGraphType _SetGraphTypeFunc;
                internal static _SetGraphType SetGraphType() {
                    if (_SetGraphTypeFunc == null) {
                        _SetGraphTypeFunc =
                            (_SetGraphType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_setGraphType"), typeof(_SetGraphType));
                    }

                    return _SetGraphTypeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveAutoPlot__Args
                {

				   internal int plotId;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _RemoveAutoPlot(IntPtr _this, int plotId);
                internal delegate void _RemoveAutoPlot(IntPtr _this, RemoveAutoPlot__Args args);
                private static _RemoveAutoPlot _RemoveAutoPlotFunc;
                internal static _RemoveAutoPlot RemoveAutoPlot() {
                    if (_RemoveAutoPlotFunc == null) {
                        _RemoveAutoPlotFunc =
                            (_RemoveAutoPlot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_removeAutoPlot"), typeof(_RemoveAutoPlot));
                    }

                    return _RemoveAutoPlotFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddAutoPlot__Args
                {

				   internal int plotId;

				   internal string variable;

				   internal int updateFrequency;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddAutoPlot(IntPtr _this, int plotId, string variable, int updateFrequency);
                internal delegate void _AddAutoPlot(IntPtr _this, AddAutoPlot__Args args);
                private static _AddAutoPlot _AddAutoPlotFunc;
                internal static _AddAutoPlot AddAutoPlot() {
                    if (_AddAutoPlotFunc == null) {
                        _AddAutoPlotFunc =
                            (_AddAutoPlot)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_addAutoPlot"), typeof(_AddAutoPlot));
                    }

                    return _AddAutoPlotFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDatum__Args
                {

				   internal int plotId;

				   internal int index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate float _GetDatum(IntPtr _this, int plotId, int index);
                internal delegate float _GetDatum(IntPtr _this, GetDatum__Args args);
                private static _GetDatum _GetDatumFunc;
                internal static _GetDatum GetDatum() {
                    if (_GetDatumFunc == null) {
                        _GetDatumFunc =
                            (_GetDatum)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_getDatum"), typeof(_GetDatum));
                    }

                    return _GetDatumFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddDatum__Args
                {

				   internal int plotId;

				   internal float value;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddDatum(IntPtr _this, int plotId, float value);
                internal delegate void _AddDatum(IntPtr _this, AddDatum__Args args);
                private static _AddDatum _AddDatumFunc;
                internal static _AddDatum AddDatum() {
                    if (_AddDatumFunc == null) {
                        _AddDatumFunc =
                            (_AddDatum)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiGraphCtrl_addDatum"), typeof(_AddDatum));
                    }

                    return _AddDatumFunc;
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
                                    "fnGuiGraphCtrl_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiGraphCtrl_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion


								public void MatchScale(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.MatchScale()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}


                  public void SetGraphType(int plotId, GuiGraphType graphType) {

                                                               InternalUnsafeMethods.SetGraphType__Args _args = new InternalUnsafeMethods.SetGraphType__Args() {
                        plotId = plotId,
                        graphType = (int)graphType,
                     };
                     InternalUnsafeMethods.SetGraphType()(ObjectPtr, _args);

                  }



                  public void RemoveAutoPlot(int plotId) {

                                          InternalUnsafeMethods.RemoveAutoPlot__Args _args = new InternalUnsafeMethods.RemoveAutoPlot__Args() {
                        plotId = plotId,
                     };
                     InternalUnsafeMethods.RemoveAutoPlot()(ObjectPtr, _args);

                  }



                  public void AddAutoPlot(int plotId, string variable, int updateFrequency) {

                                                                                    InternalUnsafeMethods.AddAutoPlot__Args _args = new InternalUnsafeMethods.AddAutoPlot__Args() {
                        plotId = plotId,
                        variable = variable,
                        updateFrequency = updateFrequency,
                     };
                     InternalUnsafeMethods.AddAutoPlot()(ObjectPtr, _args);

                  }



                  public float GetDatum(int plotId, int index) {

                                                               InternalUnsafeMethods.GetDatum__Args _args = new InternalUnsafeMethods.GetDatum__Args() {
                        plotId = plotId,
                        index = index,
                     };
                     float _engineResult = InternalUnsafeMethods.GetDatum()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void AddDatum(int plotId, float value) {

                                                               InternalUnsafeMethods.AddDatum__Args _args = new InternalUnsafeMethods.AddDatum__Args() {
                        plotId = plotId,
                        value = value,
                     };
                     InternalUnsafeMethods.AddDatum()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public float CenterY {
            get => GenericMarshal.StringTo<float>(GetFieldValue("centerY"));
            set => SetFieldValue("centerY", GenericMarshal.ToString(value));
        }


        public DynamicFieldVector<LinearColorF> PlotColor {
            get => new DynamicFieldVector<LinearColorF>(
                    this,
                    "plotColor",
                    6,
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<GuiGraphType> PlotType {
            get => new DynamicFieldVector<GuiGraphType>(
                    this,
                    "plotType",
                    6,
                    val => GenericMarshal.StringTo<GuiGraphType>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<string> PlotVariable {
            get => new DynamicFieldVector<string>(
                    this,
                    "plotVariable",
                    6,
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        public DynamicFieldVector<int> PlotInterval {
            get => new DynamicFieldVector<int>(
                    this,
                    "plotInterval",
                    6,
                    val => GenericMarshal.StringTo<int>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


    }
}
