using System.ComponentModel.DataAnnotations;

namespace JokesWeb.Models
{
    public class Joke
    {
        public Joke()
        {
            
        }

        public int Id { get; set; }

        [Required]
        public string JokeQuestion { get; set; }

        [Required]
        public string JokeAnswer { get; set; }

        public string? CreatedByUsername { get; set; }
    }
}