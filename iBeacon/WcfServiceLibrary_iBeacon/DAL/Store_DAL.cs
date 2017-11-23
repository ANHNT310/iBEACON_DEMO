using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary_iBeacon.Database;

namespace WcfServiceLibrary_iBeacon.DAL
{
    public class Store_DAL
    {
        iBeacon_Entities ctx = new iBeacon_Entities();

        public List<IBEACON_STORES> GtList()
        {
            return ctx.IBEACON_STORES.ToList();
        }

        public IBEACON_STORES GetStores(int id)
        {
            return ctx.IBEACON_STORES.FirstOrDefault(e => e.ID_STORE == id);
        }

        public bool create(IBEACON_STORES obj)
        {
            try
            {
                ctx.IBEACON_STORES.Add(new IBEACON_STORES
                {
                    GUID = Guid.NewGuid().ToString(),
                    STORE_NAME = obj.STORE_NAME,
                    STORE_TYPE_ID = obj.STORE_TYPE_ID,
                    MALL_ID = obj.MALL_ID,
                    BROADCAST_ENABLE = obj.BROADCAST_ENABLE,
                    HOME_PAGE = obj.HOME_PAGE,
                });
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }

        public bool update(IBEACON_STORES obj)
        {
            try
            {
                var item = GetStores(obj.ID_STORE);
                if (item != null)
                {
                    item.STORE_NAME = obj.STORE_NAME;
                    item.STORE_TYPE_ID = obj.STORE_TYPE_ID;
                    item.MALL_ID = obj.MALL_ID;
                    item.BROADCAST_ENABLE = obj.BROADCAST_ENABLE;
                    item.HOME_PAGE = obj.HOME_PAGE;
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }

        public void delete(int id)
        {
            try
            {
                var item = GetStores(id);
                if (item != null)
                {
                    ctx.IBEACON_STORES.Remove(item);
                }
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
