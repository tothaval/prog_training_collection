using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId) ,"Id")]
public partial class EditContactPage : ContentPage
{
    private Contact contact;

    public string ContactId
    {
        set
        {
           contact = ContactRepository.GetContactById(int.Parse(value));
            //lblName.Text = contact.Name;

            if (contact != null)
            {
                contactCtrl.Name = contact.Name;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
                contactCtrl.Address = contact.Address;
            }
        }
    }

    public EditContactPage()
    {
        InitializeComponent();
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");

        //absolute path, required to navigate to a page on root level
        //Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {       
        contact.Name = contactCtrl.Name;
        contact.Address = contactCtrl.Address;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");

    }
}