using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Core.Helpers;
using DemoApp.Core.Models;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace DemoApp.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public Vehiculo Vehiculo1 { get; set; } = new Vehiculo
        {
        };
        public Vehiculo Vehiculo2 { get; set; } = new Vehiculo();
        public Vehiculo Vehiculo3 { get; set; } = new Vehiculo();

        public MvxObservableCollection<Vehiculo> Vehiculos { get; set; }

        public string AndroidId { get; set; }

        public HomeViewModel()
        {
            Vehiculos = new MvxObservableCollection<Vehiculo>();

            Vehiculos.Add(new Vehiculo { Marca = "VW", Modelo = "Jetta", Year = "2000" });
            Vehiculos.Add(new Vehiculo { Marca = "Nissan", Modelo = "Datsun", Year = "2001" });

            SendDataCommand = new MvxCommand(ExecuteSendDataCommand);
        }

        public MvxNotifyTask GetAndroidIdTask { get; set; }

        public override async Task Initialize()
        {
            await base.Initialize();
            GetAndroidIdTask = MvxNotifyTask.Create(GetAndroidIdAsync);

        }

        private async Task GetAndroidIdAsync()
        {
            AndroidId = await DependencyService.Get<IAndroidId>().GetAndroidId();
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
