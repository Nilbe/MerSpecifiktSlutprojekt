using System;

public class RedTile: Tiles
{
    public RedTile()
    {
        color = Color.RED;
        tile = new Rectangle(0,0,tileSize,tileSize);
    }
}
