using Microsoft.EntityFrameworkCore;

namespace HandballAPI.Model
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { PostId = 1, Title = "Jugge", Description = "Övningen jugge...", Link = "Test", Author = "Filip Lindberg", Team = "Herrarna" },
                new Post { PostId = 2, Title = "Utvisningspel", Description = "Utvisningsepelets tanke ör att isolera en 2:a för att får ett man man läge mellan 3 och 2 på sin starkaste sida.", Link = "Test 2", Author = "Filip Lindberg", Team = "P08" }
                );
        }
    }
}
