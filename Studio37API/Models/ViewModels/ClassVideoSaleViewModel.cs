namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassVideoSaleViewModel
    {
        public ClassVideoSaleViewModel(ClassVideoSale incomingClassVideoSale)
        {
            id = incomingClassVideoSale.id;
            ClassVideoID = incomingClassVideoSale.ClassVideoID;
            SaleID = incomingClassVideoSale.SaleID;
        }
        public Guid id { get; set; }

        public Guid ClassVideoID { get; set; }

        public Guid SaleID { get; set; }

        //public virtual ClassVideo ClassVideo { get; set; }

       // public virtual Sale Sale { get; set; }
    }
}
