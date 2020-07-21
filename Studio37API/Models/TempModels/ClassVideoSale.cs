namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassVideoSale")]
    public partial class ClassVideoSale
    {
        public Guid id { get; set; }

        public Guid? ClassVideoID { get; set; }

        public Guid? SaleID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
