using System;

namespace Championship.Domain.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Strength { get; set; }

        public int Agillity { get; set; }

        public int Defense { get; set; }

        public void genId()
        {
            Random rnd = new Random();
            this.PlayerId = rnd.Next(1, 100);
        }
    }
}