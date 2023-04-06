using System;

public class Tiles: Tilemap
{
    private Tilemap tilemap;
    protected Color color;

    public Tiles()
    {
        tilemap = new Tilemap();
        color = Color.WHITE;
        Rectangle rect = new Rectangle(x * tileSize,y * tileSize,tileSize,tileSize);
    }
}
