using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login_Basico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btbOk_Clicked(object sender, EventArgs e)
        {
            string sUsuario = txtUsuario.Text;
            string sPasword = txtPasword.Text;

            if ((sUsuario == "VANESA") && (sPasword == "32495220"))
            {
                Navigation.PushAsync(new Sistema());
            }
            else
            {
                DisplayAlert("Alert", "El usuario o su Password son incorrectos", "Ok");
            }
        }        
    }
}
