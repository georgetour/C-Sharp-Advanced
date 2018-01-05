using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Asynchronous_Operation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Top button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtmlAsync("https://msdn.microsoft.com/en-us/");
        }



        //Second button
        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            var getHtmlTask = GetHtmlAsync("https://msdn.microsoft.com/en-us/");

            //Do something while await method runs
            MessageBox.Show("I m running while the await method is executed");

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0,10));

        }


        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);//Download as string the url 

            try
            {
                using (var streamWriter = new StreamWriter(@"C:/Users/Giant/Documents/Visual Studio 2015/Projects/C-Sharp-Advanced/Chapter 10 Asynchronous Programming/result.html"))
                {
                    await streamWriter.WriteAsync(html);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

       
    }
}
