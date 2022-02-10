﻿using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    // Tests for the BookController
    public class BookTests
    {
        /* TODO: Fix this test. It has the same issue as the AuthorTests Index Test
         * 
        [Fact]
        public void IndexTest()
        {
            // Test to see if titles of all books are returned without duplicates

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new BookController(fakeRepo);
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { BookTitle = "Book 1" };
            fakeRepo.AddReviewAsync(review1);
            fakeRepo.AddReviewAsync(review1);
            var review2 = new Review() { BookTitle = "Book 2" };
            fakeRepo.AddReviewAsync(review2);
            fakeRepo.AddReviewAsync(review2);
            var review3 = new Review() { BookTitle = "Book 3" };
            fakeRepo.AddReviewAsync(review3);
            fakeRepo.AddReviewAsync(review3);
            // Act
            var viewResult = (ViewResult)controller.Index().Result;
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var titles = (List<string>)viewResult.ViewData.Model;
            Assert.Equal(3, titles.Count);
            Assert.Equal(titles[0], review1.BookTitle);
            Assert.Equal(titles[1], review2.BookTitle);
            Assert.Equal(titles[2], review3.BookTitle);
        }
        */
    }
}
