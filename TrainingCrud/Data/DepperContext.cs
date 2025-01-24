using Microsoft.EntityFrameworkCore;
using TrainingCrud.Models;

namespace TrainingCrud.Data
{
    public class DepperContext : DbContext
    {
        public DepperContext(DbContextOptions<DepperContext> options) : base(options)
        {
        }

        public DbSet<TrainingCourse> TrainingCourses { get; set; }
    }
}