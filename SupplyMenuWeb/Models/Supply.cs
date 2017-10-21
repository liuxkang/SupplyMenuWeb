namespace SupplyMenuWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supply")]
    public partial class Supply
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplyName { get; set; }

        [StringLength(50)]
        public string SupplyType { get; set; }

        [Required]
        [StringLength(3)]
        public string Dw { get; set; }

        public int Count { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }
    }
}
