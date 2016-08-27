using Xamarin.Forms;
using System.Collections.Generic;
using System;
using System.Linq;

namespace XFContactsApp
{
    public partial class XFContactsAppPage : TabbedPage
    {
        public XFContactsAppPage()
        {
            InitializeComponent();

            contactList.ItemsSource = GetContacts();
        }

        async void Button_Clicked(object sender, EventArgs e)
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

        void SearchBar_ButtonPressed(object sender, EventArgs e)
        {
            var searchBar = sender as SearchBar;

            if (searchBar == null)
            {
                return;
            }

            contactList.ItemsSource = string.IsNullOrWhiteSpace(searchBar.Text) 
                                            ? GetContacts() : GetFilteredContacts(searchBar.Text);
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = sender as SearchBar;

            if (searchBar == null)
            {
                return;
            }

            contactList.ItemsSource = string.IsNullOrWhiteSpace(searchBar.Text)
                                            ? GetContacts() : GetFilteredContacts(searchBar.Text);
        }

        static IEnumerable<ContactEntity> GetContacts()
        {
            var contacts = new List<ContactEntity>();

            for (int i = 0; i < 100; i++)
            {
                contacts.Add(new ContactEntity
                {
                    Name = $"Contact Name {i}",
                    Description = $"Description {i}"
                });
            }

            return contacts;
        }

        IEnumerable<ContactEntity> GetFilteredContacts(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            return contactList?.ItemsSource?.Cast<ContactEntity>()?.Where(x => x.Name.Contains(text));
        }
    }
}

