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
    /// <summary>Brief Desc.</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// // Comment:
    /// %okButton = new ClassObject()
    /// instantiation
    /// </code>
    public unsafe class GuiControlArrayControl : GuiControl {
        public GuiControlArrayControl(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiControlArrayControl(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiControlArrayControl(string pName) 
            : this(pName, false) {
        }
        
        public GuiControlArrayControl(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiControlArrayControl(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiControlArrayControl(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiControlArrayControl(IntPtr pObj) 
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
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiControlArrayControl_staticGetType"), typeof(_StaticGetType));
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
                                "fnGuiControlArrayControl_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiControlArrayControl class.
        /// </description>
        /// <returns>The type info object for GuiControlArrayControl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Number of colums in the array.
        /// </description>
        /// </value>
        public int ColCount {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colCount"));
            set => SetFieldValue("colCount", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Size of each individual column.
        /// </description>
        /// </value>
        public IntVector ColSizes {
            get => GenericMarshal.StringTo<IntVector>(GetFieldValue("colSizes"));
            set => SetFieldValue("colSizes", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Heigth of a row in the array.
        /// </description>
        /// </value>
        public int RowSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rowSize"));
            set => SetFieldValue("rowSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Padding to put between rows.
        /// </description>
        /// </value>
        public int RowSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rowSpacing"));
            set => SetFieldValue("rowSpacing", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Padding to put between columns.
        /// </description>
        /// </value>
        public int ColSpacing {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colSpacing"));
            set => SetFieldValue("colSpacing", GenericMarshal.ToString(value));
        }
    }
}