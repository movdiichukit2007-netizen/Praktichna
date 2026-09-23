using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryApp
{
    public class GenericRepository<T> : IRepository<T> where T : Model
    {
        private static readonly List<T> items = new List<T>();

        public void Add(T entity)
        {
            items.Add(entity);
            Console.WriteLine($"[Додано] ID: {entity.Id}");
        }

        public T GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public void Update(T entity)
        {
            int index = items.FindIndex(x => x.Id == entity.Id);
            if (index != -1)
            {
                items[index] = entity;
                Console.WriteLine($"[Оновлено] ID: {entity.Id}");
            }
            else
            {
                Console.WriteLine($"[Помилка] ID {entity.Id} не знайдено.");
            }
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"[Видалено] ID: {id}");
            }
            else
            {
                Console.WriteLine($"[Помилка] ID {id} не знайдено.");
            }
        }
    }
}
