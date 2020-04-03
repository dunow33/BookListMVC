using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class ApplicationDBContext
    {
        public ApplicationDBContext(DBContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
