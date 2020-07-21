namespace Studio37API.Models.DataBaseModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventUser
    {
        public Guid id { get; set; }

        public Guid EventID { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public virtual Event Event { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
