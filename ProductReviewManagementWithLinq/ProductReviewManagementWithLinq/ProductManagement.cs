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
    }
}
