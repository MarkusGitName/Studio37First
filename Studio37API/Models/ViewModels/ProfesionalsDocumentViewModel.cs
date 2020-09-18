namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfesionalsDocumentViewModel
    {
        public ProfesionalsDocumentViewModel(ProfesionalsDocument incomingProfesionalsDocument)
        {
            id = incomingProfesionalsDocument.id;
            Discription = incomingProfesionalsDocument.Discription;
            DocumentPath = incomingProfesionalsDocument.DocumentPath;
            VissibleToFollowers = incomingProfesionalsDocument.VissibleToFollowers;
            VissibleToPublic = incomingProfesionalsDocument.VissibleToPublic;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Discription { get; set; }

        [Required]
        [StringLength(450)]
        public string DocumentPath { get; set; }

        public bool VissibleToPublic { get; set; }

        public bool VissibleToFollowers { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }
    }
}
