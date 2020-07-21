namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostPhotos")]
    public partial class PostPhoto
    {
        public Guid id { get; set; }

        public Guid? PostID { get; set; }

        public Guid? PhotoID { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual Post Post { get; set; }
    }
}
