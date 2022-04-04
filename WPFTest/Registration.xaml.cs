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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            using (myUsersContext db = new myUsersContext())
            {
                if (db.UsersLogins.Where((UsersLogin user)=>  user.Name == loginBox.Text).FirstOrDefault() == null)
                {
                    db.UsersLogins.Add(new UsersLogin(passwordBox.Password, loginBox.Text));
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже есть!");
                    return;
                }
            }
                this.DialogResult = true;
        }
    }

}
