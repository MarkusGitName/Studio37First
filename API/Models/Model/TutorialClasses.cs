using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialClasses
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        [Column("ClassVideoID")]
        public Guid? ClassVideoId { get; set; }

        [ForeignKey(nameof(ClassVideoId))]
        [InverseProperty("TutorialClasses")]
        public virtual ClassVideo ClassVideo { get; set; }
        [ForeignKey(nameof(TutorialId))]
        [InverseProperty(nameof(TutorialCattegory.TutorialClasses))]
        public virtual TutorialCattegory Tutorial { get; set; }
    }
}
