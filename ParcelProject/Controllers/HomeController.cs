using ParcelProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ParcelProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/route")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}