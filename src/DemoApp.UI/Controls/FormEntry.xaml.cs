using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.UI.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormEntry : ContentView
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty MarcaProperty =
  BindableProperty.Create<FormEntry, string>(f => f.Marca, "",  BindingMode.TwoWay, null, propertyChanged: HandleMarcaChanged);

        private static void HandleMarcaChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var button = (FormEntry)bindable;
            button.Marca = (string)newValue;
        }

        public string Marca
        {
            get
            {
                return (string)GetValue(MarcaProperty);
            }
            set {
                SetValue(MarcaProperty, value);
                OnPropertyChanged("Marca");
            }
        }

        public static readonly BindableProperty ModeloProperty =
  BindableProperty.Create("Modelo", typeof(string), typeof(FormEntry), null, BindingMode.TwoWay, propertyChanged: HandleModeloChanged);

        private static void HandleModeloChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var button = (FormEntry)bindable;
            button.Modelo = (string)newValue;
        }

        public string Modelo
        {
            get { return (string)GetValue(ModeloProperty); }
            set { SetValue(ModeloProperty, value);
                OnPropertyChanged("Modelo");
            }
        }

        public static readonly BindableProperty YearProperty =
 BindableProperty.Create("Year", typeof(string), typeof(FormEntry), null, BindingMode.TwoWay, propertyChanged: HandleYearChanged);

        private static void HandleYearChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var button = (FormEntry)bindable;
            button.Year = (string)newValue;
        }

        public string Year
        {
            get { return (string)GetValue(YearProperty); }
            set { SetValue(YearProperty, value);
                OnPropertyChanged("Year");
            }
        }
    }
}
