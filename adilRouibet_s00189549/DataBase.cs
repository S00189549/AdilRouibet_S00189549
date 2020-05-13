using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adilRouibet_s00189549
{
    public class PhonesDataBase : DbContext
    {
        public PhonesDataBase() : base("PhonesDataBase") { }

        public DbSet<Phone> phones { get; set; }

    }
}
