using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcJokes.Models;

public class Joke
{
    public int Id { get; set; }

    [Display(Name = "Joke Question")]
    public string? JokeQuestion { get; set; }

    [Display(Name = "Joke Answer")]
    public string? JokeAnswer { get; set; }

    [Display(Name = "Joke Rating")]
    public string? JokeRating { get; set; }
}