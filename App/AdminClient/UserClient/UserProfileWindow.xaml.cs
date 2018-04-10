using Core.RexaModel.ADONET;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for UserProfileWindow.xaml
    /// </summary>
    public partial class UserProfileWindow : Window
    {
        Core.RexaModel.ADONET.UserView thisUser;

        public UserProfileWindow(string Username)
        {
            InitializeComponent();

            using (var db = new MainModel())
            {
                thisUser = db.UserView.Where(x => x.MasterId == Username).FirstOrDefault();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // job
            Hide();
            new Resume("Job", thisUser.Id).ShowDialog();
            Show();
        }

        private void Button_Click_2(object senders, RoutedEventArgs e)
        {
            // educational
            Hide();
            new Resume("Education", thisUser.Id).ShowDialog();
            Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BMP|*.bmp|JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|TIF|*.tif|All files|*";
            if (ofd.ShowDialog() ?? false)
            {
                txt_image.Text = ofd.FileName;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var ur = new UserPasswordView { Firstname = txt_firstname.Text, Lastname = txt_lastname.Text, Password = txt_password.Password };
            if (txt_username.Text != string.Empty && txt_password.Password != string.Empty && txt_lastname.Text != string.Empty && txt_firstname.Text != string.Empty && txt_image.Text != string.Empty)
            {
                if (txt_image.Text != string.Empty)
                {
                    try
                    {
                        ur.Image = File.ReadAllBytes(txt_image.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid image selected.");
                    }
                }
                if (txt_confirmPassword.Password != txt_confirmPassword.Password)
                {
                    MessageBox.Show("Password and confirm don't match");
                }
                else
                {
                    ur.Password = txt_password.Password;
                }
                new Core.RexaModel.Interface.User.Public().Update(thisUser.MasterId, ur);
                MessageBox.Show("Well done!");
            }
            else MessageBox.Show("Please fill out all fields");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_firstname.Text = thisUser.Firstname;
            txt_lastname.Text = thisUser.Lastname;
            txt_username.Text = thisUser.MasterId;
        }
    }
}
