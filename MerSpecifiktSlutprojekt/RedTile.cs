using System;

public class RedTile: Tiles
{
    public RedTile()
    {
        color = Color.RED;
        tile = new Rectangle(200,300,tileSize,tileSize);
    }
}
