using Microsoft.AspNetCore.Mvc;

namespace CoupleFinanceDashboard.Api.Controllers;

[ApiController] // marks this class as an API controller: enables automatic request validation and JSON responses
[Route("api/[controller]")] // sets the URL prefix; [controller] is replaced with the class name minus "Controller" -> api/accounts
public class AccountsController : ControllerBase // ":" means "inherits from" - ControllerBase gives this class helper methods like Ok(), NotFound()
{
    [HttpGet]   // marks the method below as handling GET requests to this route
    public IActionResult Get()  // a method: return type IActionResult (an HTTP response), name Get, no parameters
    {
        return Ok(new { message = "Hello, world!" });   // Ok() builds a 200 response; new { ... } is an inline anonymous object
    }
}
