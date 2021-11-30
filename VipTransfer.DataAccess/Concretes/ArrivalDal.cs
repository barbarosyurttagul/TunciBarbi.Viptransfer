using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Concretes
{
    public class ArrivalDal
    {
        List<Arrival> arrivals = new List<Arrival>();
        public ArrivalDal()
        {
            arrivals.Add(new Arrival() { Id = 1, Name = "Antalya Havalimanı"});
            arrivals.Add(new Arrival { Id = 2, Name = "Gazipaşa" });
            arrivals.Add(new Arrival { Id = 3, Name = "Alanya" });
        }
        
        public void Ekle(Arrival arrival)
        {
            arrivals.Add(arrival);
        }

        public void Sil(Arrival arrival)
        {
            arrivals.Remove(arrival);
        }

        public void Update(Arrival arrival)
        {
            //LINQ
            var arrivalToUpdate = arrivals.Where(x => x.Id == arrival.Id).FirstOrDefault();
            arrivalToUpdate.Name = arrival.Name;
        }

        public List<Arrival> GetAll()
        {
            return arrivals;
        }

        public string GetById(int id)
        {
            var arrivalById = arrivals.Where(x => x.Id == id).FirstOrDefault(); 
            return arrivalById.Name;
        }
    }
}
