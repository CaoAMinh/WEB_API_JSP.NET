using iSmartMeter_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iSmartMeter_Project.Controllers
{
    public class StationsController : ApiController
    {
        public IEnumerable<Station> GetStation()
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.Stations.ToList();
            }
        }
        public Station GetStation(int id)
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.Stations.FirstOrDefault(sta => sta.id == id);
            }
        }

       
    }
   
}
