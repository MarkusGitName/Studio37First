namespace Studio37API.Models.DataBaseMdels
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

        public Guid ClassVideoID { get; set; }

        public Guid SaleID { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
