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
    public class EditCandidatoModel : PageModel
    {
        private readonly AppDBContext _context;
        public IEnumerable<Orden> OrdenList { get; set; }
        private readonly IRepository<Orden> repositoryOrden;
        public EditCandidatoModel(AppDBContext context, IRepository<Orden> repositoryOrden)
        {
            _context = context;
            this.OrdenList = repositoryOrden.GetAll();
        }
        [BindProperty]
        public Candidato Candidato { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Candidato = await _context.Candidatos.FindAsync(id);

            if (Candidato == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Candidato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Candidato.Id))
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
            return _context.Empresas.Any(e => e.Id == id);
        }
    }
}