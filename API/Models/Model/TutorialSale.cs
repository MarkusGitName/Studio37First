using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialSale
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        [Column("SaleID")]
        public Guid? SaleId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfSale { get; set; }
        public int? Credits { get; set; }

        [ForeignKey(nameof(SaleId))]
        [InverseProperty("TutorialSale")]
        public virtual Sale Sale { get; set; }
        [ForeignKey(nameof(TutorialId))]
        [InverseProperty("TutorialSale")]
        public virtual Tutorial Tutorial { get; set; }
    }
}
