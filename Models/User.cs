using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}