namespace Studio37API.Models.DataBaseMdels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TutorialRating")]
    public partial class TutorialRating
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public Guid TutorialID { get; set; }

        public int Rating { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
