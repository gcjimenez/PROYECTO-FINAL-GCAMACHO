using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DAL
{
    public class CLS_DBC_CINE : DbContext
    {
        public DbSet<CLS_SALA> SALA { get; set; }

    }
}
