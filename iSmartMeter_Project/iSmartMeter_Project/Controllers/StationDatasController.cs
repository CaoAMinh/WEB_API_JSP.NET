using iSmartMeter_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iSmartMeter_Project.Controllers
{
    public class StationDatasController : ApiController
    {
        public IEnumerable<StationData> GetStationData()
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.StationDatas.ToList();
            }
        }
        public StationData GetStationData(int id)
        {
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                return dbContext.StationDatas.FirstOrDefault(sta => sta.id == id);
            }
        }
        [HttpGet]
        [Route("api/stationdatas/normalized/{normalized}")]
        public List<StationData> GetStationDataByNormalized(string normalized)
        {
            List<StationData> list = new List<StationData>();
            iSmartMeterEntities1 dbContext;
            using (dbContext = new iSmartMeterEntities1())
            {
                list = dbContext.StationDatas.Where(sta => sta.normalized == normalized).ToList();
            }
            return list;
        }
    }
}
