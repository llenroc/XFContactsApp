using Xamarin.Forms;

namespace XFContactsApp
{
    public partial class XFContactsAppPage : TabbedPage
    {
        public XFContactsAppPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            var clickedButton = sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            var selectedContact = clickedButton.CommandParameter?.ToString();

            if (string.IsNullOrWhiteSpace(selectedContact))
            {
                return;
            }

            await DisplayAlert("Clicked", $"You have clicked {selectedContact}", "Ok");
        }
    }
}

