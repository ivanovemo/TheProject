using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Lecture;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;
using Constants = TheProject.Infrastructure.Constants.Constants;

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
            if (!await _context.Courses.AnyAsync(c => c.Id == model.CourseId))
            {
                throw new ArgumentException($"No course found with ID {model.CourseId}. Cannot add lecture.");
            }

            var lecture = new Lecture()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Description = model.Description,
                Duration = model.Duration,
                StartDate = startDate,
                CourseId = model.CourseId,

            };

            _context.Lectures.Add(lecture);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLectureAsync(Guid lectureId)
        {
            var lecture = await _context.Lectures.FindAsync(lectureId);

            if (lecture != null)
            {
                _context.Lectures.Remove(lecture);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException($"A lecture with the ID {lectureId} was not found.");
            }
        }

        public async Task<LectureViewModel> GetLectureByIdAsync(Guid lectureId)
        {
            var lecture = await _context.Lectures
                .Where(l => l.Id == lectureId)
                .Select(l => new LectureViewModel
                {
                    Id = l.Id,
                    Title = l.Title,
                    Description = l.Description,
                    StartDate = l.StartDate.ToString(Constants.Date.LectureFormat),
                    Duration = l.Duration,
                    CourseId = l.CourseId
                })
                .FirstOrDefaultAsync();

            if (lecture == null)
            {
                throw new ArgumentException($"A lecture with the ID {lectureId} was not found.");
            }

            return lecture;
        }

        public async Task<IList<LectureViewModel>> GetLecturesByCourseId(Guid courseId)
        {
            if (!await _context.Courses.AnyAsync(c => c.Id == courseId))
            {
                throw new ArgumentException($"No course found with ID {courseId}. Cannot retrieve lectures.");
            }

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
