namespace CoupleFinanceDashboard.Api.Models;

public enum AccountType
{
    Checking,
    Savings,
    CreditCard,
    Investment
}

public class Account
{
    public int Id{get; set;}
    public required string InstitutionName{get; set;}
    public required string AccountName{get; set;}
    public required AccountType Type{get; set;}
    public decimal Balance{get; set;}
    public int PartnerId {get; set;}

}