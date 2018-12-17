using ProjetoWebLP4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoWebLP4.Context
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("DefaultConnection")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }

}

