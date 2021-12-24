using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class UserLogin
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Confirm_Pass { get; set; }
            public string Role { get; set; }
            public ICollection<SaleInfo> SaleInfo { get; set; }
            public ICollection<PurchaseInfo> PurchaseInfo { get; set; }
            public ICollection<ReturnInfo> ReturnInfo { get; set; }
    }
}
