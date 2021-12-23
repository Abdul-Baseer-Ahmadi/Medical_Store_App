using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class SaleInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Sale_Id { get; set; }
        public DateTime Sale_Date { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [DefaultValue(0)]
        public float Total_Amount { get; set; }
        [DefaultValue(0)]
        public float Discount { get; set; }
        [DefaultValue(0)]
        public float Paid_Amount { get; set; }
        [DefaultValue(0)]
        public int Total_Items { get; set; }
        public UserLogin User { get; set; }
        public ICollection<SoldProduct> Sold_Product { get; set; }

    }
}
