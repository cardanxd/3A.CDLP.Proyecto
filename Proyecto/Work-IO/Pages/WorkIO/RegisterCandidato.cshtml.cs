using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages.WorkIO
{
    public class RegisterCandidatoModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }
        [BindProperty]
        public Documentos Documentos { get; set; }

        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Empresa> repository;

        public RegisterCandidatoModel(IRepository<Candidato> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repository.Insert(Candidato);

            return RedirectToPage("/Index");
        }
    }
}