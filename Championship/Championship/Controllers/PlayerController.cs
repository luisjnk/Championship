using AutoMapper;
using Championship.Domain.Entities;
using Championship.Infra.Data.Repositories;
using Championship.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Championship.Controllers
{
    public class PlayerController : ApiController
    {
        private readonly PlayerRepository _playerRepository = new PlayerRepository();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]PlayerViewModel player)
        {
            var playerDomain = Mapper.Map<PlayerViewModel, Player>(player);
            _playerRepository.Add(playerDomain);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}