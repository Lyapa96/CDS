using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSServer.Server
{
    public enum ResourceRecordType
    {
        A = 1,
        NS = 2,
        CNAME = 5,
        SOA = 6,
        PTR = 12,
        MX = 15
    }

    class ResourceRecord
    {
        public string Name { get; set; }
        public ResourceRecordType Type { get; set; }

    }
}
