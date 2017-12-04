using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        public User GetUserByCredentials(string userName, string password)
        {
            User user = null;
            if (userName == "alice" && password == "alice")
            {
                user = new User
                {
                    Id = 132,
                    Password = "alice",
                    UserName = "alice",
                    FirstName = "Alice",
                    LastName = "Smith"
                };
            }

            return user;
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
