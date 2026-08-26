using Microsoft.AspNetCore.Mvc;
using CoupleFinanceDashboard.Api.Models;
using CoupleFinanceDashboard.Api.Data;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartnersController : ControllerBase
{
    
    private readonly AppDbContext _context;
    public PartnersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Partner> partners = _context.Partners.ToList();
        return Ok(partners);
    }
}
