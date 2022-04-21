using Microsoft.EntityFrameworkCore;

namespace HandballAPI.Model
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { PostId = 1, Title = "Test 1", Description = "Test 11", Link = "Test", UserId = 1 },
                new Post { PostId = 2, Title = "Test 2", Description = "Test 22", Link = "Test 2", UserId = 2 }
                );
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Fname = "Filip", Lname = "Lindberg", Email = "filip.lindberg97@gmail.com", Password = "112233", PhoneNumber = 112 },
                new User { UserId = 2, Fname = "Test", Lname = "Lindberg", Email = "filip.lindberg97@test.com", Password = "11223344", PhoneNumber = 112233 }
                );
        }
    }
}
