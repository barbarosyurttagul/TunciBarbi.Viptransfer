using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipTransfer.Entities.Concretes;

namespace VipTransfer.DataAccess.Concretes
{
    public class DepartureDal 
    {
        List<Departure> departures = new List<Departure>();
       

        public DepartureDal()
        {
            departures.Add(new Departure { Id=1, Name="Kaş"});
            departures.Add(new Departure { Id = 1, Name = "Alanya" });
            departures.Add(new Departure { Id = 1, Name = "Kalkab" });

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
    }

    depart


}
