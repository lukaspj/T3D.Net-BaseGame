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
    public unsafe class GuiImageList : SimObject {
        public GuiImageList(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiImageList(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiImageList(string pName) 
            : this(pName, false) {
        }
        
        public GuiImageList(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiImageList(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiImageList(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiImageList(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Insert__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string imagePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Insert(IntPtr _this, Insert__Args args);
            private static _Insert _InsertFunc;
            internal static _Insert Insert() {
                if (_InsertFunc == null) {
                    _InsertFunc =
                        (_Insert)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_insert"), typeof(_Insert));
                }
                
                return _InsertFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string imagePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetIndex(IntPtr _this, GetIndex__Args args);
            private static _GetIndex _GetIndexFunc;
            internal static _GetIndex GetIndex() {
                if (_GetIndexFunc == null) {
                    _GetIndexFunc =
                        (_GetIndex)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_getIndex"), typeof(_GetIndex));
                }
                
                return _GetIndexFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Remove__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Remove(IntPtr _this, Remove__Args args);
            private static _Remove _RemoveFunc;
            internal static _Remove Remove() {
                if (_RemoveFunc == null) {
                    _RemoveFunc =
                        (_Remove)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_remove"), typeof(_Remove));
                }
                
                return _RemoveFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Count__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Count(IntPtr _this, Count__Args args);
            private static _Count _CountFunc;
            internal static _Count Count() {
                if (_CountFunc == null) {
                    _CountFunc =
                        (_Count)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_count"), typeof(_Count));
                }
                
                return _CountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
                if (_ClearFunc == null) {
                    _ClearFunc =
                        (_Clear)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_clear"), typeof(_Clear));
                }
                
                return _ClearFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetImage__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetImage(IntPtr _this, GetImage__Args args);
            private static _GetImage _GetImageFunc;
            internal static _GetImage GetImage() {
                if (_GetImageFunc == null) {
                    _GetImageFunc =
                        (_GetImage)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiImageList_getImage"), typeof(_GetImage));
                }
                
                return _GetImageFunc;
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
                                "fnGuiImageList_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiImageList_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public int Insert(string imagePath) {
             InternalUnsafeMethods.Insert__Args _args = new InternalUnsafeMethods.Insert__Args() {
                imagePath = imagePath,
             };
             int _engineResult = InternalUnsafeMethods.Insert()(ObjectPtr, _args);
             return _engineResult;
        }

        public int GetIndex(string imagePath) {
             InternalUnsafeMethods.GetIndex__Args _args = new InternalUnsafeMethods.GetIndex__Args() {
                imagePath = imagePath,
             };
             int _engineResult = InternalUnsafeMethods.GetIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool Remove(int index) {
             InternalUnsafeMethods.Remove__Args _args = new InternalUnsafeMethods.Remove__Args() {
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.Remove()(ObjectPtr, _args);
             return _engineResult;
        }

        public int Count() {
             InternalUnsafeMethods.Count__Args _args = new InternalUnsafeMethods.Count__Args() {
             };
             int _engineResult = InternalUnsafeMethods.Count()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.Clear()(ObjectPtr, _args);
             return _engineResult;
        }

        public string GetImage(int index) {
             InternalUnsafeMethods.GetImage__Args _args = new InternalUnsafeMethods.GetImage__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetImage()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}