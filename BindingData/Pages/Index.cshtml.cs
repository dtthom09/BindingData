using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BindingData.Models;

namespace BindingData.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        private readonly DBClass _db;

        public IndexModel(DBClass db)//ILogger<IndexModel> logger, DBClass db)
        {
            //_logger = logger;
            _db = db;
        }

        public IEnumerable<EmpClass> Getrecords { get; set; }

        public async Task OnGet()
        {
            List<EmpClass> lists = await _db.Students1.ToListAsync();
            Getrecords = lists;
        }
    }
}