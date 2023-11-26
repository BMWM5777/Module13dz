using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    class Client
    {
        public string Id { get; set; }
        public string ServiceType { get; set; }

        public Client(string id, string serviceType)
        {
            Id = id;
            ServiceType = serviceType;
        }
    }
}
