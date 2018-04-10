using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms.Views
{
    public partial class Login : Forms.Master.Public
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void rexaButton4_Click(object sender, EventArgs e)
        {
            if (!new Core.RexaModel.Interface.User.Public().Login(rexaTextBox1.Text, rexaTextBox2.Text))
            {
                Program.container.ShowMessage("Username or password is invalid");
            }
            else
            {
                Program.Username = rexaTextBox1.Text;
                Program.container.ShowMessage("You are also done! Welcome " + Program.Username);
                Close();
            }
        }
    }
}
