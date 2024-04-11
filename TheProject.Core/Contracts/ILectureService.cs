using TheProject.Core.Models.Lecture;
using TheProject.Core.Models.Review;

namespace TheProject.Core.Contracts
{
    public interface ILectureService
    {
        Task AddLectureAsync(LectureViewModel model, DateTime startDate);
        Task<IList<LectureViewModel>> GetLecturesByCourseId(Guid courseId);
        Task<LectureViewModel> GetLectureByIdAsync(Guid lectureId);
        Task DeleteLectureAsync(Guid lectureId);
    }
}
