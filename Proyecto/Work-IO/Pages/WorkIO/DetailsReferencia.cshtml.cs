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
    public class DetailsReferenciaModel : PageModel
    {
        private readonly IRepository<Referencia> repository;
        public Referencia Referencia { get; private set; }
        public IEnumerable<Referencia> ReferenciaList { get; set; }
        public DetailsReferenciaModel(IRepository<Referencia> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            Referencia = repository.Get(id);
            if (Referencia == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}