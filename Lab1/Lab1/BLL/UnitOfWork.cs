using BLL.Managers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork
    {
        private static EntityFramworkEntities context = new EntityFramworkEntities();
        private static UnitOfWork unitOfWork;
        private UnitOfWork() { }

        public static UnitOfWork Create()
        {
            if (unitOfWork == null)
            {
                unitOfWork = new UnitOfWork();
            }
            return unitOfWork;
        }
        public CityManger CityManger
        {
            get { return new CityManger(context); }
        }
        public CountryManger CountryManger
        {
            get { return new CountryManger(context); }
        }

    }
}
