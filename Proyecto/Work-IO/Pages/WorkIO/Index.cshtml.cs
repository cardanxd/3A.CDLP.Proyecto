﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Work_IO.Pages.WorkIO
{
    public class IndexModel : PageModel
    {
        public IActionResult Login()
        {
            return Page();
        }
        public void OnGet()
        {

        }
    }
}