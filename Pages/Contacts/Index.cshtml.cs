using AddressBookRazor.Data;
using AddressBookRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddressBookRazor.Pages.Contacts
{
    public class ContactsModel : PageModel
    {
        private readonly AddressBookRazorContext _context;

        public ContactsModel(AddressBookRazorContext context)
        {
            _context = context;
        }

        public List<Contact> Contacts { get; set; }

        public void OnGet()
        {
            Contacts = _context.Contact.ToList();
        }
    }
}
