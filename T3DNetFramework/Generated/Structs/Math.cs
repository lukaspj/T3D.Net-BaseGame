using System;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Interop;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Structs.Math {

    public class RotationF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public float x;
            [FieldOffset(4)] public float y;
            [FieldOffset(8)] public float z;
            [FieldOffset(12)] public float w;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public RotationF() { }

        public RotationF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public RotationF(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<float>(strings[0]);
            Y = GenericMarshal.StringTo<float>(strings[1]);
            Z = GenericMarshal.StringTo<float>(strings[2]);
            W = GenericMarshal.StringTo<float>(strings[3]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStruct.z = Z;
            internalStruct.w = W;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            Z = internalStruct.z;
            W = internalStruct.w;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);
            s += " " + GenericMarshal.ToString(Z);
            s += " " + GenericMarshal.ToString(W);

            return s.Substring(1);
        }
    }

    public class EaseF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public int dir;
            [FieldOffset(4)] public int type;
            [FieldOffset(8)] public IntPtr param;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public int Dir { get; set; }
        public int Type { get; set; }
        public float[] Param { get; set; }

        public EaseF() { }

        public EaseF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public EaseF(string s) {
            string[] strings = s.Split(' ');
            Dir = GenericMarshal.StringTo<int>(strings[0]);
            Type = GenericMarshal.StringTo<int>(strings[1]);
            Param = GenericMarshal.StringTo<float[]>(strings[2]);

        }

        public void Alloc() {
            internalStruct.dir = Dir;
            internalStruct.type = Type;
            internalStruct.param = GenericMarshal.ToPtr(Param);
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            Dir = internalStruct.dir;
            Type = internalStruct.type;
            Param = GenericMarshal.FromPtr<float>(internalStruct.param, 2, true);
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(Dir);
            s += " " + GenericMarshal.ToString(Type);
            s += " " + GenericMarshal.ToString(Param);

            return s.Substring(1);
        }
    }

    public class Box3F : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public Point3F.InternalStruct minExtents;
            [FieldOffset(12)] public Point3F.InternalStruct maxExtents;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public Point3F MinExtents { get; set; }
        public Point3F MaxExtents { get; set; }

        public Box3F() { }

        public Box3F(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Box3F(string s) {
            string[] strings = s.Split(' ');
            MinExtents = GenericMarshal.StringTo<Point3F>(strings[0]);
            MaxExtents = GenericMarshal.StringTo<Point3F>(strings[1]);

        }

        public void Alloc() {
            MinExtents.Alloc();internalStruct.minExtents = MinExtents.internalStruct;
            MaxExtents.Alloc();internalStruct.maxExtents = MaxExtents.internalStruct;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            MinExtents.internalStruct = internalStruct.minExtents; MinExtents.Free();
            MaxExtents.internalStruct = internalStruct.maxExtents; MaxExtents.Free();
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(MinExtents);
            s += " " + GenericMarshal.ToString(MaxExtents);

            return s.Substring(1);
        }
    }

    public class TransformF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public Point3F.InternalStruct position;
            [FieldOffset(12)] public AngAxisF.InternalStruct orientation;
            [FieldOffset(28)] public bool hasRotation;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public Point3F Position { get; set; }
        public AngAxisF Orientation { get; set; }
        public bool HasRotation { get; set; }

        public TransformF() { }

        public TransformF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public TransformF(string s) {
            string[] strings = s.Split(' ');
            Position = GenericMarshal.StringTo<Point3F>(strings[0]);
            Orientation = GenericMarshal.StringTo<AngAxisF>(strings[1]);
            HasRotation = GenericMarshal.StringTo<bool>(strings[2]);

        }

        public void Alloc() {
            Position.Alloc();internalStruct.position = Position.internalStruct;
            Orientation.Alloc();internalStruct.orientation = Orientation.internalStruct;
            internalStruct.hasRotation = HasRotation;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            Position.internalStruct = internalStruct.position; Position.Free();
            Orientation.internalStruct = internalStruct.orientation; Orientation.Free();
            HasRotation = internalStruct.hasRotation;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(Position);
            s += " " + GenericMarshal.ToString(Orientation);
            s += " " + GenericMarshal.ToString(HasRotation);

            return s.Substring(1);
        }
    }

    public class AngAxisF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public Point3F.InternalStruct axis;
            [FieldOffset(12)] public float angle;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public Point3F Axis { get; set; }
        public float Angle { get; set; }

        public AngAxisF() { }

        public AngAxisF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public AngAxisF(string s) {
            string[] strings = s.Split(' ');
            Axis = GenericMarshal.StringTo<Point3F>(strings[0]);
            Angle = GenericMarshal.StringTo<float>(strings[1]);

        }

        public void Alloc() {
            Axis.Alloc();internalStruct.axis = Axis.internalStruct;
            internalStruct.angle = Angle;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            Axis.internalStruct = internalStruct.axis; Axis.Free();
            Angle = internalStruct.angle;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(Axis);
            s += " " + GenericMarshal.ToString(Angle);

            return s.Substring(1);
        }
    }

    public class MatrixF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public IntPtr m;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public float[] M { get; set; }

        public MatrixF() { }

        public MatrixF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public MatrixF(string s) {
            string[] strings = s.Split(' ');
            M = GenericMarshal.StringTo<float[]>(strings[0]);

        }

        public void Alloc() {
            internalStruct.m = GenericMarshal.ToPtr(M);
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            M = GenericMarshal.FromPtr<float>(internalStruct.m, 16, true);
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(M);

            return s.Substring(1);
        }
    }

    public class RectF : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public Point2F.InternalStruct point;
            [FieldOffset(8)] public Point2F.InternalStruct extent;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public Point2F Point { get; set; }
        public Point2F Extent { get; set; }

        public RectF() { }

        public RectF(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public RectF(string s) {
            string[] strings = s.Split(' ');
            Point = GenericMarshal.StringTo<Point2F>(strings[0]);
            Extent = GenericMarshal.StringTo<Point2F>(strings[1]);

        }

        public void Alloc() {
            Point.Alloc();internalStruct.point = Point.internalStruct;
            Extent.Alloc();internalStruct.extent = Extent.internalStruct;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            Point.internalStruct = internalStruct.point; Point.Free();
            Extent.internalStruct = internalStruct.extent; Extent.Free();
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(Point);
            s += " " + GenericMarshal.ToString(Extent);

            return s.Substring(1);
        }
    }

    public class RectI : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public Point2I.InternalStruct point;
            [FieldOffset(8)] public Point2I.InternalStruct extent;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public Point2I Point { get; set; }
        public Point2I Extent { get; set; }

        public RectI() { }

        public RectI(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public RectI(string s) {
            string[] strings = s.Split(' ');
            Point = GenericMarshal.StringTo<Point2I>(strings[0]);
            Extent = GenericMarshal.StringTo<Point2I>(strings[1]);

        }

        public void Alloc() {
            Point.Alloc();internalStruct.point = Point.internalStruct;
            Extent.Alloc();internalStruct.extent = Extent.internalStruct;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            Point.internalStruct = internalStruct.point; Point.Free();
            Extent.internalStruct = internalStruct.extent; Extent.Free();
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(Point);
            s += " " + GenericMarshal.ToString(Extent);

            return s.Substring(1);
        }
    }

    public class Point4F : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public float x;
            [FieldOffset(4)] public float y;
            [FieldOffset(8)] public float z;
            [FieldOffset(12)] public float w;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public Point4F() { }

        public Point4F(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Point4F(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<float>(strings[0]);
            Y = GenericMarshal.StringTo<float>(strings[1]);
            Z = GenericMarshal.StringTo<float>(strings[2]);
            W = GenericMarshal.StringTo<float>(strings[3]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStruct.z = Z;
            internalStruct.w = W;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            Z = internalStruct.z;
            W = internalStruct.w;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);
            s += " " + GenericMarshal.ToString(Z);
            s += " " + GenericMarshal.ToString(W);

            return s.Substring(1);
        }
    }

    public class Point3F : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public float x;
            [FieldOffset(4)] public float y;
            [FieldOffset(8)] public float z;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3F() { }

        public Point3F(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Point3F(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<float>(strings[0]);
            Y = GenericMarshal.StringTo<float>(strings[1]);
            Z = GenericMarshal.StringTo<float>(strings[2]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStruct.z = Z;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            Z = internalStruct.z;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);
            s += " " + GenericMarshal.ToString(Z);

            return s.Substring(1);
        }
    }

    public class Point3I : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public int x;
            [FieldOffset(4)] public int y;
            [FieldOffset(8)] public int z;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3I() { }

        public Point3I(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Point3I(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<int>(strings[0]);
            Y = GenericMarshal.StringTo<int>(strings[1]);
            Z = GenericMarshal.StringTo<int>(strings[2]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStruct.z = Z;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            Z = internalStruct.z;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);
            s += " " + GenericMarshal.ToString(Z);

            return s.Substring(1);
        }
    }

    public class Point2F : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public float x;
            [FieldOffset(4)] public float y;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public float X { get; set; }
        public float Y { get; set; }

        public Point2F() { }

        public Point2F(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Point2F(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<float>(strings[0]);
            Y = GenericMarshal.StringTo<float>(strings[1]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);

            return s.Substring(1);
        }
    }

    public class Point2I : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public int x;
            [FieldOffset(4)] public int y;
        }

        public InternalStruct internalStruct;

        public IntPtr internalStructPtr;

        public int X { get; set; }
        public int Y { get; set; }

        public Point2I() { }

        public Point2I(InternalStruct data) {
            internalStruct = data;
			Free();
        }

        public Point2I(string s) {
            string[] strings = s.Split(' ');
            X = GenericMarshal.StringTo<int>(strings[0]);
            Y = GenericMarshal.StringTo<int>(strings[1]);

        }

        public void Alloc() {
            internalStruct.x = X;
            internalStruct.y = Y;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }

        public void Free() {
            X = internalStruct.x;
            Y = internalStruct.y;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }

        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(X);
            s += " " + GenericMarshal.ToString(Y);

            return s.Substring(1);
        }
    }

}
