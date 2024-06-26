﻿using TheProject.Core.Models.Review;

namespace TheProject.Core.Contracts
{
    public interface IReviewService
    {
        Task AddReviewAsync(ReviewViewModel model, string userId);
        Task<IList<ReviewViewModel>> GetReviewsByCourseIdAsync(Guid courseId);
    }
}
