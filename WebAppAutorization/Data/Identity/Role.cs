using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


namespace WebAppAutorization.Data.Identity
{
    public class Role : IdentityRole
    {
        [MaxLength(256)]
        public string RoleName { get; set; }

    }
}
