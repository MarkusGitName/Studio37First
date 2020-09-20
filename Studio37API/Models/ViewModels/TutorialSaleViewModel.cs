namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialSaleViewModel
    {
        public TutorialSaleViewModel(TutorialSale incomingTutorialSale)
        {
            id = incomingTutorialSale.id;
            TutorialID = incomingTutorialSale.TutorialID;
            SaleID = incomingTutorialSale.SaleID;

        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid SaleID { get; set; }

        // public virtual Sale Sale { get; set; }

        // public virtual Tutorial Tutorial { get; set; }
    }
}
