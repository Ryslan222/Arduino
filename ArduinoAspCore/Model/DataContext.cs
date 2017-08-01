using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArduinoAspCore.Model
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.10;Database=ArduinoWeb;Integrated Security=False;User ID=ArduinoWeb;Password=ArduinoWebQAZ");
        }
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        public DbSet<Data> Datas { get; set; }
    }
}
