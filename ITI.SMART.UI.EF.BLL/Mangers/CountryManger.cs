using ITI.smart.UI.EF.model;
using ITI.SMART.UI.EF.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.BLL.Mangers
{
    public class CountryManger : Repository<Country, Entities>
    {
        public CountryManger(Entities context) : base(context)
        {
        }
    }
}
