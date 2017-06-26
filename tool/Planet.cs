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
        private System.Windows.Forms.PictureBox Representation;
        public Planet()
        {

        }
        public Planet(string newName, Vector3 newPosition)
        {
            Name = newName;
            Galactic_Position = newPosition;
        }
        public Planet(string newName, String newPosition)
        {
            Name = newName;
            Galactic_Position = ConvertStringToV3(newPosition);
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
        public System.Windows.Forms.PictureBox Draw()
        {
            Representation = new System.Windows.Forms.PictureBox();
            Representation.Height = 20;
            Representation.Width = 20;
            //Representation.BackColor = System.Drawing.Color.PaleGreen;
            Representation.Paint += new System.Windows.Forms.PaintEventHandler(Representation_Paint);
            Representation.MouseEnter += new System.EventHandler(Representation_MouseEnter);
            System.Windows.Forms.ToolTip ttip = new System.Windows.Forms.ToolTip();
            ttip.SetToolTip(Representation, Name);
            return Representation;
        }
        private void Representation_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Tomato, 2);
            System.Drawing.SolidBrush myb = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            g.DrawEllipse(p, 1, 1, 17, 17);
            g.FillEllipse(myb, 1, 1, 17, 17);
            p.Dispose();
        }

        private void Representation_MouseEnter(object sender, EventArgs e)
        {
            Console.Write("Mouse over {0}\n", Name);
        }
    }
}
