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
    public class ReferenciaIdModel : PageModel
    {
        private readonly AppDBContext _context;
        private readonly IRepository<Candidato> repositoryCandidato;
        public Candidato Candidato { get; set; }

        public ReferenciaIdModel(AppDBContext context, IRepository<Candidato> repositoryCandidato)
        {
            _context = context;
            this.Candidato = repositoryCandidato.Get(Referencia.CandidatoID);
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Referencia Referencia { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Referencias.Add(Referencia);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}