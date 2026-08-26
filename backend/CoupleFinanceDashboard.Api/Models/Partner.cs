namespace CoupleFinanceDashboard.Api.Models;

public class Partner
{
    public int Id{get; set;}
    public required string Name{get; set;}
    public ICollection<Account> Accounts {get; set;} = new List<Account>();
}