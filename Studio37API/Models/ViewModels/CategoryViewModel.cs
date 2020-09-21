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
        public CategoryViewModel(Category incomingCategory)
        {
            id = incomingCategory.id;
            Category1 = incomingCategory.Category1;
            SubCategory = incomingCategory.SubCategory;
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
