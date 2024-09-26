using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Valasztasok.Model;

namespace Valasztasok.Pages
{
    public class ListMatchesModel : PageModel
    {
        private readonly Valasztasok.Model.ValasztasokDbContext _context;

        public ListMatchesModel(Valasztasok.Model.ValasztasokDbContext context)
        {
            _context = context;
        }

        public IList<Jelolt> Jelolt { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Jelolt = await _context.Jeloltek.ToListAsync();
        }
    }
}
