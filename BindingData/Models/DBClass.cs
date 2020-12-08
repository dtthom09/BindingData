using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BindingData.Models
{
    public class DBClass : DbContext
    {
        public DBClass(DbContextOptions<DBClass> options) : base(options)
        {

        }
        public DbSet<EmpClass> Students1 { get; set; }
    }
}
