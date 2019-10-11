using Microsoft.EntityFrameworkCore;

namespace UserModel.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :base (options)
        {

        }
        public DbSet<UserDB> UserTbl {get;set;}
    }
}