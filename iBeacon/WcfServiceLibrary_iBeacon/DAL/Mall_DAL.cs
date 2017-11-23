using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary_iBeacon.Database;

namespace WcfServiceLibrary_iBeacon.DAL
{
    public class Mall_DAL
    {
        iBeacon_Entities ctx = new iBeacon_Entities();

        public List<MALL> GetList()
        {
            return ctx.MALLs.ToList();
        }

        public MALL GetMallById(int id)
        {
            return ctx.MALLs.FirstOrDefault(e => e.ID == id);
        }

        public bool CreateBooking(MALL mall)
        {
            try
            {
                ctx.MALLs.Add(new MALL
                {
                    MALL_GUID = Guid.NewGuid().ToString(),
                    MALL_NAME = mall.MALL_NAME,
                    LOCATION_CODE = mall.LOCATION_CODE,
                    BEACON_ID = mall.BEACON_ID,
                    LAT = mall.LAT,
                    LONG = mall.LONG,
                    RADIUS = mall.RADIUS,
                    BROADCAST_ENABLE = mall.BROADCAST_ENABLE
                });
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateMall(MALL mall)
        {
            try
            {
                var item = GetMallById(mall.ID);
                if (item != null)
                {
                    item.MALL_NAME = mall.MALL_NAME;
                    item.LOCATION_CODE = mall.LOCATION_CODE;
                    item.BEACON_ID = mall.BEACON_ID;
                    item.LAT = mall.LAT;
                    item.LONG = mall.LONG;
                    item.RADIUS = mall.RADIUS;
                    item.BROADCAST_ENABLE = mall.BROADCAST_ENABLE;
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteMall(int id)
        {
            try
            {
                var item = GetMallById(id);
                if (item != null)
                {
                    ctx.MALLs.Remove(item);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
