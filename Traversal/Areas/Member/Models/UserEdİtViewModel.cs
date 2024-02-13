namespace Traversal.Areas.Member.Models
{
    public class UserEdİtViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string ımageurl { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public IFormFile Image {get; set;}

    }
}
