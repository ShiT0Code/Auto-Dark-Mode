using System;
using Microsoft.UI.Xaml;
using Windows.System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Auto_Dark_Mode
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.ExtendsContentIntoTitleBar = true;
        }

        private async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            // 邮件的 URI 方案，包含收件人地址
            string recipient = "mailto:hbeauwor@outlook.com"; // 替换为实际的收件人地址
            var uri = new Uri(recipient);

            // 启动邮件应用
            await Launcher.LaunchUriAsync(uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
