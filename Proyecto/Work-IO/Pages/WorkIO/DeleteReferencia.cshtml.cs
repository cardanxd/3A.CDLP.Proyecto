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
    public class DeleteReferenciaModel : PageModel
    {
        [BindProperty]
        public Referencia Referencia { get; set; }

        private readonly AppDBContext _context;
        public DeleteReferenciaModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Referencia = await _context.Referencias.FindAsync(id);

            if (Referencia == null)
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

            Referencia = await _context.Referencias.FindAsync(id);

            if (Referencia != null)
            {
                _context.Referencias.Remove(Referencia);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}