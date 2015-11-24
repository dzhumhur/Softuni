namespace _01.Point3D
{

    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);
        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartPoint
        {
            get { return StartingPoint; }
        }

        public override string ToString()
        {
            return string.Format("-> Coordinates:\n - X = {0}\n - Y = {1}\n - Z = {2}",
                                this.X,
                                this.Y,
                                this.Z);
        }
    }
}
