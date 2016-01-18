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
            var entDesc = new Entry
            {
                Placeholder = "Describe tu problema..."
               
            };
            var btnEnviar = new Button
            {
                Text = "Enviar"
            };


            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { labTitulo, entNombre, entDesc, btnEnviar }
            };


        }

        private Boolean BtnEnviar_Clicked(object sender, EventArgs e)
        {
            return true;
        }
    }
}
