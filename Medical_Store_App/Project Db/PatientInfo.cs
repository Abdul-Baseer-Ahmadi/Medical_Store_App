using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class PatientInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Visit_Date { get; set; }
        public ICollection<LabPayment> Lab_Patient_Payment { get; set; }
    }
}
