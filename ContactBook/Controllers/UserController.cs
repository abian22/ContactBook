using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ContactContext _context; //Access to the database context

        public UserController(ContactContext context) //constructor that receives the context as a parameter
        {
            _context = context; //assing the context to the private field
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            try
            {
                var users = _context.Users.ToList();

                if (users == null || users.Count == 0)
                {
                    return NotFound(new { message = "No users found" });
                }

                return Ok(users);
            }
            catch (Exception ex)
            {
                // Log the exception (opcional)
                return StatusCode(500, new { message = "An error occurred while retrieving users", error = ex.Message });
            }
        }

    }
}
