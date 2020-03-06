using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Identity_Card.Models
{
    public class DbConnection:DbContext
    {
        public DbConnection() : base("Buletin")
        {

        }
        public DbSet<PersonDetails> Person { get; set; }    
    }
}