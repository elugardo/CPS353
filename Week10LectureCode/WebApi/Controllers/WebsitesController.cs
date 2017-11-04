using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    public class WebsitesController : ApiController
    {
        private WebsiteRepository _websiteRepository;

        public WebsitesController()
        {
            
            _websiteRepository = new WebsiteRepository();
        }
        // GET: api/Websites
        public IEnumerable<Website> Get()
        {
            return _websiteRepository.Get();
        }

        // GET: api/Websites/5
        public Website Get(int id)
        {
            return _websiteRepository.Get(id);
        }

        // POST: api/Websites
        public void Post([FromBody]Website website)
        {
            _websiteRepository.Add(website);
        }

        // PUT: api/Websites/5
        public void Put(int id, [FromBody]Website website)
        {
            _websiteRepository.Update(website);
        }

        // DELETE: api/Websites/5
        public void Delete(int id)
        {
            _websiteRepository.Remove(id);
        }
    }
}
