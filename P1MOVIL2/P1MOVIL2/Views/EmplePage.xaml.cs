using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1MOVIL2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmplePage : ContentPage
    {
        public EmplePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.BaseDatos.listaempleados();
        }

        private void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Models.Empleados item = (Models.Empleados)e.SelectedItem;
            
        }

        private async void ListaEmpleados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Empleados item = (Models.Empleados)e.Item;
            var newpage = new Views.PageCreateEmple();
            newpage.BindingContext = item;
            await Navigation.PushAsync(newpage);
        }

        private async void btnAgregarEmple_Clicked(object sender, EventArgs e)
        {
            var pagina = new Views.PageCreateEmple();
            await Navigation.PushAsync(pagina);
        }
    }
}