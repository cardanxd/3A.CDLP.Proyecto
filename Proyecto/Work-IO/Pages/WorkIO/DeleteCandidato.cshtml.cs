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
    public class DeleteCandidatoModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }

        private readonly AppDBContext _context;
        public DeleteCandidatoModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Candidato = await _context.Candidatos.FindAsync(id);

            if (Candidato == null)
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

            Candidato = await _context.Candidatos.FindAsync(id);

            if (Candidato != null)
            {
                _context.Candidatos.Remove(Candidato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}