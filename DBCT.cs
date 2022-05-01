using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoesE.Models;
using Microsoft.EntityFrameworkCore;

namespace ShoesE
{
    public class DBCT : DbContext
    {
        public DBCT(DbContextOptions<DBCT> options) : base(options)
        {
        }

        public DbSet<Sanpham> SANPHAM { get; set; }
    }
}
