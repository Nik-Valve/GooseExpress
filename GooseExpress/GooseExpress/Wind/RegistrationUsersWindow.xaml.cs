using GooseExpress.DataHelper;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для RegistrationUsersWindow.xaml
    /// </summary>
    public partial class RegistrationUsersWindow : Window
    {
        string fileName;
        //public async void Start(HttpClient httpClient)
        //{
        //    //PostAsync(httpClient);
        //}
        public static async Task<City> CityValidation(string cityName)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            var response = await httpClient.GetAsync($"https://localhost:7061/api/City?NameCity={cityName}");
            City a = new City();
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync<City>();
                }
            }
            return a;
        }
        public static async Task<string> AddCity(City city)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            var res = await httpClient.PostAsJsonAsync($"https://localhost:7061/api/City", city);
            return await res.Content.ReadAsStringAsync();
        }
        public static async Task<string> AddCustomer(Customer customer)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            var res = await httpClient.PostAsJsonAsync($"https://localhost:7061/api/Customer", customer);
            return await res.Content.ReadAsStringAsync();
        }


        public RegistrationUsersWindow()
        {
            InitializeComponent();
            NameOrganization.Visibility = Visibility.Hidden;
            tbNameOrganization.Visibility = Visibility.Hidden;
            lbOrganization.Visibility = Visibility.Hidden;
            bOrganization.Visibility = Visibility.Hidden;


            //HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7061");
            //httpClient.DefaultRequestHeaders.Accept.Clear();
            //httpClient.DefaultRequestHeaders.Accept.Add(
            //    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
            //    );
            //Start(httpClient);

        }
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            City city = new City();
            city = await CityValidation(tbCity.Text);
            Found:
            if (city != null)
            {
                customer.IdCity = city.ID;
                customer.NameOfCustomer = tbNameOrganization.Text;
                customer.LegalAddres = tbAddress.Text;
                customer.Phone =tbPhone.Text;
                customer.LastName = tbLastName.Text;
                customer.FirstName = tbName.Text;
                customer.Patronymic = tbPatronymic.Text;
                customer.Email = tbEmail.Text;
                customer.Seria = tbSeria.Text;
                customer.Number = tbNumber.Text;
                customer.Login = tbPhone.Text;
                customer.Password = tbPassword.Text;
                if(fileName != null)
                {
                    customer.Image = File.ReadAllBytes(fileName);
                }
                else
                {
                    customer.Image = null;
                }
                await AddCustomer(customer);
            }
            else
            {
                city.NameOfCity = tbCity.Text;
                city.IDDistrict = 1;
                city.CodeCity = 1;
                AddCity(city);
                goto Found;
            }
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



        private void btnAva_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            btnAva.Background = null;
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                fileName = dlg.FileName;
                imgAva.Source = new BitmapImage(new Uri(fileName));
            }
        }
    }
}
