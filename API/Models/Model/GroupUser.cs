using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class GroupUser
    {
        [Key]
        public Guid Groupid { get; set; }
        [Key]
        public string Userid { get; set; }

        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(Groups.GroupUser))]
        public virtual Groups Group { get; set; }
        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Profile.GroupUser))]
        public virtual Profile User { get; set; }
    }
}
