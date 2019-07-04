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
using System.Windows.Shapes;

namespace testingFilereading
{    
    public partial class Display : Window
    {
        PersonEntry pe = PersonEntry.GetInstance;     
        public Display()
        {
            InitializeComponent();
        }
        public Display(int index)
        {
            InitializeComponent();           
            DisplayName.Content = "Name: " + pe.name[index];
            DisplayEmail.Content = "Email: " + pe.email[index];
            DisplayPNo.Content = "Phone No: " + pe.phoneNo[index];
        }
    }
}
