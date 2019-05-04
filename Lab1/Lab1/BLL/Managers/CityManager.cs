using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Repository;
using Model;

namespace BLL.Managers
{
    public class CityManger : Repository<City, EntityFramworkEntities>
    {

        public CityManger(EntityFramworkEntities context) : base(context)
        {
        }
    }
}
