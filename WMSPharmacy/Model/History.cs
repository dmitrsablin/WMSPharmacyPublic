using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSPharmacy.Model
{
    [Table("History")]
    public partial class History
    {
        public int Id { get; set; }

        public int UserName { get; set; }

        public int Medicines { get; set; }

        public int WasQuantity { get; set; }

        public int HasQuantity { get; set; }

        public DateTime DateOfChange { get; set; }

        public virtual Users Users { get; set; }

        public virtual Medicines Medicines1 { get; set; }
    }
}
