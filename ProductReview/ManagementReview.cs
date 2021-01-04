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
        /// U8 Creates the table with All Filed.
        /// </summary>
        /// <param name="productReview">The product review.</param>
        /// <returns></returns>
        public DataTable CreateTable(List<ProductReview> productReview)
        {
            var tableColumn1=new DataColumn("ProductId",typeof(int));
            dataTable.Columns.Add(tableColumn1);
            var tableColumn2 = new DataColumn("UserId",typeof(int));
            dataTable.Columns.Add(tableColumn2);
            var tableColumn3 = new DataColumn("Rating", typeof(double));
            dataTable.Columns.Add(tableColumn3);
            var tableColumn4 = new DataColumn("Review");
            dataTable.Columns.Add(tableColumn4);
            var tableColumn5 = new DataColumn("isLike",typeof(bool));
            dataTable.Columns.Add(tableColumn5);
            return dataTable;
        }

        /// <summary>
        /// UC 9 Retrieves the records withis like true.
        /// </summary>
        /// <param name="table">The table.</param>
        public void RetrieveRecordsWithisLikeTrue(DataTable table)
        {
            var recordedData = from productReviews in table.AsEnumerable()
                               where (productReviews.Field<bool>("isLike") == true)
                               select productReviews;
            Console.WriteLine("Records with isLike=true are :-");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.Field<int>("ProductID") + " " + "UserID:- " + list.Field<int>("UserID")
                    + " " + "Rating:- " + list.Field<double>("Rating") + " " + "Review:- " + list.Field<string>("Review") + " " + "isLike:- " + list.Field<bool>("isLike"));
            }
        }

        /// <summary>
        /// UC 10 Gets the average ratings.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void GetAvgRatings(List<ProductReview> listProductReview)
        {
            Console.WriteLine("Avg Rating per Productid-");
            var recordedData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { Pid = x.Key, Pavg = x.Average(y => y.Rating) });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.Pid + "-----" + list.Pavg);
            }
        }

        /// <summary>
        /// UC  11Gets the nice review.
        /// </summary>
        public void GetNiceReview(List<ProductReview> listproductReview)
        {
            Console.WriteLine("Get Nice Messege Review:- ");
            var recordData = (from ProductReview in listproductReview
                             where (ProductReview.Review.Equals("Nice"))
                             select ProductReview).ToList();
            DisplayRecord((List<ProductReview>) recordData);
        }

        /// <summary>
        /// UC  12Gets the nice review.
        /// </summary>
        public void GetRecord_ByUserID(List<ProductReview> listproductReview)
        {
            Console.WriteLine("User ID 10 Record ");
            var recordData = (from ProductReview in listproductReview
                              where (ProductReview.UserId==10)
                              orderby ProductReview.Rating descending
                              select ProductReview).ToList();
            DisplayRecord((List<ProductReview>)recordData);
        }

        /// <summary>
        /// Displays the record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void DisplayRecord(List<ProductReview> record)
        {
            foreach (var lists in record)
            {
                Console.WriteLine("Product id = " + lists.ProductId + "User id = " + lists.UserId + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.isLike);
            }
        }
    }
}
