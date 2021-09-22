using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WMSPharmacy.Model
{
    public partial class Manufacturers
    {
        public Manufacturers()
        {
            Medicines = new HashSet<Medicines>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ManufacturerName { get; set; }

        public virtual ICollection<Medicines> Medicines { get; set; }
    }
}
