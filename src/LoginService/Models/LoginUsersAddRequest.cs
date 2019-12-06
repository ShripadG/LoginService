using System.ComponentModel.DataAnnotations;

namespace LoginService.Models
{
    public class LoginUsersAddRequest
    {
       
      
        public string EmailID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Passwordsalt { get; set; }
        public string Type { get; set; }
    }
}