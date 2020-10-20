using System;
using Raylib_cs;

namespace Graphics
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Hello TE!");

      Color myColor = new Color(0, 255, 128, 255);

      float x = 0;

      while (!Raylib.WindowShouldClose())
      {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
          x += .1f;
        }

        Raylib.BeginDrawing();

        Raylib.ClearBackground(myColor);

        Raylib.DrawRectangle((int)x, 0, 20, 20, Color.PINK);


        Raylib.EndDrawing();

      }


    }
  }
}
