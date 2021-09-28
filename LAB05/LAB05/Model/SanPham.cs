namespace lab05_02.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(50)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        public decimal? GiaMua { get; set; }

        public decimal? GiaBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
