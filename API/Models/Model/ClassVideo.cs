using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ClassVideo
    {
        public ClassVideo()
        {
            ClassRatings = new HashSet<ClassRatings>();
            ClassVideoCattegory = new HashSet<ClassVideoCattegory>();
            ClassVideoSale = new HashSet<ClassVideoSale>();
            TutorialClasses = new HashSet<TutorialClasses>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string VideoPath { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [StringLength(450)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [StringLength(450)]
        public string VideoThumbnail { get; set; }

        [InverseProperty("ClassVideo")]
        public virtual ICollection<ClassRatings> ClassRatings { get; set; }
        [InverseProperty("ClassVideo")]
        public virtual ICollection<ClassVideoCattegory> ClassVideoCattegory { get; set; }
        [InverseProperty("ClassVideo")]
        public virtual ICollection<ClassVideoSale> ClassVideoSale { get; set; }
        [InverseProperty("ClassVideo")]
        public virtual ICollection<TutorialClasses> TutorialClasses { get; set; }
    }
}
