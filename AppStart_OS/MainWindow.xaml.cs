using System.Windows;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System;

namespace AppStart_OS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("shell32.dll")]

        public static extern int ShellExecute(int hWnd, string lpOperation, string lpFile, string lpParameters, string lbDirectory, int snShowCmd);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenApp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ShellExecute(0, "Open", tbAppName.Text, "","",1);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
