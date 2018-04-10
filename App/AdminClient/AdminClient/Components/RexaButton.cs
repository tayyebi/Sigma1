using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdminClient.Components
{
    public partial class RexaButton : Button
    {
        private Timer rexaTimer;
        private Color Default_LeaveBackColor;
        private Color Default_LeaveForeColor;
        public RexaButton()
        {
            InitializeComponent();
        }

        private void RexaTimer_Tick(object sender, EventArgs e)
        {
            ForeColor = Color.White;

            int r, g, b;

            r = BackColor.R;
            g = BackColor.G;
            b = BackColor.B;

            if (r > 0)
                r -= 25;
            if (g > 0)
                g -= 25;
            if (b > 0)
                b -= 25;

            if (r < 0)
                r = 0;
            if (g < 0)
                g = 0;
            if (b < 0)
                b = 0;

            BackColor = Color.FromArgb(r, g, b);
            this.Update();

            if (r + g + b <= 0)
            {
                rexaTimer.Stop();
            }

        }

        public RexaButton(IContainer container)
        {
            InitializeComponent();

            Default_LeaveBackColor = this.BackColor;
            Default_LeaveForeColor = this.ForeColor;

            this.UseVisualStyleBackColor = true;

            rexaTimer = new Timer();
            rexaTimer.Interval = 50;
            rexaTimer.Tick += RexaTimer_Tick;
            rexaTimer.Enabled = false;


            MouseEnter += delegate
            {
                rexaTimer.Start();
                Cursor = Cursors.Hand;
            };
            MouseLeave += delegate
            {
                rexaTimer.Stop();
                ForeColor = Default_LeaveForeColor;
                BackColor = Default_LeaveBackColor;
            };
        }
    }
}