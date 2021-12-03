using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Abstract
{
    internal interface IDepartureDal : IEntityRepository<Departure>
    {
       Departure GetByName(string name);
    }
}
