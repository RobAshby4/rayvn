using Raylib_cs;
using rayvn;
using System.IO;

class Program
{
    public static void Main()
    {

        Raylib.InitWindow(800, 480, "Hello World");
        StreamReader reader = new StreamReader("./testinput.txt");
        string? text = "init text";
        TextBox dialogue_box = new TextBox(Raylib.GetScreenWidth() / 2 - 100, Raylib.GetScreenHeight() / 2 - 50, 200, 100, Color.Magenta, "wowsers");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                try
                {
                    text = reader.ReadLine();
                }
                catch(IOException e)
                {
                    Console.WriteLine("IO Error: " + e.Message);
                }
            }

            if (text == null)
            {
                break;
            }

            Raylib.DrawText(text, 12, 20, 20, Color.Black);
            dialogue_box.draw();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
