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
    public class TestModel : PageModel
    {
        [BindProperty]
        public int id { get; set; }
        private readonly IRepository<Empresa> repository;
        public IEnumerable<Empresa> EmpresaList { get; set; }

        public TestModel(IRepository<Empresa> repository)
        {
            this.repository = repository;
            this.EmpresaList = repository.GetAll();
        }

        public void OnPost()
        {
            Console.WriteLine(id);
        }

        public void OnGet()
        {

        }
    }
}