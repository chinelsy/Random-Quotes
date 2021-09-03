using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomQuotes.Models
{
    public static class MyQuotes
    {
        public static List<GenerateQuotes> Datastore { get; set; } = new List<GenerateQuotes>
        {
            new GenerateQuotes
            {
                Author = "Anonymous",
                Quote = "The cost of not following your heart is spending the rest of your life wishing you had!!"
            },
            new GenerateQuotes
            {
                Author = "Anonymous function",
                Quote = "Don't let anyone take you back to a level that you leveled up from "
            },
             new GenerateQuotes
             {
                Author = "Chimamanda Adichie",
                Quote = "The danger of a single story"
             },
            new GenerateQuotes
            {
                Author = "CHIKKI",
                Quote = "I choose to make the rest of my life the best of my LIFE"
            },
             new GenerateQuotes
             {
                Author = "Adichie Ngozi Chimamanda",
                Quote = "At the END we should all be Feminist"
             }
        };
        public static GenerateQuotes GetRandomQuotes()
        {
            var quote2Return = Datastore[new Random().Next(Datastore.Count)];
            return quote2Return;
        }

    }
}
