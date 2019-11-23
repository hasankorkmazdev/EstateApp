﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.Main
{
    class RadiusImageBox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            this.BorderStyle = BorderStyle.None;
            base.OnPaint(pe);
        }
    }
}
