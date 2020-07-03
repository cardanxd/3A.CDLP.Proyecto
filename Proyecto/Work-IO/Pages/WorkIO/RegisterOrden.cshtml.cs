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
    public class RegisterOrdenModel : PageModel
    {
        [BindProperty]
        public Orden Orden { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Orden> repository;

        private readonly IRepository<Empresa> repositoryEmpresa;
        public IEnumerable<Empresa> EmpresaList { get; set; }

        public RegisterOrdenModel(IRepository<Orden> repository, IRepository<Empresa> repositoryEmpresa, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            this.EmpresaList = repositoryEmpresa.GetAll();
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repository.Insert(Orden);

            return RedirectToPage("/WorkIO/Index");
        }
    }
}