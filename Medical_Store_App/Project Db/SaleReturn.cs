using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class SaleReturn
    {
        public long Id { get; set; }
        [ForeignKey("Return_Info")]
        public long Return_Id { get; set; }
        [ForeignKey("Stock_Products")]
        public long Product_Id { get; set; }
        public float Unit_Price { get; set; }
        public int Quantity { get; set; }
        [DefaultValue(0)]
        public float Total_Amount { get; set; }
        public DateTime Return_Date { get; set; }
        public Stock Stock_Products { get; set; }
        public ReturnInfo Return_Info { get; set; }

    }
}
