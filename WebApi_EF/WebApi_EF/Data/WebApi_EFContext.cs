using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi_EF.Models;

namespace WebApi_EF.Data
{
    public class WebApi_EFContext : DbContext
    {
        public WebApi_EFContext (DbContextOptions<WebApi_EFContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi_EF.Models.Book> Book { get; set; }
    }
}
