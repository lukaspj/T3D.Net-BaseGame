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
    public unsafe class PostEffect : SimGroup {
        public PostEffect(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public PostEffect(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public PostEffect(string pName) 
            : this(pName, false) {
        }
        
        public PostEffect(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public PostEffect(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public PostEffect(SimObject pObj) 
            : base(pObj) {
        }
        
        public PostEffect(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearShaderMacros__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearShaderMacros(IntPtr _this, ClearShaderMacros__Args args);
            private static _ClearShaderMacros _ClearShaderMacrosFunc;
            internal static _ClearShaderMacros ClearShaderMacros() {
                if (_ClearShaderMacrosFunc == null) {
                    _ClearShaderMacrosFunc =
                        (_ClearShaderMacros)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_clearShaderMacros"), typeof(_ClearShaderMacros));
                }
                
                return _ClearShaderMacrosFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveShaderMacro__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveShaderMacro(IntPtr _this, RemoveShaderMacro__Args args);
            private static _RemoveShaderMacro _RemoveShaderMacroFunc;
            internal static _RemoveShaderMacro RemoveShaderMacro() {
                if (_RemoveShaderMacroFunc == null) {
                    _RemoveShaderMacroFunc =
                        (_RemoveShaderMacro)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_removeShaderMacro"), typeof(_RemoveShaderMacro));
                }
                
                return _RemoveShaderMacroFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetShaderMacro__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetShaderMacro(IntPtr _this, SetShaderMacro__Args args);
            private static _SetShaderMacro _SetShaderMacroFunc;
            internal static _SetShaderMacro SetShaderMacro() {
                if (_SetShaderMacroFunc == null) {
                    _SetShaderMacroFunc =
                        (_SetShaderMacro)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_setShaderMacro"), typeof(_SetShaderMacro));
                }
                
                return _SetShaderMacroFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpShaderDisassembly__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _DumpShaderDisassembly(IntPtr _this, DumpShaderDisassembly__Args args);
            private static _DumpShaderDisassembly _DumpShaderDisassemblyFunc;
            internal static _DumpShaderDisassembly DumpShaderDisassembly() {
                if (_DumpShaderDisassemblyFunc == null) {
                    _DumpShaderDisassemblyFunc =
                        (_DumpShaderDisassembly)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_dumpShaderDisassembly"), typeof(_DumpShaderDisassembly));
                }
                
                return _DumpShaderDisassemblyFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAspectRatio__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetAspectRatio(IntPtr _this, GetAspectRatio__Args args);
            private static _GetAspectRatio _GetAspectRatioFunc;
            internal static _GetAspectRatio GetAspectRatio() {
                if (_GetAspectRatioFunc == null) {
                    _GetAspectRatioFunc =
                        (_GetAspectRatio)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_getAspectRatio"), typeof(_GetAspectRatio));
                }
                
                return _GetAspectRatioFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetShaderConst__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetShaderConst(IntPtr _this, SetShaderConst__Args args);
            private static _SetShaderConst _SetShaderConstFunc;
            internal static _SetShaderConst SetShaderConst() {
                if (_SetShaderConstFunc == null) {
                    _SetShaderConstFunc =
                        (_SetShaderConst)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_setShaderConst"), typeof(_SetShaderConst));
                }
                
                return _SetShaderConstFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTexture__Args
            {
                internal int index;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTexture(IntPtr _this, SetTexture__Args args);
            private static _SetTexture _SetTextureFunc;
            internal static _SetTexture SetTexture() {
                if (_SetTextureFunc == null) {
                    _SetTextureFunc =
                        (_SetTexture)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_setTexture"), typeof(_SetTexture));
                }
                
                return _SetTextureFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct IsEnabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsEnabled(IntPtr _this, IsEnabled__Args args);
            private static _IsEnabled _IsEnabledFunc;
            internal static _IsEnabled IsEnabled() {
                if (_IsEnabledFunc == null) {
                    _IsEnabledFunc =
                        (_IsEnabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_isEnabled"), typeof(_IsEnabled));
                }
                
                return _IsEnabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Toggle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Toggle(IntPtr _this, Toggle__Args args);
            private static _Toggle _ToggleFunc;
            internal static _Toggle Toggle() {
                if (_ToggleFunc == null) {
                    _ToggleFunc =
                        (_Toggle)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_toggle"), typeof(_Toggle));
                }
                
                return _ToggleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Disable__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Disable(IntPtr _this, Disable__Args args);
            private static _Disable _DisableFunc;
            internal static _Disable Disable() {
                if (_DisableFunc == null) {
                    _DisableFunc =
                        (_Disable)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_disable"), typeof(_Disable));
                }
                
                return _DisableFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Enable__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Enable(IntPtr _this, Enable__Args args);
            private static _Enable _EnableFunc;
            internal static _Enable Enable() {
                if (_EnableFunc == null) {
                    _EnableFunc =
                        (_Enable)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_enable"), typeof(_Enable));
                }
                
                return _EnableFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Reload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reload(IntPtr _this, Reload__Args args);
            private static _Reload _ReloadFunc;
            internal static _Reload Reload() {
                if (_ReloadFunc == null) {
                    _ReloadFunc =
                        (_Reload)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnPostEffect_reload"), typeof(_Reload));
                }
                
                return _ReloadFunc;
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
                                "fnPostEffect_staticGetType"), typeof(_StaticGetType));
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
                                "fnPostEffect_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDisabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDisabled(IntPtr _this, OnDisabled__Args args);
            private static _OnDisabled _OnDisabledFunc;
            internal static _OnDisabled OnDisabled() {
                if (_OnDisabledFunc == null) {
                    _OnDisabledFunc =
                        (_OnDisabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPostEffect_onDisabled"), typeof(_OnDisabled));
                }
                
                return _OnDisabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnEnabled(IntPtr _this, OnEnabled__Args args);
            private static _OnEnabled _OnEnabledFunc;
            internal static _OnEnabled OnEnabled() {
                if (_OnEnabledFunc == null) {
                    _OnEnabledFunc =
                        (_OnEnabled)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPostEffect_onEnabled"), typeof(_OnEnabled));
                }
                
                return _OnEnabledFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetShaderConsts__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetShaderConsts(IntPtr _this, SetShaderConsts__Args args);
            private static _SetShaderConsts _SetShaderConstsFunc;
            internal static _SetShaderConsts SetShaderConsts() {
                if (_SetShaderConstsFunc == null) {
                    _SetShaderConstsFunc =
                        (_SetShaderConsts)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPostEffect_setShaderConsts"), typeof(_SetShaderConsts));
                }
                
                return _SetShaderConstsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PreProcess__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PreProcess(IntPtr _this, PreProcess__Args args);
            private static _PreProcess _PreProcessFunc;
            internal static _PreProcess PreProcess() {
                if (_PreProcessFunc == null) {
                    _PreProcessFunc =
                        (_PreProcess)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "cbPostEffect_preProcess"), typeof(_PreProcess));
                }
                
                return _PreProcessFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
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
                                "cbPostEffect_onAdd"), typeof(_OnAdd));
                }
                
                return _OnAddFunc;
            }
        }
        #endregion

        public void ClearShaderMacros() {
             InternalUnsafeMethods.ClearShaderMacros__Args _args = new InternalUnsafeMethods.ClearShaderMacros__Args() {
             };
             InternalUnsafeMethods.ClearShaderMacros()(ObjectPtr, _args);
        }

        public void RemoveShaderMacro(string key) {
             InternalUnsafeMethods.RemoveShaderMacro__Args _args = new InternalUnsafeMethods.RemoveShaderMacro__Args() {
                key = key,
             };
             InternalUnsafeMethods.RemoveShaderMacro()(ObjectPtr, _args);
        }

        public void SetShaderMacro(string key, string value = "") {
             InternalUnsafeMethods.SetShaderMacro__Args _args = new InternalUnsafeMethods.SetShaderMacro__Args() {
                key = key,
                value = value,
             };
             InternalUnsafeMethods.SetShaderMacro()(ObjectPtr, _args);
        }

        public string DumpShaderDisassembly() {
             InternalUnsafeMethods.DumpShaderDisassembly__Args _args = new InternalUnsafeMethods.DumpShaderDisassembly__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.DumpShaderDisassembly()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public float GetAspectRatio() {
             InternalUnsafeMethods.GetAspectRatio__Args _args = new InternalUnsafeMethods.GetAspectRatio__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetAspectRatio()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetShaderConst(string name, string value) {
             InternalUnsafeMethods.SetShaderConst__Args _args = new InternalUnsafeMethods.SetShaderConst__Args() {
                name = name,
                value = value,
             };
             InternalUnsafeMethods.SetShaderConst()(ObjectPtr, _args);
        }

        public void SetTexture(int index, string filePath) {
             InternalUnsafeMethods.SetTexture__Args _args = new InternalUnsafeMethods.SetTexture__Args() {
                index = index,
                filePath = filePath,
             };
             InternalUnsafeMethods.SetTexture()(ObjectPtr, _args);
        }

        public bool IsEnabled() {
             InternalUnsafeMethods.IsEnabled__Args _args = new InternalUnsafeMethods.IsEnabled__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool Toggle() {
             InternalUnsafeMethods.Toggle__Args _args = new InternalUnsafeMethods.Toggle__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.Toggle()(ObjectPtr, _args);
             return _engineResult;
        }

        public void Disable() {
             InternalUnsafeMethods.Disable__Args _args = new InternalUnsafeMethods.Disable__Args() {
             };
             InternalUnsafeMethods.Disable()(ObjectPtr, _args);
        }

        public void Enable() {
             InternalUnsafeMethods.Enable__Args _args = new InternalUnsafeMethods.Enable__Args() {
             };
             InternalUnsafeMethods.Enable()(ObjectPtr, _args);
        }

        public void Reload() {
             InternalUnsafeMethods.Reload__Args _args = new InternalUnsafeMethods.Reload__Args() {
             };
             InternalUnsafeMethods.Reload()(ObjectPtr, _args);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        public void OnDisabled() {
             InternalUnsafeMethods.OnDisabled__Args _args = new InternalUnsafeMethods.OnDisabled__Args() {
             };
             InternalUnsafeMethods.OnDisabled()(ObjectPtr, _args);
        }

        public bool OnEnabled() {
             InternalUnsafeMethods.OnEnabled__Args _args = new InternalUnsafeMethods.OnEnabled__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.OnEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        public void SetShaderConsts() {
             InternalUnsafeMethods.SetShaderConsts__Args _args = new InternalUnsafeMethods.SetShaderConsts__Args() {
             };
             InternalUnsafeMethods.SetShaderConsts()(ObjectPtr, _args);
        }

        public void PreProcess() {
             InternalUnsafeMethods.PreProcess__Args _args = new InternalUnsafeMethods.PreProcess__Args() {
             };
             InternalUnsafeMethods.PreProcess()(ObjectPtr, _args);
        }

        public void OnAdd() {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        public string Shader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shader"));
            set => SetFieldValue("shader", GenericMarshal.ToString(value));
        }

        public GFXStateBlockData StateBlock {
            get => GenericMarshal.StringTo<GFXStateBlockData>(GetFieldValue("stateBlock"));
            set => SetFieldValue("stateBlock", GenericMarshal.ToString(value));
        }

        public string Target {
            get => GenericMarshal.StringTo<string>(GetFieldValue("target"));
            set => SetFieldValue("target", GenericMarshal.ToString(value));
        }

        public string TargetDepthStencil {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetDepthStencil"));
            set => SetFieldValue("targetDepthStencil", GenericMarshal.ToString(value));
        }

        public Point2F TargetScale {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("targetScale"));
            set => SetFieldValue("targetScale", GenericMarshal.ToString(value));
        }

        public Point2I TargetSize {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("targetSize"));
            set => SetFieldValue("targetSize", GenericMarshal.ToString(value));
        }

        public GFXFormat TargetFormat {
            get => GenericMarshal.StringTo<GFXFormat>(GetFieldValue("targetFormat"));
            set => SetFieldValue("targetFormat", GenericMarshal.ToString(value));
        }

        public LinearColorF TargetClearColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("targetClearColor"));
            set => SetFieldValue("targetClearColor", GenericMarshal.ToString(value));
        }

        public PFXTargetClear TargetClear {
            get => GenericMarshal.StringTo<PFXTargetClear>(GetFieldValue("targetClear"));
            set => SetFieldValue("targetClear", GenericMarshal.ToString(value));
        }

        public PFXTargetViewport TargetViewport {
            get => GenericMarshal.StringTo<PFXTargetViewport>(GetFieldValue("targetViewport"));
            set => SetFieldValue("targetViewport", GenericMarshal.ToString(value));
        }

        public DynamicFieldVector<string> Texture {
            get => new DynamicFieldVector<string>(
                    this, 
                    "texture", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public DynamicFieldVector<bool> TextureSRGB {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "textureSRGB", 
                    8, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }

        public PFXRenderTime RenderTime {
            get => GenericMarshal.StringTo<PFXRenderTime>(GetFieldValue("renderTime"));
            set => SetFieldValue("renderTime", GenericMarshal.ToString(value));
        }

        public string RenderBin {
            get => GenericMarshal.StringTo<string>(GetFieldValue("renderBin"));
            set => SetFieldValue("renderBin", GenericMarshal.ToString(value));
        }

        public float RenderPriority {
            get => GenericMarshal.StringTo<float>(GetFieldValue("renderPriority"));
            set => SetFieldValue("renderPriority", GenericMarshal.ToString(value));
        }

        public bool AllowReflectPass {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowReflectPass"));
            set => SetFieldValue("allowReflectPass", GenericMarshal.ToString(value));
        }

        public bool Enabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enabled"));
            set => SetFieldValue("enabled", GenericMarshal.ToString(value));
        }

        public bool OnThisFrame {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("onThisFrame"));
            set => SetFieldValue("onThisFrame", GenericMarshal.ToString(value));
        }

        public bool OneFrameOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("oneFrameOnly"));
            set => SetFieldValue("oneFrameOnly", GenericMarshal.ToString(value));
        }

        public bool Skip {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("skip"));
            set => SetFieldValue("skip", GenericMarshal.ToString(value));
        }
    }
}