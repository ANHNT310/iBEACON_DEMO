using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary_iBeacon.Database;

namespace WcfServiceLibrary_iBeacon.DAL
{
    public class StoreType_DAL
    {
        iBeacon_Entities ctx = new iBeacon_Entities();

        public List<STORE_TYPE> GetList()
        {
            return ctx.STORE_TYPE.ToList();
        }

        public STORE_TYPE GetStoreType(int id)
        {
            return ctx.STORE_TYPE.FirstOrDefault(e => e.ID_STORE_TYPE == id);
        }
    }
}
