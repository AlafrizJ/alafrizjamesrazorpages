#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using alafrizjamesrazorpages.Data;

namespace alafrizjamesrazorpages.Pages.Basketball
{
    public class IndexModel : PageModel
    {
        private readonly alafrizjamesrazorpages.Data.alafrizjamesrazorpagesContext _context;

        public IndexModel(alafrizjamesrazorpages.Data.alafrizjamesrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
