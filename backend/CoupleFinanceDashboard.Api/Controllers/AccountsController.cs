using Microsoft.AspNetCore.Mvc;
using CoupleFinanceDashboard.Api.Models;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Account> accounts = new List<Account>
        {
            new Account
            {
                Id = 1,
                PartnerId = 1,
                InstitutionName = "AMEX",
                AccountName = "Nick",
                Type = AccountType.Checking,
                Balance = 236.32m
            },

            new Account
            {
                Id = 2,
                PartnerId = 2,
                InstitutionName = "CHASE",
                AccountName = "Trinity",
                Type = AccountType.Checking,
                Balance = 371.76m
            }
        };
        return Ok(accounts);
    }
}
