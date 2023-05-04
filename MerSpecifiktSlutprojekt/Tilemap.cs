using System;

public class Tilemap
{
    public int tileSize = 100;
    public int rows = 6;
    public int columns = 8;

    bool pickedUp = false;

    public Vector2 MousePosition;
    public Vector2 textPos = new Vector2(500,300);

    private Tiles tiles;
    private RedTile redTile;
    public Stack<Tiles> stack = new(); // en stack som förvarar de tiles man taggit upp

    public Tilemap()
    {
        tiles = new Tiles();
        redTile = new RedTile();
    }

    public void Update() // logik för att ta upp och plasera tiles
    {
        MousePosition = Raylib.GetMousePosition(); // sätter ut ett värde för vectoren MousePosition

        redTile.Update();

        if(Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(MousePosition, redTile.tile))
        {
            stack.Push(redTile);

            pickedUp = true;
        }
        else 
        {
            pickedUp = false;
        }
    }

    public void Draw() // utritandet av rutnätet och tilesen i det
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
