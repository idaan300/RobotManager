using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace RobotMananager.CustomControls;

public class PlayfieldOverview : Panel {
    //TODO Stuff
    //Entity Class
    //DrawRectRelative
    //Helper Stuff

    const Int32 WallWidth = 10;



    protected override void OnPaint(PaintEventArgs e) {
        DrawMap_BackGround(e.Graphics, this);
        DrawMap_Border(e.Graphics, this);


        //Brush brush = new SolidBrush(Color.DarkGreen);
        //Font A = new("Segoe UI", 16.0f, FontStyle.Regular);

        //g.FillPolygon(brush, points);

        //TextRenderer.DrawText(g, "Bean", A, new Point(125, 125), Color.DarkGoldenrod);


    }


    private static void DrawMap_BackGround(Graphics G, Panel Pnl) {
        Brush Brsh = new SolidBrush(Color.DarkCyan);

        Point[] BG = new Point[] {
            new (0, 0), //Topleft
            new (Pnl.Width, 0), //TopRight
            new (Pnl.Width, Pnl.Height),
            new (0, Pnl.Height),
        };

        G.FillPolygon(Brsh, BG);

    }

    private static void DrawMap_CheckerBoard(int x, Panel Pnl, Graphics G) {
        Brush Brsh = new SolidBrush(Color.DarkCyan);

        Point[] BG = new Point[] {
            new (0, 0), //Topleft
            new (Pnl.Width, 0), //TopRight
            new (Pnl.Width, Pnl.Height),
            new (0, Pnl.Height),
        };

        G.FillPolygon(Brsh, BG);

    }



    private static void DrawMap_Border(Graphics G, Panel Pnl) {

        Brush Brsh = new SolidBrush(Color.DarkBlue);

        Point[] WallL = new Point[] {
            new (0, 0), //Topleft
            new (WallWidth, 0), //TopRight
            new (WallWidth, Pnl.Height),  //BottomRight
            new (0, Pnl.Height),// BottomLeft
        };

        Point[] WallR = new Point[] {
            new (Pnl.Width, 0),
            new (Pnl.Width - WallWidth, 0),
            new (Pnl.Width - WallWidth, Pnl.Height),
            new (Pnl.Width, Pnl.Height),
        };

        Point[] WallT = new Point[] {
            new (0, 0),
            new (Pnl.Width, 0),
            new (Pnl.Width, WallWidth),
            new (0, WallWidth),
        };

        Point[] WallB = new Point[] {
            new (0, Pnl.Height - WallWidth),
            new (Pnl.Width, Pnl.Height - WallWidth),
            new (Pnl.Width, Pnl.Height),
            new (0, Pnl.Height),
        };

        G.FillPolygon(Brsh, WallL);
        G.FillPolygon(Brsh, WallR);
        G.FillPolygon(Brsh, WallT);
        G.FillPolygon(Brsh, WallB);

    }
}
