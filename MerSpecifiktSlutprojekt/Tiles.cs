using System;

public class Tiles // basklass för alla tiles i spelet
{
    protected Color color;
    public int tileSize = 100;

    public Tiles()
    {
        Rectangle tile = new Rectangle(0,0,tileSize,tileSize);
    }

    public virtual void Draw()
    {
        Raylib.DrawRectangleRec(tile, color);
    }

    public void Update()
    {
        
    }
    
    public Rectangle tile;
}