using AddressBookRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddressBookRazor.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        private readonly Data.AddressBookRazorContext _context;

        public CreateModel(Data.AddressBookRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contact.Add(Contact);
            _context.SaveChanges();

            return RedirectToPage("/Contacts/Index");
        }
    }
}
