using _01.Point3D;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Paths
{
    public static class Storage
    {
        public static Path3D Load(string file)
        {
            Path3D loadedPath = new Path3D();
            using (StreamReader reader = new StreamReader("../../" + file + ".txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] currLine = line.Split(' ', '(', ')', ',');
                    int x = int.Parse(currLine[1]);
                    int y = int.Parse(currLine[3]);
                    int z = int.Parse(currLine[5]);
                    loadedPath.Add(new Point3D(x, y, z));

                    line = reader.ReadLine();
                }
            }

            return loadedPath;
        }
        

        public static void Save(string file, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter("../../" + file + ".txt"))
            {
                foreach (var currPoint in path.Points)
                {
                    writer.WriteLine("({0}, {1}, {2})", currPoint.X, currPoint.Y, currPoint.Z);
                }
            }
        }
    }
}
