using System;


namespace Championship.Domain.Entities
{
    public class Tournament
    {
        public Guid TournamentId { get; set; }

        public string Name { get; set; }

        public int TeamsCount { get; set; }

        public void genId()
        {
            this.TournamentId = Guid.NewGuid();
        }

    }
}
