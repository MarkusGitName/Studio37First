namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfesionalsDocument
    {
        public Guid id { get; set; }

        [StringLength(450)]
        public string UserID { get; set; }

        [Column(TypeName = "text")]
        public string Discription { get; set; }

        [StringLength(450)]
        public string DocumentPath { get; set; }

        public bool? VissibleToPublic { get; set; }

        public bool? VissibleToFollowers { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }
    }
}
