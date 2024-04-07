using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Lecture;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Core.Services
{
    public class LectureService : ILectureService
    {
        private readonly ApplicationDbContext _context;

        public LectureService(ApplicationDbContext context)
        {
                _context = context;
        }

        public async Task AddLectureAsync(LectureViewModel model, DateTime startDate)
        {
            var lecture = new Lecture()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Description = model.Description,
                Duration = model.Duration,
                StartDate = startDate,
                CourseId = model.CourseId,
                
            };

            await _context.Lectures.AddAsync(lecture);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<LectureViewModel>> GetLecturesByCourseId(Guid courseId)
        {
            return await _context.Lectures
                .Where(l => l.CourseId == courseId)
                .Select(l => new LectureViewModel()
                {
                    Id = l.Id,
                    Title = l.Title,
                    Description = l.Description,
                    Duration = l.Duration,
                    StartDate = l.StartDate.ToString("dd/MM/yyy HH:mm"),
                    CourseId = l.CourseId
                })
                .ToListAsync();
        }
    }
}
