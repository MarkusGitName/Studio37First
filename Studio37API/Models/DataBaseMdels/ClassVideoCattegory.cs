namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassVideoCattegory")]
    public partial class ClassVideoCattegoryViewModel
    {
        public ClassVideoCattegoryViewModel(ClassVideoCattegory incomigClassVideoCattegory)
        {
            ClassVideoID = incomigClassVideoCattegory.ClassVideoID;
            CattegoryID = incomigClassVideoCattegory.CattegoryID;
            id = incomigClassVideoCattegory.id;
        }
        public Guid ClassVideoID { get; set; }

        public Guid CattegoryID { get; set; }

        public Guid id { get; set; }

       // public virtual Category Category { get; set; }

       // public virtual ClassVideo ClassVideo { get; set; }
    }
}
