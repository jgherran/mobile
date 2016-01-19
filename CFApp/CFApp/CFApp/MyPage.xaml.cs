using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            lblTitulo.Text = "Esto es una nota!";
        }
    }
}
