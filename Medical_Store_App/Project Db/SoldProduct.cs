using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class SoldProduct
    {
        public long Id { get; set; }
        [ForeignKey("Sale_History")]
        public long Sale_Id { get; set; }
        [ForeignKey("Sold_Product")]
        public long Product_Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Total_Amount { get; set; }
        public float Profit { get; set; }
        public DateTime Sale_Date { get; set; }
        public SaleInfo Sale_History { get; set; }
        public Stock Sold_Product { get; set; }
    }
}
