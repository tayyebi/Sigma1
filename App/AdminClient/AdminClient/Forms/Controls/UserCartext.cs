using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.RexaModel.ADONET;
using System.IO;

namespace AdminClient.Forms.Controls
{
    public partial class UserCartext : PUBLIC
    {
        public UserCartext(string Username)
        {
            InitializeComponent();
            using (var db = new MainModel())
            {
                var user = db.UserView.Where(x => x.MasterId == Username).FirstOrDefault();
                rexaLabel1.Text = user.Firstname + " " + user.Lastname;
                rexaLabel3.Text = user.UpdatesCount.ToString();
                if (user.Image != null)
                {
                    using (var m = new MemoryStream(user.Image))
                    {
                        pictureBox1.BackgroundImage = new Bitmap(m);
                    }
                }

                var edits = (from a in db.UserSet
                             join l in db.Logger
                             on a.Id equals l.IndexId
                             select a
                             ).Where(x => x.Logger.MasterId == user.MasterId).OrderByDescending(x => x.Id).Select(x => new { x.Firstname, x.Lastname, x.Image }).ToList();
                rexaDataGridView1.DataSource = edits;

                DataGridViewImageColumn i = rexaDataGridView1.Columns["Image"] as DataGridViewImageColumn;
                i.ImageLayout = DataGridViewImageCellLayout.Zoom;

                if (db.Logger.Where(x => x.MasterId == Username).OrderByDescending(x => x.IndexId).FirstOrDefault().IsDeleted)
                {
                    rexaLabel4.Visible = true;
                    tabControl1.Visible = false;
                }
            }
        }

        private void UserCartext_Load(object sender, EventArgs e)
        {

        }
    }
}
