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
    public class DeleteEmpresaModel : PageModel
    {
        [BindProperty]
        public Empresa Empresa { get; set; }

        private readonly AppDBContext _context;
        public DeleteEmpresaModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Empresa = await _context.Empresas.FindAsync(id);

            if (Empresa == null)
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

            Empresa = await _context.Empresas.FindAsync(id);

            if (Empresa != null)
            {
                _context.Empresas.Remove(Empresa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}