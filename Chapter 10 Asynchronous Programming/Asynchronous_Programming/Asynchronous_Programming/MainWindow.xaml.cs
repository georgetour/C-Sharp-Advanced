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

namespace Asynchronous_Programming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // **** Without Asynchronous operation ****
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://msdn.microsoft.com/en-us/");
        }


        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);//Download as string the url 

            try
            {
                using (var streamWriter = new StreamWriter(@"C:/Users/Giant/Documents/Visual Studio 2015/Projects/C-Sharp-Advanced/Chapter 10 Asynchronous Programming/result.html"))
                {
                    streamWriter.Write(html);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }
    }
}
