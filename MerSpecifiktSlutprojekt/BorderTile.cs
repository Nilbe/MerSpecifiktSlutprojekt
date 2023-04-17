using System;


public class BorderTile: Tiles
{
    public BorderTile()
    {
        color = Color.GRAY;
        tile = new Rectangle(0,0,tileSize,tileSize);
    }
}
