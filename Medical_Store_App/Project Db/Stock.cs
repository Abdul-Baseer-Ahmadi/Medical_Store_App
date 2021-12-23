using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class Stock
    {
        public long Id { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Purchase_Price { get; set; }
        public float Profit { get; set; }
        public float Sale_Price { get; set; }
        public int Quantity { get; set; }
        public float Total_Amount { get; set; }
        public DateTime Mfg_Date { get; set; }
        public DateTime Exp_Date { get; set; }
        public ICollection<SoldProduct> SoldProduct { get; set; }
        public ICollection<PurchaseItem> Purchase_Item { get; set; }
    }
}
