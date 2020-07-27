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
    public class OrdenesRegistradosModel : PageModel
    { 
        public IEnumerable<Orden> Ordenes { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Orden> repository;

        public OrdenesRegistradosModel(IRepository<Orden> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {
            Ordenes = repository.GetAll();
            
        }
    }
}