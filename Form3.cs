using System;
using System.Drawing;
using System.Windows.Forms;

namespace kolmnurk1
{
    internal class Form3 : Form
    {
        public Form3(int w, int h)
        {
            this.Width = w;
            this.Height = h;

            this.Text = "Форма 2";

            this.Size = new Size(500, 500);

            this.BackColor = Color.Pink;
        }
    }
}
