using Microsoft.AspNetCore.Mvc;
using CoupleFinanceDashboard.Api.Models;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartnersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Partner> partners = new List<Partner>
        {
            new Partner
            {
                Id = 1,
                Name = "Nick"

            },

            new Partner
            {
                Id = 2,
                Name = "Trinity"
            }
        };
        return Ok(partners);
    }
}
