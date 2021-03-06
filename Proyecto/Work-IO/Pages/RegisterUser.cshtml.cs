﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages
{
    public class RegisterUserModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Usuario> repository;

        public RegisterUserModel(IRepository<Usuario> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repository.Insert(Usuario);

            return RedirectToPage("/Index");
        }
    }
}