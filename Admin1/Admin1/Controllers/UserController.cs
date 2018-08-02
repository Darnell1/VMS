using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin1.Models;

namespace Admin1.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository repository;
       public UserController(IUserRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Users);
    }
}
