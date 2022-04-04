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

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            Button btn;
        }

        private void Registrating(object sender, RoutedEventArgs e)
        {
            Registration regWindow = new Registration();
            regWindow.ShowDialog();
        }

        private void Loggining(object sender, RoutedEventArgs e)
        {
            using (myUsersContext db = new myUsersContext())
            {
                if (db.UsersLogins
                    .Where((UsersLogin user) => user.Name == loginBox.Text&&user.Password == passwordBox.Password)
                    .FirstOrDefault() != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
