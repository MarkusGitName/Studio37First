namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassRating
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public Guid ClassVideoID { get; set; }

        public int? Rating { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
