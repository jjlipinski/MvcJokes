using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcJokes.Models;

public class Joke
{
    [Display(Name = "ID")]
    public int Id { get; set; }

    [StringLength(60), Required, Display(Name = "Joke Question")]
    public string? JokeQuestion { get; set; }

    [StringLength(60), Required, Display(Name = "Joke Answer")]
    public string? JokeAnswer { get; set; }

    [StringLength(10), Display(Name = "Joke Rating")]
    public string? JokeRating { get; set; }
}