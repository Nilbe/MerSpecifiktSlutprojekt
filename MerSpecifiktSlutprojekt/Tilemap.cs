using System;

public class Tilemap
{
    public const int screenWidth = 800;
    public const int screenHeight = 450;
    public const int tileSize = 32;
    public const int tilesX = screenWidth / tileSize;
    public const int tilesY = screenHeight / tileSize;
    public int x = 0;
    public int y = 0;

    public List<Tiles> tiles = new();

    public void Update() 
    {    
    }

    public void Draw()
    {
        for (x = 0; x < tilesX; x++)
        {
            for (y = 0; y < tilesY; y++)
            {
                
                Raylib.DrawRectangleLinesEx(tile, 1, Color.BLACK);
            }
        }
        Raylib.EndDrawing();
    }
}
