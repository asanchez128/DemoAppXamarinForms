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
  BindableProperty.Create("Marca", typeof(string), typeof(FormEntry), null);

        public string Marca
        {
            get { return (string)GetValue(MarcaProperty); }
            set { SetValue(MarcaProperty, value); }
        }

        public static readonly BindableProperty ModeloProperty =
  BindableProperty.Create("Modelo", typeof(string), typeof(FormEntry), null);

        public string Modelo
        {
            get { return (string)GetValue(ModeloProperty); }
            set { SetValue(ModeloProperty, value); }
        }

        public static readonly BindableProperty YearProperty =
 BindableProperty.Create("Year", typeof(string), typeof(FormEntry), null);

        public string Year
        {
            get { return (string)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }
    }
}
