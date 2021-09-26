using Microsoft.AspNetCore.Mvc;

namespace StoreVendors.Controllers
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