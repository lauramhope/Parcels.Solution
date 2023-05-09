using ParcelProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ParcelProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}