using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3).ToList();
            DisplayRecords((List<ProductReview>)recordData);
        }

        public void DisplayRecords(List<ProductReview> records)
        {
            foreach (var list in records)
            {
                Console.WriteLine("ProductID " + list.ProductId + " UserID " + list.UserId + " Rating " + list.Rating + " Review " + list.Review + "IsLike " + list.isLike);
            }
        }

        public void RetriveRecordsOnSpecificCon(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              where ((productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                              && productReviews.Rating > 3)
                              select productReviews).ToList();
            DisplayRecords(recordData);
        }
        /// <summary>
        /// Retrive Count of ProductID Records
        /// </summary>
        /// <param name="listProductReview"></param>
        public void CountOfRecordsByProductID(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + " = " + list.Count);
            }
        }

        public void RetrieveProductIDAndReview(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.Select(x => new { ProductID = x.ProductId, ProductReview = x.Review });
            foreach (var records in recordData)
            {

                Console.WriteLine("ProductID : " + records.ProductID + "\tProduct Review : " + records.ProductReview);
            }
        }

        public void skippedTopFiveRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              select productReviews).Skip(5).ToList();
            DisplayRecords(recordData);
        }

        public void retriveRecordsWhohaveLikeValueTrue(DataTable table)
        {
            {
                var records = table.Rows.Cast<DataRow>().Where(x => x["isLike"].Equals(true));

                foreach (var row in records)
                {
                    //  Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " "); Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " ");
                    foreach (var item in row.ItemArray)
                    {
                           Console.Write(" " + item);
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        public void calAverageRatingOfEachProductID(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .GroupBy(x => x.Field<int>("ProductId"))
                          .Select(x => new
                          {
                              ProductId = x.Key,
                              avrageRating = x.Average(x => x.Field<int>("Rating"))
                          }).ToList();

            foreach (var row in records)
            {
                Console.Write("ProductID : " + row.ProductId + " " + "Average Rating is : " + row.avrageRating);
                Console.WriteLine("\n");
            }
        }

        public void RetrievRecordsReviewIsNice(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["Review"].Equals("Nice"));

            foreach (var row in records)
            {
                Console.Write("ProductID : " + row.Field<int>("ProductId") + " " + "UserID : " + row.Field<int>("UserID") + " " + "Rating : " + row.Field<int>("Rating") + " " + "Review : " + row.Field<string>("Review") + " " + "isLike : " + row.Field<bool>("isLike"));
                Console.WriteLine("\n");
            }
        }
    }
}
