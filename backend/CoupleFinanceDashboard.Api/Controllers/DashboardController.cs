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

        List<object> partnerBreakdowns = new List<object>();

        foreach (Partner partner in partners)
        {
            var partnerAccounts = accounts
                .Where(account => account.PartnerId == partner.Id)
                .Select(account => new
                {
                    id = account.Id,
                    institutionName = account.InstitutionName,
                    accountName = account.AccountName,
                    type = account.Type,
                    balance = account.Balance
                })
                .ToList();

            decimal partnerNetWorth = partnerAccounts.Sum(account => account.balance);

            partnerBreakdowns.Add(new
            {
                partnerId = partner.Id,
                partnerName = partner.Name,
                netWorth = partnerNetWorth,
                accounts = partnerAccounts
            });
        }

        return Ok(new
        {
            combinedNetWorth = CombinedNetWorth,
            partners = partnerBreakdowns
        });
    }
}