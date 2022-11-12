using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext context { get; }
        public UsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = context.Users.ToList();
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = context.Users.Find(id);
            return user;
        }
    }
}