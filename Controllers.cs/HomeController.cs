using Microsoft.AspNetCore.Mvc;

namespace PortfolioII
{
    public class HomeController : Controller
    {
        //Requests
        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("/projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}