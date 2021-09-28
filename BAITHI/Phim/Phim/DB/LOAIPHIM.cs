namespace Phim.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHIM")]
    public partial class LOAIPHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHIM()
        {
            PHIMs = new HashSet<PHIM>();
        }

        [Key]
        [StringLength(5)]
        public string MaLP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIM> PHIMs { get; set; }
    }
}
