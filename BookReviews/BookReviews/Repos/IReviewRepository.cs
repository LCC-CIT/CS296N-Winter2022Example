﻿using BookReviews.Models;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Repos
{
    public interface IReviewRepository
    {
        IQueryable<Review> Reviews { get; }  // Read (or retrieve) reviews
        Task AddReviewAsync(Review review);  // Create a review
        Task UpdateReviewAsync(Review review);  // Modify a review
    }
}
