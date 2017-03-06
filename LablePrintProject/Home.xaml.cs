using LablePrintProject.Domain;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LablePrintProject
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
          
        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("http://www.shinva.net/");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto://shaochenglong@shinva.com");
        }

        private void LogInButton_OnClick(object sender, RoutedEventArgs e)
        { 
            LogInDialogCommand(null);
        }

        private async void LogInDialogCommand(object obj)
        {
            //let's set up a little MVVM, cos that's what the cool kids are doing:
            var view = new iLogInDialog
            {
                DataContext = new SampleDialogViewModel()
            };

            //show the dialog
            var result = await DialogHost.Show(view, "RootDialog", LogInClosingEventHandler);

            //check the result...
            Console.WriteLine("Dialog was closed, the CommandParameter used to close it was: " + (result ?? "NULL"));
        }

        private void LogInClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        { 

        }
    }
}
