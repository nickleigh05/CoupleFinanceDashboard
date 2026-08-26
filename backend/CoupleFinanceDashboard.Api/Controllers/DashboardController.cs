using Microsoft.AspNetCore.Mvc;
using CoupleFinanceDashboard.Api.Data;
using CoupleFinanceDashboard.Api.Models;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {

        List<Account> accounts = _context.Accounts.ToList();
        List<Partner> partners = _context.Partners.ToList();

        decimal CombinedNetWorth = accounts.Sum(account => account.Balance);

    return Ok(CombinedNetWorth);
    }
}