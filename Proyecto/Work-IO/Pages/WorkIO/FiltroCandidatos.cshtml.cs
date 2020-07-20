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
    public class FiltroCandidatosModel : PageModel
    {
        private readonly IRepository<Orden> repository;
        public IEnumerable<Orden> Ordenes { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public FiltroCandidatosModel(IRepository<Orden> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            Ordenes = new List<Orden>(); ;
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {
            IEnumerable<Orden> Ordenes = repository.GetAll().Where(x => x.Nombre == "Carlos");
        }
    }
    
}