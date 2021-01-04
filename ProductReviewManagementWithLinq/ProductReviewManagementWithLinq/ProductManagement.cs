﻿using System;
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
    }
}
