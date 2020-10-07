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
   

        public Guid id { get; set; }

        [Required]
        [StringLength(150,MinimumLength =1)]
        public string Category1 { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 1)]
        public string SubCategory { get; set; }


       public virtual List<ClassVideoCattegory> ClassVideoCattegories { get; set; }

        public virtual List<LiveShowCattegory> LiveShowCattegories { get; set; }

        public virtual List<PostCattegory> PostCattegories { get; set; }

        public virtual List<StickerCattegory> StickerCattegories { get; set; }

        public virtual List<TutorialCattegory> TutorialCattegories { get; set; }

        public virtual List<UserCattegory> UserCattegories { get; set; }
    }
}

