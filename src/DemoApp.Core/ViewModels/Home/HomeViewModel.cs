using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DemoApp.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace DemoApp.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public Vehiculo Vehiculo1 { get; set; }
        public Vehiculo Vehiculo2 { get; set; }
        public Vehiculo Vehiculo3 { get; set; }

        public ObservableCollection<Vehiculo> Vehiculos { get; set; }

        public HomeViewModel()
        {
            Vehiculos = new ObservableCollection<Vehiculo>();

            Vehiculos.Add(new Vehiculo { Marca = "VW", Modelo = "Jetta", Year = "2000" });
            Vehiculos.Add(new Vehiculo { Marca = "Nissan", Modelo = "Datsun", Year = "2001" });

            SendDataCommand = new MvxCommand(ExecuteSendDataCommand);
        }

        private void ExecuteSendDataCommand()
        {
            

            Vehiculos.Add(Vehiculo1);
            Vehiculos.Add(Vehiculo2);
            Vehiculos.Add(Vehiculo3);

        }

        public MvxCommand SendDataCommand { get; set; }



    }
}
