using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1MOVIL2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnpagina_Clicked(object sender, EventArgs e)
        {
            var Contact = new Models.Contactos
            {
               Nombre = this.txtnombre.Text,
               Edad = Convert.ToInt32(this.txtedad.Text),
               Ocupacion = txtocupacion.SelectedItem.ToString(),
               Pais = txtpais.Text 
            };
            var pagina = new PageMain();
            pagina.BindingContext = Contact;
            await Navigation.PushAsync(pagina);
        }
    }
}
