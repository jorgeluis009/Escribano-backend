using EscribanoBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UserDataAccesss;

namespace EscribanoBackend.Controllers
{
    public class UsersController : ApiController
    {
        private NotariaDataBaseEntities db = new NotariaDataBaseEntities();

        private User[] users = new User[]
        {
           new User { ID_User = 1, LoginName = "name1" , Password = "abc", FirstName = "FName", LastName = "LName", Email = "mail@test.com"},
           new User { ID_User = 2, LoginName = "name2" , Password = "abc", FirstName = "FName", LastName = "LName", Email = "mail@test.com"},
           new User { ID_User = 3, LoginName = "name3" , Password = "abc", FirstName = "FName", LastName = "LName", Email = "mail@test.com"},
           new User { ID_User = 4, LoginName = "name4" , Password = "abc", FirstName = "FName", LastName = "LName", Email = "mail@test.com"},

        };

        
        // GET: api/Users
        [ResponseType(typeof(IEnumerable<Users>))]
        public IEnumerable<Users> Get()
        {
            /*using (NotariaDataBaseEntities entities = new NotariaDataBaseEntities())
            {
                return entities.Users.ToList();
            }*/
            return db.Users.ToList();
                
        }

        public Users Get(int id)
        {
            using (NotariaDataBaseEntities entities = new NotariaDataBaseEntities())
            {
                return entities.Users.FirstOrDefault(e => e.id == id);

            }

        }


        public IHttpActionResult GetLocal(int id)
        {
            var product = users.FirstOrDefault((p) => p.ID_User == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public void POST(Users user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // GET: api/Users/5
        public string Get1(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
