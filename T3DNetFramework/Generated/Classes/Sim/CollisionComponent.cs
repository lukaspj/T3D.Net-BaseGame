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
    /// <summary>The Box Collider component uses a box or rectangular convex shape for collisions.</summary>
    /// <description>
    /// Colliders are individualized components that are similarly based off the CollisionInterface core.
    /// They are basically the entire functionality of how Torque handles collisions compacted into a single component.
    /// A collider will both collide against and be collided with, other entities.
    /// Individual colliders will offer different shapes. This box collider will generate a box/rectangle convex, 
    /// while the mesh collider will take the owner Entity's rendered shape and do polysoup collision on it, etc.
    /// 
    /// The general flow of operations for how collisions happen is thus:
    ///   -When the component is added(or updated) prepCollision() is called.
    ///     This will set up our initial convex shape for usage later.
    /// 
    ///   -When we update via processTick(), we first test if our entity owner is mobile.
    ///     If our owner isn't mobile(as in, they have no components that provide it a velocity to move)
    ///     then we skip doing our active collision checks. Collisions are checked by the things moving, as
    ///     opposed to being reactionary. If we're moving, we call updateWorkingCollisionSet().
    ///     updateWorkingCollisionSet() estimates our bounding space for our current ticket based on our position and velocity.
    ///     If our bounding space has changed since the last tick, we proceed to call updateWorkingList() on our convex.
    ///     This notifies any object in the bounding space that they may be collided with, so they will call buildConvex().
    ///     buildConvex() will set up our ConvexList with our collision convex info.
    /// 
    ///   -When the component that is actually causing our movement, such as SimplePhysicsBehavior, updates, it will check collisions.
    ///     It will call checkCollisions() on us. checkCollisions() will first build a bounding shape for our convex, and test
    ///     if we can early out because we won't hit anything based on our starting point, velocity, and tick time.
    ///     If we don't early out, we proceed to call updateCollisions(). This builds an ExtrudePolyList, which is then extruded
    ///     based on our velocity. We then test our extruded polies on our working list of objects we build
    ///     up earlier via updateWorkingCollisionSet. Any collisions that happen here will be added to our mCollisionList.
    ///     Finally, we call handleCollisionList() on our collisionList, which then queues out the colliison notice
    ///     to the object(s) we collided with so they can do callbacks and the like. We also report back on if we did collide
    ///     to the physics component via our bool return in checkCollisions() so it can make the physics react accordingly.
    /// 
    /// One interesting point to note is the usage of mBlockColliding.
    /// This is set so that it dictates the return on checkCollisions(). If set to false, it will ensure checkCollisions()
    /// will return false, regardless if we actually collided. This is useful, because even if checkCollisions() returns false,
    /// we still handle the collisions so the callbacks happen. This enables us to apply a collider to an object that doesn't block
    /// objects, but does have callbacks, so it can act as a trigger, allowing for arbitrarily shaped triggers, as any collider can
    /// act as a trigger volume(including MeshCollider).
    /// </description>
    /// <code>
    /// new CollisionComponentInstance()
    /// {
    ///    template = CollisionComponentTemplate;
    ///    colliderSize = "1 1 2";
    ///    blockColldingObject = "1";
    /// };
    /// </code>
    /// <see cref="SimplePhysicsBehavior" />
    public unsafe class CollisionComponent : Component {
        public CollisionComponent(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public CollisionComponent(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public CollisionComponent(string pName) 
            : this(pName, false) {
        }
        
        public CollisionComponent(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public CollisionComponent(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public CollisionComponent(SimObject pObj) 
            : base(pObj) {
        }
        
        public CollisionComponent(IntPtr pObj) 
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
                                "fnCollisionComponent_staticGetType"), typeof(_StaticGetType));
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
                                "fnCollisionComponent_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBestCollisionAngle__Args
            {
                internal IntPtr upVector;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetBestCollisionAngle(IntPtr _this, GetBestCollisionAngle__Args args);
            private static _GetBestCollisionAngle _GetBestCollisionAngleFunc;
            internal static _GetBestCollisionAngle GetBestCollisionAngle() {
                if (_GetBestCollisionAngleFunc == null) {
                    _GetBestCollisionAngleFunc =
                        (_GetBestCollisionAngle)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getBestCollisionAngle"), typeof(_GetBestCollisionAngle));
                }
                
                return _GetBestCollisionAngleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCollisionAngle__Args
            {
                internal int collisionIndex;
                internal IntPtr upVector;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetCollisionAngle(IntPtr _this, GetCollisionAngle__Args args);
            private static _GetCollisionAngle _GetCollisionAngleFunc;
            internal static _GetCollisionAngle GetCollisionAngle() {
                if (_GetCollisionAngleFunc == null) {
                    _GetCollisionAngleFunc =
                        (_GetCollisionAngle)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getCollisionAngle"), typeof(_GetCollisionAngle));
                }
                
                return _GetCollisionAngleFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCollisionNormal__Args
            {
                internal int collisionIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetCollisionNormal(IntPtr _this, GetCollisionNormal__Args args);
            private static _GetCollisionNormal _GetCollisionNormalFunc;
            internal static _GetCollisionNormal GetCollisionNormal() {
                if (_GetCollisionNormalFunc == null) {
                    _GetCollisionNormalFunc =
                        (_GetCollisionNormal)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getCollisionNormal"), typeof(_GetCollisionNormal));
                }
                
                return _GetCollisionNormalFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCollisionCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCollisionCount(IntPtr _this, GetCollisionCount__Args args);
            private static _GetCollisionCount _GetCollisionCountFunc;
            internal static _GetCollisionCount GetCollisionCount() {
                if (_GetCollisionCountFunc == null) {
                    _GetCollisionCountFunc =
                        (_GetCollisionCount)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getCollisionCount"), typeof(_GetCollisionCount));
                }
                
                return _GetCollisionCountFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct HasContact__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _HasContact(IntPtr _this, HasContact__Args args);
            private static _HasContact _HasContactFunc;
            internal static _HasContact HasContact() {
                if (_HasContactFunc == null) {
                    _HasContactFunc =
                        (_HasContact)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_hasContact"), typeof(_HasContact));
                }
                
                return _HasContactFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContactTime__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetContactTime(IntPtr _this, GetContactTime__Args args);
            private static _GetContactTime _GetContactTimeFunc;
            internal static _GetContactTime GetContactTime() {
                if (_GetContactTimeFunc == null) {
                    _GetContactTimeFunc =
                        (_GetContactTime)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getContactTime"), typeof(_GetContactTime));
                }
                
                return _GetContactTimeFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContactPoint__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetContactPoint(IntPtr _this, GetContactPoint__Args args);
            private static _GetContactPoint _GetContactPointFunc;
            internal static _GetContactPoint GetContactPoint() {
                if (_GetContactPointFunc == null) {
                    _GetContactPointFunc =
                        (_GetContactPoint)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getContactPoint"), typeof(_GetContactPoint));
                }
                
                return _GetContactPointFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContactObject__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetContactObject(IntPtr _this, GetContactObject__Args args);
            private static _GetContactObject _GetContactObjectFunc;
            internal static _GetContactObject GetContactObject() {
                if (_GetContactObjectFunc == null) {
                    _GetContactObjectFunc =
                        (_GetContactObject)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getContactObject"), typeof(_GetContactObject));
                }
                
                return _GetContactObjectFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContactMaterial__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetContactMaterial(IntPtr _this, GetContactMaterial__Args args);
            private static _GetContactMaterial _GetContactMaterialFunc;
            internal static _GetContactMaterial GetContactMaterial() {
                if (_GetContactMaterialFunc == null) {
                    _GetContactMaterialFunc =
                        (_GetContactMaterial)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getContactMaterial"), typeof(_GetContactMaterial));
                }
                
                return _GetContactMaterialFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContactNormal__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetContactNormal(IntPtr _this, GetContactNormal__Args args);
            private static _GetContactNormal _GetContactNormalFunc;
            internal static _GetContactNormal GetContactNormal() {
                if (_GetContactNormalFunc == null) {
                    _GetContactNormalFunc =
                        (_GetContactNormal)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getContactNormal"), typeof(_GetContactNormal));
                }
                
                return _GetContactNormalFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBestContact__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetBestContact(IntPtr _this, GetBestContact__Args args);
            private static _GetBestContact _GetBestContactFunc;
            internal static _GetBestContact GetBestContact() {
                if (_GetBestContactFunc == null) {
                    _GetBestContactFunc =
                        (_GetBestContact)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getBestContact"), typeof(_GetBestContact));
                }
                
                return _GetBestContactFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumberOfContacts__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumberOfContacts(IntPtr _this, GetNumberOfContacts__Args args);
            private static _GetNumberOfContacts _GetNumberOfContactsFunc;
            internal static _GetNumberOfContacts GetNumberOfContacts() {
                if (_GetNumberOfContactsFunc == null) {
                    _GetNumberOfContactsFunc =
                        (_GetNumberOfContacts)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnCollisionComponent_getNumberOfContacts"), typeof(_GetNumberOfContacts));
                }
                
                return _GetNumberOfContactsFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the CollisionComponent class.
        /// </description>
        /// <returns>The type info object for CollisionComponent</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <summary>Apply an impulse to this object as defined by a world position and velocity vector.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pos">impulse world position</param>
        /// <param name="vel">impulse velocity (impulse force F = m * v)</param>
        /// <returns>Always true</returns>
        /// <remarks> Not all objects that derrive from GameBase have this defined.
        /// </remarks>
        public float GetBestCollisionAngle(Point3F upVector) {
upVector.Alloc();             InternalUnsafeMethods.GetBestCollisionAngle__Args _args = new InternalUnsafeMethods.GetBestCollisionAngle__Args() {
                upVector = upVector.internalStructPtr,
             };
             float _engineResult = InternalUnsafeMethods.GetBestCollisionAngle()(ObjectPtr, _args);
upVector.Free();             return _engineResult;
        }

        /// <summary>Apply an impulse to this object as defined by a world position and velocity vector.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pos">impulse world position</param>
        /// <param name="vel">impulse velocity (impulse force F = m * v)</param>
        /// <returns>Always true</returns>
        /// <remarks> Not all objects that derrive from GameBase have this defined.
        /// </remarks>
        public float GetCollisionAngle(int collisionIndex, Point3F upVector) {
upVector.Alloc();             InternalUnsafeMethods.GetCollisionAngle__Args _args = new InternalUnsafeMethods.GetCollisionAngle__Args() {
                collisionIndex = collisionIndex,
                upVector = upVector.internalStructPtr,
             };
             float _engineResult = InternalUnsafeMethods.GetCollisionAngle()(ObjectPtr, _args);
upVector.Free();             return _engineResult;
        }

        /// <summary>Apply an impulse to this object as defined by a world position and velocity vector.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pos">impulse world position</param>
        /// <param name="vel">impulse velocity (impulse force F = m * v)</param>
        /// <returns>Always true</returns>
        /// <remarks> Not all objects that derrive from GameBase have this defined.
        /// </remarks>
        public Point3F GetCollisionNormal(int collisionIndex) {
             InternalUnsafeMethods.GetCollisionNormal__Args _args = new InternalUnsafeMethods.GetCollisionNormal__Args() {
                collisionIndex = collisionIndex,
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetCollisionNormal()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <summary>Apply an impulse to this object as defined by a world position and velocity vector.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pos">impulse world position</param>
        /// <param name="vel">impulse velocity (impulse force F = m * v)</param>
        /// <returns>Always true</returns>
        /// <remarks> Not all objects that derrive from GameBase have this defined.
        /// </remarks>
        public int GetCollisionCount() {
             InternalUnsafeMethods.GetCollisionCount__Args _args = new InternalUnsafeMethods.GetCollisionCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCollisionCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Apply an impulse to this object as defined by a world position and velocity vector.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pos">impulse world position</param>
        /// <param name="vel">impulse velocity (impulse force F = m * v)</param>
        /// <returns>Always true</returns>
        /// <remarks> Not all objects that derrive from GameBase have this defined.
        /// </remarks>
        public bool HasContact() {
             InternalUnsafeMethods.HasContact__Args _args = new InternalUnsafeMethods.HasContact__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.HasContact()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public int GetContactTime() {
             InternalUnsafeMethods.GetContactTime__Args _args = new InternalUnsafeMethods.GetContactTime__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetContactTime()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public Point3F GetContactPoint() {
             InternalUnsafeMethods.GetContactPoint__Args _args = new InternalUnsafeMethods.GetContactPoint__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetContactPoint()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public int GetContactObject() {
             InternalUnsafeMethods.GetContactObject__Args _args = new InternalUnsafeMethods.GetContactObject__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetContactObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public int GetContactMaterial() {
             InternalUnsafeMethods.GetContactMaterial__Args _args = new InternalUnsafeMethods.GetContactMaterial__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetContactMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public Point3F GetContactNormal() {
             InternalUnsafeMethods.GetContactNormal__Args _args = new InternalUnsafeMethods.GetContactNormal__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetContactNormal()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public int GetBestContact() {
             InternalUnsafeMethods.GetBestContact__Args _args = new InternalUnsafeMethods.GetBestContact__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetBestContact()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of contacts this collider has hit.
        /// </description>
        /// <returns>The number of static fields defined on the object.</returns>
        public int GetNumberOfContacts() {
             InternalUnsafeMethods.GetNumberOfContacts__Args _args = new InternalUnsafeMethods.GetNumberOfContacts__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumberOfContacts()(ObjectPtr, _args);
             return _engineResult;
        }


        /// <value>
        /// <description>
        /// The type of mesh data to use for collision queries.
        /// </description>
        /// </value>
        public CollisionMeshMeshType CollisionType {
            get => GenericMarshal.StringTo<CollisionMeshMeshType>(GetFieldValue("CollisionType"));
            set => SetFieldValue("CollisionType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The type of mesh data to use for collision queries.
        /// </description>
        /// </value>
        public CollisionMeshMeshType LineOfSightType {
            get => GenericMarshal.StringTo<CollisionMeshMeshType>(GetFieldValue("LineOfSightType"));
            set => SetFieldValue("LineOfSightType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The type of mesh data to use for collision queries.
        /// </description>
        /// </value>
        public CollisionMeshMeshType DecalType {
            get => GenericMarshal.StringTo<CollisionMeshMeshType>(GetFieldValue("DecalType"));
            set => SetFieldValue("DecalType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The type of mesh data to use for collision queries.
        /// </description>
        /// </value>
        public string CollisionMeshPrefix {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CollisionMeshPrefix"));
            set => SetFieldValue("CollisionMeshPrefix", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool BlockCollisions {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("BlockCollisions"));
            set => SetFieldValue("BlockCollisions", GenericMarshal.ToString(value));
        }
    }
}