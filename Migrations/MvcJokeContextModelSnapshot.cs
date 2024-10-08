﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcJoke.Data;

#nullable disable

namespace MvcJokes.Migrations
{
    [DbContext(typeof(MvcJokeContext))]
    partial class MvcJokeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MvcJokes.Models.Joke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JokeAnswer")
                        .HasColumnType("TEXT");

                    b.Property<string>("JokeQuestion")
                        .HasColumnType("TEXT");

                    b.Property<string>("JokeRating")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Joke");
                });
#pragma warning restore 612, 618
        }
    }
}
