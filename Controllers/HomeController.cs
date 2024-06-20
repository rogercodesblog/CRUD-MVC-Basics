using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudExample.Models;
using CrudExample.Data;

namespace CrudExample.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _database;
    public HomeController(ApplicationDbContext database)
    {
        _database = database;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
