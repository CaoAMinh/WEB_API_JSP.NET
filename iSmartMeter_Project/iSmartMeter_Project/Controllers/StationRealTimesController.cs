using iSmartMeter_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iSmartMeter_Project.Controllers
{
    public class StationRealTimesController : ApiController
    {
        public IEnumerable<StationRealTime> GetStationRealTime()
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.StationRealTimes.ToList();
            }
        }
        public StationRealTime GetStationRealTime(int id)
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.StationRealTimes.FirstOrDefault(sta => sta.id == id);
            }
        }

        [HttpGet]
        [Route("api/stationrealtimes/consumption/{consumption}")]
        public List<StationRealTime> GetStationDataByConsumption(string consumption)
        {
            List<StationRealTime> list = new List<StationRealTime>();
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            { 
                list = dbContext.StationRealTimes.Where(sta => sta.consumption == consumption).ToList();
            }
            return list;
        }
    }
}
