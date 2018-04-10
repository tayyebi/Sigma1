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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (new Core.RexaModel.Interface.User.Public().Login(t1.Text, t2.Password))
            {
                Hide();
                UserProfileWindow f = new UserProfileWindow(t1.Text);
                f.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Username or password is invalid");
            }
        }
    }
}
