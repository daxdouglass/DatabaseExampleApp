using DatabaseExample.Model;
using DatabaseExample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DatabaseExample.Pages.Example
{
    public class IndexModel : PageModel
    {
        //Connect to database
        private readonly DataContext _db;

        public IEnumerable<ExampleModel> Example { get; set; }
        public IndexModel(DataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Example = _db.Examples;
        }
    }
}
