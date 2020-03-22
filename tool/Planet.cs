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
        private System.Windows.Forms.ToolTip RepresentationTTIP = new System.Windows.Forms.ToolTip();
        public Planet()
        {

        }
        public Planet(string newName, Vector3 newPosition)
        {
            Name = newName;
            Galactic_Position = newPosition;
            int absX = (int)Galactic_Position.X;
            int absY = (int)Galactic_Position.Y;
            if (absX < 0)
                absX = absX * (-1);
            if (absY < 0)
                absY = absY * (-1);
            if (absX > tool.Global.PROJECT_SCALE_)
                tool.Global.PROJECT_SCALE_ = absX + tool.Global.PROJECT_SCALE_VARIANT_;
            if (absY > tool.Global.PROJECT_SCALE_)
                tool.Global.PROJECT_SCALE_ = absY + tool.Global.PROJECT_SCALE_VARIANT_;
            if (tool.Global.PROJECT_SCALE_ > tool.Global.PROJECT_MAX_SCALE_)
                 tool.Global.PROJECT_MAX_SCALE_ = tool.Global.PROJECT_SCALE_;
        }
        public Planet(string newName, String newPosition)
        {
            Name = newName;
            Galactic_Position = ConvertStringToV3(newPosition);
            int absX = (int)Galactic_Position.X;
            int absY = (int)Galactic_Position.Y;
            if (absX < 0)
                absX = absX * (-1);
            if (absY < 0)
                absY = absY * (-1);
            if (absX > tool.Global.PROJECT_SCALE_)
                tool.Global.PROJECT_SCALE_ = absX + tool.Global.PROJECT_SCALE_VARIANT_;
            if (absY > tool.Global.PROJECT_SCALE_)
                tool.Global.PROJECT_SCALE_ = absY + tool.Global.PROJECT_SCALE_VARIANT_;
            if (tool.Global.PROJECT_SCALE_ > tool.Global.PROJECT_MAX_SCALE_)
                tool.Global.PROJECT_MAX_SCALE_ = tool.Global.PROJECT_SCALE_;
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
            Representation.MouseLeave += new System.EventHandler(Representation_MouseLeave);
            Representation.MouseDown += new System.Windows.Forms.MouseEventHandler(Representation_MouseDown);
            Representation.MouseMove += new System.Windows.Forms.MouseEventHandler(Representation_MouseMove);
            Representation.MouseUp += new System.Windows.Forms.MouseEventHandler(Representation_MouseUp);        
            System.Drawing.Point Position = ImageSpaceCoordinates(CalculateRelativePositionFromGCPosition(Galactic_Position));
            Position.X -= 10;
            Position.Y -= 10;
            Representation.Location = Position;
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
            ToolState CurrAppState = Global.APP_STATE_;
            switch (CurrAppState)
            {
                case ToolState.SELECT_MOVE_:
                    Representation.Cursor = System.Windows.Forms.Cursors.Cross;
                    break;
                default:
                    break;
            }

           RepresentationTTIP = new System.Windows.Forms.ToolTip
            {
                AutoPopDelay = 15000,  // Warning! MSDN states this is Int32, but anything over 32767 will fail.
                ShowAlways = true,
                ToolTipTitle = Name,
                InitialDelay = 200,
                ReshowDelay = 200,
                UseAnimation = true
            };
            RepresentationTTIP.SetToolTip(Representation, "Galactic position:\n\t" + Galactic_Position.ToString());
#if DEBUG
            Console.Write("Mouse over {0}\n", Name);
#endif
        }
        private void Representation_MouseLeave(object sender, EventArgs e)
        {
            RepresentationTTIP.Active = false;
            ToolState CurrAppState = Global.APP_STATE_;
            switch (CurrAppState)
            {
                case ToolState.SELECT_MOVE_:
                    Representation.Cursor = System.Windows.Forms.Cursors.Default;
                    break;
                default:
                    break;
            }
        }
        private void Representation_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ToolState CurrAppState = Global.APP_STATE_;
            switch (CurrAppState)
            {
                case ToolState.SELECT_MOVE_:
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
#if DEBUG
                        Console.Write(Global.APP_SELECT_MOVE_);
#endif
                    }
                    break;
                case ToolState.ADD_REMOVE_:
#if DEBUG
                    Console.Write(Global.APP_ADD_REMOVE_);
#endif
                    break;
                default:
#if DEBUG
                    Console.Write(Global.APP_STATE_DEFAULT_CASE_);
