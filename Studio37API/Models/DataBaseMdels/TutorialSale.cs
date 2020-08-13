namespace Studio37API.Models.DataBaseMdels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TutorialSale")]
    public partial class TutorialSale
    {
        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid SaleID { get; set; }

        public virtual Sale Sale { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
