namespace RobotMananager.CustomControls;

public class PlayfieldOverview : Panel
{
    //TODO Stuff
    //Entity Class
    //DrawRectRelative
    //Helper Stuff




    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;


        Point[] points = new Point[4];
        //TopLeft
        points[0] = new Point(100, 100);
        //TopRight
        points[1] = new Point(200, 100);
        //BottomLeft
        points[2] = new Point(200, 200);
        //BottomRight
        points[3] = new Point(100, 200);


        Brush brush = new SolidBrush(Color.DarkGreen);
        Font A = new("Segoe UI", 16.0f, FontStyle.Regular);

        g.FillPolygon(brush, points);

        TextRenderer.DrawText(g, "Bean", A, new Point(125, 125), Color.DarkGoldenrod);


    }
}

