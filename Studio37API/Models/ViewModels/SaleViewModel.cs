namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaleViewModel
    {
        public SaleViewModel(Sale incomingSale)
        {
            id = incomingSale.id;
            ProfesionalID = incomingSale.ProfesionalID;
            BuyerID = incomingSale.BuyerID;
            Amount = incomingSale.Amount;
            Credits = incomingSale.Credits;
            Date = incomingSale.Date;

            foreach(ClassVideoSale incomingClassVideoSales in incomingSale.ClassVideoSales)
            {
                ClassVideoSales.Add(new ClassVideoSaleViewModel(incomingClassVideoSales));
            }

            foreach(LiveShowSale incomingLiveShowSales in incomingSale.LiveShowSales)
            {
                LiveShowSales.Add(new LiveShowSaleViewModel(incomingLiveShowSales));
            }

            foreach(TutorialSale incomingTutorialSales in incomingSale.TutorialSales)
            {
                TutorialSales.Add(new TutorialSaleViewModel(incomingTutorialSales));
            }
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string ProfesionalID { get; set; }

        [Required]
        [StringLength(450)]
        public string BuyerID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int Credits { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual List<ClassVideoSaleViewModel> ClassVideoSales { get; set; }

        public virtual List<LiveShowSaleViewModel> LiveShowSales { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

       // public virtual Profile Profile { get; set; }

        public virtual List<TutorialSaleViewModel> TutorialSales { get; set; }
    }
}
