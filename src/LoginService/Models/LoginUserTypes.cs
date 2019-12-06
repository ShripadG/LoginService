using System.ComponentModel.DataAnnotations;

namespace employeeservice.Models
{
    public class LoginUserTypes
    {
        [Key]
        public string Id { get; set; }
        public string _id { get; set; }
        public string _rev { get; set; }
        public string logintypes { get; set; }
        
       
    }
}