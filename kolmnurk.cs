using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sdcscsc
{
    public class kolmnurk1
    {
        public double a;
        public double b;
        public double c;

        public kolmnurk1() { }

        public kolmnurk1(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Surface()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool ExistTriangle
        {
            get { return (a + b > c) && (a + c > b) && (b + c > a); }
        }
    }

    public partial class Form1 : Form
    {
        Button btn;
        TextBox txtA, txtB, txtC;
        ListView listView1;
        Label lblA, lblB, lblC;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(850, 550);
            this.Text = "Работа с треугольником";

            btn = new Button
            {
                Text = "Запуск",
                BackColor = Color.FromArgb(255, 255, 192),
                Font = new Font("Arial", 28),
                Size = new Size(200, 100),
                Location = new Point(500, 40),
                Cursor = Cursors.Hand
            };
            btn.Click += Run_button_Click;
            Controls.Add(btn);


            lblA = new Label();
            lblA.Text = "Сторона A:";
            lblA.Font = new Font("Arial", 12, FontStyle.Underline);
            lblA.Size = new Size(100, 25);
            lblA.Location = new Point(150, 45);
            Controls.Add(lblA);

            lblB = new Label();
            lblB.Text = "Сторона B:";
            lblB.Font = new Font("Arial", 12, FontStyle.Underline);
            lblB.Size = new Size(100, 25);
            lblB.Location = new Point(150, 85);
            Controls.Add(lblB);

            lblC = new Label();
            lblC.Text = "Сторона C:";
            lblC.Font = new Font("Arial", 12, FontStyle.Underline);
            lblC.Size = new Size(100, 25);
            lblC.Location = new Point(150, 125);
            Controls.Add(lblC);


            txtA = CreateTextBox("", 0, 250, 40);
            txtB = CreateTextBox("", 0, 250, 80);
            txtC = CreateTextBox("", 0, 250, 120);


            listView1 = new ListView
            {
                Location = new Point(50, 200),
                Size = new Size(400, 150),
                View = View.Details,
                GridLines = true,
                FullRowSelect = true
            };

            listView1.Columns.Add("Поле", 200);
            listView1.Columns.Add("Значение", 200);

            Controls.Add(listView1);
        }

        private TextBox CreateTextBox(string labelText, double defaultValue, int x, int y)
        {
            Label label = new Label
            {
                Text = labelText,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(x - 100, y),
                AutoSize = true
            };
            Controls.Add(label);

            TextBox textBox = new TextBox
            {
                Text = defaultValue.ToString(),
                Font = new Font("Arial", 14),
                Location = new Point(x, y),
                Width = 100
            };
            Controls.Add(textBox);

            return textBox;
        }

        public void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            kolmnurk1 triangle = new kolmnurk1(a, b, c);
            listView1.Items.Clear();
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.a.ToString());
            listView1.Items[1].SubItems.Add(triangle.b.ToString());
            listView1.Items[2].SubItems.Add(triangle.c.ToString());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle)
                listView1.Items[5].SubItems.Add("Существует");
            else
                listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add("Спецификатор");
        }
    }
}
