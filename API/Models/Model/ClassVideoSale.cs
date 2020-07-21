using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ClassVideoSale
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("ClassVideoID")]
        public Guid? ClassVideoId { get; set; }
        [Column("SaleID")]
        public Guid? SaleId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [ForeignKey(nameof(ClassVideoId))]
        [InverseProperty("ClassVideoSale")]
        public virtual ClassVideo ClassVideo { get; set; }
        [ForeignKey(nameof(SaleId))]
        [InverseProperty("ClassVideoSale")]
        public virtual Sale Sale { get; set; }
    }
}
