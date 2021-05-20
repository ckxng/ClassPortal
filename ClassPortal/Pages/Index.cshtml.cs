using ClassPortal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace ClassPortal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly DataContext _context;

        public string Error = null;

        public IList<College> Colleges { get; set; }

        public IndexModel(DataContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;

            Colleges = _context.Colleges
                .OrderBy(c => c.Name)
                .ToList();
        }

        public void OnGet()
        {
            if (Colleges == null)
            {
                Error = "unable to retrieve list of colleges";
                return;
            }
        }
    }
}
