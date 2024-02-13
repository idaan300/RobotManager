namespace RobotMananager.CustomControls;

public class PlayfieldOverview : Panel {
    //TODO Stuff
    //Entity Class
    //DrawRectRelative
    //Helper Stuff

    const Int32 WallWidth = 10;
    const Int32 EntitySize = 50;
    const Int32 GridSize = 50;

    DataStructures.Map Map = new();

    protected override void OnPaint(PaintEventArgs e) {
        Map.FillMap();
        DrawMap_BackGround(e.Graphics, this);
        DrawMap_Border(e.Graphics, this);
        DrawMap_Entities(e.Graphics);
    }


    public void Update(DataStructures.Map M) {
        Map = M;
        Invalidate();
        Refresh();
    }

    private void DrawMap_Entities(Graphics G) {
        for (int Y = 0; Y < 11; Y++) {

            for (int X = 0; X < 11; X++) {
                DrawEntity_Wall(G, X, Y);
                DrawEntity_Spawn(G, X, Y);
            }
        }
    }

    private void DrawEntity_Wall(Graphics G, Int32 X, Int32 Y) {
        if (Map.GetTile(X, Y) == DataStructures.VisualTileType.Wall)
            _ = new Entity(G, X, Y, Color.SaddleBrown);
    }

    private void DrawEntity_Spawn(Graphics G, Int32 X, Int32 Y) {
        if (Map.GetTile(X, Y) == DataStructures.VisualTileType.Spawn1)
            _ = new Entity(G, X, Y, Color.DeepPink);

        if (Map.GetTile(X, Y) == DataStructures.VisualTileType.Spawn2)
            _ = new Entity(G, X, Y, Color.DarkBlue);

        if (Map.GetTile(X, Y) == DataStructures.VisualTileType.Spawn3)
            _ = new Entity(G, X, Y, Color.DarkOrange);

        if (Map.GetTile(X, Y) == DataStructures.VisualTileType.Spawn4)
            _ = new Entity(G, X, Y, Color.DarkRed);
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

    private static void DrawMap_Border(Graphics G, Panel Pnl) {

        Brush Brsh = new SolidBrush(Color.Black);

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

    public class Entity {

        public Entity(Graphics G, Int32 GridX, Int32 GridY , Color C) {

            Brush EntBrush = new SolidBrush(C);
            Point[] Obj = new Point[] {
            new ((WallWidth + GridX * GridSize), (WallWidth + GridY * GridSize)), //Topleft
            new ((WallWidth + GridX * GridSize) + (EntitySize - WallWidth / 11) , (WallWidth + GridY * GridSize)), //TopRight
            new ((WallWidth + GridX * GridSize) + (EntitySize - WallWidth / 11), (WallWidth + GridY * GridSize) + (EntitySize - WallWidth / 11)), //BottomRight
            new ((WallWidth + GridX * GridSize), (WallWidth + GridY * GridSize) + (EntitySize - WallWidth / 11)), //BottomLeft
            };

            G.FillPolygon(EntBrush, Obj);
        }


    }

    public class EntityFlag {

        public EntityFlag(Graphics G, Int32 GridX, Int32 GridY, Color C) {

            TextRenderer.DrawText(G, "FL", new Font("Consolas", 25, FontStyle.Regular), new Point((WallWidth + GridX * GridSize) - 2, (WallWidth + GridY * GridSize) + 5), C);

        }

    }





}
