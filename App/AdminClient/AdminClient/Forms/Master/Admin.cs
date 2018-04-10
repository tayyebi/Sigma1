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
    public partial class Admin : Public
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO
            if (Program.Username == null || Program.Username == String.Empty)
            {
                Close();
                throw new OperationCanceledException("Authentication failure");
            }
        }
    }
}
