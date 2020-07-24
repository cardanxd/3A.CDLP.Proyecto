using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository<Usuario> repository;
        public Usuario Usuario { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IRepository<Usuario> repository)
        {
            _logger = logger;
            this.repository = repository;
        }
        public IActionResult OnPost()
        {
            Usuario = repository.GetAll().FirstOrDefault(x => x.UserName == Usuario.UserName && x.Password == Usuario.Password);
            if (Usuario.Id > 0)
                return RedirectToPage("./Index");
            return Page();
        }


    }

}
