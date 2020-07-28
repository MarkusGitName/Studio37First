using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Studio37Media.Server.Models.DataModels;

    public class ViewConext : DbContext
    {
        public ViewConext (DbContextOptions<ViewConext> options)
            : base(options)
        {
        }

        public DbSet<Studio37Media.Server.Models.DataModels.Profile> Profile { get; set; }
    }
