using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkIO.Models;
using WorkIO.Services;

namespace Work_IO.Pages.WorkIO
{
    public class EditOrdenModel : PageModel
    {
        private readonly AppDBContext _context;
        private readonly IRepository<Empresa> repositoryEmpresa;
        public IEnumerable<Empresa> EmpresaList { get; set; }
        public EditOrdenModel(AppDBContext context, IRepository<Empresa> repositoryEmpresa)
        {
            _context = context;
            this.EmpresaList = repositoryEmpresa.GetAll();
        }
        [BindProperty]
        public Orden Orden { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Orden = await _context.Ordens.FindAsync(id);

            if (Orden == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Orden).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Orden.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool EmpresaExists(int id)
        {
            return _context.Ordens.Any(e => e.Id == id);
        }
    }
}