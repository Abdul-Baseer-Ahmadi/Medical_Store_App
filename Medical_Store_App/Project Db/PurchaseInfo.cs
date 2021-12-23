using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class PurchaseInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Purchase_Id { get; set; }
        [Index(IsUnique =true)]
        public long Invoice { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public DateTime Purchase_Date { get; set; }
        public UserLogin User { get; set; }
        public ICollection<PurchaseItem> Purchase_Item { get; set; }
    }
}
