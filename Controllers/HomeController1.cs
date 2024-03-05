using Microsoft.AspNetCore.Mvc;
using sprijosiMVCAPP.Models;

namespace sprijosiMVCAPP.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult jpView()
        {
            return View(uc.SprijosiTables.ToList());
        }
    }
}
