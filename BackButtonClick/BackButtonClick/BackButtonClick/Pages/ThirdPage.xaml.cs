using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonClick.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPage : ExtendedContentPage
    {
		public ThirdPage ()
		{
			InitializeComponent ();

            if (EnableBackButtonOverride)
            {
                this.CustomBackButtonAction = async () =>
                {
                    var result = await this.DisplayAlert(null,
                        "Hey wait now! are you sure " +
                        "you want to go back?",
                        "Yes go back", "Nope");

                    if (result)
                    {
                        await Navigation.PopAsync(true);
                    }
                };
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}