using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUsers), new { id = user.UserId }, user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound(new { message = "User not found" });
                }
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    message = "User successfully deleted",
                    deletedUser = user
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    };

}
