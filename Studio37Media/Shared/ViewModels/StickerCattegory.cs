using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StickerCattegory
    {
        public Guid id { get; set; }

        public Guid StickeID { get; set; }

        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Sticker Sticker { get; set; }
    }
}
