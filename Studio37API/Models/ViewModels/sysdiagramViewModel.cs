namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdiagramViewModel
    {
        public sysdiagramViewModel(sysdiagram incomingsysdiagram)
        {
            name = incomingsysdiagram.name;
            principal_id = incomingsysdiagram.principal_id;
            diagram_id = incomingsysdiagram.diagram_id;
            version = incomingsysdiagram.version;
            definition = incomingsysdiagram.definition;
        }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }

        public int? version { get; set; }

        public byte[] definition { get; set; }
    }
}
