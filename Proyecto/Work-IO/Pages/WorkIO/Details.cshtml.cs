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
    public class DetailsModel : PageModel
    {
        private readonly IRepository<Orden> repository;
        public Orden Orden { get; private set; }
        private readonly IRepository<Empresa> repositoryEmpresa;
        public IEnumerable<Empresa> EmpresaList { get; set; }
        public DetailsModel(IRepository<Orden> repository, IRepository<Empresa> repositoryEmpresa)
        {
            this.repository = repository;
            this.EmpresaList = repositoryEmpresa.GetAll();
        }
        public IActionResult OnGet(int id)
        {
            Orden = repository.Get(id);
            if (Orden.Id == 0)
                return RedirectToPage("NotFound");
            return Page();
        }
    }
}