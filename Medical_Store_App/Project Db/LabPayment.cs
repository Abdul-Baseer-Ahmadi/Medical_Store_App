using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_App.Project_Db
{
    public class LabPayment
    {
        public long Id { get; set; }
        [ForeignKey("Patient_Info")]
        public long Patient_Id { get; set; }
        [ForeignKey("Test_Info")]
        public int Test_Id { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
        public float Total_Amount { get; set; }
        public DateTime Visit_Date { get; set; }
        public PatientInfo Patient_Info { get; set; }
        public TestInfo Test_Info { get; set; }
    }
}
