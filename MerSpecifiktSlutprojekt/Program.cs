global using Raylib_cs;
global using System.Numerics;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "");

Tilemap tilemap = new Tilemap();

while (!Raylib.WindowShouldClose())     //utritning av Area
{
    tilemap.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    tilemap.Draw();

    Raylib.EndDrawing();
}