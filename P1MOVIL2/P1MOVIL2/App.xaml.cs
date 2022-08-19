using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using P1MOVIL2.Models;
using System.IO;

namespace P1MOVIL2
{
    public partial class App : Application
    {
        static EmpleDB basedatos;

        public static EmpleDB BaseDatos
        {
            get
            {
                if(basedatos == null)
                {
                    basedatos = new EmpleDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleDb.db3"));
                }
                return basedatos;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Views.EmplePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
