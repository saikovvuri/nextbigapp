using Microsoft.EntityFrameworkCore;

namespace marvel_api.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData
                (
                    new Character()
                    {
                        CharacterId = 1,
                        FirstName = "Anthony",
                        LastName = "Stark",
                        Status = "Deceased"
                    },
                    new Character()
                    {
                        CharacterId = 2,
                        FirstName = "Steven",
                        LastName = "Rogers",
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 3,
                        FirstName = "Peter",
                        LastName = "Quill",
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 4,
                        FirstName = "Thor",
                        LastName = "Odinson",
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 5,
                        FirstName = "Natalia",
                        LastName = "Romanoff",
                        Status = "Deceased"
                    },
                    new Character()
                    {
                        CharacterId = 6,
                        FirstName = "T'Challa",
                        LastName = null,
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 7,
                        FirstName = "Bruce",
                        LastName = "Banner",
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 8,
                        FirstName = "Scott",
                        LastName = "Lang",
                        Status = "Alive"
                    },
                    new Character()
                    {
                        CharacterId = 9,
                        FirstName = "Phillip",
                        LastName = "Coulson",
                        Status = "Deceased"
                    },
                    new Character()
                    {
                        CharacterId = 10,
                        FirstName = "Nick",
                        LastName = "Fury",
                        Status = "Alive"
                    }
                );
        }
    }
}
