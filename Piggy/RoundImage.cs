using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy
{
     class RoundImage:PictureBox

    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Create ellipse path
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            // Set the region for the ellipse
            this.Region = new System.Drawing.Region(grpath);

            // Draw the ellipse with a thicker shadow
            DrawShadow(pe.Graphics, grpath, 8); // Adjust the shadow thickness as needed

            base.OnPaint(pe);
        }

        private void DrawShadow(Graphics g, GraphicsPath path, int shadowThickness)
        {
            // Create a thicker shadow effect by increasing the translation distance
            Matrix shadowMatrix = new Matrix();
            shadowMatrix.Translate(shadowThickness, shadowThickness); // Adjust the shadow position and thickness as needed

            // Create a brush for the shadow color (e.g., Color.Gray)
            using (Brush shadowBrush = new SolidBrush(Color.Gray))
            {
                g.Transform = shadowMatrix;
                g.FillPath(shadowBrush, path);
                g.ResetTransform();
            }
        }

    }


}
