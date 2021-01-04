using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3).ToList();

            Display ((List<ProductReview>) recordData);
        }
        
        public void Display(List<ProductReview> records)
        {
            foreach (var list in records)
            {
                Console.WriteLine("ProductID " + list.ProductId + " UserID " + list.UserId + " Rating " + list.Rating + " Review " + list.Review + "IsLike " + list.isLike);
            }
        }
    }
}
