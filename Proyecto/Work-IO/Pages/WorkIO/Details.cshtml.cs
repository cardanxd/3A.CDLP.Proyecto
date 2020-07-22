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
        //public Empresa EmpresaList { get; set; }
        private readonly IRepository<Candidato> repositoryCandidato;
        public IEnumerable<Candidato> CandidatosList { get; set; }
        public DetailsModel(IRepository<Orden> repository, IRepository<Empresa> repositoryEmpresa, IRepository<Candidato> repositoryCandidato)
        {
            this.repository = repository;
            this.EmpresaList = repositoryEmpresa.GetAll();
            this.CandidatosList = repositoryCandidato.GetAll();
            //this.EmpresaList = repositoryEmpresa.Get(Orden.EmpresaID);
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