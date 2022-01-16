using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class PaymentInfo
    {
        public long Id { get; set; }
        [ForeignKey("Company_Info")]
        public int Company_Id { get; set; }
        public float Received_Amount { get; set; }
        public string Bill_No { get; set; }
        public float Given_Amout { get; set; }
        public string Raseed_No { get; set; }
        public float Remaining_Amount { get; set; }
        public DateTime Pay_Date { get; set; }
        public CompanyInfo Company_Info { get; set; }

    }
}
