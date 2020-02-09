using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using MvcTask1.Models.Data;
using Domain;

namespace MvcTask1.Models.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ProfDTO> Profs { get; set; }

       
    }
}