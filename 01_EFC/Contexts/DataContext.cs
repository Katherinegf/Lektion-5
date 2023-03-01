using _01_EFC.Models.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EFC.Contexts
{
    internal class DataContext : DbContext
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sagam\Documents\Utbildning\Datalagring\Lektion-5\01_EFC\Contects\Sql_db.mdf;Integrated Security=True;Connect Timeout=30";

        #region constructors 
        public DataContext()  //skapar en tom konstruktor
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        #endregion

        #region overrides
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //konfiguration av databaskopplingen, vilken connectionstring
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);
        }

        #endregion

        public DbSet<AddressEntity> Addresses { get; set; } = null!;    // DbSet är en lista men från EntityFramework
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

       
    }
}
