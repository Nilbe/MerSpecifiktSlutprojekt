global using Raylib_cs;
global using System.Numerics;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,450, "");

Tilemap tilemap = new Tilemap();

while (!Raylib.WindowShouldClose())     //utritning av Area
{
    tilemap.Update();

    Raylib.BeginDrawing();

    tilemap.Draw();

    Raylib.EndDrawing();
}