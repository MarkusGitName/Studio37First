namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCattegory")]
    public partial class UserCattegory
    {
        public Guid id { get; set; }

        [StringLength(450)]
        public string UserID { get; set; }

        public Guid? CattegorryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