#endif
                    break;
            }
        }

        private void Representation_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ToolState CurrAppState = Global.APP_STATE_;
            switch (CurrAppState)
            {
                case ToolState.SELECT_MOVE_:
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        System.Drawing.Point tempLocation = Representation.Parent.PointToClient(System.Windows.Forms.Cursor.Position);
                        tempLocation.X = Global.Clamp(tempLocation.X, Global.CANVAS_SIZE_, 0) - 10;
                        tempLocation.Y = Global.Clamp(tempLocation.Y, Global.CANVAS_SIZE_, 0) - 10;
                        Representation.Location = tempLocation;
#if DEBUG
                        Console.Write("New location {0}\n", Representation.Location);
#endif
                    }
                    break;
                default:
                    break;
            }
        }
        private void Representation_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ToolState CurrAppState = Global.APP_STATE_;
            switch (CurrAppState)
            {
                case ToolState.SELECT_MOVE_:
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        UpdatePlanetPosition();
                    }
                    break;
                default:
                    break;
            }
        }
        public void UpdatePlanetPosition()
        {
            tool.Global.PROJECT_DIRTY_ = true;
            System.Drawing.Point newPlanetLocation = Representation.Location;
            System.Drawing.PointF newRelativePlanetLocation = CalculateRelativePositionFromWindowposition(newPlanetLocation);
            Vector3 NewGalacticCoordinates = GalacticSpaceCoordinates(newRelativePlanetLocation);
            Galactic_Position = NewGalacticCoordinates;
#if DEBUG
            Console.Write("New absolute planet location {0}\n", newPlanetLocation);
            Console.Write("New relative planet location {0}\n", newRelativePlanetLocation);
            Console.Write("New galactic planet location {0}\n", NewGalacticCoordinates);
#endif
        }
        private Vector3 CalculateRelativePositionFromGCPosition(Vector3 absolutePosition)
        {
            Vector3 relativePosition = new Vector3(0.0f, 0.0f, 10.0f);
            relativePosition.X = tool.Global.Clamp(absolutePosition.X / tool.Global.PROJECT_SCALE_, 1.0f, -1.0f);
            relativePosition.Y = tool.Global.Clamp(absolutePosition.Y / tool.Global.PROJECT_SCALE_, 1.0f, -1.0f);
#if DEBUG
            Console.Write("    Converting absolute position {0} to relative position {1}\n", absolutePosition, relativePosition);
#endif
            return relativePosition;
        }
        private System.Drawing.PointF CalculateRelativePositionFromWindowposition(System.Drawing.Point newPlanetLocation)
        {
            newPlanetLocation.X += 10;
            newPlanetLocation.Y += 10;
            System.Drawing.PointF newRelativePlanetLocation = newPlanetLocation;
            newRelativePlanetLocation.X = Global.Clamp(newRelativePlanetLocation.X / Representation.Parent.Width, 1.0f, 0);
            newRelativePlanetLocation.Y = Global.Clamp(newRelativePlanetLocation.Y / Representation.Parent.Width, 1.0f, 0);
#if DEBUG
            Console.Write("    Converting absolute position {0} to relative position {1}\n", newPlanetLocation, newRelativePlanetLocation);
#endif
            return newRelativePlanetLocation;
        }
        private System.Drawing.Point ImageSpaceCoordinates(Vector3 relativePosition)
        {
            System.Drawing.Point imageSpacePosition = new System.Drawing.Point(0, 0);
            int canvasAbsoluteWidth = tool.Global.CANVAS_SIZE_;
            float canvasRelativeScaleDenom = canvasAbsoluteWidth;
            System.Drawing.PointF relativePosF = new System.Drawing.PointF((relativePosition.X + 1) * 0.5f, (relativePosition.Y - 1) * (-0.5f));
            imageSpacePosition.X = (int)(relativePosF.X * canvasRelativeScaleDenom);
            imageSpacePosition.Y = (int)(relativePosF.Y * canvasRelativeScaleDenom);
            return imageSpacePosition;
        }
        private Vector3 GalacticSpaceCoordinates(System.Drawing.PointF relativePosition)
        {
            Vector3 NewGalacticCoordinates = new Vector3(0.0f, 0.0f, 10.0f);
            System.Drawing.PointF relativePosF = new System.Drawing.PointF((relativePosition.X * 2.0f) - 1.0f, (relativePosition.Y * (-2.0f)) + 1.0f);
            relativePosF.X = tool.Global.Clamp(relativePosF.X, 1.0f, -1.0f);
            relativePosF.Y = tool.Global.Clamp(relativePosF.Y, 1.0f, -1.0f);
            relativePosF.X = relativePosF.X * tool.Global.PROJECT_SCALE_;
            relativePosF.Y = relativePosF.Y * tool.Global.PROJECT_SCALE_;

            NewGalacticCoordinates.X = (int)relativePosF.X;
            NewGalacticCoordinates.Y = (int)relativePosF.Y;

            return NewGalacticCoordinates;
        }
        private Vector3 CalculateAbsolutePosition(Vector3 relativePosition)
        {
            Vector3 absolutePosition = new Vector3(0, 0, 10);
            absolutePosition.X = relativePosition.X * tool.Global.PROJECT_SCALE_;
            absolutePosition.Y = relativePosition.Y * tool.Global.PROJECT_SCALE_;
            return absolutePosition;
        }
        public string V3ToGalacticPos()
        {
            string retStr = Galactic_Position.X.ToString("n1") + ", " + Galactic_Position.Y.ToString("n1") + ", " + Galactic_Position.Z.ToString("n1");
#if DEBUG
            Console.Write("Galactic Position:" + retStr + "\n");
#endif
            return retStr;
        }

    }
}
