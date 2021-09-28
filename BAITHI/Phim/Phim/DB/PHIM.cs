namespace Phim.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIM")]
    public partial class PHIM
    {
        [Key]
        [StringLength(5)]
        public string MaPH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPH { get; set; }

        public DateTime NgayCC { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLP { get; set; }

        public virtual LOAIPHIM LOAIPHIM { get; set; }
    }
}
