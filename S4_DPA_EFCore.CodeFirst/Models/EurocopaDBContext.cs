using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_DPA_EFCore.CodeFirst.Models
{
    public class EurocopaDBContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //var myConnectionString = "Server=MyServer;Database=EurocopaDB;User=XXX;Pwd=XXXX";
            var myConnectionString = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=EurocopaDB;Trusted_Connection=true;MultipleActiveResultSets=true";

            options
                .UseSqlServer(myConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(options);
        }        
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerPosition> PlayerPosition { get; set; } 


    }
}
