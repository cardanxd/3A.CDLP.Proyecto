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
    public class RegisterCandidatoModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }

        private readonly IRepository<Orden> repositoryOrden;
        public IEnumerable<Orden> OrdenList { get; set; }

        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Candidato> repository;

        public RegisterCandidatoModel(IRepository<Candidato> repository, IRepository<Orden> repositoryOrden, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            this.OrdenList = repositoryOrden.GetAll();
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

            return RedirectToPage("/WorkIO/Index");
        }
    }
}