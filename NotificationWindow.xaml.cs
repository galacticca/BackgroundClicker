using System.Windows;
using System.Windows.Media;

namespace BackgroundClicker.Wpf
{
    public enum NotificationResult
    {
        None,
        Primary,
        Secondary
    }

    public partial class NotificationWindow : Window
    {
        public NotificationResult Result { get; private set; }

        public NotificationWindow(string message,
                                  bool isError = false,
                                  string primaryButtonText = "OK",
                                  string secondaryButtonText = null)
        {
            InitializeComponent();

            Result = NotificationResult.None;
            MessageTextBlock.Text = message;
            PrimaryButton.Content = primaryButtonText;

            if (string.IsNullOrEmpty(secondaryButtonText))
            {
                SecondaryButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                SecondaryButton.Visibility = Visibility.Visible;
                SecondaryButton.Content = secondaryButtonText;
            }

            if (isError)
            {
                RootBorder.Background = new SolidColorBrush(Color.FromArgb(0xF0, 0x3B, 0x0B, 0x0B));
            }
        }

        private void PrimaryButton_Click(object sender, RoutedEventArgs e)
        {
            Result = NotificationResult.Primary;
            DialogResult = true;
        }

        private void SecondaryButton_Click(object sender, RoutedEventArgs e)
        {
            Result = NotificationResult.Secondary;
            DialogResult = false;
        }
    }
}
