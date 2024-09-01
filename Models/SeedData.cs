using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcJoke.Data;
using System;
using System.Linq;

namespace MvcJokes.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcJokeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcJokeContext>>()))
        {
            // Look for any movies.
            if (context.Joke.Any())
            {
                return;   // DB has been seeded
            }
            context.Joke.AddRange(
                new Joke
                {
                    JokeQuestion = "Why did Mozart get rid of his chickens?",
                    JokeAnswer = "All they said was Bach, Bach, Bach!",
                    JokeRating = "cheesy"
                },
                new Joke
                {
                    JokeQuestion = "Why couldn’t the classical composer concentrate in the saloon?",
                    JokeAnswer = "There was too much Bartók!",
                    JokeRating = "clever"
                }
            
            );
            context.SaveChanges();
        }
    }
}