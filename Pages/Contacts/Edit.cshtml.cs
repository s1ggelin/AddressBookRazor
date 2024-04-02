using AddressBookRazor.Data;
using AddressBookRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddressBookRazor.Pages.Contacts
{
    public class EditModel : PageModel
    {

        private readonly AddressBookRazorContext _context;

        public EditModel(AddressBookRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = _context.Contact.Find(id);

            if (Contact == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _context.Update(Contact);
            _context.SaveChanges();

            return RedirectToPage("/Contacts/Index");
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
