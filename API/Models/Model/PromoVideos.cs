using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PromoVideos
    {
        public PromoVideos()
        {
            TutorialPromoVideo = new HashSet<TutorialPromoVideo>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string VideoPath { get; set; }

        [InverseProperty("PromoVideo")]
        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideo { get; set; }
    }
}
