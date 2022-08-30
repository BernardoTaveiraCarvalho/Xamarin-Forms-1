using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Forms_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
           
        }
        private void Button_Clicked(object sender,EventArgs e)
        {
            //Validar credenciais (dummy validation) 
            if(utilizador.Text =="user" && palavrapasse.Text == "pass")
            {
                //Navegar para a MainPage
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error","Login wrong","close");
            }
        }
    }
}