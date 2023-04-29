using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Networking;

namespace RobotMananager.CustomControls;

public class PlayfieldOverview : Panel {
    //TODO Stuff
    //Entity Class
    //DrawRectRelative
    //Helper Stuff




    protected override void OnPaint(PaintEventArgs e) {
        var g = e.Graphics;

        
        Point[] points = new Point[4];

        points[0] = new Point(0, 0);
        points[1] = new Point(0, 100);
        points[2] = new Point(100, 0);
        points[3] = new Point(200,100);


        Brush brush = new SolidBrush(Color.DarkGreen);
        Font A = new("Segoe UI", 16.0f, FontStyle.Regular);

        g.FillPolygon(brush, points);

        TextRenderer.DrawText(g, "Bean", A, new Point(50, 50), Color.DarkRed);


    }
}

