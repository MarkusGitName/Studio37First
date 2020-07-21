using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Categories
    {
        public Categories()
        {
            ClassVideoCattegory = new HashSet<ClassVideoCattegory>();
            PostCattegory = new HashSet<PostCattegory>();
            StickerCattegory = new HashSet<StickerCattegory>();
            TutorialCattegory = new HashSet<TutorialCattegory>();
            UserCattegory = new HashSet<UserCattegory>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string Category { get; set; }
        [StringLength(450)]
        public string SubCategory { get; set; }

        [InverseProperty("Cattegory")]
        public virtual ICollection<ClassVideoCattegory> ClassVideoCattegory { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostCattegory> PostCattegory { get; set; }
        [InverseProperty("Category")]
        public virtual ICollection<StickerCattegory> StickerCattegory { get; set; }
        [InverseProperty("Cattegory")]
        public virtual ICollection<TutorialCattegory> TutorialCattegory { get; set; }
        [InverseProperty("Cattegorry")]
        public virtual ICollection<UserCattegory> UserCattegory { get; set; }
    }
}
