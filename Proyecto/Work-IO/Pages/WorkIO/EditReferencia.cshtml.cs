using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkIO.Models;
using WorkIO.Services;


namespace Work_IO.Pages.WorkIO
{
    public class EditReferenciaModel : PageModel
    {
        private readonly AppDBContext _context;
        private readonly IRepository<Candidato> repositoryCandidato;
        public IEnumerable<Candidato> CandidatoList { get; set; }
        public EditReferenciaModel(AppDBContext context, IRepository<Candidato> repositoryCandidato)
        {
            _context = context;
            this.CandidatoList = repositoryCandidato.GetAll();
        }
        [BindProperty]
        public Referencia Referencia { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Referencia = await _context.Referencias.FindAsync(id);

            if (Referencia == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Referencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Referencia.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool EmpresaExists(int id)
        {
            return _context.Referencias.Any(e => e.Id == id);
        }
    }
}