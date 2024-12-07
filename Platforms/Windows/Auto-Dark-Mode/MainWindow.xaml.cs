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
            // �ʼ��� URI �����������ռ��˵�ַ
            string recipient = "mailto:hbeauwor@outlook.com"; // �滻Ϊʵ�ʵ��ռ��˵�ַ
            var uri = new Uri(recipient);

            // �����ʼ�Ӧ��
            await Launcher.LaunchUriAsync(uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
