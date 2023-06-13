using GooseExpress.DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using static GooseExpress.Wind.AboutOrderWind;

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        Customer a = new Customer();
        public RegWindow()
        {
            InitializeComponent();

        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            a = await EmployeeValidation(tbLogin.Text, tbPassword.Text);
            //MessageBox.Show($"ID = {GlobalVariable.id}", "IDDD", MessageBoxButton.OK,MessageBoxImage.Information);
            //a.Id = 0;
            //a.IdCity = 0;
            //a.NameOfCustomer = "";
            //a.LegalAddres = "";
            //a.Phone = "";
            //a.LastName = "";
            //a.FirstName = "";
            //a.Patronymic = "";
            //a.Email = "";
            //a.Seria = "";
            //a.Number = "";
            //a.Login = "";
            //a.Password = "";
            //a.Image = "";
            if (tbLogin.Text != "" && tbPassword.Text != "")
            {
                if (a != null)
                {
                    MainWind mainWind = new MainWind();
                    GlobalVariable.id = a.Id;
                    mainWind.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин и/или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public static async Task<Customer> EmployeeValidation(string login,string password)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            var response = await httpClient.GetAsync($"https://localhost:7061/api/Customer?username={login}&password={password}");
            Customer a = new Customer();
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync<Customer>();
                }
            }
            return a;
        }

        private void pbMemberPas_Click(object sender, RoutedEventArgs e)
        {

            ////string str = $"https://localhost:7061/api/Cargo/Customer/LoginPassword?username={tbLogin.Text}&password={tbPassword.Text}";

            //var response = await httpClient.GetAsync("https://localhost:7061/api/Cargo/Customer/LoginPassword?username=abc&password=1");
            ////var a = await httpClient.PostAsJsonAsync(login, password);
            //var a = response.Content;

            ForgotWind forgotWind = new ForgotWind();
            forgotWind.Show();
            this.Close();
        }

        private void pbRegistration_Click(object sender, RoutedEventArgs e)
        {

            RegistrationUsersWindow ruw = new RegistrationUsersWindow();
            ruw.Show();
            this.Close();
        }
    }
}
