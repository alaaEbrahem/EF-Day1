using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.SMART.UI.EF.Repos;
using ITI.smart.UI.EF.model;

namespace ITI.SMART.UI.EF.BLL.Mangers
{
    public class CityManger : Repository<Country, Entities>
    {
       

        public CityManger(Entities context) : base(context)
        {
        }
    }
}
