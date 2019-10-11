
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserModel.Models;
namespace User.Controller
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }
        [HttpGet("users")]
       public ActionResult<IEnumerable<UserDB>> GetUsers()
        {
            return _context.UserTbl;
        }
        [HttpPost("users")]
        public ActionResult<UserDB> CreateUser(UserDB user)
        {
            _context.UserTbl.Add(user);
            _context.SaveChanges();

           return CreatedAtAction("GetUsers",new UserDB{Id =user.Id}, user);
        }
        [HttpPut("users/{id}")]
        public ActionResult<UserDB> PutUser (int id, UserDB user)
        {
            if ( id != user.Id) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return CreatedAtAction("GetUsers", new UserDB{Id = user.Id},user);
        }
        [HttpDelete("users/{id}")]
        public ActionResult<UserDB> DeleteUser(int id)
        {
            var user = _context.UserTbl.Find(id);
            if(user == null) return NotFound();

            _context.UserTbl.Remove(user);
            _context.SaveChanges();

            return user;
        }
}
}