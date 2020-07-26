using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Usuario> repository;
        public IndexModel(IRepository<Usuario> repository)
        {
            this.repository = repository;
        }

        public Usuario Usuario { get; set; }
        public IActionResult OnPostAsync(string NombreUsuario, string clave)
        {
            Usuario = repository.GetAll().FirstOrDefault(s => s.UserName == NombreUsuario && s.Password == clave);
            if (Usuario.Id > 0)
            {
                if (Usuario.Id > 0)
                {
                    Console.WriteLine("Entre");
                    return RedirectToPage("/WorkIO/Index");
                }
                else
                {
                    Console.WriteLine("contraseña invalida");
                    return Page();
                }
            }
            else
            {
                Console.WriteLine("no se");
                return Page();
            }
        }

        public IActionResult Login()
        {
            return Page();
        }


    }

}
