using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ITI.SMART.UI.EF.BLL.Mangers;
using ITI.smart.UI.EF.model;
using ITI.SMART.UI.EF.BLL;

namespace EF.Day1.Task
{
    class Program
    {
        static void Main(string[] args)
        {App_Start.EntityFrameworkProfilerBootstrapper.PreStart();


            UnitOfWork unit =  UnitOfWork.Create();
            unit.countryManger.Add(new Country { name="USA"});

        }
    }
}


