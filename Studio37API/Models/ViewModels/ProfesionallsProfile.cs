using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProfesionallsProfile
    {
        public ProfesionallsProfile()
        {
            LiveShows = new HashSet<LiveShow>();
            ProfesionalsDocuments = new HashSet<ProfesionalsDocument>();
            Sales = new HashSet<Sale>();
            Stickers = new HashSet<Sticker>();
            Tutorials = new HashSet<Tutorial>();
        }

        [StringLength(450)]
        public string UserID { get; set; }

        public int YearsExperience { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(450)]
        public string Logo { get; set; }

        [Required]
        [StringLength(350)]
        public string ProfesionalEmail { get; set; }

        public virtual ICollection<LiveShow> LiveShows { get; set; }

      //  public virtual Profile Profile { get; set; }

        public virtual ICollection<ProfesionalsDocument> ProfesionalsDocuments { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

         public virtual ICollection<Sticker> Stickers { get; set; }

        public virtual ICollection<Tutorial> Tutorials { get; set; }
    }
}
