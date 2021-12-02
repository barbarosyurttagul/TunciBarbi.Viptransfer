using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        public void Add(T entity);

        
        
        public void Delete(T entity);


        public void Update(T entity);


        public List<T> GetAll();


        public string GetById(int id);
    }
}
