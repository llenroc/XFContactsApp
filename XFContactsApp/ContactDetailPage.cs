using Xamarin.Forms;

namespace XFContactsApp
{
    public class ContactDetailPage : ContentPage
    {
        readonly ContactEntity _contact;


        public ContactDetailPage(ContactEntity selectedContact)
        {
            Title = "Contact Details";

            _contact = selectedContact;

            Content = new StackLayout
            {
                Children =
                {
                    new Image
                    {
                        Source = _contact.Image,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Start,
                        Aspect = Aspect.AspectFit,
                        HeightRequest = 300
                    },
                    new BoxView
                    {
                        HeightRequest = 1,
                        Color = Color.Gray,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Opacity = 0.5,
                        Margin = 2
                    },
                    new Label
                    {
                        Text = _contact.Name,
                        FontSize = Device.GetNamedSize(NamedSize.Large, this),
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalTextAlignment = TextAlignment.Start,
                        VerticalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = _contact.Description,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, this),
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalTextAlignment = TextAlignment.Start,
                        VerticalTextAlignment = TextAlignment.Center
                    }
                },
                Padding = 10,
                Spacing = 10
            };
        }
    }
}


