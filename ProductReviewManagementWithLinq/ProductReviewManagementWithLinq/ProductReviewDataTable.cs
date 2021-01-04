using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class ProductReviewDataTable
    {
        public DataTable CreateDataTableAddDefaultValues()
        {
            //Here we adding Column
            DataTable productTable = new DataTable();
            productTable.Columns.Add("ProductId",typeof(int));
            productTable.Columns.Add("UserId",typeof(int));
            productTable.Columns.Add("Rating", typeof(int));
            productTable.Columns.Add("Review", typeof(string));
            productTable.Columns.Add("isLike", typeof(bool));

            //Here we adding Rows
            productTable.Rows.Add(1, 1,  5,"Good", true);
            productTable.Rows.Add(2, 2,  6, "Nice", false);
            productTable.Rows.Add(1, 1,  5, "Good", true );
            productTable.Rows.Add(3, 3,  4, "Good", false);
            productTable.Rows.Add(4, 4,  5, "Good", true);
            productTable.Rows.Add( 5, 5, 4, "Good", false);
            productTable.Rows.Add(6, 6,  3, "Nice", true);
            productTable.Rows.Add(9, 9,  8,  "Good", true);
            productTable.Rows.Add(8, 8,  3,  "Good", false);
            productTable.Rows.Add(9, 9,  3, "Nice", true);
            productTable.Rows.Add(4, 4,  4, "Good", true);
            productTable.Rows.Add(11, 11, 4, "Good", false);
            productTable.Rows.Add(12, 12, 9, "Good", true);
            productTable.Rows.Add(1,  1,  3, "Nice", true);
            productTable.Rows.Add(14, 14, 3, "Good", true);
            productTable.Rows.Add(15, 15, 5, "Good", true);
            productTable.Rows.Add(16, 16, 2, "bad",  true);
            productTable.Rows.Add(10, 12, 9, "Good", true);
            productTable.Rows.Add(10, 1, 3, "Nice", true);
            productTable.Rows.Add(10, 14, 3, "Good", true);
            productTable.Rows.Add(10, 15, 5, "Good", true);
            productTable.Rows.Add(10, 16, 2, "bad", true);

            return productTable;
        }
    }
}
