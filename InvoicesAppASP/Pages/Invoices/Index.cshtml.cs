using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InvoicesAppASP.Data;
using InvoicesAppASP.Models;

namespace InvoicesAppASP.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly InvoicesAppASP.Data.InvoicesAppASPContext _context;

        public IndexModel(InvoicesAppASP.Data.InvoicesAppASPContext context)
        {
            _context = context;
        }

        public IList<Invoice> Invoice { get;set; }

        public async Task OnGetAsync()
        {
            Invoice = await _context.Invoice.ToListAsync();
        }
    }
}
