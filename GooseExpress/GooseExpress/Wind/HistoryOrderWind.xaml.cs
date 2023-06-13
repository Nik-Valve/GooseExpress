using GooseExpress.DataHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для HistoryOrderWind.xaml
    /// </summary>
    public partial class HistoryOrderWind : Window
    {
        List<HistoryOrder> historyOrders = new List<HistoryOrder>();
        int identi = GlobalVariable.id;


        public static async Task<List<HistoryOrder>> Orders(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            List<HistoryOrder> a = new List<HistoryOrder>();
            var response = await httpClient.GetAsync($"https://localhost:7061/api/Cargo/Recipients/All?a={id}");
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync<List<HistoryOrder>>();
                }
            }
            return a;

        }
        public async void DGrid(int a)
        {
            historyOrders = await Orders(a);
            //MessageBox.Show($"{identi}", "Ok", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            dtGrid.ItemsSource = historyOrders;

        }
        public HistoryOrderWind()
        {
            InitializeComponent();
            History.TextDecorations = TextDecorations.Underline;
            DGrid(identi);
        }


        private void btnreturn_Click_1(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingWind settingWind = new SettingWind();
            settingWind.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWind mainWind = new MainWind();
            mainWind.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FeedBackWind feedBackWind = new FeedBackWind();
            feedBackWind.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AboutOrderWind aboutOrderWind = new AboutOrderWind();
            aboutOrderWind.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AboutCompanyWind aboutCompanyWind = new AboutCompanyWind();
            aboutCompanyWind.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            HistoryOrderWind historyOrderWind = new HistoryOrderWind();
            historyOrderWind.Show();
            this.Close();
        }
    }
}
