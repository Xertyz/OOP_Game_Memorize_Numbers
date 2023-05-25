using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemorizeNumbers
{
    public class GMNContext : DbContext
    {
        public GMNContext() : base("DBConnection") { }
        public DbSet<Result> Results { get; set; } = null!;
    }
}
