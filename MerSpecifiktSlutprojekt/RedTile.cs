using System;

public class RedTile: Tiles // information specifik för RedTile
{
    public RedTile()
    {
        color = Color.RED;
        tile = new Rectangle(200,300,tileSize,tileSize);
    }
}
