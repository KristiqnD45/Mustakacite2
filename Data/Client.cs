using Microsoft.AspNetCore.Identity;

namespace ASPMustakacite.Data
{
    public class Client : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredOn { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
