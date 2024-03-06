using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //koristi se za nadjacavanje pri kreiranju modela
            modelBuilder.Entity<Villa>().HasData(
                new Villa() 
                    {
                        Id = 1,
                        Name = "King vila",
                        Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                        ImageUrl="",//ecample path image
                        Occupancy = 5,
                        Rate = 2000,
                        Sqft = 550,
                        Amenity=""
                },
                new Villa()
                {
                    Id = 2,
                    Name = "King vila 2",
                    Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                    ImageUrl = "",//ecample path image
                    Occupancy = 5,
                    Rate = 1000,
                    Sqft = 300,
                    Amenity = ""
                },
                new Villa()
                {
                    Id = 3,
                    Name = "King vila 3",
                    Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                    ImageUrl = "",//ecample path image
                    Occupancy = 4,
                    Rate = 1200,
                    Sqft = 350,
                    Amenity = ""
                },
                new Villa()
                {
                    Id = 4,
                    Name = "King vila 4",
                    Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                    ImageUrl = "",//ecample path image
                    Occupancy = 3,
                    Rate = 800,
                    Sqft = 200,
                    Amenity = ""
                },
                new Villa()
                {
                    Id = 5,
                    Name = "King vila 5",
                    Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                    ImageUrl = "",//ecample path image
                    Occupancy = 5,
                    Rate = 1400,
                    Sqft = 900,
                    Amenity = ""
                },
                new Villa()
                {
                    Id = 6,
                    Name = "King vila 6",
                    Details = "Prekrasna vila s 4 spavaće sobe i privatnim bazenom, idealna za obiteljski odmor." +
                        "\r\nSmještena u mirnom okruženju, samo 50 metara od plaže." +
                        "\r\nVila nudi savršen spoj moderne opreme i tradicionalnog dalmatinskog stila.\r\n",
                    ImageUrl = "",//ecample path image
                    Occupancy = 5,
                    Rate = 1000,
                    Sqft = 300,
                    Amenity = ""
                }
                );
        }
    }
}
