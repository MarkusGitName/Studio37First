using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class UserCattegory
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("CattegorryID")]
        public Guid? CattegorryId { get; set; }

        [ForeignKey(nameof(CattegorryId))]
        [InverseProperty(nameof(Categories.UserCattegory))]
        public virtual Categories Cattegorry { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.UserCattegory))]
        public virtual Profile User { get; set; }
    }
}
