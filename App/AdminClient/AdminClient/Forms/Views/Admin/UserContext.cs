using Core.RexaModel.ADONET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms.Views.Admin
{
    public partial class UserContext : Forms.Master.Admin
    {
        public UserContext()
        {
            InitializeComponent();
        }

        private void UserContext_Load(object sender, EventArgs e)
        {
            using (var db = new MainModel())
            {
                int k = 0;
                foreach (var item in db.UserView.Select(x=>x.MasterId))
                {
                    var u = new Forms.Controls.UserCartext(item) { Dock = DockStyle.Top };
                    if (k % 2 == 0)
                        u.BackColor = Color.LightBlue;
                    k++;
                   
                    panel2.Controls.Add(u);
                }
            }
        }
    }
}
