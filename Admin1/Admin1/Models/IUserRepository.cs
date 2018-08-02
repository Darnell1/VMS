using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin1.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
    }
}
