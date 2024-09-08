using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedDiaryEntries(modelBuilder);
    }

    private static void SeedDiaryEntries(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<DiaryEntry>()
            .HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Lisa.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Walked Dogs",
                    Content = "Walked Henri and Hugo. Both has massive dumps!",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went to the Gym",
                    Content = "Went to the gym and did some cardio.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 4,
                    Title = "Went to the Movies",
                    Content = "Went to the movies and watched a comedy.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 5,
                    Title = "Went to the Beach",
                    Content = "Went to the beach and swam in the ocean.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 6,
                    Title = "Went to the Park",
                    Content = "Went to the park and had a picnic.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 7,
                    Title = "Went to the Zoo",
                    Content = "Went to the zoo and saw the animals.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 8,
                    Title = "Went to the Museum",
                    Content = "Went to the museum and saw the exhibits.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 9,
                    Title = "Went to the Library",
                    Content = "Went to the library and read some books.",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 10,
                    Title = "Went to the Mall",
                    Content = "Went to the mall and did some shopping.",
                    Created = DateTime.Now
                }
            );
    }
}
