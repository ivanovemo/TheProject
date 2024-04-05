using TheProject.Core.Models.Course;
using TheProject.Core.Models.Instructor;
using TheProject.Infrastructure.Data.Models;

namespace TheProject.Core.Contracts
{
    public interface IInstructorService
    {
        Task<InstructorViewModel> GetInstructorByIdAsync(Guid instructorId);
    }
}
