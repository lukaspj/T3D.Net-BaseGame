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
    public unsafe class SimXMLDocument : SimObject {
        public SimXMLDocument(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public SimXMLDocument(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public SimXMLDocument(string pName) 
            : this(pName, false) {
        }
        
        public SimXMLDocument(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public SimXMLDocument(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public SimXMLDocument(SimObject pObj) 
            : base(pObj) {
        }
        
        public SimXMLDocument(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetData__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetData(IntPtr _this, GetData__Args args);
            private static _GetData _GetDataFunc;
            internal static _GetData GetData() {
                if (_GetDataFunc == null) {
                    _GetDataFunc =
                        (_GetData)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_getData"), typeof(_GetData));
                }
                
                return _GetDataFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddData__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddData(IntPtr _this, AddData__Args args);
            private static _AddData _AddDataFunc;
            internal static _AddData AddData() {
                if (_AddDataFunc == null) {
                    _AddDataFunc =
                        (_AddData)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_addData"), typeof(_AddData));
                }
                
                return _AddDataFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveText(IntPtr _this, RemoveText__Args args);
            private static _RemoveText _RemoveTextFunc;
            internal static _RemoveText RemoveText() {
                if (_RemoveTextFunc == null) {
                    _RemoveTextFunc =
                        (_RemoveText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_removeText"), typeof(_RemoveText));
                }
                
                return _RemoveTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
                if (_GetTextFunc == null) {
                    _GetTextFunc =
                        (_GetText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_getText"), typeof(_GetText));
                }
                
                return _GetTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddText__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddText(IntPtr _this, AddText__Args args);
            private static _AddText _AddTextFunc;
            internal static _AddText AddText() {
                if (_AddTextFunc == null) {
                    _AddTextFunc =
                        (_AddText)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_addText"), typeof(_AddText));
                }
                
                return _AddTextFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ReadComment__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ReadComment(IntPtr _this, ReadComment__Args args);
            private static _ReadComment _ReadCommentFunc;
            internal static _ReadComment ReadComment() {
                if (_ReadCommentFunc == null) {
                    _ReadCommentFunc =
                        (_ReadComment)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_readComment"), typeof(_ReadComment));
                }
                
                return _ReadCommentFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddComment__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string comment;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddComment(IntPtr _this, AddComment__Args args);
            private static _AddComment _AddCommentFunc;
            internal static _AddComment AddComment() {
                if (_AddCommentFunc == null) {
                    _AddCommentFunc =
                        (_AddComment)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_addComment"), typeof(_AddComment));
                }
                
                return _AddCommentFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddHeader__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddHeader(IntPtr _this, AddHeader__Args args);
            private static _AddHeader _AddHeaderFunc;
            internal static _AddHeader AddHeader() {
                if (_AddHeaderFunc == null) {
                    _AddHeaderFunc =
                        (_AddHeader)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_addHeader"), typeof(_AddHeader));
                }
                
                return _AddHeaderFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AddNewElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddNewElement(IntPtr _this, AddNewElement__Args args);
            private static _AddNewElement _AddNewElementFunc;
            internal static _AddNewElement AddNewElement() {
                if (_AddNewElementFunc == null) {
                    _AddNewElementFunc =
                        (_AddNewElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_addNewElement"), typeof(_AddNewElement));
                }
                
                return _AddNewElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PushNewElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushNewElement(IntPtr _this, PushNewElement__Args args);
            private static _PushNewElement _PushNewElementFunc;
            internal static _PushNewElement PushNewElement() {
                if (_PushNewElementFunc == null) {
                    _PushNewElementFunc =
                        (_PushNewElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_pushNewElement"), typeof(_PushNewElement));
                }
                
                return _PushNewElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetObjectAttributes__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objectID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetObjectAttributes(IntPtr _this, SetObjectAttributes__Args args);
            private static _SetObjectAttributes _SetObjectAttributesFunc;
            internal static _SetObjectAttributes SetObjectAttributes() {
                if (_SetObjectAttributesFunc == null) {
                    _SetObjectAttributesFunc =
                        (_SetObjectAttributes)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_setObjectAttributes"), typeof(_SetObjectAttributes));
                }
                
                return _SetObjectAttributesFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAttribute__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAttribute(IntPtr _this, SetAttribute__Args args);
            private static _SetAttribute _SetAttributeFunc;
            internal static _SetAttribute SetAttribute() {
                if (_SetAttributeFunc == null) {
                    _SetAttributeFunc =
                        (_SetAttribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_setAttribute"), typeof(_SetAttribute));
                }
                
                return _SetAttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PrevAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _PrevAttribute(IntPtr _this, PrevAttribute__Args args);
            private static _PrevAttribute _PrevAttributeFunc;
            internal static _PrevAttribute PrevAttribute() {
                if (_PrevAttributeFunc == null) {
                    _PrevAttributeFunc =
                        (_PrevAttribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_prevAttribute"), typeof(_PrevAttribute));
                }
                
                return _PrevAttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct NextAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _NextAttribute(IntPtr _this, NextAttribute__Args args);
            private static _NextAttribute _NextAttributeFunc;
            internal static _NextAttribute NextAttribute() {
                if (_NextAttributeFunc == null) {
                    _NextAttributeFunc =
                        (_NextAttribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_nextAttribute"), typeof(_NextAttribute));
                }
                
                return _NextAttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct LastAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _LastAttribute(IntPtr _this, LastAttribute__Args args);
            private static _LastAttribute _LastAttributeFunc;
            internal static _LastAttribute LastAttribute() {
                if (_LastAttributeFunc == null) {
                    _LastAttributeFunc =
                        (_LastAttribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_lastAttribute"), typeof(_LastAttribute));
                }
                
                return _LastAttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct FirstAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _FirstAttribute(IntPtr _this, FirstAttribute__Args args);
            private static _FirstAttribute _FirstAttributeFunc;
            internal static _FirstAttribute FirstAttribute() {
                if (_FirstAttributeFunc == null) {
                    _FirstAttributeFunc =
                        (_FirstAttribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_firstAttribute"), typeof(_FirstAttribute));
                }
                
                return _FirstAttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeExists__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AttributeExists(IntPtr _this, AttributeExists__Args args);
            private static _AttributeExists _AttributeExistsFunc;
            internal static _AttributeExists AttributeExists() {
                if (_AttributeExistsFunc == null) {
                    _AttributeExistsFunc =
                        (_AttributeExists)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_attributeExists"), typeof(_AttributeExists));
                }
                
                return _AttributeExistsFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeS32__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AttributeS32(IntPtr _this, AttributeS32__Args args);
            private static _AttributeS32 _AttributeS32Func;
            internal static _AttributeS32 AttributeS32() {
                if (_AttributeS32Func == null) {
                    _AttributeS32Func =
                        (_AttributeS32)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_attributeS32"), typeof(_AttributeS32));
                }
                
                return _AttributeS32Func;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeF32__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _AttributeF32(IntPtr _this, AttributeF32__Args args);
            private static _AttributeF32 _AttributeF32Func;
            internal static _AttributeF32 AttributeF32() {
                if (_AttributeF32Func == null) {
                    _AttributeF32Func =
                        (_AttributeF32)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_attributeF32"), typeof(_AttributeF32));
                }
                
                return _AttributeF32Func;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Attribute__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _Attribute(IntPtr _this, Attribute__Args args);
            private static _Attribute _AttributeFunc;
            internal static _Attribute Attribute() {
                if (_AttributeFunc == null) {
                    _AttributeFunc =
                        (_Attribute)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_attribute"), typeof(_Attribute));
                }
                
                return _AttributeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PopElement__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopElement(IntPtr _this, PopElement__Args args);
            private static _PopElement _PopElementFunc;
            internal static _PopElement PopElement() {
                if (_PopElementFunc == null) {
                    _PopElementFunc =
                        (_PopElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_popElement"), typeof(_PopElement));
                }
                
                return _PopElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ElementValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ElementValue(IntPtr _this, ElementValue__Args args);
            private static _ElementValue _ElementValueFunc;
            internal static _ElementValue ElementValue() {
                if (_ElementValueFunc == null) {
                    _ElementValueFunc =
                        (_ElementValue)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_elementValue"), typeof(_ElementValue));
                }
                
                return _ElementValueFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct NextSiblingElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _NextSiblingElement(IntPtr _this, NextSiblingElement__Args args);
            private static _NextSiblingElement _NextSiblingElementFunc;
            internal static _NextSiblingElement NextSiblingElement() {
                if (_NextSiblingElementFunc == null) {
                    _NextSiblingElementFunc =
                        (_NextSiblingElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_nextSiblingElement"), typeof(_NextSiblingElement));
                }
                
                return _NextSiblingElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PushChildElement__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PushChildElement(IntPtr _this, PushChildElement__Args args);
            private static _PushChildElement _PushChildElementFunc;
            internal static _PushChildElement PushChildElement() {
                if (_PushChildElementFunc == null) {
                    _PushChildElementFunc =
                        (_PushChildElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_pushChildElement"), typeof(_PushChildElement));
                }
                
                return _PushChildElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct PushFirstChildElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PushFirstChildElement(IntPtr _this, PushFirstChildElement__Args args);
            private static _PushFirstChildElement _PushFirstChildElementFunc;
            internal static _PushFirstChildElement PushFirstChildElement() {
                if (_PushFirstChildElementFunc == null) {
                    _PushFirstChildElementFunc =
                        (_PushFirstChildElement)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_pushFirstChildElement"), typeof(_PushFirstChildElement));
                }
                
                return _PushFirstChildElementFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearError__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearError(IntPtr _this, ClearError__Args args);
            private static _ClearError _ClearErrorFunc;
            internal static _ClearError ClearError() {
                if (_ClearErrorFunc == null) {
                    _ClearErrorFunc =
                        (_ClearError)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_clearError"), typeof(_ClearError));
                }
                
                return _ClearErrorFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetErrorDesc__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetErrorDesc(IntPtr _this, GetErrorDesc__Args args);
            private static _GetErrorDesc _GetErrorDescFunc;
            internal static _GetErrorDesc GetErrorDesc() {
                if (_GetErrorDescFunc == null) {
                    _GetErrorDescFunc =
                        (_GetErrorDesc)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_getErrorDesc"), typeof(_GetErrorDesc));
                }
                
                return _GetErrorDescFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
                if (_ClearFunc == null) {
                    _ClearFunc =
                        (_Clear)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_clear"), typeof(_Clear));
                }
                
                return _ClearFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Parse__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string xmlString;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Parse(IntPtr _this, Parse__Args args);
            private static _Parse _ParseFunc;
            internal static _Parse Parse() {
                if (_ParseFunc == null) {
                    _ParseFunc =
                        (_Parse)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_parse"), typeof(_Parse));
                }
                
                return _ParseFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SaveFile(IntPtr _this, SaveFile__Args args);
            private static _SaveFile _SaveFileFunc;
            internal static _SaveFile SaveFile() {
                if (_SaveFileFunc == null) {
                    _SaveFileFunc =
                        (_SaveFile)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_saveFile"), typeof(_SaveFile));
                }
                
                return _SaveFileFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct LoadFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _LoadFile(IntPtr _this, LoadFile__Args args);
            private static _LoadFile _LoadFileFunc;
            internal static _LoadFile LoadFile() {
                if (_LoadFileFunc == null) {
                    _LoadFileFunc =
                        (_LoadFile)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_loadFile"), typeof(_LoadFile));
                }
                
                return _LoadFileFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
                if (_ResetFunc == null) {
                    _ResetFunc =
                        (_Reset)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnSimXMLDocument_reset"), typeof(_Reset));
                }
                
                return _ResetFunc;
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
                                "fnSimXMLDocument_staticGetType"), typeof(_StaticGetType));
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
                                "fnSimXMLDocument_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        public string GetData() {
             InternalUnsafeMethods.GetData__Args _args = new InternalUnsafeMethods.GetData__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetData()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void AddData(string text) {
             InternalUnsafeMethods.AddData__Args _args = new InternalUnsafeMethods.AddData__Args() {
                text = text,
             };
             InternalUnsafeMethods.AddData()(ObjectPtr, _args);
        }

        public void RemoveText() {
             InternalUnsafeMethods.RemoveText__Args _args = new InternalUnsafeMethods.RemoveText__Args() {
             };
             InternalUnsafeMethods.RemoveText()(ObjectPtr, _args);
        }

        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void AddText(string text) {
             InternalUnsafeMethods.AddText__Args _args = new InternalUnsafeMethods.AddText__Args() {
                text = text,
             };
             InternalUnsafeMethods.AddText()(ObjectPtr, _args);
        }

        public string ReadComment(int index) {
             InternalUnsafeMethods.ReadComment__Args _args = new InternalUnsafeMethods.ReadComment__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ReadComment()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void AddComment(string comment) {
             InternalUnsafeMethods.AddComment__Args _args = new InternalUnsafeMethods.AddComment__Args() {
                comment = comment,
             };
             InternalUnsafeMethods.AddComment()(ObjectPtr, _args);
        }

        public void AddHeader() {
             InternalUnsafeMethods.AddHeader__Args _args = new InternalUnsafeMethods.AddHeader__Args() {
             };
             InternalUnsafeMethods.AddHeader()(ObjectPtr, _args);
        }

        public void AddNewElement(string name) {
             InternalUnsafeMethods.AddNewElement__Args _args = new InternalUnsafeMethods.AddNewElement__Args() {
                name = name,
             };
             InternalUnsafeMethods.AddNewElement()(ObjectPtr, _args);
        }

        public void PushNewElement(string name) {
             InternalUnsafeMethods.PushNewElement__Args _args = new InternalUnsafeMethods.PushNewElement__Args() {
                name = name,
             };
             InternalUnsafeMethods.PushNewElement()(ObjectPtr, _args);
        }

        public void SetObjectAttributes(string objectID) {
             InternalUnsafeMethods.SetObjectAttributes__Args _args = new InternalUnsafeMethods.SetObjectAttributes__Args() {
                objectID = objectID,
             };
             InternalUnsafeMethods.SetObjectAttributes()(ObjectPtr, _args);
        }

        public void SetAttribute(string attributeName, string value) {
             InternalUnsafeMethods.SetAttribute__Args _args = new InternalUnsafeMethods.SetAttribute__Args() {
                attributeName = attributeName,
                value = value,
             };
             InternalUnsafeMethods.SetAttribute()(ObjectPtr, _args);
        }

        public string PrevAttribute() {
             InternalUnsafeMethods.PrevAttribute__Args _args = new InternalUnsafeMethods.PrevAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.PrevAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string NextAttribute() {
             InternalUnsafeMethods.NextAttribute__Args _args = new InternalUnsafeMethods.NextAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.NextAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string LastAttribute() {
             InternalUnsafeMethods.LastAttribute__Args _args = new InternalUnsafeMethods.LastAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.LastAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public string FirstAttribute() {
             InternalUnsafeMethods.FirstAttribute__Args _args = new InternalUnsafeMethods.FirstAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.FirstAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool AttributeExists(string attributeName) {
             InternalUnsafeMethods.AttributeExists__Args _args = new InternalUnsafeMethods.AttributeExists__Args() {
                attributeName = attributeName,
             };
             bool _engineResult = InternalUnsafeMethods.AttributeExists()(ObjectPtr, _args);
             return _engineResult;
        }

        public int AttributeS32(string attributeName) {
             InternalUnsafeMethods.AttributeS32__Args _args = new InternalUnsafeMethods.AttributeS32__Args() {
                attributeName = attributeName,
             };
             int _engineResult = InternalUnsafeMethods.AttributeS32()(ObjectPtr, _args);
             return _engineResult;
        }

        public float AttributeF32(string attributeName) {
             InternalUnsafeMethods.AttributeF32__Args _args = new InternalUnsafeMethods.AttributeF32__Args() {
                attributeName = attributeName,
             };
             float _engineResult = InternalUnsafeMethods.AttributeF32()(ObjectPtr, _args);
             return _engineResult;
        }

        public string Attribute(string attributeName) {
             InternalUnsafeMethods.Attribute__Args _args = new InternalUnsafeMethods.Attribute__Args() {
                attributeName = attributeName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.Attribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void PopElement() {
             InternalUnsafeMethods.PopElement__Args _args = new InternalUnsafeMethods.PopElement__Args() {
             };
             InternalUnsafeMethods.PopElement()(ObjectPtr, _args);
        }

        public string ElementValue() {
             InternalUnsafeMethods.ElementValue__Args _args = new InternalUnsafeMethods.ElementValue__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.ElementValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public bool NextSiblingElement(string name) {
             InternalUnsafeMethods.NextSiblingElement__Args _args = new InternalUnsafeMethods.NextSiblingElement__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.NextSiblingElement()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool PushChildElement(int index) {
             InternalUnsafeMethods.PushChildElement__Args _args = new InternalUnsafeMethods.PushChildElement__Args() {
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.PushChildElement()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool PushFirstChildElement(string name) {
             InternalUnsafeMethods.PushFirstChildElement__Args _args = new InternalUnsafeMethods.PushFirstChildElement__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.PushFirstChildElement()(ObjectPtr, _args);
             return _engineResult;
        }

        public void ClearError() {
             InternalUnsafeMethods.ClearError__Args _args = new InternalUnsafeMethods.ClearError__Args() {
             };
             InternalUnsafeMethods.ClearError()(ObjectPtr, _args);
        }

        public string GetErrorDesc() {
             InternalUnsafeMethods.GetErrorDesc__Args _args = new InternalUnsafeMethods.GetErrorDesc__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetErrorDesc()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        public void Parse(string xmlString) {
             InternalUnsafeMethods.Parse__Args _args = new InternalUnsafeMethods.Parse__Args() {
                xmlString = xmlString,
             };
             InternalUnsafeMethods.Parse()(ObjectPtr, _args);
        }

        public bool SaveFile(string fileName) {
             InternalUnsafeMethods.SaveFile__Args _args = new InternalUnsafeMethods.SaveFile__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.SaveFile()(ObjectPtr, _args);
             return _engineResult;
        }

        public bool LoadFile(string fileName) {
             InternalUnsafeMethods.LoadFile__Args _args = new InternalUnsafeMethods.LoadFile__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.LoadFile()(ObjectPtr, _args);
             return _engineResult;
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
    }
}