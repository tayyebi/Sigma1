using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms.Master
{
    public partial class Public : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Public()
        {

            InitializeComponent();


            bool mouseDown = false;

            panel1.MouseUp += delegate
            {
                mouseDown = false;
            };

            Point enter_location = new Point(0, 0);
            panel1.MouseMove += (sender, move_location) =>
            {
                if (mouseDown)
                {
                    this.Location = new Point(this.Location.X + (move_location.Location.X - enter_location.X), this.Location.Y + (move_location.Location.Y - enter_location.Y));
                    Update();
                }
            };
            panel1.MouseDown += (sender, args) =>
            {
                mouseDown = true;
                enter_location = args.Location;
            };
        }

        private void Public_Load(object sender, EventArgs e)
        {
     
        }

        private void rexaButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Public_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                this.DisplayRectangle);
        }
    }
}
