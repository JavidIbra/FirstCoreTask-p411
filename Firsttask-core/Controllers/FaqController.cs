using Firsttask_core.DAL;
using Firsttask_core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Firsttask_core.Controllers
{
    public class FaqController : Controller
    {
       private readonly AppDbContext db;

        public FaqController(AppDbContext _db)
        {
            this.db = _db;
        }

        public IActionResult Index()
        {
            List<Faq> faqs = db.Faqs.ToList();

            return View(faqs);
        }
    }
}
