﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_Factorys
{
    [Authorize]
    [Authorize(Policy = "ХАБ Фабрики")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public H_Factory H_Factory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.H_Factory == null)
            {
                return NotFound();
            }

            var h_factory = await _context.H_Factory.FirstOrDefaultAsync(m => m.id_factory == id);

            if (h_factory == null)
            {
                return NotFound();
            }
            else 
            {
                H_Factory = h_factory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.H_Factory == null)
            {
                return NotFound();
            }
            var h_factory = await _context.H_Factory.FindAsync(id);

            if (h_factory != null)
            {
                H_Factory = h_factory;
                _context.H_Factory.Remove(H_Factory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}