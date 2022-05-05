using Microsoft.EntityFrameworkCore;

namespace HandballAPI.Model
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { PostId = 1, Title = "Test 1", Description = "Test 11", Link = "Test", Author = "Filip Lindberg", Team = "P08"/*, UserId = 1*/ },
                new Post { PostId = 2, Title = "Test 2", Description = "Test 22", Link = "Test 2", Author = "Filip Lindberg", Team = "P08"/*, UserId = 2*/ }
                );
        }
    }
}
