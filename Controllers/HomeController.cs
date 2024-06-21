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

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Contact contact)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        contact.DateCreated = DateTimeOffset.UtcNow;

        _database.Contacts.Add(contact);
        await _database.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }


}
