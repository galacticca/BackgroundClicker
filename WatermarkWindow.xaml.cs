using System.Windows;
using System.Windows.Input;

namespace BackgroundClicker.Wpf
{
    public partial class WatermarkWindow : Window
    {
        public WatermarkWindow(string title, string text)
        {
            InitializeComponent();
            this.Title = title;
            WatermarkTextBox.Text = text;
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
