using System;

public class Tilemap
{
    public int tileSize = 100;
    public int rows = 6;
    public int columns = 8;

    public List<Tiles> tile = new();

    public void Update() 
    {    
    }

    public void Draw()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col =0; col < columns; col++)
            {
                Rectangle tileRect = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                Raylib.DrawRectangleLinesEx(tileRect, 1, Color.WHITE);
            }
        }
    }
}
