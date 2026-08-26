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

    // For CreditCard accounts, we'll use a negative sign to represent the amount owed.
    // This way, when we sum all the account balances, we get the correct net worth.
    public decimal Balance{get; set;}
    public int PartnerId {get; set;}
    public Partner? Partner { get; set; }

}