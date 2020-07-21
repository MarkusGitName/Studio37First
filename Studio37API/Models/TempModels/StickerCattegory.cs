namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StickerCattegory")]
    public partial class StickerCattegory
    {
        public Guid id { get; set; }

        public Guid? StickeID { get; set; }

        public Guid? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Sticker Sticker { get; set; }
    }
}
