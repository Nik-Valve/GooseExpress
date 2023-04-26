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

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для RegistrationUsersWindow.xaml
    /// </summary>
    public partial class RegistrationUsersWindow : Window
    {
        public RegistrationUsersWindow()
        {
            InitializeComponent();
            NameOrganization.Visibility = Visibility.Hidden;
            tbNameOrganization.Visibility = Visibility.Hidden;
            lbOrganization.Visibility = Visibility.Hidden;
            bOrganization.Visibility = Visibility.Hidden;
        }

        private void rbNo_Checked(object sender, RoutedEventArgs e)
        {
            NameOrganization.Visibility = Visibility.Hidden;
            tbNameOrganization.Visibility = Visibility.Hidden;
            lbOrganization.Visibility = Visibility.Hidden;
            bOrganization.Visibility = Visibility.Hidden;
            tbNameOrganization.Clear();
        }

        private void rbYes_Checked(object sender, RoutedEventArgs e)
        {
            NameOrganization.Visibility = Visibility.Visible;
            tbNameOrganization.Visibility = Visibility.Visible;
            lbOrganization.Visibility = Visibility.Visible;
            bOrganization.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }

        private void Button_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }
    }
}
