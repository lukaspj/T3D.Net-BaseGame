namespace T3DNetFramework.Engine.Structs
{
    public class AngAxisF : Generated.Structs.Math.AngAxisF
    {

        public AngAxisF(string s)
            : base(s)
        {
        }

        public AngAxisF(Point3F axis, float angle)
        {
            Axis = axis;
            Angle = angle;
        }

        public AngAxisF(float x, float y, float z, float angle)
        {
            Axis = new Point3F(x, y, z);
            Angle = angle;
        }
    }
}
