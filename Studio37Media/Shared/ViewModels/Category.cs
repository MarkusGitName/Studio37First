using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Category
    {
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

        [Required]
        [StringLength(150,MinimumLength =1)]
        public string Category1 { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 1)]
        public string SubCategory { get; set; }


        public virtual ICollection<ClassVideoCattegory> ClassVideoCattegories { get; set; }

        public virtual ICollection<LiveShowCattegory> LiveShowCattegories { get; set; }

        public virtual ICollection<PostCattegory> PostCattegories { get; set; }

        public virtual ICollection<StickerCattegory> StickerCattegories { get; set; }

        public virtual ICollection<TutorialCattegory> TutorialCattegories { get; set; }

        public virtual ICollection<UserCattegory> UserCattegories { get; set; }
    }
}
