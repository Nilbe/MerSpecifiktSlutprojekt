using System;

public class Tilemap
{
    public int tileSize = 100;
    public int rows = 6;
    public int columns = 8;

    bool pickedUp = false;

    public Vector2 MousePosition;

    private Tiles tiles;
    private RedTile redTile;
    public Stack<Tiles> stack = new();

    public Tilemap()
    {
        tiles = new Tiles();
        redTile = new RedTile();

        MousePosition = Raylib.GetMousePosition();
    }

    public void Update() 
    {
        redTile.Update();

        if(Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(MousePosition, redTile.tile))
        {
            stack.Push(redTile);
            pickedUp = true;
        }
    }

    public void Draw()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Rectangle tileRect = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                Raylib.DrawRectangleLinesEx(tileRect, 1, Color.WHITE);
            }
        }

        redTile.Draw();

    }
}
