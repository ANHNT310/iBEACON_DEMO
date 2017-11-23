using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary_iBeacon.Database;

namespace WcfServiceLibrary_iBeacon.DAL
{
    public class Device_DAL
    {
        iBeaconEntities _ctx = new iBeaconEntities();

        public List<BEACON_DEVICES> GetList()
        {
            return _ctx.BEACON_DEVICES.ToList();
        }

        public BEACON_DEVICES GetBeaconDevices(int id)
        {
            return _ctx.BEACON_DEVICES.FirstOrDefault(e => e.id == id);
        }

        public bool Create(BEACON_DEVICES obj)
        {
            try
            {
                _ctx.BEACON_DEVICES.Add(new BEACON_DEVICES
                {
                    BEACON_ID = Guid.NewGuid().ToString(),
                    BEACON_Name = obj.BEACON_Name,
                    BEACON_UUID = obj.BEACON_UUID,
                    BEACON_MAJOR = obj.BEACON_MAJOR,
                    BEACON_MINOR = obj.BEACON_MINOR,
                    IS_BROADCASTING = obj.IS_BROADCASTING,
                    SUBTITLE = obj.SUBTITLE,
                    SELLING_GLASS = obj.SELLING_GLASS,
                    ACTIVE = obj.ACTIVE,
                    STATUS = obj.STATUS
                });
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Update(BEACON_DEVICES obj)
        {
            try
            {
                var item = GetBeaconDevices(obj.id);
                if (item != null)
                {
                    item.BEACON_Name = obj.BEACON_Name;
                    item.BEACON_UUID = obj.BEACON_UUID;
                    item.BEACON_MAJOR = obj.BEACON_MAJOR;
                    item.BEACON_MINOR = obj.BEACON_MINOR;
                    item.IS_BROADCASTING = obj.IS_BROADCASTING;
                    item.SUBTITLE = obj.SUBTITLE;
                    item.SELLING_GLASS = obj.SELLING_GLASS;
                    item.ACTIVE = obj.ACTIVE;
                    item.STATUS = obj.STATUS;
                }
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
                Console.WriteLine(e);
                throw;
            }
        }

        public void delete(int id)
        {
            try
            {
                var item = GetBeaconDevices(id);
                if (item != null)
                {
                    _ctx.BEACON_DEVICES.Remove(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
