using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class PurchaseItem
    {
        public long Id { get; set; }
        [ForeignKey("Purchase_Info")]
        public long Purchase_Id { get; set; }
        [ForeignKey("Item_Stock")]
        public long Product_Id { get; set; }
        public long Invoice_No { get; set; }
        public int Quantity { get; set; }
        public float Purchase_Price { get; set; }
        public float Sale_Price { get; set; }
        public float Total_Amount { get; set; }
        public DateTime Mfg_Date { get; set; }
        public DateTime Expiry_Date { get; set; }
        public DateTime Purchase_Date { get; set; }

        public PurchaseInfo Purchase_Info { get; set; }
        public Stock Item_Stock { get; set; }
    }
}
