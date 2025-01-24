using Microsoft.EntityFrameworkCore;
using TrainingCrud.Data;
using TrainingCrud.Models;

namespace TrainingCrud.Repositories
{
    public class TrainingCourseRepository
    {
        private readonly DepperContext _context;

        public TrainingCourseRepository(DepperContext context)
        {
            _context = context;
        }

        public async Task<List<TrainingCourse>> GetAllAsync() =>
            await _context.TrainingCourses.ToListAsync();

        public async Task<TrainingCourse?> GetByIdAsync(int id)
        {
            return await _context.TrainingCourses.FindAsync(id);
        }

        public async Task AddAsync(TrainingCourse trainingCourse)
        {
            _context.TrainingCourses.Add(trainingCourse);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TrainingCourse trainingCourse)
        {
            _context.TrainingCourses.Update(trainingCourse);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var trainingCourse = await _context.TrainingCourses.FindAsync(id);
            _context.TrainingCourses.Remove(trainingCourse);
            await _context.SaveChangesAsync();
        }
    }
}
    