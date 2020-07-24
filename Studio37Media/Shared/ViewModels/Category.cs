namespace Studio37Media.Shared
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   // using System.Data.Entity.Spatial;

    public partial class Category
    {
 

        public Guid id { get; set; }

      //  [Column("Category")]
        [Required]
        [StringLength(450)]
        public string Category1 { get; set; }

        [Required]
        [StringLength(450)]
        public string SubCategory { get; set; }

    }
}
