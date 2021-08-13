using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvoicesAppASP.Models;

namespace InvoicesAppASP.Data
{
    public class InvoicesAppASPContext : DbContext
    {
        public InvoicesAppASPContext (DbContextOptions<InvoicesAppASPContext> options)
            : base(options)
        {
        }

        public DbSet<InvoicesAppASP.Models.Invoice> Invoice { get; set; }
    }
}
