using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;



namespace lesson_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        static void ImportArrayByFile(string address, string theme, string message)
        {
            string result = address + theme + message; 
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.GetFullPath(Path.Combine(baseDir, "OUTPUT.txt"));
            File.WriteAllText(path, result, Encoding.UTF8);
        }

        private void Send1_Click(object sender, RoutedEventArgs e)
        {
            ImportArrayByFile(Adress.Text, ThemeMessage.Text, Message.Text);
        }
    }
}
