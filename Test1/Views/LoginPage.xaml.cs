using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPageVM ViewModel { get; set; }

		public LoginPage ()
		{
			InitializeComponent ();
            BindingContext = ViewModel = new LoginPageVM();
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            if (ViewModel.VerifyLogin(EntryUsername.Text, EntryPassword.Text))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CategoryPage()));
            }
            else
            {
                await DisplayAlert("Error", "Usuario invalido", "Ok :'v");
            }
        }

        private void ButtonSignUp_Clicked(object sender, EventArgs e)
        {

        }
    }
}