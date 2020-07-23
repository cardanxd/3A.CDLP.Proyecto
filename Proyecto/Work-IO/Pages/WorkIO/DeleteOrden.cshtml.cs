using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages.WorkIO
{
    public class DeleteOrdenModel : PageModel
    {
        [BindProperty]
        public Orden Orden { get; set; }

        private readonly AppDBContext _context;
        public DeleteOrdenModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Orden = await _context.Ordens.FindAsync(id);

            if (Orden == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orden = await _context.Ordens.FindAsync(id);

            if (Orden != null)
            {
                _context.Ordens.Remove(Orden);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}