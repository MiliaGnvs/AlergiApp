using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlergiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        private void Esqueci_Senha_Tapped(object sender,EventArgs e)
        {
            return;
        }

        private void Cadastrar_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }
    }
}