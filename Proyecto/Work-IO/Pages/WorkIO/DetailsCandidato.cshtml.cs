using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages.WorkIO
{
    public class DetailsCandidatoModel : PageModel
    {
        private readonly IRepository<Candidato> repository;
        public Candidato Candidato { get; private set; }

        public DetailsCandidatoModel(IRepository<Candidato> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            Candidato = repository.Get(id);
            if (Candidato.Id == 0)
                return RedirectToPage("NotFound");
            return Page();
        }
    }
}