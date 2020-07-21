using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ClassVideoCattegory
    {
        [Column("ClassVideoID")]
        public Guid ClassVideoId { get; set; }
        [Column("CattegoryID")]
        public Guid CattegoryId { get; set; }
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(CattegoryId))]
        [InverseProperty(nameof(Categories.ClassVideoCattegory))]
        public virtual Categories Cattegory { get; set; }
        [ForeignKey(nameof(ClassVideoId))]
        [InverseProperty("ClassVideoCattegory")]
        public virtual ClassVideo ClassVideo { get; set; }
    }
}
