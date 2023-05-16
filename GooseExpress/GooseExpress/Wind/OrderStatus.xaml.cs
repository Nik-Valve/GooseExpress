using GooseExpress.DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Web.WebView2.Core;
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
    /// Логика взаимодействия для OrderStatus.xaml
    /// </summary>
    public partial class OrderStatus : Window
    {
        public OrderStatus()
        {
            InitializeComponent();
            Order.TextDecorations = TextDecorations.Underline;
        }

        private void btnreturn_Click(object sender, RoutedEventArgs e)
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
            AboutCompanyWind aboutCompanyWind = new AboutCompanyWind();
            aboutCompanyWind.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            OrderStatusRoute route = new OrderStatusRoute();
            //MessageBox.Show($"ID = {GlobalVariable.id}", "IDDD", MessageBoxButton.OK, MessageBoxImage.Information);

            if (webView != null && webView.CoreWebView2 != null)
            {
                switch (GlobalVariable.id)
                {
                    case 1:
                        webView.CoreWebView2.Navigate(route.orderStatus[0]);
                        break;
                }
                //if (customer.Id == 1)
                //{
                //webView.So = "";

                //}
                //else
                //{

                //}
            }
        }
    }
}
