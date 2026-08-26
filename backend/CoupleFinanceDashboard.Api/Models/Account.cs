// needed for ControllerBase, IActionResult, and attributes like [ApiController]
// namespace: put this in CoupleFinanceDashboard.Api.Models (matches the folder)
namespace CoupleFinanceDashboard.Api.Models;
// enum: a fixed list of named options, called AccountType
//   options: Checking, Savings, CreditCard, Investment
public enum AccountType
{
    Checking,
    Savings,
    CreditCard,
    Investment
}
// class: a blueprint called Account
//   property: Id, a whole number
//   property: InstitutionName, text, e.g. "Chase"
//   property: AccountName, text, e.g. "Checking"
//   property: Type, an AccountType (one of the enum options above)
//   property: Balance, money (use the type made for exact money math, not float/double)

public class Account
{
    public int Id{ get; set; }
    public required string InstitutionName{ get; set; }
    public required string AccountName{ get; set; }
    public required AccountType Type{ get; set; }
    public decimal Balance{ get; set; } // of type decimal cause floats shouldnt take money???

}