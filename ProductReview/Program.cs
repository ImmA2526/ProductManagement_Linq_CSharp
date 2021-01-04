using System;
using System.Collections.Generic;

namespace ProductReviews
{
    class Program
    {
        /// <summary>
        /// UC. 1 Create List of Product Review
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        	Console.WriteLine("****************Welcome To Product MGt Using Linq*******");

            List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() {ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 3, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 1, Rating = 5, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 8, UserId = 1, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 9, UserId = 1, Rating = 2.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 1, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 13, UserId = 1, Rating = 5, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike=true }
            };
        
            ManagementReview display = new ManagementReview();
            display.TopRecords(list);
        }
    }
}