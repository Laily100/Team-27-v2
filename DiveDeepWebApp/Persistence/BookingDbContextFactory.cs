using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DiveDeepWebApp.Persistence
{
    public class BookingDbContextFactory : IDesignTimeDbContextFactory<BookingDbContext>
    {
        public BookingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookingDbContext>();

            optionsBuilder.UseSqlServer(
    "Server=localhost\\SQLEXPRESS;Database=DiveDeepDB;Trusted_Connection=True;TrustServerCertificate=True;");




            return new BookingDbContext(optionsBuilder.Options);
        }
    }
}
