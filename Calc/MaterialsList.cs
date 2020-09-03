using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;

namespace Calc
{
    public class MaterialsList
    {
        private string name;
        private string color;
        private int engrave;
        private int cut;

        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
        public int Engrave
        {
            get { return engrave; }
            set
            {
                engrave = value;
                OnPropertyChanged("Engrave");
            }
        }

        public int Cut
        {
            get { return cut; }
            set
            {
                cut = value;
                OnPropertyChanged("Cut");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
