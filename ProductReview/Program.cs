using System;
using System.Collections.Generic;
using System.Data;

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
            new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 16, UserId = 1, Rating = 3, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 17, UserId = 1, Rating = 3, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 18, UserId = 1, Rating = 3.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 18, UserId = 1, Rating = 3.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 19, UserId = 1, Rating = 2.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 20, Rating = 2, Review = "Bad", isLike=false }

            };
          
            ManagementReview display = new ManagementReview();
            display.TopRecords(list);
            display.SelectedRecords(list);
            display.CountRecord(list);
            display.RetrieveAnd_Review(list);
            display.Skip_Five_Records(list);

            DataTable data = display.CreateTable(list);
            foreach (var table in list)
            {
                data.Rows.Add(table.ProductId,table.UserId,table.Rating,table.Review,table.isLike);
            }
            display.RetrieveRecordsWithisLikeTrue(data);
        }
    }
}