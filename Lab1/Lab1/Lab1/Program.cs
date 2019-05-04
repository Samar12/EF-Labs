using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {App_Start.EntityFrameworkProfilerBootstrapper.PreStart();

            UnitOfWork u = UnitOfWork.Create();
          
            u.CountryManger.Add(new Country {
                Name = "USA"
            });


            Country x = u.CountryManger.GetById(1);
            x.Name = "Egypt";
            u.CountryManger.Update(x);


            Country y = u.CountryManger.GetById(1);
            u.CountryManger.Delete(y);

     


        }
    }
}

