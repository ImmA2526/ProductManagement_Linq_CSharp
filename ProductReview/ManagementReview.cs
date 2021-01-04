using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
namespace ProductReviews
{
    class ManagementReview
    {
        /// <summary>
        /// UC 2 The Retrive Top # Record
        /// </summary>
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3).ToList();
           DisplayRecord((List<ProductReview>)recordedData);
        }

        /// <summary>
        /// UC 3 Selecteds the records.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                               where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                               && productReviews.Rating > 3
                               select productReviews).ToList();
            Console.WriteLine("Rating greater than 3 with product id of 1,4 or 9 :-");
            DisplayRecord((List<ProductReview>)recordedData);
        }

        /// <summary>
        /// Uc 4 Count The Record.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void CountRecord(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("\nResult for Records Grouped By ProductID");
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductID + "-----" + list.Count);
            }
        }

        /// <summary>
        /// UC 5 Retrieves the review.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void RetrieveAnd_Review(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductId, Review = x.Review });
            Console.WriteLine("ID with Review");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Review);
            }
        }

        /// <summary>
        /// UC 6 Skip Five Record .
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void Skip_Five_Records(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Skip(5).ToList();
            Console.WriteLine("Top Records skiping top 5 rated records- ");
            DisplayRecord((List<ProductReview>)recordedData);
        }

        /// <summary>
        /// UC 7 Retrive Data with Select.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void Retrieve_Review_UsingSelect(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductId, Review = x.Review });
            Console.WriteLine("ID with Review");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Review);
            }
        }

        /// <summary>
        /// Displays the record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void DisplayRecord(List<ProductReview>record)
        {
            foreach (var lists in record)
            {
                Console.WriteLine("Product id = " + lists.ProductId + "User id = " + lists.UserId + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.isLike);
            }
        }
    }
}
