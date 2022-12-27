using exam19.DataBase;
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

namespace exam19.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public static prog19Entities prog19Entities = new prog19Entities();
        public AuthPage()
        {
            InitializeComponent();
        }

        //private void EnterBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var Auth in prog19Entities.Authorization)
        //    {
        //        if (Auth.Login == LoginTB.Text.Trim())
        //        {
        //            if (LoginTB.Text == "" || PasswordTB.Text == "")
        //            {
        //                MessageBox.Show("Введите логин и пароль");
        //            }
        //            else if (Auth.Password == PasswordTB.Text.Trim() && Auth.ID_Role == 2)
        //            {
        //                MessageBox.Show($"Добро пожаловать, администратор {Auth.Login}");
        //                MainWindow  main = new MainWindow();
        //                main.MainSP.Visibility = Visibility.Visible; 
        //           }
        //            else if (Auth.Password == PasswordTB.Text.Trim() && Auth.ID_Role == 1)
        //            {
        //                MessageBox.Show($"Добро пожаловать, владелец {Auth.Login}");
        //                MainWindow main = new MainWindow();
        //                main.MainSP.Visibility = Visibility.Visible;
        //            }
        //            else if (Auth.Password == PasswordTB.Text.Trim() && Auth.ID_Role == 3)
        //            {
        //                MessageBox.Show($"Добро пожаловать, работник мастерской {Auth.Login}");
        //                MainWindow main = new MainWindow();
        //                main.MainSP.Visibility = Visibility.Visible;
        //            }
        //            else if (Auth.Password == PasswordTB.Text.Trim() && Auth.ID_Role == 4)
        //            {
        //                MessageBox.Show($"Добро пожаловать, работник склада {Auth.Login}");
        //                MainWindow main = new MainWindow();
        //                main.MainSP.Visibility = Visibility.Visible;
        //            }
        //        }
        ////    }
        //}
    }
}
