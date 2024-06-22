using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudExample.Models;
using CrudExample.Data;
using Microsoft.EntityFrameworkCore;

namespace CrudExample.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _database;
    public HomeController(ApplicationDbContext database)
    {
        _database = database;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _database.Contacts.ToListAsync());
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

    [HttpGet]
    public IActionResult Edit(int? id)
    {

        if (id == null || id <= 0)
        {
            return NotFound();
        }

        var _contact = _database.Contacts.Find(id);

        if (_contact == null)
        {
            return NotFound();
        }

        return View(_contact);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Contact contact)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        _database.Update(contact);
        await _database.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var _contact = _database.Contacts.Find(id);
        if (_contact == null)
        {
            return NotFound();
        }
        return View(_contact);
    }

}
