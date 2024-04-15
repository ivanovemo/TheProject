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
            var instructor = await _context.Instructors.FirstOrDefaultAsync(i => i.Id == instructorId);

            if (instructor == null)
            {
                throw new ArgumentException("Invalid instructor ID.");
            }

            var model = new InstructorViewModel()
            {
                Id = instructor.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Photo = instructor.Photo,
                Bio = instructor.Bio
            };

            return model;
        }
    }
}
