using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProfesionalsDocument
    {
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

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }
    }
}
