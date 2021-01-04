using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1
            Console.WriteLine("Product Review Management With Linq!");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 2,UserId = 2, Rating = 6, Review = "Nice", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 3,UserId = 3, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 4,UserId = 4, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 5,UserId = 5, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 6,UserId = 6, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 9,UserId = 9, Rating = 8, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 8,UserId = 8, Rating = 3, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 9,UserId = 9, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 4,UserId = 4, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 11,UserId = 11, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 12,UserId = 12, Rating = 9, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 14,UserId = 14, Rating = 3, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 15,UserId = 15, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 16,UserId = 16, Rating = 2, Review = "bad", isLike = true }
            };

            /* foreach (var list in productReviewList)
             {
                 Console.WriteLine("\n-----------------");
                 Console.Write("\nProductID " + list.ProductId + "\nUserID " + list.UserId + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
             }*/

            ProductManagement management = new ProductManagement();
            //management.TopRecords(productReviewList); 
            // management.RetriveRecordsOnSpecificCon(productReviewList);
            //management.CountOfRecordsByProductID(productReviewList);
            //management.RetrieveProductIDAndReview(productReviewList);
            // management.skippedTopFiveRecords(productReviewList);

            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            DataTable dataTable = productReviewDataTable.CreateDataTableAddDefaultValues();
            /*
                        Retrive All records
                        foreach (DataRow row in data.Rows)
                        {
                            Console.Write("-->");
                            foreach (var item in row.ItemArray)
                            { 
                                Console.Write(" "+item);
                            }
                            Console.Write("\n ");
                        }*/

            /*// iterate all rows.
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine(row.Field<int>(0), row.Field<int>(1), row.Field<int>(2), row.Field<string>(3), row.Field<bool>(4));
            }*/

            /*foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    bool islike = row.Field<bool>(4);
                    if (islike == true)
                    {
                        Console.Write(" " + item);
                    }
                }
                Console.Write("\n ");
            }*/
            //management.retriveRecordsWhohaveLikeValueTrue(dataTable);
            //management.calAverageRatingOfEachProductID(dataTable);
            //management.RetrievRecordsReviewIsNice(dataTable);
            management.RetrievPerticularUserIDRecords(dataTable);
        }
    }
}
