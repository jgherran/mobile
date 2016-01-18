using System;
using Xamarin.Forms;

namespace CApp
{
    public class SimpleContentPage : ContentPage
    {
        public SimpleContentPage()
        {
            var labTitulo = new Label
               {
                   Text = "Registro",
                   FontSize = 24
               };
            var entNombre = new Entry
            {
                Placeholder = "Cual es tu problema?"
            };
            var entDesc = new Editor
            {
                Text = "Describe tu problema..."
                //Placeholder = "Describe tu problema..."
               
            };
            var sliCat = new Slider
            {
                Minimum = 1,
                Maximum = 10
            };
            var sliLevel = new Slider
            {
                Minimum = 1,
                Maximum = 10
            };


            var btnEnviar = new Button
            {
                Text = "Enviar"
            };


            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { labTitulo, entNombre, entDesc, sliCat, sliLevel, btnEnviar }
            };


        }

        private Boolean BtnEnviar_Clicked(object sender, EventArgs e)
        {
            return true;
        }
    }
}
