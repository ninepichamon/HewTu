using System;
using Microsoft.Maui.Controls;

namespace HewTU
{
    public partial class AddStorePage : ContentPage
    {
        public AddStorePage()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            string storeName = StoreNameEntry.Text;
            string storeType = StoreTypePicker.SelectedItem?.ToString();
            string description = DescriptionEditor.Text;
            string address = AddressEntry.Text;
            string phone = PhoneEntry.Text;
            string openingTime = OpeningTimeEntry.Text;
            string closingTime = ClosingTimeEntry.Text;

            if (string.IsNullOrWhiteSpace(storeName) || string.IsNullOrWhiteSpace(storeType))
            {
                DisplayAlert("Error", "Please fill in all required fields.", "OK");
                return;
            }

            // Save data logic here
            DisplayAlert("Success", "Store has been added successfully!", "OK");
            // Navigate back or clear the form
        }
    }
}
