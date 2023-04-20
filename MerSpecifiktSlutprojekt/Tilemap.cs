using System;

public class Tilemap
{
    public int tileSize = 100;
    public int rows = 6;
    public int columns = 8;

    private Tiles tiles;
    private RedTile redTile;
    public List list = new();
    public Stack<Tiles> stack = new();

    public Tilemap()
    {
        tiles = new Tiles();
        redTile = new RedTile();
    }

    public void Update() 
    {

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
