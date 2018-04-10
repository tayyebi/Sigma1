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
    public partial class Register : Forms.Master.Public
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void rexaButton4_Click(object sender, EventArgs e)
        {

            if (rexaTextBox2.Text != rexaTextBox3.Text)
                throw new Exception("Password and confirm didn't match");

            new Core.RexaModel.Interface.User.Public().Insert(rexaTextBox1.Text, new Core.RexaModel.ADONET.UserPasswordView { Password= rexaTextBox2.Text,  MasterId = rexaTextBox1.Text, Firstname = rexaTextBox4.Text, Lastname = rexaTextBox5.Text });
            Program.container.ShowMessage("You are done!");
            Close();
        }
    }
}
