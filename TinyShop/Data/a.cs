using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class a : IDesignTimeDbContextFactory<DataContext>
    {
        public a()
        {
        }

        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseMySql("server=localhost;user id=root;password=Whz123456,;database=tinyshop;charset=utf8;sslMode=None");
            return new DataContext(optionsBuilder.Options);
        }
    }
}
