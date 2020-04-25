using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;

namespace JDSY.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {

        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

        public MyAirportContext(DbContextOptions<MyAirportContext> dbContextOptions)
            :base(dbContextOptions)
        {
        }
    }
}
