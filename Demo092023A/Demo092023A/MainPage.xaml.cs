using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo092023A
{
    public partial class MainPage : ContentPage
    {
        bool isTap=false;
        bool isVisible = false;
        public MainPage()
        {
            InitializeComponent();

            /*
           Paso 1: Declarar una instancia del gesture a utilizar
           Paso 2: Creo un Evento
           Paso 3: Asigno mi evento creado en el paso2
           Paso 4: Asignarr el gesto a  un control.
           */

            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += EventTap;
            lblDemo.GestureRecognizers.Add(tap1);

            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += EventTapImage;
            lblDemoImage.GestureRecognizers.Add(tap2);



        }
        void EventTap(object sender, EventArgs args)
        {
            if (isTap)
                btnDemo.BackgroundColor = Color.Red;
            else
                btnDemo.BackgroundColor = Color.Yellow;

            isTap = !isTap;
            //Business Logic   
        }

        void EventTapImage(object sender, EventArgs args)
        {
            
            isVisible = !isVisible;
            if (isVisible)
                image1.Source = "tapped.jpg";            
            else
                image1.Source = "tapped2.jpg";            
        }






    }
}
