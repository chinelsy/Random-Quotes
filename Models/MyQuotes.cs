using System;
using System.Collections.Generic;

namespace RandomQuotes.Models
{
    public static class MyQuotes
    {
        // public static List<GenerateQuotes> Storequotes = new List<GenerateQuotes> ()
        public static List<GenerateQuotes> Storequotes { get; set; } = new List<GenerateQuotes>
        {
            new GenerateQuotes
            {
                Author = "Motivational Speaker",
                Quote = "Aspire to acquire the desire that you admire. but if in the process " +
                        "you prespire, don't retire but REFIRE to acquire that desire that you admire."
            },

             new GenerateQuotes
            {
                Author = "Chimamanda Adichie",
                Quote = "Never ever accept Because you are a woman as a reason for doing or not doing anything."
            },

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
                Quote = "The danger of a single story(sterotype)"
            },

            new GenerateQuotes
            {
                Author = "CHIKKI",
                Quote = "I choose to make the rest of my life the best of my LIFE"
            },

            new GenerateQuotes
            {
                Author = "Napoleon Hill",
                Quote = " Whatever the mind of man can conceive and believe, it can achieve"
            },

            new GenerateQuotes
            {
                Author = "Robert Frost",
                Quote ="Two roads diverged in a wood, and I—I took the one less traveled by, And that has made all the difference.  "
            },

            new GenerateQuotes
            {
                Author = "Albert Einstein",
                Quote = "Strive not to be a success, but rather to be of value. –"
            },

            new GenerateQuotes
            {
                Author = "F.Nightingale",
                Quote = " I attribute my success to this: I never gave or took any excuse."
            },

            new GenerateQuotes
            {
                Author = "Adichie Ngozi Chimamanda",
                Quote = "At the END we should all be Feminist"
            }
        };


        public static GenerateQuotes GetRandomQuotes()
        {
            var returnQuotes = Storequotes[new Random().Next(Storequotes.Count)];
            return returnQuotes;
        }

    }
}
