using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialPromoVideo
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        [Column("PromoVideoID")]
        public Guid? PromoVideoId { get; set; }

        [ForeignKey(nameof(PromoVideoId))]
        [InverseProperty(nameof(PromoVideos.TutorialPromoVideo))]
        public virtual PromoVideos PromoVideo { get; set; }
        [ForeignKey(nameof(TutorialId))]
        [InverseProperty("TutorialPromoVideo")]
        public virtual Tutorial Tutorial { get; set; }
    }
}
