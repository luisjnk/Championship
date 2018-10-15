using System;
using System.Collections.Generic;

namespace Championship.Domain.Entities
{
    public class Key
    {
        public Guid KeyId { get; set; }

        public string Name { get; set; }

        public List<Team> Team {get; set;}
        
    }
}