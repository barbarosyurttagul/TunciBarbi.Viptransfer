using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.DataAccess.Abstract;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Concretes
{
    public class DepartureDal : IDepartureDal
    {
        List<Departure> departures = new List<Departure>();
       

        public DepartureDal()
        {
            departures.Add(new Departure { Id = 1, Name = "Kaş"});
            departures.Add(new Departure { Id = 2, Name = "Alanya" });
            departures.Add(new Departure { Id = 3, Name = "Kalkab" });

        }

        public void Add(Departure departure)
        {
            departures.Add(departure);
        }

        public void Delete(Departure departure)
        {
            departures.Remove(departure);
        }

        public List<Departure> GetAll()
        {
            return departures;
        }

        public void Update(Departure departure)
        {
            var departureToUpdate = departures.Where(x => x.Id == departure.Id).FirstOrDefault();
            departureToUpdate.Name=departure.Name;

            
        }

        public string GetById(int id)
        {
            var departureById = departures.Where(x => x.Id == id).FirstOrDefault();
            
            return departureById.Name;
        }

       public Departure GetByName(string name)
        {
            var departureByName = departures.Where(x => x.Name == name).FirstOrDefault();
            if (departureByName != null)
               return departureByName;

            var defaultDepartureByName=departures.Take<Departure>(1).FirstOrDefault();

            Console.WriteLine("Aradığınız lokasyon bulunamadı. En yakın lokasyon: ");
#pragma warning disable CS8603 // Olası null başvuru dönüşü.
            return defaultDepartureByName;
#pragma warning restore CS8603 // Olası null başvuru dönüşü.
        }
    }

    


}
