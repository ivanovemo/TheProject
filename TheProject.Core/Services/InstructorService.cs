using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using TheProject.Core.Contracts;
using TheProject.Core.Models.Course;
using TheProject.Core.Models.Instructor;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Core.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly ApplicationDbContext _context;
        public InstructorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<InstructorViewModel> GetInstructorByIdAsync(Guid instructorId)
        {
            var courseInstructor = await _context.Instructors.FirstOrDefaultAsync(i => i.Id == instructorId);

            var model = new InstructorViewModel()
            {
                Id = courseInstructor.Id,
                FirstName = courseInstructor.FirstName,
                LastName = courseInstructor.LastName,
                Photo = courseInstructor.Photo,
                Bio = courseInstructor.Bio
            };

            return model;
        }
    }
}
