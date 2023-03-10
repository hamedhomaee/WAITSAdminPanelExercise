using Microsoft.AspNetCore.Mvc;
using WAITSAdminPanelExercise.Entities;

namespace WAITSAdminPanelExercise.Controllers;

public class HomeController : Controller
{
    private readonly AppUsersDbContext _appUsersDbContext;

    public HomeController(AppUsersDbContext appUsersDbContext)
    {
        _appUsersDbContext = appUsersDbContext;
    }

    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}