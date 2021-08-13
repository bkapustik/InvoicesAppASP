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
    public class DetailsModel : PageModel
    {
        private readonly InvoicesAppASP.Data.InvoicesAppASPContext _context;

        public DetailsModel(InvoicesAppASP.Data.InvoicesAppASPContext context)
        {
            _context = context;
        }

        public Invoice Invoice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoice = await _context.Invoice.FirstOrDefaultAsync(m => m.ID == id);

            if (Invoice == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
