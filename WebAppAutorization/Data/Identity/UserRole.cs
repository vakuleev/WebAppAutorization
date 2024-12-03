using Microsoft.AspNetCore.Identity;

namespace WebAppAutorization.Data.Identity
{
//    [Table("ApplicationUserRoles", Schema = "data")]
    public class UserRole : IdentityUserRole<string>
    {
        //override public string? UserId { get; set; }
        //override public string? RoleId { get; set; }
    }
}
