using Microsoft.Maui.Controls.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace WeatherApp.Platforms.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Inicia o conteúdo da janela MAUI
            var mauiApp = Microsoft.Maui.MauiApplication.Current;
            var page = mauiApp.Services.GetService(typeof(Microsoft.Maui.Controls.ContentPage)) as Microsoft.Maui.Controls.Page;
            this.Content = new Microsoft.UI.Xaml.Controls.Frame { Content = page };
        }
    }
}
