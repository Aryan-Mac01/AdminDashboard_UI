using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdminDashboard_UI.Models
{
    [Table("Users")]
    public class Users
    {
        [Key] //Primary key
        public int UserId { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [MaxLength(40)]
        public string Role { get; set; }

        public string password { get; set; }

    }
}
