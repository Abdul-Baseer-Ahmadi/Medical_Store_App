using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        public string Company_Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public ICollection<PaymentInfo> Payment_Info { get; set; }
    }
}
