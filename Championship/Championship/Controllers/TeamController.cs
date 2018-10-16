﻿using AutoMapper;
using Championship.Domain.Entities;
using Championship.Infra.Data.Repositories;
using Championship.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Championship.Controllers
{
    public class TeamController : ApiController
    {

        private readonly TeamRepository _teamRepository = new TeamRepository();

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
        public void Post([FromBody]TeamViewModel team) { 
            var teamDomain = Mapper.Map<TeamViewModel, Team>(team);
            string uri = "Team/set";

            _teamRepository.Add(teamDomain, uri);
        }

        // POST api/<controller>
        [Route("api/team/bulk/insert")]
        public void PostBulkTeam([FromBody]List<TeamViewModel> teams)
        {
            var team = teams;

          /*  var teamDomain = Mapper.Map<TeamViewModel, Team>(team);
            string uri = "Team/set";

            _teamRepository.Add(teamDomain, uri);*/
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