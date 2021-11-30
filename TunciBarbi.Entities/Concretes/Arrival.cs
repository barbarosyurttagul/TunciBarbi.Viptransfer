using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.Entities.Abstract;

namespace VipTransfer.Entities.Concretes
{
    public class Arrival : Location
    {
        public Arrival()
        {

        }
        public Arrival(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
