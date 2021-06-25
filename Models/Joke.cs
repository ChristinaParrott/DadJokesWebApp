using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        [DisplayName("Joke Question")]
        public string JokeQuestion { get; set; }
        [DisplayName("Joke Answer")]
        public string JokeAnswer { get; set; }
        [DisplayName("Joke User")]
        public string JokeUser { get; set; }

        public Joke()
        {

        }
    }
}
