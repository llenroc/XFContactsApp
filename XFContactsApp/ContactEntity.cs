using Xamarin.Forms;
namespace XFContactsApp
{
    public class ContactEntity
    {
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public ImageSource Image => ImageSource.FromFile("user3");
    }
}