using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WMSPharmacy.Model
{
    public partial class Medicines
    {
        public Medicines()
        {
            History = new HashSet<History>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MedicineName { get; set; }

        public int Manufacturer { get; set; }

        public int MedicinesType { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        [Required]
        [StringLength(2048)]
        public string Description { get; set; }

        [Required]
        [StringLength(2048)]
        public string Structure { get; set; }

        [Required]
        [StringLength(2048)]
        public string Diseases { get; set; }

        public bool IsDrug { get; set; }

        public virtual ICollection<History> History { get; set; }

        public virtual Manufacturers Manufacturers { get; set; }

        public virtual MedicinesTypes MedicinesTypes { get; set; }
    }
}
