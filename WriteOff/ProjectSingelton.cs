using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteOff
{
    public  static class ProjectSingelton
    {
        public const string ConnectionString = "EquipmentWrite_OffConnectionString";
        public static DataContext db;
    }
}
