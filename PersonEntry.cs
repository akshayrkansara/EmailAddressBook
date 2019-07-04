//Anil,Akshay,Tyler,Shubham
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;


namespace testingFilereading
{
    class PersonEntry : INotifyPropertyChanged
    {
        int counter = 0;
        const int arraysize = 30;
        private string _selectedName;
        public string[] name = new string[arraysize];
        public string[] email = new string[arraysize];
        public string[] phoneNo = new string[arraysize];
        private static PersonEntry Instance;
        public static PersonEntry GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new PersonEntry();
                return Instance;
            }
        }
        List<string> _names = new List<string>();
        public List<string> Names
        {
            get { return _names; }
            set { _names = value; NotifyChange(); }
        }
        public string SelectedName
        {
            get { return _selectedName; }
            set { _selectedName = value; NotifyChange(); }
        }
        public int determineIndex()
        {
            int i;
            for (i = 0; i < name.Length; i++)
            {
                if (name[i] == SelectedName)
                {
                    return i;
                }
            }
            return i;
        }
        public void ReadName()
        {
            try
            {
                FileStream fs = new FileStream("personalDetails.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);                
                while (sr.Peek() != -1)
                {
                    if (counter < name.Length)
                    {
                        name[counter] = sr.ReadLine();
                        email[counter] = sr.ReadLine();
                        phoneNo[counter] = sr.ReadLine();
                        counter++;
                    }
                }
                Names = name.ToList();                
            }
            catch (Exception ex) {
                throw ex;
            }
        }        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChange([CallerMemberName]string caller = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
