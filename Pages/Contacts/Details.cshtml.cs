using AddressBookRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddressBookRazor.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly Data.AddressBookRazorContext _context;

        public DetailsModel(Data.AddressBookRazorContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public void OnGet(int id)
        {
            Contact = _context.Contact.Find(id);
        }
    }
}
