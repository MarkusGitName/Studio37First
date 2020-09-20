using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ClassVideoSale
    {
        public Guid id { get; set; }

        public Guid ClassVideoID { get; set; }

        public Guid SaleID { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
