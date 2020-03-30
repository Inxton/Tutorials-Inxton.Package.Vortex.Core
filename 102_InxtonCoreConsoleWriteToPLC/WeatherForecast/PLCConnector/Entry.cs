#define LOCAL // Comment if your target is remote

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace PLC
{
    public static class Entry
    {
#if LOCAL 
        const string AmsId = null; // your ams id or set to 'null' if local
        const int Port = 851;
#else
        const string AmsId = "172.20.10.2.1.1"; // set your target ams id
        const int Port = 851;
#endif 
        public static PLCTwinController Plc = new PLCTwinController(Tc3ConnectorAdapter.Create(AmsId, Port));
    }
}
