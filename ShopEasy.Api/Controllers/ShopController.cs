using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Api.Data;
using ShopEasy.Api.Models;

namespace ShopEasy.Api.Controllers;

public class ShopController : Controller
{
    private readonly AppDbContext _db;

    public ShopController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _db.Products.ToListAsync();
        return View(products);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        if (!ModelState.IsValid) return View(product);

        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}