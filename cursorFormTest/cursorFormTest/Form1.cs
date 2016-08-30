using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursorFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xDiff;
        int yDiff;

        public Timer t;

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);

            this.Location = new Point(Cursor.Position.X - 16, Cursor.Position.Y - 20);

            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;

            xDiff = pictureBox1.Location.X - this.Location.X;
            yDiff = pictureBox1.Location.Y - this.Location.Y;

            //t = new Timer();
            //t.Interval = 1000;
            //t.Tick += timerHandler;
            //t.Start();
            Cursor.Hide();

            this.MouseMove += theMouseMove;
            
        }

        private void theMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path that is drawn onto the Panel.
            this.Location = new Point(Cursor.Position.X - (410), Cursor.Position.Y - (200));
        }

        private void timerHandler(object sender, EventArgs e)
        {
            t.Stop();
            Cursor.Hide();
            t = new Timer();
            t.Interval = 4000;
            t.Tick += timerHandler2;
            t.Start();
        }

        private void timerHandler2(object sender, EventArgs e)
        {
            t.Stop();
            Cursor.Show();
        }
    }
}
