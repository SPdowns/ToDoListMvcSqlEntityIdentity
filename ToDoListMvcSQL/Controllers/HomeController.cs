using Microsoft.AspNetCore.Mvc;
using ToDoListMvcSqlEntityIdentity.Models;
using System.Collections.Generic;

namespace ToDoListMvcSqlEntityIdentity.Controllers
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