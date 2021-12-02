using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Abstract
{
    public interface IArrivalDal : IEntityRepository<Arrival>
    {
        Arrival GetByName(string name);
        
        
    }
}
