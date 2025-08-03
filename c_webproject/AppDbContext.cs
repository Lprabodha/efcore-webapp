using c_webproject.Models;
using Microsoft.EntityFrameworkCore;

namespace c_webproject
{

   
    public class AppDbContext:DbContext
    {
        /// <summary>
        /// inject defendencies
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
           
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Lecturer> lecturers { get; set; }
        public DbSet<Book> books { get; set; }
    }
}
