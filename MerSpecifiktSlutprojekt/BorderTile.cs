using System;


public class BorderTile: Tiles // information specifik för BorderTile
{
    public BorderTile()
    {
        color = Color.GRAY;
        tile = new Rectangle(0,0,tileSize,tileSize);
    }

    public void Draw()
    {
        
    }
}
