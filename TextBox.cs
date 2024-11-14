using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace rayvn
{
    internal class TextBox : Drawable
    {
        public int x = 0;
        public int y = 0;
        public int width = 0;
        public int height = 0;
        public string text = "";
        public Rectangle rec;
        public Color color;

        public TextBox(int x, int y, int width, int height, Color color, string text)
        {
            this.text = text;
            this.color = color;
            this.rec = new Rectangle(x, y, width, height);
        }

        public void updateText(string text)
        {
            this.text = text;
        }
        public void draw()
        {
            Raylib.DrawRectangleRounded(rec, 0.5f, 1, this.color);
        }
    }
}
