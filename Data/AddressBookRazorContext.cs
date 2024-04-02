using AddressBookRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookRazor.Data
{
    public class AddressBookRazorContext : DbContext
    {
        public AddressBookRazorContext(DbContextOptions<AddressBookRazorContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; } = default!;
    }
}
