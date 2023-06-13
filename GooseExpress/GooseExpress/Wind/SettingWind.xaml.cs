using GooseExpress.DataHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для SettingWind.xaml
    /// </summary>
    public partial class SettingWind : Window
    {
        List<SpecialCustomer> customer = new List<SpecialCustomer>();
        Customer customers2 = new Customer();
        City city = new City();
        string filename;
        public static async Task<List<SpecialCustomer>> SpecialCustomerId(int i)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            var response = await httpClient.GetAsync($"https://localhost:7061/api/Customer/{i}");
            List<SpecialCustomer> a = new List<SpecialCustomer>();
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync<List<SpecialCustomer>>();
                }
            }
            return a;
        }
        public static async Task<Customer> PutCustomer(Customer customer)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            var response = await httpClient.PutAsJsonAsync($"https://localhost:7061/api/Customer/UpdateUser?id={GlobalVariable.id}",customer);
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
        public static async Task<City> GetCity(City city,List<SpecialCustomer> specialCustomer)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            var response = await httpClient.GetAsync($"https://localhost:7061/api/City?NameCity={specialCustomer[0].NameOfCity}");
            City a = new City();
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync <City>();
                }
            }
            return a;
        }
        public SettingWind()
        {
            InitializeComponent();
            Start();
        }
        public async void Start()
        {
            customer = await SpecialCustomerId(GlobalVariable.id);
            city = await GetCity(city, customer);
            tbSeria.Text = customer[0].Seria.ToString();
            tbNumber.Text = customer[0].Number.ToString();
            tbCity.Text = customer[0].NameOfCity.ToString();
            tbLastName.Text = customer[0].LastName.ToString();
            tbFirstName.Text = customer[0].FirstName.ToString();
            tbPatronymic.Text = customer[0].Patronymic.ToString();
            tbAddress.Text = customer[0].LegalAddres.ToString();
            tbPhone.Text = customer[0].Phone.ToString();
            tbPasssword.Text = customer[0].Password.ToString();
            tbEmail.Text = customer[0].Email.ToString();
            if (customer[0].NameOfCustomer == null)
            {
                tbNameOrganization.Text = "";
            }
            else
            {
                tbNameOrganization.Text = customer[0].NameOfCustomer.ToString();
            }
            if (customer[0].Image != null)
            {
                using (MemoryStream stream = new MemoryStream(customer[0].Image))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    bitmapImage.StreamSource = stream;
                    bitmapImage.EndInit();
                    imgAva.Source = bitmapImage;
                }
            }
        }
        public async void Put()
            {
                customers2.Id = GlobalVariable.id;
                customers2.IdCity = city.ID;
                customers2.NameOfCustomer = tbNameOrganization.Text;
                customers2.LegalAddres = tbAddress.Text;
                customers2.Phone = tbPhone.Text;
                customers2.LastName = tbLastName.Text;
                customers2.FirstName = tbFirstName.Text;
                customers2.Patronymic = tbPatronymic.Text;
                customers2.Email = tbEmail.Text;
                customers2.Seria = tbSeria.Text;
                customers2.Number = tbNumber.Text;
                customers2.Login = tbPhone.Text;
                customers2.Password = tbPasssword.Text;
            if(tbPasssword == null)
            {
                MessageBox.Show("Поле пароля не может быть пустым", "Пароль", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (filename != null)
            {
                customers2.Image = File.ReadAllBytes(filename);
            }
            else
            {
                customers2.Image = customer[0].Image;
            }
            PutCustomer(customers2);
            }
        private void btnreturn_Click(object sender, RoutedEventArgs e)
        {
            Put();
            MainWind mainWind = new MainWind();
            mainWind.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegWhiteWind regWhiteWind = new RegWhiteWind();
            regWhiteWind.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
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


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                filename = dlg.FileName;
                imgAva.Source = new BitmapImage(new Uri( filename));
            }
        }
    }
}
