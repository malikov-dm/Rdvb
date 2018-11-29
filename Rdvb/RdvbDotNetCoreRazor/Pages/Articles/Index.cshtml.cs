using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RdvbDotNetCoreRazor.Data;

namespace RdvbDotNetCoreRazor.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly RdvbDotNetCoreRazor.Data.ApplicationDbContext _context;

        public IndexModel(RdvbDotNetCoreRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
