using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.TextToSpeech;
namespace P1MOVIL2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTTS : ContentPage
    {
        public PageTTS()
        {
            InitializeComponent();
        }

        private async void btnspeed_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(txtnota.Text);
        }

        private async void btnspeed1_Clicked(object sender, EventArgs e)
        {
            await CrossTextToSpeech.Current.Speak(txtnota.Text, null, (float)SldTono.Value, (float)SldSpeed.Value, (float)SldVolumen.Value);
        }
    }
}