using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages
{
    public class RegisterEmpresaModel : PageModel
    {
        [BindProperty]
        public Empresa Empresa { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Empresa> repository;

        public RegisterEmpresaModel(IRepository<Empresa> repository, IWebHostEnvironment hostEnvironment)
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

            var id = repository.Insert(Empresa);

            return RedirectToPage("/Index");
        }
    }
}