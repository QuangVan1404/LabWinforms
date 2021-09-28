namespace lab05_02.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoTT { get; set; }

        [StringLength(50)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public double DonGia { get; set; }

        public int SoLuong { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
