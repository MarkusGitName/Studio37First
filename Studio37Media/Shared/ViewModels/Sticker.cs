using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Sticker
    {
        public Sticker()
        {
            StickerCattegories = new HashSet<StickerCattegory>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public int Grade { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<StickerCattegory> StickerCattegories { get; set; }
    }
}
