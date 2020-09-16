namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CategoryViewModel
    {
        public CategoryViewModel(Category incomingTategory)
        {
            id = incomingTategory.id;
            Category1 = incomingTategory.Category1;
            SubCategory = incomingTategory.SubCategory;
        }

        public Guid id { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(150)]
        public string Category1 { get; set; }

        [Required]
        [StringLength(150)]
        public string SubCategory { get; set; }

    
    }
}
