using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core
{
    public class ApplictionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-AD4AI73\\MSSQLSERVER01;Initial Catalog=Ef Core;Integrated Security=True;");
        }
    }
}
