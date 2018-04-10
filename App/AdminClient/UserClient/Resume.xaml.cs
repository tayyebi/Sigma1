using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserClient
{
    /// <summary>
    /// Interaction logic for Resume.xaml
    /// </summary>
    public partial class Resume : Window
    {
        public Resume(string Type, int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Type = Type;
            lbl_type.Content = Type + " type resume";           
        }

        private string _Type;
        private int _UserID;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var resume = new Core.RexaModel.ADONET.ResumeSet
            {
                UserId = _UserID,
                Title = txt_Title.Text,
                Description = txt_Description.Text
            };
            if (_Type == "Job")
            {
                new Core.RexaModel.Interface.Resume.Job().Insert(Guid.NewGuid().ToString(), resume);
            }
            else if (_Type == "Education")
            {
                new Core.RexaModel.Interface.Resume.Educational().Insert(Guid.NewGuid().ToString(), resume);
            }
            MessageBox.Show("Done!");
            Close();
        }
    }
}
