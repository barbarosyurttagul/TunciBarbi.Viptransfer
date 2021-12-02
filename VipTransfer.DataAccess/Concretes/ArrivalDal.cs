using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.DataAccess.Abstract;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Concretes
{
    public class ArrivalDal : IArrivalDal
    {
        List<Arrival> arrivals = new List<Arrival>();
        public ArrivalDal()
        {
            arrivals.Add(new Arrival() { Id = 1, Name = "Antalya Havalimanı"});
            arrivals.Add(new Arrival { Id = 2, Name = "Gazipaşa" });
            arrivals.Add(new Arrival { Id = 3, Name = "Alanya" });
        }

        public void Add(Arrival arrival)
        {
            arrivals.Add(arrival);
        }

        public void Delete(Arrival arrival)
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

        public Arrival GetByName(string name)
        {
            var arrivalByName = arrivals.Where(x => x.Name == name).FirstOrDefault();
            if(arrivalByName != null)
            {
                return arrivalByName;
            }
            
            var defaultArrivalByName = arrivals.Take<Arrival>(1).First();


            Console.WriteLine("Aradığınız lokasyon bulunamadı. Onun yerine bunu verelim");
            return defaultArrivalByName;
        }
    }
}
