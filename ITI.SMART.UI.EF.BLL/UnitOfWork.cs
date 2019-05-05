using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.SMART.UI.EF.BLL.Mangers;
using ITI.smart.UI.EF.model;
namespace ITI.SMART.UI.EF.BLL
{
    public class UnitOfWork
    {
        private static Entities context ;
        private static UnitOfWork unitofwork;
        private UnitOfWork()
        {
            context = new Entities();
        }
        public static UnitOfWork Create()
        {
            if (unitofwork == null)
            {
                unitofwork = new UnitOfWork();
            }
            return unitofwork;
        }
        public CityManger cityManger {
            get
            {
                return new CityManger(context);
            }
                
                }
        public CountryManger countryManger
        {
            get
            {
                return new CountryManger(context);
            }

        }
    }
}
