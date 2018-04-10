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
    public partial class Container : Master.Public
    {
        public Container()
        {
            InitializeComponent();
        }
        public void ShowMessage(string Message)
        {
            OpenForm(new RexaMessage(Message), true);
        }
        public void OpenForm(Form f, bool Dialog = false)
        {
            if (!Dialog)
            {
                f.TopLevel = false;
                this.panel2.Controls.Add(f);
                f.Show();
            }
            else
            {
                f.ShowDialog();
            }
        }
        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void rexaButton4_Click(object sender, EventArgs e)
        {
            OpenForm(new Views.Login());
        }

        private void rexaButton5_Click(object sender, EventArgs e)
        {
            OpenForm(new Views.Register());
        }

        private void rexaButton6_Click(object sender, EventArgs e)
        {
            ShowMessage("email: rexa@gordarg.com \r\n blog: rexa.gordarg.com");
        }

        private void rexaButton7_Click(object sender, EventArgs e)
        {
            OpenForm(new Views.Admin.UserContext());

        }
    }
}
