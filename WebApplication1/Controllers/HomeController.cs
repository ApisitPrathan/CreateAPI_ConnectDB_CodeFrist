using Microsoft.AspNetCore.Mvc;
using WebApplication1.Business;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        private readonly ApplicationDb _db;

        public HomeController(ApplicationDb db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("/api/[controller]")]
        public IActionResult viewGet([FromBody] Count obj)
        {
            return Json(Count.GetView());
        }

        [HttpPost]
        [Route("/api/[controller]")]  
        public IActionResult viewPost([FromBody] Count obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            IEnumerable<Count> Test = _db.Counts;

            return Json(Test);
        }

        [HttpDelete]
        [Route("/api/[controller]")]
        public IActionResult viewDelete([FromBody] Count obj)
        {
            Count.ResetView();
            return Json(Empty);
        }
    }
}
