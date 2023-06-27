using MediatRsession3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatRsession3.Models;
using Microsoft.AspNetCore.Components.Web;

namespace ProductAppTest
{
    public class ProductAppDbFixture
    {
        public AppDbContext _appDbContext;
        public ProductAppDbFixture( )
        {
            //give connection string for in memory data string.
            var productDbcontextOptions =new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("InMemoryDatabase").Options;
            _appDbContext = new AppDbContext(productDbcontextOptions);
            _appDbContext.Add(new Product() { Id=1,Name= "Mouse", Price=899});
            _appDbContext.Add(new Product() { Id=2,Name= "KeyBoard", Price=1299});
            _appDbContext.Add(new Product() { Id=3,Name= "Monitor", Price=1799});
            _appDbContext.Add(new Product() { Id=4,Name= "CPU", Price=33899});
            _appDbContext.SaveChanges();
        }
    }
}
