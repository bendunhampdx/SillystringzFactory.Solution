using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}