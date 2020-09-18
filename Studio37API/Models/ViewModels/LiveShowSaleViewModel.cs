namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class LiveShowSaleViewModel
    {
        public LiveShowSaleViewModel(LiveShowSale incomingLiveShowSale)
        {
            id = incomingLiveShowSale.id;
            LiveShowID = incomingLiveShowSale.LiveShowID;
            SaleID = incomingLiveShowSale.SaleID;
        }

        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        public Guid SaleID { get; set; }

        // public virtual LiveShow LiveShow { get; set; }

        // public virtual Sale Sale { get; set; }
    }
}
