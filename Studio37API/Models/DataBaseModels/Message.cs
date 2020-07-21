namespace Studio37API.Models.DataBaseModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public Guid MessageID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Msge { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public Guid ChatID { get; set; }

        public virtual Chat Chat { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
