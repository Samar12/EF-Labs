using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class CountryManger : Repository<Country, EntityFramworkEntities>
    {
        public CountryManger(EntityFramworkEntities context) : base(context)
        {
        }
    }
}
