using System.ComponentModel.DataAnnotations;

namespace HandballAPI.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        public void CloneIt(User user)
        {
            Fname = user.Fname;
            Lname = user.Lname;
            Email = user.Email;
            Password = user.Password;
            PhoneNumber = user.PhoneNumber;
        }
    }
}
