namespace Studio37API.Models.DataBaseMdels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            ClassVideoCattegories = new HashSet<ClassVideoCattegory>();
            LiveShowCattegories = new HashSet<LiveShowCattegory>();
            PostCattegories = new HashSet<PostCattegory>();
            StickerCattegories = new HashSet<StickerCattegory>();
            TutorialCattegories = new HashSet<TutorialCattegory>();
            UserCattegories = new HashSet<UserCattegory>();
        }

        public Guid id { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(150)]
        public string Category1 { get; set; }

        [Required]
        [StringLength(150)]
        public string SubCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassVideoCattegory> ClassVideoCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LiveShowCattegory> LiveShowCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostCattegory> PostCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StickerCattegory> StickerCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialCattegory> TutorialCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCattegory> UserCattegories { get; set; }
    }
}
