using System.ComponentModel.DataAnnotations;

namespace employeeservice.Models
{
    public class LoginUsersAddRequest
    {
        [Key]
        public string Id { get; set; }
        public string _id { get; set; }
        public string _rev { get; set; }
        public string EmailID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Passwordsalt { get; set; }
        public string Type { get; set; }
    }
}