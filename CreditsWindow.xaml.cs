using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace BackgroundClicker.Wpf
{
    public partial class CreditsWindow : Window
    {
        public CreditsWindow()
        {
            InitializeComponent();
            GitHubLink.MouseLeftButtonUp += (s, e) => Process.Start("https://github.com/TheHolyOneZ");
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBar_Drag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
