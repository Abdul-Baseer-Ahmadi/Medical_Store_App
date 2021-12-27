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
    public class ReturnInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Return_Id { get; set; }
        [DefaultValue(0)]
        public int Total_items { get; set; }
        [DefaultValue(0)]
        public float Return_Amount { get; set; }
        public DateTime Return_Date { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public ICollection<SaleReturn> Sale_Return { get; set; }
        public UserLogin User { get; set; }
    }
}
