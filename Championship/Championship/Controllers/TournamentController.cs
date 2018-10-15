using AutoMapper;
using Championship.Domain.Entities;
using Championship.Infra.Data.Repositories;
using Championship.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Championship.Controllers
{
    public class TournamentController : ApiController
    {

        private readonly TournamentRepository _tournamentRepository = new TournamentRepository();

        [HttpGet]
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
        public TournamentViewModel Post([FromBody]TournamentViewModel tournament) {
            try
            {
                Tournament tournamentDomain = Mapper.Map<TournamentViewModel, Tournament>(tournament);
                tournamentDomain.genId();
                string uri = "Tournament/set";
                _tournamentRepository.Add(tournamentDomain, uri);
                TournamentViewModel tournamentVM = Mapper.Map<Tournament, TournamentViewModel>(tournamentDomain);
                return tournamentVM;

            }
            catch (Exception ex)
            {
                throw;
            }
    
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