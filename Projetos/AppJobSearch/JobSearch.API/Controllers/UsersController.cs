using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.API.DataBase;
using JobSearch.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly JobSearchContext _data;

        public UsersController(JobSearchContext data)
        {
            _data = data;
        }

        /*
         * http://seusite.com.br/api/Users?email=teste@gmail.com&password=123mudar
         */
        [HttpGet]
        public IActionResult GetUser(string email, string password)
        {
            User userDb =_data.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (userDb == null)
                return NotFound(); //HTTP - 404 - Não encontrado!

            return new JsonResult(userDb);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            //TODO - Validação...

            _data.Users.Add(user);
            _data.SaveChanges();

            //200 - OK
            //201 - Created

            return CreatedAtAction(nameof(GetUser), new { email = user.Email, password = user.Password }, user);
        }
    }
}
