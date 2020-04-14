using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoApp.Core.Models
{
    public class Vehiculo : INotifyPropertyChanged
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Year { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
