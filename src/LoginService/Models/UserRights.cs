using System.ComponentModel.DataAnnotations;

namespace employeeservice.Models
{
    public class LoginUsers
    {
        [Key]
        public string Id { get; set; }
        public string _id { get; set; }
        public string _rev { get; set; }
        public string LoginTypes { get; set; }
        public string IsEmployeeMaster { get; set; }
        public string ILCMaster { get; set; }
        public string ForcastMaster { get; set; }
        public string Financials { get; set; }
        public string Financials { get; set; }
        public string Financials { get; set; }
        public string Financials { get; set; }
        public string Financials { get; set; }

    }
}