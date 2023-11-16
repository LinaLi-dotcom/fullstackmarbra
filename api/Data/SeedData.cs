using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<HouseEntity>().HasData(new List<HouseEntity> {
            new HouseEntity{
                Id = 1,
                Address = "123 Main St",
                Country = "USA",
                Description = "A nice house",
                Price = 100000,

            },
            new HouseEntity{
                Id = 2,
                Address = "123 Main St",
                Country = "USA",
                Description = "A nice house",
                Price = 100000,

            },
            new HouseEntity{
                Id = 3,
                Address = "123 Main St",
                Country = "USA",
                Description = "A nice house",
                Price = 100000,

            },
            new HouseEntity{
                Id = 4,
                Address = "123 Main St",
                Country = "USA",
                Description = "A nice house",
                Price = 100000,

            },
        });
    }
}