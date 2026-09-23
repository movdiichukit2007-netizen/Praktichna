using System.Collections.Generic;

namespace DeliveryApp
{
    public interface IRepository<T> where T : Model
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
