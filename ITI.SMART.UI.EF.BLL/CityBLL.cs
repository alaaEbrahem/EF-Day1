using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.smart.UI.EF.model;

namespace ITI.SMART.UI.EF.BLL
{
    public class CityBLL
    {
        Entities context = new Entities();
        public List<City> getAll()
        {
            return context.Cities.ToList();
        }
    }
}
