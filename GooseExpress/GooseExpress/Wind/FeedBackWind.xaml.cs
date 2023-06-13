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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для FeedBackWind.xaml
    /// </summary>
    public partial class FeedBackWind : Window
    {
        List<FeedBacks> b = new List<FeedBacks>();

        public static async Task<List<FeedBacks>> FeedBack()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7061");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            List<FeedBacks> a = new List<FeedBacks>();
            var response = await httpClient.GetAsync("https://localhost:7061/api/FeedBack/FeedBack/All");
            if (response.IsSuccessStatusCode)
            {
                if (response != null)
                {
                    a = await response.Content.ReadAsAsync<List<FeedBacks>>();
                }
            }
            return a;
        }
        public FeedBackWind()
        {
            InitializeComponent();
            Feedback.TextDecorations = TextDecorations.Underline;
            Labels();
        }
        public async void Labels()
        {
            b = await FeedBack();
            //Image1.Source = b[0].Image.ToStrin;
            LabelTop1.Text = b[0].Comment;
            LabelBottom1.Content = b[0].Lastname + " " + b[0].FirstName;
            
            LabelTop2.Text = b[1].Comment;
            LabelBottom2.Content = b[1].Lastname + " " + b[1].FirstName;

            LabelTop3.Text = b[2].Comment;
            LabelBottom3.Content = b[2].Lastname + " " + b[2].FirstName;

            LabelTop4.Text = b[3].Comment;
            LabelBottom4.Content = b[3].Lastname + " " + b[3].FirstName;

            LabelTop5.Text = b[4].Comment;
            LabelBottom5.Content = b[4].Lastname + " " + b[4].FirstName;

            LabelTop6.Text = b[5].Comment;
            LabelBottom6.Content = b[5].Lastname + " " + b[5].FirstName;

            LabelTop7.Text = b[6].Comment;
            LabelBottom7.Content = b[6].Lastname + " " + b[6].FirstName;

            LabelTop8.Text = b[7].Comment;
            LabelBottom8.Content = b[7].Lastname + " " + b[7].FirstName;

        }

        Point scrollMousePoint = new Point();
        double hOff = 1;
        private void scrollViewer_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            scrollMousePoint = e.GetPosition(scrollViewer);
            hOff = scrollViewer.VerticalOffset;
            scrollViewer.CaptureMouse();
        }

        private void scrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer.IsMouseCaptured)
            {
                scrollViewer.ScrollToVerticalOffset(hOff + (scrollMousePoint.Y - e.GetPosition(scrollViewer).Y));
            }
        }

        private void scrollViewer_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer.ReleaseMouseCapture();
        }

        private void scrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + e.Delta);
        }
        Point scrollMousePoint2 = new Point();
        double hOff2 = 1;
        private void scrollViewer2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            scrollMousePoint2 = e.GetPosition(scrollViewer2);
            hOff2 = scrollViewer2.VerticalOffset;
            scrollViewer2.CaptureMouse();
        }

        private void scrollViewer2_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer2.IsMouseCaptured)
            {
                scrollViewer2.ScrollToVerticalOffset(hOff2 + (scrollMousePoint2.Y - e.GetPosition(scrollViewer2).Y));
            }
        }

        private void scrollViewer2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer2.ReleaseMouseCapture();
        }

        private void scrollViewer2_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollViewer2.ScrollToVerticalOffset(scrollViewer2.VerticalOffset + e.Delta);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HistoryOrderWind historyOrderWind = new HistoryOrderWind();
            historyOrderWind.Show();
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWind mainWind = new MainWind();
            mainWind.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.Show();
            this.Close();
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
    }
}
