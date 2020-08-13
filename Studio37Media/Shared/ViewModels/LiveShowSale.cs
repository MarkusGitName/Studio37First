using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LiveShowSale")]
    public partial class LiveShowSale
    {
        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        public Guid SaleID { get; set; }

        public virtual LiveShow LiveShow { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
