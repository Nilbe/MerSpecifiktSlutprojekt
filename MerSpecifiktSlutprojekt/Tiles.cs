using System;

public class Tiles: Tilemap
{
    protected Color color;

    public Tiles()
    {
        Rectangle tile = new Rectangle(0,0,32,32);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(tile, color);
    }

    public void Update()
    {
        
    }
    public Rectangle tile;
}