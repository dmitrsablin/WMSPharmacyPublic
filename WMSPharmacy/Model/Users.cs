using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WMSPharmacy.Model
{
    public partial class Users
    {
        public Users()
        {
            History = new HashSet<History>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string MiddleName { get; set; }

        public int UserRole { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        public virtual ICollection<History> History { get; set; }

        public virtual UserRoles UserRoles { get; set; }
    }
}
