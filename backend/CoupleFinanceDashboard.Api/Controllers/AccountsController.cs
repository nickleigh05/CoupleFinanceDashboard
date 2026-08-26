using Microsoft.AspNetCore.Mvc;
using CoupleFinanceDashboard.Api.Models;
using CoupleFinanceDashboard.Api.Data;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{

    private readonly AppDbContext _context;
    public AccountsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Account> accounts = _context.Accounts.ToList();
        return Ok(accounts);
    }

    [HttpPost]
    public IActionResult Create(Account newAccount)
    {
        _context.Accounts.Add(newAccount);
        _context.SaveChanges();
        return Ok(newAccount);
    }

}
