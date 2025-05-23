using System;
using System.Windows;
using OptimizerLLG.Core;

namespace OptimizerLLG.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow() { InitializeComponent(); }

        private void StartPresentMon(object sender, RoutedEventArgs e)
        {
            string processName = ProcessBox.Text.Trim();
            if (!string.IsNullOrEmpty(processName))
            {
                PresentMonRunner.StartCapture(processName, 300);
                MessageBox.Show("Captura iniciada con PresentMon durante 5 minutos.");
            }
        }
    }
}