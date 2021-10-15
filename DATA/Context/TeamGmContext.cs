using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGM.DATA.Context
{
    public class TeamGmContext : DbContext
    {
        public TeamGmContext(DbContextOptions<TeamGmContext> options) : base(options) { }
    }
}
