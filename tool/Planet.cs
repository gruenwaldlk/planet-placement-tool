using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlanetPlacementTool.tool
{
    public class Planet
    {
        public string Name { get; set; }
        public Vector3 Galactic_Position { get; set; }
        public bool Drawn { get; set; }
        public Planet()
        {

        }
        public Planet(string newName, Vector3 newPosition)
        {
            Name = newName;
            Galactic_Position = newPosition;
            Drawn = false;
        }
        public Planet(string newName, String newPosition)
        {
            Name = newName;
            Galactic_Position = ConvertStringToV3(newPosition);
            Drawn = false;
        }

        private Vector3 ConvertStringToV3(string ConvertVal)
        {
            Vector3 retVec3 = new Vector3(0, 0, 0);
            string[] v3 = ConvertVal.Split(new Char[] {','});
            retVec3.X = float.Parse(v3[0]);
            retVec3.Y = float.Parse(v3[1]);
            // we omitt the Z-value
            retVec3.Z = 10;
#if DEBUG
            Console.WriteLine("String to V3 conversion\t{0}: {1} {2} {3}", ConvertVal, retVec3.X.ToString("n1"), retVec3.Y.ToString("n1"), retVec3.Z.ToString("n1"));
#endif
            return retVec3;
        }
    }
}
