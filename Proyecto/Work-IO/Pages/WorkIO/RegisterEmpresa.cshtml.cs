using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkIO.Services;

namespace Work_IO.Pages
{
    public class RegisterEmpresaModel : PageModel
    {
        private readonly IRepository repository;
        [BindProperty]
        public string empresaName { get; set; }
        [BindProperty]
        public string contactName { get; set; }
        [BindProperty]
        public string contactTel { get; set; }
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string direccion { get; set; }
        [BindProperty]
        public string register { get; set; }

        public void OnGet()
        {

        }
    }

    internal interface IRepository
    {
    }
}