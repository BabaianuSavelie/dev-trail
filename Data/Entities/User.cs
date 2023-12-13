using Microsoft.AspNetCore.Identity;

namespace dev_trail.Data.Entities;

public class User : IdentityUser
{
    public List<Post> Posts { get; set; }
}
