namespace Studio37API.Models.DataBaseMdels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostClassVideo")]
    public partial class PostClassVideo
    {
        public Guid id { get; set; }

        public Guid PostId { get; set; }

        public Guid ClassVideoId { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Post Post { get; set; }
    }
}
