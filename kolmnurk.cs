using System;
using System.Drawing;
using System.Windows.Forms;

namespace kolmnurk1
{
    class kolmnurk
    {
        public double a;
        public double b;
        public double c;
        public kolmnurk(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriange
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return false;
                else return true;
            }
        }
    }









    public partial class kolmnurk1 : Form
    {
        Button btn;
        PictureBox tP;

        public kolmnurk1()
        {
            this.Size = new Size(800, 400);
            this.Text = "Работа с треугольником";


            btn = new Button();
            btn.Text = "Запуск";
            btn.BackColor = Color.FromArgb(255, 255, 192);
            btn.Font = new Font("Arial", 28);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btn.FlatAppearance.BorderSize = 10;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Size = new Size(200, 100);
            btn.Location = new Point(500, 40);
            Controls.Add(btn);

            tP = new PictureBox();
            tP.Size = new Size(200, 200);
            tP.Location = new Point(50, 50);
            tP.BackgroundImage = Image.FromFile(@"..\..\..\triangle.png");
            Controls.Add(tP);

        }
    }
}
