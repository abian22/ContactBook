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
                return StatusCode(500, new { message = "An error occurred while retrieving users", error = ex.Message });
            }
        }

        [HttpPost]

        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            try
            {
                _context.Users.Add(user); // Asegúrate de que Users existe en el contexto
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUsers), new { id = user.UserId }, user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message); // Manejo de errores genérico
            }
        }
    }
}
