//Anil,Akshay,Tyler,Shubham
using System;
using System.Collections.Generic;
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

namespace testingFilereading
{    
    public partial class MainWindow : Window
    {
        PersonEntry pe = PersonEntry.GetInstance;           
        public MainWindow()
        {
            InitializeComponent();
            DataContext = pe;
            pe.ReadName();            
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            int selName = pe.determineIndex();
            Display secWindow = new Display(selName);
            secWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            secWindow.Show();
        }
    }
}
