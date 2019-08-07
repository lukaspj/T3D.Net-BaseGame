using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class NavMesh : SceneObject {



        public NavMesh(bool pRegister = false)
            : base(pRegister) {
        }

        public NavMesh(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public NavMesh(string pName)
            : this(pName, false) {
        }

        public NavMesh(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public NavMesh(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public NavMesh(SimObject pObj)
            : base(pObj) {
        }

        public NavMesh(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct Save__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Save(IntPtr _this);
                internal delegate void _Save(IntPtr _this, Save__Args args);
                private static _Save _SaveFunc;
                internal static _Save Save() {
                    if (_SaveFunc == null) {
                        _SaveFunc =
                            (_Save)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_save"), typeof(_Save));
                    }

                    return _SaveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Load__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Load(IntPtr _this);
                internal delegate bool _Load(IntPtr _this, Load__Args args);
                private static _Load _LoadFunc;
                internal static _Load Load() {
                    if (_LoadFunc == null) {
                        _LoadFunc =
                            (_Load)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_load"), typeof(_Load));
                    }

                    return _LoadFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CreateCoverPoints__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CreateCoverPoints(IntPtr _this);
                internal delegate bool _CreateCoverPoints(IntPtr _this, CreateCoverPoints__Args args);
                private static _CreateCoverPoints _CreateCoverPointsFunc;
                internal static _CreateCoverPoints CreateCoverPoints() {
                    if (_CreateCoverPointsFunc == null) {
                        _CreateCoverPointsFunc =
                            (_CreateCoverPoints)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_createCoverPoints"), typeof(_CreateCoverPoints));
                    }

                    return _CreateCoverPointsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteCoverPoints__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DeleteCoverPoints(IntPtr _this);
                internal delegate void _DeleteCoverPoints(IntPtr _this, DeleteCoverPoints__Args args);
                private static _DeleteCoverPoints _DeleteCoverPointsFunc;
                internal static _DeleteCoverPoints DeleteCoverPoints() {
                    if (_DeleteCoverPointsFunc == null) {
                        _DeleteCoverPointsFunc =
                            (_DeleteCoverPoints)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_deleteCoverPoints"), typeof(_DeleteCoverPoints));
                    }

                    return _DeleteCoverPointsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct BuildLinks__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _BuildLinks(IntPtr _this);
                internal delegate void _BuildLinks(IntPtr _this, BuildLinks__Args args);
                private static _BuildLinks _BuildLinksFunc;
                internal static _BuildLinks BuildLinks() {
                    if (_BuildLinksFunc == null) {
                        _BuildLinksFunc =
                            (_BuildLinks)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_buildLinks"), typeof(_BuildLinks));
                    }

                    return _BuildLinksFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct BuildTiles__Args
                {

				   internal IntPtr box;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _BuildTiles(IntPtr _this, IntPtr box);
                internal delegate void _BuildTiles(IntPtr _this, BuildTiles__Args args);
                private static _BuildTiles _BuildTilesFunc;
                internal static _BuildTiles BuildTiles() {
                    if (_BuildTilesFunc == null) {
                        _BuildTilesFunc =
                            (_BuildTiles)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_buildTiles"), typeof(_BuildTiles));
                    }

                    return _BuildTilesFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CancelBuild__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _CancelBuild(IntPtr _this);
                internal delegate void _CancelBuild(IntPtr _this, CancelBuild__Args args);
                private static _CancelBuild _CancelBuildFunc;
                internal static _CancelBuild CancelBuild() {
                    if (_CancelBuildFunc == null) {
                        _CancelBuildFunc =
                            (_CancelBuild)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_cancelBuild"), typeof(_CancelBuild));
                    }

                    return _CancelBuildFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Build__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool background;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool save;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _Build(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool background, [MarshalAs(UnmanagedType.I1)]bool save);
                internal delegate bool _Build(IntPtr _this, Build__Args args);
                private static _Build _BuildFunc;
                internal static _Build Build() {
                    if (_BuildFunc == null) {
                        _BuildFunc =
                            (_Build)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_build"), typeof(_Build));
                    }

                    return _BuildFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteLinks__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DeleteLinks(IntPtr _this);
                internal delegate void _DeleteLinks(IntPtr _this, DeleteLinks__Args args);
                private static _DeleteLinks _DeleteLinksFunc;
                internal static _DeleteLinks DeleteLinks() {
                    if (_DeleteLinksFunc == null) {
                        _DeleteLinksFunc =
                            (_DeleteLinks)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_deleteLinks"), typeof(_DeleteLinks));
                    }

                    return _DeleteLinksFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteLink__Args
                {

				   internal uint id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DeleteLink(IntPtr _this, uint id);
                internal delegate void _DeleteLink(IntPtr _this, DeleteLink__Args args);
                private static _DeleteLink _DeleteLinkFunc;
                internal static _DeleteLink DeleteLink() {
                    if (_DeleteLinkFunc == null) {
                        _DeleteLinkFunc =
                            (_DeleteLink)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_deleteLink"), typeof(_DeleteLink));
                    }

                    return _DeleteLinkFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLinkEnd__Args
                {

				   internal uint id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetLinkEnd(IntPtr _this, uint id);
                internal delegate Point3F.InternalStruct _GetLinkEnd(IntPtr _this, GetLinkEnd__Args args);
                private static _GetLinkEnd _GetLinkEndFunc;
                internal static _GetLinkEnd GetLinkEnd() {
                    if (_GetLinkEndFunc == null) {
                        _GetLinkEndFunc =
                            (_GetLinkEnd)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_getLinkEnd"), typeof(_GetLinkEnd));
                    }

                    return _GetLinkEndFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLinkStart__Args
                {

				   internal uint id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetLinkStart(IntPtr _this, uint id);
                internal delegate Point3F.InternalStruct _GetLinkStart(IntPtr _this, GetLinkStart__Args args);
                private static _GetLinkStart _GetLinkStartFunc;
                internal static _GetLinkStart GetLinkStart() {
                    if (_GetLinkStartFunc == null) {
                        _GetLinkStartFunc =
                            (_GetLinkStart)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_getLinkStart"), typeof(_GetLinkStart));
                    }

                    return _GetLinkStartFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetLinkFlags__Args
                {

				   internal uint id;

				   internal uint flags;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetLinkFlags(IntPtr _this, uint id, uint flags);
                internal delegate void _SetLinkFlags(IntPtr _this, SetLinkFlags__Args args);
                private static _SetLinkFlags _SetLinkFlagsFunc;
                internal static _SetLinkFlags SetLinkFlags() {
                    if (_SetLinkFlagsFunc == null) {
                        _SetLinkFlagsFunc =
                            (_SetLinkFlags)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_setLinkFlags"), typeof(_SetLinkFlags));
                    }

                    return _SetLinkFlagsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLinkFlags__Args
                {

				   internal uint id;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetLinkFlags(IntPtr _this, uint id);
                internal delegate int _GetLinkFlags(IntPtr _this, GetLinkFlags__Args args);
                private static _GetLinkFlags _GetLinkFlagsFunc;
                internal static _GetLinkFlags GetLinkFlags() {
                    if (_GetLinkFlagsFunc == null) {
                        _GetLinkFlagsFunc =
                            (_GetLinkFlags)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_getLinkFlags"), typeof(_GetLinkFlags));
                    }

                    return _GetLinkFlagsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLinkCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetLinkCount(IntPtr _this);
                internal delegate int _GetLinkCount(IntPtr _this, GetLinkCount__Args args);
                private static _GetLinkCount _GetLinkCountFunc;
                internal static _GetLinkCount GetLinkCount() {
                    if (_GetLinkCountFunc == null) {
                        _GetLinkCountFunc =
                            (_GetLinkCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_getLinkCount"), typeof(_GetLinkCount));
                    }

                    return _GetLinkCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetLink__Args
                {

				   internal IntPtr pos;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetLink(IntPtr _this, IntPtr pos);
                internal delegate int _GetLink(IntPtr _this, GetLink__Args args);
                private static _GetLink _GetLinkFunc;
                internal static _GetLink GetLink() {
                    if (_GetLinkFunc == null) {
                        _GetLinkFunc =
                            (_GetLink)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_getLink"), typeof(_GetLink));
                    }

                    return _GetLinkFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddLink__Args
                {

				   internal IntPtr from;

				   internal IntPtr to;

				   internal uint flags;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _AddLink(IntPtr _this, IntPtr from, IntPtr to, uint flags);
                internal delegate int _AddLink(IntPtr _this, AddLink__Args args);
                private static _AddLink _AddLinkFunc;
                internal static _AddLink AddLink() {
                    if (_AddLinkFunc == null) {
                        _AddLinkFunc =
                            (_AddLink)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnNavMesh_addLink"), typeof(_AddLink));
                    }

                    return _AddLinkFunc;
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
                                    "fnNavMesh_staticGetType"), typeof(_StaticGetType));
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
                                    "fnNavMesh_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void Save() {

                     InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                     };
                     InternalUnsafeMethods.Save()(ObjectPtr, _args);

                  }



                  public bool Load() {

                     InternalUnsafeMethods.Load__Args _args = new InternalUnsafeMethods.Load__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.Load()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public bool CreateCoverPoints() {

                     InternalUnsafeMethods.CreateCoverPoints__Args _args = new InternalUnsafeMethods.CreateCoverPoints__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.CreateCoverPoints()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void DeleteCoverPoints() {

                     InternalUnsafeMethods.DeleteCoverPoints__Args _args = new InternalUnsafeMethods.DeleteCoverPoints__Args() {
                     };
                     InternalUnsafeMethods.DeleteCoverPoints()(ObjectPtr, _args);

                  }



                  public void BuildLinks() {

                     InternalUnsafeMethods.BuildLinks__Args _args = new InternalUnsafeMethods.BuildLinks__Args() {
                     };
                     InternalUnsafeMethods.BuildLinks()(ObjectPtr, _args);

                  }



                  public void BuildTiles(Box3F box) {

                     box.Alloc();                     InternalUnsafeMethods.BuildTiles__Args _args = new InternalUnsafeMethods.BuildTiles__Args() {
                        box = box.internalStructPtr,
                     };
                     InternalUnsafeMethods.BuildTiles()(ObjectPtr, _args);
                                          box.Free();
                  }



                  public void CancelBuild() {

                     InternalUnsafeMethods.CancelBuild__Args _args = new InternalUnsafeMethods.CancelBuild__Args() {
                     };
                     InternalUnsafeMethods.CancelBuild()(ObjectPtr, _args);

                  }



                  public bool Build(bool background = false, bool save = false) {

                                                               InternalUnsafeMethods.Build__Args _args = new InternalUnsafeMethods.Build__Args() {
                        background = background,
                        save = save,
                     };
                     bool _engineResult = InternalUnsafeMethods.Build()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void DeleteLinks() {

                     InternalUnsafeMethods.DeleteLinks__Args _args = new InternalUnsafeMethods.DeleteLinks__Args() {
                     };
                     InternalUnsafeMethods.DeleteLinks()(ObjectPtr, _args);

                  }



                  public void DeleteLink(uint id) {

                                          InternalUnsafeMethods.DeleteLink__Args _args = new InternalUnsafeMethods.DeleteLink__Args() {
                        id = id,
                     };
                     InternalUnsafeMethods.DeleteLink()(ObjectPtr, _args);

                  }



                  public Point3F GetLinkEnd(uint id) {

                                          InternalUnsafeMethods.GetLinkEnd__Args _args = new InternalUnsafeMethods.GetLinkEnd__Args() {
                        id = id,
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetLinkEnd()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public Point3F GetLinkStart(uint id) {

                                          InternalUnsafeMethods.GetLinkStart__Args _args = new InternalUnsafeMethods.GetLinkStart__Args() {
                        id = id,
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetLinkStart()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public void SetLinkFlags(uint id, uint flags) {

                                                               InternalUnsafeMethods.SetLinkFlags__Args _args = new InternalUnsafeMethods.SetLinkFlags__Args() {
                        id = id,
                        flags = flags,
                     };
                     InternalUnsafeMethods.SetLinkFlags()(ObjectPtr, _args);

                  }



                  public int GetLinkFlags(uint id) {

                                          InternalUnsafeMethods.GetLinkFlags__Args _args = new InternalUnsafeMethods.GetLinkFlags__Args() {
                        id = id,
                     };
                     int _engineResult = InternalUnsafeMethods.GetLinkFlags()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetLinkCount() {

                     InternalUnsafeMethods.GetLinkCount__Args _args = new InternalUnsafeMethods.GetLinkCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetLinkCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetLink(Point3F pos) {

                     pos.Alloc();                     InternalUnsafeMethods.GetLink__Args _args = new InternalUnsafeMethods.GetLink__Args() {
                        pos = pos.internalStructPtr,
                     };
                     int _engineResult = InternalUnsafeMethods.GetLink()(ObjectPtr, _args);
                                          pos.Free();
                     return _engineResult;
                  }



                  public int AddLink(Point3F from, Point3F to, uint flags = 0) {

                     from.Alloc();                     to.Alloc();                                          InternalUnsafeMethods.AddLink__Args _args = new InternalUnsafeMethods.AddLink__Args() {
                        from = from.internalStructPtr,
                        to = to.internalStructPtr,
                        flags = flags,
                     };
                     int _engineResult = InternalUnsafeMethods.AddLink()(ObjectPtr, _args);
                                          from.Free();                     to.Free();
                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }


        public NavMeshWaterMethod WaterMethod {
            get => GenericMarshal.StringTo<NavMeshWaterMethod>(GetFieldValue("waterMethod"));
            set => SetFieldValue("waterMethod", GenericMarshal.ToString(value));
        }


        public float CellSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cellSize"));
            set => SetFieldValue("cellSize", GenericMarshal.ToString(value));
        }


        public float CellHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cellHeight"));
            set => SetFieldValue("cellHeight", GenericMarshal.ToString(value));
        }


        public float TileSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("tileSize"));
            set => SetFieldValue("tileSize", GenericMarshal.ToString(value));
        }


        public float ActorHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("actorHeight"));
            set => SetFieldValue("actorHeight", GenericMarshal.ToString(value));
        }


        public float ActorClimb {
            get => GenericMarshal.StringTo<float>(GetFieldValue("actorClimb"));
            set => SetFieldValue("actorClimb", GenericMarshal.ToString(value));
        }


        public float ActorRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("actorRadius"));
            set => SetFieldValue("actorRadius", GenericMarshal.ToString(value));
        }


        public float WalkableSlope {
            get => GenericMarshal.StringTo<float>(GetFieldValue("walkableSlope"));
            set => SetFieldValue("walkableSlope", GenericMarshal.ToString(value));
        }


        public bool SmallCharacters {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("smallCharacters"));
            set => SetFieldValue("smallCharacters", GenericMarshal.ToString(value));
        }


        public bool RegularCharacters {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("regularCharacters"));
            set => SetFieldValue("regularCharacters", GenericMarshal.ToString(value));
        }


        public bool LargeCharacters {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("largeCharacters"));
            set => SetFieldValue("largeCharacters", GenericMarshal.ToString(value));
        }


        public bool Vehicles {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("vehicles"));
            set => SetFieldValue("vehicles", GenericMarshal.ToString(value));
        }


        public string CoverGroup {
            get => GenericMarshal.StringTo<string>(GetFieldValue("coverGroup"));
            set => SetFieldValue("coverGroup", GenericMarshal.ToString(value));
        }


        public bool InnerCover {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("innerCover"));
            set => SetFieldValue("innerCover", GenericMarshal.ToString(value));
        }


        public float CoverDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("coverDist"));
            set => SetFieldValue("coverDist", GenericMarshal.ToString(value));
        }


        public float PeekDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("peekDist"));
            set => SetFieldValue("peekDist", GenericMarshal.ToString(value));
        }


        public bool AlwaysRender {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alwaysRender"));
            set => SetFieldValue("alwaysRender", GenericMarshal.ToString(value));
        }


        public int BorderSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderSize"));
            set => SetFieldValue("borderSize", GenericMarshal.ToString(value));
        }


        public float DetailSampleDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailSampleDist"));
            set => SetFieldValue("detailSampleDist", GenericMarshal.ToString(value));
        }


        public float DetailSampleError {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailSampleError"));
            set => SetFieldValue("detailSampleError", GenericMarshal.ToString(value));
        }


        public int MaxEdgeLen {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxEdgeLen"));
            set => SetFieldValue("maxEdgeLen", GenericMarshal.ToString(value));
        }


        public float SimplificationError {
            get => GenericMarshal.StringTo<float>(GetFieldValue("simplificationError"));
            set => SetFieldValue("simplificationError", GenericMarshal.ToString(value));
        }


        public int MinRegionArea {
            get => GenericMarshal.StringTo<int>(GetFieldValue("minRegionArea"));
            set => SetFieldValue("minRegionArea", GenericMarshal.ToString(value));
        }


        public int MergeRegionArea {
            get => GenericMarshal.StringTo<int>(GetFieldValue("mergeRegionArea"));
            set => SetFieldValue("mergeRegionArea", GenericMarshal.ToString(value));
        }


        public int MaxPolysPerTile {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxPolysPerTile"));
            set => SetFieldValue("maxPolysPerTile", GenericMarshal.ToString(value));
        }


    }
}
