using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WMSPharmacy.Model
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NameRole { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
