using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin1.Models
{
    public class EFPUserRepository : IUserRepository
    {
        private ApplicationDbContext context;
        public EFPUserRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<User> Users => context.Users;
    }
}
