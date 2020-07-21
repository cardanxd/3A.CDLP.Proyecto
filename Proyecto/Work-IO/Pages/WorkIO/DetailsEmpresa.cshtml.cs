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
    public class DetailsEmpresaModel : PageModel
    {
        private readonly IRepository<Empresa> repository;
        public Empresa Empresa { get; private set; }

        public DetailsEmpresaModel(IRepository<Empresa> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            Empresa = repository.Get(id);
            if (Empresa.Id == 0)
                return RedirectToPage("NotFound");
            return Page();
        }
    }
}