using CommanderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
    public class ComanderContext : DbContext
    {
        public ComanderContext(DbContextOptions<ComanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
