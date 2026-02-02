using System;
using System.Globalization;
using System.Windows;

namespace BackgroundClicker.Wpf
{
    public partial class EditStepWindow : Window
    {
        private readonly MainWindow.SequenceStep _step;

        public EditStepWindow(MainWindow.SequenceStep stepToEdit)
        {
            InitializeComponent();
            _step = stepToEdit;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_step == null)
            {
                Close();
                return;
            }
            
            DelayTextBox.Text = _step.DelaySeconds.ToString(CultureInfo.InvariantCulture);
            DoubleClickCheckBox.IsChecked = _step.DoubleClick;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            double delay;
            if (double.TryParse(DelayTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out delay) && delay >= 0)
            {
                _step.DelaySeconds = delay;
                _step.DoubleClick = DoubleClickCheckBox.IsChecked == true;
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid, non-negative number for the delay.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
