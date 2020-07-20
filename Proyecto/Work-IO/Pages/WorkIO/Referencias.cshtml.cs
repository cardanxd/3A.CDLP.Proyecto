using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages.WorkIO
{
    public class ReferenciasModel : PageModel
    {
        [BindProperty]
        public Referencia Referencia { get; set; }

        private readonly IRepository<Candidato> repositoryCandidato;
        public IEnumerable<Candidato> CandidatoList { get; set; }

        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Referencia> repository;

        public ReferenciasModel(IRepository<Referencia> repository, IRepository<Candidato> repositoryCandidato, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            this.CandidatoList = repositoryCandidato.GetAll();
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var id = repository.Insert(Referencia);

            return RedirectToPage("/WorkIO/Index");
        }
    }
}